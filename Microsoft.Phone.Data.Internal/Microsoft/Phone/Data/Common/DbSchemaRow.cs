// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbSchemaRow
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class DbSchemaRow
  {
    internal const string SchemaMappingUnsortedIndex = "SchemaMapping Unsorted Index";
    private DbSchemaTable schemaTable;
    private DataRow dataRow;

    internal static DbSchemaRow[] GetSortedSchemaRows(
      DataTable dataTable,
      bool returnProviderSpecificTypes)
    {
      DataColumn column = dataTable.Columns["SchemaMapping Unsorted Index"];
      if (column == null)
      {
        column = new DataColumn("SchemaMapping Unsorted Index", typeof (int));
        dataTable.Columns.Add(column);
      }
      int count = dataTable.Rows.Count;
      for (int index = 0; index < count; ++index)
        dataTable.Rows[index][column] = (object) index;
      DbSchemaTable schemaTable = new DbSchemaTable(dataTable, returnProviderSpecificTypes);
      DataRow[] dataRowArray = dataTable.Select((string) null, "ColumnOrdinal ASC", DataViewRowState.CurrentRows);
      Debug.Assert(dataRowArray != null, "GetSchemaRows: unexpected null dataRows");
      DbSchemaRow[] dbSchemaRowArray = new DbSchemaRow[dataRowArray.Length];
      for (int index = 0; index < dataRowArray.Length; ++index)
        dbSchemaRowArray[index] = new DbSchemaRow(schemaTable, dataRowArray[index]);
      return dbSchemaRowArray;
    }

    internal DbSchemaRow(DbSchemaTable schemaTable, DataRow dataRow)
    {
      this.schemaTable = schemaTable;
      this.dataRow = dataRow;
    }

    internal DataRow DataRow => this.dataRow;

    internal string ColumnName
    {
      get
      {
        Debug.Assert(this.schemaTable.ColumnName != null, "no column ColumnName");
        object obj = this.dataRow[this.schemaTable.ColumnName, DataRowVersion.Default];
        return !Convert.IsDBNull(obj) ? Convert.ToString(obj, (IFormatProvider) CultureInfo.InvariantCulture) : "";
      }
    }

    internal int Size
    {
      get
      {
        Debug.Assert(this.schemaTable.Size != null, "no column Size");
        object obj = this.dataRow[this.schemaTable.Size, DataRowVersion.Default];
        return !Convert.IsDBNull(obj) ? Convert.ToInt32(obj, (IFormatProvider) CultureInfo.InvariantCulture) : 0;
      }
    }

    internal string BaseColumnName
    {
      get
      {
        if (this.schemaTable.BaseColumnName != null)
        {
          object obj = this.dataRow[this.schemaTable.BaseColumnName, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToString(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return "";
      }
    }

    internal string BaseServerName
    {
      get
      {
        if (this.schemaTable.BaseServerName != null)
        {
          object obj = this.dataRow[this.schemaTable.BaseServerName, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToString(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return "";
      }
    }

    internal string BaseCatalogName
    {
      get
      {
        if (this.schemaTable.BaseCatalogName != null)
        {
          object obj = this.dataRow[this.schemaTable.BaseCatalogName, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToString(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return "";
      }
    }

    internal string BaseSchemaName
    {
      get
      {
        if (this.schemaTable.BaseSchemaName != null)
        {
          object obj = this.dataRow[this.schemaTable.BaseSchemaName, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToString(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return "";
      }
    }

    internal string BaseTableName
    {
      get
      {
        if (this.schemaTable.BaseTableName != null)
        {
          object obj = this.dataRow[this.schemaTable.BaseTableName, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToString(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return "";
      }
    }

    internal bool IsAutoIncrement
    {
      get
      {
        if (this.schemaTable.IsAutoIncrement != null)
        {
          object obj = this.dataRow[this.schemaTable.IsAutoIncrement, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToBoolean(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return false;
      }
    }

    internal bool IsUnique
    {
      get
      {
        if (this.schemaTable.IsUnique != null)
        {
          object obj = this.dataRow[this.schemaTable.IsUnique, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToBoolean(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return false;
      }
    }

    internal bool IsRowVersion
    {
      get
      {
        if (this.schemaTable.IsRowVersion != null)
        {
          object obj = this.dataRow[this.schemaTable.IsRowVersion, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToBoolean(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return false;
      }
    }

    internal bool IsKey
    {
      get
      {
        if (this.schemaTable.IsKey != null)
        {
          object obj = this.dataRow[this.schemaTable.IsKey, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToBoolean(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return false;
      }
    }

    internal bool IsExpression
    {
      get
      {
        if (this.schemaTable.IsExpression != null)
        {
          object obj = this.dataRow[this.schemaTable.IsExpression, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToBoolean(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return false;
      }
    }

    internal bool IsHidden
    {
      get
      {
        if (this.schemaTable.IsHidden != null)
        {
          object obj = this.dataRow[this.schemaTable.IsHidden, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToBoolean(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return false;
      }
    }

    internal bool IsLong
    {
      get
      {
        if (this.schemaTable.IsLong != null)
        {
          object obj = this.dataRow[this.schemaTable.IsLong, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToBoolean(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return false;
      }
    }

    internal bool IsReadOnly
    {
      get
      {
        if (this.schemaTable.IsReadOnly != null)
        {
          object obj = this.dataRow[this.schemaTable.IsReadOnly, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToBoolean(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return false;
      }
    }

    internal Type DataType
    {
      get
      {
        if (this.schemaTable.DataType != null)
        {
          object obj = this.dataRow[this.schemaTable.DataType, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return (Type) obj;
        }
        return (Type) null;
      }
    }

    internal bool AllowDBNull
    {
      get
      {
        if (this.schemaTable.AllowDBNull != null)
        {
          object obj = this.dataRow[this.schemaTable.AllowDBNull, DataRowVersion.Default];
          if (!Convert.IsDBNull(obj))
            return Convert.ToBoolean(obj, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return true;
      }
    }

    internal int UnsortedIndex => (int) this.dataRow[this.schemaTable.UnsortedIndex, DataRowVersion.Default];
  }
}
