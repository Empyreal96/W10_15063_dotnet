// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataRowCollection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;

namespace Microsoft.Phone.Data
{
  public sealed class DataRowCollection : InternalDataCollectionBase
  {
    private readonly DataTable table;
    private readonly DataRowCollection.DataRowTree list = new DataRowCollection.DataRowTree();
    internal int nullInList;

    internal DataRowCollection(DataTable table) => this.table = table;

    public override int Count => this.list.Count;

    public DataRow this[int index] => this.list[index];

    public void Add(DataRow row) => this.table.AddRow(row, -1);

    public void InsertAt(DataRow row, int pos)
    {
      if (pos < 0)
        throw ExceptionBuilder.RowInsertOutOfRange(pos);
      if (pos >= this.list.Count)
        this.table.AddRow(row, -1);
      else
        this.table.InsertRow(row, -1, pos);
    }

    internal void DiffInsertAt(DataRow row, int pos)
    {
      if (pos < 0 || pos == this.list.Count)
        this.table.AddRow(row, pos > -1 ? pos + 1 : -1);
      else if (this.table.NestedParentRelations.Length != 0)
      {
        if (pos < this.list.Count)
        {
          if (this.list[pos] != null)
            throw ExceptionBuilder.RowInsertTwice(pos, this.table.TableName);
          this.list.RemoveAt(pos);
          --this.nullInList;
          this.table.InsertRow(row, pos + 1, pos);
        }
        else
        {
          while (pos > this.list.Count)
          {
            this.list.Add((DataRow) null);
            ++this.nullInList;
          }
          this.table.AddRow(row, pos + 1);
        }
      }
      else
        this.table.InsertRow(row, pos + 1, pos > this.list.Count ? -1 : pos);
    }

    public int IndexOf(DataRow row) => row == null || row.Table != this.table || row.RBTreeNodeId == 0 && row.RowState == DataRowState.Detached ? -1 : this.list.IndexOf(row.RBTreeNodeId, row);

    public DataRow Add(params object[] values)
    {
      DataRow row = this.table.NewRow(this.table.NewRecordFromArray(values));
      this.table.AddRow(row, -1);
      return row;
    }

    internal void ArrayAdd(DataRow row) => row.RBTreeNodeId = this.list.Add(row);

    internal void ArrayInsert(DataRow row, int pos) => row.RBTreeNodeId = this.list.Insert(pos, row);

    internal void ArrayClear() => this.list.Clear();

    internal void ArrayRemove(DataRow row)
    {
      if (row.RBTreeNodeId == 0)
        throw ExceptionBuilder.InternalRBTreeError(RBTreeError.AttachedNodeWithZerorbTreeNodeId);
      this.list.RBDelete(row.RBTreeNodeId);
      row.RBTreeNodeId = 0;
    }

    public DataRow Find(object key) => this.table.FindByPrimaryKey(key);

    public DataRow Find(object[] keys) => this.table.FindByPrimaryKey(keys);

    public void Clear() => this.table.Clear(false);

    public bool Contains(object key) => this.table.FindByPrimaryKey(key) != null;

    public bool Contains(object[] keys) => this.table.FindByPrimaryKey(keys) != null;

    public override void CopyTo(Array ar, int index) => this.list.CopyTo(ar, index);

    public void CopyTo(DataRow[] array, int index) => this.list.CopyTo(array, index);

    public override IEnumerator GetEnumerator() => this.list.GetEnumerator();

    public void Remove(DataRow row)
    {
      if (row == null || row.Table != this.table || -1 == row.rowID)
        throw ExceptionBuilder.RowOutOfRange();
      if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
        row.Delete();
      if (row.RowState == DataRowState.Detached)
        return;
      row.AcceptChanges();
    }

    public void RemoveAt(int index) => this.Remove(this[index]);

    private sealed class DataRowTree : RBTree<DataRow>
    {
      internal DataRowTree()
        : base(TreeAccessMethod.INDEX_ONLY)
      {
      }

      protected override int CompareNode(DataRow record1, DataRow record2) => throw ExceptionBuilder.InternalRBTreeError(RBTreeError.CompareNodeInDataRowTree);

      protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) => throw ExceptionBuilder.InternalRBTreeError(RBTreeError.CompareSateliteTreeNodeInDataRowTree);
    }
  }
}
