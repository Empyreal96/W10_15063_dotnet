// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataColumn
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using Microsoft.Phone.Data.Workaround;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Xml;

namespace Microsoft.Phone.Data
{
  public class DataColumn : MarshalByValueComponent
  {
    private bool allowNull = true;
    private bool autoIncrement;
    private long autoIncrementStep = 1;
    private long autoIncrementSeed;
    private string caption;
    private string _columnName;
    private Type dataType;
    internal object defaultValue = (object) DBNull.Value;
    private DataSetDateTime _dateTimeMode = DataSetDateTime.UnspecifiedLocal;
    private DataExpression expression;
    private int maxLength = -1;
    private int _ordinal = -1;
    private bool readOnly;
    internal Index sortIndex;
    internal DataTable table;
    private bool unique;
    internal MappingType columnMapping = MappingType.Element;
    internal int _hashCode;
    internal int errors;
    private bool isSqlType;
    private bool implementsINullable;
    private bool implementsIChangeTracking;
    private bool implementsIRevertibleChangeTracking;
    private bool implementsIXMLSerializable;
    private bool defaultValueIsNull = true;
    internal List<DataColumn> dependentColumns;
    internal PropertyCollection extendedProperties;
    private PropertyChangedEventHandler onPropertyChangingDelegate;
    private DataStorage _storage;
    internal long autoIncrementCurrent;
    internal string _columnUri;
    private string _columnPrefix = "";
    internal string encodedColumnName;
    internal string description = "";
    internal string dttype = "";
    internal SimpleType simpleType;

    public DataColumn()
      : this((string) null, typeof (string), (string) null, MappingType.Element)
    {
    }

    public DataColumn(string columnName)
      : this(columnName, typeof (string), (string) null, MappingType.Element)
    {
    }

    public DataColumn(string columnName, Type dataType)
      : this(columnName, dataType, (string) null, MappingType.Element)
    {
    }

    public DataColumn(string columnName, Type dataType, string expr)
      : this(columnName, dataType, expr, MappingType.Element)
    {
    }

    public DataColumn(string columnName, Type dataType, string expr, MappingType type)
    {
      GC.SuppressFinalize((object) this);
      StorageType typeCode = dataType != null ? DataStorage.GetStorageType(dataType) : throw ExceptionBuilder.ArgumentNull(nameof (dataType));
      if (DataStorage.ImplementsINullableValue(typeCode, dataType))
        throw ExceptionBuilder.ColumnTypeNotSupported();
      this._columnName = columnName == null ? "" : columnName;
      SimpleType simpleType = SimpleType.CreateSimpleType(dataType);
      if (simpleType != null)
        this.SimpleType = simpleType;
      this.UpdateColumnType(dataType, typeCode);
      if (expr != null && 0 < expr.Length)
        this.Expression = expr;
      this.columnMapping = type;
    }

    private void UpdateColumnType(Type type, StorageType typeCode)
    {
      this.dataType = type;
      if (StorageType.DateTime != typeCode)
        this._dateTimeMode = DataSetDateTime.UnspecifiedLocal;
      DataStorage.ImplementsInterfaces(typeCode, type, out this.isSqlType, out this.implementsINullable, out this.implementsIXMLSerializable, out this.implementsIChangeTracking, out this.implementsIRevertibleChangeTracking);
    }

    public bool AllowDBNull
    {
      get => this.allowNull;
      set
      {
        if (this.allowNull == value)
          return;
        if (this.table != null && !value && this.table.EnforceConstraints)
          this.CheckNotAllowNull();
        this.allowNull = value;
      }
    }

    public bool AutoIncrement
    {
      get => this.autoIncrement;
      set
      {
        if (this.autoIncrement == value)
          return;
        if (value)
        {
          if (this.expression != null)
            throw ExceptionBuilder.AutoIncrementAndExpression();
          if (!this.DefaultValueIsNull)
            throw ExceptionBuilder.AutoIncrementAndDefaultValue();
          if (!DataColumn.IsAutoIncrementType(this.DataType))
          {
            if (this.HasData)
              throw ExceptionBuilder.AutoIncrementCannotSetIfHasData(this.DataType.Name);
            this.DataType = typeof (int);
          }
        }
        this.autoIncrement = value;
      }
    }

    public long AutoIncrementSeed
    {
      get => this.autoIncrementSeed;
      set
      {
        if (this.autoIncrementSeed == value)
          return;
        if (this.autoIncrementCurrent == this.autoIncrementSeed)
          this.autoIncrementCurrent = value;
        if (this.AutoIncrementStep > 0L)
        {
          if (this.autoIncrementCurrent < value)
            this.autoIncrementCurrent = value;
        }
        else if (this.autoIncrementCurrent > value)
          this.autoIncrementCurrent = value;
        this.autoIncrementSeed = value;
      }
    }

    public long AutoIncrementStep
    {
      get => this.autoIncrementStep;
      set
      {
        if (this.autoIncrementStep == value)
          return;
        if (value == 0L)
          throw ExceptionBuilder.AutoIncrementSeed();
        if (this.autoIncrementCurrent != this.autoIncrementSeed)
          this.autoIncrementCurrent += value - this.autoIncrementStep;
        this.autoIncrementStep = value;
      }
    }

    public string Caption
    {
      get => this.caption == null ? this._columnName : this.caption;
      set
      {
        if (value == null)
          value = "";
        if (this.caption != null && string.Compare(this.caption, value, this.Locale, CompareOptions.IgnoreCase) == 0)
          return;
        this.caption = value;
      }
    }

    public string ColumnName
    {
      get => this._columnName;
      set
      {
        if (value == null)
          value = "";
        if (string.Compare(this._columnName, value, this.Locale, CompareOptions.IgnoreCase) != 0)
        {
          if (this.table != null)
          {
            if (value.Length == 0)
              throw ExceptionBuilder.ColumnNameRequired();
            this.table.Columns.RegisterColumnName(value, this, (DataTable) null);
            if (this._columnName.Length != 0)
              this.table.Columns.UnregisterName(this._columnName);
          }
          this.RaisePropertyChanging(nameof (ColumnName));
          this._columnName = value;
          this.encodedColumnName = (string) null;
          if (this.table == null)
            return;
          this.table.Columns.OnColumnPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, (object) this));
        }
        else
        {
          if (!(this._columnName != value))
            return;
          this.RaisePropertyChanging(nameof (ColumnName));
          this._columnName = value;
          this.encodedColumnName = (string) null;
          if (this.table == null)
            return;
          this.table.Columns.OnColumnPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, (object) this));
        }
      }
    }

    internal string EncodedColumnName
    {
      get
      {
        if (this.encodedColumnName == null)
          this.encodedColumnName = XmlConvert.EncodeLocalName(this.ColumnName);
        Debug.Assert(this.encodedColumnName != null && (uint) this.encodedColumnName.Length > 0U);
        return this.encodedColumnName;
      }
    }

    internal IFormatProvider FormatProvider => this.table == null ? (IFormatProvider) CultureInfo.CurrentCulture : this.table.FormatProvider;

    internal CultureInfo Locale => this.table == null ? CultureInfo.CurrentCulture : this.table.Locale;

    public string Prefix
    {
      get => this._columnPrefix;
      set
      {
        if (value == null)
          value = "";
        this._columnPrefix = !(XmlConvert.DecodeName(value) == value) || !(XmlConvert.EncodeName(value) != value) ? value : throw ExceptionBuilder.InvalidPrefix(value);
      }
    }

    internal bool Computed => this.expression != null;

    internal DataExpression DataExpression => this.expression;

    public Type DataType
    {
      get => this.dataType;
      set
      {
        if (this.dataType == value)
          return;
        if (this.HasData)
          throw ExceptionBuilder.CantChangeDataType();
        StorageType typeCode = value != null ? DataStorage.GetStorageType(value) : throw ExceptionBuilder.NullDataType();
        if (DataStorage.ImplementsINullableValue(typeCode, value))
          throw ExceptionBuilder.ColumnTypeNotSupported();
        if (this.table != null && this.IsInRelation())
          throw ExceptionBuilder.ColumnsTypeMismatch();
        if (!this.DefaultValueIsNull)
        {
          try
          {
            if (typeof (string) == value)
              this.defaultValue = (object) this.DefaultValue.ToString();
            else if (typeof (object) != value)
              this.DefaultValue = SqlConvert.ChangeType(this.DefaultValue, value, this.FormatProvider);
          }
          catch (InvalidCastException ex)
          {
            throw ExceptionBuilder.DefaultValueDataType(this.ColumnName, this.DefaultValue.GetType(), value);
          }
          catch (FormatException ex)
          {
            throw ExceptionBuilder.DefaultValueDataType(this.ColumnName, this.DefaultValue.GetType(), value);
          }
        }
        this.SimpleType = this.ColumnMapping != MappingType.SimpleContent || value != typeof (char) ? SimpleType.CreateSimpleType(value) : throw ExceptionBuilder.CannotSetSimpleContentType(this.ColumnName, value);
        if (StorageType.String == typeCode)
          this.maxLength = -1;
        this.UpdateColumnType(value, typeCode);
        this.XmlDataType = (string) null;
        if (!this.AutoIncrement || DataColumn.IsAutoIncrementType(value))
          return;
        this.AutoIncrement = false;
      }
    }

    public DataSetDateTime DateTimeMode
    {
      get => this._dateTimeMode;
      set
      {
        if (this._dateTimeMode == value)
          return;
        if (this.DataType != typeof (DateTime) && value != DataSetDateTime.UnspecifiedLocal)
          throw ExceptionBuilder.CannotSetDateTimeModeForNonDateTimeColumns();
        switch (value)
        {
          case DataSetDateTime.Local:
          case DataSetDateTime.Utc:
            if (this.HasData)
              throw ExceptionBuilder.CantChangeDateTimeMode(this._dateTimeMode, value);
            break;
          case DataSetDateTime.Unspecified:
          case DataSetDateTime.UnspecifiedLocal:
            if (this._dateTimeMode != DataSetDateTime.Unspecified && this._dateTimeMode != DataSetDateTime.UnspecifiedLocal && this.HasData)
              throw ExceptionBuilder.CantChangeDateTimeMode(this._dateTimeMode, value);
            break;
          default:
            throw ExceptionBuilder.InvalidDateTimeMode(value);
        }
        this._dateTimeMode = value;
      }
    }

    public object DefaultValue
    {
      get
      {
        Debug.Assert(this.defaultValue != null, "It should not have been set to null.");
        if (this.defaultValue == DBNull.Value && this.implementsINullable)
        {
          if (this._storage != null)
            this.defaultValue = this._storage.NullValue;
          else if (this.isSqlType)
            this.defaultValue = SqlConvert.ChangeType(this.defaultValue, this.dataType, this.FormatProvider);
          else if (this.implementsINullable)
          {
            PropertyInfo property = this.dataType.GetProperty("Null", BindingFlags.Static | BindingFlags.Public);
            if (property != null)
              this.defaultValue = property.GetValue((object) null, (object[]) null);
          }
        }
        return this.defaultValue;
      }
      set
      {
        if (this.defaultValue != null && this.DefaultValue.Equals(value))
          return;
        if (this.AutoIncrement)
          throw ExceptionBuilder.DefaultValueAndAutoIncrement();
        object obj = value == null ? (object) DBNull.Value : value;
        if (obj != DBNull.Value)
        {
          if (this.DataType != typeof (object))
          {
            try
            {
              obj = SqlConvert.ChangeType(obj, this.DataType, this.FormatProvider);
            }
            catch (InvalidCastException ex)
            {
              throw ExceptionBuilder.DefaultValueColumnDataType(this.ColumnName, this.DefaultValue.GetType(), this.DataType);
            }
          }
        }
        this.defaultValue = obj;
        this.defaultValueIsNull = obj == DBNull.Value || this.ImplementsINullable && DataStorage.IsObjectSqlNull(obj);
      }
    }

    internal bool DefaultValueIsNull => this.defaultValueIsNull;

    internal void BindExpression() => this.DataExpression.Bind(this.table);

    public string Expression
    {
      get => this.expression != null ? this.expression.Expression : "";
      set
      {
        if (value == null)
          value = "";
        DataExpression dataExpression1 = (DataExpression) null;
        if (value.Length > 0)
        {
          DataExpression dataExpression2 = new DataExpression(this.table, value, this.dataType);
          if (dataExpression2.HasValue)
            dataExpression1 = dataExpression2;
        }
        if (this.expression == null && dataExpression1 != null)
        {
          if (this.AutoIncrement || this.Unique)
            throw ExceptionBuilder.ExpressionAndUnique();
          if (this.table != null)
          {
            for (int index = 0; index < this.table.Constraints.Count; ++index)
            {
              if (this.table.Constraints[index].ContainsColumn(this))
                throw ExceptionBuilder.ExpressionAndConstraint(this, this.table.Constraints[index]);
            }
          }
          bool flag = this.ReadOnly;
          try
          {
            this.ReadOnly = true;
          }
          catch (ReadOnlyException ex)
          {
            ExceptionBuilder.TraceExceptionForCapture((Exception) ex);
            this.ReadOnly = flag;
            throw ExceptionBuilder.ExpressionAndReadOnly();
          }
        }
        if (this.table != null)
        {
          if (dataExpression1 != null && dataExpression1.DependsOn(this))
            throw ExceptionBuilder.ExpressionCircular();
          this.HandleDependentColumnList(this.expression, dataExpression1);
          DataExpression expression = this.expression;
          this.expression = dataExpression1;
          try
          {
            if (dataExpression1 == null)
            {
              for (int record = 0; record < this.table.RecordCapacity; ++record)
                this.InitializeRecord(record);
            }
            else
              this.table.EvaluateExpressions(this);
            this.table.ResetInternalIndexes(this);
            this.table.EvaluateDependentExpressions(this);
          }
          catch (Exception ex1)
          {
            if (!ADP.IsCatchableExceptionType(ex1))
            {
              throw;
            }
            else
            {
              ExceptionBuilder.TraceExceptionForCapture(ex1);
              try
              {
                this.expression = expression;
                this.HandleDependentColumnList(dataExpression1, this.expression);
                if (expression == null)
                {
                  for (int record = 0; record < this.table.RecordCapacity; ++record)
                    this.InitializeRecord(record);
                }
                else
                  this.table.EvaluateExpressions(this);
                this.table.ResetInternalIndexes(this);
                this.table.EvaluateDependentExpressions(this);
              }
              catch (Exception ex2)
              {
                if (!ADP.IsCatchableExceptionType(ex2))
                  throw;
                else
                  ExceptionBuilder.TraceExceptionWithoutRethrow(ex2);
              }
              throw;
            }
          }
        }
        else
          this.expression = dataExpression1;
      }
    }

    public PropertyCollection ExtendedProperties
    {
      get
      {
        if (this.extendedProperties == null)
          this.extendedProperties = new PropertyCollection();
        return this.extendedProperties;
      }
    }

    internal bool HasData => this._storage != null;

    internal bool ImplementsINullable => this.implementsINullable;

    internal bool ImplementsIChangeTracking => this.implementsIChangeTracking;

    internal bool ImplementsIRevertibleChangeTracking => this.implementsIRevertibleChangeTracking;

    internal bool IsCloneable
    {
      get
      {
        Debug.Assert(this._storage != null, "no storage");
        return this._storage.IsCloneable;
      }
    }

    internal bool IsStringType
    {
      get
      {
        Debug.Assert(this._storage != null, "no storage");
        return this._storage.IsStringType;
      }
    }

    internal bool IsValueType
    {
      get
      {
        Debug.Assert(this._storage != null, "no storage");
        return this._storage.IsValueType;
      }
    }

    internal bool IsSqlType => this.isSqlType;

    private void SetMaxLengthSimpleType()
    {
      if (this.simpleType != null)
      {
        Debug.Assert(this.simpleType.CanHaveMaxLength(), "expected simpleType to be string");
        this.simpleType.MaxLength = this.maxLength;
        if (this.simpleType.IsPlainString())
        {
          this.simpleType = (SimpleType) null;
        }
        else
        {
          if (this.simpleType.Name == null || this.dttype == null)
            return;
          this.simpleType.ConvertToAnnonymousSimpleType();
          this.dttype = (string) null;
        }
      }
      else
      {
        if (-1 >= this.maxLength)
          return;
        this.SimpleType = SimpleType.CreateLimitedStringType(this.maxLength);
      }
    }

    public int MaxLength
    {
      get => this.maxLength;
      set
      {
        if (this.maxLength == value)
          return;
        if (this.ColumnMapping == MappingType.SimpleContent)
          throw ExceptionBuilder.CannotSetMaxLength2(this);
        if (this.DataType != typeof (string))
          throw ExceptionBuilder.HasToBeStringType(this);
        int maxLength = this.maxLength;
        this.maxLength = Math.Max(value, -1);
        if ((maxLength < 0 || value < maxLength) && (this.table != null && this.table.EnforceConstraints) && !this.CheckMaxLength())
        {
          this.maxLength = maxLength;
          throw ExceptionBuilder.CannotSetMaxLength(this, value);
        }
        this.SetMaxLengthSimpleType();
      }
    }

    public string Namespace
    {
      get
      {
        if (this._columnUri != null)
          return this._columnUri;
        return this.Table != null && this.columnMapping != MappingType.Attribute ? this.Table.Namespace : "";
      }
      set
      {
        if (!(this._columnUri != value))
          return;
        if (this.columnMapping != MappingType.SimpleContent)
        {
          this.RaisePropertyChanging(nameof (Namespace));
          this._columnUri = value;
        }
        else if (value != this.Namespace)
          throw ExceptionBuilder.CannotChangeNamespace(this.ColumnName);
      }
    }

    public int Ordinal => this._ordinal;

    public void SetOrdinal(int ordinal)
    {
      if (this._ordinal == -1)
        throw ExceptionBuilder.ColumnNotInAnyTable();
      if (this._ordinal == ordinal)
        return;
      this.table.Columns.MoveTo(this, ordinal);
    }

    internal void SetOrdinalInternal(int ordinal)
    {
      if (this._ordinal == ordinal)
        return;
      if (this.Unique && this._ordinal != -1 && ordinal == -1)
      {
        UniqueConstraint keyConstraint = this.table.Constraints.FindKeyConstraint(this);
        if (keyConstraint != null)
          this.table.Constraints.Remove((Constraint) keyConstraint);
      }
      if (this.sortIndex != null && -1 == ordinal)
      {
        Debug.Assert(2 <= this.sortIndex.RefCount, "bad sortIndex refcount");
        this.sortIndex.RemoveRef();
        this.sortIndex.RemoveRef();
        this.sortIndex = (Index) null;
      }
      int ordinal1 = this._ordinal;
      this._ordinal = ordinal;
      if (ordinal1 != -1 || this._ordinal == -1 || !this.Unique)
        return;
      this.table.Constraints.Add((Constraint) new UniqueConstraint(this));
    }

    public bool ReadOnly
    {
      get => this.readOnly;
      set
      {
        if (this.readOnly == value)
          return;
        this.readOnly = value || this.expression == null ? value : throw ExceptionBuilder.ReadOnlyAndExpression();
      }
    }

    private Index SortIndex
    {
      get
      {
        if (this.sortIndex == null)
        {
          this.sortIndex = this.table.GetIndex(new IndexField[1]
          {
            new IndexField(this, false)
          }, DataViewRowState.CurrentRows, (IFilter) null);
          this.sortIndex.AddRef();
        }
        return this.sortIndex;
      }
    }

    public DataTable Table => this.table;

    internal void SetTable(DataTable table)
    {
      if (this.table == table)
        return;
      if (this.Computed && (table == null || !table.fInitInProgress && (table.DataSet == null || !table.DataSet.fIsSchemaLoading && !table.DataSet.fInitInProgress)))
        this.DataExpression.Bind(table);
      if (this.Unique && this.table != null)
      {
        UniqueConstraint keyConstraint = table.Constraints.FindKeyConstraint(this);
        if (keyConstraint != null)
          table.Constraints.CanRemove((Constraint) keyConstraint, true);
      }
      this.table = table;
      this._storage = (DataStorage) null;
    }

    private DataRow GetDataRow(int index) => this.table.recordManager[index];

    internal object this[int record]
    {
      get
      {
        this.table.recordManager.VerifyRecord(record);
        Debug.Assert(this._storage != null, "null storage");
        return this._storage.Get(record);
      }
      set
      {
        try
        {
          this.table.recordManager.VerifyRecord(record);
          Debug.Assert(this._storage != null, "no storage");
          Debug.Assert(value != null, "setting null, expecting dbnull");
          this._storage.Set(record, value);
          Debug.Assert(this.table != null, "storage with no DataTable on column");
        }
        catch (Exception ex)
        {
          ExceptionBuilder.TraceExceptionForCapture(ex);
          throw ExceptionBuilder.SetFailed(value, this, this.DataType, ex);
        }
        if (this.autoIncrement && !DataStorage.IsObjectNull(value))
        {
          long num = (long) SqlConvert.ChangeType2(value, StorageType.Int64, typeof (long), this.FormatProvider);
          if (this.autoIncrementStep > 0L)
          {
            if (num >= this.autoIncrementCurrent)
              this.autoIncrementCurrent = num + this.autoIncrementStep;
          }
          else if (num <= this.autoIncrementCurrent)
            this.autoIncrementCurrent = num + this.autoIncrementStep;
        }
        if (!this.Computed)
          return;
        DataRow dataRow = this.GetDataRow(record);
        if (dataRow == null)
          return;
        dataRow.LastChangedColumn = this;
      }
    }

    internal void InitializeRecord(int record)
    {
      Debug.Assert(this._storage != null, "no storage");
      this._storage.Set(record, this.DefaultValue);
    }

    internal void SetValue(int record, object value)
    {
      try
      {
        Debug.Assert(value != null, "setting null, expecting dbnull");
        Debug.Assert(this.table != null, "storage with no DataTable on column");
        Debug.Assert(this._storage != null, "no storage");
        this._storage.Set(record, value);
      }
      catch (Exception ex)
      {
        ExceptionBuilder.TraceExceptionForCapture(ex);
        throw ExceptionBuilder.SetFailed(value, this, this.DataType, ex);
      }
      DataRow dataRow = this.GetDataRow(record);
      if (dataRow == null)
        return;
      dataRow.LastChangedColumn = this;
    }

    internal void FreeRecord(int record)
    {
      Debug.Assert(this._storage != null, "no storage");
      this._storage.Set(record, this._storage.NullValue);
    }

    public bool Unique
    {
      get => this.unique;
      set
      {
        if (this.unique == value)
          return;
        if (value && this.expression != null)
          throw ExceptionBuilder.UniqueAndExpression();
        UniqueConstraint uniqueConstraint1 = (UniqueConstraint) null;
        if (this.table != null)
        {
          if (value)
          {
            this.CheckUnique();
          }
          else
          {
            foreach (object constraint in (InternalDataCollectionBase) this.Table.Constraints)
            {
              if (constraint is UniqueConstraint uniqueConstraint6 && uniqueConstraint6.ColumnsReference.Length == 1 && uniqueConstraint6.ColumnsReference[0] == this)
                uniqueConstraint1 = uniqueConstraint6;
            }
            Debug.Assert(uniqueConstraint1 != null, "Should have found a column to remove from the collection.");
            this.table.Constraints.CanRemove((Constraint) uniqueConstraint1, true);
          }
        }
        this.unique = value;
        if (this.table == null)
          return;
        if (value)
        {
          UniqueConstraint uniqueConstraint2 = new UniqueConstraint(this);
          Debug.Assert(this.table.Constraints.FindKeyConstraint(this) == null, "Should not be a duplication constraint in collection");
          this.table.Constraints.Add((Constraint) uniqueConstraint2);
        }
        else
          this.table.Constraints.Remove((Constraint) uniqueConstraint1);
      }
    }

    internal void InternalUnique(bool value) => this.unique = value;

    internal string XmlDataType
    {
      get => this.dttype;
      set => this.dttype = value;
    }

    internal SimpleType SimpleType
    {
      get => this.simpleType;
      set
      {
        this.simpleType = value;
        if (value == null || !value.CanHaveMaxLength())
          return;
        this.maxLength = this.simpleType.MaxLength;
      }
    }

    public virtual MappingType ColumnMapping
    {
      get => this.columnMapping;
      set
      {
        if (value == this.columnMapping)
          return;
        if (value == MappingType.SimpleContent && this.table != null)
        {
          int num = 0;
          if (this.columnMapping == MappingType.Element)
            num = 1;
          if (this.dataType == typeof (char))
            throw ExceptionBuilder.CannotSetSimpleContent(this.ColumnName, this.dataType);
          if (this.table.XmlText != null && this.table.XmlText != this)
            throw ExceptionBuilder.CannotAddColumn3();
          if (this.table.ElementColumnCount > num)
            throw ExceptionBuilder.CannotAddColumn4(this.ColumnName);
        }
        this.RaisePropertyChanging(nameof (ColumnMapping));
        if (this.table != null)
        {
          if (this.columnMapping == MappingType.SimpleContent)
            this.table.xmlText = (DataColumn) null;
          if (value == MappingType.Element)
            ++this.table.ElementColumnCount;
          else if (this.columnMapping == MappingType.Element)
            --this.table.ElementColumnCount;
        }
        this.columnMapping = value;
        if (value != MappingType.SimpleContent)
          return;
        this._columnUri = (string) null;
        if (this.table != null)
          this.table.XmlText = this;
        this.SimpleType = (SimpleType) null;
      }
    }

    internal void CheckColumnConstraint(DataRow row, DataRowAction action)
    {
      if (!this.table.UpdatingCurrent(row, action))
        return;
      this.CheckNullable(row);
      this.CheckMaxLength(row);
    }

    internal bool CheckMaxLength()
    {
      if (0 <= this.maxLength && this.Table != null && 0 < this.Table.Rows.Count)
      {
        Debug.Assert(this.IsStringType, "not a String or SqlString column");
        foreach (DataRow row in (InternalDataCollectionBase) this.Table.Rows)
        {
          if (row.HasVersion(DataRowVersion.Current) && this.maxLength < this.GetStringLength(row.GetCurrentRecordNo()))
            return false;
        }
      }
      return true;
    }

    internal void CheckMaxLength(DataRow dr)
    {
      if (0 > this.maxLength)
        return;
      Debug.Assert(this.IsStringType, "not a String or SqlString column");
      if (this.maxLength < this.GetStringLength(dr.GetDefaultRecord()))
        throw ExceptionBuilder.LongerThanMaxLength(this);
    }

    protected internal void CheckNotAllowNull()
    {
      if (this._storage == null)
        return;
      if (this.sortIndex != null)
      {
        if (this.sortIndex.IsKeyInIndex(this._storage.NullValue))
          throw ExceptionBuilder.NullKeyValues(this.ColumnName);
      }
      else
      {
        foreach (DataRow row in (InternalDataCollectionBase) this.table.Rows)
        {
          if (row.RowState != DataRowState.Deleted)
          {
            if (!this.implementsINullable)
            {
              if (row[this] == DBNull.Value)
                throw ExceptionBuilder.NullKeyValues(this.ColumnName);
            }
            else if (DataStorage.IsObjectNull(row[this]))
              throw ExceptionBuilder.NullKeyValues(this.ColumnName);
          }
        }
      }
    }

    internal void CheckNullable(DataRow row)
    {
      if (this.AllowDBNull)
        return;
      Debug.Assert(this._storage != null, "no storage");
      if (this._storage.IsNull(row.GetDefaultRecord()))
        throw ExceptionBuilder.NullValues(this.ColumnName);
    }

    protected void CheckUnique()
    {
      if (!this.SortIndex.CheckUnique())
        throw ExceptionBuilder.NonUniqueValues(this.ColumnName);
    }

    internal int Compare(int record1, int record2)
    {
      Debug.Assert(this._storage != null, "null storage");
      return this._storage.Compare(record1, record2);
    }

    internal bool CompareValueTo(int record1, object value, bool checkType)
    {
      if (this.CompareValueTo(record1, value) == 0)
      {
        Type type1 = value.GetType();
        Type type2 = this._storage.Get(record1).GetType();
        if (type1 == typeof (string) && type2 == typeof (string))
          return string.CompareOrdinal((string) this._storage.Get(record1), (string) value) == 0;
        if (type1 == type2)
          return true;
      }
      return false;
    }

    internal int CompareValueTo(int record1, object value)
    {
      Debug.Assert(this._storage != null, "null storage");
      return this._storage.CompareValueTo(record1, value);
    }

    internal object ConvertValue(object value)
    {
      Debug.Assert(this._storage != null, "null storage");
      return this._storage.ConvertValue(value);
    }

    internal void Copy(int srcRecordNo, int dstRecordNo)
    {
      Debug.Assert(this._storage != null, "null storage");
      this._storage.Copy(srcRecordNo, dstRecordNo);
    }

    internal DataColumn Clone()
    {
      DataColumn instance = (DataColumn) Activator.CreateInstance(this.GetType());
      instance.SimpleType = this.SimpleType;
      instance.allowNull = this.allowNull;
      instance.autoIncrement = this.autoIncrement;
      instance.autoIncrementStep = this.autoIncrementStep;
      instance.autoIncrementSeed = this.autoIncrementSeed;
      instance.autoIncrementCurrent = this.autoIncrementCurrent;
      instance.caption = this.caption;
      instance.ColumnName = this.ColumnName;
      instance._columnUri = this._columnUri;
      instance._columnPrefix = this._columnPrefix;
      instance.DataType = this.DataType;
      instance.defaultValue = this.defaultValue;
      instance.defaultValueIsNull = this.defaultValue == DBNull.Value || instance.ImplementsINullable && DataStorage.IsObjectSqlNull(this.defaultValue);
      instance.columnMapping = this.columnMapping;
      instance.readOnly = this.readOnly;
      instance.MaxLength = this.MaxLength;
      instance.dttype = this.dttype;
      instance._dateTimeMode = this._dateTimeMode;
      if (this.extendedProperties != null)
      {
        foreach (object key in (IEnumerable) this.extendedProperties.Keys)
          instance.ExtendedProperties[key] = this.extendedProperties[key];
      }
      return instance;
    }

    internal object GetAggregateValue(int[] records, AggregateType kind)
    {
      if (this._storage != null)
        return this._storage.Aggregate(records, kind);
      return kind == AggregateType.Count ? (object) 0 : (object) DBNull.Value;
    }

    private int GetStringLength(int record)
    {
      Debug.Assert(this._storage != null, "no storage");
      return this._storage.GetStringLength(record);
    }

    internal void Init(int record)
    {
      if (this.AutoIncrement)
      {
        object incrementCurrent = (object) this.autoIncrementCurrent;
        this.autoIncrementCurrent += this.autoIncrementStep;
        Debug.Assert(this._storage != null, "no storage");
        this._storage.Set(record, incrementCurrent);
      }
      else
        this[record] = this.defaultValue;
    }

    internal static bool IsAutoIncrementType(Type dataType) => dataType == typeof (int) || dataType == typeof (long) || dataType == typeof (short) || dataType == typeof (Decimal);

    private bool IsColumnMappingValid(StorageType typeCode, MappingType mapping) => mapping == MappingType.Element || !DataStorage.IsTypeCustomType(typeCode);

    internal bool IsCustomType => this._storage != null ? this._storage.IsCustomDefinedType : DataStorage.IsTypeCustomType(this.DataType);

    internal bool IsValueCustomTypeInstance(object value) => DataStorage.IsTypeCustomType(value.GetType()) && !(value is Type);

    internal bool ImplementsIXMLSerializable => this.implementsIXMLSerializable;

    internal bool IsNull(int record)
    {
      Debug.Assert(this._storage != null, "no storage");
      return this._storage.IsNull(record);
    }

    internal bool IsInRelation()
    {
      DataRelationCollection parentRelations = this.table.ParentRelations;
      Debug.Assert(parentRelations != null, "Invalid ParentRelations");
      for (int index = 0; index < parentRelations.Count; ++index)
      {
        DataKey childKey = parentRelations[index].ChildKey;
        Debug.Assert(childKey.HasValue, "Invalid child key (null)");
        if (childKey.ContainsColumn(this))
          return true;
      }
      DataRelationCollection childRelations = this.table.ChildRelations;
      Debug.Assert(childRelations != null, "Invalid ChildRelations");
      for (int index = 0; index < childRelations.Count; ++index)
      {
        DataKey parentKey = childRelations[index].ParentKey;
        Debug.Assert(parentKey.HasValue, "Invalid parent key (null)");
        if (parentKey.ContainsColumn(this))
          return true;
      }
      return false;
    }

    internal bool IsMaxLengthViolated()
    {
      if (this.MaxLength < 0)
        return true;
      bool flag = false;
      string error = (string) null;
      foreach (DataRow row in (InternalDataCollectionBase) this.Table.Rows)
      {
        if (row.HasVersion(DataRowVersion.Current))
        {
          object obj = row[this];
          if (obj != null && obj != DBNull.Value && ((string) obj).Length > this.MaxLength)
          {
            if (error == null)
              error = ExceptionBuilder.MaxLengthViolationText(this.ColumnName);
            row.RowError = error;
            row.SetColumnError(this, error);
            flag = true;
          }
        }
      }
      return flag;
    }

    internal bool IsNotAllowDBNullViolated()
    {
      Index sortIndex = this.SortIndex;
      DataRow[] rows = sortIndex.GetRows(sortIndex.FindRecords((object) DBNull.Value));
      for (int index = 0; index < rows.Length; ++index)
      {
        string error = ExceptionBuilder.NotAllowDBNullViolationText(this.ColumnName);
        rows[index].RowError = error;
        rows[index].SetColumnError(this, error);
      }
      return (uint) rows.Length > 0U;
    }

    internal void FinishInitInProgress()
    {
      if (!this.Computed)
        return;
      this.BindExpression();
    }

    protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
    {
      if (this.onPropertyChangingDelegate == null)
        return;
      this.onPropertyChangingDelegate((object) this, pcevent);
    }

    protected internal void RaisePropertyChanging(string name) => this.OnPropertyChanging(new PropertyChangedEventArgs(name));

    private void InsureStorage()
    {
      if (this._storage != null)
        return;
      this._storage = DataStorage.CreateStorage(this, this.dataType);
    }

    internal void SetCapacity(int capacity)
    {
      this.InsureStorage();
      this._storage.SetCapacity(capacity);
    }

    internal void OnSetDataSet()
    {
    }

    public override string ToString() => this.expression == null ? this.ColumnName : this.ColumnName + " + " + this.Expression;

    internal void AddDependentColumn(DataColumn expressionColumn)
    {
      if (this.dependentColumns == null)
        this.dependentColumns = new List<DataColumn>();
      Debug.Assert(!this.dependentColumns.Contains(expressionColumn), "duplicate column - expected to be unique");
      this.dependentColumns.Add(expressionColumn);
      this.table.AddDependentColumn(expressionColumn);
    }

    internal void RemoveDependentColumn(DataColumn expressionColumn)
    {
      if (this.dependentColumns != null && this.dependentColumns.Contains(expressionColumn))
        this.dependentColumns.Remove(expressionColumn);
      this.table.RemoveDependentColumn(expressionColumn);
    }

    internal void HandleDependentColumnList(
      DataExpression oldExpression,
      DataExpression newExpression)
    {
      if (oldExpression != null)
      {
        foreach (DataColumn dataColumn in oldExpression.GetDependency())
        {
          Debug.Assert(dataColumn != null, "null datacolumn in expression dependencies");
          dataColumn.RemoveDependentColumn(this);
          if (dataColumn.table != this.table)
            this.table.RemoveDependentColumn(this);
        }
        this.table.RemoveDependentColumn(this);
      }
      if (newExpression == null)
        return;
      foreach (DataColumn dataColumn in newExpression.GetDependency())
      {
        dataColumn.AddDependentColumn(this);
        if (dataColumn.table != this.table)
          this.table.AddDependentColumn(this);
      }
      this.table.AddDependentColumn(this);
    }
  }
}
