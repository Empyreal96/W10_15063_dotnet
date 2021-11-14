// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataRelationCollection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using Microsoft.Phone.Data.Workaround;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  public abstract class DataRelationCollection : InternalDataCollectionBase
  {
    private DataRelation inTransition;
    private int defaultNameIndex = 1;
    private CollectionChangeEventHandler onCollectionChangedDelegate;

    public abstract DataRelation this[int index] { get; }

    public abstract DataRelation this[string name] { get; }

    public void Add(DataRelation relation)
    {
      if (this.inTransition == relation)
        return;
      this.inTransition = relation;
      try
      {
        this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Add, (object) relation));
        this.AddCore(relation);
        this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Add, (object) relation));
      }
      finally
      {
        this.inTransition = (DataRelation) null;
      }
    }

    public virtual void AddRange(DataRelation[] relations)
    {
      if (relations == null)
        return;
      foreach (DataRelation relation in relations)
      {
        if (relation != null)
          this.Add(relation);
      }
    }

    public virtual DataRelation Add(
      string name,
      DataColumn[] parentColumns,
      DataColumn[] childColumns)
    {
      DataRelation relation = new DataRelation(name, parentColumns, childColumns);
      this.Add(relation);
      return relation;
    }

    public virtual DataRelation Add(
      string name,
      DataColumn[] parentColumns,
      DataColumn[] childColumns,
      bool createConstraints)
    {
      DataRelation relation = new DataRelation(name, parentColumns, childColumns, createConstraints);
      this.Add(relation);
      return relation;
    }

    public virtual DataRelation Add(
      DataColumn[] parentColumns,
      DataColumn[] childColumns)
    {
      DataRelation relation = new DataRelation((string) null, parentColumns, childColumns);
      this.Add(relation);
      return relation;
    }

    public virtual DataRelation Add(
      string name,
      DataColumn parentColumn,
      DataColumn childColumn)
    {
      DataRelation relation = new DataRelation(name, parentColumn, childColumn);
      this.Add(relation);
      return relation;
    }

    public virtual DataRelation Add(
      string name,
      DataColumn parentColumn,
      DataColumn childColumn,
      bool createConstraints)
    {
      DataRelation relation = new DataRelation(name, parentColumn, childColumn, createConstraints);
      this.Add(relation);
      return relation;
    }

    public virtual DataRelation Add(DataColumn parentColumn, DataColumn childColumn)
    {
      DataRelation relation = new DataRelation((string) null, parentColumn, childColumn);
      this.Add(relation);
      return relation;
    }

    protected virtual void AddCore(DataRelation relation)
    {
      if (relation == null)
        throw ExceptionBuilder.ArgumentNull(nameof (relation));
      relation.CheckState();
      DataSet dataSet = this.GetDataSet();
      if (relation.DataSet == dataSet)
        throw ExceptionBuilder.RelationAlreadyInTheDataSet();
      if (relation.DataSet != null)
        throw ExceptionBuilder.RelationAlreadyInOtherDataSet();
      if (!CultureInfoCompareWorkaround.CultureEqual(relation.ChildTable.Locale, relation.ParentTable.Locale) || relation.ChildTable.CaseSensitive != relation.ParentTable.CaseSensitive)
        throw ExceptionBuilder.CaseLocaleMismatch();
      if (!relation.Nested)
        return;
      DataRelation dataRelation = relation;
      dataRelation.CheckNamespaceValidityForNestedRelations(dataRelation.ParentTable.Namespace);
      relation.ValidateMultipleNestedRelations();
      ++relation.ParentTable.ElementColumnCount;
    }

    public event CollectionChangeEventHandler CollectionChanged
    {
      add => this.onCollectionChangedDelegate += value;
      remove => this.onCollectionChangedDelegate -= value;
    }

    internal string AssignName()
    {
      string str = this.MakeName(this.defaultNameIndex);
      ++this.defaultNameIndex;
      return str;
    }

    public virtual void Clear()
    {
      int count = this.Count;
      this.OnCollectionChanging(InternalDataCollectionBase.RefreshEventArgs);
      for (int index = count - 1; index >= 0; --index)
      {
        this.inTransition = this[index];
        this.RemoveCore(this.inTransition);
      }
      this.OnCollectionChanged(InternalDataCollectionBase.RefreshEventArgs);
      this.inTransition = (DataRelation) null;
    }

    public virtual bool Contains(string name) => this.InternalIndexOf(name) >= 0;

    public void CopyTo(DataRelation[] array, int index)
    {
      if (array == null)
        throw ExceptionBuilder.ArgumentNull(nameof (array));
      if (index < 0)
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (index));
      ArrayList list = this.List;
      if (array.Length - index < list.Count)
        throw ExceptionBuilder.InvalidOffsetLength();
      for (int index1 = 0; index1 < list.Count; ++index1)
        array[index + index1] = (DataRelation) list[index1];
    }

    public virtual int IndexOf(DataRelation relation)
    {
      int count = this.List.Count;
      for (int index = 0; index < count; ++index)
      {
        if (relation == (DataRelation) this.List[index])
          return index;
      }
      return -1;
    }

    public virtual int IndexOf(string relationName)
    {
      int num = this.InternalIndexOf(relationName);
      return num >= 0 ? num : -1;
    }

    internal int InternalIndexOf(string name)
    {
      int num = -1;
      if (name != null && 0 < name.Length)
      {
        int count = this.List.Count;
        for (int index = 0; index < count; ++index)
        {
          switch (this.NamesEqual(((DataRelation) this.List[index]).RelationName, name, false, this.GetDataSet().Locale))
          {
            case -1:
              num = num == -1 ? index : -2;
              break;
            case 1:
              return index;
          }
        }
      }
      return num;
    }

    protected abstract DataSet GetDataSet();

    private string MakeName(int index) => 1 == index ? "Relation1" : "Relation" + index.ToString((IFormatProvider) CultureInfo.InvariantCulture);

    protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent)
    {
      if (this.onCollectionChangedDelegate == null)
        return;
      this.onCollectionChangedDelegate((object) this, ccevent);
    }

    protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent)
    {
    }

    internal void RegisterName(string name)
    {
      Debug.Assert(name != null);
      CultureInfo locale = this.GetDataSet().Locale;
      int count = this.Count;
      for (int index = 0; index < count; ++index)
      {
        if (this.NamesEqual(name, this[index].RelationName, true, locale) != 0)
          throw ExceptionBuilder.DuplicateRelation(this[index].RelationName);
      }
      if (this.NamesEqual(name, this.MakeName(this.defaultNameIndex), true, locale) == 0)
        return;
      ++this.defaultNameIndex;
    }

    public virtual bool CanRemove(DataRelation relation) => relation != null && relation.DataSet == this.GetDataSet();

    public void Remove(DataRelation relation)
    {
      if (this.inTransition == relation)
        return;
      this.inTransition = relation;
      try
      {
        this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Remove, (object) relation));
        this.RemoveCore(relation);
        this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Remove, (object) relation));
      }
      finally
      {
        this.inTransition = (DataRelation) null;
      }
    }

    public void RemoveAt(int index) => this.Remove(this[index] ?? throw ExceptionBuilder.RelationOutOfRange((object) index));

    public void Remove(string name) => this.Remove(this[name] ?? throw ExceptionBuilder.RelationNotInTheDataSet(name));

    protected virtual void RemoveCore(DataRelation relation)
    {
      if (relation == null)
        throw ExceptionBuilder.ArgumentNull(nameof (relation));
      DataSet dataSet = this.GetDataSet();
      if (relation.DataSet != dataSet)
        throw ExceptionBuilder.RelationNotInTheDataSet(relation.RelationName);
      if (!relation.Nested)
        return;
      --relation.ParentTable.ElementColumnCount;
      relation.ParentTable.Columns.UnregisterName(relation.ChildTable.TableName);
    }

    internal void UnregisterName(string name)
    {
      if (this.NamesEqual(name, this.MakeName(this.defaultNameIndex - 1), true, this.GetDataSet().Locale) == 0)
        return;
      do
      {
        --this.defaultNameIndex;
      }
      while (this.defaultNameIndex > 1 && !this.Contains(this.MakeName(this.defaultNameIndex - 1)));
    }

    internal sealed class DataTableRelationCollection : DataRelationCollection
    {
      private readonly DataTable table;
      private readonly ArrayList relations;
      private readonly bool fParentCollection;
      private CollectionChangeEventHandler onRelationPropertyChangedDelegate;

      internal DataTableRelationCollection(DataTable table, bool fParentCollection)
      {
        this.table = table != null ? table : throw ExceptionBuilder.RelationTableNull();
        this.fParentCollection = fParentCollection;
        this.relations = new ArrayList();
      }

      protected override ArrayList List => this.relations;

      private void EnsureDataSet()
      {
        if (this.table.DataSet == null)
          throw ExceptionBuilder.RelationTableWasRemoved();
      }

      protected override DataSet GetDataSet()
      {
        this.EnsureDataSet();
        return this.table.DataSet;
      }

      public override DataRelation this[int index]
      {
        get
        {
          if (index >= 0 && index < this.relations.Count)
            return (DataRelation) this.relations[index];
          throw ExceptionBuilder.RelationOutOfRange((object) index);
        }
      }

      public override DataRelation this[string name]
      {
        get
        {
          int index = this.InternalIndexOf(name);
          if (index == -2)
            throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
          return index >= 0 ? (DataRelation) this.List[index] : (DataRelation) null;
        }
      }

      internal event CollectionChangeEventHandler RelationPropertyChanged
      {
        add => this.onRelationPropertyChangedDelegate += value;
        remove => this.onRelationPropertyChangedDelegate -= value;
      }

      internal void OnRelationPropertyChanged(CollectionChangeEventArgs ccevent)
      {
        if (this.onRelationPropertyChangedDelegate == null)
          return;
        this.onRelationPropertyChangedDelegate((object) this, ccevent);
      }

      private void AddCache(DataRelation relation) => this.relations.Add((object) relation);

      protected override void AddCore(DataRelation relation)
      {
        if (this.fParentCollection)
        {
          if (relation.ChildTable != this.table)
            throw ExceptionBuilder.ChildTableMismatch();
        }
        else if (relation.ParentTable != this.table)
          throw ExceptionBuilder.ParentTableMismatch();
        this.GetDataSet().Relations.Add(relation);
        this.AddCache(relation);
      }

      public override bool CanRemove(DataRelation relation)
      {
        if (!base.CanRemove(relation))
          return false;
        if (this.fParentCollection)
        {
          if (relation.ChildTable != this.table)
            return false;
        }
        else if (relation.ParentTable != this.table)
          return false;
        return true;
      }

      private void RemoveCache(DataRelation relation)
      {
        for (int index = 0; index < this.relations.Count; ++index)
        {
          if (relation == this.relations[index])
          {
            this.relations.RemoveAt(index);
            return;
          }
        }
        throw ExceptionBuilder.RelationDoesNotExist();
      }

      protected override void RemoveCore(DataRelation relation)
      {
        if (this.fParentCollection)
        {
          if (relation.ChildTable != this.table)
            throw ExceptionBuilder.ChildTableMismatch();
        }
        else if (relation.ParentTable != this.table)
          throw ExceptionBuilder.ParentTableMismatch();
        this.GetDataSet().Relations.Remove(relation);
        this.RemoveCache(relation);
      }
    }

    internal sealed class DataSetRelationCollection : DataRelationCollection
    {
      private readonly DataSet dataSet;
      private readonly ArrayList relations;
      private DataRelation[] delayLoadingRelations;

      internal DataSetRelationCollection(DataSet dataSet)
      {
        this.dataSet = dataSet != null ? dataSet : throw ExceptionBuilder.RelationDataSetNull();
        this.relations = new ArrayList();
      }

      protected override ArrayList List => this.relations;

      public override void AddRange(DataRelation[] relations)
      {
        if (this.dataSet.fInitInProgress)
        {
          this.delayLoadingRelations = relations;
        }
        else
        {
          if (relations == null)
            return;
          foreach (DataRelation relation in relations)
          {
            if (relation != null)
              this.Add(relation);
          }
        }
      }

      public override void Clear()
      {
        base.Clear();
        if (!this.dataSet.fInitInProgress || this.delayLoadingRelations == null)
          return;
        this.delayLoadingRelations = (DataRelation[]) null;
      }

      protected override DataSet GetDataSet() => this.dataSet;

      public override DataRelation this[int index]
      {
        get
        {
          if (index >= 0 && index < this.relations.Count)
            return (DataRelation) this.relations[index];
          throw ExceptionBuilder.RelationOutOfRange((object) index);
        }
      }

      public override DataRelation this[string name]
      {
        get
        {
          int index = this.InternalIndexOf(name);
          if (index == -2)
            throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
          return index >= 0 ? (DataRelation) this.List[index] : (DataRelation) null;
        }
      }

      protected override void AddCore(DataRelation relation)
      {
        base.AddCore(relation);
        if (relation.ChildTable.DataSet != this.dataSet || relation.ParentTable.DataSet != this.dataSet)
          throw ExceptionBuilder.ForeignRelation();
        relation.CheckState();
        if (relation.Nested)
          relation.CheckNestedRelations();
        if (relation.relationName.Length == 0)
          relation.relationName = this.AssignName();
        else
          this.RegisterName(relation.relationName);
        DataKey childKey = relation.ChildKey;
        for (int index = 0; index < this.relations.Count; ++index)
        {
          if (childKey.ColumnsEqual(((DataRelation) this.relations[index]).ChildKey) && relation.ParentKey.ColumnsEqual(((DataRelation) this.relations[index]).ParentKey))
            throw ExceptionBuilder.RelationAlreadyExists();
        }
        this.relations.Add((object) relation);
        relation.ParentTable.ChildRelations.Add(relation);
        relation.ChildTable.ParentRelations.Add(relation);
        relation.SetDataSet(this.dataSet);
        relation.ChildKey.GetSortIndex().AddRef();
        if (relation.Nested)
          relation.ChildTable.CacheNestedParent();
        ForeignKeyConstraint foreignKeyConstraint = relation.ChildTable.Constraints.FindForeignKeyConstraint(relation.ParentColumnsReference, relation.ChildColumnsReference);
        if (relation.createConstraints && foreignKeyConstraint == null)
        {
          relation.ChildTable.Constraints.Add((Constraint) (foreignKeyConstraint = new ForeignKeyConstraint(relation.ParentColumnsReference, relation.ChildColumnsReference)));
          try
          {
            foreignKeyConstraint.ConstraintName = relation.RelationName;
          }
          catch (Exception ex)
          {
            if (!ADP.IsCatchableExceptionType(ex))
              throw;
            else
              ExceptionBuilder.TraceExceptionWithoutRethrow(ex);
          }
        }
        UniqueConstraint keyConstraint = relation.ParentTable.Constraints.FindKeyConstraint(relation.ParentColumnsReference);
        relation.SetParentKeyConstraint(keyConstraint);
        relation.SetChildKeyConstraint(foreignKeyConstraint);
      }

      protected override void RemoveCore(DataRelation relation)
      {
        base.RemoveCore(relation);
        this.dataSet.OnRemoveRelationHack(relation);
        relation.SetDataSet((DataSet) null);
        relation.ChildKey.GetSortIndex().RemoveRef();
        if (relation.Nested)
          relation.ChildTable.CacheNestedParent();
        for (int index = 0; index < this.relations.Count; ++index)
        {
          if (relation == this.relations[index])
          {
            this.relations.RemoveAt(index);
            relation.ParentTable.ChildRelations.Remove(relation);
            relation.ChildTable.ParentRelations.Remove(relation);
            if (relation.Nested)
              relation.ChildTable.CacheNestedParent();
            this.UnregisterName(relation.RelationName);
            relation.SetParentKeyConstraint((UniqueConstraint) null);
            relation.SetChildKeyConstraint((ForeignKeyConstraint) null);
            return;
          }
        }
        throw ExceptionBuilder.RelationDoesNotExist();
      }

      internal void FinishInitRelations()
      {
        if (this.delayLoadingRelations == null)
          return;
        for (int index1 = 0; index1 < this.delayLoadingRelations.Length; ++index1)
        {
          DataRelation delayLoadingRelation = this.delayLoadingRelations[index1];
          if (delayLoadingRelation.parentColumnNames == null || delayLoadingRelation.childColumnNames == null)
          {
            this.Add(delayLoadingRelation);
          }
          else
          {
            int length = delayLoadingRelation.parentColumnNames.Length;
            DataColumn[] parentColumns = new DataColumn[length];
            DataColumn[] childColumns = new DataColumn[length];
            for (int index2 = 0; index2 < length; ++index2)
            {
              parentColumns[index2] = delayLoadingRelation.parentTableNamespace != null ? this.dataSet.Tables[delayLoadingRelation.parentTableName, delayLoadingRelation.parentTableNamespace].Columns[delayLoadingRelation.parentColumnNames[index2]] : this.dataSet.Tables[delayLoadingRelation.parentTableName].Columns[delayLoadingRelation.parentColumnNames[index2]];
              childColumns[index2] = delayLoadingRelation.childTableNamespace != null ? this.dataSet.Tables[delayLoadingRelation.childTableName, delayLoadingRelation.childTableNamespace].Columns[delayLoadingRelation.childColumnNames[index2]] : this.dataSet.Tables[delayLoadingRelation.childTableName].Columns[delayLoadingRelation.childColumnNames[index2]];
            }
            this.Add(new DataRelation(delayLoadingRelation.relationName, parentColumns, childColumns, false)
            {
              Nested = delayLoadingRelation.nested
            });
          }
        }
        this.delayLoadingRelations = (DataRelation[]) null;
      }
    }
  }
}
