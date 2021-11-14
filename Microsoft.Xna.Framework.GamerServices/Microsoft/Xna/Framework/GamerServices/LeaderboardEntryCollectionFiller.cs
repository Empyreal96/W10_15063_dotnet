// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.LeaderboardEntryCollectionFiller
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class LeaderboardEntryCollectionFiller : 
    IPropertyCollectionFiller,
    IEnumerable<IPropertyFiller>,
    IEnumerable
  {
    internal List<LeaderboardEntry> entries;
    internal LeaderboardEntryFiller filler = new LeaderboardEntryFiller();
    internal LeaderboardColumnFiller columnFiller = new LeaderboardColumnFiller();
    private LeaderboardIdentity leaderboardId;
    private bool isReadOnly;

    public LeaderboardEntryCollectionFiller(LeaderboardIdentity leaderboardId, bool isReadOnly)
    {
      this.leaderboardId = leaderboardId;
      this.isReadOnly = isReadOnly;
      this.filler.GamerFiller = new GamerFiller();
    }

    public LeaderboardEntryCollectionFiller(
      LeaderboardIdentity leaderboardId,
      LeaderboardEntry entry)
    {
      this.leaderboardId = leaderboardId;
      this.isReadOnly = false;
      this.entries = new List<LeaderboardEntry>();
      this.entries.Add(entry);
    }

    public void Reserve(int size)
    {
      if (!this.isReadOnly)
        return;
      this.entries = new List<LeaderboardEntry>(size);
      for (int index = 0; index < size; ++index)
        this.entries.Add(new LeaderboardEntry(this.isReadOnly));
    }

    public IEnumerator<IPropertyFiller> GetEnumerator() => (IEnumerator<IPropertyFiller>) new LeaderboardEntryCollectionFiller.Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    public struct Enumerator : IEnumerator<IPropertyFiller>, IEnumerator, IDisposable
    {
      private LeaderboardEntryCollectionFiller owner;
      private int position;

      internal Enumerator(LeaderboardEntryCollectionFiller owner)
      {
        this.owner = owner;
        this.position = -1;
      }

      public IPropertyFiller Current => (IPropertyFiller) this.owner.filler;

      public bool MoveNext()
      {
        ++this.position;
        if (this.position >= this.owner.entries.Count)
        {
          this.position = this.owner.entries.Count;
          this.owner.filler.Target = (LeaderboardEntry) null;
          return false;
        }
        LeaderboardEntry entry = this.owner.entries[this.position];
        this.owner.filler.Target = entry;
        if (this.owner.isReadOnly)
        {
          GamerServicesDispatcher.Gsp.FillLeaderboardColumns(this.owner.leaderboardId, this.owner.isReadOnly, (ILeaderboardColumnFiller) this.owner.columnFiller);
          entry.Columns = this.owner.columnFiller.Target;
        }
        return true;
      }

      void IEnumerator.Reset() => this.position = -1;

      public void Dispose()
      {
      }

      object IEnumerator.Current => (object) this.Current;
    }
  }
}
