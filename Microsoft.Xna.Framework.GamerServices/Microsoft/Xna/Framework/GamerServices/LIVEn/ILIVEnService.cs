// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.LIVEn.ILIVEnService
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System.IO;

namespace Microsoft.Xna.Framework.GamerServices.LIVEn
{
  internal interface ILIVEnService
  {
    void Initialize();

    void GetProfile(string gamertag, out Stream stream, out uint hPictureGroup);

    bool GetCurrentGamerPrivilegeOptions(out GamerPrivilegeOptions privileges);

    GamerPrivilegeOptions DownloadGamerPrivilegeOptions();

    string GetTokenString(string audienceUri);

    void AwardAchievement(string achievementKey);

    void GetAchievements(out Stream stream, out uint hPictureGroup);

    Stream ReadLeaderboard(
      int variant,
      string property,
      string dataGroup,
      int? pageStart,
      int pageSize);

    void WriteScore(int variant, long score, LeaderboardOutcome outcome, byte[] blob);

    void WriteTime(int variant, long score, LeaderboardOutcome outcome, byte[] blob);

    Stream GetBlob(string blob);

    Stream GetPicture(uint hPictureGroup, string url);

    void ReleasePictureGroup(uint hPictureGroup);
  }
}
