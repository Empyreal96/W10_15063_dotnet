// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.PerfUtil
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Logging;

namespace System.Windows.Navigation
{
  internal class PerfUtil
  {
    internal static void BeginLogMarker(MarkerEvents EventCode, string Message) => PerfUtil.LogPerfMarker(LogFlags.Health | LogFlags.MemoryStats | LogFlags.BeginMarker, EventCode, Message);

    internal static void EndLogMarker(MarkerEvents EventCode, string Message) => PerfUtil.LogPerfMarker(LogFlags.Health | LogFlags.MemoryStats | LogFlags.EndMarker, EventCode, Message);

    internal static void InfoLogMarker(MarkerEvents EventCode, string Message) => PerfUtil.LogPerfMarker(LogFlags.Health | LogFlags.MemoryStats, EventCode, Message);

    private static void LogPerfMarker(LogFlags logFlag, MarkerEvents EventCode, string Message) => Logger.YLogEvent(2147483654U, (uint) EventCode, logFlag, Message);
  }
}
