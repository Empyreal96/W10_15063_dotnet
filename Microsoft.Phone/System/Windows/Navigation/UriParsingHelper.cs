// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.UriParsingHelper
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;

namespace System.Windows.Navigation
{
  internal static class UriParsingHelper
  {
    internal const string QueryStringDelimiter = "?";
    private const string ValueDelimiter = "=";
    private const string StatePairDelimiter = "&";
    private const string FragmentDelimiter = "#";
    private const string PathSeparator = "/";
    private const string HttpLocalhost = "http://localhost";
    private const string ExternalFragmentDelimiter = "$";
    private const string ExternalFragmentDelimiterPercentEncoded = "%24";
    internal const string ComponentDelimiter = ";component/";
    internal const string ComponentDelimiterWithoutSlash = ";component";
    internal static readonly int ComponentDelimiterWithoutSlashLength = ";component".Length;

    private static Uri MakeAbsolute(Uri baseUri) => baseUri == (Uri) null || baseUri.OriginalString.StartsWith("/", StringComparison.Ordinal) ? new Uri("http://localhost" + (object) baseUri, UriKind.Absolute) : new Uri("http://localhost/" + (object) baseUri, UriKind.Absolute);

    private static Uri MakeAbsolute(string originalString) => originalString == null || originalString.StartsWith("/", StringComparison.Ordinal) ? new Uri("http://localhost" + originalString, UriKind.Absolute) : new Uri("http://localhost/" + originalString, UriKind.Absolute);

    internal static string InternalUriToExternalValue(Uri uri)
    {
      Uri uri1 = UriParsingHelper.MakeAbsolute(uri);
      UriComponents components = UriComponents.Path;
      if (uri != (Uri) null && uri.OriginalString.StartsWith("/", StringComparison.Ordinal))
        components |= UriComponents.KeepDelimiter;
      string str1 = uri1.GetComponents(components, UriFormat.UriEscaped).Replace("$"[0].ToString(), "%24");
      string str2 = uri1.GetComponents(UriComponents.Query, UriFormat.UriEscaped).Replace("$"[0].ToString(), "%24");
      string str3 = uri1.GetComponents(UriComponents.Fragment, UriFormat.UriEscaped).Replace("$"[0].ToString(), "%24");
      string str4 = str1;
      if (!string.IsNullOrEmpty(str2))
        str4 = str4 + "?" + str2;
      if (!string.IsNullOrEmpty(str3))
        str4 = str4 + "$" + str3;
      return str4;
    }

    internal static string InternalUriFromExternalValue(string externalVal)
    {
      string str = UriParsingHelper.MakeAbsolute(externalVal.Replace("$", "#").Replace("%24", "$")).GetComponents(UriComponents.PathAndQuery | UriComponents.Fragment, UriFormat.SafeUnescaped);
      if (!externalVal.StartsWith("/", StringComparison.Ordinal))
        str = str.Substring(1);
      return str;
    }

    internal static Uri InternalUriMerge(Uri baseUri, Uri newUri)
    {
      Guard.ArgumentNotNull((object) newUri, nameof (newUri));
      if (baseUri == (Uri) null)
        baseUri = new Uri(string.Empty, UriKind.Relative);
      if (!UriParsingHelper.InternalUriIsFragment(newUri))
        return newUri;
      if (baseUri.OriginalString.StartsWith("/", StringComparison.Ordinal))
        return new Uri(UriParsingHelper.InternalUriGetAllButFragment(baseUri) + newUri.OriginalString, UriKind.Relative);
      string str = UriParsingHelper.InternalUriGetAllButFragment(baseUri);
      if (!string.IsNullOrEmpty(str))
        str = str.Substring(1);
      return new Uri(str + newUri.OriginalString, UriKind.Relative);
    }

    internal static bool InternalUriIsNavigable(Uri uri)
    {
      if (!(uri != (Uri) null))
        return false;
      return UriParsingHelper.InternalUriIsFragment(uri) || UriParsingHelper.InternalUriIsRelativeToAppRoot(uri) || UriParsingHelper.InternalUriIsRelativeWithComponent(uri) || string.IsNullOrEmpty(uri.OriginalString);
    }

    internal static bool InternalUriIsRelativeToAppRoot(Uri uri) => !uri.IsAbsoluteUri && uri.OriginalString.StartsWith("/", StringComparison.Ordinal) && !uri.OriginalString.Contains(";component/");

    internal static bool InternalUriIsRelativeWithComponent(Uri uri)
    {
      if (uri.OriginalString.Length < 1 || uri.IsAbsoluteUri || !uri.OriginalString.StartsWith("/", StringComparison.OrdinalIgnoreCase))
        return false;
      string str = uri.ToString();
      int startIndex = 0;
      if ((int) str[0] == (int) "/"[0])
        startIndex = 1;
      int num = str.IndexOf("/"[0], startIndex);
      return num > 0 && str.Substring(startIndex, num - startIndex).EndsWith(";component", StringComparison.OrdinalIgnoreCase);
    }

    internal static bool InternalUriIsFragment(Uri uri) => uri != (Uri) null && !uri.IsAbsoluteUri && !string.IsNullOrEmpty(uri.OriginalString) && uri.OriginalString.StartsWith("#", StringComparison.Ordinal);

    internal static string InternalUriGetFragment(Uri uri) => UriParsingHelper.MakeAbsolute(uri).GetComponents(UriComponents.Fragment, UriFormat.Unescaped);

    internal static string InternalUriGetAllButFragment(Uri uri)
    {
      if (uri != (Uri) null && string.IsNullOrEmpty(uri.OriginalString))
        return string.Empty;
      UriComponents components = UriComponents.PathAndQuery;
      if (uri != (Uri) null && uri.OriginalString.StartsWith("/", StringComparison.Ordinal))
        components |= UriComponents.KeepDelimiter;
      return UriParsingHelper.MakeAbsolute(uri).GetComponents(components, UriFormat.SafeUnescaped);
    }

    internal static string InternalUriGetQueryString(Uri uri) => UriParsingHelper.MakeAbsolute(uri).GetComponents(UriComponents.Query, UriFormat.SafeUnescaped);

    internal static string InternalUriGetBaseValue(Uri uri)
    {
      UriComponents components = UriComponents.Path;
      if (uri.OriginalString.StartsWith("/", StringComparison.Ordinal))
        components |= UriComponents.KeepDelimiter;
      return UriParsingHelper.MakeAbsolute(uri).GetComponents(components, UriFormat.SafeUnescaped);
    }

    internal static IDictionary<string, string> InternalUriParseQueryStringToDictionary(
      Uri uri,
      bool decodeResults)
    {
      IDictionary<string, string> dictionary = (IDictionary<string, string>) new Dictionary<string, string>((IEqualityComparer<string>) StringComparer.Ordinal);
      foreach (string str in UriParsingHelper.InternalUriGetQueryString(uri).Split("&".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
      {
        int length = str.IndexOf("=", StringComparison.Ordinal);
        if (length == -1)
          dictionary.Add(decodeResults ? HttpUtility.UrlDecode(str) : str, string.Empty);
        else
          dictionary.Add(decodeResults ? HttpUtility.UrlDecode(str.Substring(0, length)) : str.Substring(0, length), decodeResults ? HttpUtility.UrlDecode(str.Substring(length + 1)) : str.Substring(length + 1));
      }
      return dictionary;
    }

    internal static Uri InternalUriCreateWithQueryStringValues(
      string uriBase,
      IDictionary<string, string> queryStringValues,
      string fragment)
    {
      StringBuilder stringBuilder1 = new StringBuilder(200).Append(uriBase);
      if (queryStringValues.Count > 0)
      {
        StringBuilder stringBuilder2 = stringBuilder1.Append("?");
        foreach (string key in (IEnumerable<string>) queryStringValues.Keys)
          stringBuilder2 = stringBuilder2.AppendFormat((IFormatProvider) CultureInfo.InvariantCulture, "{0}{1}{2}{3}", (object) key, (object) "="[0], (object) queryStringValues[key], (object) "&"[0]);
        StringBuilder stringBuilder3 = stringBuilder2;
        stringBuilder1 = stringBuilder3.Remove(stringBuilder3.Length - 1, 1);
      }
      if (!string.IsNullOrEmpty(fragment))
        stringBuilder1.AppendFormat((IFormatProvider) CultureInfo.InvariantCulture, "{0}{1}", (object) "#", (object) fragment);
      return new Uri(stringBuilder1.ToString(), UriKind.Relative);
    }
  }
}
