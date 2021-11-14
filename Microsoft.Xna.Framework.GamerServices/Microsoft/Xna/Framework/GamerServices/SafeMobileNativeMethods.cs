// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.SafeMobileNativeMethods
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal static class SafeMobileNativeMethods
  {
    [SecuritySafeCritical]
    internal static uint GameFoundation_Init() => MobileNativeMethods.GameFoundation_Init();

    [SecuritySafeCritical]
    internal static void GameFoundation_Shutdown() => MobileNativeMethods.GameFoundation_Shutdown();

    [SecuritySafeCritical]
    internal static uint GameFoundation_GetGamerProfile(
      string gamertag,
      out uint hStream,
      out uint hPicutreGroup)
    {
      return MobileNativeMethods.GameFoundation_GetGamerProfile(gamertag, out hStream, out hPicutreGroup);
    }

    [SecuritySafeCritical]
    internal static bool GameFoundation_IsSignedIn() => MobileNativeMethods.GameFoundation_IsSignedIn();

    [SecuritySafeCritical]
    internal static uint GameFoundation_GetAchievements(out uint hStream, out uint hPicutreGroup) => MobileNativeMethods.GameFoundation_GetAchievements(out hStream, out hPicutreGroup);

    [SecuritySafeCritical]
    internal static uint GameFoundation_GrantAchievement(uint dwAchievementKey) => MobileNativeMethods.GameFoundation_GrantAchievement(dwAchievementKey);

    [SecuritySafeCritical]
    internal static uint GameFoundation_AuthenticatedRequest(
      GfServiceType eService,
      string pszRequestUri,
      GfRequestMethod eVerb,
      string pszPostData,
      out uint handle)
    {
      return MobileNativeMethods.GameFoundation_AuthenticatedRequest(eService, pszRequestUri, eVerb, pszPostData, out handle);
    }

    [SecuritySafeCritical]
    internal static uint GameFoundation_Request(string pszRequestUri, out uint handle) => MobileNativeMethods.GameFoundation_Request(pszRequestUri, out handle);

    [SecuritySafeCritical]
    internal static string GameFoundation_GetTokenString(string audienceUri)
    {
      StringBuilder stringBuilder = new StringBuilder(8192);
      uint num1 = 0;
      string empty = string.Empty;
      string audienceUri1 = audienceUri;
      StringBuilder buffer1 = stringBuilder;
      int capacity1 = buffer1.Capacity;
      ref uint local1 = ref num1;
      uint num2 = MobileNativeMethods.GameFoundation_GetTokenString(audienceUri1, buffer1, (uint) capacity1, ref local1);
      if (num2 == 2147942522U)
      {
        stringBuilder = new StringBuilder((int) num1);
        num2 = 0U;
        string audienceUri2 = audienceUri;
        StringBuilder buffer2 = stringBuilder;
        int capacity2 = buffer2.Capacity;
        ref uint local2 = ref num1;
        ErrorHandler.ThrowExceptionFromResult(MobileNativeMethods.GameFoundation_GetTokenString(audienceUri2, buffer2, (uint) capacity2, ref local2));
      }
      if (num2 == 0U)
        empty = stringBuilder.ToString();
      return empty;
    }

    [SecuritySafeCritical]
    internal static GamerPrivilegeOptions GameFoundation_DownloadGamerPrivilegeOptions()
    {
      GamerPrivilegeOptions privileges;
      ErrorHandler.ThrowExceptionFromResult(MobileNativeMethods.GameFoundation_DownloadGamerPrivilegeOptions(out privileges));
      return privileges;
    }

    [SecuritySafeCritical]
    internal static bool GameFoundation_GetCurrentGamerPrivilegeOptions(
      out GamerPrivilegeOptions privileges)
    {
      bool hasValidPrivileges;
      ErrorHandler.ThrowExceptionFromResult(MobileNativeMethods.GameFoundation_GetCurrentGamerPrivilegeOptions(out privileges, out hasValidPrivileges));
      return hasValidPrivileges;
    }

    [SecuritySafeCritical]
    internal static unsafe void GameFoundation_PostGameResult(
      uint variant,
      long rating,
      bool isScore,
      LeaderboardOutcome outcome,
      byte[] blob)
    {
      IntPtr num = IntPtr.Zero;
      uint cbBlob = 0;
      GCHandle gcHandle = new GCHandle();
      if (blob != null)
      {
        gcHandle = GCHandle.Alloc((object) blob, GCHandleType.Pinned);
        cbBlob = (uint) blob.Length;
        num = gcHandle.AddrOfPinnedObject();
      }
      try
      {
        ErrorHandler.ThrowExceptionFromResult(MobileNativeMethods.GameFoundation_PostGameResult(variant, rating, isScore, outcome, num.ToPointer(), cbBlob));
      }
      finally
      {
        if (gcHandle.IsAllocated)
          gcHandle.Free();
      }
    }

    [SecuritySafeCritical]
    internal static void GameFoundation_FlushGameResultPosts() => ErrorHandler.ThrowExceptionFromResult(MobileNativeMethods.GameFoundation_FlushGameResultPosts());

    [SecuritySafeCritical]
    internal static uint GameFoundation_GetPictureStream(
      uint hPictureGroup,
      string url,
      out uint hStream)
    {
      return MobileNativeMethods.GameFoundation_GetPictureStream(hPictureGroup, url, out hStream);
    }

    [SecuritySafeCritical]
    internal static uint GameFoundation_ReleasePictureGroup(uint hPictureGroup) => MobileNativeMethods.GameFoundation_ReleasePictureGroup(hPictureGroup);

    [SecuritySafeCritical]
    internal static uint IStream_Read(uint hStream, [In, Out] byte[] buffer, uint count, out uint pcbRead) => MobileNativeMethods.IStream_Read(hStream, buffer, count, out pcbRead);

    [SecuritySafeCritical]
    internal static uint IStream_Close(uint hStream) => MobileNativeMethods.IStream_Close(hStream);
  }
}
