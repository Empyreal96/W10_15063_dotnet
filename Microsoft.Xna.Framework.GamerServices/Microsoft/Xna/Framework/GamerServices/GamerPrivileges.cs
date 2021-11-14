// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.GamerPrivileges
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

namespace Microsoft.Xna.Framework.GamerServices
{
  public sealed class GamerPrivileges
  {
    internal GamerPrivilegeOptions privileges;

    internal GamerPrivileges(GamerPrivilegeOptions privileges) => this.privileges = privileges;

    public bool AllowOnlineSessions => (uint) (this.privileges & GamerPrivilegeOptions.AllowOnlineSessions) > 0U;

    public GamerPrivilegeSetting AllowCommunication
    {
      get
      {
        if ((this.privileges & GamerPrivilegeOptions.AllowCommunication) != GamerPrivilegeOptions.AllowNone)
          return GamerPrivilegeSetting.Everyone;
        return (this.privileges & GamerPrivilegeOptions.AllowCommunicationFriendsOnly) != GamerPrivilegeOptions.AllowNone ? GamerPrivilegeSetting.FriendsOnly : GamerPrivilegeSetting.Blocked;
      }
    }

    public GamerPrivilegeSetting AllowProfileViewing
    {
      get
      {
        if ((this.privileges & GamerPrivilegeOptions.AllowProfileViewing) != GamerPrivilegeOptions.AllowNone)
          return GamerPrivilegeSetting.Everyone;
        return (this.privileges & GamerPrivilegeOptions.AllowProfileViewingFriendsOnly) != GamerPrivilegeOptions.AllowNone ? GamerPrivilegeSetting.FriendsOnly : GamerPrivilegeSetting.Blocked;
      }
    }

    public GamerPrivilegeSetting AllowUserCreatedContent
    {
      get
      {
        if ((this.privileges & GamerPrivilegeOptions.AllowUserCreatedContent) != GamerPrivilegeOptions.AllowNone)
          return GamerPrivilegeSetting.Everyone;
        return (this.privileges & GamerPrivilegeOptions.AllowUserCreatedContentFriendsOnly) != GamerPrivilegeOptions.AllowNone ? GamerPrivilegeSetting.FriendsOnly : GamerPrivilegeSetting.Blocked;
      }
    }

    public bool AllowTradeContent => (uint) (this.privileges & GamerPrivilegeOptions.AllowTradeContent) > 0U;

    public bool AllowPurchaseContent => (uint) (this.privileges & GamerPrivilegeOptions.AllowPurchaseContent) > 0U;

    public bool AllowPremiumContent => (uint) (this.privileges & GamerPrivilegeOptions.AllowPremiumContent) > 0U;
  }
}
