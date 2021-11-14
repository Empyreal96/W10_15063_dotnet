// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.ReadOnlyCollection`1
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class ReadOnlyCollection<T> : 
    ICollection,
    IEnumerable,
    ICollection<T>,
    IEnumerable<T>
  {
    private T[] _items;

    internal ReadOnlyCollection(T[] items)
    {
      this._items = items;
      for (int index = 0; index < items.Length; ++index)
        Debug.Assert((object) items[index] != null, "null item");
    }

    public void CopyTo(T[] array, int arrayIndex) => Array.Copy((Array) this._items, 0, (Array) array, arrayIndex, this._items.Length);

    void ICollection.CopyTo(Array array, int arrayIndex) => Array.Copy((Array) this._items, 0, array, arrayIndex, this._items.Length);

    IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>) new ReadOnlyCollection<T>.Enumerator<T>(this._items);

    public IEnumerator GetEnumerator() => (IEnumerator) new ReadOnlyCollection<T>.Enumerator<T>(this._items);

    bool ICollection.IsSynchronized => false;

    object ICollection.SyncRoot => (object) this._items;

    bool ICollection<T>.IsReadOnly => true;

    void ICollection<T>.Add(T value) => throw new NotSupportedException();

    void ICollection<T>.Clear() => throw new NotSupportedException();

    bool ICollection<T>.Contains(T value) => Array.IndexOf<T>(this._items, value) >= 0;

    bool ICollection<T>.Remove(T value) => throw new NotSupportedException();

    public int Count => this._items.Length;

    internal struct Enumerator<K> : IEnumerator<K>, IEnumerator, IDisposable
    {
      private K[] _items;
      private int _index;

      internal Enumerator(K[] items)
      {
        this._items = items;
        this._index = -1;
      }

      public void Dispose()
      {
      }

      public bool MoveNext() => ++this._index < this._items.Length;

      public K Current => this._items[this._index];

      object IEnumerator.Current => (object) this._items[this._index];

      void IEnumerator.Reset() => this._index = -1;
    }
  }
}
