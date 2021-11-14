// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataTableReaderListener
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;

namespace Microsoft.Phone.Data
{
  internal sealed class DataTableReaderListener
  {
    private DataTable currentDataTable;
    private bool isSubscribed;
    private WeakReference readerWeak;

    internal DataTableReaderListener(DataTableReader reader)
    {
      if (reader == null)
        throw ExceptionBuilder.ArgumentNull("DataTableReader");
      if (this.currentDataTable != null)
        this.UnSubscribeEvents();
      this.readerWeak = new WeakReference((object) reader);
      this.currentDataTable = reader.CurrentDataTable;
      if (this.currentDataTable == null)
        return;
      this.SubscribeEvents();
    }

    internal void CleanUp() => this.UnSubscribeEvents();

    internal void UpdataTable(DataTable datatable)
    {
      if (datatable == null)
        throw ExceptionBuilder.ArgumentNull("DataTable");
      this.UnSubscribeEvents();
      this.currentDataTable = datatable;
      this.SubscribeEvents();
    }

    private void SubscribeEvents()
    {
      if (this.currentDataTable == null || this.isSubscribed)
        return;
      this.currentDataTable.Columns.ColumnPropertyChanged += new CollectionChangeEventHandler(this.SchemaChanged);
      this.currentDataTable.Columns.CollectionChanged += new CollectionChangeEventHandler(this.SchemaChanged);
      this.currentDataTable.RowChanged += new DataRowChangeEventHandler(this.DataChanged);
      this.currentDataTable.RowDeleted += new DataRowChangeEventHandler(this.DataChanged);
      this.currentDataTable.TableCleared += new DataTableClearEventHandler(this.DataTableCleared);
      this.isSubscribed = true;
    }

    private void UnSubscribeEvents()
    {
      if (this.currentDataTable == null || !this.isSubscribed)
        return;
      this.currentDataTable.Columns.ColumnPropertyChanged -= new CollectionChangeEventHandler(this.SchemaChanged);
      this.currentDataTable.Columns.CollectionChanged -= new CollectionChangeEventHandler(this.SchemaChanged);
      this.currentDataTable.RowChanged -= new DataRowChangeEventHandler(this.DataChanged);
      this.currentDataTable.RowDeleted -= new DataRowChangeEventHandler(this.DataChanged);
      this.currentDataTable.TableCleared -= new DataTableClearEventHandler(this.DataTableCleared);
      this.isSubscribed = false;
    }

    private void DataTableCleared(object sender, DataTableClearEventArgs e)
    {
      DataTableReader target = (DataTableReader) this.readerWeak.Target;
      if (target != null)
        target.DataTableCleared();
      else
        this.UnSubscribeEvents();
    }

    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      DataTableReader target = (DataTableReader) this.readerWeak.Target;
      if (target != null)
        target.SchemaChanged();
      else
        this.UnSubscribeEvents();
    }

    private void DataChanged(object sender, DataRowChangeEventArgs args)
    {
      DataTableReader target = (DataTableReader) this.readerWeak.Target;
      if (target != null)
        target.DataChanged(args);
      else
        this.UnSubscribeEvents();
    }
  }
}
