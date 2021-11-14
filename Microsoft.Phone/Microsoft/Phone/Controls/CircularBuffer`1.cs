// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.CircularBuffer`1
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls.Properties;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Phone.Controls
{
  internal class CircularBuffer<TItem> : IEnumerable<TItem>, IEnumerable
  {
    private const int InitialSize = 10;
    private TItem[] _data;
    private int _head;
    private int _tail;
    private int _generation;

    public CircularBuffer(int initialSize = 10)
    {
      this._data = new TItem[initialSize];
      this._tail = this._data.Length - 1;
    }

    public int Count { get; protected set; }

    public TItem Head => this.Count != 0 ? this._data[this._head] : default (TItem);

    public TItem Tail => this.Count != 0 ? this._data[this._tail] : default (TItem);

    public void Clear()
    {
      this._data = new TItem[this._data.Length];
      this.Count = this._head = 0;
      this._tail = this._data.Length - 1;
    }

    public TItem DequeueHead()
    {
      if (this.Count == 0)
        throw new InvalidOperationException(Resources.CircularBuffer_RemoveWhenEmpty);
      TItem obj = this._data[this._head];
      this._data[this._head] = default (TItem);
      this._head = this.GetNext(this._head);
      --this.Count;
      this._generation = (this._generation + 1) % int.MaxValue;
      return obj;
    }

    public TItem DequeueTail()
    {
      if (this.Count == 0)
        throw new InvalidOperationException(Resources.CircularBuffer_RemoveWhenEmpty);
      TItem obj = this._data[this._tail];
      this._data[this._tail] = default (TItem);
      --this.Count;
      this._tail = this.GetPrevious(this._tail);
      this._generation = (this._generation + 1) % int.MaxValue;
      return obj;
    }

    public void EnqueueHead(TItem value)
    {
      if (this.Count == this._data.Length)
        this.IncreaseSpace();
      this._head = this.GetPrevious(this._head);
      this._data[this._head] = value;
      ++this.Count;
      this._generation = (this._generation + 1) % int.MaxValue;
    }

    public void EnqueueTail(TItem value)
    {
      if (this.Count == this._data.Length)
        this.IncreaseSpace();
      this._tail = this.GetNext(this._tail);
      this._data[this._tail] = value;
      ++this.Count;
      this._generation = (this._generation + 1) % int.MaxValue;
    }

    public IEnumerator<TItem> GetEnumerator() => (IEnumerator<TItem>) new CircularBuffer<TItem>.Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    private void IncreaseSpace()
    {
      TItem[] objArray = new TItem[this._data.Length * 2];
      int length = this._data.Length;
      int index = this._head;
      int num = 0;
      while (length-- > 0)
      {
        objArray[num++] = this._data[index];
        index = this.GetNext(index);
      }
      this._data = objArray;
      this._head = 0;
      this._tail = num - 1;
    }

    private int GetNext(int index)
    {
      ++index;
      if (index >= this._data.Length)
        index = 0;
      return index;
    }

    private int GetPrevious(int index)
    {
      --index;
      if (index < 0)
        index = this._data.Length - 1;
      return index;
    }

    private class Enumerator : IEnumerator<TItem>, IEnumerator, IDisposable
    {
      private CircularBuffer<TItem> _source;
      private int _count;
      private int _index;
      private TItem _current;
      private int _generation;

      internal Enumerator(CircularBuffer<TItem> source)
      {
        this._source = source;
        this._generation = this._source._generation;
        this.Reset();
      }

      public TItem Current => this._current;

      public void Dispose()
      {
      }

      object IEnumerator.Current => (object) this._current;

      public bool MoveNext()
      {
        if (this._generation != this._source._generation)
          throw new InvalidOperationException(Resources.CircularBuffer_EnumeratorVersionChanged);
        int num = this._count < this._source.Count ? 1 : 0;
        if (num == 0)
          return num != 0;
        this._index = this._source.GetNext(this._index);
        this._current = this._source._data[this._index];
        ++this._count;
        return num != 0;
      }

      public void Reset()
      {
        this._count = 0;
        this._index = this._source.GetPrevious(this._source._head);
        this._current = default (TItem);
      }
    }
  }
}
