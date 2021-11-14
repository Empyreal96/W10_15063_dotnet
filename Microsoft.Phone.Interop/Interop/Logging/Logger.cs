// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Interop.Logging.Logger
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.ComponentModel;
using System.Globalization;
using System.Security;

namespace Microsoft.Phone.Interop.Logging
{
  [SecuritySafeCritical]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal static class Logger
  {
    private const uint ApiVersion = 2;

    [SecuritySafeCritical]
    private static bool IsLogEnabled(uint SubSytemOrKPI, LogFlags logFlags) => NativeMethods.IsLogEnabled(SubSytemOrKPI, (uint) logFlags);

    [SecuritySafeCritical]
    internal static void YLogEvent(
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
    internal static void YLogEvent(
      uint subsystemOrKpiId,
      uint eventCode,
      LogFlags logFlags,
      string format,
      params object[] args)
    {
      if (!Logger.IsLogEnabled(subsystemOrKpiId, logFlags))
        return;
      string str = string.Format((IFormatProvider) CultureInfo.InvariantCulture, format, args);
      int num1 = (int) subsystemOrKpiId;
      int num2 = (int) eventCode;
      int num3 = (int) (logFlags | LogFlags.StringBlob);
      string pData = str;
      int num4 = (int) (ushort) (pData.Length * 2);
      NativeMethods.LogStringEventCore((uint) num1, (uint) num2, (uint) num3, pData, (ushort) num4);
    }
  }
}
