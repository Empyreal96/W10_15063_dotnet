// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.KernelCallType
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

namespace Microsoft.Xna.Framework.GamerServices
{
  internal enum KernelCallType
  {
    RunUnitTest = 1,
    TellKernelToCallManagedUnitTestFunction = 2,
    DrawGuide = 3,
    WindowsMessage = 4,
    GamerServices_SetTitleName = 5,
    GamerServices_Update = 6,
    KernelAsyncDispatcher_CleanUpAsyncOperation = 7,
    Gamer_IsFriend = 8,
    Gamer_BeginGetProfile = 9,
    Gamer_EndGetProfile = 10, // 0x0000000A
    Gamer_BeginAwardAchievement = 11, // 0x0000000B
    Gamer_BeginAwardPicture = 12, // 0x0000000C
    Gamer_BeginAwardAvatarAssets = 13, // 0x0000000D
    Gamer_BeginGetAchievements = 14, // 0x0000000E
    Gamer_EndGetAchievements = 15, // 0x0000000F
    Gamer_BeginGetFromGamertag = 16, // 0x00000010
    Gamer_EndGetFromGamertag = 17, // 0x00000011
    Gamer_DisposeSocialGamer = 18, // 0x00000012
    BeginCheckStrings = 19, // 0x00000013
    EndCheckStrings = 20, // 0x00000014
    FriendCollection_GetFriends = 21, // 0x00000015
    FriendCollection_Dispose = 22, // 0x00000016
    Guide_BeginShowMessageBox = 23, // 0x00000017
    Guide_EndShowMessageBox = 24, // 0x00000018
    Guide_BeginShowKeyboardInput = 25, // 0x00000019
    Guide_EndShowKeyboardInput = 26, // 0x0000001A
    Guide_BeginShowStorageDeviceSelector = 27, // 0x0000001B
    Guide_EndShowStorageDeviceSelector = 28, // 0x0000001C
    Guide_ShowSignIn = 29, // 0x0000001D
    Guide_ShowMessages = 30, // 0x0000001E
    Guide_ShowFriends = 31, // 0x0000001F
    Guide_ShowPlayers = 32, // 0x00000020
    Guide_ShowFriendRequest = 33, // 0x00000021
    Guide_ShowPlayerReview = 34, // 0x00000022
    Guide_ShowGamerCard = 35, // 0x00000023
    Guide_ShowComposeMessage = 36, // 0x00000024
    Guide_SetNotificationPosition = 37, // 0x00000025
    Guide_EnableScreenSaver = 38, // 0x00000026
    Guide_DelayNotifications = 39, // 0x00000027
    Guide_ShowAchievements = 40, // 0x00000028
    Guide_ShowGameInvite = 41, // 0x00000029
    Guide_ShowMarketplace = 42, // 0x0000002A
    NetworkSession_BeginCreate = 43, // 0x0000002B
    NetworkSession_EndCreate = 44, // 0x0000002C
    NetworkSession_BeginJoinInvited = 45, // 0x0000002D
    NetworkSession_EndJoinInvited = 46, // 0x0000002E
    NetworkSession_Update = 47, // 0x0000002F
    NetworkSession_Destroy = 48, // 0x00000030
    NetworkSession_AddLocalGamer = 49, // 0x00000031
    SessionFinder_BeginFindSessions = 50, // 0x00000032
    SessionFinder_EndFindSessions = 51, // 0x00000033
    SessionFinder_BeginJoin = 52, // 0x00000034
    SessionFinder_EndJoin = 53, // 0x00000035
    SessionFinder_Destroy = 54, // 0x00000036
    SessionFinder_GetQualityOfService = 55, // 0x00000037
    Leaderboard_Dispose = 56, // 0x00000038
    Leaderboard_BeginReadGamerList = 57, // 0x00000039
    Leaderboard_BeginReadPivotGamer = 58, // 0x0000003A
    Leaderboard_BeginReadByRank = 59, // 0x0000003B
    Leaderboard_EndRead = 60, // 0x0000003C
    Leaderboard_BeginPage = 61, // 0x0000003D
    Leaderboard_EndPage = 62, // 0x0000003E
    Gamer_EndAwardPicture = 63, // 0x0000003F
    Gamer_EndAwardAchievement = 64, // 0x00000040
    Gamer_EndAwardAvatarAssets = 65, // 0x00000041
    Guide_ShowParty = 66, // 0x00000042
    Guide_ShowPartySessions = 67, // 0x00000043
    Party_SendInvites = 68, // 0x00000044
    Storage_BeginOpenContent = 69, // 0x00000045
    Storage_EndOpenContent = 70, // 0x00000046
    Storage_BeginGetDownloadedContent = 71, // 0x00000047
    Storage_EndGetDownloadedContent = 72, // 0x00000048
    Storage_BeginGetProfileData = 73, // 0x00000049
    Storage_EndGetProfileData = 74, // 0x0000004A
    Storage_BeginSetProfileData = 75, // 0x0000004B
    Storage_EndSetProfileData = 76, // 0x0000004C
    AvatarRenderer_Create = 77, // 0x0000004D
    AvatarRenderer_ReleaseHandle = 78, // 0x0000004E
    AvatarRenderer_IsLoaded = 79, // 0x0000004F
    AvatarRenderer_Draw = 80, // 0x00000050
    AvatarRenderer_GetBindPose = 81, // 0x00000051
    AvatarDescription_BeginGetFromGamer = 82, // 0x00000052
    AvatarDescription_EndGetFromGamer = 83, // 0x00000053
    AvatarDescription_CreateRandom = 84, // 0x00000054
    AvatarDescription_GetHeight = 85, // 0x00000055
    AvatarDescription_GetBodyType = 86, // 0x00000056
    AvatarAnimation_Create = 87, // 0x00000057
    AvatarAnimation_ReleaseHandle = 88, // 0x00000058
    AvatarAnimation_Update = 89, // 0x00000059
    Guide_ShowDownloadableContentOffers = 90, // 0x0000005A
    TitleServiceConnection_Create = 91, // 0x0000005B
    TitleServiceConnection_Dispose = 92, // 0x0000005C
    TitleServiceConnection_Connect = 93, // 0x0000005D
    TitleServiceConnection_Disconnect = 94, // 0x0000005E
    TitleServiceConnection_GetStatus = 95, // 0x0000005F
    TitleServiceConnection_GetConnectionResults = 96, // 0x00000060
    TitleServiceConnection_Cancel = 97, // 0x00000061
    TitleServiceDirectory_Create = 98, // 0x00000062
    TitleServiceDirectory_Dispose = 99, // 0x00000063
    TitleServiceDirectory_FindService = 100, // 0x00000064
    TitleServiceDirectory_GetFindServiceResults = 101, // 0x00000065
    TitleServiceDirectory_Cancel = 102, // 0x00000066
    Gamer_GetXUID = 103, // 0x00000067
  }
}
