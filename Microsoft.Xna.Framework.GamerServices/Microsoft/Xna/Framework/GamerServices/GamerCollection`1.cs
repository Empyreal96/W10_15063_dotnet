// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.GamerCollection`1
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework.GamerServices
{
  public class GamerCollection<T> : ReadOnlyCollection<T>, IEnumerable<Gamer>, IEnumerable
    where T : Gamer
  {
    private List<T> wrappedList;
    private static InternalIndexComparer<T> internalIndexComparer;

    internal GamerCollection()
      : base((IList<T>) new List<T>())
    {
      this.wrappedList = (List<T>) this.Items;
    }

    IEnumerator<Gamer> IEnumerable<Gamer>.GetEnumerator()
    {
      foreach (T obj in this)
        yield return (Gamer) obj;
    }

    internal T FindGamerWithInternalIndexAndRemove(int index)
    {
      for (int index1 = 0; index1 < this.wrappedList.Count; ++index1)
      {
        T wrapped = this.wrappedList[index1];
        if (wrapped.InternalIndex == index)
        {
          this.wrappedList.RemoveAt(index1);
          return wrapped;
        }
      }
      throw new InvalidOperationException(FrameworkResources.UnexpectedError);
    }

    internal void Insert(T newGamer)
    {
      int num = this.wrappedList.BinarySearch(newGamer, (IComparer<T>) GamerCollection<T>.internalIndexComparer);
      if (num > 0)
        throw new InvalidOperationException(FrameworkResources.UnexpectedError);
      this.wrappedList.Insert(~num, newGamer);
    }

    public GamerCollection<T>.GamerCollectionEnumerator GetEnumerator() => new GamerCollection<T>.GamerCollectionEnumerator(this.wrappedList.GetEnumerator());

    public struct GamerCollectionEnumerator : IEnumerator<T>, IEnumerator, IDisposable
    {
      private List<T>.Enumerator internalEnumerator;

      internal GamerCollectionEnumerator(List<T>.Enumerator internalEnumerator) => this.internalEnumerator = internalEnumerator;

      public T Current => this.internalEnumerator.Current;

      public void Dispose() => this.internalEnumerator.Dispose();

      public bool MoveNext() => this.internalEnumerator.MoveNext();

      object IEnumerator.Current => (object) this.internalEnumerator.Current;

      void IEnumerator.Reset()
      {
        IEnumerator internalEnumerator = (IEnumerator) this.internalEnumerator;
        internalEnumerator.Reset();
        this.internalEnumerator = (List<T>.Enumerator) internalEnumerator;
      }
    }
  }
}
