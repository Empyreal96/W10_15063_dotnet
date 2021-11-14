// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.WebBrowserTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;

namespace Microsoft.Phone.Tasks
{
  public sealed class WebBrowserTask
  {
    private const string WebBrowserAppUri = "http:";
    private string _URL;
    private Uri _uri;

    [Obsolete("Please use Uri property")]
    public string URL
    {
      get => this._URL;
      set
      {
        if (this.Uri != (Uri) null)
          throw new InvalidOperationException("Cannot set URL while Uri is already set.");
        this._URL = value;
      }
    }

    public Uri Uri
    {
      get => this._uri;
      set
      {
        if (!value.IsAbsoluteUri || value.Scheme != Uri.UriSchemeHttp && value.Scheme != Uri.UriSchemeHttps)
          throw new ArgumentOutOfRangeException("Uri has to be absolute and only http/https is allowed.");
        this._URL = Uri.EscapeDataString(value.AbsoluteUri);
        this._uri = value;
      }
    }

    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      Uri appUri = this.BuildUri();
      if (!(appUri != (Uri) null))
        return;
      ChooserHelper.LaunchSession(appUri, new ParameterPropertyBag());
    }

    internal Uri BuildUri()
    {
      Uri result = (Uri) null;
      if (this._uri != (Uri) null)
        result = this._uri;
      else if (this._URL != null)
      {
        string uriString = QuirksMode.ShouldUseWeakDecodingForWebBrowserTask() ? WebBrowserTask.DecodePercentEncodedCharacters(this._URL) : Uri.UnescapeDataString(this._URL);
        Uri.TryCreate(uriString, UriKind.Absolute, out result);
        if (result == (Uri) null && !uriString.ToLower().StartsWith("http://") && !uriString.ToLower().StartsWith("https://"))
          Uri.TryCreate("http://" + uriString, UriKind.Absolute, out result);
      }
      else
        result = new Uri("http:", UriKind.RelativeOrAbsolute);
      return result;
    }

    private static string DecodePercentEncodedCharacters(string s)
    {
      string empty = string.Empty;
      for (int index = 0; index < s.Length; ++index)
      {
        if (s[index] == '%' && index < s.Length - 2 && (WebBrowserTask.IsHex(s[index + 1]) && WebBrowserTask.IsHex(s[index + 2])))
        {
          empty += ((char) (16 * WebBrowserTask.HexToInt(s[index + 1]) + WebBrowserTask.HexToInt(s[index + 2]))).ToString();
          index += 2;
        }
        else
          empty += s[index].ToString();
      }
      return empty;
    }

    private static bool IsHex(char c)
    {
      if (c >= '0' && c <= '9' || c >= 'a' && c <= 'f')
        return true;
      return c >= 'A' && c <= 'F';
    }

    private static int HexToInt(char c)
    {
      if (c >= '0' && c <= '9')
        return (int) c - 48;
      if (c >= 'A' && c <= 'F')
        return (int) c - 65 + 10;
      return c >= 'a' && c <= 'f' ? (int) c - 97 + 10 : -1;
    }
  }
}
