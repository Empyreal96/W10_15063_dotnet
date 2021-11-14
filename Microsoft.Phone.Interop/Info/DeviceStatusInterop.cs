// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Info.DeviceStatusInterop
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Info
{
  internal sealed class DeviceStatusInterop
  {
    public const int S_OK = 0;
    public const int COR_E_FILENOTFOUND = -2147024894;

    [SecurityCritical]
    public static long GetMemoryUsageLimit()
    {
      ulong outvalue;
      DeviceStatusInterop.GetResourceManagementValue(DeviceStatusInterop.ResourceManagementValue.RMV_MEMORYCAP, out outvalue);
      return (long) outvalue;
    }

    [SecurityCritical]
    [DllImport("PlatformInterop.dll")]
    public static extern int StartSubscriptionCallback(
      DeviceTypes deviceType,
      IntPtr pfnCallback,
      ref IntPtr phNotify);

    [SecurityCritical]
    [DllImport("PlatformInterop.dll")]
    public static extern int StopSubscriptionCallback(IntPtr hNotify);

    [SecurityCritical]
    [DllImport("PlatformInterop.dll")]
    public static extern int SubscriptionInitialize();

    [DllImport("PlatformInterop.dll")]
    public static extern int GetResourceManagementValue(
      DeviceStatusInterop.ResourceManagementValue rmv,
      out ulong outvalue);

    [SecurityCritical]
    [DllImport("PlatformInterop.dll")]
    public static extern int GetCurrentValue(DeviceTypes deviceType, ref int dwData);

    public enum ResourceManagementValue
    {
      RMV_MEMORYCAP = 6,
    }
  }
}
