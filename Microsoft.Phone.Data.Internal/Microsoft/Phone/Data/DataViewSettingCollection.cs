// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataViewSettingCollection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;

namespace Microsoft.Phone.Data
{
  public class DataViewSettingCollection : ICollection, IEnumerable
  {
    private readonly DataViewManager dataViewManager;
    private readonly Microsoft.Phone.Data.Workaround.Hashtable list = new Microsoft.Phone.Data.Workaround.Hashtable();

    internal DataViewSettingCollection(DataViewManager dataViewManager) => this.dataViewManager = dataViewManager != null ? dataViewManager : throw ExceptionBuilder.ArgumentNull(nameof (dataViewManager));

    public virtual DataViewSetting this[DataTable table]
    {
      get
      {
        DataViewSetting dataViewSetting = table != null ? (DataViewSetting) this.list[(object) table] : throw ExceptionBuilder.ArgumentNull(nameof (table));
        if (dataViewSetting == null)
        {
          dataViewSetting = new DataViewSetting();
          this[table] = dataViewSetting;
        }
        return dataViewSetting;
      }
      set
      {
        if (table == null)
          throw ExceptionBuilder.ArgumentNull(nameof (table));
        value.SetDataViewManager(this.dataViewManager);
        value.SetDataTable(table);
        this.list[(object) table] = (object) value;
      }
    }

    private DataTable GetTable(string tableName)
    {
      DataTable dataTable = (DataTable) null;
      DataSet dataSet = this.dataViewManager.DataSet;
      if (dataSet != null)
        dataTable = dataSet.Tables[tableName];
      return dataTable;
    }

    private DataTable GetTable(int index)
    {
      DataTable dataTable = (DataTable) null;
      DataSet dataSet = this.dataViewManager.DataSet;
      if (dataSet != null)
        dataTable = dataSet.Tables[index];
      return dataTable;
    }

    public virtual DataViewSetting this[string tableName]
    {
      get
      {
        DataTable table = this.GetTable(tableName);
        return table != null ? this[table] : (DataViewSetting) null;
      }
    }

    public virtual DataViewSetting this[int index]
    {
      get
      {
        DataTable table = this.GetTable(index);
        return table != null ? this[table] : (DataViewSetting) null;
      }
      set
      {
        DataTable table = this.GetTable(index);
        if (table == null)
          return;
        this[table] = value;
      }
    }

    public void CopyTo(Array ar, int index)
    {
      foreach (object obj in this)
        ar.SetValue(obj, index++);
    }

    public void CopyTo(DataViewSetting[] ar, int index)
    {
      foreach (object obj in this)
        ar.SetValue(obj, index++);
    }

    public virtual int Count
    {
      get
      {
        DataSet dataSet = this.dataViewManager.DataSet;
        return dataSet != null ? dataSet.Tables.Count : 0;
      }
    }

    public IEnumerator GetEnumerator() => (IEnumerator) new DataViewSettingCollection.DataViewSettingsEnumerator(this.dataViewManager);

    public bool IsReadOnly => true;

    public bool IsSynchronized => false;

    public object SyncRoot => (object) this;

    internal void Remove(DataTable table) => this.list.Remove((object) table);

    private sealed class DataViewSettingsEnumerator : IEnumerator
    {
      private DataViewSettingCollection dataViewSettings;
      private IEnumerator tableEnumerator;

      public DataViewSettingsEnumerator(DataViewManager dvm)
      {
        if (dvm.DataSet != null)
        {
          this.dataViewSettings = dvm.DataViewSettings;
          this.tableEnumerator = dvm.DataSet.Tables.GetEnumerator();
        }
        else
        {
          this.dataViewSettings = (DataViewSettingCollection) null;
          this.tableEnumerator = DataSet.zeroTables.GetEnumerator();
        }
      }

      public bool MoveNext() => this.tableEnumerator.MoveNext();

      public void Reset() => this.tableEnumerator.Reset();

      public object Current => (object) this.dataViewSettings[(DataTable) this.tableEnumerator.Current];
    }
  }
}
