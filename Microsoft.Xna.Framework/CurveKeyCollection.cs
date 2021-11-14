// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.CurveKeyCollection
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework
{
  public class CurveKeyCollection : ICollection<CurveKey>, IEnumerable<CurveKey>, IEnumerable
  {
    private List<CurveKey> Keys = new List<CurveKey>();
    internal float TimeRange;
    internal float InvTimeRange;
    internal bool IsCacheAvailable = true;

    public int IndexOf(CurveKey item) => this.Keys.IndexOf(item);

    public void RemoveAt(int index)
    {
      this.Keys.RemoveAt(index);
      this.IsCacheAvailable = false;
    }

    public CurveKey this[int index]
    {
      get => this.Keys[index];
      set
      {
        if (value == (CurveKey) null)
          throw new ArgumentNullException();
        if ((double) this.Keys[index].Position == (double) value.Position)
        {
          this.Keys[index] = value;
        }
        else
        {
          this.Keys.RemoveAt(index);
          this.Add(value);
        }
      }
    }

    public void Add(CurveKey item)
    {
      int index = !(item == (CurveKey) null) ? this.Keys.BinarySearch(item) : throw new ArgumentNullException();
      if (index >= 0)
      {
        while (index < this.Keys.Count && (double) item.Position == (double) this.Keys[index].Position)
          ++index;
      }
      else
        index = ~index;
      this.Keys.Insert(index, item);
      this.IsCacheAvailable = false;
    }

    public void Clear()
    {
      this.Keys.Clear();
      this.TimeRange = this.InvTimeRange = 0.0f;
      this.IsCacheAvailable = false;
    }

    public bool Contains(CurveKey item) => this.Keys.Contains(item);

    public void CopyTo(CurveKey[] array, int arrayIndex)
    {
      this.Keys.CopyTo(array, arrayIndex);
      this.IsCacheAvailable = false;
    }

    public int Count => this.Keys.Count;

    public bool IsReadOnly => false;

    public bool Remove(CurveKey item)
    {
      this.IsCacheAvailable = false;
      return this.Keys.Remove(item);
    }

    public IEnumerator<CurveKey> GetEnumerator() => (IEnumerator<CurveKey>) this.Keys.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable) this.Keys).GetEnumerator();

    public CurveKeyCollection Clone() => new CurveKeyCollection()
    {
      Keys = new List<CurveKey>((IEnumerable<CurveKey>) this.Keys),
      InvTimeRange = this.InvTimeRange,
      TimeRange = this.TimeRange,
      IsCacheAvailable = true
    };

    internal void ComputeCacheValues()
    {
      this.TimeRange = this.InvTimeRange = 0.0f;
      if (this.Keys.Count > 1)
      {
        this.TimeRange = this.Keys[this.Keys.Count - 1].Position - this.Keys[0].Position;
        if ((double) this.TimeRange > 1.40129846432482E-45)
          this.InvTimeRange = 1f / this.TimeRange;
      }
      this.IsCacheAvailable = true;
    }
  }
}
