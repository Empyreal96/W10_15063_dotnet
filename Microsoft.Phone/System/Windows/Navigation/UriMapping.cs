// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.UriMapping
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace System.Windows.Navigation
{
  public sealed class UriMapping
  {
    private static readonly Regex _conversionRegex = new Regex("(?<ConversionCapture>{.*?})", RegexOptions.ExplicitCapture);
    private Uri _uri;
    private Uri _mappedUri;
    private Regex _uriRegex;
    private bool _uriRegexIdentifierUsedTwice;
    private bool _uriHasQueryString;
    private bool _uriHasFragment;
    private bool _mappedUriIsOnlyFragment;
    private bool _mappedUriIsOnlyQueryString;
    private List<string> _uriIdentifiers;
    private List<string> _mappedUriIdentifiers;
    private bool _initialized;

    public Uri Uri
    {
      get => this._uri;
      set
      {
        this._uri = value;
        this._initialized = false;
      }
    }

    public Uri MappedUri
    {
      get => this._mappedUri;
      set
      {
        this._mappedUri = value;
        this._initialized = false;
      }
    }

    private bool UriTemplateContainsSameIdentifierTwice(Uri uri, out Regex uriRegex)
    {
      if (uri == (Uri) null)
      {
        uriRegex = (Regex) null;
        return false;
      }
      string originalString = uri.OriginalString;
      MatchCollection matchCollection = UriMapping._conversionRegex.Matches(originalString);
      this._uriIdentifiers = new List<string>();
      foreach (Capture capture in matchCollection)
      {
        string str = capture.Value.Replace("{", string.Empty).Replace("}", string.Empty);
        if (this._uriIdentifiers.Contains(str))
        {
          uriRegex = (Regex) null;
          return true;
        }
        this._uriIdentifiers.Add(str);
      }
      string str1 = UriMapping._conversionRegex.Replace(originalString, "(?<$1>.*?)").Replace("{", string.Empty).Replace("}", string.Empty);
      uriRegex = new Regex("^" + str1 + "$");
      return false;
    }

    private void GetIdentifiersForMappedUri(Uri mappedUri)
    {
      string originalString = mappedUri.OriginalString;
      MatchCollection matchCollection = UriMapping._conversionRegex.Matches(originalString);
      this._mappedUriIdentifiers = new List<string>();
      foreach (Capture capture in matchCollection)
      {
        string str = capture.Value.Replace("{", string.Empty).Replace("}", string.Empty);
        if (!this._mappedUriIdentifiers.Contains(str))
          this._mappedUriIdentifiers.Add(str);
      }
    }

    private void Initialize()
    {
      Regex uriRegex = (Regex) null;
      this._uriRegexIdentifierUsedTwice = this.UriTemplateContainsSameIdentifierTwice(this._uri, out uriRegex);
      this._uriHasQueryString = !string.IsNullOrEmpty(UriParsingHelper.InternalUriGetQueryString(this._uri));
      this._uriHasFragment = !string.IsNullOrEmpty(UriParsingHelper.InternalUriGetFragment(this._uri));
      this._uriRegex = uriRegex;
      this._mappedUriIsOnlyFragment = UriParsingHelper.InternalUriIsFragment(this._mappedUri);
      this._mappedUriIsOnlyQueryString = "?" + UriParsingHelper.InternalUriGetQueryString(this._mappedUri) == this._mappedUri.OriginalString;
      this.GetIdentifiersForMappedUri(this._mappedUri);
      this._initialized = true;
    }

    public Uri MapUri(Uri uri)
    {
      this.CheckPreconditions();
      if (this._uriRegex == null)
        return uri == (Uri) null || uri.OriginalString == null || uri.OriginalString.Length == 0 ? new Uri(this._mappedUri.OriginalString, UriKind.Relative) : (Uri) null;
      Match match = this._uriRegex.Match(UriParsingHelper.InternalUriGetBaseValue(uri));
      if (!match.Success)
        return (Uri) null;
      string uriBase = UriParsingHelper.InternalUriGetBaseValue(this._mappedUri);
      IDictionary<string, string> stringToDictionary1 = UriParsingHelper.InternalUriParseQueryStringToDictionary(this._mappedUri, false);
      IDictionary<string, string> stringToDictionary2 = UriParsingHelper.InternalUriParseQueryStringToDictionary(uri, false);
      string fragment1 = UriParsingHelper.InternalUriGetFragment(uri);
      string fragment2 = UriParsingHelper.InternalUriGetFragment(this._mappedUri);
      IDictionary<string, string> dictionary = (IDictionary<string, string>) new Dictionary<string, string>();
      int count = match.Groups.Count;
      for (int index = 1; index < count; ++index)
        dictionary.Add(this._uriRegex.GroupNameFromNumber(index), match.Groups[index].Value);
      foreach (string mappedUriIdentifier in this._mappedUriIdentifiers)
      {
        string oldValue = "{" + mappedUriIdentifier + "}";
        string newValue = dictionary.ContainsKey(mappedUriIdentifier) ? dictionary[mappedUriIdentifier] : string.Empty;
        uriBase = uriBase.Replace(oldValue, newValue);
        string[] array = new string[stringToDictionary1.Keys.Count];
        stringToDictionary1.Keys.CopyTo(array, 0);
        foreach (string key in array)
        {
          if (stringToDictionary1[key].Contains(oldValue) && dictionary.ContainsKey(mappedUriIdentifier))
            stringToDictionary1[key] = stringToDictionary1[key].Replace(oldValue, newValue);
          if (key.Contains(oldValue))
          {
            string str = stringToDictionary1[key];
            stringToDictionary1.Remove(key);
            stringToDictionary1.Add(key.Replace(oldValue, newValue), str);
          }
        }
        if (string.IsNullOrEmpty(fragment1) && !string.IsNullOrEmpty(fragment2) && fragment2.Contains(oldValue))
          fragment2 = fragment2.Replace(oldValue, newValue);
      }
      foreach (string key in (IEnumerable<string>) stringToDictionary2.Keys)
      {
        if (!stringToDictionary1.ContainsKey(key))
          stringToDictionary1.Add(key, stringToDictionary2[key]);
        else
          stringToDictionary1[key] = stringToDictionary2[key];
      }
      if (!string.IsNullOrEmpty(fragment1))
        fragment2 = fragment1;
      return UriParsingHelper.InternalUriCreateWithQueryStringValues(uriBase, stringToDictionary1, fragment2);
    }

    private void CheckPreconditions()
    {
      if (this._mappedUri == (Uri) null)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.UriMapping_TemplateMustBeSpecified, (object) "MappedUri"));
      if (!this._initialized)
        this.Initialize();
      if (this._uriHasQueryString)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.UriMapping_UriTemplateCannotHaveAQueryString, (object) "Uri"));
      if (this._uriHasFragment)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.UriMapping_UriTemplateCannotHaveAFragment, (object) "Uri"));
      if (this._uriRegexIdentifierUsedTwice)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.UriMapping_UriTemplateCannotContainTheSameIdentifierMoreThanOnce, (object) "Uri"));
      if (this._mappedUriIsOnlyFragment)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.UriMapping_MappedUriCannotBeOnlyFragment, (object) "MappedUri"));
      if (this._mappedUriIsOnlyQueryString)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.UriMapping_MappedUriCannotBeOnlyQueryString, (object) "MappedUri"));
    }
  }
}
