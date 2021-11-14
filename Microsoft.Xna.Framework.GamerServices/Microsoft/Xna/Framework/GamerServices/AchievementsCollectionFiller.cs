// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AchievementsCollectionFiller
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class AchievementsCollectionFiller : 
    IPropertyCollectionFiller,
    IEnumerable<IPropertyFiller>,
    IEnumerable
  {
    internal List<Achievement> achivements;
    internal AchievementFiller filler;

    public void Reserve(int size)
    {
      this.achivements = new List<Achievement>(size);
      for (int index = 0; index < size; ++index)
        this.achivements.Add(new Achievement());
    }

    public IEnumerator<IPropertyFiller> GetEnumerator() => (IEnumerator<IPropertyFiller>) new AchievementsCollectionFiller.Enumerator(this.achivements, this.filler);

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    public struct Enumerator : IEnumerator<IPropertyFiller>, IEnumerator, IDisposable
    {
      private List<Achievement> achivements;
      private AchievementFiller filler;
      private int position;

      internal Enumerator(List<Achievement> achivements, AchievementFiller filler)
      {
        this.achivements = achivements;
        this.filler = filler;
        this.position = -1;
      }

      public IPropertyFiller Current => (IPropertyFiller) this.filler;

      public bool MoveNext()
      {
        ++this.position;
        if (this.position >= this.achivements.Count)
        {
          this.position = this.achivements.Count;
          this.filler.Target = (Achievement) null;
          return false;
        }
        this.filler.Target = this.achivements[this.position];
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
