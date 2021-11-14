// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataViewListener
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class DataViewListener
  {
    private readonly WeakReference _dvWeak;
    private DataTable _table;
    private Index _index;
    internal readonly int ObjectID;

    internal DataViewListener(DataView dv)
    {
      this.ObjectID = dv.ObjectID;
      this._dvWeak = new WeakReference((object) dv);
    }

    private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
    {
      DataView target = (DataView) this._dvWeak.Target;
      if (target != null)
        target.ChildRelationCollectionChanged(sender, e);
      else
        this.CleanUp(true);
    }

    private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
    {
      DataView target = (DataView) this._dvWeak.Target;
      if (target != null)
        target.ParentRelationCollectionChanged(sender, e);
      else
        this.CleanUp(true);
    }

    private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e)
    {
      DataView target = (DataView) this._dvWeak.Target;
      if (target != null)
        target.ColumnCollectionChangedInternal(sender, e);
      else
        this.CleanUp(true);
    }

    internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
    {
      DataView target = (DataView) this._dvWeak.Target;
      if (target != null)
        target.MaintainDataView(changedType, row, trackAddRemove);
      else
        this.CleanUp(true);
    }

    internal void IndexListChanged(ListChangedEventArgs e)
    {
      DataView target = (DataView) this._dvWeak.Target;
      if (target != null)
        target.IndexListChangedInternal(e);
      else
        this.CleanUp(true);
    }

    internal void RegisterMetaDataEvents(DataTable table)
    {
      Debug.Assert(this._table == null, "DataViewListener already registered table");
      this._table = table;
      if (table == null)
        return;
      this.RegisterListener(table);
      CollectionChangeEventHandler changeEventHandler1 = new CollectionChangeEventHandler(this.ColumnCollectionChanged);
      table.Columns.ColumnPropertyChanged += changeEventHandler1;
      table.Columns.CollectionChanged += changeEventHandler1;
      CollectionChangeEventHandler changeEventHandler2 = new CollectionChangeEventHandler(this.ChildRelationCollectionChanged);
      ((DataRelationCollection.DataTableRelationCollection) table.ChildRelations).RelationPropertyChanged += changeEventHandler2;
      table.ChildRelations.CollectionChanged += changeEventHandler2;
      CollectionChangeEventHandler changeEventHandler3 = new CollectionChangeEventHandler(this.ParentRelationCollectionChanged);
      ((DataRelationCollection.DataTableRelationCollection) table.ParentRelations).RelationPropertyChanged += changeEventHandler3;
      table.ParentRelations.CollectionChanged += changeEventHandler3;
    }

    internal void UnregisterMetaDataEvents() => this.UnregisterMetaDataEvents(true);

    private void UnregisterMetaDataEvents(bool updateListeners)
    {
      DataTable table = this._table;
      this._table = (DataTable) null;
      if (table == null)
        return;
      CollectionChangeEventHandler changeEventHandler1 = new CollectionChangeEventHandler(this.ColumnCollectionChanged);
      table.Columns.ColumnPropertyChanged -= changeEventHandler1;
      table.Columns.CollectionChanged -= changeEventHandler1;
      CollectionChangeEventHandler changeEventHandler2 = new CollectionChangeEventHandler(this.ChildRelationCollectionChanged);
      ((DataRelationCollection.DataTableRelationCollection) table.ChildRelations).RelationPropertyChanged -= changeEventHandler2;
      table.ChildRelations.CollectionChanged -= changeEventHandler2;
      CollectionChangeEventHandler changeEventHandler3 = new CollectionChangeEventHandler(this.ParentRelationCollectionChanged);
      ((DataRelationCollection.DataTableRelationCollection) table.ParentRelations).RelationPropertyChanged -= changeEventHandler3;
      table.ParentRelations.CollectionChanged -= changeEventHandler3;
      if (!updateListeners)
        return;
      List<DataViewListener> listeners = table.GetListeners();
      lock (listeners)
        listeners.Remove(this);
    }

    internal void RegisterListChangedEvent(Index index)
    {
      Debug.Assert(this._index == null, "DataviewListener already registered index");
      this._index = index;
      if (index == null)
        return;
      lock (index)
      {
        index.AddRef();
        index.ListChangedAdd(this);
      }
    }

    internal void UnregisterListChangedEvent()
    {
      Index index = this._index;
      this._index = (Index) null;
      if (index == null)
        return;
      lock (index)
      {
        index.ListChangedRemove(this);
        if (index.RemoveRef() > 1)
          return;
        index.RemoveRef();
      }
    }

    private void CleanUp(bool updateListeners)
    {
      this.UnregisterMetaDataEvents(updateListeners);
      this.UnregisterListChangedEvent();
    }

    private void RegisterListener(DataTable table)
    {
      List<DataViewListener> listeners = table.GetListeners();
      lock (listeners)
      {
        for (int index = listeners.Count - 1; 0 <= index; --index)
        {
          DataViewListener dataViewListener = listeners[index];
          if (!dataViewListener._dvWeak.IsAlive)
          {
            listeners.RemoveAt(index);
            dataViewListener.CleanUp(false);
          }
        }
        listeners.Add(this);
      }
    }
  }
}
