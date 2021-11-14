// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Index
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.Phone.Data
{
  internal sealed class Index
  {
    private const int DoNotReplaceCompareRecord = 0;
    private const int ReplaceNewRecordForCompare = 1;
    private const int ReplaceOldRecordForCompare = 2;
    private readonly DataTable table;
    internal readonly int[] IndexDesc;
    internal readonly IndexField[] IndexFields;
    private readonly Comparison<DataRow> _comparison;
    private readonly DataViewRowState recordStates;
    private WeakReference rowFilter;
    private Index.IndexTree records;
    private int recordCount;
    private int refCount;
    private Listeners<DataViewListener> _listeners;
    private bool suspendEvents;
    private static readonly object[] zeroObjects = new object[0];
    private readonly bool isSharable;
    private readonly bool _hasRemoteAggregate;
    internal const int MaskBits = 2147483647;
    private static int _objectTypeCount;
    private readonly int _objectID = Interlocked.Increment(ref Index._objectTypeCount);

    public Index(
      DataTable table,
      IndexField[] indexFields,
      DataViewRowState recordStates,
      IFilter rowFilter)
      : this(table, (int[]) null, indexFields, recordStates, rowFilter)
    {
    }

    public Index(
      DataTable table,
      int[] ndexDesc,
      IndexField[] indexFields,
      DataViewRowState recordStates,
      IFilter rowFilter)
      : this(table, ndexDesc, indexFields, (Comparison<DataRow>) null, recordStates, rowFilter)
    {
    }

    public Index(
      DataTable table,
      Comparison<DataRow> comparison,
      DataViewRowState recordStates,
      IFilter rowFilter)
      : this(table, (int[]) null, Index.GetAllFields(table.Columns), comparison, recordStates, rowFilter)
    {
    }

    private static IndexField[] GetAllFields(DataColumnCollection columns)
    {
      IndexField[] indexFieldArray = new IndexField[columns.Count];
      for (int index = 0; index < indexFieldArray.Length; ++index)
        indexFieldArray[index] = new IndexField(columns[index], false);
      return indexFieldArray;
    }

    private Index(
      DataTable table,
      int[] ndexDesc,
      IndexField[] indexFields,
      Comparison<DataRow> comparison,
      DataViewRowState recordStates,
      IFilter rowFilter)
    {
      Debug.Assert(indexFields != null);
      Debug.Assert(table != null, "null table");
      if ((recordStates & ~(DataViewRowState.OriginalRows | DataViewRowState.Added | DataViewRowState.ModifiedCurrent)) != DataViewRowState.None)
        throw ExceptionBuilder.RecordStateRange();
      this.table = table;
      this._listeners = new Listeners<DataViewListener>(this.ObjectID, (Listeners<DataViewListener>.Func<DataViewListener, bool>) (listener => listener != null));
      this.IndexDesc = ndexDesc;
      this.IndexFields = indexFields;
      if (ndexDesc == null)
        this.IndexDesc = Select.ConvertIndexFieldtoIndexDesc(indexFields);
      this.recordStates = recordStates;
      this._comparison = comparison;
      DataColumnCollection columns = table.Columns;
      this.isSharable = rowFilter == null && comparison == null;
      if (rowFilter != null)
      {
        this.rowFilter = new WeakReference((object) rowFilter);
        if (rowFilter is DataExpression dataExpression2)
          this._hasRemoteAggregate = dataExpression2.HasRemoteAggregate();
      }
      this.InitRecords(rowFilter);
    }

    public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter)
    {
      if (!this.isSharable || this.IndexFields.Length != indexDesc.Length || (this.recordStates != recordStates || rowFilter != null))
        return false;
      for (int index = 0; index < this.IndexFields.Length; ++index)
      {
        if (this.IndexFields[index].Column != indexDesc[index].Column || this.IndexFields[index].IsDescending != indexDesc[index].IsDescending)
          return false;
      }
      return true;
    }

    internal bool HasRemoteAggregate => this._hasRemoteAggregate;

    internal int ObjectID => this._objectID;

    public DataViewRowState RecordStates => this.recordStates;

    public IFilter RowFilter => this.rowFilter != null ? (IFilter) this.rowFilter.Target : (IFilter) (object) null;

    public int GetRecord(int recordIndex)
    {
      Debug.Assert(recordIndex >= 0 && recordIndex < this.recordCount, "recordIndex out of range");
      return this.records[recordIndex];
    }

    public bool HasDuplicates => this.records.HasDuplicates;

    public int RecordCount => this.recordCount;

    public bool IsSharable => this.isSharable;

    private bool AcceptRecord(int record) => this.AcceptRecord(record, this.RowFilter);

    private bool AcceptRecord(int record, IFilter filter)
    {
      if (filter == null)
        return true;
      DataRow row = this.table.recordManager[record];
      if (row == null)
        return true;
      DataRowVersion version = DataRowVersion.Default;
      if (row.oldRecord == record)
        version = DataRowVersion.Original;
      else if (row.newRecord == record)
        version = DataRowVersion.Current;
      else if (row.tempRecord == record)
        version = DataRowVersion.Proposed;
      return filter.Invoke(row, version);
    }

    internal void ListChangedAdd(DataViewListener listener) => this._listeners.Add(listener);

    internal void ListChangedRemove(DataViewListener listener) => this._listeners.Remove(listener);

    public int RefCount => this.refCount;

    public void AddRef()
    {
      lock (this.table.indexes)
      {
        Debug.Assert(0 <= this.refCount, "AddRef on disposed index");
        Debug.Assert(this.records != null, "null records");
        if (this.refCount == 0)
        {
          this.table.ShadowIndexCopy();
          this.table.indexes.Add(this);
        }
        ++this.refCount;
      }
    }

    public int RemoveRef()
    {
      int num;
      lock (this.table.indexes)
      {
        num = --this.refCount;
        if (this.refCount <= 0)
        {
          this.table.ShadowIndexCopy();
          Debug.Assert(this.table.indexes.Remove(this), "Index did not exist in index collection");
        }
      }
      return num;
    }

    private void ApplyChangeAction(int record, int action, int changeRecord)
    {
      if (action == 0)
        return;
      if (action > 0)
      {
        if (!this.AcceptRecord(record))
          return;
        this.InsertRecord(record, true);
      }
      else if (this._comparison != null && -1 != record)
        this.DeleteRecord(this.GetIndex(record, changeRecord));
      else
        this.DeleteRecord(this.GetIndex(record));
    }

    public bool CheckUnique()
    {
      Debug.Assert(this.records.CheckUnique(this.records.root) != this.HasDuplicates, "CheckUnique difference");
      return !this.HasDuplicates;
    }

    private int CompareRecords(int record1, int record2)
    {
      if (this._comparison != null)
        return this.CompareDataRows(record1, record2);
      if (this.IndexFields.Length != 0)
      {
        for (int index = 0; index < this.IndexFields.Length; ++index)
        {
          int num = this.IndexFields[index].Column.Compare(record1, record2);
          if (num != 0)
            return !this.IndexFields[index].IsDescending ? num : -num;
        }
        return 0;
      }
      Debug.Assert(this.table.recordManager[record1] != null, "record1 no datarow");
      Debug.Assert(this.table.recordManager[record2] != null, "record2 no datarow");
      return this.table.Rows.IndexOf(this.table.recordManager[record1]).CompareTo(this.table.Rows.IndexOf(this.table.recordManager[record2]));
    }

    private int CompareDataRows(int record1, int record2)
    {
      this.table.recordManager.VerifyRecord(record1, this.table.recordManager[record1]);
      this.table.recordManager.VerifyRecord(record2, this.table.recordManager[record2]);
      return this._comparison(this.table.recordManager[record1], this.table.recordManager[record2]);
    }

    private int CompareDuplicateRecords(int record1, int record2)
    {
      if (this._comparison != null)
        Debug.Assert(this.CompareDataRows(record1, record2) == 0, "duplicate record not a duplicate by user function");
      else if (record1 != record2)
      {
        for (int index = 0; index < this.IndexFields.Length; ++index)
          Debug.Assert(this.IndexFields[index].Column.Compare(record1, record2) == 0, "duplicate record not a duplicate");
      }
      Debug.Assert(this.table.recordManager[record1] != null, "record1 no datarow");
      Debug.Assert(this.table.recordManager[record2] != null, "record2 no datarow");
      if (this.table.recordManager[record1] == null)
        return this.table.recordManager[record2] != null ? -1 : 0;
      if (this.table.recordManager[record2] == null)
        return 1;
      int num = this.table.recordManager[record1].rowID.CompareTo(this.table.recordManager[record2].rowID);
      if (num == 0 && record1 != record2)
        num = ((int) this.table.recordManager[record1].GetRecordState(record1)).CompareTo((int) this.table.recordManager[record2].GetRecordState(record2));
      return num;
    }

    private int CompareRecordToKey(int record1, object[] vals)
    {
      for (int index = 0; index < this.IndexFields.Length; ++index)
      {
        int num = this.IndexFields[index].Column.CompareValueTo(record1, vals[index]);
        if (num != 0)
          return !this.IndexFields[index].IsDescending ? num : -num;
      }
      return 0;
    }

    public void DeleteRecordFromIndex(int recordIndex) => this.DeleteRecord(recordIndex, false);

    private void DeleteRecord(int recordIndex) => this.DeleteRecord(recordIndex, true);

    private void DeleteRecord(int recordIndex, bool fireEvent)
    {
      if (recordIndex < 0)
        return;
      --this.recordCount;
      this.MaintainDataView(ListChangedType.ItemDeleted, this.records.DeleteByIndex(recordIndex), !fireEvent);
      if (!fireEvent)
        return;
      this.OnListChanged(ListChangedType.ItemDeleted, recordIndex);
    }

    public RBTree<int>.RBTreeEnumerator GetEnumerator(int startIndex) => new RBTree<int>.RBTreeEnumerator((RBTree<int>) this.records, startIndex);

    public int GetIndex(int record) => this.records.GetIndexByKey(record);

    private int GetIndex(int record, int changeRecord)
    {
      Debug.Assert(this._comparison != null, "missing comparison");
      DataRow row = this.table.recordManager[record];
      int newRecord = row.newRecord;
      int oldRecord = row.oldRecord;
      try
      {
        switch (changeRecord)
        {
          case 1:
            row.newRecord = record;
            break;
          case 2:
            row.oldRecord = record;
            break;
        }
        this.table.recordManager.VerifyRecord(record, row);
        return this.records.GetIndexByKey(record);
      }
      finally
      {
        switch (changeRecord)
        {
          case 1:
            Debug.Assert(record == row.newRecord, "newRecord has change during GetIndex");
            row.newRecord = newRecord;
            break;
          case 2:
            Debug.Assert(record == row.oldRecord, "oldRecord has change during GetIndex");
            row.oldRecord = oldRecord;
            break;
        }
        if (-1 != newRecord)
          this.table.recordManager.VerifyRecord(newRecord, row);
      }
    }

    public object[] GetUniqueKeyValues()
    {
      if (this.IndexFields == null || this.IndexFields.Length == 0)
        return Index.zeroObjects;
      List<object[]> list = new List<object[]>();
      this.GetUniqueKeyValues(list, this.records.root);
      return (object[]) list.ToArray();
    }

    public int FindRecord(int record)
    {
      int node = this.records.Search(record);
      return node != 0 ? this.records.GetIndexByNode(node) : -1;
    }

    public int FindRecordByKey(object key)
    {
      int nodeByKey = this.FindNodeByKey(key);
      return nodeByKey != 0 ? this.records.GetIndexByNode(nodeByKey) : -1;
    }

    public int FindRecordByKey(object[] key)
    {
      int nodeByKeys = this.FindNodeByKeys(key);
      return nodeByKeys != 0 ? this.records.GetIndexByNode(nodeByKeys) : -1;
    }

    private int FindNodeByKey(object originalKey)
    {
      if (this.IndexFields.Length != 1)
        throw ExceptionBuilder.IndexKeyLength(this.IndexFields.Length, 1);
      int nodeId = this.records.root;
      if (nodeId != 0)
      {
        DataColumn column = this.IndexFields[0].Column;
        object obj = column.ConvertValue(originalKey);
        nodeId = this.records.root;
        int num1;
        int num2;
        if (this.IndexFields[0].IsDescending)
        {
          for (; nodeId != 0; nodeId = num1 >= 0 ? this.records.Right(nodeId) : this.records.Left(nodeId))
          {
            num1 = column.CompareValueTo(this.records.Key(nodeId), obj);
            if (num1 == 0)
              break;
          }
        }
        else
        {
          for (; nodeId != 0; nodeId = num2 <= 0 ? this.records.Right(nodeId) : this.records.Left(nodeId))
          {
            num2 = column.CompareValueTo(this.records.Key(nodeId), obj);
            if (num2 == 0)
              break;
          }
        }
      }
      return nodeId;
    }

    private int FindNodeByKeys(object[] originalKey)
    {
      int keyLength = originalKey != null ? originalKey.Length : 0;
      if (keyLength == 0 || this.IndexFields.Length != keyLength)
        throw ExceptionBuilder.IndexKeyLength(this.IndexFields.Length, keyLength);
      int nodeId = this.records.root;
      if (nodeId != 0)
      {
        object[] vals = new object[originalKey.Length];
        for (int index = 0; index < originalKey.Length; ++index)
          vals[index] = this.IndexFields[index].Column.ConvertValue(originalKey[index]);
        int key;
        for (nodeId = this.records.root; nodeId != 0; nodeId = key <= 0 ? this.records.Right(nodeId) : this.records.Left(nodeId))
        {
          key = this.CompareRecordToKey(this.records.Key(nodeId), vals);
          if (key == 0)
            break;
        }
      }
      return nodeId;
    }

    private int FindNodeByKeyRecord(int record)
    {
      int nodeId = this.records.root;
      int num;
      if (nodeId != 0)
      {
        for (nodeId = this.records.root; nodeId != 0; nodeId = num <= 0 ? this.records.Right(nodeId) : this.records.Left(nodeId))
        {
          num = this.CompareRecords(this.records.Key(nodeId), record);
          if (num == 0)
            break;
        }
      }
      return nodeId;
    }

    internal Range FindRecords<TKey, TRow>(
      Index.ComparisonBySelector<TKey, TRow> comparison,
      TKey key)
      where TRow : DataRow
    {
      int nodeId;
      int num;
      for (nodeId = this.records.root; nodeId != 0; nodeId = num >= 0 ? this.records.Right(nodeId) : this.records.Left(nodeId))
      {
        num = comparison(key, (TRow) this.table.recordManager[this.records.Key(nodeId)]);
        if (num == 0)
          break;
      }
      return this.GetRangeFromNode(nodeId);
    }

    private Range GetRangeFromNode(int nodeId)
    {
      if (nodeId == 0)
        return new Range();
      int indexByNode = this.records.GetIndexByNode(nodeId);
      if (this.records.Next(nodeId) == 0)
      {
        int num = indexByNode;
        return new Range(num, num);
      }
      int num1 = this.records.SubTreeSize(this.records.Next(nodeId));
      int min = indexByNode;
      return new Range(min, min + num1 - 1);
    }

    public Range FindRecords(object key) => this.GetRangeFromNode(this.FindNodeByKey(key));

    public Range FindRecords(object[] key) => this.GetRangeFromNode(this.FindNodeByKeys(key));

    internal void FireResetEvent()
    {
      if (!this.DoListChanged)
        return;
      this.OnListChanged(DataView.ResetEventArgs);
    }

    private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState)
    {
      int num = (this.recordStates & oldState) == DataViewRowState.None ? 0 : 1;
      return ((this.recordStates & newState) == DataViewRowState.None ? 0 : 1) - num;
    }

    private static int GetReplaceAction(DataViewRowState oldState)
    {
      if ((DataViewRowState.CurrentRows & oldState) != DataViewRowState.None)
        return 1;
      return (DataViewRowState.OriginalRows & oldState) == DataViewRowState.None ? 0 : 2;
    }

    public DataRow GetRow(int i) => this.table.recordManager[this.GetRecord(i)];

    public DataRow[] GetRows(object[] values) => this.GetRows(this.FindRecords(values));

    public DataRow[] GetRows(Range range)
    {
      DataRow[] dataRowArray = this.table.NewRowArray(range.Count);
      if (dataRowArray.Length != 0)
      {
        RBTree<int>.RBTreeEnumerator enumerator = this.GetEnumerator(range.Min);
        for (int index = 0; index < dataRowArray.Length && enumerator.MoveNext(); ++index)
          dataRowArray[index] = this.table.recordManager[enumerator.Current];
      }
      return dataRowArray;
    }

    private void InitRecords(IFilter filter)
    {
      DataViewRowState recordStates = this.recordStates;
      bool append = this.IndexFields.Length == 0;
      this.records = new Index.IndexTree(this);
      this.recordCount = 0;
      foreach (DataRow row in (InternalDataCollectionBase) this.table.Rows)
      {
        int record = -1;
        if (row.oldRecord == row.newRecord)
        {
          if ((recordStates & DataViewRowState.Unchanged) != DataViewRowState.None)
            record = row.oldRecord;
        }
        else if (row.oldRecord == -1)
        {
          if ((recordStates & DataViewRowState.Added) != DataViewRowState.None)
            record = row.newRecord;
        }
        else if (row.newRecord == -1)
        {
          if ((recordStates & DataViewRowState.Deleted) != DataViewRowState.None)
            record = row.oldRecord;
        }
        else if ((recordStates & DataViewRowState.ModifiedCurrent) != DataViewRowState.None)
          record = row.newRecord;
        else if ((recordStates & DataViewRowState.ModifiedOriginal) != DataViewRowState.None)
          record = row.oldRecord;
        if (record != -1 && this.AcceptRecord(record, filter))
        {
          this.records.InsertAt(-1, record, append);
          ++this.recordCount;
        }
      }
    }

    public int InsertRecordToIndex(int record)
    {
      int num = -1;
      if (this.AcceptRecord(record))
        num = this.InsertRecord(record, false);
      return num;
    }

    private int InsertRecord(int record, bool fireEvent)
    {
      bool append = false;
      if (this.IndexFields.Length == 0 && this.table != null)
        append = this.table.Rows.IndexOf(this.table.recordManager[record]) + 1 == this.table.Rows.Count;
      int node = this.records.InsertAt(-1, record, append);
      ++this.recordCount;
      this.MaintainDataView(ListChangedType.ItemAdded, record, !fireEvent);
      if (!fireEvent)
        return this.records.GetIndexByNode(node);
      if (this.DoListChanged)
        this.OnListChanged(ListChangedType.ItemAdded, this.records.GetIndexByNode(node));
      return 0;
    }

    public bool IsKeyInIndex(object key) => (uint) this.FindNodeByKey(key) > 0U;

    public bool IsKeyInIndex(object[] key) => (uint) this.FindNodeByKeys(key) > 0U;

    public bool IsKeyRecordInIndex(int record) => (uint) this.FindNodeByKeyRecord(record) > 0U;

    private bool DoListChanged => !this.suspendEvents && this._listeners.HasListeners && !this.table.AreIndexEventsSuspended;

    private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex)
    {
      if (!this.DoListChanged)
        return;
      this.OnListChanged(new ListChangedEventArgs(changedType, newIndex, oldIndex));
    }

    private void OnListChanged(ListChangedType changedType, int index)
    {
      if (!this.DoListChanged)
        return;
      this.OnListChanged(new ListChangedEventArgs(changedType, index));
    }

    private void OnListChanged(ListChangedEventArgs e)
    {
      Debug.Assert(this.DoListChanged, "supposed to check DoListChanged before calling to delay create ListChangedEventArgs");
      this._listeners.Notify<ListChangedEventArgs, bool, bool>(e, false, false, (Listeners<DataViewListener>.Action<DataViewListener, ListChangedEventArgs, bool, bool>) ((listener, args, arg2, arg3) => listener.IndexListChanged(args)));
    }

    private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove)
    {
      Debug.Assert(-1 <= record, "bad record#");
      this._listeners.Notify<ListChangedType, DataRow, bool>(changedType, 0 <= record ? this.table.recordManager[record] : (DataRow) null, trackAddRemove, (Listeners<DataViewListener>.Action<DataViewListener, ListChangedType, DataRow, bool>) ((listener, type, row, track) => listener.MaintainDataView(changedType, row, track)));
    }

    public void Reset()
    {
      this.InitRecords(this.RowFilter);
      this.MaintainDataView(ListChangedType.Reset, -1, false);
      this.FireResetEvent();
    }

    public void RecordChanged(int record)
    {
      if (!this.DoListChanged)
        return;
      int index = this.GetIndex(record);
      if (index < 0)
        return;
      this.OnListChanged(ListChangedType.ItemChanged, index);
    }

    public void RecordChanged(int oldIndex, int newIndex)
    {
      if (oldIndex <= -1 && newIndex <= -1)
        return;
      if (oldIndex == newIndex)
        this.OnListChanged(ListChangedType.ItemChanged, newIndex, oldIndex);
      else if (oldIndex == -1)
        this.OnListChanged(ListChangedType.ItemAdded, newIndex, oldIndex);
      else if (newIndex == -1)
        this.OnListChanged(ListChangedType.ItemDeleted, oldIndex);
      else
        this.OnListChanged(ListChangedType.ItemMoved, newIndex, oldIndex);
    }

    public void RecordStateChanged(
      int record,
      DataViewRowState oldState,
      DataViewRowState newState)
    {
      int changeAction = this.GetChangeAction(oldState, newState);
      this.ApplyChangeAction(record, changeAction, Index.GetReplaceAction(oldState));
    }

    public void RecordStateChanged(
      int oldRecord,
      DataViewRowState oldOldState,
      DataViewRowState oldNewState,
      int newRecord,
      DataViewRowState newOldState,
      DataViewRowState newNewState)
    {
      Debug.Assert(-1 == oldRecord || -1 == newRecord || this.table.recordManager[oldRecord] == this.table.recordManager[newRecord], "not the same DataRow when updating oldRecord and newRecord");
      int changeAction1 = this.GetChangeAction(oldOldState, oldNewState);
      int changeAction2 = this.GetChangeAction(newOldState, newNewState);
      if (changeAction1 == -1 && changeAction2 == 1 && this.AcceptRecord(newRecord))
      {
        int num = this._comparison == null || changeAction1 >= 0 ? this.GetIndex(oldRecord) : this.GetIndex(oldRecord, Index.GetReplaceAction(oldOldState));
        if (this._comparison == null && num != -1 && this.CompareRecords(oldRecord, newRecord) == 0)
        {
          this.records.UpdateNodeKey(oldRecord, newRecord);
          int index = this.GetIndex(newRecord);
          this.OnListChanged(ListChangedType.ItemChanged, index, index);
        }
        else
        {
          this.suspendEvents = true;
          if (num != -1)
          {
            this.records.DeleteByIndex(num);
            --this.recordCount;
          }
          this.records.Insert(newRecord);
          ++this.recordCount;
          this.suspendEvents = false;
          int index = this.GetIndex(newRecord);
          if (num == index)
            this.OnListChanged(ListChangedType.ItemChanged, index, num);
          else if (num == -1)
          {
            this.MaintainDataView(ListChangedType.ItemAdded, newRecord, false);
            this.OnListChanged(ListChangedType.ItemAdded, this.GetIndex(newRecord));
          }
          else
            this.OnListChanged(ListChangedType.ItemMoved, index, num);
        }
      }
      else
      {
        this.ApplyChangeAction(oldRecord, changeAction1, Index.GetReplaceAction(oldOldState));
        this.ApplyChangeAction(newRecord, changeAction2, Index.GetReplaceAction(newOldState));
      }
    }

    internal DataTable Table => this.table;

    private void GetUniqueKeyValues(List<object[]> list, int curNodeId)
    {
      if (curNodeId == 0)
        return;
      this.GetUniqueKeyValues(list, this.records.Left(curNodeId));
      int record = this.records.Key(curNodeId);
      object[] objArray = new object[this.IndexFields.Length];
      for (int index = 0; index < objArray.Length; ++index)
        objArray[index] = this.IndexFields[index].Column[record];
      list.Add(objArray);
      this.GetUniqueKeyValues(list, this.records.Right(curNodeId));
    }

    internal static int IndexOfReference<T>(List<T> list, T item) where T : class
    {
      if (list != null)
      {
        for (int index = 0; index < list.Count; ++index)
        {
          if ((object) list[index] == (object) item)
            return index;
        }
      }
      return -1;
    }

    internal static bool ContainsReference<T>(List<T> list, T item) where T : class => 0 <= Index.IndexOfReference<T>(list, item);

    private sealed class IndexTree : RBTree<int>
    {
      private readonly Index _index;

      internal IndexTree(Index index)
        : base(TreeAccessMethod.KEY_SEARCH_AND_INDEX)
      {
        this._index = index;
      }

      protected override int CompareNode(int record1, int record2) => this._index.CompareRecords(record1, record2);

      protected override int CompareSateliteTreeNode(int record1, int record2) => this._index.CompareDuplicateRecords(record1, record2);
    }

    internal delegate int ComparisonBySelector<TKey, TRow>(TKey key, TRow row) where TRow : DataRow;
  }
}
