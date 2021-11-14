// Decompiled with JetBrains decompiler
// Type: GamerServices.Platforms.Web.LIVEnAchievementsReader
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace GamerServices.Platforms.Web
{
  internal class LIVEnAchievementsReader : LIVEnTask
  {
    public List<LIVEnAchievement> Achievements { get; private set; }

    public override void Do()
    {
      Stream stream1 = (Stream) null;
      uint hPictureGroup = 0;
      try
      {
        this.webService.GetAchievements(out stream1, out hPictureGroup);
        List<LIVEnAchievement> livEnAchievementList = this.ReadAchievements(stream1);
        byte[] buffer1 = new byte[16384];
        foreach (LIVEnAchievement livEnAchievement1 in livEnAchievementList)
        {
          using (Stream picture = this.webService.GetPicture(hPictureGroup, livEnAchievement1.PictureUri))
          {
            byte[] numArray = new byte[picture.Read(buffer1, 0, buffer1.Length)];
            Array.Copy((Array) buffer1, (Array) numArray, numArray.Length);
            LIVEnAchievement livEnAchievement2 = livEnAchievement1;
            IGamerServicesProvider gsp = GamerServicesDispatcher.Gsp;
            byte[] buffer2 = numArray;
            int length = buffer2.Length;
            int stream2 = gsp.CreateStream(buffer2, length);
            livEnAchievement2.Picture = stream2;
          }
        }
        this.Achievements = livEnAchievementList;
      }
      finally
      {
        stream1?.Dispose();
        this.webService.ReleasePictureGroup(hPictureGroup);
      }
    }

    private List<LIVEnAchievement> ReadAchievements(Stream stream)
    {
      XmlReader reader = XmlReader.Create(stream);
      List<LIVEnAchievement> livEnAchievementList = new List<LIVEnAchievement>();
      while (XmlReaderHelper.ReadUntil(reader, "Achievement"))
      {
        LIVEnAchievement livEnAchievement = this.ReadAchievement(reader);
        if (livEnAchievement != null)
          livEnAchievementList.Add(livEnAchievement);
      }
      return livEnAchievementList;
    }

    private LIVEnAchievement ReadAchievement(XmlReader reader)
    {
      LIVEnAchievement livEnAchievement = new LIVEnAchievement();
      bool flag = false;
      while (!reader.EOF)
      {
        if (!flag)
          reader.Read();
        if (reader.NodeType == XmlNodeType.Element)
        {
          flag = true;
          switch (reader.Name.ToLower())
          {
            case "description":
              livEnAchievement.Description = reader.ReadElementContentAsString();
              continue;
            case "displaybeforeearned":
              livEnAchievement.DisplayBeforeEarned = reader.ReadElementContentAsBoolean();
              continue;
            case "earneddatetime":
              livEnAchievement.EarnedDateTime = reader.ReadElementContentAsDateTime().Ticks;
              continue;
            case "earnedonline":
              livEnAchievement.EarnedOnline = reader.ReadElementContentAsBoolean();
              continue;
            case "gamerscore":
              livEnAchievement.GameScore = reader.ReadElementContentAsInt();
              continue;
            case "howtoearn":
              livEnAchievement.HowToEarn = reader.ReadElementContentAsString();
              continue;
            case "isearned":
              livEnAchievement.IsEarned = reader.ReadElementContentAsBoolean();
              continue;
            case "key":
              livEnAchievement.Key = reader.ReadElementContentAsString();
              continue;
            case "name":
              livEnAchievement.Name = reader.ReadElementContentAsString();
              continue;
            case "pictureurl":
              livEnAchievement.PictureUri = reader.ReadElementContentAsString();
              continue;
            default:
              flag = false;
              continue;
          }
        }
        else if (XmlReaderHelper.IsEndElement(reader, "Achievement"))
          break;
      }
      return livEnAchievement;
    }
  }
}
