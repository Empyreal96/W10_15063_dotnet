// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataTable
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
using System.Text;
using System.Threading;

namespace Microsoft.Phone.Data
{
  public class DataTable : MarshalByValueComponent
  {
    private DataSet dataSet;
    private DataView defaultView;
    internal int nextRowID;
    internal readonly DataRowCollection rowCollection;
    internal readonly DataColumnCollection columnCollection;
    private readonly ConstraintCollection constraintCollection;
    private int elementColumnCount;
    internal DataRelationCollection parentRelationsCollection;
    internal DataRelationCollection childRelationsCollection;
    internal readonly RecordManager recordManager;
    internal readonly List<Index> indexes;
    private List<Index> shadowIndexes;
    private int shadowCount;
    internal PropertyCollection extendedProperties;
    private string tableName = "";
    internal string tableNamespace;
    private string tablePrefix = "";
    internal DataExpression displayExpression;
    internal bool fNestedInDataset = true;
    private CultureInfo _culture;
    private bool _cultureUserSet;
    private CompareInfo _compareInfo;
    private CompareOptions _compareFlags = CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth;
    private IFormatProvider _formatProvider;
    private StringComparer _hashCodeProvider;
    private bool _caseSensitive;
    private bool _caseSensitiveUserSet;
    internal string encodedTableName;
    internal DataColumn xmlText;
    internal bool textOnly;
    internal Decimal minOccurs = 1M;
    internal Decimal maxOccurs = 1M;
    internal bool repeatableElement;
    private object typeName;
    private static readonly int[] zeroIntegers = new int[0];
    internal static readonly DataColumn[] zeroColumns = new DataColumn[0];
    internal static readonly DataRow[] zeroRows = new DataRow[0];
    internal UniqueConstraint primaryKey;
    internal static readonly IndexField[] zeroIndexField = new IndexField[0];
    internal IndexField[] _primaryIndex = DataTable.zeroIndexField;
    private DataColumn[] delayedSetPrimaryKey;
    private Index loadIndex;
    private Index loadIndexwithOriginalAdded;
    private Index loadIndexwithCurrentDeleted;
    private int _suspendIndexEvents;
    private bool savedEnforceConstraints;
    private bool inDataLoad;
    private bool initialLoad;
    private bool schemaLoading;
    private bool enforceConstraints = true;
    internal bool _suspendEnforceConstraints;
    protected internal bool fInitInProgress;
    private bool inLoad;
    internal bool fInLoadDiffgram;
    private byte _isTypedDataTable;
    private DataRow[] EmptyDataRowArray;
    private static readonly DataRelation[] EmptyArrayDataRelation = new DataRelation[0];
    private DataRelation[] _nestedParentRelations = DataTable.EmptyArrayDataRelation;
    internal List<DataColumn> dependentColumns;
    private bool mergingData;
    private DataRowChangeEventHandler onRowChangedDelegate;
    private DataRowChangeEventHandler onRowChangingDelegate;
    private DataRowChangeEventHandler onRowDeletingDelegate;
    private DataRowChangeEventHandler onRowDeletedDelegate;
    private DataColumnChangeEventHandler onColumnChangedDelegate;
    private DataColumnChangeEventHandler onColumnChangingDelegate;
    private DataTableClearEventHandler onTableClearingDelegate;
    private DataTableClearEventHandler onTableClearedDelegate;
    private DataTableNewRowEventHandler onTableNewRowDelegate;
    private EventHandler onInitialized;
    private readonly DataRowBuilder rowBuilder;
    private const string KEY_XMLSCHEMA = "XmlSchema";
    private const string KEY_XMLDIFFGRAM = "XmlDiffGram";
    private const string KEY_NAME = "TableName";
    internal readonly List<DataView> delayedViews = new List<DataView>();
    private readonly List<DataViewListener> _dataViewListeners = new List<DataViewListener>();
    internal Microsoft.Phone.Data.Workaround.Hashtable rowDiffId;
    internal int ukColumnPositionForInference = -1;

    public DataTable()
    {
      GC.SuppressFinalize((object) this);
      this.nextRowID = 1;
      this.recordManager = new RecordManager(this);
      this._culture = CultureInfo.CurrentCulture;
      this.columnCollection = new DataColumnCollection(this);
      this.constraintCollection = new ConstraintCollection(this);
      this.rowCollection = new DataRowCollection(this);
      this.indexes = new List<Index>();
      this.rowBuilder = new DataRowBuilder(this, -1);
    }

    public DataTable(string tableName)
      : this()
    {
      this.tableName = tableName == null ? "" : tableName;
    }

    public DataTable(string tableName, string tableNamespace)
      : this(tableName)
    {
      this.Namespace = tableNamespace;
    }

    public bool CaseSensitive
    {
      get => this._caseSensitive;
      set
      {
        if (this._caseSensitive != value)
        {
          bool caseSensitive = this._caseSensitive;
          bool sensitiveUserSet = this._caseSensitiveUserSet;
          this._caseSensitive = value;
          this._caseSensitiveUserSet = true;
          if (this.DataSet != null && !this.DataSet.ValidateCaseConstraint())
          {
            this._caseSensitive = caseSensitive;
            this._caseSensitiveUserSet = sensitiveUserSet;
            throw ExceptionBuilder.CannotChangeCaseLocale();
          }
          this.SetCaseSensitiveValue(value, true, true);
        }
        this._caseSensitiveUserSet = true;
      }
    }

    internal bool AreIndexEventsSuspended => 0 < this._suspendIndexEvents;

    internal void RestoreIndexEvents(bool forceReset)
    {
      if (0 >= this._suspendIndexEvents)
        return;
      --this._suspendIndexEvents;
      if (this._suspendIndexEvents != 0)
        return;
      Exception exception = (Exception) null;
      this.SetShadowIndexes();
      try
      {
        int count = this.shadowIndexes.Count;
        for (int index = 0; index < count; ++index)
        {
          Index shadowIndex = this.shadowIndexes[index];
          try
          {
            if (forceReset || shadowIndex.HasRemoteAggregate)
              shadowIndex.Reset();
            else
              shadowIndex.FireResetEvent();
          }
          catch (Exception ex)
          {
            if (!ADP.IsCatchableExceptionType(ex))
            {
              throw;
            }
            else
            {
              ExceptionBuilder.TraceExceptionWithoutRethrow(ex);
              if (exception == null)
                exception = ex;
            }
          }
        }
        if (exception != null)
          throw exception;
      }
      finally
      {
        this.RestoreShadowIndexes();
      }
    }

    internal void SuspendIndexEvents() => ++this._suspendIndexEvents;

    public bool IsInitialized => !this.fInitInProgress;

    private bool IsTypedDataTable
    {
      get
      {
        switch (this._isTypedDataTable)
        {
          case 0:
            this._isTypedDataTable = this.GetType() != typeof (DataTable) ? (byte) 1 : (byte) 2;
            return (byte) 1 == this._isTypedDataTable;
          case 1:
            return true;
          default:
            return false;
        }
      }
    }

    internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes)
    {
      if (!userSet && (this._caseSensitiveUserSet || this._caseSensitive == isCaseSensitive))
        return false;
      this._caseSensitive = isCaseSensitive;
      this._compareFlags = !isCaseSensitive ? CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth : CompareOptions.None;
      if (resetIndexes)
      {
        this.ResetIndexes();
        foreach (Constraint constraint in (InternalDataCollectionBase) this.Constraints)
          constraint.CheckConstraint();
      }
      return true;
    }

    private void ResetCaseSensitive()
    {
      this.SetCaseSensitiveValue(this.dataSet != null && this.dataSet.CaseSensitive, true, true);
      this._caseSensitiveUserSet = false;
    }

    internal bool ShouldSerializeCaseSensitive() => this._caseSensitiveUserSet;

    internal bool SelfNested
    {
      get
      {
        foreach (DataRelation parentRelation in (InternalDataCollectionBase) this.ParentRelations)
        {
          if (parentRelation.Nested && parentRelation.ParentTable == this)
            return true;
        }
        return false;
      }
    }

    internal List<Index> LiveIndexes
    {
      get
      {
        if (!this.AreIndexEventsSuspended)
        {
          for (int index1 = this.indexes.Count - 1; 0 <= index1; --index1)
          {
            Index index2 = this.indexes[index1];
            if (index2.RefCount <= 1)
              index2.RemoveRef();
          }
        }
        return this.indexes;
      }
    }

    internal int UKColumnPositionForInference
    {
      get => this.ukColumnPositionForInference;
      set => this.ukColumnPositionForInference = value;
    }

    public DataRelationCollection ChildRelations
    {
      get
      {
        if (this.childRelationsCollection == null)
          this.childRelationsCollection = (DataRelationCollection) new DataRelationCollection.DataTableRelationCollection(this, false);
        return this.childRelationsCollection;
      }
    }

    public DataColumnCollection Columns => this.columnCollection;

    private CompareInfo CompareInfo
    {
      get
      {
        if (this._compareInfo == null)
          this._compareInfo = this.Locale.CompareInfo;
        return this._compareInfo;
      }
    }

    public ConstraintCollection Constraints => this.constraintCollection;

    private void ResetConstraints() => this.Constraints.Clear();

    public DataSet DataSet => this.dataSet;

    internal void SetDataSet(DataSet dataSet)
    {
      if (this.dataSet == dataSet)
        return;
      this.dataSet = dataSet;
      DataColumnCollection columns = this.Columns;
      for (int index = 0; index < columns.Count; ++index)
        columns[index].OnSetDataSet();
      if (this.DataSet == null)
        return;
      this.defaultView = (DataView) null;
    }

    public DataView DefaultView
    {
      get
      {
        DataView dataView1 = this.defaultView;
        if (dataView1 == null)
        {
          DataView dataView2;
          if (this.dataSet != null)
          {
            dataView2 = this.dataSet.DefaultViewManager.CreateDataView(this);
          }
          else
          {
            dataView2 = new DataView(this, true);
            dataView2.SetIndex2("", DataViewRowState.CurrentRows, (IFilter) null, true);
          }
          dataView1 = Interlocked.CompareExchange<DataView>(ref this.defaultView, dataView2, (DataView) null) ?? this.defaultView;
        }
        return dataView1;
      }
    }

    public string DisplayExpression
    {
      get => this.DisplayExpressionInternal;
      set
      {
        if (value != null && value.Length > 0)
          this.displayExpression = new DataExpression(this, value);
        else
          this.displayExpression = (DataExpression) null;
      }
    }

    internal string DisplayExpressionInternal => this.displayExpression == null ? "" : this.displayExpression.Expression;

    internal bool EnforceConstraints
    {
      get
      {
        if (this.SuspendEnforceConstraints)
          return false;
        return this.dataSet != null ? this.dataSet.EnforceConstraints : this.enforceConstraints;
      }
      set
      {
        if (this.dataSet != null || this.enforceConstraints == value)
          return;
        if (value)
          this.EnableConstraints();
        this.enforceConstraints = value;
      }
    }

    internal bool SuspendEnforceConstraints
    {
      get => this._suspendEnforceConstraints;
      set => this._suspendEnforceConstraints = value;
    }

    internal void EnableConstraints()
    {
      bool flag = false;
      foreach (Constraint constraint in (InternalDataCollectionBase) this.Constraints)
      {
        if (constraint is UniqueConstraint)
          flag |= constraint.IsConstraintViolated();
      }
      foreach (DataColumn column in (InternalDataCollectionBase) this.Columns)
      {
        if (!column.AllowDBNull)
          flag |= column.IsNotAllowDBNullViolated();
        if (column.MaxLength >= 0)
          flag |= column.IsMaxLengthViolated();
      }
      if (flag)
      {
        this.EnforceConstraints = false;
        throw ExceptionBuilder.EnforceConstraint();
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

    internal IFormatProvider FormatProvider
    {
      get
      {
        if (this._formatProvider == null)
        {
          CultureInfo cultureInfo = this.Locale;
          if (cultureInfo.IsNeutralCulture)
            cultureInfo = CultureInfo.InvariantCulture;
          this._formatProvider = (IFormatProvider) cultureInfo;
        }
        return this._formatProvider;
      }
    }

    public bool HasErrors
    {
      get
      {
        for (int index = 0; index < this.Rows.Count; ++index)
        {
          if (this.Rows[index].HasErrors)
            return true;
        }
        return false;
      }
    }

    public CultureInfo Locale
    {
      get
      {
        Debug.Assert(this._culture != null, "null culture");
        Debug.Assert(this._cultureUserSet || this.dataSet == null || this._culture.Equals((object) this.dataSet.Locale), "Locale mismatch");
        return this._culture;
      }
      set
      {
        bool flag1 = true;
        if (value == null)
        {
          flag1 = false;
          value = this.dataSet != null ? this.dataSet.Locale : this._culture;
        }
        if (this._culture != value && !this._culture.Equals((object) value))
        {
          bool flag2 = false;
          bool flag3 = false;
          CultureInfo culture = this._culture;
          bool cultureUserSet = this._cultureUserSet;
          try
          {
            this._cultureUserSet = true;
            this.SetLocaleValue(value, true, false);
            if (this.DataSet != null)
            {
              if (!this.DataSet.ValidateLocaleConstraint())
                goto label_16;
            }
            flag2 = false;
            this.SetLocaleValue(value, true, true);
            flag2 = true;
          }
          catch
          {
            flag3 = true;
            throw;
          }
          finally
          {
            if (!flag2)
            {
              try
              {
                this.SetLocaleValue(culture, true, true);
              }
              catch (Exception ex)
              {
                if (!ADP.IsCatchableExceptionType(ex))
                  throw;
                else
                  ADP.TraceExceptionWithoutRethrow(ex);
              }
              this._cultureUserSet = cultureUserSet;
              if (!flag3)
                throw ExceptionBuilder.CannotChangeCaseLocale((Exception) null);
            }
          }
label_16:
          this.SetLocaleValue(value, true, true);
        }
        this._cultureUserSet = flag1;
      }
    }

    internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes)
    {
      Debug.Assert(culture != null, "SetLocaleValue: no locale");
      if (!(userSet | resetIndexes) && (this._cultureUserSet || this._culture.Equals((object) culture)))
        return false;
      this._culture = culture;
      this._compareInfo = (CompareInfo) null;
      this._formatProvider = (IFormatProvider) null;
      this._hashCodeProvider = (StringComparer) null;
      foreach (DataColumn column in (InternalDataCollectionBase) this.Columns)
        column._hashCode = this.GetSpecialHashCode(column.ColumnName);
      if (resetIndexes)
      {
        this.ResetIndexes();
        foreach (Constraint constraint in (InternalDataCollectionBase) this.Constraints)
          constraint.CheckConstraint();
      }
      return true;
    }

    internal bool ShouldSerializeLocale() => this._cultureUserSet;

    public int MinimumCapacity
    {
      get => this.recordManager.MinimumCapacity;
      set
      {
        if (value == this.recordManager.MinimumCapacity)
          return;
        this.recordManager.MinimumCapacity = value;
      }
    }

    internal int RecordCapacity => this.recordManager.RecordCapacity;

    internal int ElementColumnCount
    {
      get => this.elementColumnCount;
      set => this.elementColumnCount = value <= 0 || this.xmlText == null ? value : throw ExceptionBuilder.TableCannotAddToSimpleContent();
    }

    public DataRelationCollection ParentRelations
    {
      get
      {
        if (this.parentRelationsCollection == null)
          this.parentRelationsCollection = (DataRelationCollection) new DataRelationCollection.DataTableRelationCollection(this, true);
        return this.parentRelationsCollection;
      }
    }

    internal bool MergingData
    {
      get => this.mergingData;
      set => this.mergingData = value;
    }

    internal DataRelation[] NestedParentRelations
    {
      get
      {
        DataRelation[] nestedParentRelations = this.FindNestedParentRelations();
        Debug.Assert(nestedParentRelations.Length == this._nestedParentRelations.Length, "nestedParent cache is broken");
        for (int index = 0; index < nestedParentRelations.Length; ++index)
        {
          Debug.Assert(nestedParentRelations[index] != null, "null relation");
          Debug.Assert(this._nestedParentRelations[index] != null, "null relation");
          Debug.Assert(nestedParentRelations[index] == this._nestedParentRelations[index], "unequal relations");
        }
        return this._nestedParentRelations;
      }
    }

    internal bool SchemaLoading => this.schemaLoading;

    internal void CacheNestedParent() => this._nestedParentRelations = this.FindNestedParentRelations();

    private DataRelation[] FindNestedParentRelations()
    {
      List<DataRelation> dataRelationList = (List<DataRelation>) null;
      foreach (DataRelation parentRelation in (InternalDataCollectionBase) this.ParentRelations)
      {
        if (parentRelation.Nested)
        {
          if (dataRelationList == null)
            dataRelationList = new List<DataRelation>();
          dataRelationList.Add(parentRelation);
        }
      }
      return dataRelationList == null || dataRelationList.Count == 0 ? DataTable.EmptyArrayDataRelation : dataRelationList.ToArray();
    }

    internal int NestedParentsCount
    {
      get
      {
        int num = 0;
        foreach (DataRelation parentRelation in (InternalDataCollectionBase) this.ParentRelations)
        {
          if (parentRelation.Nested)
            ++num;
        }
        return num;
      }
    }

    public DataColumn[] PrimaryKey
    {
      get
      {
        UniqueConstraint primaryKey = this.primaryKey;
        if (primaryKey == null)
          return DataTable.zeroColumns;
        Debug.Assert(2 <= this.primaryKey.ConstraintIndex.RefCount, "bad primaryKey index RefCount");
        return primaryKey.Key.ToArray();
      }
      set
      {
        UniqueConstraint uniqueConstraint = (UniqueConstraint) null;
        if (this.fInitInProgress && value != null)
        {
          this.delayedSetPrimaryKey = value;
        }
        else
        {
          if (value != null && value.Length != 0)
          {
            int length = 0;
            for (int index = 0; index < value.Length && value[index] != null; ++index)
              ++length;
            if (length != 0)
            {
              DataColumn[] columns = value;
              if (length != value.Length)
              {
                columns = new DataColumn[length];
                for (int index = 0; index < length; ++index)
                  columns[index] = value[index];
              }
              uniqueConstraint = new UniqueConstraint(columns);
              if (uniqueConstraint.Table != this)
                throw ExceptionBuilder.TableForeignPrimaryKey();
            }
          }
          if (uniqueConstraint == this.primaryKey || uniqueConstraint != null && uniqueConstraint.Equals((object) this.primaryKey))
            return;
          UniqueConstraint constraint;
          if ((constraint = (UniqueConstraint) this.Constraints.FindConstraint((Constraint) uniqueConstraint)) != null)
          {
            uniqueConstraint.ColumnsReference.CopyTo((Array) constraint.Key.ColumnsReference, 0);
            uniqueConstraint = constraint;
          }
          UniqueConstraint primaryKey = this.primaryKey;
          this.primaryKey = (UniqueConstraint) null;
          if (primaryKey != null)
          {
            primaryKey.ConstraintIndex.RemoveRef();
            if (this.loadIndex != null)
            {
              this.loadIndex.RemoveRef();
              this.loadIndex = (Index) null;
            }
            if (this.loadIndexwithOriginalAdded != null)
            {
              this.loadIndexwithOriginalAdded.RemoveRef();
              this.loadIndexwithOriginalAdded = (Index) null;
            }
            if (this.loadIndexwithCurrentDeleted != null)
            {
              this.loadIndexwithCurrentDeleted.RemoveRef();
              this.loadIndexwithCurrentDeleted = (Index) null;
            }
            this.Constraints.Remove((Constraint) primaryKey);
          }
          if (uniqueConstraint != null && constraint == null)
            this.Constraints.Add((Constraint) uniqueConstraint);
          this.primaryKey = uniqueConstraint;
          Debug.Assert(this.Constraints.FindConstraint((Constraint) this.primaryKey) == this.primaryKey, "PrimaryKey is not in ConstraintCollection");
          this._primaryIndex = uniqueConstraint != null ? uniqueConstraint.Key.GetIndexDesc() : DataTable.zeroIndexField;
          if (this.primaryKey == null)
            return;
          uniqueConstraint.ConstraintIndex.AddRef();
          for (int index = 0; index < uniqueConstraint.ColumnsReference.Length; ++index)
            uniqueConstraint.ColumnsReference[index].AllowDBNull = false;
        }
      }
    }

    public DataRowCollection Rows => this.rowCollection;

    public string TableName
    {
      get => this.tableName;
      set
      {
        if (value == null)
          value = "";
        CultureInfo locale = this.Locale;
        if (string.Compare(this.tableName, value, locale, CompareOptions.IgnoreCase) != 0)
        {
          if (this.dataSet != null)
          {
            if (value.Length == 0)
              throw ExceptionBuilder.NoTableName();
            if (string.Compare(value, this.dataSet.DataSetName, this.dataSet.Locale, CompareOptions.IgnoreCase) == 0 && !this.fNestedInDataset)
              throw ExceptionBuilder.DatasetConflictingName(this.dataSet.DataSetName);
            DataRelation[] nestedParentRelations = this.NestedParentRelations;
            if (nestedParentRelations.Length == 0)
            {
              this.dataSet.Tables.RegisterName(value, this.Namespace);
            }
            else
            {
              foreach (DataRelation dataRelation in nestedParentRelations)
              {
                if (!dataRelation.ParentTable.Columns.CanRegisterName(value))
                  throw ExceptionBuilder.CannotAddDuplicate2(value);
              }
              this.dataSet.Tables.RegisterName(value, this.Namespace);
              foreach (DataRelation dataRelation in nestedParentRelations)
              {
                dataRelation.ParentTable.Columns.RegisterColumnName(value, (DataColumn) null, this);
                dataRelation.ParentTable.Columns.UnregisterName(this.TableName);
              }
            }
            if (this.tableName.Length != 0)
              this.dataSet.Tables.UnregisterName(this.tableName);
          }
          this.RaisePropertyChanging(nameof (TableName));
          this.tableName = value;
          this.encodedTableName = (string) null;
        }
        else
        {
          if (string.Compare(this.tableName, value, locale, CompareOptions.None) == 0)
            return;
          this.RaisePropertyChanging(nameof (TableName));
          this.tableName = value;
          this.encodedTableName = (string) null;
        }
      }
    }

    private string GetInheritedNamespace(List<DataTable> visitedTables)
    {
      DataRelation[] nestedParentRelations = this.NestedParentRelations;
      if (nestedParentRelations.Length != 0)
      {
        for (int index = 0; index < nestedParentRelations.Length; ++index)
        {
          DataRelation dataRelation = nestedParentRelations[index];
          if (dataRelation.ParentTable.tableNamespace != null)
            return dataRelation.ParentTable.tableNamespace;
        }
        int index1 = 0;
        while (index1 < nestedParentRelations.Length && (nestedParentRelations[index1].ParentTable == this || visitedTables.Contains(nestedParentRelations[index1].ParentTable)))
          ++index1;
        if (index1 < nestedParentRelations.Length)
        {
          DataTable parentTable = nestedParentRelations[index1].ParentTable;
          if (!visitedTables.Contains(parentTable))
            visitedTables.Add(parentTable);
          return parentTable.GetInheritedNamespace(visitedTables);
        }
      }
      return this.DataSet != null ? this.DataSet.Namespace : string.Empty;
    }

    public string Namespace
    {
      get => this.tableNamespace == null ? this.GetInheritedNamespace(new List<DataTable>()) : this.tableNamespace;
      set
      {
        if (value != this.tableNamespace)
        {
          if (this.dataSet != null)
          {
            string str = value == null ? this.GetInheritedNamespace(new List<DataTable>()) : value;
            if (str != this.Namespace)
            {
              if (this.dataSet.Tables.Contains(this.TableName, str, true, true))
                throw ExceptionBuilder.DuplicateTableName2(this.TableName, str);
              this.CheckCascadingNamespaceConflict(str);
            }
          }
          this.CheckNamespaceValidityForNestedRelations(value);
          this.DoRaiseNamespaceChange();
        }
        this.tableNamespace = value;
      }
    }

    internal bool IsNamespaceInherited() => this.tableNamespace == null;

    internal void CheckCascadingNamespaceConflict(string realNamespace)
    {
      foreach (DataRelation childRelation in (InternalDataCollectionBase) this.ChildRelations)
      {
        if (childRelation.Nested && childRelation.ChildTable != this && childRelation.ChildTable.tableNamespace == null)
        {
          DataTable childTable = childRelation.ChildTable;
          if (this.dataSet.Tables.Contains(childTable.TableName, realNamespace, false, true))
            throw ExceptionBuilder.DuplicateTableName2(this.TableName, realNamespace);
          childTable.CheckCascadingNamespaceConflict(realNamespace);
        }
      }
    }

    internal void CheckNamespaceValidityForNestedRelations(string realNamespace)
    {
      foreach (DataRelation childRelation in (InternalDataCollectionBase) this.ChildRelations)
      {
        if (childRelation.Nested)
        {
          if (realNamespace != null)
            childRelation.ChildTable.CheckNamespaceValidityForNestedParentRelations(realNamespace, this);
          else
            childRelation.ChildTable.CheckNamespaceValidityForNestedParentRelations(this.GetInheritedNamespace(new List<DataTable>()), this);
        }
      }
      if (realNamespace != null)
        return;
      this.CheckNamespaceValidityForNestedParentRelations(this.GetInheritedNamespace(new List<DataTable>()), this);
    }

    internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable)
    {
      foreach (DataRelation parentRelation in (InternalDataCollectionBase) this.ParentRelations)
      {
        if (parentRelation.Nested && parentRelation.ParentTable != parentTable && parentRelation.ParentTable.Namespace != ns)
          throw ExceptionBuilder.InValidNestedRelation(this.TableName);
      }
    }

    internal void DoRaiseNamespaceChange()
    {
      this.RaisePropertyChanging("Namespace");
      foreach (DataColumn column in (InternalDataCollectionBase) this.Columns)
      {
        if (column._columnUri == null)
          column.RaisePropertyChanging("Namespace");
      }
      foreach (DataRelation childRelation in (InternalDataCollectionBase) this.ChildRelations)
      {
        if (childRelation.Nested && childRelation.ChildTable != this)
        {
          DataTable childTable = childRelation.ChildTable;
          childRelation.ChildTable.DoRaiseNamespaceChange();
        }
      }
    }

    public virtual void BeginInit() => this.fInitInProgress = true;

    public virtual void EndInit()
    {
      if (this.dataSet == null || !this.dataSet.fInitInProgress)
      {
        this.Columns.FinishInitCollection();
        this.Constraints.FinishInitConstraints();
        foreach (DataColumn column in (InternalDataCollectionBase) this.Columns)
        {
          if (column.Computed)
          {
            DataColumn dataColumn = column;
            dataColumn.Expression = dataColumn.Expression;
          }
        }
      }
      this.fInitInProgress = false;
      if (this.delayedSetPrimaryKey != null)
      {
        this.PrimaryKey = this.delayedSetPrimaryKey;
        this.delayedSetPrimaryKey = (DataColumn[]) null;
      }
      if (this.delayedViews.Count > 0)
      {
        foreach (DataView delayedView in this.delayedViews)
          delayedView.EndInit();
        this.delayedViews.Clear();
      }
      this.OnInitialized();
    }

    internal DataColumn XmlText
    {
      get => this.xmlText;
      set
      {
        if (this.xmlText == value)
          return;
        if (this.xmlText != null)
        {
          if (value != null)
            throw ExceptionBuilder.MultipleTextOnlyColumns();
          this.Columns.Remove(this.xmlText);
        }
        else
        {
          Debug.Assert(value != null, "Value shoud not be null ??");
          Debug.Assert(value.ColumnMapping == MappingType.SimpleContent, "should be text node here");
          if (value != this.Columns[value.ColumnName])
            this.Columns.Add(value);
        }
        this.xmlText = value;
      }
    }

    internal Decimal MaxOccurs
    {
      get => this.maxOccurs;
      set => this.maxOccurs = value;
    }

    internal Decimal MinOccurs
    {
      get => this.minOccurs;
      set => this.minOccurs = value;
    }

    internal void SetKeyValues(DataKey key, object[] keyValues, int record)
    {
      for (int index = 0; index < keyValues.Length; ++index)
        key.ColumnsReference[index][record] = keyValues[index];
    }

    internal DataRow FindByIndex(Index ndx, object[] key)
    {
      Range records = ndx.FindRecords(key);
      return records.IsNull ? (DataRow) null : this.recordManager[ndx.GetRecord(records.Min)];
    }

    internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx)
    {
      DataRow dataRow = (DataRow) null;
      if (key.HasValue)
      {
        Debug.Assert(ndx != null);
        int record = row.oldRecord == -1 ? row.newRecord : row.oldRecord;
        object[] keyValues = key.GetKeyValues(record);
        dataRow = this.FindByIndex(ndx, keyValues);
      }
      return dataRow;
    }

    private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action)
    {
      if (newRecord != -1)
      {
        this.SetNewRecord(row, newRecord, action, true, true);
        this.SetOldRecord(row, oldRecord);
      }
      else
      {
        this.SetOldRecord(row, oldRecord);
        if (row.newRecord == -1)
          return;
        Debug.Assert(action == DataRowAction.Delete, "Unexpected SetNewRecord action in merge function.");
        this.SetNewRecord(row, newRecord, action, true, true);
      }
    }

    internal DataRow MergeRow(
      DataRow row,
      DataRow targetRow,
      bool preserveChanges,
      Index idxSearch)
    {
      if (targetRow == null)
      {
        targetRow = this.NewEmptyRow();
        targetRow.oldRecord = this.recordManager.ImportRecord(row.Table, row.oldRecord);
        DataRow dataRow = targetRow;
        dataRow.newRecord = dataRow.oldRecord;
        if (row.oldRecord != row.newRecord)
          targetRow.newRecord = this.recordManager.ImportRecord(row.Table, row.newRecord);
        this.InsertRow(targetRow, -1);
      }
      else
      {
        int tempRecord = targetRow.tempRecord;
        targetRow.tempRecord = -1;
        try
        {
          DataRowState rowState = targetRow.RowState;
          int oldRecord1;
          int num1 = rowState == DataRowState.Added ? targetRow.newRecord : (oldRecord1 = targetRow.oldRecord);
          if (targetRow.RowState == DataRowState.Unchanged && row.RowState == DataRowState.Unchanged)
          {
            int oldRecord2 = targetRow.oldRecord;
            int newRecord = preserveChanges ? this.recordManager.CopyRecord(this, oldRecord2, -1) : targetRow.newRecord;
            int oldRecord3 = this.recordManager.CopyRecord(row.Table, row.oldRecord, targetRow.oldRecord);
            this.SetMergeRecords(targetRow, newRecord, oldRecord3, DataRowAction.Change);
          }
          else if (row.newRecord == -1)
          {
            int oldRecord2 = targetRow.oldRecord;
            int newRecord = !preserveChanges ? -1 : (targetRow.RowState == DataRowState.Unchanged ? this.recordManager.CopyRecord(this, oldRecord2, -1) : targetRow.newRecord);
            int oldRecord3 = this.recordManager.CopyRecord(row.Table, row.oldRecord, oldRecord2);
            if (num1 != (rowState == DataRowState.Added ? newRecord : oldRecord3))
            {
              this.SetMergeRecords(targetRow, newRecord, oldRecord3, newRecord == -1 ? DataRowAction.Delete : DataRowAction.Change);
              idxSearch.Reset();
              num1 = rowState == DataRowState.Added ? newRecord : oldRecord3;
            }
            else
              this.SetMergeRecords(targetRow, newRecord, oldRecord3, newRecord == -1 ? DataRowAction.Delete : DataRowAction.Change);
          }
          else
          {
            int oldRecord2 = targetRow.oldRecord;
            int num2 = targetRow.newRecord;
            if (targetRow.RowState == DataRowState.Unchanged)
              num2 = this.recordManager.CopyRecord(this, oldRecord2, -1);
            int oldRecord3 = this.recordManager.CopyRecord(row.Table, row.oldRecord, oldRecord2);
            if (!preserveChanges)
              num2 = this.recordManager.CopyRecord(row.Table, row.newRecord, num2);
            this.SetMergeRecords(targetRow, num2, oldRecord3, DataRowAction.Change);
          }
          if (rowState == DataRowState.Added && targetRow.oldRecord != -1)
            idxSearch.Reset();
          Debug.Assert(num1 == (rowState == DataRowState.Added ? targetRow.newRecord : targetRow.oldRecord), "oops, you change index record without noticing it");
        }
        finally
        {
          targetRow.tempRecord = tempRecord;
        }
      }
      if (row.HasErrors)
      {
        if (targetRow.RowError.Length == 0)
        {
          targetRow.RowError = row.RowError;
        }
        else
        {
          DataRow dataRow = targetRow;
          dataRow.RowError = dataRow.RowError + " ]:[ " + row.RowError;
        }
        DataColumn[] columnsInError = row.GetColumnsInError();
        for (int index = 0; index < columnsInError.Length; ++index)
        {
          DataColumn column = targetRow.Table.Columns[columnsInError[index].ColumnName];
          targetRow.SetColumnError(column, row.GetColumnError(columnsInError[index]));
        }
      }
      else if (!preserveChanges)
        targetRow.ClearErrors();
      return targetRow;
    }

    public void AcceptChanges()
    {
      DataRow[] array = new DataRow[this.Rows.Count];
      this.Rows.CopyTo(array, 0);
      this.SuspendIndexEvents();
      try
      {
        for (int index = 0; index < array.Length; ++index)
        {
          if (array[index].rowID != -1)
            array[index].AcceptChanges();
        }
      }
      finally
      {
        this.RestoreIndexEvents(false);
      }
    }

    protected virtual DataTable CreateInstance() => (DataTable) Activator.CreateInstance(this.GetType());

    public virtual DataTable Clone() => this.Clone((DataSet) null);

    internal DataTable Clone(DataSet cloneDS)
    {
      DataTable instance = this.CreateInstance();
      if (instance.Columns.Count > 0)
        instance.Reset();
      return this.CloneTo(instance, cloneDS, false);
    }

    private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable)
    {
      foreach (DataColumn column in (InternalDataCollectionBase) sourceTable.Columns)
      {
        if (targetTable.Columns[column.ColumnName] == null)
          targetTable.Columns.Add(column.Clone());
      }
      return targetTable;
    }

    private DataTable CloneHierarchy(
      DataTable sourceTable,
      DataSet ds,
      Microsoft.Phone.Data.Workaround.Hashtable visitedMap)
    {
      if (visitedMap == null)
        visitedMap = new Microsoft.Phone.Data.Workaround.Hashtable();
      if (visitedMap.Contains((object) sourceTable))
        return (DataTable) visitedMap[(object) sourceTable];
      DataTable dataTable1 = ds.Tables[sourceTable.TableName, sourceTable.Namespace];
      DataTable dataTable2;
      if (dataTable1 != null && dataTable1.Columns.Count > 0)
      {
        dataTable2 = this.IncrementalCloneTo(sourceTable, dataTable1);
      }
      else
      {
        if (dataTable1 == null)
        {
          dataTable1 = new DataTable();
          ds.Tables.Add(dataTable1);
        }
        dataTable2 = sourceTable.CloneTo(dataTable1, ds, true);
      }
      visitedMap[(object) sourceTable] = (object) dataTable2;
      foreach (DataRelation childRelation in (InternalDataCollectionBase) sourceTable.ChildRelations)
        this.CloneHierarchy(childRelation.ChildTable, ds, visitedMap);
      return dataTable2;
    }

    private DataTable CloneTo(
      DataTable clone,
      DataSet cloneDS,
      bool skipExpressionColumns)
    {
      Debug.Assert(clone != null, "The table passed in has to be newly created empty DataTable.");
      clone.tableName = this.tableName;
      clone.tableNamespace = this.tableNamespace;
      clone.tablePrefix = this.tablePrefix;
      clone.fNestedInDataset = this.fNestedInDataset;
      clone._culture = this._culture;
      clone._cultureUserSet = this._cultureUserSet;
      clone._compareInfo = this._compareInfo;
      clone._compareFlags = this._compareFlags;
      clone._hashCodeProvider = this._hashCodeProvider;
      clone._caseSensitive = this._caseSensitive;
      clone._caseSensitiveUserSet = this._caseSensitiveUserSet;
      clone.displayExpression = this.displayExpression;
      clone.typeName = this.typeName;
      clone.repeatableElement = this.repeatableElement;
      clone.MinimumCapacity = this.MinimumCapacity;
      DataColumnCollection columns = this.Columns;
      for (int index = 0; index < columns.Count; ++index)
        clone.Columns.Add(columns[index].Clone());
      if (!skipExpressionColumns && cloneDS == null)
      {
        for (int index = 0; index < columns.Count; ++index)
          clone.Columns[columns[index].ColumnName].Expression = columns[index].Expression;
      }
      DataColumn[] primaryKey = this.PrimaryKey;
      if (primaryKey.Length != 0)
      {
        DataColumn[] dataColumnArray = new DataColumn[primaryKey.Length];
        for (int index = 0; index < primaryKey.Length; ++index)
          dataColumnArray[index] = clone.Columns[primaryKey[index].Ordinal];
        clone.PrimaryKey = dataColumnArray;
      }
      for (int index = 0; index < this.Constraints.Count; ++index)
      {
        ForeignKeyConstraint constraint1 = this.Constraints[index] as ForeignKeyConstraint;
        UniqueConstraint constraint2 = this.Constraints[index] as UniqueConstraint;
        if (constraint1 != null)
        {
          if (constraint1.Table == constraint1.RelatedTable)
          {
            ForeignKeyConstraint foreignKeyConstraint = constraint1.Clone(clone);
            Constraint constraint3 = clone.Constraints.FindConstraint((Constraint) foreignKeyConstraint);
            if (constraint3 != null)
              constraint3.ConstraintName = this.Constraints[index].ConstraintName;
          }
        }
        else if (constraint2 != null)
        {
          UniqueConstraint uniqueConstraint = constraint2.Clone(clone);
          Constraint constraint3 = clone.Constraints.FindConstraint((Constraint) uniqueConstraint);
          if (constraint3 != null)
          {
            constraint3.ConstraintName = this.Constraints[index].ConstraintName;
            foreach (object key in (IEnumerable) uniqueConstraint.ExtendedProperties.Keys)
              constraint3.ExtendedProperties[key] = uniqueConstraint.ExtendedProperties[key];
          }
        }
      }
      for (int index = 0; index < this.Constraints.Count; ++index)
      {
        if (!clone.Constraints.Contains(this.Constraints[index].ConstraintName, true))
        {
          ForeignKeyConstraint constraint1 = this.Constraints[index] as ForeignKeyConstraint;
          UniqueConstraint constraint2 = this.Constraints[index] as UniqueConstraint;
          if (constraint1 != null)
          {
            if (constraint1.Table == constraint1.RelatedTable)
            {
              ForeignKeyConstraint foreignKeyConstraint = constraint1.Clone(clone);
              if (foreignKeyConstraint != null)
                clone.Constraints.Add((Constraint) foreignKeyConstraint);
            }
          }
          else if (constraint2 != null)
            clone.Constraints.Add((Constraint) constraint2.Clone(clone));
        }
      }
      if (this.extendedProperties != null)
      {
        foreach (object key in (IEnumerable) this.extendedProperties.Keys)
          clone.ExtendedProperties[key] = this.extendedProperties[key];
      }
      return clone;
    }

    public DataTable Copy()
    {
      DataTable table = this.Clone();
      foreach (DataRow row in (InternalDataCollectionBase) this.Rows)
        this.CopyRow(table, row);
      return table;
    }

    public event DataColumnChangeEventHandler ColumnChanging
    {
      add => this.onColumnChangingDelegate += value;
      remove => this.onColumnChangingDelegate -= value;
    }

    public event DataColumnChangeEventHandler ColumnChanged
    {
      add => this.onColumnChangedDelegate += value;
      remove => this.onColumnChangedDelegate -= value;
    }

    public event EventHandler Initialized
    {
      add => this.onInitialized += value;
      remove => this.onInitialized -= value;
    }

    public event DataRowChangeEventHandler RowChanged
    {
      add => this.onRowChangedDelegate += value;
      remove => this.onRowChangedDelegate -= value;
    }

    public event DataRowChangeEventHandler RowChanging
    {
      add => this.onRowChangingDelegate += value;
      remove => this.onRowChangingDelegate -= value;
    }

    public event DataRowChangeEventHandler RowDeleting
    {
      add => this.onRowDeletingDelegate += value;
      remove => this.onRowDeletingDelegate -= value;
    }

    public event DataRowChangeEventHandler RowDeleted
    {
      add => this.onRowDeletedDelegate += value;
      remove => this.onRowDeletedDelegate -= value;
    }

    public event DataTableClearEventHandler TableClearing
    {
      add => this.onTableClearingDelegate += value;
      remove => this.onTableClearingDelegate -= value;
    }

    public event DataTableClearEventHandler TableCleared
    {
      add => this.onTableClearedDelegate += value;
      remove => this.onTableClearedDelegate -= value;
    }

    public event DataTableNewRowEventHandler TableNewRow
    {
      add => this.onTableNewRowDelegate += value;
      remove => this.onTableNewRowDelegate -= value;
    }

    public override ISite Site
    {
      get => base.Site;
      set
      {
        ISite site = this.Site;
        if (value == null && site != null)
        {
          IContainer container = site.Container;
          if (container != null)
          {
            for (int index = 0; index < this.Columns.Count; ++index)
            {
              if (this.Columns[index].Site != null)
                container.Remove((IComponent) this.Columns[index]);
            }
          }
        }
        base.Site = value;
      }
    }

    internal DataRow AddRecords(int oldRecord, int newRecord)
    {
      DataRow row;
      if (oldRecord == -1 && newRecord == -1)
      {
        row = this.NewRow(-1);
        this.AddRow(row);
      }
      else
      {
        row = this.NewEmptyRow();
        row.oldRecord = oldRecord;
        row.newRecord = newRecord;
        this.InsertRow(row, -1);
      }
      return row;
    }

    internal void AddRow(DataRow row) => this.AddRow(row, -1);

    internal void AddRow(DataRow row, int proposedID) => this.InsertRow(row, proposedID, -1);

    internal void InsertRow(DataRow row, int proposedID, int pos) => this.InsertRow(row, proposedID, pos, true);

    internal void InsertRow(DataRow row, int proposedID, int pos, bool fireEvent)
    {
      Exception deferredException = (Exception) null;
      if (row == null)
        throw ExceptionBuilder.ArgumentNull(nameof (row));
      if (row.Table != this)
        throw ExceptionBuilder.RowAlreadyInOtherCollection();
      if (row.rowID != -1)
        throw ExceptionBuilder.RowAlreadyInTheCollection();
      row.BeginEdit();
      int tempRecord = row.tempRecord;
      row.tempRecord = -1;
      if (proposedID == -1)
        proposedID = this.nextRowID;
      bool flag;
      if (flag = this.nextRowID <= proposedID)
        this.nextRowID = checked (proposedID + 1);
      try
      {
        try
        {
          row.rowID = proposedID;
          this.SetNewRecordWorker(row, tempRecord, DataRowAction.Add, false, pos, fireEvent, out deferredException);
        }
        catch
        {
          if (flag && this.nextRowID == proposedID + 1)
            this.nextRowID = proposedID;
          row.rowID = -1;
          row.tempRecord = tempRecord;
          throw;
        }
        if (deferredException != null)
          throw deferredException;
        if (!this.EnforceConstraints || this.inLoad)
          return;
        int count = this.columnCollection.Count;
        for (int index = 0; index < count; ++index)
        {
          DataColumn column = this.columnCollection[index];
          if (column.Computed)
            column.CheckColumnConstraint(row, DataRowAction.Add);
        }
      }
      finally
      {
        row.ResetLastChangedColumn();
      }
    }

    internal void CheckNotModifying(DataRow row)
    {
      if (row.tempRecord == -1)
        return;
      row.EndEdit();
    }

    public void Clear() => this.Clear(true);

    internal void Clear(bool clearAll)
    {
      Debug.Assert(this.rowDiffId == null, "wasn't previously cleared");
      this.rowDiffId = (Microsoft.Phone.Data.Workaround.Hashtable) null;
      bool flag = (uint) this.Rows.Count > 0U;
      DataTableClearEventArgs e = (DataTableClearEventArgs) null;
      if (flag)
      {
        e = new DataTableClearEventArgs(this);
        this.OnTableClearing(e);
      }
      if (this.dataSet != null && this.dataSet.EnforceConstraints)
      {
        ParentForeignKeyConstraintEnumerator constraintEnumerator = new ParentForeignKeyConstraintEnumerator(this.dataSet, this);
        while (constraintEnumerator.GetNext())
          constraintEnumerator.GetForeignKeyConstraint().CheckCanClearParentTable(this);
      }
      this.recordManager.Clear(clearAll);
      foreach (DataRow row in (InternalDataCollectionBase) this.Rows)
      {
        row.oldRecord = -1;
        row.newRecord = -1;
        row.tempRecord = -1;
        row.rowID = -1;
        row.RBTreeNodeId = 0;
      }
      this.Rows.ArrayClear();
      this.ResetIndexes();
      if (flag)
        this.OnTableCleared(e);
      foreach (DataColumn column in (InternalDataCollectionBase) this.Columns)
        this.EvaluateDependentExpressions(column);
    }

    internal void CascadeAll(DataRow row, DataRowAction action)
    {
      if (this.DataSet == null || !this.DataSet.fEnableCascading)
        return;
      ParentForeignKeyConstraintEnumerator constraintEnumerator = new ParentForeignKeyConstraintEnumerator(this.dataSet, this);
      while (constraintEnumerator.GetNext())
        constraintEnumerator.GetForeignKeyConstraint().CheckCascade(row, action);
    }

    internal void CommitRow(DataRow row)
    {
      DataRowChangeEventArgs args = this.OnRowChanging((DataRowChangeEventArgs) null, row, DataRowAction.Commit);
      if (!this.inDataLoad)
        this.CascadeAll(row, DataRowAction.Commit);
      DataRow row1 = row;
      this.SetOldRecord(row1, row1.newRecord);
      this.OnRowChanged(args, row, DataRowAction.Commit);
    }

    internal int Compare(string s1, string s2)
    {
      object obj1 = (object) s1;
      object obj2 = (object) s2;
      if (obj1 == obj2)
        return 0;
      if (obj1 == null)
        return -1;
      if (obj2 == null)
        return 1;
      int length1 = s1.Length;
      int length2 = s2.Length;
      while (length1 > 0 && (s1[length1 - 1] == ' ' || s1[length1 - 1] == '　'))
        --length1;
      while (length2 > 0 && (s2[length2 - 1] == ' ' || s2[length2 - 1] == '　'))
        --length2;
      return this.CompareInfo.Compare(s1, 0, length1, s2, 0, length2, this._compareFlags);
    }

    internal int IndexOf(string s1, string s2) => this.CompareInfo.IndexOf(s1, s2, this._compareFlags);

    internal bool IsSuffix(string s1, string s2) => this.CompareInfo.IsSuffix(s1, s2, this._compareFlags);

    public object Compute(string expression, string filter)
    {
      DataRow[] rows = this.Select(filter, "", DataViewRowState.CurrentRows);
      return new DataExpression(this, expression).Evaluate(rows);
    }

    internal void CopyRow(DataTable table, DataRow row)
    {
      int oldRecord = -1;
      int newRecord = -1;
      if (row == null)
        return;
      if (row.oldRecord != -1)
        oldRecord = table.recordManager.ImportRecord(row.Table, row.oldRecord);
      if (row.newRecord != -1)
        newRecord = row.newRecord == row.oldRecord ? oldRecord : table.recordManager.ImportRecord(row.Table, row.newRecord);
      DataRow dataRow = table.AddRecords(oldRecord, newRecord);
      if (!row.HasErrors)
        return;
      dataRow.RowError = row.RowError;
      DataColumn[] columnsInError = row.GetColumnsInError();
      for (int index = 0; index < columnsInError.Length; ++index)
      {
        DataColumn column = dataRow.Table.Columns[columnsInError[index].ColumnName];
        dataRow.SetColumnError(column, row.GetColumnError(columnsInError[index]));
      }
    }

    internal void DeleteRow(DataRow row)
    {
      if (row.newRecord == -1)
        throw ExceptionBuilder.RowAlreadyDeleted();
      this.SetNewRecord(row, -1, DataRowAction.Delete, false, true);
    }

    private void CheckPrimaryKey()
    {
      if (this.primaryKey == null)
        throw ExceptionBuilder.TableMissingPrimaryKey();
    }

    internal DataRow FindByPrimaryKey(object[] values)
    {
      this.CheckPrimaryKey();
      return this.FindRow(this.primaryKey.Key, values);
    }

    internal DataRow FindByPrimaryKey(object value)
    {
      this.CheckPrimaryKey();
      return this.FindRow(this.primaryKey.Key, value);
    }

    private DataRow FindRow(DataKey key, object[] values)
    {
      Index index = this.GetIndex(this.NewIndexDesc(key));
      Range records = index.FindRecords(values);
      return records.IsNull ? (DataRow) null : this.recordManager[index.GetRecord(records.Min)];
    }

    private DataRow FindRow(DataKey key, object value)
    {
      Index index = this.GetIndex(this.NewIndexDesc(key));
      Range records = index.FindRecords(value);
      return records.IsNull ? (DataRow) null : this.recordManager[index.GetRecord(records.Min)];
    }

    internal string FormatSortString(IndexField[] indexDesc)
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (IndexField indexField in indexDesc)
      {
        if (0 < stringBuilder.Length)
          stringBuilder.Append(", ");
        stringBuilder.Append(indexField.Column.ColumnName);
        if (indexField.IsDescending)
          stringBuilder.Append(" DESC");
      }
      return stringBuilder.ToString();
    }

    internal void FreeRecord(ref int record) => this.recordManager.FreeRecord(ref record);

    public DataTable GetChanges()
    {
      DataTable dataTable = this.Clone();
      for (int index = 0; index < this.Rows.Count; ++index)
      {
        DataRow row = this.Rows[index];
        if (row.oldRecord != row.newRecord)
          dataTable.ImportRow(row);
      }
      return dataTable.Rows.Count == 0 ? (DataTable) null : dataTable;
    }

    public DataTable GetChanges(DataRowState rowStates)
    {
      DataTable dataTable = this.Clone();
      Debug.Assert(Enum.GetUnderlyingType(typeof (DataRowState)) == typeof (int), "Invalid DataRowState type");
      for (int index = 0; index < this.Rows.Count; ++index)
      {
        DataRow row = this.Rows[index];
        if ((row.RowState & rowStates) != (DataRowState) 0)
          dataTable.ImportRow(row);
      }
      return dataTable.Rows.Count == 0 ? (DataTable) null : dataTable;
    }

    public DataRow[] GetErrors()
    {
      List<DataRow> dataRowList = new List<DataRow>();
      for (int index = 0; index < this.Rows.Count; ++index)
      {
        DataRow row = this.Rows[index];
        if (row.HasErrors)
          dataRowList.Add(row);
      }
      DataRow[] array = this.NewRowArray(dataRowList.Count);
      dataRowList.CopyTo(array);
      return array;
    }

    internal Index GetIndex(IndexField[] indexDesc) => this.GetIndex(indexDesc, DataViewRowState.CurrentRows, (IFilter) null);

    internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) => this.GetIndex(this.ParseSortString(sort), recordStates, rowFilter);

    internal Index GetIndex(
      IndexField[] indexDesc,
      DataViewRowState recordStates,
      IFilter rowFilter)
    {
      lock (this.indexes)
      {
        for (int index1 = 0; index1 < this.indexes.Count; ++index1)
        {
          Index index2 = this.indexes[index1];
          if (index2 != null && index2.Equal(indexDesc, recordStates, rowFilter))
            return index2;
        }
      }
      Index index = new Index(this, indexDesc, recordStates, rowFilter);
      index.AddRef();
      return index;
    }

    internal List<DataViewListener> GetListeners() => this._dataViewListeners;

    internal int GetSpecialHashCode(string name)
    {
      int index = 0;
      while (index < name.Length && '　' > name[index])
        ++index;
      if (name.Length != index)
        return 0;
      if (this._hashCodeProvider == null)
        this._hashCodeProvider = StringComparer.Create(this.Locale, true);
      return this._hashCodeProvider.GetHashCode(name);
    }

    public void ImportRow(DataRow row)
    {
      int oldRecord = -1;
      int newRecord = -1;
      if (row == null)
        return;
      if (row.oldRecord != -1)
        oldRecord = this.recordManager.ImportRecord(row.Table, row.oldRecord);
      if (row.newRecord != -1)
        newRecord = row.RowState == DataRowState.Unchanged ? oldRecord : this.recordManager.ImportRecord(row.Table, row.newRecord);
      if (oldRecord == -1 && newRecord == -1)
        return;
      DataRow dataRow = this.AddRecords(oldRecord, newRecord);
      if (!row.HasErrors)
        return;
      dataRow.RowError = row.RowError;
      DataColumn[] columnsInError = row.GetColumnsInError();
      for (int index = 0; index < columnsInError.Length; ++index)
      {
        DataColumn column = dataRow.Table.Columns[columnsInError[index].ColumnName];
        dataRow.SetColumnError(column, row.GetColumnError(columnsInError[index]));
      }
    }

    internal void InsertRow(DataRow row, int proposedID)
    {
      if (row.Table != this)
        throw ExceptionBuilder.RowAlreadyInOtherCollection();
      if (row.rowID != -1)
        throw ExceptionBuilder.RowAlreadyInTheCollection();
      if (row.oldRecord == -1 && row.newRecord == -1)
        throw ExceptionBuilder.RowEmpty();
      if (proposedID == -1)
        proposedID = this.nextRowID;
      row.rowID = proposedID;
      if (this.nextRowID <= proposedID)
        this.nextRowID = checked (proposedID + 1);
      DataRowChangeEventArgs args = (DataRowChangeEventArgs) null;
      if (row.newRecord != -1)
      {
        DataRow dataRow1 = row;
        dataRow1.tempRecord = dataRow1.newRecord;
        row.newRecord = -1;
        try
        {
          args = this.RaiseRowChanging((DataRowChangeEventArgs) null, row, DataRowAction.Add, true);
        }
        catch
        {
          row.tempRecord = -1;
          throw;
        }
        DataRow dataRow2 = row;
        dataRow2.newRecord = dataRow2.tempRecord;
        row.tempRecord = -1;
      }
      if (row.oldRecord != -1)
        this.recordManager[row.oldRecord] = row;
      if (row.newRecord != -1)
        this.recordManager[row.newRecord] = row;
      this.Rows.ArrayAdd(row);
      if (row.RowState == DataRowState.Unchanged)
      {
        this.RecordStateChanged(row.oldRecord, DataViewRowState.None, DataViewRowState.Unchanged);
      }
      else
      {
        int oldRecord = row.oldRecord;
        DataRow dataRow1 = row;
        int recordState1 = (int) dataRow1.GetRecordState(dataRow1.oldRecord);
        int newRecord = row.newRecord;
        DataRow dataRow2 = row;
        int recordState2 = (int) dataRow2.GetRecordState(dataRow2.newRecord);
        this.RecordStateChanged(oldRecord, DataViewRowState.None, (DataViewRowState) recordState1, newRecord, DataViewRowState.None, (DataViewRowState) recordState2);
      }
      if (this.dependentColumns != null && this.dependentColumns.Count > 0)
        this.EvaluateExpressions(row, DataRowAction.Add, (List<DataRow>) null);
      this.RaiseRowChanged(args, row, DataRowAction.Add);
    }

    private IndexField[] NewIndexDesc(DataKey key)
    {
      Debug.Assert(key.HasValue);
      IndexField[] indexDesc = key.GetIndexDesc();
      IndexField[] indexFieldArray = new IndexField[indexDesc.Length];
      Array.Copy((Array) indexDesc, 0, (Array) indexFieldArray, 0, indexDesc.Length);
      return indexFieldArray;
    }

    internal int NewRecord() => this.NewRecord(-1);

    internal int NewUninitializedRecord() => this.recordManager.NewRecordBase();

    internal int NewRecordFromArray(object[] value)
    {
      int count = this.columnCollection.Count;
      if (count < value.Length)
        throw ExceptionBuilder.ValueArrayLength();
      int record = this.recordManager.NewRecordBase();
      try
      {
        for (int index = 0; index < value.Length; ++index)
        {
          if (value[index] != null)
            this.columnCollection[index][record] = value[index];
          else
            this.columnCollection[index].Init(record);
        }
        for (int length = value.Length; length < count; ++length)
          this.columnCollection[length].Init(record);
        return record;
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableOrSecurityExceptionType(ex))
          this.FreeRecord(ref record);
        throw;
      }
    }

    internal int NewRecord(int sourceRecord)
    {
      int num = this.recordManager.NewRecordBase();
      int count = this.columnCollection.Count;
      if (-1 == sourceRecord)
      {
        for (int index = 0; index < count; ++index)
          this.columnCollection[index].Init(num);
      }
      else
      {
        for (int index = 0; index < count; ++index)
          this.columnCollection[index].Copy(sourceRecord, num);
      }
      return num;
    }

    internal DataRow NewEmptyRow()
    {
      this.rowBuilder._record = -1;
      return this.NewRowFromBuilder(this.rowBuilder);
    }

    private DataRow NewUninitializedRow() => this.NewRow(this.NewUninitializedRecord());

    public DataRow NewRow()
    {
      DataRow row = this.NewRow(-1);
      this.NewRowCreated(row);
      return row;
    }

    private void NewRowCreated(DataRow row)
    {
      if (this.onTableNewRowDelegate == null)
        return;
      this.OnTableNewRow(new DataTableNewRowEventArgs(row));
    }

    internal DataRow NewRow(int record)
    {
      if (-1 == record)
        record = this.NewRecord(-1);
      this.rowBuilder._record = record;
      DataRow dataRow = this.NewRowFromBuilder(this.rowBuilder);
      this.recordManager[record] = dataRow;
      return dataRow;
    }

    protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) => new DataRow(builder);

    protected virtual Type GetRowType() => typeof (DataRow);

    protected internal DataRow[] NewRowArray(int size)
    {
      if (this.IsTypedDataTable)
      {
        if (size != 0)
          return (DataRow[]) Array.CreateInstance(this.GetRowType(), size);
        if (this.EmptyDataRowArray == null)
          this.EmptyDataRowArray = (DataRow[]) Array.CreateInstance(this.GetRowType(), 0);
        return this.EmptyDataRowArray;
      }
      return size != 0 ? new DataRow[size] : DataTable.zeroRows;
    }

    internal bool NeedColumnChangeEvents => this.IsTypedDataTable || this.onColumnChangingDelegate != null || this.onColumnChangedDelegate != null;

    protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e)
    {
      Debug.Assert(e != null, "e should not be null");
      if (this.onColumnChangingDelegate == null)
        return;
      this.onColumnChangingDelegate((object) this, e);
    }

    protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e)
    {
      Debug.Assert(e != null, "e should not be null");
      if (this.onColumnChangedDelegate == null)
        return;
      this.onColumnChangedDelegate((object) this, e);
    }

    protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
    {
    }

    private DataRowChangeEventArgs OnRowChanged(
      DataRowChangeEventArgs args,
      DataRow eRow,
      DataRowAction eAction)
    {
      if (this.onRowChangedDelegate != null || this.IsTypedDataTable)
      {
        if (args == null)
          args = new DataRowChangeEventArgs(eRow, eAction);
        this.OnRowChanged(args);
      }
      return args;
    }

    private DataRowChangeEventArgs OnRowChanging(
      DataRowChangeEventArgs args,
      DataRow eRow,
      DataRowAction eAction)
    {
      if (this.onRowChangingDelegate != null || this.IsTypedDataTable)
      {
        if (args == null)
          args = new DataRowChangeEventArgs(eRow, eAction);
        this.OnRowChanging(args);
      }
      return args;
    }

    protected virtual void OnRowChanged(DataRowChangeEventArgs e)
    {
      Debug.Assert(e != null && (this.onRowChangedDelegate != null || this.IsTypedDataTable), "OnRowChanged arguments");
      if (this.onRowChangedDelegate == null)
        return;
      this.onRowChangedDelegate((object) this, e);
    }

    protected virtual void OnRowChanging(DataRowChangeEventArgs e)
    {
      Debug.Assert(e != null && (this.onRowChangingDelegate != null || this.IsTypedDataTable), "OnRowChanging arguments");
      if (this.onRowChangingDelegate == null)
        return;
      this.onRowChangingDelegate((object) this, e);
    }

    protected virtual void OnRowDeleting(DataRowChangeEventArgs e)
    {
      Debug.Assert(e != null && (this.onRowDeletingDelegate != null || this.IsTypedDataTable), "OnRowDeleting arguments");
      if (this.onRowDeletingDelegate == null)
        return;
      this.onRowDeletingDelegate((object) this, e);
    }

    protected virtual void OnRowDeleted(DataRowChangeEventArgs e)
    {
      Debug.Assert(e != null && (this.onRowDeletedDelegate != null || this.IsTypedDataTable), "OnRowDeleted arguments");
      if (this.onRowDeletedDelegate == null)
        return;
      this.onRowDeletedDelegate((object) this, e);
    }

    protected virtual void OnTableCleared(DataTableClearEventArgs e)
    {
      if (this.onTableClearedDelegate == null)
        return;
      this.onTableClearedDelegate((object) this, e);
    }

    protected virtual void OnTableClearing(DataTableClearEventArgs e)
    {
      if (this.onTableClearingDelegate == null)
        return;
      this.onTableClearingDelegate((object) this, e);
    }

    protected virtual void OnTableNewRow(DataTableNewRowEventArgs e)
    {
      if (this.onTableNewRowDelegate == null)
        return;
      this.onTableNewRowDelegate((object) this, e);
    }

    private void OnInitialized()
    {
      if (this.onInitialized == null)
        return;
      this.onInitialized((object) this, EventArgs.Empty);
    }

    internal IndexField[] ParseSortString(string sortString)
    {
      IndexField[] indexFieldArray = DataTable.zeroIndexField;
      if (sortString != null && 0 < sortString.Length)
      {
        string[] strArray = sortString.Split(',');
        indexFieldArray = new IndexField[strArray.Length];
        for (int index = 0; index < strArray.Length; ++index)
        {
          string str = strArray[index].Trim();
          int length = str.Length;
          bool isDescending = false;
          if (length >= 5 && string.Compare(str, length - 4, " ASC", 0, 4, StringComparison.OrdinalIgnoreCase) == 0)
            str = str.Substring(0, length - 4).Trim();
          else if (length >= 6 && string.Compare(str, length - 5, " DESC", 0, 5, StringComparison.OrdinalIgnoreCase) == 0)
          {
            isDescending = true;
            str = str.Substring(0, length - 5).Trim();
          }
          if (str.StartsWith("[", StringComparison.Ordinal))
            str = str.EndsWith("]", StringComparison.Ordinal) ? str.Substring(1, str.Length - 2) : throw ExceptionBuilder.InvalidSortString(strArray[index]);
          indexFieldArray[index] = new IndexField(this.Columns[str] ?? throw ExceptionBuilder.ColumnOutOfRange(str), isDescending);
        }
      }
      return indexFieldArray;
    }

    internal void RaisePropertyChanging(string name) => this.OnPropertyChanging(new PropertyChangedEventArgs(name));

    internal void RecordChanged(int record)
    {
      Debug.Assert(record != -1, "Record number must be given");
      this.SetShadowIndexes();
      try
      {
        int count = this.shadowIndexes.Count;
        for (int index = 0; index < count; ++index)
        {
          Index shadowIndex = this.shadowIndexes[index];
          if (0 < shadowIndex.RefCount)
            shadowIndex.RecordChanged(record);
        }
      }
      finally
      {
        this.RestoreShadowIndexes();
      }
    }

    internal void RecordChanged(int[] oldIndex, int[] newIndex)
    {
      this.SetShadowIndexes();
      Debug.Assert(oldIndex.Length == newIndex.Length, "Size oldIndexes and newIndexes should be the same");
      Debug.Assert(oldIndex.Length == this.shadowIndexes.Count, "Size of OldIndexes should be the same as size of Live indexes");
      try
      {
        int count = this.shadowIndexes.Count;
        for (int index = 0; index < count; ++index)
        {
          Index shadowIndex = this.shadowIndexes[index];
          if (0 < shadowIndex.RefCount)
            shadowIndex.RecordChanged(oldIndex[index], newIndex[index]);
        }
      }
      finally
      {
        this.RestoreShadowIndexes();
      }
    }

    internal void RecordStateChanged(
      int record,
      DataViewRowState oldState,
      DataViewRowState newState)
    {
      this.SetShadowIndexes();
      try
      {
        int count = this.shadowIndexes.Count;
        for (int index = 0; index < count; ++index)
        {
          Index shadowIndex = this.shadowIndexes[index];
          if (0 < shadowIndex.RefCount)
            shadowIndex.RecordStateChanged(record, oldState, newState);
        }
      }
      finally
      {
        this.RestoreShadowIndexes();
      }
    }

    internal void RecordStateChanged(
      int record1,
      DataViewRowState oldState1,
      DataViewRowState newState1,
      int record2,
      DataViewRowState oldState2,
      DataViewRowState newState2)
    {
      this.SetShadowIndexes();
      try
      {
        int count = this.shadowIndexes.Count;
        for (int index = 0; index < count; ++index)
        {
          Index shadowIndex = this.shadowIndexes[index];
          if (0 < shadowIndex.RefCount)
          {
            if (record1 != -1 && record2 != -1)
              shadowIndex.RecordStateChanged(record1, oldState1, newState1, record2, oldState2, newState2);
            else if (record1 != -1)
              shadowIndex.RecordStateChanged(record1, oldState1, newState1);
            else if (record2 != -1)
              shadowIndex.RecordStateChanged(record2, oldState2, newState2);
          }
        }
      }
      finally
      {
        this.RestoreShadowIndexes();
      }
    }

    internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version)
    {
      int count = this.LiveIndexes.Count;
      int[] numArray = new int[count];
      int recordFromVersion = row.GetRecordFromVersion(version);
      DataViewRowState recordState = row.GetRecordState(recordFromVersion);
      while (--count >= 0)
      {
        if (row.HasVersion(version) && (recordState & this.indexes[count].RecordStates) != DataViewRowState.None)
        {
          int index = this.indexes[count].GetIndex(recordFromVersion);
          if (index > -1)
          {
            numArray[count] = index;
            this.indexes[count].DeleteRecordFromIndex(index);
          }
          else
            numArray[count] = -1;
        }
        else
          numArray[count] = -1;
      }
      return numArray;
    }

    internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version)
    {
      int count = this.LiveIndexes.Count;
      int[] numArray = new int[count];
      int recordFromVersion = row.GetRecordFromVersion(version);
      DataViewRowState recordState = row.GetRecordState(recordFromVersion);
      while (--count >= 0)
      {
        if (row.HasVersion(version))
          numArray[count] = (recordState & this.indexes[count].RecordStates) == DataViewRowState.None ? -1 : this.indexes[count].InsertRecordToIndex(recordFromVersion);
      }
      return numArray;
    }

    internal void SilentlySetValue(
      DataRow dr,
      DataColumn dc,
      DataRowVersion version,
      object newValue)
    {
      int recordFromVersion = dr.GetRecordFromVersion(version);
      if (DataStorage.IsTypeCustomType(dc.DataType) && newValue != dc[recordFromVersion] || !dc.CompareValueTo(recordFromVersion, newValue, true))
      {
        int[] oldIndex = dr.Table.RemoveRecordFromIndexes(dr, version);
        dc.SetValue(recordFromVersion, newValue);
        int[] indexes = dr.Table.InsertRecordToIndexes(dr, version);
        if (dr.HasVersion(version))
        {
          if (version != DataRowVersion.Original)
            dr.Table.RecordChanged(oldIndex, indexes);
          if (dc.dependentColumns != null)
            dc.Table.EvaluateDependentExpressions(dc.dependentColumns, dr, version, (List<DataRow>) null);
        }
      }
      dr.ResetLastChangedColumn();
    }

    public void RejectChanges()
    {
      DataRow[] array = new DataRow[this.Rows.Count];
      this.Rows.CopyTo(array, 0);
      for (int index = 0; index < array.Length; ++index)
        this.RollbackRow(array[index]);
    }

    internal void RemoveRow(DataRow row, bool check)
    {
      if (row.rowID == -1)
        throw ExceptionBuilder.RowAlreadyRemoved();
      if (check && this.dataSet != null)
      {
        ParentForeignKeyConstraintEnumerator constraintEnumerator = new ParentForeignKeyConstraintEnumerator(this.dataSet, this);
        while (constraintEnumerator.GetNext())
          constraintEnumerator.GetForeignKeyConstraint().CheckCanRemoveParentRow(row);
      }
      int record = row.oldRecord;
      int newRecord = row.newRecord;
      DataViewRowState recordState1 = row.GetRecordState(record);
      DataViewRowState recordState2 = row.GetRecordState(newRecord);
      row.oldRecord = -1;
      row.newRecord = -1;
      if (record == newRecord)
        record = -1;
      this.RecordStateChanged(record, recordState1, DataViewRowState.None, newRecord, recordState2, DataViewRowState.None);
      this.FreeRecord(ref record);
      this.FreeRecord(ref newRecord);
      row.rowID = -1;
      this.Rows.ArrayRemove(row);
    }

    public virtual void Reset()
    {
      this.Clear();
      this.ResetConstraints();
      DataRelationCollection parentRelations = this.ParentRelations;
      int count1 = parentRelations.Count;
      while (count1 > 0)
      {
        --count1;
        parentRelations.RemoveAt(count1);
      }
      DataRelationCollection childRelations = this.ChildRelations;
      int count2 = childRelations.Count;
      while (count2 > 0)
      {
        --count2;
        childRelations.RemoveAt(count2);
      }
      this.Columns.Clear();
      this.indexes.Clear();
    }

    internal void ResetIndexes() => this.ResetInternalIndexes((DataColumn) null);

    internal void ResetInternalIndexes(DataColumn column)
    {
      Debug.Assert(this.indexes != null, "unexpected null indexes");
      this.SetShadowIndexes();
      try
      {
        int count = this.shadowIndexes.Count;
        for (int index = 0; index < count; ++index)
        {
          Index shadowIndex = this.shadowIndexes[index];
          if (0 < shadowIndex.RefCount)
          {
            if (column == null)
            {
              shadowIndex.Reset();
            }
            else
            {
              bool flag = false;
              foreach (IndexField indexField in shadowIndex.IndexFields)
              {
                if (column == indexField.Column)
                {
                  flag = true;
                  break;
                }
              }
              if (flag)
                shadowIndex.Reset();
            }
          }
        }
      }
      finally
      {
        this.RestoreShadowIndexes();
      }
    }

    internal void RollbackRow(DataRow row)
    {
      row.CancelEdit();
      DataRow row1 = row;
      this.SetNewRecord(row1, row1.oldRecord, DataRowAction.Rollback, false, true);
    }

    private DataRowChangeEventArgs RaiseRowChanged(
      DataRowChangeEventArgs args,
      DataRow eRow,
      DataRowAction eAction)
    {
      try
      {
        if (this.UpdatingCurrent(eRow, eAction) && (this.IsTypedDataTable || this.onRowChangedDelegate != null))
          args = this.OnRowChanged(args, eRow, eAction);
        else if (DataRowAction.Delete == eAction)
        {
          if (eRow.newRecord == -1)
          {
            if (!this.IsTypedDataTable)
            {
              if (this.onRowDeletedDelegate == null)
                goto label_12;
            }
            if (args == null)
              args = new DataRowChangeEventArgs(eRow, eAction);
            this.OnRowDeleted(args);
          }
        }
      }
      catch (Exception ex)
      {
        if (!ADP.IsCatchableExceptionType(ex))
          throw;
        else
          ExceptionBuilder.TraceExceptionWithoutRethrow(ex);
      }
label_12:
      return args;
    }

    private DataRowChangeEventArgs RaiseRowChanging(
      DataRowChangeEventArgs args,
      DataRow eRow,
      DataRowAction eAction)
    {
      if (this.UpdatingCurrent(eRow, eAction) && (this.IsTypedDataTable || this.onRowChangingDelegate != null))
      {
        eRow.inChangingEvent = true;
        try
        {
          args = this.OnRowChanging(args, eRow, eAction);
        }
        finally
        {
          eRow.inChangingEvent = false;
        }
      }
      else if (DataRowAction.Delete == eAction && eRow.newRecord != -1 && (this.IsTypedDataTable || this.onRowDeletingDelegate != null))
      {
        eRow.inDeletingEvent = true;
        try
        {
          if (args == null)
            args = new DataRowChangeEventArgs(eRow, eAction);
          this.OnRowDeleting(args);
        }
        finally
        {
          eRow.inDeletingEvent = false;
        }
      }
      return args;
    }

    private DataRowChangeEventArgs RaiseRowChanging(
      DataRowChangeEventArgs args,
      DataRow eRow,
      DataRowAction eAction,
      bool fireEvent)
    {
      if (this.EnforceConstraints && !this.inLoad)
      {
        int count1 = this.columnCollection.Count;
        for (int index = 0; index < count1; ++index)
        {
          DataColumn column = this.columnCollection[index];
          if (!column.Computed || eAction != DataRowAction.Add)
            column.CheckColumnConstraint(eRow, eAction);
        }
        int count2 = this.constraintCollection.Count;
        for (int index = 0; index < count2; ++index)
          this.constraintCollection[index].CheckConstraint(eRow, eAction);
      }
      if (fireEvent)
        args = this.RaiseRowChanging(args, eRow, eAction);
      if (!this.inDataLoad && !this.MergingData && (eAction != DataRowAction.Nothing && eAction != DataRowAction.ChangeOriginal))
        this.CascadeAll(eRow, eAction);
      return args;
    }

    public DataRow[] Select() => new Microsoft.Phone.Data.Select(this, "", "", DataViewRowState.CurrentRows).SelectRows();

    public DataRow[] Select(string filterExpression) => new Microsoft.Phone.Data.Select(this, filterExpression, "", DataViewRowState.CurrentRows).SelectRows();

    public DataRow[] Select(string filterExpression, string sort) => new Microsoft.Phone.Data.Select(this, filterExpression, sort, DataViewRowState.CurrentRows).SelectRows();

    public DataRow[] Select(
      string filterExpression,
      string sort,
      DataViewRowState recordStates)
    {
      return new Microsoft.Phone.Data.Select(this, filterExpression, sort, recordStates).SelectRows();
    }

    internal void SetNewRecord(
      DataRow row,
      int proposedRecord,
      DataRowAction action,
      bool isInMerge,
      bool fireEvent)
    {
      Exception deferredException = (Exception) null;
      this.SetNewRecordWorker(row, proposedRecord, action, isInMerge, -1, fireEvent, out deferredException);
      if (deferredException != null)
        throw deferredException;
    }

    private void SetNewRecordWorker(
      DataRow row,
      int proposedRecord,
      DataRowAction action,
      bool isInMerge,
      int position,
      bool fireEvent,
      out Exception deferredException)
    {
      Debug.Assert(row != null, "Row can't be null.");
      deferredException = (Exception) null;
      if (row.tempRecord != proposedRecord)
      {
        if (!this.inDataLoad)
        {
          row.CheckInTable();
          this.CheckNotModifying(row);
        }
        if (proposedRecord == row.newRecord)
        {
          if (!isInMerge)
            return;
          Debug.Assert(fireEvent, "SetNewRecord is called with wrong parameter");
          this.RaiseRowChanged((DataRowChangeEventArgs) null, row, action);
          return;
        }
        Debug.Assert(!row.inChangingEvent, "How can this row be in an infinite loop?");
        row.tempRecord = proposedRecord;
      }
      DataRowChangeEventArgs args = (DataRowChangeEventArgs) null;
      try
      {
        row._action = action;
        args = this.RaiseRowChanging((DataRowChangeEventArgs) null, row, action, fireEvent);
      }
      catch
      {
        row.tempRecord = -1;
        throw;
      }
      finally
      {
        row._action = DataRowAction.Nothing;
      }
      row.tempRecord = -1;
      int newRecord = row.newRecord;
      int num = proposedRecord != -1 ? proposedRecord : (row.RowState != DataRowState.Unchanged ? row.oldRecord : -1);
      if (action == DataRowAction.Add)
      {
        if (position == -1)
          this.Rows.ArrayAdd(row);
        else
          this.Rows.ArrayInsert(row, position);
      }
      List<DataRow> cachedRows = (List<DataRow>) null;
      if ((action == DataRowAction.Delete || action == DataRowAction.Change) && (this.dependentColumns != null && this.dependentColumns.Count > 0))
      {
        cachedRows = new List<DataRow>();
        for (int index = 0; index < this.ParentRelations.Count; ++index)
        {
          DataRelation parentRelation = this.ParentRelations[index];
          if (parentRelation.ChildTable == row.Table)
          {
            List<DataRow> dataRowList = cachedRows;
            dataRowList.InsertRange(dataRowList.Count, (IEnumerable<DataRow>) row.GetParentRows(parentRelation));
          }
        }
        for (int index = 0; index < this.ChildRelations.Count; ++index)
        {
          DataRelation childRelation = this.ChildRelations[index];
          if (childRelation.ParentTable == row.Table)
          {
            List<DataRow> dataRowList = cachedRows;
            dataRowList.InsertRange(dataRowList.Count, (IEnumerable<DataRow>) row.GetChildRows(childRelation));
          }
        }
      }
      if (this.LiveIndexes.Count != 0)
      {
        DataViewRowState recordState1 = row.GetRecordState(newRecord);
        DataViewRowState recordState2 = row.GetRecordState(num);
        row.newRecord = proposedRecord;
        if (proposedRecord != -1)
          this.recordManager[proposedRecord] = row;
        DataViewRowState recordState3 = row.GetRecordState(newRecord);
        DataViewRowState recordState4 = row.GetRecordState(num);
        this.RecordStateChanged(newRecord, recordState1, recordState3, num, recordState2, recordState4);
      }
      else
      {
        row.newRecord = proposedRecord;
        if (proposedRecord != -1)
          this.recordManager[proposedRecord] = row;
      }
      if (-1 != newRecord && newRecord != row.oldRecord && (newRecord != row.tempRecord && newRecord != row.newRecord) && row == this.recordManager[newRecord])
        this.FreeRecord(ref newRecord);
      if (row.RowState == DataRowState.Detached && row.rowID != -1)
        this.RemoveRow(row, false);
      if (this.dependentColumns != null)
      {
        if (this.dependentColumns.Count > 0)
        {
          try
          {
            this.EvaluateExpressions(row, action, cachedRows);
          }
          catch (Exception ex)
          {
            if (action != DataRowAction.Add)
              throw ex;
            deferredException = ex;
          }
        }
      }
      try
      {
        if (!fireEvent)
          return;
        this.RaiseRowChanged(args, row, action);
      }
      catch (Exception ex)
      {
        if (!ADP.IsCatchableExceptionType(ex))
          throw;
        else
          ExceptionBuilder.TraceExceptionWithoutRethrow(ex);
      }
    }

    internal void SetOldRecord(DataRow row, int proposedRecord)
    {
      if (!this.inDataLoad)
      {
        row.CheckInTable();
        this.CheckNotModifying(row);
      }
      if (proposedRecord == row.oldRecord)
        return;
      int oldRecord = row.oldRecord;
      try
      {
        if (this.LiveIndexes.Count != 0)
        {
          DataViewRowState recordState1 = row.GetRecordState(oldRecord);
          DataViewRowState recordState2 = row.GetRecordState(proposedRecord);
          row.oldRecord = proposedRecord;
          if (proposedRecord != -1)
            this.recordManager[proposedRecord] = row;
          DataViewRowState recordState3 = row.GetRecordState(oldRecord);
          DataViewRowState recordState4 = row.GetRecordState(proposedRecord);
          this.RecordStateChanged(oldRecord, recordState1, recordState3, proposedRecord, recordState2, recordState4);
        }
        else
        {
          row.oldRecord = proposedRecord;
          if (proposedRecord == -1)
            return;
          this.recordManager[proposedRecord] = row;
        }
      }
      finally
      {
        if (oldRecord != -1 && oldRecord != row.tempRecord && (oldRecord != row.oldRecord && oldRecord != row.newRecord))
          this.FreeRecord(ref oldRecord);
        if (row.RowState == DataRowState.Detached && row.rowID != -1)
          this.RemoveRow(row, false);
      }
    }

    private void RestoreShadowIndexes()
    {
      Debug.Assert(1 <= this.shadowCount, "unexpected negative shadow count");
      --this.shadowCount;
      if (this.shadowCount != 0)
        return;
      this.shadowIndexes = (List<Index>) null;
    }

    private void SetShadowIndexes()
    {
      if (this.shadowIndexes == null)
      {
        Debug.Assert(this.shadowCount == 0, "unexpected count");
        this.shadowIndexes = this.LiveIndexes;
        this.shadowCount = 1;
      }
      else
      {
        Debug.Assert(1 <= this.shadowCount, "unexpected negative shadow count");
        ++this.shadowCount;
      }
    }

    internal void ShadowIndexCopy()
    {
      if (this.shadowIndexes != this.indexes)
        return;
      Debug.Assert(0 < this.indexes.Count, "unexpected");
      this.shadowIndexes = new List<Index>((IEnumerable<Index>) this.indexes);
    }

    public override string ToString() => this.displayExpression == null ? this.TableName : this.TableName + " + " + this.DisplayExpressionInternal;

    public void BeginLoadData()
    {
      if (this.inDataLoad)
        return;
      this.inDataLoad = true;
      Debug.Assert(this.loadIndex == null, "loadIndex should already be null");
      this.loadIndex = (Index) null;
      this.initialLoad = this.Rows.Count == 0;
      if (this.initialLoad)
      {
        this.SuspendIndexEvents();
      }
      else
      {
        if (this.primaryKey != null)
          this.loadIndex = this.primaryKey.Key.GetSortIndex(DataViewRowState.OriginalRows);
        if (this.loadIndex != null)
          this.loadIndex.AddRef();
      }
      if (this.DataSet != null)
      {
        this.savedEnforceConstraints = this.DataSet.EnforceConstraints;
        this.DataSet.EnforceConstraints = false;
      }
      else
        this.EnforceConstraints = false;
    }

    public void EndLoadData()
    {
      if (!this.inDataLoad)
        return;
      if (this.loadIndex != null)
        this.loadIndex.RemoveRef();
      if (this.loadIndexwithOriginalAdded != null)
        this.loadIndexwithOriginalAdded.RemoveRef();
      if (this.loadIndexwithCurrentDeleted != null)
        this.loadIndexwithCurrentDeleted.RemoveRef();
      this.loadIndex = (Index) null;
      this.loadIndexwithOriginalAdded = (Index) null;
      this.loadIndexwithCurrentDeleted = (Index) null;
      this.inDataLoad = false;
      this.RestoreIndexEvents(false);
      if (this.DataSet != null)
        this.DataSet.EnforceConstraints = this.savedEnforceConstraints;
      else
        this.EnforceConstraints = true;
    }

    public DataRow LoadDataRow(object[] values, bool fAcceptChanges)
    {
      if (this.inDataLoad)
      {
        int num = this.NewRecordFromArray(values);
        if (this.loadIndex != null)
        {
          Debug.Assert(2 <= this.loadIndex.RefCount, "bad loadIndex.RefCount");
          int record = this.loadIndex.FindRecord(num);
          if (record != -1)
          {
            DataRow row1 = this.recordManager[this.loadIndex.GetRecord(record)];
            Debug.Assert(row1 != null, "Row can't be null for index record");
            row1.CancelEdit();
            if (row1.RowState == DataRowState.Deleted)
            {
              DataRow row2 = row1;
              this.SetNewRecord(row2, row2.oldRecord, DataRowAction.Rollback, false, true);
            }
            this.SetNewRecord(row1, num, DataRowAction.Change, false, true);
            if (fAcceptChanges)
              row1.AcceptChanges();
            return row1;
          }
        }
        DataRow row = this.NewRow(num);
        this.AddRow(row);
        if (fAcceptChanges)
          row.AcceptChanges();
        return row;
      }
      DataRow dataRow = this.UpdatingAdd(values);
      if (fAcceptChanges)
        dataRow.AcceptChanges();
      return dataRow;
    }

    public DataRow LoadDataRow(object[] values, LoadOption loadOption)
    {
      Index searchIndex = (Index) null;
      if (this.primaryKey != null)
      {
        if (loadOption == LoadOption.Upsert)
        {
          if (this.loadIndexwithCurrentDeleted == null)
          {
            this.loadIndexwithCurrentDeleted = this.primaryKey.Key.GetSortIndex(DataViewRowState.CurrentRows | DataViewRowState.Deleted);
            Debug.Assert(this.loadIndexwithCurrentDeleted != null, "loadIndexwithCurrentDeleted should not be null");
            if (this.loadIndexwithCurrentDeleted != null)
              this.loadIndexwithCurrentDeleted.AddRef();
          }
          searchIndex = this.loadIndexwithCurrentDeleted;
        }
        else
        {
          if (this.loadIndexwithOriginalAdded == null)
          {
            this.loadIndexwithOriginalAdded = this.primaryKey.Key.GetSortIndex(DataViewRowState.OriginalRows | DataViewRowState.Added);
            Debug.Assert(this.loadIndexwithOriginalAdded != null, "loadIndexwithOriginalAdded should not be null");
            if (this.loadIndexwithOriginalAdded != null)
              this.loadIndexwithOriginalAdded.AddRef();
          }
          searchIndex = this.loadIndexwithOriginalAdded;
        }
        Debug.Assert(2 <= searchIndex.RefCount, "bad indextoUse.RefCount");
      }
      if (this.inDataLoad && !this.AreIndexEventsSuspended)
        this.SuspendIndexEvents();
      return this.LoadRow(values, loadOption, searchIndex);
    }

    internal DataRow UpdatingAdd(object[] values)
    {
      Index index = (Index) null;
      if (this.primaryKey != null)
        index = this.primaryKey.Key.GetSortIndex(DataViewRowState.OriginalRows);
      if (index == null)
        return this.Rows.Add(values);
      int record1 = this.NewRecordFromArray(values);
      int record2 = index.FindRecord(record1);
      if (record2 != -1)
      {
        DataRow dataRow = this.recordManager[index.GetRecord(record2)];
        Debug.Assert(dataRow != null, "Row can't be null for index record");
        dataRow.RejectChanges();
        dataRow.SetNewRecord(record1);
        return dataRow;
      }
      DataRow row = this.NewRow(record1);
      this.Rows.Add(row);
      return row;
    }

    internal bool UpdatingCurrent(DataRow row, DataRowAction action) => action == DataRowAction.Add || action == DataRowAction.Change || (action == DataRowAction.Rollback || action == DataRowAction.ChangeOriginal) || action == DataRowAction.ChangeCurrentAndOriginal;

    public void Merge(DataTable table) => this.Merge(table, false, MissingSchemaAction.Add);

    public void Merge(DataTable table, bool preserveChanges) => this.Merge(table, preserveChanges, MissingSchemaAction.Add);

    public void Merge(
      DataTable table,
      bool preserveChanges,
      MissingSchemaAction missingSchemaAction)
    {
      if (table == null)
        throw ExceptionBuilder.ArgumentNull(nameof (table));
      switch (missingSchemaAction)
      {
        case MissingSchemaAction.Add:
        case MissingSchemaAction.Ignore:
        case MissingSchemaAction.Error:
        case MissingSchemaAction.AddWithKey:
          new Merger(this, preserveChanges, missingSchemaAction).MergeTable(table);
          break;
        default:
          throw ADP.InvalidMissingSchemaAction(missingSchemaAction);
      }
    }

    public void Load(IDataReader reader) => this.Load(reader, LoadOption.PreserveChanges, (FillErrorEventHandler) null);

    public void Load(IDataReader reader, LoadOption loadOption) => this.Load(reader, loadOption, (FillErrorEventHandler) null);

    public virtual void Load(
      IDataReader reader,
      LoadOption loadOption,
      FillErrorEventHandler errorHandler)
    {
      if (this.PrimaryKey.Length == 0 && reader is DataTableReader dataTableReader && dataTableReader.CurrentDataTable == this)
        return;
      LoadAdapter loadAdapter = new LoadAdapter();
      loadAdapter.FillLoadOption = loadOption;
      loadAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
      if (errorHandler != null)
        loadAdapter.FillError += errorHandler;
      loadAdapter.FillFromReader(new DataTable[1]{ this }, reader, 0, 0);
      if (reader.IsClosed || reader.NextResult())
        return;
      reader.Close();
    }

    private DataRow LoadRow(object[] values, LoadOption loadOption, Index searchIndex)
    {
      DataRow dataRow1 = (DataRow) null;
      if (searchIndex != null)
      {
        int[] numArray = new int[0];
        if (this.primaryKey != null)
        {
          numArray = new int[this.primaryKey.ColumnsReference.Length];
          for (int index = 0; index < this.primaryKey.ColumnsReference.Length; ++index)
            numArray[index] = this.primaryKey.ColumnsReference[index].Ordinal;
        }
        object[] key = new object[numArray.Length];
        for (int index = 0; index < numArray.Length; ++index)
          key[index] = values[numArray[index]];
        Range records = searchIndex.FindRecords(key);
        if (!records.IsNull)
        {
          int num1 = 0;
          for (int min = records.Min; min <= records.Max; ++min)
          {
            int record = searchIndex.GetRecord(min);
            dataRow1 = this.recordManager[record];
            int num2 = this.NewRecordFromArray(values);
            for (int index = 0; index < values.Length; ++index)
            {
              if (values[index] == null)
                this.columnCollection[index].Copy(record, num2);
            }
            for (int length = values.Length; length < this.columnCollection.Count; ++length)
              this.columnCollection[length].Copy(record, num2);
            if (loadOption != LoadOption.Upsert || dataRow1.RowState != DataRowState.Deleted)
              this.SetDataRowWithLoadOption(dataRow1, num2, loadOption, true);
            else
              ++num1;
          }
          if (num1 == 0)
            return dataRow1;
        }
      }
      int num = this.NewRecordFromArray(values);
      DataRow dataRow2 = this.NewRow(num);
      DataRowAction eAction;
      switch (loadOption)
      {
        case LoadOption.OverwriteChanges:
        case LoadOption.PreserveChanges:
          eAction = DataRowAction.ChangeCurrentAndOriginal;
          break;
        case LoadOption.Upsert:
          eAction = DataRowAction.Add;
          break;
        default:
          throw ExceptionBuilder.ArgumentOutOfRange("LoadOption");
      }
      DataRowChangeEventArgs args = this.RaiseRowChanging((DataRowChangeEventArgs) null, dataRow2, eAction);
      this.InsertRow(dataRow2, -1, -1, false);
      switch (loadOption)
      {
        case LoadOption.OverwriteChanges:
        case LoadOption.PreserveChanges:
          this.SetOldRecord(dataRow2, num);
          goto case LoadOption.Upsert;
        case LoadOption.Upsert:
          this.RaiseRowChanged(args, dataRow2, eAction);
          return dataRow2;
        default:
          throw ExceptionBuilder.ArgumentOutOfRange("LoadOption");
      }
    }

    private void SetDataRowWithLoadOption(
      DataRow dataRow,
      int recordNo,
      LoadOption loadOption,
      bool checkReadOnly)
    {
      bool flag = false;
      if (checkReadOnly)
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this.Columns)
        {
          if (column.ReadOnly && !column.Computed)
          {
            switch (loadOption)
            {
              case LoadOption.OverwriteChanges:
                if (dataRow[column, DataRowVersion.Current] != column[recordNo] || dataRow[column, DataRowVersion.Original] != column[recordNo])
                {
                  flag = true;
                  continue;
                }
                continue;
              case LoadOption.PreserveChanges:
                if (dataRow[column, DataRowVersion.Original] != column[recordNo])
                {
                  flag = true;
                  continue;
                }
                continue;
              case LoadOption.Upsert:
                if (dataRow[column, DataRowVersion.Current] != column[recordNo])
                {
                  flag = true;
                  continue;
                }
                continue;
              default:
                continue;
            }
          }
        }
      }
      DataRowChangeEventArgs args1 = (DataRowChangeEventArgs) null;
      DataRowAction eAction = DataRowAction.Nothing;
      int tempRecord = dataRow.tempRecord;
      dataRow.tempRecord = recordNo;
      switch (loadOption)
      {
        case LoadOption.OverwriteChanges:
          eAction = DataRowAction.ChangeCurrentAndOriginal;
          break;
        case LoadOption.PreserveChanges:
          eAction = dataRow.RowState != DataRowState.Unchanged ? DataRowAction.ChangeOriginal : DataRowAction.ChangeCurrentAndOriginal;
          break;
        case LoadOption.Upsert:
          switch (dataRow.RowState)
          {
            case DataRowState.Unchanged:
              IEnumerator enumerator = dataRow.Table.Columns.GetEnumerator();
              try
              {
                while (enumerator.MoveNext())
                {
                  if (((DataColumn) enumerator.Current).Compare(dataRow.newRecord, recordNo) != 0)
                  {
                    eAction = DataRowAction.Change;
                    break;
                  }
                }
                break;
              }
              finally
              {
                if (enumerator is IDisposable disposable4)
                  disposable4.Dispose();
              }
            case DataRowState.Deleted:
              Debug.Assert(false, "LoadOption.Upsert with deleted row, should not be here");
              break;
            default:
              eAction = DataRowAction.Change;
              break;
          }
          break;
        default:
          throw ExceptionBuilder.ArgumentOutOfRange("LoadOption");
      }
      try
      {
        args1 = this.RaiseRowChanging((DataRowChangeEventArgs) null, dataRow, eAction);
        if (eAction == DataRowAction.Nothing)
        {
          dataRow.inChangingEvent = true;
          try
          {
            args1 = this.OnRowChanging(args1, dataRow, eAction);
          }
          finally
          {
            dataRow.inChangingEvent = false;
          }
        }
      }
      finally
      {
        Debug.Assert(dataRow.tempRecord == recordNo, "tempRecord has been changed in event handler");
        if (DataRowState.Detached == dataRow.RowState)
        {
          if (-1 != tempRecord)
            this.FreeRecord(ref tempRecord);
        }
        else if (dataRow.tempRecord != recordNo)
        {
          if (-1 != tempRecord)
            this.FreeRecord(ref tempRecord);
          if (-1 != recordNo)
            this.FreeRecord(ref recordNo);
          recordNo = dataRow.tempRecord;
        }
        else
          dataRow.tempRecord = tempRecord;
      }
      if (dataRow.tempRecord != -1)
        dataRow.CancelEdit();
      switch (loadOption)
      {
        case LoadOption.OverwriteChanges:
          this.SetNewRecord(dataRow, recordNo, DataRowAction.Change, false, false);
          this.SetOldRecord(dataRow, recordNo);
          break;
        case LoadOption.PreserveChanges:
          if (dataRow.RowState == DataRowState.Unchanged)
          {
            this.SetOldRecord(dataRow, recordNo);
            this.SetNewRecord(dataRow, recordNo, DataRowAction.Change, false, false);
            break;
          }
          this.SetOldRecord(dataRow, recordNo);
          break;
        case LoadOption.Upsert:
          if (dataRow.RowState == DataRowState.Unchanged)
          {
            this.SetNewRecord(dataRow, recordNo, DataRowAction.Change, false, false);
            if (!dataRow.HasChanges())
            {
              this.SetOldRecord(dataRow, recordNo);
              break;
            }
            break;
          }
          if (dataRow.RowState == DataRowState.Deleted)
            dataRow.RejectChanges();
          this.SetNewRecord(dataRow, recordNo, DataRowAction.Change, false, false);
          break;
        default:
          throw ExceptionBuilder.ArgumentOutOfRange("LoadOption");
      }
      if (flag)
      {
        // ISSUE: reference to a compiler-generated method
        string error = Res.GetString("Load_ReadOnlyDataModified");
        if (dataRow.RowError.Length == 0)
        {
          dataRow.RowError = error;
        }
        else
        {
          DataRow dataRow1 = dataRow;
          dataRow1.RowError = dataRow1.RowError + " ]:[ " + error;
        }
        foreach (DataColumn column in (InternalDataCollectionBase) this.Columns)
        {
          if (column.ReadOnly && !column.Computed)
            dataRow.SetColumnError(column, error);
        }
      }
      DataRowChangeEventArgs args2 = this.RaiseRowChanged(args1, dataRow, eAction);
      if (eAction != DataRowAction.Nothing)
        return;
      dataRow.inChangingEvent = true;
      try
      {
        this.OnRowChanged(args2, dataRow, eAction);
      }
      finally
      {
        dataRow.inChangingEvent = false;
      }
    }

    public DataTableReader CreateDataReader() => new DataTableReader(this);

    private void CreateTableList(DataTable currentTable, List<DataTable> tableList)
    {
      foreach (DataRelation childRelation in (InternalDataCollectionBase) currentTable.ChildRelations)
      {
        if (!tableList.Contains(childRelation.ChildTable))
        {
          tableList.Add(childRelation.ChildTable);
          this.CreateTableList(childRelation.ChildTable, tableList);
        }
      }
    }

    private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList)
    {
      foreach (DataTable table in tableList)
      {
        foreach (DataRelation childRelation in (InternalDataCollectionBase) table.ChildRelations)
        {
          if (tableList.Contains(childRelation.ChildTable) && tableList.Contains(childRelation.ParentTable))
            relationList.Add(childRelation);
        }
      }
    }

    internal Microsoft.Phone.Data.Workaround.Hashtable RowDiffId
    {
      get
      {
        if (this.rowDiffId == null)
          this.rowDiffId = new Microsoft.Phone.Data.Workaround.Hashtable();
        return this.rowDiffId;
      }
    }

    internal void AddDependentColumn(DataColumn expressionColumn)
    {
      if (this.dependentColumns == null)
        this.dependentColumns = new List<DataColumn>();
      if (this.dependentColumns.Contains(expressionColumn))
        return;
      this.dependentColumns.Add(expressionColumn);
    }

    internal void RemoveDependentColumn(DataColumn expressionColumn)
    {
      if (this.dependentColumns == null || !this.dependentColumns.Contains(expressionColumn))
        return;
      this.dependentColumns.Remove(expressionColumn);
    }

    internal void EvaluateExpressions()
    {
      if (this.dependentColumns == null || 0 >= this.dependentColumns.Count)
        return;
      foreach (DataRow row in (InternalDataCollectionBase) this.Rows)
      {
        if (row.oldRecord != -1 && row.oldRecord != row.newRecord)
          this.EvaluateDependentExpressions(this.dependentColumns, row, DataRowVersion.Original, (List<DataRow>) null);
        if (row.newRecord != -1)
          this.EvaluateDependentExpressions(this.dependentColumns, row, DataRowVersion.Current, (List<DataRow>) null);
        if (row.tempRecord != -1)
          this.EvaluateDependentExpressions(this.dependentColumns, row, DataRowVersion.Proposed, (List<DataRow>) null);
      }
    }

    internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows)
    {
      switch (action)
      {
        case DataRowAction.Delete:
          if (this.dependentColumns == null)
            break;
          foreach (DataColumn dependentColumn in this.dependentColumns)
          {
            if (dependentColumn.DataExpression != null && dependentColumn.DataExpression.HasLocalAggregate() && dependentColumn.Table == this)
            {
              for (int index = 0; index < this.Rows.Count; ++index)
              {
                DataRow row1 = this.Rows[index];
                if (row1.oldRecord != -1 && row1.oldRecord != row1.newRecord)
                  this.EvaluateDependentExpressions(this.dependentColumns, row1, DataRowVersion.Original, (List<DataRow>) null);
                if (row1.newRecord != -1)
                  this.EvaluateDependentExpressions(this.dependentColumns, row1, DataRowVersion.Current, (List<DataRow>) null);
                if (row1.tempRecord != -1)
                  this.EvaluateDependentExpressions(this.dependentColumns, row1, DataRowVersion.Proposed, (List<DataRow>) null);
              }
              break;
            }
          }
          using (List<DataRow>.Enumerator enumerator = cachedRows.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              DataRow current = enumerator.Current;
              if (current.oldRecord != -1 && current.oldRecord != current.newRecord)
                current.Table.EvaluateDependentExpressions(current.Table.dependentColumns, current, DataRowVersion.Original, (List<DataRow>) null);
              if (current.newRecord != -1)
                current.Table.EvaluateDependentExpressions(current.Table.dependentColumns, current, DataRowVersion.Current, (List<DataRow>) null);
              if (current.tempRecord != -1)
                current.Table.EvaluateDependentExpressions(current.Table.dependentColumns, current, DataRowVersion.Proposed, (List<DataRow>) null);
            }
            break;
          }
        case DataRowAction.Change:
        case DataRowAction.Rollback:
        case DataRowAction.Add:
          if (row.oldRecord != -1 && row.oldRecord != row.newRecord)
            this.EvaluateDependentExpressions(this.dependentColumns, row, DataRowVersion.Original, cachedRows);
          if (row.newRecord != -1)
            this.EvaluateDependentExpressions(this.dependentColumns, row, DataRowVersion.Current, cachedRows);
          if (row.tempRecord == -1)
            break;
          this.EvaluateDependentExpressions(this.dependentColumns, row, DataRowVersion.Proposed, cachedRows);
          break;
      }
    }

    internal void EvaluateExpressions(DataColumn column)
    {
      Debug.Assert(column.Computed, "Only computed columns should be re-evaluated.");
      int count = column.table.Rows.Count;
      if (column.DataExpression.IsTableAggregate() && count > 0)
      {
        object obj = column.DataExpression.Evaluate();
        for (int index = 0; index < count; ++index)
        {
          DataRow row = column.table.Rows[index];
          if (row.oldRecord != -1 && row.oldRecord != row.newRecord)
            column[row.oldRecord] = obj;
          if (row.newRecord != -1)
            column[row.newRecord] = obj;
          if (row.tempRecord != -1)
            column[row.tempRecord] = obj;
        }
      }
      else
      {
        for (int index = 0; index < count; ++index)
        {
          DataRow row = column.table.Rows[index];
          if (row.oldRecord != -1 && row.oldRecord != row.newRecord)
            column[row.oldRecord] = column.DataExpression.Evaluate(row, DataRowVersion.Original);
          if (row.newRecord != -1)
            column[row.newRecord] = column.DataExpression.Evaluate(row, DataRowVersion.Current);
          if (row.tempRecord != -1)
            column[row.tempRecord] = column.DataExpression.Evaluate(row, DataRowVersion.Proposed);
        }
      }
      column.Table.ResetInternalIndexes(column);
      this.EvaluateDependentExpressions(column);
    }

    internal void EvaluateDependentExpressions(DataColumn column)
    {
      if (column.dependentColumns == null)
        return;
      foreach (DataColumn dependentColumn in column.dependentColumns)
      {
        if (dependentColumn.table != null && column != dependentColumn)
          this.EvaluateExpressions(dependentColumn);
      }
    }

    internal void EvaluateDependentExpressions(
      List<DataColumn> columns,
      DataRow row,
      DataRowVersion version,
      List<DataRow> cachedRows)
    {
      if (columns == null)
        return;
      int count1 = columns.Count;
      for (int index1 = 0; index1 < count1; ++index1)
      {
        if (columns[index1].Table == this)
        {
          DataColumn column = columns[index1];
          if (column.DataExpression != null && column.DataExpression.HasLocalAggregate())
          {
            DataRowVersion version1 = version == DataRowVersion.Proposed ? DataRowVersion.Default : version;
            bool flag = column.DataExpression.IsTableAggregate();
            object newValue = (object) null;
            if (flag)
              newValue = column.DataExpression.Evaluate(row, version1);
            for (int index2 = 0; index2 < this.Rows.Count; ++index2)
            {
              DataRow row1 = this.Rows[index2];
              if (row1.RowState != DataRowState.Deleted && (version1 != DataRowVersion.Original || row1.oldRecord != -1 && row1.oldRecord != row1.newRecord))
              {
                if (!flag)
                  newValue = column.DataExpression.Evaluate(row1, version1);
                this.SilentlySetValue(row1, column, version1, newValue);
              }
            }
          }
          else if (row.RowState != DataRowState.Deleted && (version != DataRowVersion.Original || row.oldRecord != -1 && row.oldRecord != row.newRecord))
            this.SilentlySetValue(row, column, version, column.DataExpression == null ? column.DefaultValue : column.DataExpression.Evaluate(row, version));
        }
      }
      int count2 = columns.Count;
      for (int index1 = 0; index1 < count2; ++index1)
      {
        DataColumn column = columns[index1];
        if (column.Table != this || column.DataExpression != null && !column.DataExpression.HasLocalAggregate())
        {
          DataRowVersion version1 = version == DataRowVersion.Proposed ? DataRowVersion.Default : version;
          if (cachedRows != null)
          {
            foreach (DataRow cachedRow in cachedRows)
            {
              if (cachedRow.Table == column.Table && (version1 != DataRowVersion.Original || cachedRow.newRecord != cachedRow.oldRecord) && (cachedRow != null && cachedRow.RowState != DataRowState.Deleted && (version != DataRowVersion.Original || cachedRow.oldRecord != -1)))
              {
                object newValue = column.DataExpression.Evaluate(cachedRow, version1);
                this.SilentlySetValue(cachedRow, column, version1, newValue);
              }
            }
          }
          for (int index2 = 0; index2 < this.ParentRelations.Count; ++index2)
          {
            DataRelation parentRelation = this.ParentRelations[index2];
            if (parentRelation.ParentTable == column.Table)
            {
              foreach (DataRow parentRow in row.GetParentRows(parentRelation, version))
              {
                if ((cachedRows == null || !cachedRows.Contains(parentRow)) && (version1 != DataRowVersion.Original || parentRow.newRecord != parentRow.oldRecord) && (parentRow != null && parentRow.RowState != DataRowState.Deleted && (version != DataRowVersion.Original || parentRow.oldRecord != -1)))
                {
                  object newValue = column.DataExpression.Evaluate(parentRow, version1);
                  this.SilentlySetValue(parentRow, column, version1, newValue);
                }
              }
            }
          }
          for (int index2 = 0; index2 < this.ChildRelations.Count; ++index2)
          {
            DataRelation childRelation = this.ChildRelations[index2];
            if (childRelation.ChildTable == column.Table)
            {
              foreach (DataRow childRow in row.GetChildRows(childRelation, version))
              {
                if ((cachedRows == null || !cachedRows.Contains(childRow)) && (version1 != DataRowVersion.Original || childRow.newRecord != childRow.oldRecord) && (childRow != null && childRow.RowState != DataRowState.Deleted && (version != DataRowVersion.Original || childRow.oldRecord != -1)))
                {
                  object newValue = column.DataExpression.Evaluate(childRow, version1);
                  this.SilentlySetValue(childRow, column, version1, newValue);
                }
              }
            }
          }
        }
      }
    }
  }
}
