// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Logging.Logger
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.ComponentModel;
using System.Security;

namespace Microsoft.Phone.Logging
{
  [SecuritySafeCritical]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class Logger
  {
    private const uint ApiVersion = 2;

    [SecuritySafeCritical]
    private static bool IsLogEnabled(uint SubSytemOrKPI, LogFlags logFlags) => NativeMethods.IsLogEnabled(SubSytemOrKPI, (uint) logFlags);

    [SecuritySafeCritical]
    [CLSCompliant(false)]
    public static void YLogEvent(
      uint subsystemOrKpiId,
      uint eventCode,
      LogFlags logFlags,
      byte[] dataBlob)
    {
      if (!Logger.IsLogEnabled(subsystemOrKpiId, logFlags))
        return;
      int num1 = (int) subsystemOrKpiId;
      int num2 = (int) eventCode;
      int num3 = (int) logFlags;
      byte[] pData = dataBlob;
      int length = (int) (ushort) pData.Length;
      NativeMethods.LogEventCore((uint) num1, (uint) num2, (uint) num3, pData, (ushort) length);
    }

    [SecuritySafeCritical]
    [CLSCompliant(false)]
    public static void YLogEvent(
      uint subsystemOrKpiId,
      uint eventCode,
      LogFlags logFlags,
      uint dataValue)
    {
      if (!Logger.IsLogEnabled(subsystemOrKpiId, logFlags))
        return;
      NativeMethods.LogEventUInt32Core(subsystemOrKpiId, eventCode, (uint) logFlags, dataValue);
    }

    [SecuritySafeCritical]
    [CLSCompliant(false)]
    public static void YLogEvent(
      uint subsystemOrKpiId,
      uint eventCode,
      LogFlags logFlags,
      ulong dataValue)
    {
      if (!Logger.IsLogEnabled(subsystemOrKpiId, logFlags))
        return;
      NativeMethods.LogEventUInt64Core(subsystemOrKpiId, (ulong) eventCode, (uint) logFlags, dataValue);
    }

    [CLSCompliant(false)]
    [SecuritySafeCritical]
    public static void YLogEvent(
      uint subsystemOrKpiId,
      uint eventCode,
      LogFlags logFlags,
      string message)
    {
      if (!Logger.IsLogEnabled(subsystemOrKpiId, logFlags))
        return;
      int num1 = (int) subsystemOrKpiId;
      int num2 = (int) eventCode;
      int num3 = (int) (logFlags | LogFlags.StringBlob);
      string pData = message;
      int num4 = (int) (ushort) (pData.Length * 2);
      NativeMethods.LogStringEventCore((uint) num1, (uint) num2, (uint) num3, pData, (ushort) num4);
    }

    [SecuritySafeCritical]
    [CLSCompliant(false)]
    public static uint GetEventLevelAndFlags(
      uint subsystemOrKpiId,
      LogFlags logFlags,
      ref uint eventFlags)
    {
      return NativeMethods.GetEventLevelAndFlags(subsystemOrKpiId, (uint) logFlags, ref eventFlags);
    }

    [SecuritySafeCritical]
    public static void LaunchApp_EndDuration() => NativeMethods.LaunchApp_EndDuration();

    public delegate void Delegate();
  }
}
