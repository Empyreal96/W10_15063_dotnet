// Decompiled with JetBrains decompiler
// Type: GamerServices.Platforms.Web.LIVEnProfileReader
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace GamerServices.Platforms.Web
{
  internal class LIVEnProfileReader : LIVEnTask
  {
    private string gamertag;
    private bool isSignedInGamer;

    public LIVEnProfileReader(LIVEnGamer gamer, string gamertag, bool isSignedInGamer)
    {
      this.Gamer = gamer;
      this.gamertag = gamertag;
      this.isSignedInGamer = isSignedInGamer;
    }

    public LIVEnGamer Gamer { get; private set; }

    public override void Do()
    {
      Stream stream1 = (Stream) null;
      uint hPictureGroup = 0;
      string gamerPicUrl = string.Empty;
      try
      {
        this.webService.GetProfile(this.gamertag, out stream1, out hPictureGroup);
        using (XmlReader reader = XmlReader.Create(stream1))
        {
          if (XmlReaderHelper.ReadUntil(reader, "DisplayName"))
            this.Gamer.DisplayName = reader.ReadElementContentAsString();
          try
          {
            if (XmlReaderHelper.ReadUntil(reader, "XboxLiveProperties"))
              this.ReadXboxLiveProperties(reader, out gamerPicUrl);
          }
          catch (Exception ex)
          {
          }
        }
        using (Stream picture = this.webService.GetPicture(hPictureGroup, gamerPicUrl))
        {
          byte[] buffer1 = new byte[16384];
          byte[] numArray = new byte[picture.Read(buffer1, 0, buffer1.Length)];
          Array.Copy((Array) buffer1, (Array) numArray, numArray.Length);
          LIVEnGamer gamer = this.Gamer;
          IGamerServicesProvider gsp = GamerServicesDispatcher.Gsp;
          byte[] buffer2 = numArray;
          int length = buffer2.Length;
          int stream2 = gsp.CreateStream(buffer2, length);
          gamer.GamerPicture = stream2;
        }
        if (this.isSignedInGamer)
        {
          this.Gamer.Culture = CultureInfo.CurrentCulture.Name;
        }
        else
        {
          this.Gamer.SignInState = PlayerSignInState.NotSignedIn;
          this.Gamer.Culture = "en-US";
        }
      }
      finally
      {
        stream1?.Dispose();
        this.webService.ReleasePictureGroup(hPictureGroup);
      }
    }

    private void ReadXboxLiveProperties(XmlReader reader, out string gamerPicUrl)
    {
      gamerPicUrl = string.Empty;
      while (XmlReaderHelper.ReadUntil(reader, "KeyValueOfXboxLivePropertyanyTypeHrp0VRoE"))
      {
        XmlReaderHelper.ReadUntil(reader, "Key");
        string str1 = reader.ReadElementContentAsString();
        XmlReaderHelper.ReadUntil(reader, "Value");
        switch (str1.ToLower())
        {
          case "gamerpicurl":
            gamerPicUrl = reader.ReadElementContentAsString();
            continue;
          case "gamerscore":
            this.Gamer.GamerScore = reader.ReadElementContentAsInt();
            continue;
          case "gamertag":
            this.Gamer.Gamertag = reader.ReadElementContentAsString();
            continue;
          case "gamerzone":
            string str2 = reader.ReadElementContentAsString();
            this.Gamer.GamerZone = str2 == "Recreation" ? GamerZone.Recreation : (str2 == "Pro" ? GamerZone.Pro : (str2 == "Family" ? GamerZone.Family : (str2 == "Underground" ? GamerZone.Underground : GamerZone.Unknown)));
            continue;
          case "motto":
            this.Gamer.Motto = reader.ReadElementContentAsString();
            continue;
          case "reputation":
            this.Gamer.Reputation = reader.ReadElementContentAsFloat();
            continue;
          case "titleplayed":
            this.Gamer.TitlePlayed = reader.ReadElementContentAsInt();
            continue;
          case "totalachievements":
            this.Gamer.TotalAchievements = reader.ReadElementContentAsInt();
            continue;
          default:
            continue;
        }
      }
    }
  }
}
