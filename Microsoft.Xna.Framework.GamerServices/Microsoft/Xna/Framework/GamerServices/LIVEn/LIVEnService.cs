﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.LIVEn.LIVEnService
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.IO;
using System.Text;

namespace Microsoft.Xna.Framework.GamerServices.LIVEn
{
  internal class LIVEnService : ILIVEnService
  {
    private static bool UpdateRequired;

    public void Initialize() => ErrorHandler.ThrowExceptionFromResult(SafeMobileNativeMethods.GameFoundation_Init());

    public void GetProfile(string gamertag, out Stream stream, out uint hPictureGroup)
    {
      uint hStream;
      ErrorHandler.ThrowExceptionFromResult(SafeMobileNativeMethods.GameFoundation_GetGamerProfile(gamertag, out hStream, out hPictureGroup));
      stream = (Stream) new IStreamStream(hStream);
    }

    public GamerPrivilegeOptions DownloadGamerPrivilegeOptions()
    {
      GamerPrivilegeOptions privilegeOptions = GamerPrivilegeOptions.AllowNone;
      try
      {
        privilegeOptions = SafeMobileNativeMethods.GameFoundation_DownloadGamerPrivilegeOptions();
      }
      catch (GameUpdateRequiredException ex)
      {
        LIVEnService.UpdateRequired = true;
      }
      return privilegeOptions;
    }

    public bool GetCurrentGamerPrivilegeOptions(out GamerPrivilegeOptions privileges)
    {
      if (LIVEnService.UpdateRequired)
        throw new GameUpdateRequiredException(FrameworkResources.LIVEnTitleUpdateRequired);
      return SafeMobileNativeMethods.GameFoundation_GetCurrentGamerPrivilegeOptions(out privileges);
    }

    public string GetTokenString(string audienceUri) => SafeMobileNativeMethods.GameFoundation_GetTokenString(audienceUri);

    public Stream ReadLeaderboard(
      int variant,
      string property,
      string dataGroup,
      int? pageStart,
      int pageSize)
    {
      SafeMobileNativeMethods.GameFoundation_FlushGameResultPosts();
      StringBuilder builder = new StringBuilder();
      LIVEnService.AddService(builder, "/leaderboard");
      LIVEnService.AddParam(builder, "GameId", "{gameid}");
      LIVEnService.AddParam(builder, nameof (variant), variant.ToString());
      LIVEnService.AddParam(builder, nameof (property), property);
      if (pageStart.HasValue)
        LIVEnService.AddParam(builder, "rankStart", pageStart.Value.ToString());
      LIVEnService.AddParam(builder, "numRows", pageSize.ToString());
      LIVEnService.AddParam(builder, nameof (dataGroup), dataGroup);
      LIVEnService.AddParam(builder, "socialGraph", "2");
      return this.GetAuthenticatedWebStream(GfServiceType.GameData, builder.ToString(), GfRequestMethod.Get, (string) null);
    }

    public void WriteScore(int variant, long score, LeaderboardOutcome outcome, byte[] blob) => SafeMobileNativeMethods.GameFoundation_PostGameResult((uint) variant, score, true, outcome, blob);

    public void WriteTime(int variant, long time, LeaderboardOutcome outcome, byte[] blob) => SafeMobileNativeMethods.GameFoundation_PostGameResult((uint) variant, time, false, outcome, blob);

    public Stream GetBlob(string blob)
    {
      StringBuilder builder = new StringBuilder();
      LIVEnService.AddService(builder, "/Datablob");
      LIVEnService.AddParam(builder, "DatablobId", blob);
      return this.GetAuthenticatedWebStream(GfServiceType.GameData, builder.ToString(), GfRequestMethod.Get, (string) null);
    }

    public Stream GetPicture(uint hPictureGroup, string pictureUrl)
    {
      uint hStream;
      if (SafeMobileNativeMethods.GameFoundation_GetPictureStream(hPictureGroup, pictureUrl, out hStream) == 0U)
        return (Stream) new IStreamStream(hStream);
      try
      {
        return this.GetWebStream(pictureUrl);
      }
      catch (Exception ex)
      {
        return (Stream) new MemoryStream(new byte[582]
        {
          (byte) 137,
          (byte) 80,
          (byte) 78,
          (byte) 71,
          (byte) 13,
          (byte) 10,
          (byte) 26,
          (byte) 10,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 13,
          (byte) 73,
          (byte) 72,
          (byte) 68,
          (byte) 82,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 64,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 64,
          (byte) 8,
          (byte) 3,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 157,
          (byte) 183,
          (byte) 129,
          (byte) 236,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 25,
          (byte) 116,
          (byte) 69,
          (byte) 88,
          (byte) 116,
          (byte) 83,
          (byte) 111,
          (byte) 102,
          (byte) 116,
          (byte) 119,
          (byte) 97,
          (byte) 114,
          (byte) 101,
          (byte) 0,
          (byte) 65,
          (byte) 100,
          (byte) 111,
          (byte) 98,
          (byte) 101,
          (byte) 32,
          (byte) 73,
          (byte) 109,
          (byte) 97,
          (byte) 103,
          (byte) 101,
          (byte) 82,
          (byte) 101,
          (byte) 97,
          (byte) 100,
          (byte) 121,
          (byte) 113,
          (byte) 201,
          (byte) 101,
          (byte) 60,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 96,
          (byte) 80,
          (byte) 76,
          (byte) 84,
          (byte) 69,
          (byte) 11,
          (byte) 11,
          (byte) 11,
          (byte) 41,
          (byte) 41,
          (byte) 41,
          (byte) 66,
          (byte) 66,
          (byte) 66,
          (byte) 84,
          (byte) 84,
          (byte) 84,
          (byte) 94,
          (byte) 94,
          (byte) 94,
          (byte) 104,
          (byte) 104,
          (byte) 104,
          (byte) 112,
          (byte) 112,
          (byte) 112,
          (byte) 120,
          (byte) 120,
          (byte) 120,
          (byte) 127,
          (byte) 127,
          (byte) 127,
          (byte) 128,
          (byte) 128,
          (byte) 128,
          (byte) 135,
          (byte) 135,
          (byte) 135,
          (byte) 144,
          (byte) 144,
          (byte) 144,
          (byte) 151,
          (byte) 151,
          (byte) 151,
          (byte) 159,
          (byte) 159,
          (byte) 159,
          (byte) 167,
          (byte) 167,
          (byte) 167,
          (byte) 179,
          (byte) 179,
          (byte) 179,
          (byte) 192,
          (byte) 192,
          (byte) 192,
          (byte) 201,
          (byte) 201,
          (byte) 201,
          (byte) 208,
          (byte) 208,
          (byte) 208,
          (byte) 212,
          (byte) 212,
          (byte) 212,
          (byte) 218,
          (byte) 218,
          (byte) 218,
          (byte) 228,
          (byte) 228,
          (byte) 228,
          (byte) 237,
          (byte) 237,
          (byte) 237,
          (byte) 244,
          (byte) 244,
          (byte) 244,
          (byte) 248,
          (byte) 248,
          (byte) 248,
          (byte) 251,
          (byte) 251,
          (byte) 251,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 2,
          (byte) 2,
          (byte) 2,
          (byte) 3,
          (byte) 3,
          (byte) 3,
          (byte) 4,
          (byte) 4,
          (byte) 4,
          (byte) 69,
          (byte) 115,
          (byte) 134,
          (byte) 174,
          (byte) 0,
          (byte) 0,
          (byte) 1,
          (byte) 124,
          (byte) 73,
          (byte) 68,
          (byte) 65,
          (byte) 84,
          (byte) 120,
          (byte) 218,
          (byte) 204,
          (byte) 144,
          (byte) 235,
          (byte) 114,
          (byte) 130,
          (byte) 64,
          (byte) 12,
          (byte) 133,
          (byte) 15,
          (byte) 96,
          (byte) 237,
          (byte) 130,
          (byte) 69,
          (byte) 188,
          (byte) 45,
          (byte) 45,
          (byte) 116,
          (byte) 208,
          (byte) 247,
          (byte) 127,
          (byte) 75,
          (byte) 217,
          (byte) 205,
          (byte) 94,
          (byte) 178,
          (byte) 192,
          (byte) 208,
          (byte) 177,
          (byte) 113,
          (byte) 70,
          (byte) 191,
          (byte) 132,
          (byte) 156,
          (byte) 108,
          (byte) 18,
          (byte) 207,
          (byte) 15,
          (byte) 209,
          (byte) 11,
          (byte) 193,
          (byte) 235,
          (byte) 13,
          (byte) 186,
          (byte) 190,
          (byte) 235,
          (byte) 198,
          (byte) 175,
          (byte) 167,
          (byte) 210,
          (byte) 39,
          (byte) 125,
          (byte) 152,
          (byte) 48,
          (byte) 229,
          (byte) 99,
          (byte) 19,
          (byte) 232,
          (byte) 132,
          (byte) 224,
          (byte) 71,
          (byte) 8,
          (byte) 190,
          (byte) 133,
          (byte) 140,
          (byte) 6,
          (byte) 237,
          (byte) 250,
          (byte) 69,
          (byte) 187,
          (byte) 62,
          (byte) 67,
          (byte) 43,
          (byte) 228,
          (byte) 9,
          (byte) 6,
          (byte) 58,
          (byte) 13,
          (byte) 221,
          (byte) 174,
          (byte) 198,
          (byte) 244,
          (byte) 70,
          (byte) 67,
          (byte) 11,
          (byte) 193,
          (byte) 69,
          (byte) 107,
          (byte) 74,
          (byte) 83,
          (byte) 252,
          (byte) 35,
          (byte) 14,
          (byte) 185,
          (byte) 184,
          (byte) 38,
          (byte) 221,
          (byte) 226,
          (byte) 194,
          (byte) 208,
          (byte) 151,
          (byte) 85,
          (byte) 22,
          (byte) 215,
          (byte) 193,
          (byte) 224,
          (byte) 236,
          (byte) 190,
          (byte) 21,
          (byte) 22,
          (byte) 215,
          (byte) 56,
          (byte) 11,
          (byte) 193,
          (byte) 73,
          (byte) 8,
          (byte) 142,
          (byte) 158,
          (byte) 147,
          (byte) 77,
          (byte) 251,
          (byte) 249,
          (byte) 247,
          (byte) 84,
          (byte) 146,
          (byte) 189,
          (byte) 235,
          (byte) 113,
          (byte) 20,
          (byte) 130,
          (byte) 131,
          (byte) 16,
          (byte) 185,
          (byte) 65,
          (byte) 51,
          (byte) 231,
          (byte) 240,
          (byte) 231,
          (byte) 128,
          (byte) 141,
          (byte) 150,
          (byte) 12,
          (byte) 30,
          (byte) 194,
          (byte) 24,
          (byte) 236,
          (byte) 27,
          (byte) 94,
          (byte) 246,
          (byte) 65,
          (byte) 220,
          (byte) 231,
          (byte) 6,
          (byte) 77,
          (byte) 19,
          (byte) 151,
          (byte) 236,
          (byte) 8,
          (byte) 123,
          (byte) 33,
          (byte) 206,
          (byte) 160,
          (byte) 158,
          (byte) 140,
          (byte) 235,
          (byte) 249,
          (byte) 101,
          (byte) 189,
          (byte) 60,
          (byte) 69,
          (byte) 45,
          (byte) 4,
          (byte) 95,
          (byte) 66,
          (byte) 228,
          (byte) 6,
          (byte) 59,
          (byte) 33,
          (byte) 168,
          (byte) 170,
          (byte) 106,
          (byte) 103,
          (byte) 179,
          (byte) 170,
          (byte) 156,
          (byte) 184,
          (byte) 190,
          (byte) 74,
          (byte) 250,
          (byte) 221,
          (byte) 92,
          (byte) 168,
          (byte) 55,
          (byte) 6,
          (byte) 101,
          (byte) 252,
          (byte) 65,
          (byte) 89,
          (byte) 45,
          (byte) 188,
          (byte) 231,
          (byte) 148,
          (byte) 177,
          (byte) 162,
          (byte) 84,
          (byte) 74,
          (byte) 149,
          (byte) 6,
          (byte) 101,
          (byte) 27,
          (byte) 91,
          (byte) 109,
          (byte) 154,
          (byte) 71,
          (byte) 88,
          (byte) 216,
          (byte) 27,
          (byte) 21,
          (byte) 79,
          (byte) 104,
          (byte) 99,
          (byte) 90,
          (byte) 124,
          (byte) 18,
          (byte) 42,
          (byte) 20,
          (byte) 87,
          (byte) 93,
          (byte) 167,
          (byte) 226,
          (byte) 128,
          (byte) 73,
          (byte) 156,
          (byte) 142,
          (byte) 6,
          (byte) 219,
          (byte) 49,
          (byte) 88,
          (byte) 241,
          (byte) 226,
          (byte) 222,
          (byte) 62,
          (byte) 184,
          (byte) 196,
          (byte) 237,
          (byte) 152,
          (byte) 216,
          (byte) 10,
          (byte) 193,
          (byte) 135,
          (byte) 16,
          (byte) 185,
          (byte) 193,
          (byte) 70,
          (byte) 72,
          (byte) 48,
          (byte) 40,
          (byte) 38,
          (byte) 186,
          (byte) 225,
          (byte) 139,
          (byte) 34,
          (byte) 185,
          (byte) 42,
          (byte) 216,
          (byte) 93,
          (byte) 129,
          (byte) 66,
          (byte) 200,
          (byte) 19,
          (byte) 12,
          (byte) 114,
          (byte) 10,
          (byte) 158,
          (byte) 177,
          (byte) 36,
          (byte) 154,
          (byte) 60,
          (byte) 125,
          (byte) 139,
          (byte) 220,
          (byte) 65,
          (byte) 211,
          (byte) 220,
          (byte) 213,
          (byte) 88,
          (byte) 248,
          (byte) 42,
          (byte) 140,
          (byte) 139,
          (byte) 216,
          (byte) 6,
          (byte) 131,
          byte.MaxValue,
          (byte) 34,
          (byte) 55,
          (byte) 200,
          (byte) 114,
          (byte) 89,
          (byte) 192,
          (byte) 212,
          (byte) 144,
          (byte) 20,
          (byte) 169,
          (byte) 36,
          (byte) 7,
          (byte) 211,
          (byte) 69,
          (byte) 158,
          (byte) 33,
          (byte) 99,
          (byte) 91,
          (byte) 34,
          (byte) 79,
          (byte) 36,
          (byte) 182,
          (byte) 254,
          (byte) 134,
          (byte) 45,
          (byte) 70,
          (byte) 144,
          (byte) 9,
          (byte) 121,
          (byte) 3,
          (byte) 3,
          (byte) 100,
          (byte) 47,
          (byte) 14,
          (byte) 60,
          (byte) 193,
          (byte) 65,
          (byte) 138,
          (byte) 253,
          (byte) 27,
          (byte) 72,
          (byte) 253,
          (byte) 151,
          (byte) 77,
          (byte) 95,
          (byte) 169,
          (byte) 240,
          (byte) 124,
          (byte) 7,
          (byte) 110,
          (byte) 54,
          (byte) 188,
          (byte) 62,
          (byte) 30,
          (byte) 184,
          (byte) 9,
          (byte) 193,
          (byte) 117,
          (byte) 24,
          (byte) 134,
          (byte) 43,
          (byte) 165,
          (byte) 105,
          (byte) 35,
          (byte) 246,
          (byte) 73,
          (byte) 101,
          (byte) 160,
          (byte) 150,
          (byte) 52,
          (byte) 236,
          (byte) 233,
          (byte) 195,
          (byte) 175,
          (byte) 16,
          (byte) 177,
          (byte) 193,
          (byte) 93,
          (byte) 128,
          (byte) 1,
          (byte) 0,
          (byte) 222,
          (byte) 115,
          (byte) 197,
          (byte) 16,
          (byte) 182,
          (byte) 230,
          (byte) 202,
          (byte) 105,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 73,
          (byte) 69,
          (byte) 78,
          (byte) 68,
          (byte) 174,
          (byte) 66,
          (byte) 96,
          (byte) 130
        });
      }
    }

    public void ReleasePictureGroup(uint hPictureGroup)
    {
      int num = (int) SafeMobileNativeMethods.GameFoundation_ReleasePictureGroup(hPictureGroup);
    }

    public void GetAchievements(out Stream stream, out uint hPictureGroup)
    {
      uint hStream;
      ErrorHandler.ThrowExceptionFromResult(SafeMobileNativeMethods.GameFoundation_GetAchievements(out hStream, out hPictureGroup));
      stream = (Stream) new IStreamStream(hStream);
    }

    public void AwardAchievement(string achievementKey)
    {
      int num = (int) SafeMobileNativeMethods.GameFoundation_GrantAchievement(uint.Parse(achievementKey));
    }

    protected Stream GetWebStream(string requestUri)
    {
      uint handle;
      ErrorHandler.ThrowExceptionFromResult(SafeMobileNativeMethods.GameFoundation_Request(requestUri, out handle));
      return (Stream) new IStreamStream(handle);
    }

    protected Stream GetAuthenticatedWebStream(
      GfServiceType service,
      string requestUri,
      GfRequestMethod method,
      string postData)
    {
      uint handle;
      ErrorHandler.ThrowExceptionFromResult(SafeMobileNativeMethods.GameFoundation_AuthenticatedRequest(service, requestUri, method, postData, out handle));
      return (Stream) new IStreamStream(handle);
    }

    private static void AddParam(StringBuilder builder, string name, string value)
    {
      builder.Append("&");
      builder.Append(name);
      builder.Append("=");
      builder.Append(value);
    }

    private static void AddService(StringBuilder builder, string serviceName)
    {
      builder.Append(serviceName);
      builder.Append("?format=xml");
    }
  }
}