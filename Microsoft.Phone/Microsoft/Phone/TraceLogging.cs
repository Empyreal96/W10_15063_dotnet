﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TraceLogging
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Diagnostics;

namespace Microsoft.Phone
{
  internal static class TraceLogging
  {
    private const string _preFix = "Microsoft.Phone";

    [Conditional("DEBUG")]
    internal static void LogMessage(string message) => string.IsNullOrEmpty(message);

    [Conditional("DEBUG")]
    internal static void LogMessage(string format, params object[] args)
    {
    }
  }
}
