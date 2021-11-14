// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.LaunchParameters
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.Windows.Navigation;

namespace Microsoft.Xna.Framework
{
  public class LaunchParameters : Dictionary<string, string>
  {
    public LaunchParameters()
    {
      Uri uri1 = new Uri(ApplicationHost.Current.Uri, UriKind.RelativeOrAbsolute);
      Uri uri2 = new Uri(UriParsingHelper.InternalUriGetFragment(uri1), UriKind.RelativeOrAbsolute);
      if (!string.IsNullOrEmpty(uri2.OriginalString))
        this.ParseQueryStringArguments(uri2);
      else
        this.ParseQueryStringArguments(uri1);
    }

    internal void ParseQueryStringArguments(Uri uri)
    {
      IDictionary<string, string> stringToDictionary = UriParsingHelper.InternalUriParseQueryStringToDictionary(uri, true);
      if (stringToDictionary == null)
        return;
      foreach (KeyValuePair<string, string> keyValuePair in (IEnumerable<KeyValuePair<string, string>>) stringToDictionary)
        this.Add(keyValuePair.Key, keyValuePair.Value);
    }
  }
}
