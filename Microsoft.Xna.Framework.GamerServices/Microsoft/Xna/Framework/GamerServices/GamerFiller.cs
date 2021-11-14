// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.GamerFiller
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class GamerFiller : BaseFiller, IPropertyFiller
  {
    internal Gamer Target;

    public new void SetNamedValue(GSPropertyName key, int value)
    {
      if (key != GSPropertyName.GamerHandle)
        return;
      this.Target.KernelHandle = (uint) value;
    }

    public new void SetNamedValue(GSPropertyName key, string value)
    {
      if (key != GSPropertyName.Gamertag)
      {
        if (key != GSPropertyName.DisplayName)
          return;
        this.Target.DisplayName = value;
      }
      else
        this.Target.Gamertag = value;
    }
  }
}
