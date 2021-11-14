// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataViewManager
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;

namespace Microsoft.Phone.Data
{
  public class DataViewManager : MarshalByValueComponent
  {
    private DataViewSettingCollection dataViewSettingsCollection;
    private DataSet dataSet;
    private bool locked;
    internal int nViews;
    private static NotSupportedException NotSupported = new NotSupportedException();

    public DataViewManager()
      : this((DataSet) null, false)
    {
    }

    public DataViewManager(DataSet dataSet)
      : this(dataSet, false)
    {
    }

    internal DataViewManager(DataSet dataSet, bool locked)
    {
      GC.SuppressFinalize((object) this);
      this.dataSet = dataSet;
      DataSet dataSet1 = this.dataSet;
      this.locked = locked;
      this.dataViewSettingsCollection = new DataViewSettingCollection(this);
    }

    public DataSet DataSet
    {
      get => this.dataSet;
      set
      {
        if (value == null)
          throw ExceptionBuilder.SetFailed("DataSet to null");
        if (this.locked)
          throw ExceptionBuilder.SetDataSetFailed();
        this.dataSet = this.dataSet == null || this.nViews <= 0 ? value : throw ExceptionBuilder.CanNotSetDataSet();
        this.dataViewSettingsCollection = new DataViewSettingCollection(this);
      }
    }

    public DataViewSettingCollection DataViewSettings => this.dataViewSettingsCollection;

    public DataView CreateDataView(DataTable table)
    {
      if (this.dataSet == null)
        throw ExceptionBuilder.CanNotUseDataViewManager();
      DataView dataView = new DataView(table);
      dataView.SetDataViewManager(this);
      return dataView;
    }
  }
}
