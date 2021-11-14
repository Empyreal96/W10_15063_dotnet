// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeParameterCollection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data;
using Microsoft.Phone.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeParameterCollection : DbParameterCollection
  {
    private SqlCeCommand parent;
    private Dictionary<string, SqlCeParameter> m_KeyValuePairs;
    private List<SqlCeParameter> m_Values;
    private ADP.DstComparer m_KeyComparer;

    static SqlCeParameterCollection() => KillBitHelper.ThrowIfKillBitIsSet();

    internal SqlCeParameterCollection(SqlCeCommand parent) => this.parent = parent;

    public override bool IsSynchronized => false;

    public override object SyncRoot => (object) this;

    public override bool IsReadOnly => false;

    public override bool IsFixedSize => false;

    public override int Count => this.m_Values == null ? 0 : this.m_Values.Count;

    private Type ItemType => typeof (SqlCeParameter);

    private Exception ThrowParamterExistsException() => throw new ArgumentException(Res.GetString("ADP_CollectionIsParent", (object) this.ItemType.Name, (object) this.GetType().Name));

    private Exception ThrowParamterNotFoundException(string parameterName) => throw new IndexOutOfRangeException(Res.GetString("ADP_CollectionIndexString", (object) this.ItemType.Name, (object) "ParameterName", (object) parameterName, (object) this.GetType().Name));

    private Exception ThrowParamterNotFoundException(int index) => throw new IndexOutOfRangeException(Res.GetString("ADP_CollectionIndexString", (object) this.ItemType.Name, (object) "ParameterIndex", (object) index.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) this.GetType().Name));

    private void RangeCheck(int index)
    {
      if (index >= 0 && this.Count > index)
        return;
      this.ThrowParamterNotFoundException(index);
    }

    private void RangeCheck(string parameterName, out SqlCeParameter param)
    {
      if (string.IsNullOrEmpty(parameterName) || this.m_KeyValuePairs == null)
        this.ThrowParamterNotFoundException(parameterName);
      if (parameterName.StartsWith("@"))
        parameterName = parameterName.Substring(1);
      if (this.m_KeyValuePairs.TryGetValue(parameterName, out param))
        return;
      this.ThrowParamterNotFoundException(parameterName);
    }

    private int RangeCheckIndex(string parameterName)
    {
      int num = this.IndexOf(parameterName);
      if (-1 == num)
        this.ThrowParamterNotFoundException(parameterName);
      return num;
    }

    protected override DbParameter GetParameter(string parameterName) => (DbParameter) this[parameterName];

    protected override DbParameter GetParameter(int index) => (DbParameter) this[index];

    protected override void SetParameter(int index, DbParameter value) => this[index] = (SqlCeParameter) value;

    protected override void SetParameter(string parameterName, DbParameter value) => this[parameterName] = (SqlCeParameter) value;

    public SqlCeParameter this[int index]
    {
      get
      {
        this.RangeCheck(index);
        return this.m_Values[index];
      }
      set
      {
        this.OnDataBindingChange();
        this.RangeCheck(index);
        this.Replace(index, value);
      }
    }

    public SqlCeParameter this[string parameterName]
    {
      get
      {
        SqlCeParameter sqlCeParameter = (SqlCeParameter) null;
        this.RangeCheck(parameterName, out sqlCeParameter);
        return sqlCeParameter;
      }
      set
      {
        this.OnDataBindingChange();
        SqlCeParameter sqlCeParameter = (SqlCeParameter) null;
        this.RangeCheck(parameterName, out sqlCeParameter);
        this.Replace(this.IndexOf((object) sqlCeParameter), value);
      }
    }

    private void Replace(int index, SqlCeParameter newValue)
    {
      this.Validate(index, newValue);
      SqlCeParameter sqlCeParameter = this.m_Values[index];
      this.m_KeyValuePairs.Remove(sqlCeParameter.InternalParameterName);
      this.m_KeyValuePairs.Add(newValue.InternalParameterName, newValue);
      sqlCeParameter.Parent = (SqlCeParameterCollection) null;
      newValue.Parent = this;
      this.m_Values[index] = newValue;
    }

    internal string OnParameterNameChange(SqlCeParameter param, string newName)
    {
      if (this.Contains(newName))
        this.ThrowParamterExistsException();
      if (this.IndexOf(param.InternalParameterName) >= 0)
      {
        this.m_KeyValuePairs.Remove(param.InternalParameterName);
        param.InternalParameterName = newName;
        this.m_KeyValuePairs.Add(param.InternalParameterName, param);
      }
      return newName;
    }

    private List<SqlCeParameter> InitCollections()
    {
      if (this.m_KeyComparer == null)
        this.m_KeyComparer = new ADP.DstComparer();
      if (this.m_Values == null)
        this.m_Values = new List<SqlCeParameter>();
      if (this.m_KeyValuePairs == null)
        this.m_KeyValuePairs = new Dictionary<string, SqlCeParameter>((IEqualityComparer<string>) this.m_KeyComparer);
      return this.m_Values;
    }

    internal void AddWithoutEvents(int index, SqlCeParameter value)
    {
      this.InitCollections();
      this.Validate(-1, value);
      if (this.Contains(value.InternalParameterName))
        this.ThrowParamterExistsException();
      this.m_KeyValuePairs.Add(value.InternalParameterName, value);
      if (-1 == index)
        this.m_Values.Add(value);
      else
        this.m_Values.Insert(index, value);
      value.Parent = this;
    }

    public override void AddRange(Array values)
    {
      this.OnDataBindingChange();
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      foreach (object obj in values)
        this.ValidateType(obj);
      foreach (SqlCeParameter sqlCeParameter in values)
        this.Add(sqlCeParameter);
    }

    public override int Add(object value)
    {
      this.ValidateType(value);
      this.Add((SqlCeParameter) value);
      return this.Count - 1;
    }

    public SqlCeParameter Add(SqlCeParameter value)
    {
      this.OnDataBindingChange();
      this.AddWithoutEvents(-1, value);
      return value;
    }

    public SqlCeParameter AddWithValue(string parameterName, object value) => this.Add(new SqlCeParameter(parameterName, value));

    [Obsolete("Add(String parameterName, Object value) has been deprecated.  Use AddWithValue(String parameterName, Object value).", false)]
    public SqlCeParameter Add(string parameterName, object value) => this.Add(new SqlCeParameter(parameterName, value));

    public SqlCeParameter Add(string parameterName, SqlDbType type) => this.Add(new SqlCeParameter(parameterName, type));

    public SqlCeParameter Add(string parameterName, SqlDbType type, int size) => this.Add(new SqlCeParameter(parameterName, type, size));

    public SqlCeParameter Add(
      string parameterName,
      SqlDbType type,
      int size,
      string sourceColumn)
    {
      return this.Add(new SqlCeParameter(parameterName, type, size, sourceColumn));
    }

    public override bool Contains(string value) => !string.IsNullOrEmpty(value) && this.m_KeyValuePairs != null && this.m_KeyValuePairs.ContainsKey(value.StartsWith("@") ? value.Substring(1) : value);

    public override bool Contains(object value)
    {
      if (this.m_KeyValuePairs == null)
        return false;
      this.ValidateType(value);
      return this.m_KeyValuePairs.ContainsValue((SqlCeParameter) value);
    }

    public override void Clear()
    {
      if (0 >= this.Count)
        return;
      this.OnDataBindingChange();
      this.ClearWithoutEvents();
    }

    internal void ClearWithoutEvents()
    {
      if (this.m_Values == null)
        return;
      int count = this.m_Values.Count;
      for (int index = 0; index < count; ++index)
        this.m_Values[index].Parent = (SqlCeParameterCollection) null;
      this.m_Values.Clear();
      this.m_KeyValuePairs.Clear();
    }

    public override void CopyTo(Array array, int index) => ((ICollection) this.InitCollections()).CopyTo(array, index);

    public override IEnumerator GetEnumerator() => (IEnumerator) this.InitCollections().GetEnumerator();

    public override int IndexOf(string parameterName)
    {
      if (this.m_Values != null && parameterName != null)
      {
        if (parameterName.StartsWith("@"))
          parameterName = parameterName.Substring(1);
        int count = this.m_Values.Count;
        for (int index = 0; index < count; ++index)
        {
          if (this.m_Values[index].InternalParameterName != null)
          {
            string internalParameterName = this.m_Values[index].InternalParameterName;
            if (this.m_KeyComparer.Equals(parameterName, internalParameterName))
              return index;
          }
        }
      }
      return -1;
    }

    public override int IndexOf(object value)
    {
      if (value != null)
      {
        this.ValidateType(value);
        if (this.m_Values != null)
        {
          int count = this.m_Values.Count;
          for (int index = 0; index < count; ++index)
          {
            if (value == this.m_Values[index])
              return index;
          }
        }
      }
      return -1;
    }

    public override void Insert(int index, object value)
    {
      this.OnDataBindingChange();
      this.ValidateType(value);
      this.AddWithoutEvents(index, (SqlCeParameter) value);
    }

    internal void OnDataBindingChange()
    {
      if (this.parent == null)
        return;
      this.parent.OnDataBindingChange();
    }

    public override void RemoveAt(int index)
    {
      this.OnDataBindingChange();
      this.RangeCheck(index);
      this.RemoveIndex(index);
    }

    public override void RemoveAt(string parameterName)
    {
      this.OnDataBindingChange();
      this.RemoveIndex(this.RangeCheckIndex(parameterName));
    }

    private void RemoveIndex(int index)
    {
      Debug.Assert(this.m_Values != null && 0 <= index && index < this.Count, "RemoveIndex, invalid");
      SqlCeParameter sqlCeParameter = this.m_Values[index];
      sqlCeParameter.Parent = (SqlCeParameterCollection) null;
      this.m_KeyValuePairs.Remove(sqlCeParameter.InternalParameterName);
      this.m_Values.RemoveAt(index);
    }

    public override void Remove(object value)
    {
      this.OnDataBindingChange();
      this.ValidateType(value);
      int index = this.IndexOf((object) (SqlCeParameter) value);
      if (-1 != index)
        this.RemoveIndex(index);
      else
        throw new ArgumentException(Res.GetString("ADP_CollectionRemoveInvalidObject", (object) this.ItemType.Name, (object) this.GetType().Name));
    }

    private void ValidateType(object value)
    {
      if (value == null)
        throw new ArgumentNullException(nameof (value), Res.GetString("ADP_CollectionNullValue", (object) this.GetType().Name, (object) this.ItemType.Name));
      if (!this.ItemType.IsInstanceOfType(value))
        throw new InvalidCastException(Res.GetString("ADP_CollectionInvalidType", (object) this.GetType().Name, (object) this.ItemType.Name, (object) value.GetType().Name));
    }

    private void Validate(int index, SqlCeParameter value)
    {
      if (value == null)
        throw new ArgumentNullException(nameof (value), Res.GetString("ADP_CollectionNullValue", (object) this.GetType().Name, (object) this.ItemType.Name));
      if (value.Parent != null)
      {
        if (this != value.Parent)
          throw new ArgumentException(Res.GetString("ADP_CollectionIsNotParent", (object) this.ItemType.Name, (object) this.GetType().Name));
        if (index != this.IndexOf((object) value))
          throw new ArgumentException(Res.GetString("ADP_CollectionIsParent", (object) this.ItemType.Name, (object) this.GetType().Name));
      }
      if (!ADP.IsEmpty(value.InternalParameterName))
        return;
      index = 1;
      string parameterName;
      do
      {
        parameterName = "Parameter" + index.ToString((IFormatProvider) CultureInfo.CurrentCulture);
        ++index;
      }
      while (-1 != this.IndexOf(parameterName));
      value.ParameterName = parameterName;
    }
  }
}
