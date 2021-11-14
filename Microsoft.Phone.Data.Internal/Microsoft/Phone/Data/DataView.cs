// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataView
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using Microsoft.Phone.Data.Workaround;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Microsoft.Phone.Data
{
  public class DataView : MarshalByValueComponent, ICollection, IEnumerable, IList
  {
    private DataViewManager dataViewManager;
    private DataTable table;
    private bool locked;
    private Index index;
    private Dictionary<string, Index> findIndexes;
    private string sort = "";
    private Comparison<DataRow> _comparison;
    private IFilter rowFilter;
    private DataViewRowState recordStates = DataViewRowState.CurrentRows;
    private bool shouldOpen = true;
    private bool open;
    private bool allowNew = true;
    private bool allowEdit = true;
    private bool allowDelete = true;
    private bool applyDefaultSort;
    internal DataRow addNewRow;
    private ListChangedEventArgs addNewMoved;
    private ListChangedEventHandler onListChanged;
    private EventHandler onInitialized;
    internal static ListChangedEventArgs ResetEventArgs = new ListChangedEventArgs(ListChangedType.Reset, -1);
    private DataTable delayedTable;
    private string delayedRowFilter;
    private string delayedSort;
    private DataViewRowState delayedRecordStates = ~DataViewRowState.None;
    private bool fInitInProgress;
    private bool fEndInitInProgress;
    private Dictionary<DataRow, DataRowView> rowViewCache = new Dictionary<DataRow, DataRowView>((IEqualityComparer<DataRow>) DataView.DataRowReferenceComparer.Default);
    private readonly Dictionary<DataRow, DataRowView> rowViewBuffer = new Dictionary<DataRow, DataRowView>((IEqualityComparer<DataRow>) DataView.DataRowReferenceComparer.Default);
    private DataViewListener dvListener;
    private static int _objectTypeCount;
    private readonly int _objectID = Interlocked.Increment(ref DataView._objectTypeCount);

    internal DataView(DataTable table, bool locked)
    {
      GC.SuppressFinalize((object) this);
      this.dvListener = new DataViewListener(this);
      this.locked = locked;
      this.table = table;
      this.dvListener.RegisterMetaDataEvents(this.table);
    }

    public DataView()
      : this((DataTable) null)
    {
      this.SetIndex2("", DataViewRowState.CurrentRows, (IFilter) null, true);
    }

    public DataView(DataTable table)
      : this(table, false)
    {
      this.SetIndex2("", DataViewRowState.CurrentRows, (IFilter) null, true);
    }

    public DataView(DataTable table, string RowFilter, string Sort, DataViewRowState RowState)
    {
      GC.SuppressFinalize((object) this);
      if (table == null)
        throw ExceptionBuilder.CanNotUse();
      this.dvListener = new DataViewListener(this);
      this.locked = false;
      this.table = table;
      this.dvListener.RegisterMetaDataEvents(this.table);
      if ((RowState & ~(DataViewRowState.OriginalRows | DataViewRowState.Added | DataViewRowState.ModifiedCurrent)) != DataViewRowState.None)
        throw ExceptionBuilder.RecordStateRange();
      if ((RowState & DataViewRowState.ModifiedOriginal) != DataViewRowState.None && (RowState & DataViewRowState.ModifiedCurrent) != DataViewRowState.None)
        throw ExceptionBuilder.SetRowStateFilter();
      if (Sort == null)
        Sort = "";
      if (RowFilter == null)
        RowFilter = "";
      DataExpression dataExpression = new DataExpression(table, RowFilter);
      this.SetIndex(Sort, RowState, (IFilter) dataExpression);
    }

    internal DataView(
      DataTable table,
      Predicate<DataRow> predicate,
      Comparison<DataRow> comparison,
      DataViewRowState RowState)
    {
      GC.SuppressFinalize((object) this);
      if (table == null)
        throw ExceptionBuilder.CanNotUse();
      this.dvListener = new DataViewListener(this);
      this.locked = false;
      this.table = table;
      this.dvListener.RegisterMetaDataEvents(this.table);
      if ((RowState & ~(DataViewRowState.OriginalRows | DataViewRowState.Added | DataViewRowState.ModifiedCurrent)) != DataViewRowState.None)
        throw ExceptionBuilder.RecordStateRange();
      if ((RowState & DataViewRowState.ModifiedOriginal) != DataViewRowState.None && (RowState & DataViewRowState.ModifiedCurrent) != DataViewRowState.None)
        throw ExceptionBuilder.SetRowStateFilter();
      this._comparison = comparison;
      this.SetIndex2("", RowState, predicate != null ? (IFilter) new DataView.RowPredicateFilter(predicate) : (IFilter) null, true);
    }

    public bool AllowDelete
    {
      get => this.allowDelete;
      set
      {
        if (this.allowDelete == value)
          return;
        this.allowDelete = value;
        this.OnListChanged(DataView.ResetEventArgs);
      }
    }

    public bool ApplyDefaultSort
    {
      get => this.applyDefaultSort;
      set
      {
        if (this.applyDefaultSort == value)
          return;
        this._comparison = (Comparison<DataRow>) null;
        this.applyDefaultSort = value;
        this.UpdateIndex(true);
        this.OnListChanged(DataView.ResetEventArgs);
      }
    }

    public bool AllowEdit
    {
      get => this.allowEdit;
      set
      {
        if (this.allowEdit == value)
          return;
        this.allowEdit = value;
        this.OnListChanged(DataView.ResetEventArgs);
      }
    }

    public bool AllowNew
    {
      get => this.allowNew;
      set
      {
        if (this.allowNew == value)
          return;
        this.allowNew = value;
        this.OnListChanged(DataView.ResetEventArgs);
      }
    }

    public int Count
    {
      get
      {
        Debug.Assert(this.rowViewCache.Count == this.CountFromIndex, "DataView.Count mismatch");
        return this.rowViewCache.Count;
      }
    }

    private int CountFromIndex => (this.index != null ? this.index.RecordCount : 0) + (this.addNewRow != null ? 1 : 0);

    public DataViewManager DataViewManager => this.dataViewManager;

    public bool IsInitialized => !this.fInitInProgress;

    protected bool IsOpen => this.open;

    bool ICollection.IsSynchronized => false;

    public virtual string RowFilter
    {
      get => this.rowFilter is DataExpression rowFilter ? rowFilter.Expression : "";
      set
      {
        if (value == null)
          value = "";
        if (this.fInitInProgress)
        {
          this.delayedRowFilter = value;
        }
        else
        {
          CultureInfo culture = this.table != null ? this.table.Locale : CultureInfo.CurrentCulture;
          if (this.rowFilter != null && string.Compare(this.RowFilter, value, culture, CompareOptions.None) == 0)
            return;
          this.SetIndex(this.sort, this.recordStates, (IFilter) new DataExpression(this.table, value));
        }
      }
    }

    internal Predicate<DataRow> RowPredicate
    {
      get => !(this.GetFilter() is DataView.RowPredicateFilter filter) ? (Predicate<DataRow>) null : filter.PredicateFilter;
      set
      {
        if (this.RowPredicate == value)
          return;
        this.SetIndex(this.Sort, this.RowStateFilter, value != null ? (IFilter) new DataView.RowPredicateFilter(value) : (IFilter) null);
      }
    }

    public DataViewRowState RowStateFilter
    {
      get => this.recordStates;
      set
      {
        if (this.fInitInProgress)
        {
          this.delayedRecordStates = value;
        }
        else
        {
          if ((value & ~(DataViewRowState.OriginalRows | DataViewRowState.Added | DataViewRowState.ModifiedCurrent)) != DataViewRowState.None)
            throw ExceptionBuilder.RecordStateRange();
          if ((value & DataViewRowState.ModifiedOriginal) != DataViewRowState.None && (value & DataViewRowState.ModifiedCurrent) != DataViewRowState.None)
            throw ExceptionBuilder.SetRowStateFilter();
          if (this.recordStates == value)
            return;
          this.SetIndex(this.sort, value, this.rowFilter);
        }
      }
    }

    public string Sort
    {
      get => this.sort.Length == 0 && this.applyDefaultSort && (this.table != null && this.table._primaryIndex.Length != 0) ? this.table.FormatSortString(this.table._primaryIndex) : this.sort;
      set
      {
        if (value == null)
          value = "";
        if (this.fInitInProgress)
        {
          this.delayedSort = value;
        }
        else
        {
          CultureInfo culture = this.table != null ? this.table.Locale : CultureInfo.CurrentCulture;
          if (string.Compare(this.sort, value, culture, CompareOptions.None) == 0 && this._comparison == null)
            return;
          this.CheckSort(value);
          this._comparison = (Comparison<DataRow>) null;
          this.SetIndex(value, this.recordStates, this.rowFilter);
        }
      }
    }

    internal Comparison<DataRow> SortComparison
    {
      get => this._comparison;
      set
      {
        if (this._comparison == value)
          return;
        this._comparison = value;
        this.SetIndex("", this.recordStates, this.rowFilter);
      }
    }

    object ICollection.SyncRoot => (object) this;

    public DataTable Table
    {
      get => this.table;
      set
      {
        if (this.fInitInProgress && value != null)
        {
          this.delayedTable = value;
        }
        else
        {
          if (this.locked)
            throw ExceptionBuilder.SetTable();
          if (this.dataViewManager != null)
            throw ExceptionBuilder.CanNotSetTable();
          if (value != null && value.TableName.Length == 0)
            throw ExceptionBuilder.CanNotBindTable();
          if (this.table == value)
            return;
          this.dvListener.UnregisterMetaDataEvents();
          this.table = value;
          if (this.table != null)
            this.dvListener.RegisterMetaDataEvents(this.table);
          this.SetIndex2("", DataViewRowState.CurrentRows, (IFilter) null, false);
          this.OnListChanged(DataView.ResetEventArgs);
        }
      }
    }

    object IList.this[int recordIndex]
    {
      get => (object) this[recordIndex];
      set => throw ExceptionBuilder.SetIListObject();
    }

    public DataRowView this[int recordIndex] => this.GetRowView(this.GetRow(recordIndex));

    public virtual DataRowView AddNew()
    {
      this.CheckOpen();
      if (!this.AllowNew)
        throw ExceptionBuilder.AddNewNotAllowNull();
      if (this.addNewRow != null)
        this.rowViewCache[this.addNewRow].EndEdit();
      Debug.Assert(this.addNewRow == null, "AddNew addNewRow is not null");
      this.addNewRow = this.table.NewRow();
      DataRowView rowview = new DataRowView(this, this.addNewRow);
      this.rowViewCache.Add(this.addNewRow, rowview);
      this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, this.IndexOf(rowview)));
      return rowview;
    }

    public void BeginInit() => this.fInitInProgress = true;

    public void EndInit()
    {
      if (this.delayedTable != null && this.delayedTable.fInitInProgress)
      {
        this.delayedTable.delayedViews.Add(this);
      }
      else
      {
        this.fInitInProgress = false;
        this.fEndInitInProgress = true;
        if (this.delayedTable != null)
        {
          this.Table = this.delayedTable;
          this.delayedTable = (DataTable) null;
        }
        if (this.delayedSort != null)
        {
          this.Sort = this.delayedSort;
          this.delayedSort = (string) null;
        }
        if (this.delayedRowFilter != null)
        {
          this.RowFilter = this.delayedRowFilter;
          this.delayedRowFilter = (string) null;
        }
        if (this.delayedRecordStates != ~DataViewRowState.None)
        {
          this.RowStateFilter = this.delayedRecordStates;
          this.delayedRecordStates = ~DataViewRowState.None;
        }
        this.fEndInitInProgress = false;
        this.SetIndex(this.Sort, this.RowStateFilter, this.rowFilter);
        this.OnInitialized();
      }
    }

    private void CheckOpen()
    {
      if (!this.IsOpen)
        throw ExceptionBuilder.NotOpen();
    }

    private void CheckSort(string sort)
    {
      if (this.table == null)
        throw ExceptionBuilder.CanNotUse();
      if (sort.Length == 0)
        return;
      this.table.ParseSortString(sort);
    }

    protected void Close()
    {
      this.shouldOpen = false;
      this.UpdateIndex();
      this.dvListener.UnregisterMetaDataEvents();
    }

    public void CopyTo(Array array, int index)
    {
      if (this.index != null)
      {
        RBTree<int>.RBTreeEnumerator enumerator = this.index.GetEnumerator(0);
        while (enumerator.MoveNext())
        {
          array.SetValue((object) this.GetRowView(enumerator.Current), index);
          checked { ++index; }
        }
      }
      if (this.addNewRow == null)
        return;
      array.SetValue((object) this.rowViewCache[this.addNewRow], index);
    }

    private void CopyTo(DataRowView[] array, int index)
    {
      if (this.index != null)
      {
        RBTree<int>.RBTreeEnumerator enumerator = this.index.GetEnumerator(0);
        while (enumerator.MoveNext())
        {
          array[index] = this.GetRowView(enumerator.Current);
          checked { ++index; }
        }
      }
      if (this.addNewRow == null)
        return;
      array[index] = this.rowViewCache[this.addNewRow];
    }

    public void Delete(int index) => this.Delete(this.GetRow(index));

    internal void Delete(DataRow row)
    {
      if (row == null)
        return;
      this.CheckOpen();
      if (row == this.addNewRow)
      {
        this.FinishAddNew(false);
      }
      else
      {
        if (!this.AllowDelete)
          throw ExceptionBuilder.CanNotDelete();
        row.Delete();
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        this.Close();
      base.Dispose(disposing);
    }

    public int Find(object key) => this.FindByKey(key);

    internal virtual int FindByKey(object key) => this.index.FindRecordByKey(key);

    public int Find(object[] key) => this.FindByKey(key);

    internal virtual int FindByKey(object[] key) => this.index.FindRecordByKey(key);

    public DataRowView[] FindRows(object key) => this.FindRowsByKey(new object[1]
    {
      key
    });

    public DataRowView[] FindRows(object[] key) => this.FindRowsByKey(key);

    internal virtual DataRowView[] FindRowsByKey(object[] key) => this.GetDataRowViewFromRange(this.index.FindRecords(key));

    internal Range FindRecords<TKey, TRow>(
      Index.ComparisonBySelector<TKey, TRow> comparison,
      TKey key)
      where TRow : DataRow
    {
      return this.index.FindRecords<TKey, TRow>(comparison, key);
    }

    internal DataRowView[] GetDataRowViewFromRange(Range range)
    {
      if (range.IsNull)
        return new DataRowView[0];
      DataRowView[] dataRowViewArray = new DataRowView[range.Count];
      for (int index = 0; index < dataRowViewArray.Length; ++index)
        dataRowViewArray[index] = this[index + range.Min];
      return dataRowViewArray;
    }

    internal void FinishAddNew(bool success)
    {
      Debug.Assert(this.addNewRow != null, "null addNewRow");
      DataRow addNewRow = this.addNewRow;
      if (success)
      {
        if (DataRowState.Detached == addNewRow.RowState)
          this.table.Rows.Add(addNewRow);
        else
          addNewRow.EndEdit();
      }
      if (addNewRow != this.addNewRow)
        return;
      Debug.Assert(this.rowViewCache.Remove(this.addNewRow), "didn't remove addNewRow");
      this.addNewRow = (DataRow) null;
      if (!success)
        addNewRow.CancelEdit();
      this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, this.Count));
    }

    public IEnumerator GetEnumerator()
    {
      DataRowView[] array = new DataRowView[this.Count];
      this.CopyTo(array, 0);
      return array.GetEnumerator();
    }

    bool IList.IsReadOnly => false;

    bool IList.IsFixedSize => false;

    int IList.Add(object value)
    {
      if (value != null)
        throw ExceptionBuilder.AddExternalObject();
      this.AddNew();
      return this.Count - 1;
    }

    void IList.Clear() => throw ExceptionBuilder.CanNotClear();

    bool IList.Contains(object value) => 0 <= this.IndexOf(value as DataRowView);

    int IList.IndexOf(object value) => this.IndexOf(value as DataRowView);

    internal int IndexOf(DataRowView rowview)
    {
      if (rowview != null)
      {
        if (this.addNewRow == rowview.Row)
          return this.Count - 1;
        DataRowView dataRowView;
        if (this.index != null && DataRowState.Detached != rowview.Row.RowState && (this.rowViewCache.TryGetValue(rowview.Row, out dataRowView) && dataRowView == rowview))
          return this.IndexOfDataRowView(rowview);
      }
      return -1;
    }

    private int IndexOfDataRowView(DataRowView rowview) => this.index.GetIndex(rowview.GetRecord());

    void IList.Insert(int index, object value) => throw ExceptionBuilder.InsertExternalObject();

    void IList.Remove(object value)
    {
      int index = this.IndexOf(value as DataRowView);
      if (0 > index)
        throw ExceptionBuilder.RemoveExternalObject();
      ((IList) this).RemoveAt(index);
    }

    void IList.RemoveAt(int index) => this.Delete(index);

    internal Index GetFindIndex(string column, bool keepIndex)
    {
      if (this.findIndexes == null)
        this.findIndexes = new Dictionary<string, Index>();
      Index index;
      if (this.findIndexes.TryGetValue(column, out index))
      {
        if (!keepIndex)
        {
          this.findIndexes.Remove(column);
          index.RemoveRef();
          if (index.RefCount == 1)
            index.RemoveRef();
        }
      }
      else if (keepIndex)
      {
        index = this.table.GetIndex(column, this.recordStates, this.GetFilter());
        this.findIndexes[column] = index;
        index.AddRef();
      }
      return index;
    }

    public event ListChangedEventHandler ListChanged
    {
      add => this.onListChanged += value;
      remove => this.onListChanged -= value;
    }

    public event EventHandler Initialized
    {
      add => this.onInitialized += value;
      remove => this.onInitialized -= value;
    }

    internal virtual IFilter GetFilter() => this.rowFilter;

    private int GetRecord(int recordIndex)
    {
      if ((uint) this.Count <= (uint) recordIndex)
        throw ExceptionBuilder.RowOutOfRange(recordIndex);
      return recordIndex == this.index.RecordCount ? this.addNewRow.GetDefaultRecord() : this.index.GetRecord(recordIndex);
    }

    internal DataRow GetRow(int index)
    {
      int count = this.Count;
      if ((uint) count <= (uint) index)
        throw ExceptionBuilder.GetElementIndex(index);
      return index == count - 1 && this.addNewRow != null ? this.addNewRow : this.table.recordManager[this.GetRecord(index)];
    }

    private DataRowView GetRowView(int record) => this.GetRowView(this.table.recordManager[record]);

    private DataRowView GetRowView(DataRow dr) => this.rowViewCache[dr];

    protected virtual void IndexListChanged(object sender, ListChangedEventArgs e)
    {
      if (e.ListChangedType != ListChangedType.Reset)
        this.OnListChanged(e);
      if (this.addNewRow != null && this.index.RecordCount == 0)
        this.FinishAddNew(false);
      if (e.ListChangedType != ListChangedType.Reset)
        return;
      this.OnListChanged(e);
    }

    internal void IndexListChangedInternal(ListChangedEventArgs e)
    {
      this.rowViewBuffer.Clear();
      if (ListChangedType.ItemAdded == e.ListChangedType && this.addNewMoved != null && this.addNewMoved.NewIndex != this.addNewMoved.OldIndex)
      {
        ListChangedEventArgs addNewMoved = this.addNewMoved;
        this.addNewMoved = (ListChangedEventArgs) null;
        this.IndexListChanged((object) this, addNewMoved);
      }
      this.IndexListChanged((object) this, e);
    }

    internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
    {
      DataRowView dataRowView = (DataRowView) null;
      switch (changedType)
      {
        case ListChangedType.Reset:
          Debug.Assert(row == null, "MaintainDataView.Reset with non-null DataRow");
          this.ResetRowViewCache();
          break;
        case ListChangedType.ItemAdded:
          Debug.Assert(row != null, "MaintainDataView.ItemAdded with null DataRow");
          if (trackAddRemove && this.rowViewBuffer.TryGetValue(row, out dataRowView))
            Debug.Assert(this.rowViewBuffer.Remove(row), "row actually removed");
          if (row == this.addNewRow)
          {
            int newIndex = this.IndexOfDataRowView(this.rowViewCache[this.addNewRow]);
            Debug.Assert(0 <= newIndex, "ItemAdded was actually deleted");
            this.addNewRow = (DataRow) null;
            this.addNewMoved = new ListChangedEventArgs(ListChangedType.ItemMoved, newIndex, this.Count - 1);
            break;
          }
          if (!this.rowViewCache.ContainsKey(row))
          {
            this.rowViewCache.Add(row, dataRowView ?? new DataRowView(this, row));
            break;
          }
          Debug.Assert(false, "ItemAdded DataRow already in view");
          break;
        case ListChangedType.ItemDeleted:
          Debug.Assert(row != null, "MaintainDataView.ItemDeleted with null DataRow");
          Debug.Assert(row != this.addNewRow, "addNewRow being deleted");
          if (trackAddRemove)
          {
            this.rowViewCache.TryGetValue(row, out dataRowView);
            if (dataRowView != null)
              this.rowViewBuffer.Add(row, dataRowView);
            else
              Debug.Assert(false, "ItemDeleted DataRow not in view tracking");
          }
          if (this.rowViewCache.Remove(row))
            break;
          Debug.Assert(false, "ItemDeleted DataRow not in view");
          break;
        case ListChangedType.PropertyDescriptorAdded:
        case ListChangedType.PropertyDescriptorDeleted:
        case ListChangedType.PropertyDescriptorChanged:
          Debug.Assert(false, "unexpected");
          break;
      }
    }

    protected virtual void OnListChanged(ListChangedEventArgs e)
    {
      try
      {
        DataColumn dataColumn = (DataColumn) null;
        string propName = (string) null;
        switch (e.ListChangedType)
        {
          case ListChangedType.ItemMoved:
          case ListChangedType.ItemChanged:
            Debug.Assert(ListChangedType.ItemChanged == e.ListChangedType && (e.NewIndex == e.OldIndex || -1 == e.OldIndex) || ListChangedType.ItemMoved == e.ListChangedType && e.NewIndex != e.OldIndex && 0 <= e.OldIndex, "unexpected ItemChanged|ItemMoved");
            Debug.Assert(0 <= e.NewIndex, "negative NewIndex");
            if (0 <= e.NewIndex)
            {
              DataRow row = this.GetRow(e.NewIndex);
              if (row.HasPropertyChanged)
              {
                dataColumn = row.LastChangedColumn;
                propName = dataColumn != null ? dataColumn.ColumnName : string.Empty;
              }
              row.ResetLastChangedColumn();
              break;
            }
            break;
        }
        if (this.onListChanged != null)
        {
          if (dataColumn != null && e.NewIndex == e.OldIndex)
            this.onListChanged((object) this, new ListChangedEventArgs(e.ListChangedType, e.NewIndex, (PropertyDescriptor) new DataColumnPropertyDescriptor(dataColumn)));
          else
            this.onListChanged((object) this, e);
        }
        if (propName == null)
          return;
        this[e.NewIndex].RaisePropertyChangedEvent(propName);
      }
      catch (Exception ex)
      {
        if (!ADP.IsCatchableExceptionType(ex))
          throw;
        else
          ExceptionBuilder.TraceExceptionWithoutRethrow(ex);
      }
    }

    private void OnInitialized()
    {
      if (this.onInitialized == null)
        return;
      this.onInitialized((object) this, EventArgs.Empty);
    }

    protected void Open()
    {
      this.shouldOpen = true;
      this.UpdateIndex();
      this.dvListener.RegisterMetaDataEvents(this.table);
    }

    protected void Reset()
    {
      if (!this.IsOpen)
        return;
      this.index.Reset();
    }

    internal void ResetRowViewCache()
    {
      Dictionary<DataRow, DataRowView> dictionary = new Dictionary<DataRow, DataRowView>(this.CountFromIndex, (IEqualityComparer<DataRow>) DataView.DataRowReferenceComparer.Default);
      DataRowView dataRowView;
      if (this.index != null)
      {
        RBTree<int>.RBTreeEnumerator enumerator = this.index.GetEnumerator(0);
        while (enumerator.MoveNext())
        {
          DataRow dataRow = this.table.recordManager[enumerator.Current];
          if (!this.rowViewCache.TryGetValue(dataRow, out dataRowView))
            dataRowView = new DataRowView(this, dataRow);
          dictionary.Add(dataRow, dataRowView);
        }
      }
      if (this.addNewRow != null)
      {
        this.rowViewCache.TryGetValue(this.addNewRow, out dataRowView);
        Debug.Assert(dataRowView != null, "didn't contain addNewRow");
        dictionary.Add(this.addNewRow, dataRowView);
      }
      Debug.Assert(dictionary.Count == this.CountFromIndex, "didn't add expected count");
      this.rowViewCache = dictionary;
    }

    internal void SetDataViewManager(DataViewManager dataViewManager)
    {
      if (this.table == null)
        throw ExceptionBuilder.CanNotUse();
      if (this.dataViewManager == dataViewManager)
        return;
      if (dataViewManager != null)
        --dataViewManager.nViews;
      this.dataViewManager = dataViewManager;
      if (dataViewManager != null)
      {
        ++dataViewManager.nViews;
        DataViewSetting dataViewSetting = dataViewManager.DataViewSettings[this.table];
        try
        {
          this.applyDefaultSort = dataViewSetting.ApplyDefaultSort;
          DataExpression dataExpression = new DataExpression(this.table, dataViewSetting.RowFilter);
          this.SetIndex(dataViewSetting.Sort, dataViewSetting.RowStateFilter, (IFilter) dataExpression);
        }
        catch (Exception ex)
        {
          if (!ADP.IsCatchableExceptionType(ex))
            throw;
          else
            ExceptionBuilder.TraceExceptionWithoutRethrow(ex);
        }
        this.locked = true;
      }
      else
        this.SetIndex("", DataViewRowState.CurrentRows, (IFilter) null);
    }

    internal virtual void SetIndex(
      string newSort,
      DataViewRowState newRowStates,
      IFilter newRowFilter)
    {
      this.SetIndex2(newSort, newRowStates, newRowFilter, true);
    }

    internal void SetIndex2(
      string newSort,
      DataViewRowState newRowStates,
      IFilter newRowFilter,
      bool fireEvent)
    {
      this.sort = newSort;
      this.recordStates = newRowStates;
      this.rowFilter = newRowFilter;
      Debug.Assert((DataViewRowState.ModifiedCurrent & newRowStates) == DataViewRowState.None || (DataViewRowState.ModifiedOriginal & newRowStates) == DataViewRowState.None, "asking DataViewRowState for both Original & Current records");
      if (this.fEndInitInProgress)
        return;
      if (fireEvent)
      {
        this.UpdateIndex(true);
      }
      else
      {
        Debug.Assert(this._comparison == null, "RelatedView should not have a comparison function");
        this.UpdateIndex(true, false);
      }
      if (this.findIndexes == null)
        return;
      Dictionary<string, Index> findIndexes = this.findIndexes;
      this.findIndexes = (Dictionary<string, Index>) null;
      foreach (KeyValuePair<string, Index> keyValuePair in findIndexes)
        keyValuePair.Value.RemoveRef();
    }

    protected void UpdateIndex() => this.UpdateIndex(false);

    protected virtual void UpdateIndex(bool force) => this.UpdateIndex(force, true);

    internal void UpdateIndex(bool force, bool fireEvent)
    {
      if (!(this.open != this.shouldOpen | force))
        return;
      this.open = this.shouldOpen;
      Index index = (Index) null;
      if (this.open && this.table != null)
      {
        if (this.SortComparison != null)
        {
          index = new Index(this.table, this.SortComparison, this.recordStates, this.GetFilter());
          index.AddRef();
        }
        else
          index = this.table.GetIndex(this.Sort, this.recordStates, this.GetFilter());
      }
      if (this.index == index)
        return;
      if (this.index == null)
      {
        DataTable table1 = index.Table;
      }
      else
      {
        DataTable table2 = this.index.Table;
      }
      if (this.index != null)
        this.dvListener.UnregisterListChangedEvent();
      this.index = index;
      if (this.index != null)
        this.dvListener.RegisterListChangedEvent(this.index);
      this.ResetRowViewCache();
      if (!fireEvent)
        return;
      this.OnListChanged(DataView.ResetEventArgs);
    }

    internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
    {
      DataRelationPropertyDescriptor propertyDescriptor = (DataRelationPropertyDescriptor) null;
      this.OnListChanged(e.Action == CollectionChangeAction.Add ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorAdded, (PropertyDescriptor) new DataRelationPropertyDescriptor((DataRelation) e.Element)) : (e.Action == CollectionChangeAction.Refresh ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorChanged, (PropertyDescriptor) propertyDescriptor) : (e.Action == CollectionChangeAction.Remove ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorDeleted, (PropertyDescriptor) new DataRelationPropertyDescriptor((DataRelation) e.Element)) : (ListChangedEventArgs) null)));
    }

    internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
    {
      DataRelationPropertyDescriptor propertyDescriptor = (DataRelationPropertyDescriptor) null;
      this.OnListChanged(e.Action == CollectionChangeAction.Add ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorAdded, (PropertyDescriptor) new DataRelationPropertyDescriptor((DataRelation) e.Element)) : (e.Action == CollectionChangeAction.Refresh ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorChanged, (PropertyDescriptor) propertyDescriptor) : (e.Action == CollectionChangeAction.Remove ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorDeleted, (PropertyDescriptor) new DataRelationPropertyDescriptor((DataRelation) e.Element)) : (ListChangedEventArgs) null)));
    }

    protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e)
    {
      DataColumnPropertyDescriptor propertyDescriptor = (DataColumnPropertyDescriptor) null;
      this.OnListChanged(e.Action == CollectionChangeAction.Add ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorAdded, (PropertyDescriptor) new DataColumnPropertyDescriptor((DataColumn) e.Element)) : (e.Action == CollectionChangeAction.Refresh ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorChanged, (PropertyDescriptor) propertyDescriptor) : (e.Action == CollectionChangeAction.Remove ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorDeleted, (PropertyDescriptor) new DataColumnPropertyDescriptor((DataColumn) e.Element)) : (ListChangedEventArgs) null)));
    }

    internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) => this.ColumnCollectionChanged(sender, e);

    public DataTable ToTable() => this.ToTable((string) null, false);

    public DataTable ToTable(string tableName) => this.ToTable(tableName, false);

    public DataTable ToTable(bool distinct, params string[] columnNames) => this.ToTable((string) null, distinct, columnNames);

    public DataTable ToTable(string tableName, bool distinct, params string[] columnNames)
    {
      if (columnNames == null)
        throw ExceptionBuilder.ArgumentNull(nameof (columnNames));
      DataTable dataTable = new DataTable();
      dataTable.Locale = this.table.Locale;
      dataTable.CaseSensitive = this.table.CaseSensitive;
      dataTable.TableName = tableName != null ? tableName : this.table.TableName;
      dataTable.Namespace = this.table.Namespace;
      if (columnNames.Length == 0)
      {
        columnNames = new string[this.Table.Columns.Count];
        for (int index = 0; index < columnNames.Length; ++index)
          columnNames[index] = this.Table.Columns[index].ColumnName;
      }
      int[] numArray = new int[columnNames.Length];
      List<object[]> arraylist = new List<object[]>();
      for (int index = 0; index < columnNames.Length; ++index)
      {
        DataColumn column = this.Table.Columns[columnNames[index]];
        if (column == null)
          throw ExceptionBuilder.ColumnNotInTheUnderlyingTable(columnNames[index], this.Table.TableName);
        dataTable.Columns.Add(column.Clone());
        numArray[index] = this.Table.Columns.IndexOf(column);
      }
      foreach (DataRowView dataRowView in this)
      {
        object[] objectArray = new object[columnNames.Length];
        for (int index = 0; index < numArray.Length; ++index)
          objectArray[index] = dataRowView[numArray[index]];
        if (!distinct || !this.RowExist(arraylist, objectArray))
        {
          dataTable.Rows.Add(objectArray);
          arraylist.Add(objectArray);
        }
      }
      return dataTable;
    }

    private bool RowExist(List<object[]> arraylist, object[] objectArray)
    {
      for (int index1 = 0; index1 < arraylist.Count; ++index1)
      {
        object[] objArray = arraylist[index1];
        bool flag = true;
        for (int index2 = 0; index2 < objectArray.Length; ++index2)
          flag &= objArray[index2].Equals(objectArray[index2]);
        if (flag)
          return true;
      }
      return false;
    }

    public virtual bool Equals(DataView view) => view != null && this.Table == view.Table && (this.Count == view.Count && string.Compare(this.RowFilter, view.RowFilter, StringComparison.OrdinalIgnoreCase) == 0) && (string.Compare(this.Sort, view.Sort, StringComparison.OrdinalIgnoreCase) == 0 && this.SortComparison == view.SortComparison && (this.RowPredicate == view.RowPredicate && this.RowStateFilter == view.RowStateFilter)) && (this.DataViewManager == view.DataViewManager && this.AllowDelete == view.AllowDelete && (this.AllowNew == view.AllowNew && this.AllowEdit == view.AllowEdit));

    internal int ObjectID => this._objectID;

    private sealed class DataRowReferenceComparer : IEqualityComparer<DataRow>
    {
      internal static readonly DataView.DataRowReferenceComparer Default = new DataView.DataRowReferenceComparer();

      private DataRowReferenceComparer()
      {
      }

      public bool Equals(DataRow x, DataRow y) => x == y;

      public int GetHashCode(DataRow obj) => obj.ObjectID;
    }

    private sealed class RowPredicateFilter : IFilter
    {
      internal readonly Predicate<DataRow> PredicateFilter;

      internal RowPredicateFilter(Predicate<DataRow> predicate)
      {
        Debug.Assert(predicate != null, "null predicate");
        this.PredicateFilter = predicate;
      }

      bool IFilter.Invoke(DataRow row, DataRowVersion version)
      {
        Debug.Assert(DataRowVersion.Default != version, "not expecting Default");
        Debug.Assert(DataRowVersion.Proposed != version, "not expecting Proposed");
        return this.PredicateFilter(row);
      }
    }
  }
}
