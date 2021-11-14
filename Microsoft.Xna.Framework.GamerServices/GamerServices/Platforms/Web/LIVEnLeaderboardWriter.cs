// Decompiled with JetBrains decompiler
// Type: GamerServices.Platforms.Web.LIVEnLeaderboardWriter
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System.Collections.Generic;

namespace GamerServices.Platforms.Web
{
  internal class LIVEnLeaderboardWriter : LIVEnTask
  {
    private IList<LIVEnLeaderboardWriteEntry> entries;
    private int variant;
    private bool isScoreEntry;

    public LIVEnLeaderboardWriter(
      int variant,
      bool isScoreEntry,
      IList<LIVEnLeaderboardWriteEntry> entries)
    {
      this.variant = variant;
      this.isScoreEntry = isScoreEntry;
      this.entries = entries;
    }

    public override void Do()
    {
      foreach (LIVEnLeaderboardWriteEntry entry in (IEnumerable<LIVEnLeaderboardWriteEntry>) this.entries)
      {
        if (this.isScoreEntry)
          this.webService.WriteScore(this.variant, entry.Rating, entry.Outcome, entry.Blob);
        else
          this.webService.WriteTime(this.variant, entry.Rating, entry.Outcome, entry.Blob);
      }
    }
  }
}
