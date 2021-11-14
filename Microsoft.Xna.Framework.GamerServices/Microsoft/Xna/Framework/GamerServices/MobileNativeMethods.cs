// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.MobileNativeMethods
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal static class MobileNativeMethods
  {
    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_Init")]
    internal static extern uint GameFoundation_Init();

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_Shutdown")]
    internal static extern void GameFoundation_Shutdown();

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_GetGamerProfile")]
    internal static extern uint GameFoundation_GetGamerProfile(
      [MarshalAs(UnmanagedType.LPWStr)] string gamertag,
      out uint hStream,
      out uint hPicutreGroup);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_IsSignedIn")]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool GameFoundation_IsSignedIn();

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_GrantAchievement")]
    internal static extern uint GameFoundation_GrantAchievement(uint dwAchievementKey);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_GetAchievements")]
    internal static extern uint GameFoundation_GetAchievements(
      out uint hStream,
      out uint hPicutreGroup);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_AuthenticatedRequest")]
    internal static extern uint GameFoundation_AuthenticatedRequest(
      GfServiceType eService,
      [MarshalAs(UnmanagedType.LPWStr)] string pszRequestUri,
      GfRequestMethod eVerb,
      [MarshalAs(UnmanagedType.LPWStr)] string pszPostData,
      out uint handle);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_Request")]
    internal static extern uint GameFoundation_Request([MarshalAs(UnmanagedType.LPWStr)] string pszRequestUri, out uint handle);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_GetTokenString", CharSet = CharSet.Unicode)]
    internal static extern uint GameFoundation_GetTokenString(
      [MarshalAs(UnmanagedType.LPWStr)] string audienceUri,
      StringBuilder buffer,
      uint cchActualSize,
      ref uint cchNeeded);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_DownloadGamerPrivilegeOptions")]
    internal static extern uint GameFoundation_DownloadGamerPrivilegeOptions(
      out GamerPrivilegeOptions privileges);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_GetCurrentGamerPrivilegeOptions")]
    internal static extern uint GameFoundation_GetCurrentGamerPrivilegeOptions(
      out GamerPrivilegeOptions privileges,
      out bool hasValidPrivileges);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_PostGameResult")]
    internal static extern unsafe uint GameFoundation_PostGameResult(
      uint variant,
      long rating,
      [MarshalAs(UnmanagedType.Bool)] bool isScore,
      LeaderboardOutcome outcome,
      void* pbBlob,
      uint cbBlob);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_FlushGameResultPosts")]
    internal static extern uint GameFoundation_FlushGameResultPosts();

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_GetPictureStream")]
    internal static extern uint GameFoundation_GetPictureStream(
      uint hPictureGroup,
      [MarshalAs(UnmanagedType.LPWStr)] string url,
      out uint hStream);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_ReleasePictureGroup")]
    internal static extern uint GameFoundation_ReleasePictureGroup(uint hPictureGroup);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_IStream_Read")]
    internal static extern uint IStream_Read(
      uint hStream,
      [In, Out] byte[] buffer,
      uint count,
      out uint pcbRead);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_IStream_Close")]
    internal static extern uint IStream_Close(uint hStream);
  }
}
