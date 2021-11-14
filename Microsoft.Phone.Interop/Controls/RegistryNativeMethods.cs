// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.RegistryNativeMethods
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Controls
{
  internal class RegistryNativeMethods
  {
    [SecurityCritical]
    [DllImport("PlatformInterop.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int NativeRegOpenKey(
      IntPtr hKey,
      string lpSubKey,
      int ulOptions,
      int samDesired,
      ref IntPtr phkResult);

    [SecurityCritical]
    [DllImport("PlatformInterop.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int NativeRegQueryValue(
      IntPtr hKey,
      string lpValueName,
      int reserved,
      ref int dwType,
      byte[] lpData,
      ref int lpcbData);

    [SecurityCritical]
    [DllImport("PlatformInterop.dll", SetLastError = true)]
    public static extern int NativeRegCloseKey(IntPtr hKey);
  }
}
