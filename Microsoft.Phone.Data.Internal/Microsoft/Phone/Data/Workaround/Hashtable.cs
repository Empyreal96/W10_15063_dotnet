// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Workaround.Hashtable
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Microsoft.Phone.Data.Workaround
{
  public class Hashtable : IDictionary, ICollection, IEnumerable, ICloneable
  {
    private Hashtable.bucket[] buckets;
    private int count;
    private int occupancy;
    private int loadsize;
    private float loadFactor;
    private int version;
    private bool isWriterInProgress;
    private ICollection keys;
    private ICollection values;
    private IEqualityComparer _keycomparer;
    private object _syncRoot;

    [Obsolete("Please use KeyComparer properties.")]
    protected IHashCodeProvider hcp
    {
      get => this._keycomparer is CompatibleComparer ? ((CompatibleComparer) this._keycomparer).HashCodeProvider : throw new ArgumentException((string) null);
      set
      {
        if (this._keycomparer is CompatibleComparer)
          this._keycomparer = (IEqualityComparer) new CompatibleComparer(((CompatibleComparer) this._keycomparer).Comparer, value);
        else
          this._keycomparer = this._keycomparer == null ? (IEqualityComparer) new CompatibleComparer((IComparer) null, value) : throw new ArgumentException((string) null, nameof (value));
      }
    }

    [Obsolete("Please use KeyComparer properties.")]
    protected IComparer comparer
    {
      get => this._keycomparer is CompatibleComparer ? ((CompatibleComparer) this._keycomparer).Comparer : throw new ArgumentException((string) null);
      set
      {
        if (this._keycomparer is CompatibleComparer)
        {
          CompatibleComparer keycomparer = (CompatibleComparer) this._keycomparer;
          this._keycomparer = (IEqualityComparer) new CompatibleComparer(value, keycomparer.HashCodeProvider);
        }
        else
          this._keycomparer = this._keycomparer == null ? (IEqualityComparer) new CompatibleComparer(value, (IHashCodeProvider) null) : throw new ArgumentException((string) null, nameof (value));
      }
    }

    protected IEqualityComparer EqualityComparer => this._keycomparer;

    internal Hashtable(bool trash)
    {
    }

    public Hashtable()
      : this(0, 1f)
    {
    }

    public Hashtable(int capacity)
      : this(capacity, 1f)
    {
    }

    public Hashtable(int capacity, float loadFactor)
    {
      if (capacity < 0)
        throw new ArgumentOutOfRangeException(nameof (capacity));
      if ((double) loadFactor < 0.100000001490116 || (double) loadFactor > 1.0)
        throw new ArgumentOutOfRangeException(nameof (loadFactor));
      this.loadFactor = 0.72f * loadFactor;
      double num = (double) capacity / (double) this.loadFactor;
      if (num > (double) int.MaxValue)
        throw new ArgumentException();
      int length = num > 11.0 ? HashHelpers.GetPrime((int) num) : 11;
      this.buckets = new Hashtable.bucket[length];
      this.loadsize = (int) ((double) this.loadFactor * (double) length);
      this.isWriterInProgress = false;
      Debug.Assert(this.loadsize < length, "Invalid hashtable loadsize!");
    }

    [Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
    private Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
      : this(capacity, loadFactor)
    {
      if (hcp == null && comparer == null)
        this._keycomparer = (IEqualityComparer) null;
      else
        this._keycomparer = (IEqualityComparer) new CompatibleComparer(comparer, hcp);
    }

    public Hashtable(int capacity, float loadFactor, IEqualityComparer keyComparer)
      : this(capacity, loadFactor)
    {
      this._keycomparer = keyComparer;
    }

    [Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
    public Hashtable(IHashCodeProvider hcp, IComparer comparer)
      : this(0, 1f, hcp, comparer)
    {
    }

    public Hashtable(IEqualityComparer keyComparer)
      : this(0, 1f, keyComparer)
    {
    }

    [Obsolete("Please use Hashtable(int, IEqualityComparer) instead.")]
    public Hashtable(int capacity, IHashCodeProvider hcp, IComparer comparer)
      : this(capacity, 1f, hcp, comparer)
    {
    }

    public Hashtable(int capacity, IEqualityComparer keyComparer)
      : this(capacity, 1f, keyComparer)
    {
    }

    public Hashtable(IDictionary d)
      : this(d, 1f)
    {
    }

    public Hashtable(IDictionary d, float loadFactor)
      : this(d, loadFactor, (IEqualityComparer) null)
    {
    }

    [Obsolete("Please use Hashtable(IDictionary, IEqualityComparer) instead.")]
    public Hashtable(IDictionary d, IHashCodeProvider hcp, IComparer comparer)
      : this(d, 1f, hcp, comparer)
    {
    }

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "keycomparer")]
    public Hashtable(IDictionary d, IEqualityComparer keycomparer)
      : this(d, 1f, keycomparer)
    {
    }

    [Obsolete("Please use Hashtable(IDictionary, float, IEqualityComparer) instead.")]
    private Hashtable(IDictionary d, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
      : this(d != null ? d.Count : 0, loadFactor, hcp, comparer)
    {
      IDictionaryEnumerator dictionaryEnumerator = d != null ? d.GetEnumerator() : throw new ArgumentNullException(nameof (d));
      while (dictionaryEnumerator.MoveNext())
        this.Add(dictionaryEnumerator.Key, dictionaryEnumerator.Value);
    }

    public Hashtable(IDictionary d, float loadFactor, IEqualityComparer keyComparer)
      : this(d != null ? d.Count : 0, loadFactor, keyComparer)
    {
      IDictionaryEnumerator dictionaryEnumerator = d != null ? d.GetEnumerator() : throw new ArgumentNullException(nameof (d));
      while (dictionaryEnumerator.MoveNext())
        this.Add(dictionaryEnumerator.Key, dictionaryEnumerator.Value);
    }

    private uint InitHash(object key, int hashsize, out uint seed, out uint incr)
    {
      uint num = (uint) (this.GetHash(key) & int.MaxValue);
      seed = num;
      incr = 1U + ((seed >> 5) + 1U) % (uint) (hashsize - 1);
      return num;
    }

    public virtual void Add(object key, object value) => this.Insert(key, value, true);

    public virtual void Clear()
    {
      if (this.count == 0)
        return;
      this.isWriterInProgress = true;
      for (int index = 0; index < this.buckets.Length; ++index)
      {
        this.buckets[index].hash_coll = 0;
        this.buckets[index].key = (object) null;
        this.buckets[index].val = (object) null;
      }
      this.count = 0;
      this.occupancy = 0;
      this.UpdateVersion();
      this.isWriterInProgress = false;
    }

    public virtual object Clone()
    {
      Hashtable.bucket[] buckets = this.buckets;
      Hashtable hashtable = new Hashtable(this.count, this._keycomparer);
      hashtable.version = this.version;
      hashtable.loadFactor = this.loadFactor;
      hashtable.count = 0;
      int length = buckets.Length;
      while (length > 0)
      {
        --length;
        object key = buckets[length].key;
        if (key != null && key != buckets)
          hashtable[key] = buckets[length].val;
      }
      return (object) hashtable;
    }

    public virtual bool Contains(object key) => this.ContainsKey(key);

    public virtual bool ContainsKey(object key)
    {
      if (key == null)
        throw new ArgumentNullException(nameof (key));
      Hashtable.bucket[] buckets = this.buckets;
      uint seed;
      uint incr;
      uint num1 = this.InitHash(key, buckets.Length, out seed, out incr);
      int num2 = 0;
      int index = (int) (seed % (uint) buckets.Length);
      Hashtable.bucket bucket;
      do
      {
        bucket = buckets[index];
        if (bucket.key == null)
          return false;
        if ((long) (bucket.hash_coll & int.MaxValue) == (long) num1 && this.KeyEquals(bucket.key, key))
          return true;
        index = (int) (((long) index + (long) incr) % (long) (uint) buckets.Length);
      }
      while (bucket.hash_coll < 0 && ++num2 < buckets.Length);
      return false;
    }

    public virtual bool ContainsValue(object value)
    {
      if (value == null)
      {
        int length = this.buckets.Length;
        while (--length >= 0)
        {
          if (this.buckets[length].key != null && this.buckets[length].key != this.buckets && this.buckets[length].val == null)
            return true;
        }
      }
      else
      {
        int length = this.buckets.Length;
        while (--length >= 0)
        {
          object val = this.buckets[length].val;
          if (val != null && value.Equals(val))
            return true;
        }
      }
      return false;
    }

    private void CopyKeys(Array array, int arrayIndex)
    {
      Hashtable.bucket[] buckets = this.buckets;
      int length = buckets.Length;
      while (--length >= 0)
      {
        object key = buckets[length].key;
        if (key != null && key != this.buckets)
          array.SetValue(key, arrayIndex++);
      }
    }

    private void CopyEntries(Array array, int arrayIndex)
    {
      Hashtable.bucket[] buckets = this.buckets;
      int length = buckets.Length;
      while (--length >= 0)
      {
        object key = buckets[length].key;
        if (key != null && key != this.buckets)
        {
          DictionaryEntry dictionaryEntry = new DictionaryEntry(key, buckets[length].val);
          array.SetValue((object) dictionaryEntry, arrayIndex++);
        }
      }
    }

    public virtual void CopyTo(Array array, int arrayIndex)
    {
      if (array == null)
        throw new ArgumentNullException(nameof (array));
      if (array.Rank != 1)
        throw new ArgumentException();
      if (arrayIndex < 0)
        throw new ArgumentOutOfRangeException(nameof (arrayIndex));
      if (array.Length - arrayIndex < this.count)
        throw new ArgumentException();
      this.CopyEntries(array, arrayIndex);
    }

    private void CopyValues(Array array, int arrayIndex)
    {
      Hashtable.bucket[] buckets = this.buckets;
      int length = buckets.Length;
      while (--length >= 0)
      {
        object key = buckets[length].key;
        if (key != null && key != this.buckets)
          array.SetValue(buckets[length].val, arrayIndex++);
      }
    }

    public virtual object this[object key]
    {
      get
      {
        if (key == null)
          throw new ArgumentNullException(nameof (key));
        Hashtable.bucket[] buckets = this.buckets;
        uint seed;
        uint incr;
        uint num1 = this.InitHash(key, buckets.Length, out seed, out incr);
        int num2 = 0;
        int index = (int) (seed % (uint) buckets.Length);
        Hashtable.bucket bucket;
        do
        {
          int num3 = 0;
          int version;
          do
          {
            version = this.version;
            bucket = buckets[index];
            if (++num3 % 8 == 0)
              Thread.Sleep(1);
          }
          while (this.isWriterInProgress || version != this.version);
          if (bucket.key == null)
            return (object) null;
          if ((long) (bucket.hash_coll & int.MaxValue) == (long) num1 && this.KeyEquals(key, bucket.key))
            return bucket.val;
          index = (int) (((long) index + (long) incr) % (long) (uint) buckets.Length);
        }
        while (bucket.hash_coll < 0 && ++num2 < buckets.Length);
        return (object) null;
      }
      set => this.Insert(key, value, false);
    }

    private void expand() => this.rehash(HashHelpers.GetPrime(this.buckets.Length * 2));

    private void rehash() => this.rehash(this.buckets.Length);

    private void UpdateVersion() => ++this.version;

    private void rehash(int newsize)
    {
      this.occupancy = 0;
      Hashtable.bucket[] newBuckets = new Hashtable.bucket[newsize];
      for (int index = 0; index < this.buckets.Length; ++index)
      {
        Hashtable.bucket bucket = this.buckets[index];
        if (bucket.key != null && bucket.key != this.buckets)
          this.putEntry(newBuckets, bucket.key, bucket.val, bucket.hash_coll & int.MaxValue);
      }
      this.isWriterInProgress = true;
      this.buckets = newBuckets;
      this.loadsize = (int) ((double) this.loadFactor * (double) newsize);
      this.UpdateVersion();
      this.isWriterInProgress = false;
      Debug.Assert(this.loadsize < newsize, "Our current implementaion means this is not possible.");
    }

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) new Hashtable.HashtableEnumerator(this, 3);

    public virtual IDictionaryEnumerator GetEnumerator() => (IDictionaryEnumerator) new Hashtable.HashtableEnumerator(this, 3);

    protected virtual int GetHash(object key) => this._keycomparer != null ? this._keycomparer.GetHashCode(key) : key.GetHashCode();

    public virtual bool IsReadOnly => false;

    public virtual bool IsFixedSize => false;

    public virtual bool IsSynchronized => false;

    protected virtual bool KeyEquals(object item, object key)
    {
      if (this.buckets == item || this.buckets == key)
        return false;
      return this._keycomparer != null ? this._keycomparer.Equals(item, key) : item.Equals(key);
    }

    public virtual ICollection Keys
    {
      get
      {
        if (this.keys == null)
          this.keys = (ICollection) new Hashtable.KeyCollection(this);
        return this.keys;
      }
    }

    public virtual ICollection Values
    {
      get
      {
        if (this.values == null)
          this.values = (ICollection) new Hashtable.ValueCollection(this);
        return this.values;
      }
    }

    private void Insert(object key, object nvalue, bool add)
    {
      if (key == null)
        throw new ArgumentNullException(nameof (key));
      if (this.count >= this.loadsize)
        this.expand();
      else if (this.occupancy > this.loadsize && this.count > 100)
        this.rehash();
      uint seed;
      uint incr;
      uint num1 = this.InitHash(key, this.buckets.Length, out seed, out incr);
      int num2 = 0;
      int index1 = -1;
      int index2 = (int) (seed % (uint) this.buckets.Length);
      do
      {
        if (index1 == -1 && this.buckets[index2].key == this.buckets && this.buckets[index2].hash_coll < 0)
          index1 = index2;
        if (this.buckets[index2].key == null || this.buckets[index2].key == this.buckets && ((long) this.buckets[index2].hash_coll & 2147483648L) == 0L)
        {
          if (index1 != -1)
            index2 = index1;
          this.isWriterInProgress = true;
          this.buckets[index2].val = nvalue;
          this.buckets[index2].key = key;
          this.buckets[index2].hash_coll |= (int) num1;
          ++this.count;
          this.UpdateVersion();
          this.isWriterInProgress = false;
          return;
        }
        if ((long) (this.buckets[index2].hash_coll & int.MaxValue) == (long) num1 && this.KeyEquals(key, this.buckets[index2].key))
        {
          if (add)
            throw new ArgumentException();
          this.isWriterInProgress = true;
          this.buckets[index2].val = nvalue;
          this.UpdateVersion();
          this.isWriterInProgress = false;
          return;
        }
        if (index1 == -1 && this.buckets[index2].hash_coll >= 0)
        {
          this.buckets[index2].hash_coll |= int.MinValue;
          ++this.occupancy;
        }
        index2 = (int) (((long) index2 + (long) incr) % (long) (uint) this.buckets.Length);
      }
      while (++num2 < this.buckets.Length);
      if (index1 != -1)
      {
        this.isWriterInProgress = true;
        this.buckets[index1].val = nvalue;
        this.buckets[index1].key = key;
        this.buckets[index1].hash_coll |= (int) num1;
        ++this.count;
        this.UpdateVersion();
        this.isWriterInProgress = false;
      }
      else
      {
        Debug.Assert(false, "hash table insert failed!  Load factor too high, or our double hashing function is incorrect.");
        throw new InvalidOperationException();
      }
    }

    private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode)
    {
      Debug.Assert(hashcode >= 0, "hashcode >= 0");
      uint num1 = (uint) hashcode;
      uint num2 = 1U + ((num1 >> 5) + 1U) % (uint) (newBuckets.Length - 1);
      int index;
      for (index = (int) (num1 % (uint) newBuckets.Length); newBuckets[index].key != null && newBuckets[index].key != this.buckets; index = (int) (((long) index + (long) num2) % (long) (uint) newBuckets.Length))
      {
        if (newBuckets[index].hash_coll >= 0)
        {
          newBuckets[index].hash_coll |= int.MinValue;
          ++this.occupancy;
        }
      }
      newBuckets[index].val = nvalue;
      newBuckets[index].key = key;
      newBuckets[index].hash_coll |= hashcode;
    }

    public virtual void Remove(object key)
    {
      if (key == null)
        throw new ArgumentNullException(nameof (key));
      uint seed;
      uint incr;
      uint num1 = this.InitHash(key, this.buckets.Length, out seed, out incr);
      int num2 = 0;
      int index = (int) (seed % (uint) this.buckets.Length);
      Hashtable.bucket bucket;
      do
      {
        bucket = this.buckets[index];
        if ((long) (bucket.hash_coll & int.MaxValue) == (long) num1 && this.KeyEquals(key, bucket.key))
        {
          this.isWriterInProgress = true;
          this.buckets[index].hash_coll &= int.MinValue;
          this.buckets[index].key = this.buckets[index].hash_coll == 0 ? (object) null : (object) this.buckets;
          this.buckets[index].val = (object) null;
          --this.count;
          this.UpdateVersion();
          this.isWriterInProgress = false;
          break;
        }
        index = (int) (((long) index + (long) incr) % (long) (uint) this.buckets.Length);
      }
      while (bucket.hash_coll < 0 && ++num2 < this.buckets.Length);
    }

    public virtual object SyncRoot
    {
      get
      {
        if (this._syncRoot == null)
          Interlocked.CompareExchange(ref this._syncRoot, new object(), (object) null);
        return this._syncRoot;
      }
    }

    public virtual int Count => this.count;

    public static Hashtable Synchronized(Hashtable table) => table != null ? (Hashtable) new Hashtable.SyncHashtable(table) : throw new ArgumentNullException(nameof (table));

    private struct bucket
    {
      public object key;
      public object val;
      public int hash_coll;
    }

    private class KeyCollection : ICollection, IEnumerable
    {
      private Hashtable _hashtable;

      internal KeyCollection(Hashtable hashtable) => this._hashtable = hashtable;

      public virtual void CopyTo(Array array, int arrayIndex)
      {
        if (array == null)
          throw new ArgumentNullException(nameof (array));
        if (array.Rank != 1)
          throw new ArgumentException();
        if (arrayIndex < 0)
          throw new ArgumentOutOfRangeException(nameof (arrayIndex));
        if (array.Length - arrayIndex < this._hashtable.count)
          throw new ArgumentException();
        this._hashtable.CopyKeys(array, arrayIndex);
      }

      public virtual IEnumerator GetEnumerator() => (IEnumerator) new Hashtable.HashtableEnumerator(this._hashtable, 1);

      public virtual bool IsSynchronized => this._hashtable.IsSynchronized;

      public virtual object SyncRoot => this._hashtable.SyncRoot;

      public virtual int Count => this._hashtable.count;
    }

    private class ValueCollection : ICollection, IEnumerable
    {
      private Hashtable _hashtable;

      internal ValueCollection(Hashtable hashtable) => this._hashtable = hashtable;

      public virtual void CopyTo(Array array, int arrayIndex)
      {
        if (array == null)
          throw new ArgumentNullException(nameof (array));
        if (array.Rank != 1)
          throw new ArgumentException();
        if (arrayIndex < 0)
          throw new ArgumentOutOfRangeException(nameof (arrayIndex));
        if (array.Length - arrayIndex < this._hashtable.count)
          throw new ArgumentException();
        this._hashtable.CopyValues(array, arrayIndex);
      }

      public virtual IEnumerator GetEnumerator() => (IEnumerator) new Hashtable.HashtableEnumerator(this._hashtable, 2);

      public virtual bool IsSynchronized => this._hashtable.IsSynchronized;

      public virtual object SyncRoot => this._hashtable.SyncRoot;

      public virtual int Count => this._hashtable.count;
    }

    private class SyncHashtable : Hashtable
    {
      protected Hashtable _table;

      internal SyncHashtable(Hashtable table)
        : base(false)
      {
        this._table = table;
      }

      public override int Count => this._table.Count;

      public override bool IsReadOnly => this._table.IsReadOnly;

      public override bool IsFixedSize => this._table.IsFixedSize;

      public override bool IsSynchronized => true;

      public override object this[object key]
      {
        get => this._table[key];
        set
        {
          lock (this._table.SyncRoot)
            this._table[key] = value;
        }
      }

      public override object SyncRoot => this._table.SyncRoot;

      public override void Add(object key, object value)
      {
        lock (this._table.SyncRoot)
          this._table.Add(key, value);
      }

      public override void Clear()
      {
        lock (this._table.SyncRoot)
          this._table.Clear();
      }

      public override bool Contains(object key) => this._table.Contains(key);

      public override bool ContainsKey(object key) => this._table.ContainsKey(key);

      public override bool ContainsValue(object key)
      {
        lock (this._table.SyncRoot)
          return this._table.ContainsValue(key);
      }

      public override void CopyTo(Array array, int arrayIndex)
      {
        lock (this._table.SyncRoot)
          this._table.CopyTo(array, arrayIndex);
      }

      public override object Clone()
      {
        lock (this._table.SyncRoot)
          return (object) Hashtable.Synchronized((Hashtable) this._table.Clone());
      }

      public override IDictionaryEnumerator GetEnumerator() => this._table.GetEnumerator();

      public override ICollection Keys
      {
        get
        {
          lock (this._table.SyncRoot)
            return this._table.Keys;
        }
      }

      public override ICollection Values
      {
        get
        {
          lock (this._table.SyncRoot)
            return this._table.Values;
        }
      }

      public override void Remove(object key)
      {
        lock (this._table.SyncRoot)
          this._table.Remove(key);
      }
    }

    private class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
    {
      private Hashtable hashtable;
      private int bucket;
      private int version;
      private bool current;
      private int getObjectRetType;
      private object currentKey;
      private object currentValue;
      internal const int Keys = 1;
      internal const int Values = 2;
      internal const int DictEntry = 3;

      internal HashtableEnumerator(Hashtable hashtable, int getObjRetType)
      {
        this.hashtable = hashtable;
        this.bucket = hashtable.buckets.Length;
        this.version = hashtable.version;
        this.current = false;
        this.getObjectRetType = getObjRetType;
      }

      public object Clone() => this.MemberwiseClone();

      public virtual object Key
      {
        get
        {
          if (!this.current)
            throw new InvalidOperationException();
          return this.currentKey;
        }
      }

      public virtual bool MoveNext()
      {
        if (this.version != this.hashtable.version)
          throw new InvalidOperationException();
        while (this.bucket > 0)
        {
          --this.bucket;
          object key = this.hashtable.buckets[this.bucket].key;
          if (key != null && key != this.hashtable.buckets)
          {
            this.currentKey = key;
            this.currentValue = this.hashtable.buckets[this.bucket].val;
            this.current = true;
            return true;
          }
        }
        this.current = false;
        return false;
      }

      public virtual DictionaryEntry Entry
      {
        get
        {
          if (!this.current)
            throw new InvalidOperationException();
          return new DictionaryEntry(this.currentKey, this.currentValue);
        }
      }

      public virtual object Current
      {
        get
        {
          if (!this.current)
            throw new InvalidOperationException();
          if (this.getObjectRetType == 1)
            return this.currentKey;
          return this.getObjectRetType == 2 ? this.currentValue : (object) new DictionaryEntry(this.currentKey, this.currentValue);
        }
      }

      public virtual object Value
      {
        get
        {
          if (!this.current)
            throw new InvalidOperationException();
          return this.currentValue;
        }
      }

      public virtual void Reset()
      {
        if (this.version != this.hashtable.version)
          throw new InvalidOperationException();
        this.current = false;
        this.bucket = this.hashtable.buckets.Length;
        this.currentKey = (object) null;
        this.currentValue = (object) null;
      }
    }
  }
}
