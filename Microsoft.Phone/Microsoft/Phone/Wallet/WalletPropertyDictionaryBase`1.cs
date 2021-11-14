// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletPropertyDictionaryBase`1
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Phone.Wallet
{
  internal abstract class WalletPropertyDictionaryBase<T> : 
    IDictionary<string, T>,
    ICollection<KeyValuePair<string, T>>,
    IEnumerable<KeyValuePair<string, T>>,
    IEnumerable
    where T : WalletPropertyBase, new()
  {
    private Dictionary<string, T> _properties = new Dictionary<string, T>();
    private Dictionary<string, T> _propertiesPendingDelete = new Dictionary<string, T>();

    internal Dictionary<string, T> Properties => this._properties;

    internal Dictionary<string, T> PropertiesPendingDelete => this._propertiesPendingDelete;

    internal WalletItem OwnerItem { get; set; }

    protected abstract int MaxPropertiesAllowedInDictionary { get; }

    internal WalletPropertyDictionaryBase(WalletItem owner)
    {
      this.OwnerItem = owner;
      this.RefreshCacheFromDB();
    }

    internal abstract List<T> GetFreshListFromDB();

    internal void RefreshCacheFromDB()
    {
      List<T> freshListFromDb = this.GetFreshListFromDB();
      if (freshListFromDb == null || freshListFromDb.Count <= 0)
        return;
      Dictionary<string, T> dictionary = new Dictionary<string, T>();
      foreach (T obj in freshListFromDb)
      {
        if (this.Properties.ContainsKey(obj.Key))
        {
          T property = this.Properties[obj.Key];
          dictionary.Add(obj.Key, property);
          this.Properties.Remove(obj.Key);
        }
      }
      foreach (T obj in this.Properties.Values)
        obj.Disown();
      foreach (T obj in this.PropertiesPendingDelete.Values)
        obj.Disown();
      this.Properties.Clear();
      this.PropertiesPendingDelete.Clear();
      foreach (T obj in freshListFromDb)
      {
        if (dictionary.ContainsKey(obj.Key))
        {
          dictionary[obj.Key].HasPendingWrite = false;
          this.AddToInternalList(obj.Key, dictionary[obj.Key]);
        }
        else
        {
          obj.AssignOwnership(this.OwnerItem, obj.Key);
          this.Properties.Add(obj.Key, obj);
        }
      }
    }

    private void AddToInternalList(string key, T prop)
    {
      this.Properties.Add(key, prop);
      prop.AssignOwnership(this.OwnerItem, key);
    }

    internal void EnsureHasOwningItem()
    {
      if (this.OwnerItem == null)
        throw new InvalidOperationException("Property must be associated with a Wallet Item");
    }

    public void Add(string key, T value)
    {
      this.EnsureHasOwningItem();
      if (value.IsEmpty)
        throw new ArgumentException("Cannot assign an empty value");
      if (this.Count == this.MaxPropertiesAllowedInDictionary)
        throw new IndexOutOfRangeException("You can have a maximum of " + (object) this.MaxPropertiesAllowedInDictionary + " per item");
      this.AddToInternalList(key, value);
    }

    public bool ContainsKey(string key) => this.Properties.ContainsKey(key);

    public ICollection<string> Keys => (ICollection<string>) this.Properties.Keys;

    public bool Remove(string key)
    {
      this.EnsureHasOwningItem();
      int num = this.Properties.ContainsKey(key) ? 1 : 0;
      if (num == 0)
        return num != 0;
      T property = this.Properties[key];
      T deletedProperty = WalletPropertyBase.CreateDeletedProperty<T>((WalletPropertyBase) property);
      property.Disown();
      this.Properties.Remove(key);
      this.PropertiesPendingDelete.Add(key, deletedProperty);
      return num != 0;
    }

    public bool TryGetValue(string key, out T value)
    {
      int num = this.ContainsKey(key) ? 1 : 0;
      if (num != 0)
      {
        value = this[key];
        return num != 0;
      }
      value = new T();
      return num != 0;
    }

    public ICollection<T> Values => (ICollection<T>) this.Properties.Values;

    public T this[string key]
    {
      get => this.ContainsKey(key) ? this.Properties[key] : throw new KeyNotFoundException("The key '" + key + "' was not found.");
      set
      {
        this.EnsureHasOwningItem();
        if (value.IsEmpty)
          throw new ArgumentNullException("Cannot assign a null MutliFieldProperty.  If you'd like to remove the property, use .Remove(key)");
        if (this.Properties.ContainsKey(key))
        {
          this.Properties[key].Disown();
          this.Properties[key] = value;
          this.Properties[key].AssignOwnership(this.OwnerItem, key);
        }
        else
          this.Add(key, value);
      }
    }

    public void Add(KeyValuePair<string, T> item) => this.Add(item.Key, item.Value);

    public void Clear()
    {
      this.EnsureHasOwningItem();
      string[] array = new string[this.Properties.Keys.Count];
      this.Properties.Keys.CopyTo(array, 0);
      foreach (string key in array)
        this.Remove(key);
    }

    public bool Contains(KeyValuePair<string, T> item)
    {
      bool flag = false;
      if (this.ContainsKey(item.Key))
        flag = (object) this[item.Key] == (object) item.Value;
      return flag;
    }

    public void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
    {
      if (array == null)
        throw new ArgumentNullException("array cannot be null");
      if (arrayIndex < 0)
        throw new ArgumentOutOfRangeException("arrayIndex is out of range");
      if (array.Length - arrayIndex < this.Count)
        throw new ArgumentException("array too small");
      int index = arrayIndex;
      foreach (string key in (IEnumerable<string>) this.Keys)
      {
        array[index] = new KeyValuePair<string, T>(key, this[key]);
        ++index;
      }
    }

    public int Count => this.Properties.Values.Count;

    public bool IsReadOnly => this.OwnerItem == null;

    public bool Remove(KeyValuePair<string, T> item)
    {
      bool flag = false;
      if (this.Contains(item))
        flag = this.Remove(item.Key);
      return flag;
    }

    public IEnumerator<KeyValuePair<string, T>> GetEnumerator() => (IEnumerator<KeyValuePair<string, T>>) this.Properties.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.Properties.GetEnumerator();
  }
}
