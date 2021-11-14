// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.DSC
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Shell.Interop
{
  [SecuritySafeCritical]
  internal static class DSC
  {
    public static string DSCreateSharedFileTokenManaged(string FilePath)
    {
      string str = (string) null;
      IntPtr ppwszTokenId = IntPtr.Zero;
      DSCNative.DS_SHARE_ACCESS_CONTROL pShareAccessControl;
      pShareAccessControl.eSharePermission = DSCNative.DS_SHARE_PERMISSION.DS_SHARE_PERMISSION_READ;
      pShareAccessControl.eShareMode = DSCNative.DS_SHARE_MODE.DS_SHARE_MODE_READ;
      pShareAccessControl.ssShareScope.cShareTargets = 1U;
      pShareAccessControl.ssShareScope.pShareTargets.eShareTargetType = DSCNative.DS_SHARE_TARGET_TYPE.DS_SHARE_TARGET_ID;
      pShareAccessControl.ssShareScope.pShareTargets.pcwszShareTarget = "RingtonesAndSounds";
      uint sharedFileToken = DSCNative.DSCreateSharedFileToken(FilePath, ref pShareAccessControl, DSCNative.DS_TOKEN_LIFE_TIME_TYPE.DS_TOKEN_LIFE_TIME_SHORT, DSCNative.DS_TOKEN_USAGE_TYPE.DS_TOKEN_CONSUME, out ppwszTokenId);
      if (sharedFileToken != 0U)
        throw new ArgumentException(sharedFileToken.ToString("X"));
      if (ppwszTokenId != IntPtr.Zero)
        str = Marshal.PtrToStringUni(ppwszTokenId);
      return str;
    }

    public static string DSGetSharedFileNameManaged(string tokenId)
    {
      string str = (string) null;
      IntPtr ppwszFileName = IntPtr.Zero;
      uint sharedFileName = DSCNative.DSGetSharedFileName(tokenId, out ppwszFileName);
      if (sharedFileName != 0U)
        throw new ArgumentException(sharedFileName.ToString("X"));
      if (ppwszFileName != IntPtr.Zero)
        str = Marshal.PtrToStringUni(ppwszFileName);
      return str;
    }
  }
}
