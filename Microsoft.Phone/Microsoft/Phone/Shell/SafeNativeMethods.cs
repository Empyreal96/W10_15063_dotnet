// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.SafeNativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Shell
{
  [SecurityCritical]
  internal sealed class SafeNativeMethods
  {
    internal const int S_OK = 0;
    internal const int S_FALSE = 1;
    private const int E_OUTOFMEMORY = -2147024882;
    private const int E_INVALIDARG = -2147024809;
    private const int E_HANDLE = -2147024890;
    private const int E_NOTIMPL = -2147467263;
    private const int E_PM_LIVETOKEN_URI_INVALID = -2130509545;
    internal const int E_PM_CREATE_TILE_RESTRICTED = -2130509534;
    private const int E_PM_ERROR_SEEK = -2147024871;
    private const int E_ACCESSDENIED = -2147024891;
    internal const int E_PM_TILE_VERSION_CONFLICT = -2147024599;

    internal static void ThrowExceptionFromHResult(int hr) => SafeNativeMethods.ThrowExceptionFromHResult(hr, (Exception) new InvalidOperationException());

    [SuppressMessage("Microsoft.Usage", "CA2208")]
    internal static void ThrowExceptionFromHResult(int hr, Exception defaultException)
    {
      if (hr <= -2147024871)
      {
        if (hr <= -2147024891)
        {
          if (hr == -2147467263)
            throw new NotSupportedException();
          if (hr == -2147024891)
            goto label_16;
          else
            goto label_17;
        }
        else if (hr != -2147024890)
        {
          if (hr == -2147024882 || hr == -2147024871)
            throw new InvalidOperationException();
          goto label_17;
        }
      }
      else if (hr <= -2130509545)
      {
        if (hr != -2147024809)
        {
          if (hr == -2130509545)
            throw new ArgumentException(LocalizeString.ShellInvalidUri);
          goto label_17;
        }
      }
      else if (hr != -2130509534)
      {
        if (hr == 0 || hr == 1)
          return;
        goto label_17;
      }
      else
        goto label_16;
      throw new ArgumentException("E_INVALIDARG");
label_16:
      throw new InvalidOperationException(LocalizeString.CreateTileRestricted);
label_17:
      throw defaultException;
    }

    private SafeNativeMethods()
    {
    }

    [DllImport("coredll.dll", SetLastError = true)]
    internal static extern IntPtr LocalFree(IntPtr hMem);

    [DllImport("WpnPhoneExt.dll")]
    internal static extern int ParseInputXML(
      [MarshalAs(UnmanagedType.LPWStr)] string message,
      ref TokenPropertiesForTile tokenProperties);

    [DllImport("PlatformInterop.dll")]
    internal static extern int BNSIUpdateExpiryTime();

    [SecuritySafeCritical]
    [DllImport("PlatformInterop.dll")]
    internal static extern int IsAppRunningInLockdownMode(out bool fIsInLockdownMode);

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    internal static extern int ShellTileCreate(Guid productId, ref TileStoreTile tile);

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    internal static extern int ShellTileUpdate(Guid productId, ref TileStoreTile tile);

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    internal static extern int ShellTileDelete(Guid productId, [MarshalAs(UnmanagedType.LPWStr)] string tileId);

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    internal static extern int ShellTileExists(Guid productId, [MarshalAs(UnmanagedType.LPWStr)] string tileId, out bool exists);

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    internal static extern int ShellTileTryGet(
      Guid productId,
      [MarshalAs(UnmanagedType.LPWStr)] string tileId,
      out IntPtr tile,
      out bool found);

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    internal static extern int ShellTileGetAll(Guid productId, out IntPtr tiles, out uint count);

    [DllImport("PlatformInterop.dll")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool IsTileStoreReadEnabled();

    [DllImport("PlatformInterop.dll")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool IsTileStoreWriteEnabled();
  }
}
