// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.MeuxHelper
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Tasks
{
  internal class MeuxHelper
  {
    public static ParameterPropertyBag BuildParameterPropertyBag(
      Dictionary<string, string> arguments)
    {
      ParameterPropertyBag parameterPropertyBag = new ParameterPropertyBag();
      foreach (KeyValuePair<string, string> keyValuePair in arguments)
        parameterPropertyBag.CreateProperty(keyValuePair.Key).StringValue = keyValuePair.Value;
      return parameterPropertyBag;
    }

    public static Uri MakeLitePlayerUri(string relative) => new Uri("mswindowsvideo://" + relative, UriKind.Absolute);

    public static Uri MakeMarketplaceUri(string relative) => new Uri("ms-windows-store://" + relative, UriKind.Absolute);

    public static Uri MakeXboxMusicUri(string relative) => new Uri("xboxmusic://" + relative, UriKind.Absolute);
  }
}
