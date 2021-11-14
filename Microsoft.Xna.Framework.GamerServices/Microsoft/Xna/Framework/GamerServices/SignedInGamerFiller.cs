// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.SignedInGamerFiller
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class SignedInGamerFiller : GamerFiller, IPropertyFiller
  {
    public new void SetNamedValue(GSPropertyName key, string value)
    {
      Gamer target = this.Target;
      base.SetNamedValue(key, value);
    }

    public new void SetNamedValue(GSPropertyName key, int value)
    {
      SignedInGamer target = this.Target as SignedInGamer;
      switch (key)
      {
        case GSPropertyName.PlayerIndex:
          target.PlayerIndex = (PlayerIndex) value;
          break;
        case GSPropertyName.SignInState:
          target.IsSignedInToLive = value == 2;
          break;
        case GSPropertyName.IsGuest:
          target.IsGuest = (uint) value > 0U;
          break;
        case GSPropertyName.PrivilegeOptions:
          target.Privileges.privileges = (GamerPrivilegeOptions) value;
          break;
        default:
          base.SetNamedValue(key, value);
          break;
      }
    }
  }
}
