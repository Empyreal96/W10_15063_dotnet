// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.UniqueConstraint
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  public class UniqueConstraint : Constraint
  {
    private DataKey key;
    private Index _constraintIndex;
    internal bool bPrimaryKey;
    internal string constraintName;
    internal string[] columnNames;

    public UniqueConstraint(string name, DataColumn column)
    {
      DataColumn[] columns = new DataColumn[1]
      {
        column
      };
      this.Create(name, columns);
    }

    public UniqueConstraint(DataColumn column) => this.Create((string) null, new DataColumn[1]
    {
      column
    });

    public UniqueConstraint(string name, DataColumn[] columns) => this.Create(name, columns);

    public UniqueConstraint(DataColumn[] columns) => this.Create((string) null, columns);

    public UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey)
    {
      this.constraintName = name;
      this.columnNames = columnNames;
      this.bPrimaryKey = isPrimaryKey;
    }

    public UniqueConstraint(string name, DataColumn column, bool isPrimaryKey)
    {
      DataColumn[] columns = new DataColumn[1]
      {
        column
      };
      this.bPrimaryKey = isPrimaryKey;
      this.Create(name, columns);
    }

    public UniqueConstraint(DataColumn column, bool isPrimaryKey)
    {
      DataColumn[] columns = new DataColumn[1]
      {
        column
      };
      this.bPrimaryKey = isPrimaryKey;
      this.Create((string) null, columns);
    }

    public UniqueConstraint(string name, DataColumn[] columns, bool isPrimaryKey)
    {
      this.bPrimaryKey = isPrimaryKey;
      this.Create(name, columns);
    }

    public UniqueConstraint(DataColumn[] columns, bool isPrimaryKey)
    {
      this.bPrimaryKey = isPrimaryKey;
      this.Create((string) null, columns);
    }

    internal Index ConstraintIndex
    {
      get
      {
        Debug.Assert(this._constraintIndex != null, "null UniqueConstraint index");
        return this._constraintIndex;
      }
    }

    internal void ConstraintIndexClear()
    {
      if (this._constraintIndex == null)
        return;
      this._constraintIndex.RemoveRef();
      this._constraintIndex = (Index) null;
    }

    internal void ConstraintIndexInitialize()
    {
      if (this._constraintIndex == null)
      {
        this._constraintIndex = this.key.GetSortIndex();
        this._constraintIndex.AddRef();
      }
      Debug.Assert(this._constraintIndex == this.key.GetSortIndex(), "unexpected sort index");
    }

    internal override void CheckState() => this.NonVirtualCheckState();

    private void NonVirtualCheckState() => this.key.CheckState();

    internal override void CheckCanAddToCollection(ConstraintCollection constraints)
    {
    }

    internal override bool CanBeRemovedFromCollection(
      ConstraintCollection constraints,
      bool fThrowException)
    {
      if (this.Equals((object) constraints.Table.primaryKey))
      {
        Debug.Assert(constraints.Table.primaryKey == this, "If the primary key and this are 'Equal', they should also be '=='");
        if (!fThrowException)
          return false;
        throw ExceptionBuilder.RemovePrimaryKey(constraints.Table);
      }
      ParentForeignKeyConstraintEnumerator constraintEnumerator = new ParentForeignKeyConstraintEnumerator(this.Table.DataSet, this.Table);
      while (constraintEnumerator.GetNext())
      {
        ForeignKeyConstraint foreignKeyConstraint = constraintEnumerator.GetForeignKeyConstraint();
        if (this.key.ColumnsEqual(foreignKeyConstraint.ParentKey))
        {
          if (!fThrowException)
            return false;
          throw ExceptionBuilder.NeededForForeignKeyConstraint(this, foreignKeyConstraint);
        }
      }
      return true;
    }

    internal override bool CanEnableConstraint() => !this.Table.EnforceConstraints || this.ConstraintIndex.CheckUnique();

    internal override bool IsConstraintViolated()
    {
      bool flag = false;
      Index constraintIndex = this.ConstraintIndex;
      if (constraintIndex.HasDuplicates)
      {
        object[] uniqueKeyValues = constraintIndex.GetUniqueKeyValues();
        for (int index1 = 0; index1 < uniqueKeyValues.Length; ++index1)
        {
          Range records = constraintIndex.FindRecords((object[]) uniqueKeyValues[index1]);
          if (1 < records.Count)
          {
            DataRow[] rows = constraintIndex.GetRows(records);
            string error = ExceptionBuilder.UniqueConstraintViolationText(this.key.ColumnsReference, (object[]) uniqueKeyValues[index1]);
            for (int index2 = 0; index2 < rows.Length; ++index2)
            {
              rows[index2].RowError = error;
              foreach (DataColumn column in this.key.ColumnsReference)
                rows[index2].SetColumnError(column, error);
            }
            flag = true;
          }
        }
      }
      return flag;
    }

    internal override void CheckConstraint(DataRow row, DataRowAction action)
    {
      if (!this.Table.EnforceConstraints)
        return;
      switch (action)
      {
        case DataRowAction.Change:
        case DataRowAction.Add:
          if (!row.HaveValuesChanged(this.ColumnsReference) || !this.ConstraintIndex.IsKeyRecordInIndex(row.GetDefaultRecord()))
            break;
          throw ExceptionBuilder.ConstraintViolation(this.ColumnsReference, row.GetColumnValues(this.ColumnsReference));
        case DataRowAction.Rollback:
          if (row.tempRecord == -1)
            break;
          goto case DataRowAction.Change;
      }
    }

    internal override bool ContainsColumn(DataColumn column) => this.key.ContainsColumn(column);

    internal override Constraint Clone(DataSet destination) => this.Clone(destination, false);

    internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup)
    {
      int index1 = !ignorNSforTableLookup ? destination.Tables.IndexOf(this.Table.TableName, this.Table.Namespace, false) : destination.Tables.IndexOf(this.Table.TableName);
      if (index1 < 0)
        return (Constraint) null;
      DataTable table = destination.Tables[index1];
      int length = this.ColumnsReference.Length;
      DataColumn[] columns = new DataColumn[length];
      for (int index2 = 0; index2 < length; ++index2)
      {
        DataColumn dataColumn = this.ColumnsReference[index2];
        int index3 = table.Columns.IndexOf(dataColumn.ColumnName);
        if (index3 < 0)
          return (Constraint) null;
        columns[index2] = table.Columns[index3];
      }
      UniqueConstraint uniqueConstraint = new UniqueConstraint(this.ConstraintName, columns);
      foreach (object key in (IEnumerable) this.ExtendedProperties.Keys)
        uniqueConstraint.ExtendedProperties[key] = this.ExtendedProperties[key];
      return (Constraint) uniqueConstraint;
    }

    internal UniqueConstraint Clone(DataTable table)
    {
      int length = this.ColumnsReference.Length;
      DataColumn[] columns = new DataColumn[length];
      for (int index1 = 0; index1 < length; ++index1)
      {
        DataColumn dataColumn = this.ColumnsReference[index1];
        int index2 = table.Columns.IndexOf(dataColumn.ColumnName);
        if (index2 < 0)
          return (UniqueConstraint) null;
        columns[index1] = table.Columns[index2];
      }
      UniqueConstraint uniqueConstraint = new UniqueConstraint(this.ConstraintName, columns);
      foreach (object key in (IEnumerable) this.ExtendedProperties.Keys)
        uniqueConstraint.ExtendedProperties[key] = this.ExtendedProperties[key];
      return uniqueConstraint;
    }

    public virtual DataColumn[] Columns => this.key.ToArray();

    internal DataColumn[] ColumnsReference => this.key.ColumnsReference;

    public bool IsPrimaryKey => this.Table != null && this == this.Table.primaryKey;

    private void Create(string constraintName, DataColumn[] columns)
    {
      for (int index = 0; index < columns.Length; ++index)
      {
        if (columns[index].Computed)
          throw ExceptionBuilder.ExpressionInConstraint(columns[index]);
      }
      this.key = new DataKey(columns, true);
      this.ConstraintName = constraintName;
      this.NonVirtualCheckState();
    }

    public override bool Equals(object key2) => key2 is UniqueConstraint && this.Key.ColumnsEqual(((UniqueConstraint) key2).Key);

    public override int GetHashCode() => base.GetHashCode();

    internal override bool InCollection
    {
      set
      {
        base.InCollection = value;
        if (this.key.ColumnsReference.Length != 1)
          return;
        this.key.ColumnsReference[0].InternalUnique(value);
      }
    }

    internal DataKey Key => this.key;

    public override DataTable Table => this.key.HasValue ? this.key.Table : (DataTable) null;
  }
}
