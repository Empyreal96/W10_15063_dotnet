// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbParameterCollection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;
using System.Collections;

namespace Microsoft.Phone.Data.Common
{
  public abstract class DbParameterCollection : 
    MarshalByValueComponent,
    IDataParameterCollection,
    IList,
    ICollection,
    IEnumerable
  {
    public abstract int Count { get; }

    public abstract bool IsFixedSize { get; }

    public abstract bool IsReadOnly { get; }

    public abstract bool IsSynchronized { get; }

    public abstract object SyncRoot { get; }

    object IList.this[int index]
    {
      get => (object) this.GetParameter(index);
      set => this.SetParameter(index, (DbParameter) value);
    }

    object IDataParameterCollection.this[string parameterName]
    {
      get => (object) this.GetParameter(parameterName);
      set => this.SetParameter(parameterName, (DbParameter) value);
    }

    public DbParameter this[int index]
    {
      get => this.GetParameter(index);
      set => this.SetParameter(index, value);
    }

    public DbParameter this[string parameterName]
    {
      get => this.GetParameter(parameterName);
      set => this.SetParameter(parameterName, value);
    }

    public abstract int Add(object value);

    public abstract void AddRange(Array values);

    public abstract bool Contains(object value);

    public abstract bool Contains(string value);

    public abstract void CopyTo(Array array, int index);

    public abstract void Clear();

    public abstract IEnumerator GetEnumerator();

    protected abstract DbParameter GetParameter(int index);

    protected abstract DbParameter GetParameter(string parameterName);

    public abstract int IndexOf(object value);

    public abstract int IndexOf(string parameterName);

    public abstract void Insert(int index, object value);

    public abstract void Remove(object value);

    public abstract void RemoveAt(int index);

    public abstract void RemoveAt(string parameterName);

    protected abstract void SetParameter(int index, DbParameter value);

    protected abstract void SetParameter(string parameterName, DbParameter value);
  }
}
