// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.NativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Devices
{
  [SecurityCritical]
  internal static class NativeMethods
  {
    [DllImport("PlatformInterop.dll")]
    public static extern int Vibrate();

    [DllImport("PlatformInterop.dll")]
    public static extern int Stop();

    [DllImport("PlatformInterop.dll", PreserveSig = false)]
    public static extern int BeginManagingVibration(
      out VibrationResourceManagerHandle vibrationHandle);

    [DllImport("PlatformInterop.dll")]
    public static extern void StopManagingVibration(ref IntPtr vibrationHandle);
  }
}
