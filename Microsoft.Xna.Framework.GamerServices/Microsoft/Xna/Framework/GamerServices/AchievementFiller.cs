// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AchievementFiller
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.IO;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class AchievementFiller : BaseFiller, IPropertyFiller
  {
    internal Achievement Target;

    public new void SetNamedValue(GSPropertyName key, string value)
    {
      switch (key)
      {
        case GSPropertyName.AchievementKey:
          this.Target.Id = int.Parse(value);
          XlastConfiguration instance = XlastConfiguration.Instance;
          if (instance != null)
          {
            this.Target.Key = XlastConfiguration.GetKeyForValue<string, int>(instance.Achievements, this.Target.Id);
            break;
          }
          this.Target.Key = value;
          break;
        case GSPropertyName.AchievementName:
          this.Target.Name = value;
          break;
        case GSPropertyName.AchievementDescription:
          this.Target.Description = value;
          break;
        case GSPropertyName.AchievementHowToEarn:
          this.Target.HowToEarn = value;
          break;
      }
    }

    public new void SetNamedValue(GSPropertyName key, int value)
    {
      switch (key)
      {
        case GSPropertyName.AchievementGamerScore:
          this.Target.GamerScore = value;
          break;
        case GSPropertyName.AchievementIsEarned:
          this.Target.IsEarned = (uint) value > 0U;
          break;
        case GSPropertyName.AchievementEarnedOnline:
          this.Target.EarnedOnline = (uint) value > 0U;
          break;
        case GSPropertyName.AchievementDisplayBeforeEarned:
          this.Target.DisplayBeforeEarned = (uint) value > 0U;
          break;
        case GSPropertyName.AchievementPicture:
          using (Stream stream = GamerServicesDispatcher.Gsp.GetStream(value))
          {
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            this.Target.PictureBuffer = buffer;
            break;
          }
      }
    }

    public new void SetNamedValue(GSPropertyName key, long value)
    {
      if (key != GSPropertyName.AchievementEarnedDateTime)
        return;
      this.Target.EarnedDateTime = new DateTime(value);
    }
  }
}
