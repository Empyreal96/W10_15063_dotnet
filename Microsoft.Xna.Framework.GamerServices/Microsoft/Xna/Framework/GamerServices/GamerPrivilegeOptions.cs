// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.GamerPrivilegeOptions
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;

namespace Microsoft.Xna.Framework.GamerServices
{
  [Flags]
  internal enum GamerPrivilegeOptions
  {
    AllowNone = 0,
    AllowOnlineSessions = 1,
    AllowCommunication = 2,
    AllowCommunicationFriendsOnly = 4,
    AllowProfileViewing = 8,
    AllowProfileViewingFriendsOnly = 16, // 0x00000010
    AllowUserCreatedContent = 32, // 0x00000020
    AllowUserCreatedContentFriendsOnly = 64, // 0x00000040
    AllowTradeContent = 128, // 0x00000080
    AllowPurchaseContent = 256, // 0x00000100
    AllowPremiumContent = 512, // 0x00000200
  }
}
