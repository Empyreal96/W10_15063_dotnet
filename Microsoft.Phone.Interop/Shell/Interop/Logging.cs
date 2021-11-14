// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.Logging
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Diagnostics;

namespace Microsoft.Phone.Shell.Interop
{
  internal static class Logging
  {
    private const string _preFix = "Microsoft.Phone.Shell.Interop";

    [Conditional("DEBUG")]
    internal static void LogMessage(string message)
    {
      if (string.IsNullOrEmpty(message))
        return;
      Console.WriteLine(string.Format("{0}: {1}", (object) "Microsoft.Phone.Shell.Interop", (object) message));
    }

    [Conditional("DEBUG")]
    internal static void LogMessage(string format, params object[] args)
    {
    }
  }
}
