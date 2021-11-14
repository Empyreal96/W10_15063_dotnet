// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Constraint
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  public abstract class Constraint
  {
    internal string name = "";
    private string _schemaName = "";
    private bool inCollection;
    private DataSet dataSet;
    internal PropertyCollection extendedProperties;

    public virtual string ConstraintName
    {
      get => this.name;
      set
      {
        if (value == null)
          value = "";
        if (ADP.IsEmpty(value) && this.Table != null && this.InCollection)
          throw ExceptionBuilder.NoConstraintName();
        CultureInfo culture = this.Table != null ? this.Table.Locale : CultureInfo.CurrentCulture;
        if (string.Compare(this.name, value, culture, CompareOptions.IgnoreCase) != 0)
        {
          if (this.Table != null && this.InCollection)
          {
            this.Table.Constraints.RegisterName(value);
            if (this.name.Length != 0)
              this.Table.Constraints.UnregisterName(this.name);
          }
          this.name = value;
        }
        else
        {
          if (string.Compare(this.name, value, culture, CompareOptions.None) == 0)
            return;
          this.name = value;
        }
      }
    }

    internal string SchemaName
    {
      get => ADP.IsEmpty(this._schemaName) ? this.ConstraintName : this._schemaName;
      set
      {
        if (ADP.IsEmpty(value))
          return;
        this._schemaName = value;
      }
    }

    internal virtual bool InCollection
    {
      get => this.inCollection;
      set
      {
        this.inCollection = value;
        if (value)
          this.dataSet = this.Table.DataSet;
        else
          this.dataSet = (DataSet) null;
      }
    }

    public abstract DataTable Table { get; }

    public PropertyCollection ExtendedProperties
    {
      get
      {
        if (this.extendedProperties == null)
          this.extendedProperties = new PropertyCollection();
        return this.extendedProperties;
      }
    }

    internal abstract bool ContainsColumn(DataColumn column);

    internal abstract bool CanEnableConstraint();

    internal abstract Constraint Clone(DataSet destination);

    internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

    internal void CheckConstraint()
    {
      if (!this.CanEnableConstraint())
        throw ExceptionBuilder.ConstraintViolation(this.ConstraintName);
    }

    internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

    internal abstract bool CanBeRemovedFromCollection(
      ConstraintCollection constraint,
      bool fThrowException);

    internal abstract void CheckConstraint(DataRow row, DataRowAction action);

    internal abstract void CheckState();

    protected void CheckStateForProperty()
    {
      try
      {
        this.CheckState();
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableExceptionType(ex))
          throw ExceptionBuilder.BadObjectPropertyAccess(ex.Message);
        throw;
      }
    }

    [CLSCompliant(false)]
    protected virtual DataSet _DataSet => this.dataSet;

    protected internal void SetDataSet(DataSet dataSet) => this.dataSet = dataSet;

    internal abstract bool IsConstraintViolated();

    public override string ToString() => this.ConstraintName;
  }
}
