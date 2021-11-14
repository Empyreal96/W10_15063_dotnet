// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.OSNativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecurityCritical]
  internal static class OSNativeMethods
  {
    internal const int ERROR_SUCCESS = 0;
    private const string ComApiSet = "api-ms-win-core-com-l1-1-0.dll";
    private const string RegistryApiSet = "api-ms-win-core-registry-l1-1-0.dll";
    internal const string SN_PHONEOPERATORNAME_PATH = "System\\State\\Phone";
    internal const string SN_PHONEOPERATORNAME_VALUE = "Current Operator Name";
    internal const uint ERROR_FILE_NOT_FOUND = 2;
    internal const int ERROR_INVALID_HANDLE = 6;

    [DllImport("api-ms-win-core-registry-l1-1-0.dll", CharSet = CharSet.Unicode)]
    internal static extern int RegOpenKeyEx(
      [In] OSNativeMethods.HKey hkey,
      [In] string szSubKey,
      [In] int dwOptions,
      [In] int samDesired,
      out RegKeySafeHandle phkResult);

    [DllImport("api-ms-win-core-registry-l1-1-0.dll", CharSet = CharSet.Unicode)]
    public static extern int RegQueryValueEx(
      RegKeySafeHandle hKey,
      [In] string lpValueName,
      IntPtr reserved,
      ref int lpType,
      byte[] lpData,
      ref int lpcbData);

    [DllImport("api-ms-win-core-registry-l1-1-0.dll", SetLastError = true)]
    public static extern int RegCloseKey(IntPtr hkey);

    [DllImport("api-ms-win-core-com-l1-1-0.dll")]
    internal static extern void CoTaskMemFree([In] IntPtr ptr);

    internal enum RegValueType
    {
      REG_NONE = 0,
      REG_STRING = 1,
      REG_BINARY = 3,
      REG_DWORD = 4,
      REG_DWORD_LITTLE_ENDIAN = 4,
      REG_DWORD_BIG_ENDIAN = 5,
      REG_MULTI_SZ = 7,
    }

    internal enum HKey
    {
      CLASSES_ROOT = -2147483648, // 0x80000000
      CURRENT_USER = -2147483647, // 0x80000001
      LOCAL_MACHINE = -2147483646, // 0x80000002
      USERS = -2147483645, // 0x80000003
    }
  }
}
