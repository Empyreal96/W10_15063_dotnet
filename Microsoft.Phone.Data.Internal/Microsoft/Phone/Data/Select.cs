// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Select
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class Select
  {
    private readonly DataTable table;
    private readonly int[] indexDesc;
    private readonly IndexField[] IndexFields;
    private DataViewRowState recordStates;
    private DataExpression rowFilter;
    private ExpressionNode expression;
    private Index index;
    private int[] records;
    private int recordCount;
    private ExpressionNode linearExpression;
    private bool candidatesForBinarySearch;
    private Select.ColumnInfo[] candidateColumns;
    private int nCandidates;
    private int matchedCandidates;

    public Select(
      DataTable table,
      string filterExpression,
      string sort,
      DataViewRowState recordStates)
    {
      this.table = table;
      this.IndexFields = table.ParseSortString(sort);
      this.indexDesc = Select.ConvertIndexFieldtoIndexDesc(this.IndexFields);
      if (filterExpression != null && filterExpression.Length > 0)
      {
        this.rowFilter = new DataExpression(this.table, filterExpression);
        this.expression = this.rowFilter.ExpressionNode;
      }
      this.recordStates = recordStates;
    }

    private bool IsSupportedOperator(int op) => op >= 7 && op <= 11 || op == 13 || op == 39;

    private void AnalyzeExpression(BinaryNode expr)
    {
      if (this.linearExpression == this.expression)
        return;
      if (expr.op == 27)
        this.linearExpression = this.expression;
      else if (expr.op == 26)
      {
        bool flag1 = false;
        bool flag2 = false;
        if (expr.left is BinaryNode)
        {
          this.AnalyzeExpression((BinaryNode) expr.left);
          if (this.linearExpression == this.expression)
            return;
          flag1 = true;
        }
        else if (expr.left is UnaryNode unaryNode5)
        {
          while (unaryNode5.op == 0 && unaryNode5.right is UnaryNode && ((UnaryNode) unaryNode5.right).op == 0)
            unaryNode5 = (UnaryNode) unaryNode5.right;
          if (unaryNode5.op == 0 && unaryNode5.right is BinaryNode)
          {
            this.AnalyzeExpression((BinaryNode) unaryNode5.right);
            if (this.linearExpression == this.expression)
              return;
            flag1 = true;
          }
        }
        if (expr.right is BinaryNode)
        {
          this.AnalyzeExpression((BinaryNode) expr.right);
          if (this.linearExpression == this.expression)
            return;
          flag2 = true;
        }
        else if (expr.right is UnaryNode right5)
        {
          while (right5.op == 0 && right5.right is UnaryNode && ((UnaryNode) right5.right).op == 0)
            right5 = (UnaryNode) right5.right;
          if (right5.op == 0 && right5.right is BinaryNode)
          {
            this.AnalyzeExpression((BinaryNode) right5.right);
            if (this.linearExpression == this.expression)
              return;
            flag2 = true;
          }
        }
        if (flag1 & flag2)
          return;
        ExpressionNode left = flag1 ? expr.right : expr.left;
        this.linearExpression = this.linearExpression == null ? left : (ExpressionNode) new BinaryNode(this.table, 26, left, this.linearExpression);
      }
      else
      {
        if (this.IsSupportedOperator(expr.op))
        {
          if (expr.left is NameNode && expr.right is ConstNode)
          {
            Select.ColumnInfo candidateColumn = this.candidateColumns[((NameNode) expr.left).column.Ordinal];
            Select.ColumnInfo columnInfo = candidateColumn;
            columnInfo.expr = columnInfo.expr == null ? expr : new BinaryNode(this.table, 26, (ExpressionNode) expr, (ExpressionNode) candidateColumn.expr);
            if (expr.op == 7)
              candidateColumn.equalsOperator = true;
            this.candidatesForBinarySearch = true;
            return;
          }
          if (expr.right is NameNode && expr.left is ConstNode)
          {
            ExpressionNode left = expr.left;
            BinaryNode binaryNode = expr;
            binaryNode.left = binaryNode.right;
            expr.right = left;
            switch (expr.op)
            {
              case 8:
                expr.op = 9;
                break;
              case 9:
                expr.op = 8;
                break;
              case 10:
                expr.op = 11;
                break;
              case 11:
                expr.op = 10;
                break;
            }
            Select.ColumnInfo candidateColumn = this.candidateColumns[((NameNode) expr.left).column.Ordinal];
            Select.ColumnInfo columnInfo = candidateColumn;
            columnInfo.expr = columnInfo.expr == null ? expr : new BinaryNode(this.table, 26, (ExpressionNode) expr, (ExpressionNode) candidateColumn.expr);
            if (expr.op == 7)
              candidateColumn.equalsOperator = true;
            this.candidatesForBinarySearch = true;
            return;
          }
        }
        this.linearExpression = this.linearExpression == null ? (ExpressionNode) expr : (ExpressionNode) new BinaryNode(this.table, 26, (ExpressionNode) expr, this.linearExpression);
      }
    }

    private bool CompareSortIndexDesc(int[] id)
    {
      if (id.Length < this.indexDesc.Length)
        return false;
      int index1 = 0;
      for (int index2 = 0; index2 < id.Length && index1 < this.indexDesc.Length; ++index2)
      {
        if (id[index2] == this.indexDesc[index1])
        {
          ++index1;
        }
        else
        {
          Select.ColumnInfo candidateColumn = this.candidateColumns[DataKey.ColumnOrder(id[index2])];
          if (candidateColumn == null || !candidateColumn.equalsOperator)
            return false;
        }
      }
      return index1 == this.indexDesc.Length;
    }

    internal static int[] ConvertIndexFieldtoIndexDesc(IndexField[] fields)
    {
      int[] numArray = new int[fields.Length];
      for (int index = 0; index < fields.Length; ++index)
        numArray[index] = fields[index].Column.Ordinal | (fields[index].IsDescending ? int.MinValue : 0);
      return numArray;
    }

    private bool FindSortIndex()
    {
      this.index = (Index) null;
      lock (this.table.indexes)
      {
        int count1 = this.table.indexes.Count;
        int count2 = this.table.Rows.Count;
        for (int index1 = 0; index1 < count1; ++index1)
        {
          Index index2 = this.table.indexes[index1];
          if (index2.RecordStates == this.recordStates && index2.IsSharable && this.CompareSortIndexDesc(index2.IndexDesc))
          {
            this.index = index2;
            return true;
          }
        }
      }
      return false;
    }

    private int CompareClosestCandidateIndexDesc(int[] id)
    {
      int num = id.Length < this.nCandidates ? id.Length : this.nCandidates;
      int index;
      for (index = 0; index < num; ++index)
      {
        Select.ColumnInfo candidateColumn = this.candidateColumns[DataKey.ColumnOrder(id[index])];
        if (candidateColumn != null && candidateColumn.expr != null)
        {
          if (!candidateColumn.equalsOperator)
            return index + 1;
        }
        else
          break;
      }
      return index;
    }

    private bool FindClosestCandidateIndex()
    {
      this.index = (Index) null;
      this.matchedCandidates = 0;
      bool flag = true;
      lock (this.table.indexes)
      {
        int count1 = this.table.indexes.Count;
        int count2 = this.table.Rows.Count;
        for (int index1 = 0; index1 < count1; ++index1)
        {
          Index index2 = this.table.indexes[index1];
          if (index2.RecordStates == this.recordStates && index2.IsSharable)
          {
            int num = this.CompareClosestCandidateIndexDesc(index2.IndexDesc);
            if (num > this.matchedCandidates || num == this.matchedCandidates && !flag)
            {
              this.matchedCandidates = num;
              this.index = index2;
              flag = this.CompareSortIndexDesc(index2.IndexDesc);
              if (this.matchedCandidates == this.nCandidates & flag)
                return true;
            }
          }
        }
      }
      return this.index != null && flag;
    }

    private void InitCandidateColumns()
    {
      this.nCandidates = 0;
      this.candidateColumns = new Select.ColumnInfo[this.table.Columns.Count];
      if (this.rowFilter == null)
        return;
      DataColumn[] dependency = this.rowFilter.GetDependency();
      for (int index = 0; index < dependency.Length; ++index)
      {
        if (dependency[index].Table == this.table)
        {
          this.candidateColumns[dependency[index].Ordinal] = new Select.ColumnInfo();
          ++this.nCandidates;
        }
      }
    }

    private void CreateIndex()
    {
      if (this.index != null)
        return;
      if (this.nCandidates == 0)
      {
        this.index = new Index(this.table, this.IndexFields, this.recordStates, (IFilter) null);
        this.index.AddRef();
      }
      else
      {
        int length1 = this.candidateColumns.Length;
        int length2 = this.indexDesc.Length;
        bool flag = true;
        for (int index = 0; index < length1; ++index)
        {
          if (this.candidateColumns[index] != null && !this.candidateColumns[index].equalsOperator)
          {
            flag = false;
            break;
          }
        }
        int num1 = 0;
        for (int index = 0; index < length2; ++index)
        {
          Select.ColumnInfo candidateColumn = this.candidateColumns[DataKey.ColumnOrder(this.indexDesc[index])];
          if (candidateColumn != null)
          {
            candidateColumn.flag = true;
            ++num1;
          }
        }
        int num2 = length2 - num1;
        int nCandidates = this.nCandidates;
        int[] ndexDesc = new int[this.nCandidates + num2];
        if (flag)
        {
          int num3 = 0;
          for (int index = 0; index < length1; ++index)
          {
            if (this.candidateColumns[index] != null)
            {
              ndexDesc[num3++] = index;
              this.candidateColumns[index].flag = false;
            }
          }
          for (int index = 0; index < length2; ++index)
          {
            Select.ColumnInfo candidateColumn = this.candidateColumns[DataKey.ColumnOrder(this.indexDesc[index])];
            if (candidateColumn == null || candidateColumn.flag)
            {
              ndexDesc[num3++] = this.indexDesc[index];
              if (candidateColumn != null)
                candidateColumn.flag = false;
            }
          }
          for (int index = 0; index < this.candidateColumns.Length; ++index)
          {
            if (this.candidateColumns[index] != null)
              this.candidateColumns[index].flag = false;
          }
          IndexField[] indexFields = DataTable.zeroIndexField;
          if (ndexDesc.Length != 0)
          {
            indexFields = new IndexField[ndexDesc.Length];
            for (int index = 0; index < ndexDesc.Length; ++index)
            {
              DataColumn column = this.table.Columns[DataKey.ColumnOrder(ndexDesc[index])];
              bool isDescending = DataKey.SortDecending(ndexDesc[index]);
              indexFields[index] = new IndexField(column, isDescending);
            }
          }
          this.index = new Index(this.table, ndexDesc, indexFields, this.recordStates, (IFilter) null);
          if (!this.IsOperatorIn(this.expression))
            this.index.AddRef();
          this.matchedCandidates = this.nCandidates;
        }
        else
        {
          int index1;
          for (index1 = 0; index1 < length2; ++index1)
          {
            ndexDesc[index1] = this.indexDesc[index1];
            Select.ColumnInfo candidateColumn = this.candidateColumns[DataKey.ColumnOrder(this.indexDesc[index1])];
            if (candidateColumn != null)
              candidateColumn.flag = true;
          }
          int num3 = index1;
          for (int index2 = 0; index2 < length1; ++index2)
          {
            if (this.candidateColumns[index2] != null)
            {
              if (!this.candidateColumns[index2].flag)
                ndexDesc[num3++] = index2;
              else
                this.candidateColumns[index2].flag = false;
            }
          }
          IndexField[] indexFields = DataTable.zeroIndexField;
          if (ndexDesc.Length != 0)
          {
            indexFields = new IndexField[ndexDesc.Length];
            for (int index2 = 0; index2 < ndexDesc.Length; ++index2)
            {
              DataColumn column = this.table.Columns[DataKey.ColumnOrder(ndexDesc[index2])];
              bool isDescending = DataKey.SortDecending(ndexDesc[index2]);
              indexFields[index2] = new IndexField(column, isDescending);
            }
          }
          this.index = new Index(this.table, ndexDesc, indexFields, this.recordStates, (IFilter) null);
          this.matchedCandidates = 0;
          if (this.linearExpression != this.expression)
          {
            int[] indexDesc = this.index.IndexDesc;
            while (this.matchedCandidates < num3)
            {
              Select.ColumnInfo candidateColumn = this.candidateColumns[DataKey.ColumnOrder(indexDesc[this.matchedCandidates])];
              if (candidateColumn != null && candidateColumn.expr != null)
              {
                ++this.matchedCandidates;
                if (!candidateColumn.equalsOperator)
                  break;
              }
              else
                break;
            }
          }
          for (int index2 = 0; index2 < this.candidateColumns.Length; ++index2)
          {
            if (this.candidateColumns[index2] != null)
              this.candidateColumns[index2].flag = false;
          }
        }
      }
    }

    private bool IsOperatorIn(ExpressionNode enode) => enode is BinaryNode binaryNode && (5 == binaryNode.op || this.IsOperatorIn(binaryNode.right) || this.IsOperatorIn(binaryNode.left));

    private void BuildLinearExpression()
    {
      int[] indexDesc = this.index.IndexDesc;
      int length1 = indexDesc.Length;
      Debug.Assert(this.matchedCandidates > 0 && this.matchedCandidates <= length1, "BuildLinearExpression : Invalid Index");
      for (int index = 0; index < this.matchedCandidates; ++index)
      {
        Select.ColumnInfo candidateColumn = this.candidateColumns[DataKey.ColumnOrder(indexDesc[index])];
        Debug.Assert(candidateColumn != null && candidateColumn.expr != null, "BuildLinearExpression : Must be a matched candidate");
        candidateColumn.flag = true;
      }
      int length2 = this.candidateColumns.Length;
      for (int index = 0; index < length2; ++index)
      {
        if (this.candidateColumns[index] != null)
        {
          if (!this.candidateColumns[index].flag)
          {
            if (this.candidateColumns[index].expr != null)
              this.linearExpression = this.linearExpression == null ? (ExpressionNode) this.candidateColumns[index].expr : (ExpressionNode) new BinaryNode(this.table, 26, (ExpressionNode) this.candidateColumns[index].expr, this.linearExpression);
          }
          else
            this.candidateColumns[index].flag = false;
        }
      }
    }

    public DataRow[] SelectRows()
    {
      bool flag = true;
      this.InitCandidateColumns();
      if (this.expression is BinaryNode)
      {
        this.AnalyzeExpression((BinaryNode) this.expression);
        if (!this.candidatesForBinarySearch)
          this.linearExpression = this.expression;
        if (this.linearExpression == this.expression)
        {
          for (int index = 0; index < this.candidateColumns.Length; ++index)
          {
            if (this.candidateColumns[index] != null)
            {
              this.candidateColumns[index].equalsOperator = false;
              this.candidateColumns[index].expr = (BinaryNode) null;
            }
          }
        }
        else
          flag = !this.FindClosestCandidateIndex();
      }
      else
        this.linearExpression = this.expression;
      if (this.index == null && (this.indexDesc.Length != 0 || this.linearExpression == this.expression))
        flag = !this.FindSortIndex();
      if (this.index == null)
      {
        this.CreateIndex();
        flag = false;
      }
      if (this.index.RecordCount == 0)
        return this.table.NewRowArray(0);
      if (this.matchedCandidates == 0)
      {
        Range range = new Range(0, this.index.RecordCount - 1);
        Debug.Assert(!flag, "What are we doing here if no real reuse of this index ?");
        this.linearExpression = this.expression;
        return this.GetLinearFilteredRows(range);
      }
      Range binaryFilteredRecords = this.GetBinaryFilteredRecords();
      if (binaryFilteredRecords.Count == 0)
        return this.table.NewRowArray(0);
      if (this.matchedCandidates < this.nCandidates)
        this.BuildLinearExpression();
      if (!flag)
        return this.GetLinearFilteredRows(binaryFilteredRecords);
      this.records = this.GetLinearFilteredRecords(binaryFilteredRecords);
      this.recordCount = this.records.Length;
      if (this.recordCount == 0)
        return this.table.NewRowArray(0);
      this.Sort(0, this.recordCount - 1);
      return this.GetRows();
    }

    public DataRow[] GetRows()
    {
      DataRow[] dataRowArray = this.table.NewRowArray(this.recordCount);
      for (int index = 0; index < dataRowArray.Length; ++index)
        dataRowArray[index] = this.table.recordManager[this.records[index]];
      return dataRowArray;
    }

    private bool AcceptRecord(int record)
    {
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
      object obj = this.linearExpression.Eval(row, version);
      try
      {
        return DataExpression.ToBoolean(obj);
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableExceptionType(ex))
          throw ExprException.FilterConvertion(this.rowFilter.Expression);
        throw;
      }
    }

    private int Eval(BinaryNode expr, DataRow row, DataRowVersion version)
    {
      if (expr.op == 26)
      {
        int num1 = this.Eval((BinaryNode) expr.left, row, version);
        if (num1 != 0)
          return num1;
        int num2 = this.Eval((BinaryNode) expr.right, row, version);
        return num2 != 0 ? num2 : 0;
      }
      long num = 0;
      object vLeft = expr.left.Eval(row, version);
      if (expr.op != 13 && expr.op != 39)
      {
        object vRight = expr.right.Eval(row, version);
        bool lc = expr.left is ConstNode;
        bool rc = expr.right is ConstNode;
        if (vLeft == DBNull.Value || expr.left.IsSqlColumn && DataStorage.IsObjectSqlNull(vLeft))
          return -1;
        if (vRight == DBNull.Value || expr.right.IsSqlColumn && DataStorage.IsObjectSqlNull(vRight))
          return 1;
        StorageType storageType1 = DataStorage.GetStorageType(vLeft.GetType());
        if (StorageType.Char == storageType1)
          vRight = rc || !expr.right.IsSqlColumn ? (object) Convert.ToChar(vRight, this.table.FormatProvider) : SqlConvert.ChangeType2(vRight, StorageType.Char, typeof (char), this.table.FormatProvider);
        StorageType storageType2 = DataStorage.GetStorageType(vRight.GetType());
        StorageType resultType = expr.left.IsSqlColumn || expr.right.IsSqlColumn ? expr.ResultSqlType(storageType1, storageType2, lc, rc, expr.op) : expr.ResultType(storageType1, storageType2, lc, rc, expr.op);
        if (resultType == StorageType.Empty)
        {
          BinaryNode binaryNode = expr;
          binaryNode.SetTypeMismatchError(binaryNode.op, vLeft.GetType(), vRight.GetType());
        }
        num = (long) expr.BinaryCompare(vLeft, vRight, resultType, expr.op);
      }
      switch (expr.op)
      {
        case 7:
          num = num == 0L ? 0L : (num < 0L ? -1L : 1L);
          break;
        case 8:
          num = num > 0L ? 0L : -1L;
          break;
        case 9:
          num = num < 0L ? 0L : 1L;
          break;
        case 10:
          num = num >= 0L ? 0L : -1L;
          break;
        case 11:
          num = num <= 0L ? 0L : 1L;
          break;
        case 13:
          num = vLeft == DBNull.Value ? 0L : -1L;
          break;
        case 39:
          num = vLeft != DBNull.Value ? 0L : 1L;
          break;
        default:
          Debug.Assert(true, "Unsupported Binary Search Operator!");
          break;
      }
      return (int) num;
    }

    private int Evaluate(int record)
    {
      DataRow row = this.table.recordManager[record];
      if (row == null)
        return 0;
      DataRowVersion version = DataRowVersion.Default;
      if (row.oldRecord == record)
        version = DataRowVersion.Original;
      else if (row.newRecord == record)
        version = DataRowVersion.Current;
      else if (row.tempRecord == record)
        version = DataRowVersion.Proposed;
      int[] indexDesc = this.index.IndexDesc;
      for (int index = 0; index < this.matchedCandidates; ++index)
      {
        Debug.Assert(this.candidateColumns[DataKey.ColumnOrder(indexDesc[index])] != null, "How come this is not a candidate column");
        Debug.Assert(this.candidateColumns[DataKey.ColumnOrder(indexDesc[index])].expr != null, "How come there is no associated expression");
        int num = this.Eval(this.candidateColumns[DataKey.ColumnOrder(indexDesc[index])].expr, row, version);
        if (num != 0)
          return !DataKey.SortDecending(indexDesc[index]) ? num : -num;
      }
      return 0;
    }

    private int FindFirstMatchingRecord()
    {
      int num1 = -1;
      int num2 = 0;
      int num3 = this.index.RecordCount - 1;
      while (num2 <= num3)
      {
        int recordIndex = num2 + num3 >> 1;
        int num4 = this.Evaluate(this.index.GetRecord(recordIndex));
        if (num4 == 0)
          num1 = recordIndex;
        if (num4 < 0)
          num2 = recordIndex + 1;
        else
          num3 = recordIndex - 1;
      }
      return num1;
    }

    private int FindLastMatchingRecord(int lo)
    {
      int num1 = -1;
      int num2 = this.index.RecordCount - 1;
      while (lo <= num2)
      {
        int recordIndex = lo + num2 >> 1;
        int num3 = this.Evaluate(this.index.GetRecord(recordIndex));
        if (num3 == 0)
          num1 = recordIndex;
        if (num3 <= 0)
          lo = recordIndex + 1;
        else
          num2 = recordIndex - 1;
      }
      return num1;
    }

    private Range GetBinaryFilteredRecords()
    {
      if (this.matchedCandidates == 0)
        return new Range(0, this.index.RecordCount - 1);
      Debug.Assert(this.matchedCandidates <= this.index.IndexDesc.Length, "GetBinaryFilteredRecords : Invalid Index");
      int firstMatchingRecord = this.FindFirstMatchingRecord();
      if (firstMatchingRecord == -1)
        return new Range();
      int lastMatchingRecord = this.FindLastMatchingRecord(firstMatchingRecord);
      Debug.Assert(firstMatchingRecord <= lastMatchingRecord, "GetBinaryFilteredRecords : Invalid Search Results");
      return new Range(firstMatchingRecord, lastMatchingRecord);
    }

    private int[] GetLinearFilteredRecords(Range range)
    {
      if (this.linearExpression == null)
      {
        int[] numArray = new int[range.Count];
        RBTree<int>.RBTreeEnumerator enumerator = this.index.GetEnumerator(range.Min);
        for (int index = 0; index < range.Count && enumerator.MoveNext(); ++index)
          numArray[index] = enumerator.Current;
        return numArray;
      }
      List<int> intList = new List<int>();
      RBTree<int>.RBTreeEnumerator enumerator1 = this.index.GetEnumerator(range.Min);
      for (int index = 0; index < range.Count && enumerator1.MoveNext(); ++index)
      {
        if (this.AcceptRecord(enumerator1.Current))
          intList.Add(enumerator1.Current);
      }
      return intList.ToArray();
    }

    private DataRow[] GetLinearFilteredRows(Range range)
    {
      if (this.linearExpression == null)
        return this.index.GetRows(range);
      List<DataRow> dataRowList = new List<DataRow>();
      RBTree<int>.RBTreeEnumerator enumerator = this.index.GetEnumerator(range.Min);
      for (int index = 0; index < range.Count && enumerator.MoveNext(); ++index)
      {
        if (this.AcceptRecord(enumerator.Current))
          dataRowList.Add(this.table.recordManager[enumerator.Current]);
      }
      DataRow[] array = this.table.NewRowArray(dataRowList.Count);
      dataRowList.CopyTo(array);
      return array;
    }

    private int CompareRecords(int record1, int record2)
    {
      int length = this.indexDesc.Length;
      for (int index = 0; index < length; ++index)
      {
        int indexDesc = this.indexDesc[index];
        int num = this.table.Columns[DataKey.ColumnOrder(indexDesc)].Compare(record1, record2);
        if (num != 0)
        {
          if (DataKey.SortDecending(indexDesc))
            num = -num;
          return num;
        }
      }
      int num1 = (this.table.recordManager[record1] == null ? 0 : this.table.recordManager[record1].rowID) - (this.table.recordManager[record2] == null ? 0 : this.table.recordManager[record2].rowID);
      if (num1 == 0 && record1 != record2 && (this.table.recordManager[record1] != null && this.table.recordManager[record2] != null))
        num1 = this.table.recordManager[record1].GetRecordState(record1) - this.table.recordManager[record2].GetRecordState(record2);
      return num1;
    }

    private void Sort(int left, int right)
    {
      int index;
      do
      {
        index = left;
        int right1 = right;
        int record1 = this.records[index + right1 >> 1];
        do
        {
          while (this.CompareRecords(this.records[index], record1) < 0)
            ++index;
          while (this.CompareRecords(this.records[right1], record1) > 0)
            --right1;
          if (index <= right1)
          {
            int record2 = this.records[index];
            this.records[index] = this.records[right1];
            this.records[right1] = record2;
            ++index;
            --right1;
          }
        }
        while (index <= right1);
        if (left < right1)
          this.Sort(left, right1);
        left = index;
      }
      while (index < right);
    }

    private sealed class ColumnInfo
    {
      public bool flag;
      public bool equalsOperator;
      public BinaryNode expr;
    }
  }
}
