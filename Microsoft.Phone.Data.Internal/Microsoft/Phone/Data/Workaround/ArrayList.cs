// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Workaround.ArrayList
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Threading;

namespace Microsoft.Phone.Data.Workaround
{
  public class ArrayList : IList, ICollection, IEnumerable, ICloneable
  {
    private object[] _items;
    private int _size;
    private int _version;
    private object _syncRoot;
    private const int _defaultCapacity = 4;
    private static readonly object[] emptyArray = new object[0];

    internal ArrayList(bool trash)
    {
    }

    public ArrayList() => this._items = ArrayList.emptyArray;

    public ArrayList(int capacity) => this._items = new object[capacity];

    public ArrayList(ICollection c)
    {
      this._items = c != null ? new object[c.Count] : throw new ArgumentNullException();
      this.AddRange(c);
    }

    public virtual int Capacity
    {
      get => this._items.Length;
      set => this.InternalSetCapacity(value, true);
    }

    private void InternalSetCapacity(int value, bool updateVersion)
    {
      if (value == this._items.Length)
        return;
      if (value < this._size)
        throw new ArgumentOutOfRangeException();
      if (value > 0)
      {
        object[] objArray = new object[value];
        if (this._size > 0)
          Array.Copy((Array) this._items, 0, (Array) objArray, 0, this._size);
        this._items = objArray;
      }
      else
        this._items = new object[4];
      if (!updateVersion)
        return;
      ++this._version;
    }

    public virtual int Count => this._size;

    public virtual bool IsFixedSize => false;

    public virtual bool IsReadOnly => false;

    public virtual bool IsSynchronized => false;

    public virtual object SyncRoot
    {
      get
      {
        if (this._syncRoot == null)
          Interlocked.CompareExchange(ref this._syncRoot, new object(), (object) null);
        return this._syncRoot;
      }
    }

    public virtual object this[int index]
    {
      get => index >= 0 && index < this._size ? this._items[index] : throw new ArgumentOutOfRangeException(nameof (index));
      set
      {
        if (index < 0 || index >= this._size)
          throw new ArgumentOutOfRangeException(nameof (index));
        this._items[index] = value;
        ++this._version;
      }
    }

    public virtual int Add(object value)
    {
      if (this._size == this._items.Length)
        this.EnsureCapacity(this._size + 1);
      this._items[this._size] = value;
      ++this._version;
      return this._size++;
    }

    public virtual void AddRange(ICollection c) => this.InsertRange(this._size, c);

    public virtual int BinarySearch(int index, int count, object value, IComparer comparer)
    {
      if (index < 0 || count < 0)
        throw new ArgumentOutOfRangeException();
      if (this._size - index < count)
        throw new ArgumentException();
      return Array.BinarySearch((Array) this._items, index, count, value, comparer);
    }

    public virtual void Clear()
    {
      Array.Clear((Array) this._items, 0, this._size);
      this._size = 0;
      ++this._version;
    }

    public virtual object Clone()
    {
      ArrayList arrayList = new ArrayList(this._size);
      arrayList._size = this._size;
      arrayList._version = this._version;
      Array.Copy((Array) this._items, 0, (Array) arrayList._items, 0, this._size);
      return (object) arrayList;
    }

    public virtual bool Contains(object item)
    {
      if (item == null)
      {
        for (int index = 0; index < this._size; ++index)
        {
          if (this._items[index] == null)
            return true;
        }
        return false;
      }
      for (int index = 0; index < this._size; ++index)
      {
        if (item.Equals(this._items[index]))
          return true;
      }
      return false;
    }

    public virtual void CopyTo(Array array) => this.CopyTo(array, 0);

    public virtual void CopyTo(Array array, int arrayIndex)
    {
      if (array != null && array.Rank != 1)
        throw new ArgumentException();
      Array.Copy((Array) this._items, 0, array, arrayIndex, this._size);
    }

    public virtual void CopyTo(int index, Array array, int arrayIndex, int count)
    {
      if (this._size - index < count)
        throw new ArgumentException();
      if (array != null && array.Rank != 1)
        throw new ArgumentException();
      Array.Copy((Array) this._items, index, array, arrayIndex, count);
    }

    private void EnsureCapacity(int min)
    {
      if (this._items.Length >= min)
        return;
      int num = this._items.Length == 0 ? 4 : this._items.Length * 2;
      if (num < min)
        num = min;
      this.InternalSetCapacity(num, false);
    }

    public virtual IEnumerator GetEnumerator() => (IEnumerator) new ArrayList.ArrayListEnumeratorSimple(this);

    public virtual int IndexOf(object value) => Array.IndexOf((Array) this._items, value, 0, this._size);

    public virtual int IndexOf(object value, int startIndex, int count)
    {
      if (startIndex > this._size)
        throw new ArgumentOutOfRangeException();
      if (count < 0 || startIndex > this._size - count)
        throw new ArgumentOutOfRangeException();
      return Array.IndexOf((Array) this._items, value, startIndex, count);
    }

    public virtual void Insert(int index, object value)
    {
      if (index < 0 || index > this._size)
        throw new ArgumentOutOfRangeException();
      if (this._size == this._items.Length)
        this.EnsureCapacity(this._size + 1);
      if (index < this._size)
        Array.Copy((Array) this._items, index, (Array) this._items, index + 1, this._size - index);
      this._items[index] = value;
      ++this._size;
      ++this._version;
    }

    public virtual void InsertRange(int index, ICollection c)
    {
      if (c == null)
        throw new ArgumentNullException();
      if (index < 0 || index > this._size)
        throw new ArgumentOutOfRangeException();
      int count = c.Count;
      if (count <= 0)
        return;
      this.EnsureCapacity(this._size + count);
      if (this.SyncRoot == c.SyncRoot)
      {
        object[] objArray = new object[c.Count];
        c.CopyTo((Array) objArray, 0);
        c = (ICollection) objArray;
      }
      if (index < this._size)
        Array.Copy((Array) this._items, index, (Array) this._items, index + count, this._size - index);
      c.CopyTo((Array) this._items, index);
      this._size += count;
      ++this._version;
    }

    public virtual void Remove(object obj)
    {
      int index = this.IndexOf(obj);
      if (index < 0)
        return;
      this.RemoveAt(index);
    }

    public virtual void RemoveAt(int index)
    {
      if (index < 0 || index >= this._size)
        throw new ArgumentOutOfRangeException();
      --this._size;
      if (index < this._size)
        Array.Copy((Array) this._items, index + 1, (Array) this._items, index, this._size - index);
      this._items[this._size] = (object) null;
      ++this._version;
    }

    public virtual void RemoveRange(int index, int count)
    {
      if (index < 0 || count < 0)
        throw new ArgumentOutOfRangeException();
      if (this._size - index < count)
        throw new ArgumentException();
      if (count <= 0)
        return;
      int size = this._size;
      this._size -= count;
      if (index < this._size)
        Array.Copy((Array) this._items, index + count, (Array) this._items, index, this._size - index);
      while (size > this._size)
        this._items[--size] = (object) null;
      ++this._version;
    }

    public virtual void Reverse() => this.Reverse(0, this.Count);

    public virtual void Reverse(int index, int count)
    {
      if (index < 0 || count < 0)
        throw new ArgumentOutOfRangeException();
      if (this._size - index < count)
        throw new ArgumentException();
      Array.Reverse((Array) this._items, index, count);
      ++this._version;
    }

    public virtual void Sort() => this.Sort(0, this.Count, (IComparer) Comparer.Default);

    public virtual void Sort(IComparer comparer) => this.Sort(0, this.Count, comparer);

    public virtual void Sort(int index, int count, IComparer comparer)
    {
      if (index < 0 || count < 0)
        throw new ArgumentOutOfRangeException();
      if (this._size - index < count)
        throw new ArgumentException();
      Array.Sort((Array) this._items, index, count, comparer);
      ++this._version;
    }

    public static ArrayList Synchronized(ArrayList list) => list != null ? (ArrayList) new ArrayList.SyncArrayList(list) : throw new ArgumentNullException(nameof (list));

    public virtual object[] ToArray()
    {
      object[] objArray = new object[this._size];
      Array.Copy((Array) this._items, 0, (Array) objArray, 0, this._size);
      return objArray;
    }

    public virtual Array ToArray(Type type)
    {
      Array destinationArray = type != null ? Array.CreateInstance(type, this._size) : throw new ArgumentNullException(nameof (type));
      Array.Copy((Array) this._items, 0, destinationArray, 0, this._size);
      return destinationArray;
    }

    public virtual void TrimToSize() => this.Capacity = this._size;

    private class IListWrapper : ArrayList
    {
      private IList _list;

      internal IListWrapper(IList list)
      {
        this._list = list;
        this._version = 0;
      }

      public override int Capacity
      {
        get => this._list.Count;
        set
        {
          if (value < this._list.Count)
            throw new ArgumentOutOfRangeException(nameof (value));
        }
      }

      public override int Count => this._list.Count;

      public override bool IsReadOnly => this._list.IsReadOnly;

      public override bool IsFixedSize => this._list.IsFixedSize;

      public override bool IsSynchronized => this._list.IsSynchronized;

      public override object this[int index]
      {
        get => this._list[index];
        set
        {
          this._list[index] = value;
          ++this._version;
        }
      }

      public override object SyncRoot => this._list.SyncRoot;

      public override int Add(object obj)
      {
        int num = this._list.Add(obj);
        ++this._version;
        return num;
      }

      public override void AddRange(ICollection c) => this.InsertRange(this.Count, c);

      public override int BinarySearch(int index, int count, object value, IComparer comparer)
      {
        if (index < 0 || count < 0)
          throw new ArgumentOutOfRangeException();
        if (this._list.Count - index < count)
          throw new ArgumentException();
        if (comparer == null)
          comparer = (IComparer) Comparer.Default;
        int num1 = index;
        int num2 = index + count - 1;
        while (num1 <= num2)
        {
          int index1 = (num1 + num2) / 2;
          int num3 = comparer.Compare(value, this._list[index1]);
          if (num3 == 0)
            return index1;
          if (num3 < 0)
            num2 = index1 - 1;
          else
            num1 = index1 + 1;
        }
        return ~num1;
      }

      public override void Clear()
      {
        if (this._list.IsFixedSize)
          throw new NotSupportedException();
        this._list.Clear();
        ++this._version;
      }

      public override object Clone() => (object) new ArrayList.IListWrapper(this._list);

      public override bool Contains(object obj) => this._list.Contains(obj);

      public override void CopyTo(Array array, int index) => this._list.CopyTo(array, index);

      public override void CopyTo(int index, Array array, int arrayIndex, int count)
      {
        if (array == null)
          throw new ArgumentNullException();
        if (index < 0 || arrayIndex < 0)
          throw new ArgumentOutOfRangeException();
        if (count < 0)
          throw new ArgumentOutOfRangeException();
        if (array.Length - arrayIndex < count)
          throw new ArgumentException();
        if (this._list.Count - index < count)
          throw new ArgumentException();
        if (array.Rank != 1)
          throw new ArgumentException();
        for (int index1 = index; index1 < index + count; ++index1)
          array.SetValue(this._list[index1], arrayIndex++);
      }

      public override IEnumerator GetEnumerator() => this._list.GetEnumerator();

      public override int IndexOf(object value) => this._list.IndexOf(value);

      public override int IndexOf(object value, int startIndex, int count)
      {
        if (startIndex < 0 || startIndex > this._list.Count)
          throw new ArgumentOutOfRangeException();
        if (count < 0 || startIndex > this._list.Count - count)
          throw new ArgumentOutOfRangeException();
        int num = startIndex + count;
        if (value == null)
        {
          for (int index = startIndex; index < num; ++index)
          {
            if (this._list[index] == null)
              return index;
          }
          return -1;
        }
        for (int index = startIndex; index < num; ++index)
        {
          if (value.Equals(this._list[index]))
            return index;
        }
        return -1;
      }

      public override void Insert(int index, object obj)
      {
        this._list.Insert(index, obj);
        ++this._version;
      }

      public override void InsertRange(int index, ICollection c)
      {
        if (c == null)
          throw new ArgumentNullException();
        if (index < 0 || index > this._list.Count)
          throw new ArgumentOutOfRangeException();
        if (c.Count <= 0)
          return;
        if (this._list is ArrayList list)
        {
          list.InsertRange(index, c);
        }
        else
        {
          foreach (object obj in (IEnumerable) c)
            this._list.Insert(index++, obj);
        }
        ++this._version;
      }

      public override void Remove(object value)
      {
        int index = this.IndexOf(value);
        if (index < 0)
          return;
        this.RemoveAt(index);
      }

      public override void RemoveAt(int index)
      {
        this._list.RemoveAt(index);
        ++this._version;
      }

      public override void RemoveRange(int index, int count)
      {
        if (index < 0 || count < 0)
          throw new ArgumentOutOfRangeException();
        if (this._list.Count - index < count)
          throw new ArgumentException();
        if (count > 0)
          ++this._version;
        for (; count > 0; --count)
          this._list.RemoveAt(index);
      }

      public override void Reverse(int index, int count)
      {
        if (index < 0 || count < 0)
          throw new ArgumentOutOfRangeException();
        if (this._list.Count - index < count)
          throw new ArgumentException();
        int index1 = index;
        object obj;
        for (int index2 = index + count - 1; index1 < index2; this._list[index2--] = obj)
        {
          obj = this._list[index1];
          this._list[index1++] = this._list[index2];
        }
        ++this._version;
      }

      public override void Sort(int index, int count, IComparer comparer)
      {
        if (index < 0 || count < 0)
          throw new ArgumentOutOfRangeException();
        if (this._list.Count - index < count)
          throw new ArgumentException();
        object[] objArray = new object[count];
        this.CopyTo(index, (Array) objArray, 0, count);
        Array.Sort((Array) objArray, 0, count, comparer);
        for (int index1 = 0; index1 < count; ++index1)
          this._list[index1 + index] = objArray[index1];
        ++this._version;
      }

      public override object[] ToArray()
      {
        object[] objArray = new object[this.Count];
        this._list.CopyTo((Array) objArray, 0);
        return objArray;
      }

      public override Array ToArray(Type type)
      {
        if (type == null)
          throw new ArgumentNullException();
        Array instance = Array.CreateInstance(type, this._list.Count);
        this._list.CopyTo(instance, 0);
        return instance;
      }

      public override void TrimToSize()
      {
      }

      private sealed class IListWrapperEnumWrapper : IEnumerator, ICloneable
      {
        private IEnumerator _en;
        private int _remaining;
        private int _initialStartIndex;
        private int _initialCount;
        private bool _firstCall;

        private IListWrapperEnumWrapper()
        {
        }

        internal IListWrapperEnumWrapper(
          ArrayList.IListWrapper listWrapper,
          int startIndex,
          int count)
        {
          this._en = listWrapper.GetEnumerator();
          this._initialStartIndex = startIndex;
          this._initialCount = count;
          do
            ;
          while (startIndex-- > 0 && this._en.MoveNext());
          this._remaining = count;
          this._firstCall = true;
        }

        public object Clone() => (object) new ArrayList.IListWrapper.IListWrapperEnumWrapper()
        {
          _en = (IEnumerator) ((ICloneable) this._en).Clone(),
          _initialStartIndex = this._initialStartIndex,
          _initialCount = this._initialCount,
          _remaining = this._remaining,
          _firstCall = this._firstCall
        };

        public bool MoveNext()
        {
          if (this._firstCall)
          {
            this._firstCall = false;
            return this._remaining-- > 0 && this._en.MoveNext();
          }
          return this._remaining >= 0 && this._en.MoveNext() && this._remaining-- > 0;
        }

        public object Current
        {
          get
          {
            if (this._firstCall)
              throw new InvalidOperationException();
            if (this._remaining < 0)
              throw new InvalidOperationException();
            return this._en.Current;
          }
        }

        public void Reset()
        {
          this._en.Reset();
          int initialStartIndex = this._initialStartIndex;
          do
            ;
          while (initialStartIndex-- > 0 && this._en.MoveNext());
          this._remaining = this._initialCount;
          this._firstCall = true;
        }
      }
    }

    private sealed class ArrayListEnumeratorSimple : IEnumerator, ICloneable
    {
      private ArrayList list;
      private int index;
      private int version;
      private object currentElement;
      private bool isArrayList;

      internal ArrayListEnumeratorSimple(ArrayList list)
      {
        this.list = list;
        this.index = -1;
        this.version = list._version;
        this.isArrayList = list.GetType() == typeof (ArrayList);
      }

      public object Clone() => this.MemberwiseClone();

      public bool MoveNext()
      {
        if (this.version != this.list._version)
          throw new InvalidOperationException();
        if (this.isArrayList)
        {
          if (this.index < this.list._size - 1)
          {
            this.currentElement = this.list._items[++this.index];
            return true;
          }
          this.index = this.list._size;
          return false;
        }
        if (this.index < this.list.Count - 1)
        {
          this.currentElement = this.list[++this.index];
          return true;
        }
        this.index = this.list.Count;
        return false;
      }

      public object Current
      {
        get
        {
          if (this.index == -1)
            throw new InvalidOperationException();
          if (this.index > (this.isArrayList ? this.list._size : this.list.Count) - 1)
            throw new InvalidOperationException();
          return this.currentElement;
        }
      }

      public void Reset()
      {
        if (this.version != this.list._version)
          throw new InvalidOperationException();
        this.currentElement = (object) null;
        this.index = -1;
      }
    }

    private class SyncArrayList : ArrayList
    {
      private ArrayList _list;
      private object _root;

      internal SyncArrayList(ArrayList list)
        : base(false)
      {
        this._list = list;
        this._root = list.SyncRoot;
      }

      public override int Capacity
      {
        get
        {
          lock (this._root)
            return this._list.Capacity;
        }
        set
        {
          lock (this._root)
            this._list.Capacity = value;
        }
      }

      public override int Count
      {
        get
        {
          lock (this._root)
            return this._list.Count;
        }
      }

      public override bool IsReadOnly => this._list.IsReadOnly;

      public override bool IsFixedSize => this._list.IsFixedSize;

      public override bool IsSynchronized => true;

      public override object this[int index]
      {
        get
        {
          lock (this._root)
            return this._list[index];
        }
        set
        {
          lock (this._root)
            this._list[index] = value;
        }
      }

      public override object SyncRoot => this._root;

      public override int Add(object value)
      {
        lock (this._root)
          return this._list.Add(value);
      }

      public override void AddRange(ICollection c)
      {
        lock (this._root)
          this._list.AddRange(c);
      }

      public override int BinarySearch(int index, int count, object value, IComparer comparer)
      {
        lock (this._root)
          return this._list.BinarySearch(index, count, value, comparer);
      }

      public override void Clear()
      {
        lock (this._root)
          this._list.Clear();
      }

      public override object Clone()
      {
        lock (this._root)
          return (object) new ArrayList.SyncArrayList((ArrayList) this._list.Clone());
      }

      public override bool Contains(object item)
      {
        lock (this._root)
          return this._list.Contains(item);
      }

      public override void CopyTo(Array array, int index)
      {
        lock (this._root)
          this._list.CopyTo(array, index);
      }

      public override void CopyTo(int index, Array array, int arrayIndex, int count)
      {
        lock (this._root)
          this._list.CopyTo(index, array, arrayIndex, count);
      }

      public override IEnumerator GetEnumerator()
      {
        lock (this._root)
          return this._list.GetEnumerator();
      }

      public override int IndexOf(object value)
      {
        lock (this._root)
          return this._list.IndexOf(value);
      }

      public override int IndexOf(object value, int startIndex, int count)
      {
        lock (this._root)
          return this._list.IndexOf(value, startIndex, count);
      }

      public override void Insert(int index, object value)
      {
        lock (this._root)
          this._list.Insert(index, value);
      }

      public override void InsertRange(int index, ICollection c)
      {
        lock (this._root)
          this._list.InsertRange(index, c);
      }

      public override void Remove(object value)
      {
        lock (this._root)
          this._list.Remove(value);
      }

      public override void RemoveAt(int index)
      {
        lock (this._root)
          this._list.RemoveAt(index);
      }

      public override void RemoveRange(int index, int count)
      {
        lock (this._root)
          this._list.RemoveRange(index, count);
      }

      public override void Reverse(int index, int count)
      {
        lock (this._root)
          this._list.Reverse(index, count);
      }

      public override void Sort(int index, int count, IComparer comparer)
      {
        lock (this._root)
          this._list.Sort(index, count, comparer);
      }

      public override object[] ToArray()
      {
        lock (this._root)
          return this._list.ToArray();
      }

      public override Array ToArray(Type type)
      {
        lock (this._root)
          return this._list.ToArray(type);
      }

      public override void TrimToSize()
      {
        lock (this._root)
          this._list.TrimToSize();
      }
    }
  }
}
