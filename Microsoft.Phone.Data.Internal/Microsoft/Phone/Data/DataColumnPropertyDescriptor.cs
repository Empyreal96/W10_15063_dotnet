// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataColumnPropertyDescriptor
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using Microsoft.Phone.Data.Workaround;
using System;

namespace Microsoft.Phone.Data
{
  internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor
  {
    private DataColumn column;

    internal DataColumnPropertyDescriptor(DataColumn dataColumn)
      : base(dataColumn.ColumnName, (Attribute[]) null)
    {
      this.column = dataColumn;
    }

    internal DataColumn Column => this.column;

    public override Type ComponentType => typeof (DataRowView);

    public override bool IsReadOnly => this.column.ReadOnly;

    public override Type PropertyType => this.column.DataType;

    public override bool Equals(object other) => other is DataColumnPropertyDescriptor && ((DataColumnPropertyDescriptor) other).Column == this.Column;

    public override int GetHashCode() => this.Column.GetHashCode();

    public override bool CanResetValue(object component)
    {
      DataRowView dataRowView = (DataRowView) component;
      return !this.column.IsSqlType ? dataRowView.GetColumnValue(this.column) != DBNull.Value : !DataStorage.IsObjectNull(dataRowView.GetColumnValue(this.column));
    }

    public override object GetValue(object component) => ((DataRowView) component).GetColumnValue(this.column);

    public override void ResetValue(object component) => ((DataRowView) component).SetColumnValue(this.column, (object) DBNull.Value);

    public override void SetValue(object component, object value)
    {
      ((DataRowView) component).SetColumnValue(this.column, value);
      this.OnValueChanged(component, EventArgs.Empty);
    }

    public override bool ShouldSerializeValue(object component) => false;
  }
}
