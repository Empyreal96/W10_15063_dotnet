// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.FriendState
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;

namespace Microsoft.Xna.Framework.GamerServices
{
  [Flags]
  internal enum FriendState
  {
    FriendIsOnline = 1,
    FriendIsPlaying = 2,
    FriendIsJoinable = 4,
    FriendIsAway = 8,
    FriendIsBusy = 16, // 0x00000010
    FriendHasVoice = 32, // 0x00000020
    FriendRequestReceivedFrom = 64, // 0x00000040
    FriendRequestSentTo = 128, // 0x00000080
    InviteReceivedFrom = 256, // 0x00000100
    InviteSentTo = 512, // 0x00000200
    InviteAccepted = 1024, // 0x00000400
    InviteRejected = 2048, // 0x00000800
  }
}
