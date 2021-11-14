// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.DSCNative
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Shell.Interop
{
  [SecurityCritical]
  internal static class DSCNative
  {
    [DllImport("dsclient.dll", CharSet = CharSet.Auto)]
    internal static extern uint DSCreateSharedFileToken(
      string pcwszFilePath,
      ref DSCNative.DS_SHARE_ACCESS_CONTROL pShareAccessControl,
      DSCNative.DS_TOKEN_LIFE_TIME_TYPE eTokenLifetime,
      DSCNative.DS_TOKEN_USAGE_TYPE eTokenUsage,
      out IntPtr ppwszTokenId);

    [DllImport("dsclient.dll", PreserveSig = false)]
    internal static extern uint DSCopyFromSharedFile([MarshalAs(UnmanagedType.LPWStr)] string tokenId, [MarshalAs(UnmanagedType.LPWStr)] string destFilePath);

    [DllImport("dsclient.dll", PreserveSig = false)]
    internal static extern uint DSGetSharedFileName([MarshalAs(UnmanagedType.LPWStr)] string tokenId, out IntPtr ppwszFileName);

    internal enum DS_SHARE_PERMISSION
    {
      DS_SHARE_PERMISSION_READ,
      DS_SHARE_PERMISSION_WRITE,
      DS_SHARE_PERMISSION_READWRITE,
    }

    internal enum DS_SHARE_MODE
    {
      DS_SHARE_MODE_EXCLUSIVE,
      DS_SHARE_MODE_READ,
      DS_SHARE_MODE_WRITE,
      DS_SHARE_MODE_READWRITE,
    }

    internal enum DS_SHARE_TARGET_TYPE
    {
      DS_SHARE_TARGET_SID,
      DS_SHARE_TARGET_ID,
    }

    internal enum DS_TOKEN_USAGE_TYPE
    {
      DS_TOKEN_CONSUME,
      DS_TOKEN_DELEGATE,
    }

    internal struct DS_SHARE_SCOPE
    {
      internal uint cShareTargets;
      internal DSCNative.DS_SHARE_TARGET pShareTargets;
    }

    internal struct DS_SHARE_TARGET
    {
      internal DSCNative.DS_SHARE_TARGET_TYPE eShareTargetType;
      [MarshalAs(UnmanagedType.LPWStr)]
      internal string pcwszShareTarget;
    }

    internal struct DS_SHARE_ACCESS_CONTROL
    {
      public DSCNative.DS_SHARE_PERMISSION eSharePermission;
      public DSCNative.DS_SHARE_MODE eShareMode;
      public DSCNative.DS_SHARE_SCOPE ssShareScope;
    }

    internal enum DS_TOKEN_LIFE_TIME_TYPE
    {
      DS_TOKEN_LIFE_TIME_SHORT,
      DS_TOKEN_LIFE_TIME_LONG,
    }
  }
}
