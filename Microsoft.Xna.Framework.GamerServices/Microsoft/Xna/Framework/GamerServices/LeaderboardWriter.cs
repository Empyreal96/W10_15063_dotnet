// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.LeaderboardWriter
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.GamerServices
{
  public sealed class LeaderboardWriter
  {
    private Gamer gamer;
    private Dictionary<LeaderboardIdentity, LeaderboardEntry> leaderboardEntries = new Dictionary<LeaderboardIdentity, LeaderboardEntry>();

    internal LeaderboardWriter(Gamer gamer) => this.gamer = gamer;

    public LeaderboardEntry GetLeaderboard(LeaderboardIdentity leaderboardId)
    {
      if (Guide.IsTrialMode)
        throw new GamerPrivilegeException(FrameworkResources.TrialMode);
      if (string.IsNullOrEmpty(leaderboardId.Key))
        throw new ArgumentNullException("leaderboardKey");
      LeaderboardEntry leaderboardEntry;
      lock (this.leaderboardEntries)
      {
        if (!this.leaderboardEntries.TryGetValue(leaderboardId, out leaderboardEntry))
        {
          LeaderboardColumnFiller leaderboardColumnFiller = new LeaderboardColumnFiller();
          GamerServicesDispatcher.Gsp.FillLeaderboardColumns(leaderboardId, false, (ILeaderboardColumnFiller) leaderboardColumnFiller);
          leaderboardEntry = new LeaderboardEntry(false);
          leaderboardEntry.Gamer = this.gamer;
          leaderboardEntry.Columns = leaderboardColumnFiller.Target;
          this.leaderboardEntries.Add(leaderboardId, leaderboardEntry);
        }
      }
      return leaderboardEntry;
    }

    internal bool IsChanged
    {
      get
      {
        lock (this.leaderboardEntries)
        {
          foreach (LeaderboardEntry leaderboardEntry in this.leaderboardEntries.Values)
          {
            if (leaderboardEntry.ratingChanged || leaderboardEntry.Columns.ChangedPropertyCount > 0)
              return true;
          }
        }
        return false;
      }
    }

    internal void Reset()
    {
      lock (this.leaderboardEntries)
      {
        foreach (KeyValuePair<LeaderboardIdentity, LeaderboardEntry> leaderboardEntry1 in this.leaderboardEntries)
        {
          LeaderboardEntry leaderboardEntry2 = leaderboardEntry1.Value;
          try
          {
            leaderboardEntry2.Rating = 0L;
            leaderboardEntry2.Columns.Reset();
            leaderboardEntry2.ratingChanged = false;
          }
          finally
          {
            LeaderboardColumnFiller leaderboardColumnFiller = new LeaderboardColumnFiller();
            GamerServicesDispatcher.Gsp.FillLeaderboardColumns(leaderboardEntry1.Key, false, (ILeaderboardColumnFiller) leaderboardColumnFiller);
            leaderboardEntry2.Columns = leaderboardColumnFiller.Target;
          }
        }
      }
    }

    internal void WriteChanges()
    {
      Logger.BeginLogEvent(LoggingEvent.LeaderboardWrite, "XNA: Begin LeaderboardWrite");
      lock (this.leaderboardEntries)
      {
        foreach (KeyValuePair<LeaderboardIdentity, LeaderboardEntry> leaderboardEntry in this.leaderboardEntries)
        {
          if (leaderboardEntry.Value.ratingChanged || leaderboardEntry.Value.Columns.ChangedPropertyCount > 0)
          {
            LeaderboardEntryCollectionFiller collectionFiller = new LeaderboardEntryCollectionFiller(leaderboardEntry.Key, leaderboardEntry.Value);
            GamerServicesDispatcher.Gsp.WriteToLeaderboard(leaderboardEntry.Key, (IPropertyCollectionFiller) collectionFiller);
          }
        }
      }
      Logger.EndLogEvent(LoggingEvent.LeaderboardWrite, "XNA: End LeaderboardWrite");
    }
  }
}
