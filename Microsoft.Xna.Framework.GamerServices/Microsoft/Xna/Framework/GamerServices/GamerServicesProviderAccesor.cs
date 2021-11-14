// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.GamerServicesProviderAccesor
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.LIVEn;
using System;
using System.IO;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal static class GamerServicesProviderAccesor
  {
    internal static IComparable Callback;
    internal static GamerServicesProviderWeb Provider;
    internal static ILIVEnService orgWebService;

    public static void HookWebService()
    {
      GamerServicesProviderWeb.hookedService = (ILIVEnService) new GamerServicesProviderAccesor.TestService();
      if (GamerServicesProviderAccesor.Provider == null)
        return;
      GamerServicesProviderAccesor.Provider.HookTestService();
    }

    public static void RecoverWebService() => GamerServicesProviderAccesor.Provider.webService = GamerServicesProviderAccesor.orgWebService;

    private class TestService : ILIVEnService
    {
      public void Initialize()
      {
        object[] objArray = new object[1]
        {
          (object) nameof (Initialize)
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray);
      }

      public void GetProfile(string gamertag, out Stream stream, out uint hPictureGroup)
      {
        object[] objArray = new object[4]
        {
          (object) nameof (GetProfile),
          (object) gamertag,
          null,
          null
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray);
        stream = (Stream) objArray[2];
        hPictureGroup = (uint) objArray[3];
      }

      public bool GetCurrentGamerPrivilegeOptions(out GamerPrivilegeOptions privileges)
      {
        object[] objArray1 = new object[3]
        {
          (object) nameof (GetCurrentGamerPrivilegeOptions),
          null,
          null
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray1);
        uint num = (uint) objArray1[1];
        privileges = (GamerPrivilegeOptions) num;
        object[] objArray2 = objArray1;
        return (bool) objArray2[objArray2.Length - 1];
      }

      public GamerPrivilegeOptions DownloadGamerPrivilegeOptions()
      {
        object[] objArray1 = new object[2]
        {
          (object) nameof (DownloadGamerPrivilegeOptions),
          null
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray1);
        object[] objArray2 = objArray1;
        return (GamerPrivilegeOptions) (uint) objArray2[objArray2.Length - 1];
      }

      public string GetTokenString(string audienceUri)
      {
        object[] objArray1 = new object[3]
        {
          (object) nameof (GetTokenString),
          (object) audienceUri,
          null
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray1);
        object[] objArray2 = objArray1;
        return (string) objArray2[objArray2.Length - 1];
      }

      public void AwardAchievement(string achievementKey)
      {
        object[] objArray = new object[2]
        {
          (object) nameof (AwardAchievement),
          (object) achievementKey
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray);
      }

      public void GetAchievements(out Stream stream, out uint hPictureGroup)
      {
        object[] objArray = new object[3]
        {
          (object) nameof (GetAchievements),
          null,
          null
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray);
        stream = (Stream) objArray[1];
        hPictureGroup = (uint) objArray[2];
      }

      public Stream ReadLeaderboard(
        int variant,
        string property,
        string dataGroup,
        int? pageStart,
        int pageSize)
      {
        object[] objArray1 = new object[7]
        {
          (object) nameof (ReadLeaderboard),
          (object) variant,
          (object) property,
          (object) dataGroup,
          (object) pageStart,
          (object) pageSize,
          null
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray1);
        object[] objArray2 = objArray1;
        return (Stream) objArray2[objArray2.Length - 1];
      }

      public void WriteScore(int variant, long score, LeaderboardOutcome outcome, byte[] blob)
      {
        object[] objArray = new object[5]
        {
          (object) nameof (WriteScore),
          (object) variant,
          (object) score,
          (object) outcome,
          (object) blob
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray);
      }

      public void WriteTime(int variant, long score, LeaderboardOutcome outcome, byte[] blob)
      {
        object[] objArray = new object[5]
        {
          (object) nameof (WriteTime),
          (object) variant,
          (object) score,
          (object) outcome,
          (object) blob
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray);
      }

      public Stream GetBlob(string blob)
      {
        object[] objArray1 = new object[3]
        {
          (object) nameof (GetBlob),
          (object) blob,
          null
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray1);
        object[] objArray2 = objArray1;
        return (Stream) objArray2[objArray2.Length - 1];
      }

      public Stream GetPicture(uint hPictureGroup, string url)
      {
        object[] objArray1 = new object[4]
        {
          (object) nameof (GetPicture),
          (object) hPictureGroup,
          (object) url,
          null
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray1);
        object[] objArray2 = objArray1;
        return (Stream) objArray2[objArray2.Length - 1];
      }

      public void ReleasePictureGroup(uint hPictureGroup)
      {
        object[] objArray = new object[2]
        {
          (object) nameof (ReleasePictureGroup),
          (object) hPictureGroup
        };
        GamerServicesProviderAccesor.Callback.CompareTo((object) objArray);
      }
    }
  }
}
