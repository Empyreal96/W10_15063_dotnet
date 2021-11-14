// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataKey
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal struct DataKey
  {
    internal const int COLUMN = 65535;
    internal const int DESCENDING = -2147483648;
    private const int maxColumns = 32;
    private readonly DataColumn[] columns;

    internal DataKey(DataColumn[] columns, bool copyColumns)
    {
      if (columns == null)
        throw ExceptionBuilder.ArgumentNull(nameof (columns));
      if (columns.Length == 0)
        throw ExceptionBuilder.KeyNoColumns();
      if (columns.Length > 32)
        throw ExceptionBuilder.KeyTooManyColumns(32);
      for (int index = 0; index < columns.Length; ++index)
      {
        if (columns[index] == null)
          throw ExceptionBuilder.ArgumentNull("column");
      }
      for (int index1 = 0; index1 < columns.Length; ++index1)
      {
        for (int index2 = 0; index2 < index1; ++index2)
        {
          if (columns[index1] == columns[index2])
            throw ExceptionBuilder.KeyDuplicateColumns(columns[index1].ColumnName);
        }
      }
      if (copyColumns)
      {
        this.columns = new DataColumn[columns.Length];
        for (int index = 0; index < columns.Length; ++index)
          this.columns[index] = columns[index];
      }
      else
        this.columns = columns;
      this.CheckState();
    }

    internal DataColumn[] ColumnsReference => this.columns;

    internal bool HasValue => this.columns != null;

    internal DataTable Table => this.columns[0].Table;

    internal void CheckState()
    {
      DataTable table = this.columns[0].Table;
      if (table == null)
        throw ExceptionBuilder.ColumnNotInAnyTable();
      for (int index = 1; index < this.columns.Length; ++index)
      {
        if (this.columns[index].Table == null)
          throw ExceptionBuilder.ColumnNotInAnyTable();
        if (this.columns[index].Table != table)
          throw ExceptionBuilder.KeyTableMismatch();
      }
    }

    internal bool ColumnsEqual(DataKey key)
    {
      DataColumn[] columns1 = this.columns;
      DataColumn[] columns2 = key.columns;
      if (columns1 == columns2)
        return true;
      if (columns1 == null || columns2 == null || columns1.Length != columns2.Length)
        return false;
      for (int index1 = 0; index1 < columns1.Length; ++index1)
      {
        bool flag = false;
        for (int index2 = 0; index2 < columns2.Length; ++index2)
        {
          if (columns1[index1].Equals((object) columns2[index2]))
          {
            flag = true;
            break;
          }
        }
        if (!flag)
          return false;
      }
      return true;
    }

    internal bool ContainsColumn(DataColumn column)
    {
      for (int index = 0; index < this.columns.Length; ++index)
      {
        if (column == this.columns[index])
          return true;
      }
      return false;
    }

    public override int GetHashCode()
    {
      Debug.Assert(false, "don't put DataKey into a Hashtable");
      return base.GetHashCode();
    }

    public static bool operator ==(DataKey x, DataKey y) => x.Equals((object) y);

    public static bool operator !=(DataKey x, DataKey y) => !x.Equals((object) y);

    public override bool Equals(object value)
    {
      Debug.Assert(false, "need to directly call Equals(DataKey)");
      return this.Equals((DataKey) value);
    }

    internal bool Equals(DataKey value)
    {
      DataColumn[] columns1 = this.columns;
      DataColumn[] columns2 = value.columns;
      if (columns1 == columns2)
        return true;
      if (columns1 == null || columns2 == null || columns1.Length != columns2.Length)
        return false;
      for (int index = 0; index < columns1.Length; ++index)
      {
        if (!columns1[index].Equals((object) columns2[index]))
          return false;
      }
      return true;
    }

    internal string[] GetColumnNames()
    {
      string[] strArray = new string[this.columns.Length];
      for (int index = 0; index < this.columns.Length; ++index)
        strArray[index] = this.columns[index].ColumnName;
      return strArray;
    }

    internal IndexField[] GetIndexDesc()
    {
      IndexField[] indexFieldArray = new IndexField[this.columns.Length];
      for (int index = 0; index < this.columns.Length; ++index)
        indexFieldArray[index] = new IndexField(this.columns[index], false);
      return indexFieldArray;
    }

    internal object[] GetKeyValues(int record)
    {
      object[] objArray = new object[this.columns.Length];
      for (int index = 0; index < this.columns.Length; ++index)
        objArray[index] = this.columns[index][record];
      return objArray;
    }

    internal Index GetSortIndex() => this.GetSortIndex(DataViewRowState.CurrentRows);

    internal Index GetSortIndex(DataViewRowState recordStates) => this.columns[0].Table.GetIndex(this.GetIndexDesc(), recordStates, (IFilter) null);

    internal bool RecordsEqual(int record1, int record2)
    {
      for (int index = 0; index < this.columns.Length; ++index)
      {
        if (this.columns[index].Compare(record1, record2) != 0)
          return false;
      }
      return true;
    }

    internal DataColumn[] ToArray()
    {
      DataColumn[] dataColumnArray = new DataColumn[this.columns.Length];
      for (int index = 0; index < this.columns.Length; ++index)
        dataColumnArray[index] = this.columns[index];
      return dataColumnArray;
    }

    internal static int ColumnOrder(int indexDesc) => indexDesc & (int) ushort.MaxValue;

    internal static bool SortDecending(int indexDesc) => (uint) (indexDesc & int.MinValue) > 0U;
  }
}
