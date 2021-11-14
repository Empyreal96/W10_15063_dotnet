// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataSet
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

namespace Microsoft.Phone.Data
{
  public class DataSet : MarshalByValueComponent
  {
    private DataViewManager defaultViewManager;
    private readonly DataTableCollection tableCollection;
    private readonly DataRelationCollection relationCollection;
    internal PropertyCollection extendedProperties;
    private string dataSetName = "NewDataSet";
    private string _datasetPrefix = string.Empty;
    internal string namespaceURI = string.Empty;
    private bool enforceConstraints = true;
    private const string KEY_XMLSCHEMA = "XmlSchema";
    private const string KEY_XMLDIFFGRAM = "XmlDiffGram";
    private bool _caseSensitive;
    private CultureInfo _culture;
    private bool _cultureUserSet;
    internal bool fInReadXml;
    internal bool fInLoadDiffgram;
    internal bool fTopLevelTable;
    internal bool fInitInProgress;
    internal bool fEnableCascading = true;
    internal bool fIsSchemaLoading;
    private MergeFailedEventHandler onMergeFailed;
    private EventHandler onInitialized;
    internal static readonly DataTable[] zeroTables = new DataTable[0];
    internal string mainTableName = "";
    private object _defaultViewManagerLock = new object();

    public DataSet()
    {
      GC.SuppressFinalize((object) this);
      this.tableCollection = new DataTableCollection(this);
      this.relationCollection = (DataRelationCollection) new DataRelationCollection.DataSetRelationCollection(this);
      this._culture = CultureInfo.CurrentCulture;
    }

    public DataSet(string dataSetName)
      : this()
    {
      this.DataSetName = dataSetName;
    }

    public virtual SchemaSerializationMode SchemaSerializationMode
    {
      get => SchemaSerializationMode.IncludeSchema;
      set
      {
        if (value != SchemaSerializationMode.IncludeSchema)
          throw ExceptionBuilder.CannotChangeSchemaSerializationMode();
      }
    }

    protected virtual void InitializeDerivedDataSet()
    {
    }

    internal void FailedEnableConstraints()
    {
      this.EnforceConstraints = false;
      throw ExceptionBuilder.EnforceConstraint();
    }

    public bool CaseSensitive
    {
      get => this._caseSensitive;
      set
      {
        if (this._caseSensitive == value)
          return;
        bool caseSensitive = this._caseSensitive;
        this._caseSensitive = value;
        if (!this.ValidateCaseConstraint())
        {
          this._caseSensitive = caseSensitive;
          throw ExceptionBuilder.CannotChangeCaseLocale();
        }
        foreach (DataTable table in (InternalDataCollectionBase) this.Tables)
          table.SetCaseSensitiveValue(value, false, true);
      }
    }

    public DataViewManager DefaultViewManager
    {
      get
      {
        if (this.defaultViewManager == null)
        {
          lock (this._defaultViewManagerLock)
          {
            if (this.defaultViewManager == null)
              this.defaultViewManager = new DataViewManager(this, true);
          }
        }
        return this.defaultViewManager;
      }
    }

    public bool EnforceConstraints
    {
      get => this.enforceConstraints;
      set
      {
        if (this.enforceConstraints == value)
          return;
        if (value)
          this.EnableConstraints();
        this.enforceConstraints = value;
      }
    }

    internal void RestoreEnforceConstraints(bool value) => this.enforceConstraints = value;

    internal void EnableConstraints()
    {
      bool flag = false;
      ConstraintEnumerator constraintEnumerator = new ConstraintEnumerator(this);
      while (constraintEnumerator.GetNext())
      {
        Constraint constraint = constraintEnumerator.GetConstraint();
        flag |= constraint.IsConstraintViolated();
      }
      foreach (DataTable table in (InternalDataCollectionBase) this.Tables)
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
        {
          if (!column.AllowDBNull)
            flag |= column.IsNotAllowDBNullViolated();
          if (column.MaxLength >= 0)
            flag |= column.IsMaxLengthViolated();
        }
      }
      if (!flag)
        return;
      this.FailedEnableConstraints();
    }

    public string DataSetName
    {
      get => this.dataSetName;
      set
      {
        if (!(value != this.dataSetName))
          return;
        switch (value)
        {
          case "":
          case null:
            throw ExceptionBuilder.SetDataSetNameToEmpty();
          default:
            DataTable table = this.Tables[value, this.Namespace];
            if (table != null && !table.fNestedInDataset)
              throw ExceptionBuilder.SetDataSetNameConflicting(value);
            this.RaisePropertyChanging(nameof (DataSetName));
            this.dataSetName = value;
            break;
        }
      }
    }

    public string Namespace
    {
      get => this.namespaceURI;
      set
      {
        if (value == null)
          value = string.Empty;
        if (!(value != this.namespaceURI))
          return;
        this.RaisePropertyChanging(nameof (Namespace));
        foreach (DataTable table in (InternalDataCollectionBase) this.Tables)
        {
          if (table.tableNamespace == null && (table.NestedParentRelations.Length == 0 || table.NestedParentRelations.Length == 1 && table.NestedParentRelations[0].ChildTable == table))
          {
            if (this.Tables.Contains(table.TableName, value, false, true))
              throw ExceptionBuilder.DuplicateTableName2(table.TableName, value);
            table.CheckCascadingNamespaceConflict(value);
            table.DoRaiseNamespaceChange();
          }
        }
        this.namespaceURI = value;
        if (!ADP.IsEmpty(value))
          return;
        this._datasetPrefix = string.Empty;
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

    public bool HasErrors
    {
      get
      {
        for (int index = 0; index < this.Tables.Count; ++index)
        {
          if (this.Tables[index].HasErrors)
            return true;
        }
        return false;
      }
    }

    public bool IsInitialized => !this.fInitInProgress;

    public CultureInfo Locale
    {
      get
      {
        Debug.Assert(this._culture != null, "DataSet.Locale: null culture");
        return this._culture;
      }
      set
      {
        if (value == null)
          return;
        if (!this._culture.Equals((object) value))
          this.SetLocaleValue(value, true);
        this._cultureUserSet = true;
      }
    }

    internal void SetLocaleValue(CultureInfo value, bool userSet)
    {
      bool flag1 = false;
      bool flag2 = false;
      int num = 0;
      CultureInfo culture = this._culture;
      bool cultureUserSet = this._cultureUserSet;
      try
      {
        this._culture = value;
        this._cultureUserSet = userSet;
        foreach (DataTable table in (InternalDataCollectionBase) this.Tables)
        {
          if (!table.ShouldSerializeLocale())
            table.SetLocaleValue(value, false, false);
        }
        flag1 = this.ValidateLocaleConstraint();
        if (!flag1)
          return;
        flag1 = false;
        foreach (DataTable table in (InternalDataCollectionBase) this.Tables)
        {
          ++num;
          if (!table.ShouldSerializeLocale())
            table.SetLocaleValue(value, false, true);
        }
        flag1 = true;
      }
      catch
      {
        flag2 = true;
        throw;
      }
      finally
      {
        if (!flag1)
        {
          this._culture = culture;
          this._cultureUserSet = cultureUserSet;
          foreach (DataTable table in (InternalDataCollectionBase) this.Tables)
          {
            if (!table.ShouldSerializeLocale())
              table.SetLocaleValue(culture, false, false);
          }
          try
          {
            for (int index = 0; index < num; ++index)
            {
              if (!this.Tables[index].ShouldSerializeLocale())
                this.Tables[index].SetLocaleValue(culture, false, true);
            }
          }
          catch (Exception ex)
          {
            if (!ADP.IsCatchableExceptionType(ex))
              throw;
            else
              ADP.TraceExceptionWithoutRethrow(ex);
          }
          if (!flag2)
            throw ExceptionBuilder.CannotChangeCaseLocale((Exception) null);
        }
      }
    }

    internal bool ShouldSerializeLocale() => this._cultureUserSet;

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
            for (int index = 0; index < this.Tables.Count; ++index)
            {
              if (this.Tables[index].Site != null)
                container.Remove((IComponent) this.Tables[index]);
            }
          }
        }
        base.Site = value;
      }
    }

    public DataRelationCollection Relations => this.relationCollection;

    protected virtual bool ShouldSerializeRelations() => true;

    public DataTableCollection Tables => this.tableCollection;

    protected virtual bool ShouldSerializeTables() => true;

    public void AcceptChanges()
    {
      for (int index = 0; index < this.Tables.Count; ++index)
        this.Tables[index].AcceptChanges();
    }

    public event MergeFailedEventHandler MergeFailed
    {
      add => this.onMergeFailed += value;
      remove => this.onMergeFailed -= value;
    }

    public event EventHandler Initialized
    {
      add => this.onInitialized += value;
      remove => this.onInitialized -= value;
    }

    public void BeginInit() => this.fInitInProgress = true;

    public void EndInit()
    {
      this.Tables.FinishInitCollection();
      for (int index = 0; index < this.Tables.Count; ++index)
        this.Tables[index].Columns.FinishInitCollection();
      for (int index = 0; index < this.Tables.Count; ++index)
        this.Tables[index].Constraints.FinishInitConstraints();
      ((DataRelationCollection.DataSetRelationCollection) this.Relations).FinishInitRelations();
      this.fInitInProgress = false;
      this.OnInitialized();
    }

    public void Clear()
    {
      bool enforceConstraints = this.EnforceConstraints;
      this.EnforceConstraints = false;
      for (int index = 0; index < this.Tables.Count; ++index)
        this.Tables[index].Clear();
      this.EnforceConstraints = enforceConstraints;
    }

    public virtual DataSet Clone()
    {
      DataSet instance = (DataSet) Activator.CreateInstance(this.GetType());
      if (instance.Tables.Count > 0)
        instance.Reset();
      instance.DataSetName = this.DataSetName;
      instance.CaseSensitive = this.CaseSensitive;
      instance._culture = this._culture;
      instance._cultureUserSet = this._cultureUserSet;
      instance.EnforceConstraints = this.EnforceConstraints;
      instance.Namespace = this.Namespace;
      instance.fIsSchemaLoading = true;
      DataTableCollection tables = this.Tables;
      for (int index = 0; index < tables.Count; ++index)
      {
        DataTable table = tables[index].Clone(instance);
        table.tableNamespace = tables[index].Namespace;
        instance.Tables.Add(table);
      }
      for (int index1 = 0; index1 < tables.Count; ++index1)
      {
        ConstraintCollection constraints = tables[index1].Constraints;
        for (int index2 = 0; index2 < constraints.Count; ++index2)
        {
          if (!(constraints[index2] is UniqueConstraint))
          {
            ForeignKeyConstraint foreignKeyConstraint = constraints[index2] as ForeignKeyConstraint;
            if (foreignKeyConstraint.Table != foreignKeyConstraint.RelatedTable)
              instance.Tables[index1].Constraints.Add(constraints[index2].Clone(instance));
          }
        }
      }
      DataRelationCollection relations = this.Relations;
      for (int index = 0; index < relations.Count; ++index)
      {
        DataRelation relation = relations[index].Clone(instance);
        relation.CheckMultipleNested = false;
        instance.Relations.Add(relation);
        relation.CheckMultipleNested = true;
      }
      if (this.extendedProperties != null)
      {
        foreach (object key in (IEnumerable) this.extendedProperties.Keys)
          instance.ExtendedProperties[key] = this.extendedProperties[key];
      }
      foreach (DataTable table in (InternalDataCollectionBase) this.Tables)
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
        {
          if (column.Expression.Length != 0)
            instance.Tables[table.TableName, table.Namespace].Columns[column.ColumnName].Expression = column.Expression;
        }
      }
      for (int index = 0; index < tables.Count; ++index)
        instance.Tables[index].tableNamespace = tables[index].tableNamespace;
      instance.fIsSchemaLoading = false;
      return instance;
    }

    public DataSet Copy()
    {
      DataSet dataSet = this.Clone();
      bool enforceConstraints = dataSet.EnforceConstraints;
      dataSet.EnforceConstraints = false;
      foreach (DataTable table1 in (InternalDataCollectionBase) this.Tables)
      {
        DataTable table2 = dataSet.Tables[table1.TableName, table1.Namespace];
        foreach (DataRow row in (InternalDataCollectionBase) table1.Rows)
          table1.CopyRow(table2, row);
      }
      dataSet.EnforceConstraints = enforceConstraints;
      return dataSet;
    }

    public DataSet GetChanges() => this.GetChanges(DataRowState.Added | DataRowState.Deleted | DataRowState.Modified);

    public DataSet GetChanges(DataRowState rowStates)
    {
      DataSet dataSet = (DataSet) null;
      bool flag = false;
      if ((rowStates & ~(DataRowState.Unchanged | DataRowState.Added | DataRowState.Deleted | DataRowState.Modified)) != (DataRowState) 0)
        throw ExceptionBuilder.InvalidRowState(rowStates);
      DataSet.TableChanges[] bitMatrix = new DataSet.TableChanges[this.Tables.Count];
      for (int index = 0; index < bitMatrix.Length; ++index)
        bitMatrix[index] = new DataSet.TableChanges(this.Tables[index].Rows.Count);
      this.MarkModifiedRows(bitMatrix, rowStates);
      for (int index1 = 0; index1 < bitMatrix.Length; ++index1)
      {
        Debug.Assert(0 <= bitMatrix[index1].HasChanges, "negative change count");
        if (0 < bitMatrix[index1].HasChanges)
        {
          if (dataSet == null)
          {
            dataSet = this.Clone();
            flag = dataSet.EnforceConstraints;
            dataSet.EnforceConstraints = false;
          }
          DataTable table1 = this.Tables[index1];
          DataTable table2 = dataSet.Tables[table1.TableName, table1.Namespace];
          Debug.Assert(bitMatrix[index1].HasChanges <= table1.Rows.Count, "to many changes");
          int index2 = 0;
          while (0 < bitMatrix[index1].HasChanges)
          {
            if (bitMatrix[index1][index2])
            {
              table1.CopyRow(table2, table1.Rows[index2]);
              --bitMatrix[index1].HasChanges;
            }
            ++index2;
          }
        }
      }
      if (dataSet != null)
        dataSet.EnforceConstraints = flag;
      return dataSet;
    }

    private void MarkModifiedRows(DataSet.TableChanges[] bitMatrix, DataRowState rowStates)
    {
      for (int index1 = 0; index1 < bitMatrix.Length; ++index1)
      {
        DataRowCollection rows = this.Tables[index1].Rows;
        int count = rows.Count;
        for (int index2 = 0; index2 < count; ++index2)
        {
          DataRow row = rows[index2];
          DataRowState rowState = row.RowState;
          Debug.Assert(DataRowState.Added == rowState || DataRowState.Deleted == rowState || DataRowState.Modified == rowState || DataRowState.Unchanged == rowState, "unexpected DataRowState");
          if ((rowStates & rowState) != (DataRowState) 0 && !bitMatrix[index1][index2])
          {
            bitMatrix[index1][index2] = true;
            if (DataRowState.Deleted != rowState)
              this.MarkRelatedRowsAsModified(bitMatrix, row);
          }
        }
      }
    }

    private void MarkRelatedRowsAsModified(DataSet.TableChanges[] bitMatrix, DataRow row)
    {
      DataRelationCollection parentRelations = row.Table.ParentRelations;
      int count = parentRelations.Count;
      for (int index1 = 0; index1 < count; ++index1)
      {
        foreach (DataRow parentRow in row.GetParentRows(parentRelations[index1], DataRowVersion.Current))
        {
          int index2 = this.Tables.IndexOf(parentRow.Table);
          int index3 = parentRow.Table.Rows.IndexOf(parentRow);
          if (!bitMatrix[index2][index3])
          {
            bitMatrix[index2][index3] = true;
            if (DataRowState.Deleted != parentRow.RowState)
              this.MarkRelatedRowsAsModified(bitMatrix, parentRow);
          }
        }
      }
    }

    public bool HasChanges() => this.HasChanges(DataRowState.Added | DataRowState.Deleted | DataRowState.Modified);

    public bool HasChanges(DataRowState rowStates)
    {
      if ((rowStates & ~(DataRowState.Detached | DataRowState.Unchanged | DataRowState.Added | DataRowState.Deleted | DataRowState.Modified)) != (DataRowState) 0)
        throw ExceptionBuilder.ArgumentOutOfRange("rowState");
      for (int index1 = 0; index1 < this.Tables.Count; ++index1)
      {
        DataTable table = this.Tables[index1];
        for (int index2 = 0; index2 < table.Rows.Count; ++index2)
        {
          if ((table.Rows[index2].RowState & rowStates) != (DataRowState) 0)
            return true;
        }
      }
      return false;
    }

    internal DataRelationCollection GetParentRelations(DataTable table) => table.ParentRelations;

    public void Merge(DataSet dataSet) => this.Merge(dataSet, false, MissingSchemaAction.Add);

    public void Merge(DataSet dataSet, bool preserveChanges) => this.Merge(dataSet, preserveChanges, MissingSchemaAction.Add);

    public void Merge(
      DataSet dataSet,
      bool preserveChanges,
      MissingSchemaAction missingSchemaAction)
    {
      if (dataSet == null)
        throw ExceptionBuilder.ArgumentNull(nameof (dataSet));
      switch (missingSchemaAction)
      {
        case MissingSchemaAction.Add:
        case MissingSchemaAction.Ignore:
        case MissingSchemaAction.Error:
        case MissingSchemaAction.AddWithKey:
          new Merger(this, preserveChanges, missingSchemaAction).MergeDataSet(dataSet);
          break;
        default:
          throw ADP.InvalidMissingSchemaAction(missingSchemaAction);
      }
    }

    public void Merge(DataTable table) => this.Merge(table, false, MissingSchemaAction.Add);

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

    public void Merge(DataRow[] rows) => this.Merge(rows, false, MissingSchemaAction.Add);

    public void Merge(
      DataRow[] rows,
      bool preserveChanges,
      MissingSchemaAction missingSchemaAction)
    {
      if (rows == null)
        throw ExceptionBuilder.ArgumentNull(nameof (rows));
      switch (missingSchemaAction)
      {
        case MissingSchemaAction.Add:
        case MissingSchemaAction.Ignore:
        case MissingSchemaAction.Error:
        case MissingSchemaAction.AddWithKey:
          new Merger(this, preserveChanges, missingSchemaAction).MergeRows(rows);
          break;
        default:
          throw ADP.InvalidMissingSchemaAction(missingSchemaAction);
      }
    }

    protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
    {
    }

    internal void OnMergeFailed(MergeFailedEventArgs mfevent)
    {
      if (this.onMergeFailed == null)
        throw ExceptionBuilder.MergeFailed(mfevent.Conflict);
      this.onMergeFailed((object) this, mfevent);
    }

    internal void RaiseMergeFailed(
      DataTable table,
      string conflict,
      MissingSchemaAction missingSchemaAction)
    {
      if (MissingSchemaAction.Error == missingSchemaAction)
        throw ExceptionBuilder.MergeFailed(conflict);
      this.OnMergeFailed(new MergeFailedEventArgs(table, conflict));
    }

    private void OnInitialized()
    {
      if (this.onInitialized == null)
        return;
      this.onInitialized((object) this, EventArgs.Empty);
    }

    protected internal virtual void OnRemoveTable(DataTable table)
    {
    }

    internal void OnRemovedTable(DataTable table) => this.defaultViewManager?.DataViewSettings.Remove(table);

    protected virtual void OnRemoveRelation(DataRelation relation)
    {
    }

    internal void OnRemoveRelationHack(DataRelation relation) => this.OnRemoveRelation(relation);

    protected internal void RaisePropertyChanging(string name) => this.OnPropertyChanging(new PropertyChangedEventArgs(name));

    internal DataTable[] TopLevelTables() => this.TopLevelTables(false);

    internal DataTable[] TopLevelTables(bool forSchema)
    {
      List<DataTable> dataTableList = new List<DataTable>();
      if (forSchema)
      {
        for (int index = 0; index < this.Tables.Count; ++index)
        {
          DataTable table = this.Tables[index];
          if (table.NestedParentsCount > 1 || table.SelfNested)
            dataTableList.Add(table);
        }
      }
      for (int index = 0; index < this.Tables.Count; ++index)
      {
        DataTable table = this.Tables[index];
        if (table.NestedParentsCount == 0 && !dataTableList.Contains(table))
          dataTableList.Add(table);
      }
      return dataTableList.Count == 0 ? DataSet.zeroTables : dataTableList.ToArray();
    }

    public virtual void RejectChanges()
    {
      bool enforceConstraints = this.EnforceConstraints;
      this.EnforceConstraints = false;
      for (int index = 0; index < this.Tables.Count; ++index)
        this.Tables[index].RejectChanges();
      this.EnforceConstraints = enforceConstraints;
    }

    public virtual void Reset()
    {
      for (int index1 = 0; index1 < this.Tables.Count; ++index1)
      {
        ConstraintCollection constraints = this.Tables[index1].Constraints;
        int index2 = 0;
        while (index2 < constraints.Count)
        {
          if (constraints[index2] is ForeignKeyConstraint)
          {
            ConstraintCollection constraintCollection = constraints;
            constraintCollection.Remove(constraintCollection[index2]);
          }
          else
            ++index2;
        }
      }
      this.Clear();
      this.Relations.Clear();
      this.Tables.Clear();
    }

    internal bool ValidateCaseConstraint()
    {
      for (int index = 0; index < this.Relations.Count; ++index)
      {
        DataRelation relation = this.Relations[index];
        if (relation.ChildTable.CaseSensitive != relation.ParentTable.CaseSensitive)
          return false;
      }
      for (int index1 = 0; index1 < this.Tables.Count; ++index1)
      {
        ConstraintCollection constraints = this.Tables[index1].Constraints;
        for (int index2 = 0; index2 < constraints.Count; ++index2)
        {
          if (constraints[index2] is ForeignKeyConstraint)
          {
            ForeignKeyConstraint foreignKeyConstraint = (ForeignKeyConstraint) constraints[index2];
            if (foreignKeyConstraint.Table.CaseSensitive != foreignKeyConstraint.RelatedTable.CaseSensitive)
              return false;
          }
        }
      }
      return true;
    }

    internal bool ValidateLocaleConstraint()
    {
      for (int index = 0; index < this.Relations.Count; ++index)
      {
        DataRelation relation = this.Relations[index];
        if (!CultureInfoCompareWorkaround.CultureEqual(relation.ChildTable.Locale, relation.ParentTable.Locale))
          return false;
      }
      for (int index1 = 0; index1 < this.Tables.Count; ++index1)
      {
        ConstraintCollection constraints = this.Tables[index1].Constraints;
        for (int index2 = 0; index2 < constraints.Count; ++index2)
        {
          if (constraints[index2] is ForeignKeyConstraint)
          {
            ForeignKeyConstraint foreignKeyConstraint = (ForeignKeyConstraint) constraints[index2];
            if (!CultureInfoCompareWorkaround.CultureEqual(foreignKeyConstraint.Table.Locale, foreignKeyConstraint.RelatedTable.Locale))
              return false;
          }
        }
      }
      return true;
    }

    public virtual void Load(
      IDataReader reader,
      LoadOption loadOption,
      FillErrorEventHandler errorHandler,
      params DataTable[] tables)
    {
      foreach (DataTable table in tables)
      {
        ADP.CheckArgumentNull((object) table, nameof (tables));
        if (table.DataSet != this)
          throw ExceptionBuilder.TableNotInTheDataSet(table.TableName);
      }
      LoadAdapter loadAdapter = new LoadAdapter();
      loadAdapter.FillLoadOption = loadOption;
      loadAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
      if (errorHandler != null)
        loadAdapter.FillError += errorHandler;
      loadAdapter.FillFromReader(tables, reader, 0, 0);
      if (reader.IsClosed || reader.NextResult())
        return;
      reader.Close();
    }

    public void Load(IDataReader reader, LoadOption loadOption, params DataTable[] tables) => this.Load(reader, loadOption, (FillErrorEventHandler) null, tables);

    public void Load(IDataReader reader, LoadOption loadOption, params string[] tables)
    {
      ADP.CheckArgumentNull((object) tables, nameof (tables));
      DataTable[] dataTableArray = new DataTable[tables.Length];
      for (int index = 0; index < tables.Length; ++index)
      {
        DataTable table = this.Tables[tables[index]];
        if (table == null)
        {
          table = new DataTable(tables[index]);
          this.Tables.Add(table);
        }
        dataTableArray[index] = table;
      }
      this.Load(reader, loadOption, (FillErrorEventHandler) null, dataTableArray);
    }

    public DataTableReader CreateDataReader()
    {
      DataTable[] dataTableArray = this.Tables.Count != 0 ? new DataTable[this.Tables.Count] : throw ExceptionBuilder.CannotCreateDataReaderOnEmptyDataSet();
      for (int index = 0; index < this.Tables.Count; ++index)
        dataTableArray[index] = this.Tables[index];
      return this.CreateDataReader(dataTableArray);
    }

    public DataTableReader CreateDataReader(params DataTable[] dataTables)
    {
      if (dataTables.Length == 0)
        throw ExceptionBuilder.DataTableReaderArgumentIsEmpty();
      for (int index = 0; index < dataTables.Length; ++index)
      {
        if (dataTables[index] == null)
          throw ExceptionBuilder.ArgumentContainsNullValue();
      }
      return new DataTableReader(dataTables);
    }

    internal string MainTableName
    {
      get => this.mainTableName;
      set => this.mainTableName = value;
    }

    private struct TableChanges
    {
      private BitArray _rowChanges;
      private int _hasChanges;

      internal TableChanges(int rowCount)
      {
        this._rowChanges = new BitArray(rowCount);
        this._hasChanges = 0;
      }

      internal int HasChanges
      {
        get => this._hasChanges;
        set => this._hasChanges = value;
      }

      internal bool this[int index]
      {
        get => this._rowChanges[index];
        set
        {
          Debug.Assert(value && !this._rowChanges[index], "setting twice or to false");
          this._rowChanges[index] = value;
          ++this._hasChanges;
        }
      }
    }
  }
}
