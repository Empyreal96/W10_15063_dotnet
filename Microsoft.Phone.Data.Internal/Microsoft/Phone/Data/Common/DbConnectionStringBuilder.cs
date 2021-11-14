// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbConnectionStringBuilder
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Microsoft.Phone.Data.Common
{
  public class DbConnectionStringBuilder : IDictionary, ICollection, IEnumerable
  {
    private System.Collections.Generic.Dictionary<string, object> _currentValues;
    private string _connectionString = "";
    private bool _browsableConnectionString = true;
    private readonly bool UseOdbcRules;
    private static int _objectTypeCount;
    internal readonly int _objectID = Interlocked.Increment(ref DbConnectionStringBuilder._objectTypeCount);

    public DbConnectionStringBuilder()
    {
    }

    public DbConnectionStringBuilder(bool useOdbcRules) => this.UseOdbcRules = useOdbcRules;

    private ICollection Collection => (ICollection) this.CurrentValues;

    private IDictionary Dictionary => (IDictionary) this.CurrentValues;

    private System.Collections.Generic.Dictionary<string, object> CurrentValues
    {
      get
      {
        System.Collections.Generic.Dictionary<string, object> dictionary = this._currentValues;
        if (dictionary == null)
        {
          dictionary = new System.Collections.Generic.Dictionary<string, object>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
          this._currentValues = dictionary;
        }
        return dictionary;
      }
    }

    object IDictionary.this[object keyword]
    {
      get => this[this.ObjectToString(keyword)];
      set => this[this.ObjectToString(keyword)] = value;
    }

    public virtual object this[string keyword]
    {
      get
      {
        ADP.CheckArgumentNull((object) keyword, nameof (keyword));
        object obj;
        if (this.CurrentValues.TryGetValue(keyword, out obj))
          return obj;
        throw ADP.KeywordNotSupported(keyword);
      }
      set
      {
        ADP.CheckArgumentNull((object) keyword, nameof (keyword));
        if (value != null)
        {
          string str = DbConnectionStringBuilderUtil.ConvertToString(value);
          DbConnectionOptions.ValidateKeyValuePair(keyword, str);
          this.CurrentValues.ContainsKey(keyword);
          this.CurrentValues[keyword] = (object) str;
        }
        else
          this.Remove(keyword);
        this._connectionString = (string) null;
      }
    }

    public bool BrowsableConnectionString
    {
      get => this._browsableConnectionString;
      set => this._browsableConnectionString = value;
    }

    public string ConnectionString
    {
      get
      {
        string connectionString = this._connectionString;
        if (connectionString == null)
        {
          StringBuilder builder = new StringBuilder();
          foreach (string key in (IEnumerable) this.Keys)
          {
            object obj;
            if (this.ShouldSerialize(key) && this.TryGetValue(key, out obj))
            {
              string str = obj != null ? Convert.ToString(obj, (IFormatProvider) CultureInfo.InvariantCulture) : (string) null;
              DbConnectionStringBuilder.AppendKeyValuePair(builder, key, str, this.UseOdbcRules);
            }
          }
          connectionString = builder.ToString();
          this._connectionString = connectionString;
        }
        return connectionString;
      }
      set
      {
        DbConnectionOptions connectionOptions = new DbConnectionOptions(value, (Microsoft.Phone.Data.Workaround.Hashtable) null, this.UseOdbcRules);
        string connectionString = this.ConnectionString;
        this.Clear();
        try
        {
          for (NameValuePair nameValuePair = connectionOptions.KeyChain; nameValuePair != null; nameValuePair = nameValuePair.Next)
          {
            if (nameValuePair.Value != null)
              this[nameValuePair.Name] = (object) nameValuePair.Value;
            else
              this.Remove(nameValuePair.Name);
          }
          this._connectionString = (string) null;
        }
        catch (ArgumentException ex)
        {
          this.ConnectionString = connectionString;
          this._connectionString = connectionString;
          throw;
        }
      }
    }

    public virtual int Count => this.CurrentValues.Count;

    public bool IsReadOnly => false;

    public virtual bool IsFixedSize => false;

    bool ICollection.IsSynchronized => this.Collection.IsSynchronized;

    public virtual ICollection Keys => this.Dictionary.Keys;

    internal int ObjectID => this._objectID;

    object ICollection.SyncRoot => this.Collection.SyncRoot;

    public virtual ICollection Values
    {
      get
      {
        ICollection<string> keys = (ICollection<string>) this.Keys;
        IEnumerator<string> enumerator = keys.GetEnumerator();
        object[] items = new object[keys.Count];
        for (int index = 0; index < items.Length; ++index)
        {
          enumerator.MoveNext();
          items[index] = this[enumerator.Current];
          Debug.Assert(items[index] != null, "null value " + enumerator.Current);
        }
        return (ICollection) new ReadOnlyCollection<object>(items);
      }
    }

    void IDictionary.Add(object keyword, object value) => this.Add(this.ObjectToString(keyword), value);

    public void Add(string keyword, object value) => this[keyword] = value;

    public static void AppendKeyValuePair(StringBuilder builder, string keyword, string value) => DbConnectionOptions.AppendKeyValuePairBuilder(builder, keyword, value, false);

    public static void AppendKeyValuePair(
      StringBuilder builder,
      string keyword,
      string value,
      bool useOdbcRules)
    {
      DbConnectionOptions.AppendKeyValuePairBuilder(builder, keyword, value, useOdbcRules);
    }

    public virtual void Clear()
    {
      this._connectionString = "";
      this.CurrentValues.Clear();
    }

    protected internal void ClearPropertyDescriptors()
    {
    }

    bool IDictionary.Contains(object keyword) => this.ContainsKey(this.ObjectToString(keyword));

    public virtual bool ContainsKey(string keyword)
    {
      ADP.CheckArgumentNull((object) keyword, nameof (keyword));
      return this.CurrentValues.ContainsKey(keyword);
    }

    void ICollection.CopyTo(Array array, int index) => this.Collection.CopyTo(array, index);

    public virtual bool EquivalentTo(DbConnectionStringBuilder connectionStringBuilder)
    {
      ADP.CheckArgumentNull((object) connectionStringBuilder, nameof (connectionStringBuilder));
      if (this.GetType() != connectionStringBuilder.GetType() || this.CurrentValues.Count != connectionStringBuilder.CurrentValues.Count)
        return false;
      foreach (KeyValuePair<string, object> currentValue in this.CurrentValues)
      {
        object obj;
        if (!connectionStringBuilder.CurrentValues.TryGetValue(currentValue.Key, out obj) || !currentValue.Value.Equals(obj))
          return false;
      }
      return true;
    }

    IEnumerator IEnumerable.GetEnumerator() => this.Collection.GetEnumerator();

    IDictionaryEnumerator IDictionary.GetEnumerator() => this.Dictionary.GetEnumerator();

    private string ObjectToString(object keyword)
    {
      try
      {
        return (string) keyword;
      }
      catch (InvalidCastException ex)
      {
        throw new ArgumentException(nameof (keyword), "not a string");
      }
    }

    void IDictionary.Remove(object keyword) => this.Remove(this.ObjectToString(keyword));

    public virtual bool Remove(string keyword)
    {
      ADP.CheckArgumentNull((object) keyword, nameof (keyword));
      if (!this.CurrentValues.Remove(keyword))
        return false;
      this._connectionString = (string) null;
      return true;
    }

    public virtual bool ShouldSerialize(string keyword)
    {
      ADP.CheckArgumentNull((object) keyword, nameof (keyword));
      return this.CurrentValues.ContainsKey(keyword);
    }

    public override string ToString() => this.ConnectionString;

    public virtual bool TryGetValue(string keyword, out object value)
    {
      ADP.CheckArgumentNull((object) keyword, nameof (keyword));
      return this.CurrentValues.TryGetValue(keyword, out value);
    }
  }
}
