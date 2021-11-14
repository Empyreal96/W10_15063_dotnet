// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataViewSetting
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace Microsoft.Phone.Data
{
  public class DataViewSetting
  {
    private DataViewManager dataViewManager;
    private DataTable table;
    private string sort = "";
    private string rowFilter = "";
    private DataViewRowState rowStateFilter = DataViewRowState.CurrentRows;
    private bool applyDefaultSort;

    internal DataViewSetting()
    {
    }

    public bool ApplyDefaultSort
    {
      get => this.applyDefaultSort;
      set
      {
        if (this.applyDefaultSort == value)
          return;
        this.applyDefaultSort = value;
      }
    }

    public DataViewManager DataViewManager => this.dataViewManager;

    internal void SetDataViewManager(DataViewManager dataViewManager)
    {
      if (this.dataViewManager == dataViewManager)
        return;
      DataViewManager dataViewManager1 = this.dataViewManager;
      this.dataViewManager = dataViewManager;
    }

    public DataTable Table => this.table;

    internal void SetDataTable(DataTable table)
    {
      if (this.table == table)
        return;
      DataTable table1 = this.table;
      this.table = table;
    }

    public string RowFilter
    {
      get => this.rowFilter;
      set
      {
        if (value == null)
          value = "";
        if (!(this.rowFilter != value))
          return;
        this.rowFilter = value;
      }
    }

    public DataViewRowState RowStateFilter
    {
      get => this.rowStateFilter;
      set
      {
        if (this.rowStateFilter == value)
          return;
        this.rowStateFilter = value;
      }
    }

    public string Sort
    {
      get => this.sort;
      set
      {
        if (value == null)
          value = "";
        if (!(this.sort != value))
          return;
        this.sort = value;
      }
    }
  }
}
