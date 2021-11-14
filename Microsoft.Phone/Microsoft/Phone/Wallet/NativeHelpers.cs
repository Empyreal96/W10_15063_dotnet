// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.NativeHelpers
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Wallet
{
  internal static class NativeHelpers
  {
    internal static bool IsFailedHr(int hr) => hr < 0;

    [SecuritySafeCritical]
    internal static void IfFailedHrThrowException(int hr)
    {
      if (NativeHelpers.IsFailedHr(hr))
      {
        if (hr <= -2147024841)
        {
          if (hr == -2147024891)
            throw new UnauthorizedAccessException("Access requires ID_CAP_WALLET (and perhaps also ID_CAP_WALLET_PAYMENTINSTRUMENTS) to be defined in the manifest");
          if (hr == -2147024846)
            throw new NotSupportedException();
          if (hr == -2147024841)
            throw new IOException();
        }
        else if (hr <= -2147019873)
        {
          if (hr == -2147023436)
            throw new TimeoutException();
          if (hr == -2147019873)
            throw new InvalidOperationException();
        }
        else
        {
          if (hr == -2143682560)
            throw new KeyNotFoundException();
          if (hr == -2143682556)
            throw new ArgumentOutOfRangeException();
        }
        throw Marshal.GetExceptionForHR(hr);
      }
    }

    internal static void IfFailedHrThrowExceptionWithCapabilityName(int hr, string CapabilityName)
    {
      if (hr == -2147024891)
        throw new UnauthorizedAccessException("Access requires " + CapabilityName + " to be defined in the manifest");
      NativeHelpers.IfFailedHrThrowException(hr);
    }

    internal enum HResult
    {
      E_ACCESSDENIED = -2147024891, // 0x80070005
      ERROR_NOT_SUPPORTED = -2147024846, // 0x80070032
      ERROR_DEV_NOT_EXIST = -2147024841, // 0x80070037
      ERROR_TIMEOUT = -2147023436, // 0x800705B4
      ERROR_INVALID_STATE = -2147019873, // 0x8007139F
      E_RW_NOTFOUND = -2143682560, // 0x803A0000
      E_RW_INSUFFICIENT_BUFFER = -2143682556, // 0x803A0004
      S_OK = 0,
    }
  }
}
