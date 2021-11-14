// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Interop.Logging.NativeMethods
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Interop.Logging
{
  internal class NativeMethods
  {
    [SecurityCritical]
    [DllImport("YPerfHealthLogger.dll", EntryPoint = "YLogEvent", SetLastError = true)]
    internal static extern bool LogEventCore(
      uint dwSubsystemOrKpiId,
      uint dwEventCode,
      uint dwLogModeFlags,
      byte[] pData,
      ushort cbSize);

    [SecurityCritical]
    [DllImport("YPerfHealthLogger.dll", EntryPoint = "YLogEvent", SetLastError = true)]
    internal static extern bool LogStringEventCore(
      uint dwSubsystemOrKpiId,
      uint dwEventCode,
      uint dwLogModeFlags,
      [MarshalAs(UnmanagedType.LPWStr)] string pData,
      ushort cbSize);

    [SecurityCritical]
    [DllImport("YPerfHealthLogger.dll", EntryPoint = "YLogEventUInt32", SetLastError = true)]
    internal static extern bool LogEventUInt32Core(
      uint dwSubsystemOrKpiId,
      uint dwEventCode,
      uint dwLogModeFlags,
      uint dwEventData);

    [SecurityCritical]
    [DllImport("YPerfHealthLogger.dll", EntryPoint = "YLogEventUInt64", SetLastError = true)]
    internal static extern bool LogEventUInt64Core(
      uint dwSubsystemOrKpiId,
      ulong dwEventCode,
      uint dwLogModeFlags,
      ulong qwEventData);

    [SecuritySafeCritical]
    [DllImport("YPerfHealthLogger.dll", EntryPoint = "YIsLoggingEnabled", SetLastError = true)]
    internal static extern bool IsLogEnabled(uint dwSubsystemOrKpiId, uint dwLogFlags);

    [SecuritySafeCritical]
    [DllImport("YPerfHealthLogger.dll", EntryPoint = "YGetEventLevelAndFlags", SetLastError = true)]
    internal static extern uint GetEventLevelAndFlags(
      uint dwSubsystemOrKpiId,
      uint dwLogFlags,
      ref uint dwEventFlags);

    [SecuritySafeCritical]
    [DllImport("YPerfHealthLogger.dll", SetLastError = true)]
    internal static extern void LaunchApp_EndDuration();
  }
}
