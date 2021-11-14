// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Info.Registry
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Info
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

    private static int OpenKey(uint rootKey, string keyName, ref IntPtr newKey) => NativeMethods.NativeRegOpenKey(new IntPtr((int) rootKey), keyName, 0, 1, ref newKey);

    private static bool QueryDwordValue(IntPtr key, string valueName, ref uint propertyValue)
    {
      bool flag = false;
      int dwType = 0;
      int lpcbData = 4;
      byte[] lpData = new byte[lpcbData];
      if (NativeMethods.NativeRegQueryValue(key, valueName, 0, ref dwType, lpData, ref lpcbData) == 0 && dwType == 4)
      {
        propertyValue = BitConverter.ToUInt32(lpData, 0);
        flag = true;
      }
      return flag;
    }

    private static int CloseKey(IntPtr openedKey) => NativeMethods.NativeRegCloseKey(openedKey);
  }
}
