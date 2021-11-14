// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ShellToast
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.IO;
using System.Security;
using System.Text;

namespace Microsoft.Phone.Shell
{
  [SecuritySafeCritical]
  public class ShellToast
  {
    private const int MaxTitleLength = 64;
    private const int MaxContentLength = 256;
    private const char PageNameSeparator = '#';
    private const string TitlePropertyName = "Title";
    private const string ContentPropertyName = "Content";
    private const string NavigationUriPropertyName = "NavigationUri";
    private const string SoundPropertyName = "Sound";
    private const string SilentFileName = "*silent*";
    private const string ShellContentRoot = "Shared\\ShellContent\\";
    private string _title;
    private string _content;
    private Uri _navigationUri;
    private Uri _soundUri;

    public string Title
    {
      get => this._title;
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (Title));
        this._title = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentOutOfRangeException(nameof (Title));
      }
    }

    public string Content
    {
      get => this._content;
      set => this._content = value != null ? value : throw new ArgumentNullException(nameof (Content));
    }

    public Uri NavigationUri
    {
      get => this._navigationUri;
      set => this._navigationUri = !(value != (Uri) null) || !value.IsAbsoluteUri ? value : throw new ArgumentOutOfRangeException(nameof (NavigationUri));
    }

    public Uri Sound
    {
      get => this._soundUri;
      set => this._soundUri = value;
    }

    public void Show()
    {
      if (string.IsNullOrWhiteSpace(this.Title))
        throw new InvalidOperationException("Title is null or empty");
      LocalNotificationInterop.LNTaskInfo lnTaskInfo = new LocalNotificationInterop.LNTaskInfo();
      if (LocalNotificationInterop.LNGetAppTaskInfo(ref lnTaskInfo) < 0 || lnTaskInfo.IsAppInForeground != 0)
        return;
      StringBuilder stringBuilder = lnTaskInfo.IsXAMLLightup == 0 ? new StringBuilder(lnTaskInfo.AppBaseUri) : new StringBuilder();
      if (this.NavigationUri != (Uri) null)
      {
        if (this.NavigationUri.ToString().IndexOf('/') == 0)
        {
          if (stringBuilder.ToString().IndexOf('#') == -1)
            stringBuilder.Append('#');
          stringBuilder.Append(this.NavigationUri.ToString());
        }
        else
        {
          if (this.NavigationUri.ToString().IndexOf('?') != 0)
            throw new UriFormatException();
          stringBuilder.Append(this.NavigationUri.ToString());
        }
      }
      Uri uri = (Uri) null;
      if (lnTaskInfo.IsXAMLLightup == 0)
        uri = new Uri(stringBuilder.ToString(), UriKind.Absolute);
      string soundFileUri = string.Empty;
      if (this.Sound != (Uri) null)
      {
        if (this.Sound.OriginalString.Equals(string.Empty))
        {
          soundFileUri = "*silent*";
        }
        else
        {
          ApplicationHost current = ApplicationHost.Current;
          string fullPath = Path.GetFullPath(current.GetFileSystemPath(this.Sound.OriginalString));
          if (fullPath.IndexOfAny(Path.GetInvalidPathChars()) != -1)
            throw new ArgumentException("file-path contains invalid characters", "Sound");
          if (!File.Exists(fullPath))
            throw new FileNotFoundException(this.Sound.OriginalString);
          if (this.Sound.IsAbsoluteUri && string.CompareOrdinal(this.Sound.Scheme, "isostore") == 0 && !fullPath.StartsWith(Path.Combine(current.AppIsolatedStorePath, "Shared\\ShellContent\\"), StringComparison.OrdinalIgnoreCase))
            throw new NotSupportedException(this.Sound.ToString());
          soundFileUri = fullPath;
        }
      }
      LocalNotificationInterop.MessageToastData mtData = new LocalNotificationInterop.MessageToastData(lnTaskInfo.ProductId, lnTaskInfo.IsXAMLLightup == 0 ? uri.ToString() : stringBuilder.ToString(), soundFileUri);
      if (this.Title.Length > 64)
        mtData.Content = this.Title.Substring(0, 64);
      else
        mtData.Title = this.Title;
      mtData.Content = this.Content.Length <= 256 ? this.Content : this.Content.Substring(0, 256);
      LocalNotificationInterop.SHPostMessageToast(ref mtData);
    }
  }
}
