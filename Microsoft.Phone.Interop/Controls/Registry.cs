// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.Registry
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Controls
{
  [SecuritySafeCritical]
  internal class Registry
  {
    public const uint LocalMachineKey = 2147483650;
    public const int REG_DWORD = 4;
    public const int KEY_QUERY_VALUE = 1;

    public static bool QueryDwordValue(
      uint rootKey,
      string keyName,
      string valueName,
      ref uint propertyValue)
    {
      bool flag = false;
      IntPtr zero = IntPtr.Zero;
      if (Registry.OpenKey(rootKey, keyName, ref zero) == 0)
      {
        flag = Registry.QueryDwordValue(zero, valueName, ref propertyValue);
        Registry.CloseKey(zero);
      }
      return flag;
    }

    private static int OpenKey(uint rootKey, string keyName, ref IntPtr newKey) => RegistryNativeMethods.NativeRegOpenKey(new IntPtr((int) rootKey), keyName, 0, 1, ref newKey);

    private static bool QueryDwordValue(IntPtr key, string valueName, ref uint propertyValue)
    {
      bool flag = false;
      int dwType = 0;
      int lpcbData = 4;
      byte[] lpData = new byte[lpcbData];
      if (RegistryNativeMethods.NativeRegQueryValue(key, valueName, 0, ref dwType, lpData, ref lpcbData) == 0 && dwType == 4)
      {
        propertyValue = BitConverter.ToUInt32(lpData, 0);
        flag = true;
      }
      return flag;
    }

    private static int CloseKey(IntPtr openedKey) => RegistryNativeMethods.NativeRegCloseKey(openedKey);
  }
}
