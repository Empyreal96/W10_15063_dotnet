// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.GamerProfileFiller
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.Globalization;
using System.IO;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class GamerProfileFiller : BaseFiller, IPropertyFiller
  {
    internal GamerProfile Target;

    public new void SetNamedValue(GSPropertyName name, string value)
    {
      if (name != GSPropertyName.Motto)
      {
        if (name != GSPropertyName.Culture)
          return;
        try
        {
          this.Target.Region = new RegionInfo(value);
        }
        catch (ArgumentException ex)
        {
          this.Target.Region = new RegionInfo("en-US");
        }
      }
      else
        this.Target.Motto = value;
    }

    public new void SetNamedValue(GSPropertyName name, int value)
    {
      switch (name)
      {
        case GSPropertyName.GamerZone:
          this.Target.GamerZone = (GamerZone) value;
          break;
        case GSPropertyName.GamerScore:
          this.Target.GamerScore = value;
          break;
        case GSPropertyName.TitlePlayed:
          this.Target.TitlesPlayed = value;
          break;
        case GSPropertyName.TotalAchievements:
          this.Target.TotalAchievements = value;
          break;
        case GSPropertyName.GamerPicture:
          Stream stream = GamerServicesDispatcher.Gsp.GetStream(value);
          byte[] buffer = new byte[stream.Length];
          stream.Read(buffer, 0, buffer.Length);
          this.Target.GamerPictureBuffer = buffer;
          stream.Seek(0L, SeekOrigin.Begin);
          break;
      }
    }

    public new void SetNamedValue(GSPropertyName name, float value)
    {
      if (name != GSPropertyName.Reputation)
        return;
      this.Target.Reputation = value;
    }
  }
}
