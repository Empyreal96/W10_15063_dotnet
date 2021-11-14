// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.LeaderboardIdentity
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

namespace Microsoft.Xna.Framework.GamerServices
{
  public struct LeaderboardIdentity
  {
    public string Key { get; set; }

    public int GameMode { get; set; }

    public static LeaderboardIdentity Create(LeaderboardKey key, int gameMode) => new LeaderboardIdentity()
    {
      Key = key.ToString(),
      GameMode = gameMode
    };

    public static LeaderboardIdentity Create(LeaderboardKey key) => LeaderboardIdentity.Create(key, 0);
  }
}
