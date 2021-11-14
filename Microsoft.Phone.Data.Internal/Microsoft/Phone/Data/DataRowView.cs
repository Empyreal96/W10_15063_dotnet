// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataRowView
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.ComponentModel;

namespace Microsoft.Phone.Data
{
  public class DataRowView : IEditableObject, INotifyPropertyChanged
  {
    private readonly DataView dataView;
    private readonly DataRow _row;
    private bool delayBeginEdit;
    private PropertyChangedEventHandler onPropertyChanged;

    internal DataRowView(DataView dataView, DataRow row)
    {
      this.dataView = dataView;
      this._row = row;
    }

    public override bool Equals(object other) => this == other;

    public override int GetHashCode() => this.Row.GetHashCode();

    public DataView DataView => this.dataView;

    public object this[int ndx]
    {
      get => this.Row[ndx, this.RowVersionDefault];
      set => this.SetColumnValue(this.dataView.Table.Columns[ndx], value);
    }

    public object this[string property]
    {
      get
      {
        DataColumn column = this.dataView.Table.Columns[property];
        if (column != null)
          return this.Row[column, this.RowVersionDefault];
        if (this.dataView.Table.DataSet != null && this.dataView.Table.DataSet.Relations.Contains(property))
          return (object) this.CreateChildView(property);
        throw ExceptionBuilder.PropertyNotFound(property, this.dataView.Table.TableName);
      }
      set => this.SetColumnValue(this.dataView.Table.Columns[property] ?? throw ExceptionBuilder.SetFailed(property), value);
    }

    public DataRowVersion RowVersion => this.RowVersionDefault & ~DataRowVersion.Proposed;

    private DataRowVersion RowVersionDefault => this.Row.GetDefaultRowVersion(this.dataView.RowStateFilter);

    internal int GetRecord() => this.Row.GetRecordFromVersion(this.RowVersionDefault);

    internal object GetColumnValue(DataColumn column) => this.Row[column, this.RowVersionDefault];

    internal void SetColumnValue(DataColumn column, object value)
    {
      if (!this.dataView.AllowEdit && !this.IsNew)
        throw ExceptionBuilder.CanNotEdit();
      if (this.delayBeginEdit)
      {
        this.delayBeginEdit = false;
        this.Row.BeginEdit();
      }
      if (DataRowVersion.Original == this.RowVersionDefault)
        throw ExceptionBuilder.SetFailed(column.ColumnName);
      this.Row[column] = value;
    }

    public DataView CreateChildView(DataRelation relation)
    {
      if (relation == null || relation.ParentKey.Table != this.DataView.Table)
        throw ExceptionBuilder.CreateChildView();
      int record = this.GetRecord();
      object[] keyValues = relation.ParentKey.GetKeyValues(record);
      RelatedView relatedView = new RelatedView(relation.ChildColumnsReference, keyValues);
      relatedView.SetIndex("", DataViewRowState.CurrentRows, (IFilter) null);
      relatedView.SetDataViewManager(this.DataView.DataViewManager);
      return (DataView) relatedView;
    }

    public DataView CreateChildView(string relationName) => this.CreateChildView(this.DataView.Table.ChildRelations[relationName]);

    public DataRow Row => this._row;

    public void BeginEdit() => this.delayBeginEdit = true;

    public void CancelEdit()
    {
      DataRow row = this.Row;
      if (this.IsNew)
        this.dataView.FinishAddNew(false);
      else
        row.CancelEdit();
      this.delayBeginEdit = false;
    }

    public void EndEdit()
    {
      if (this.IsNew)
        this.dataView.FinishAddNew(true);
      else
        this.Row.EndEdit();
      this.delayBeginEdit = false;
    }

    public bool IsNew => this._row == this.dataView.addNewRow;

    public bool IsEdit => this.Row.HasVersion(DataRowVersion.Proposed) || this.delayBeginEdit;

    public void Delete() => this.dataView.Delete(this.Row);

    public event PropertyChangedEventHandler PropertyChanged
    {
      add => this.onPropertyChanged += value;
      remove => this.onPropertyChanged -= value;
    }

    internal void RaisePropertyChangedEvent(string propName)
    {
      if (this.onPropertyChanged == null)
        return;
      this.onPropertyChanged((object) this, new PropertyChangedEventArgs(propName));
    }
  }
}
