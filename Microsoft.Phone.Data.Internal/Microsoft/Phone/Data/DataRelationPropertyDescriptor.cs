// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataRelationPropertyDescriptor
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;

namespace Microsoft.Phone.Data
{
  internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor
  {
    private DataRelation relation;

    internal DataRelation Relation => this.relation;

    internal DataRelationPropertyDescriptor(DataRelation dataRelation)
      : base(dataRelation.RelationName, (Attribute[]) null)
    {
      this.relation = dataRelation;
    }

    public override Type ComponentType => typeof (DataRowView);

    public override bool IsReadOnly => false;

    public override Type PropertyType => typeof (IBindingList);

    public override bool Equals(object other) => other is DataRelationPropertyDescriptor && ((DataRelationPropertyDescriptor) other).Relation == this.Relation;

    public override int GetHashCode() => this.Relation.GetHashCode();

    public override bool CanResetValue(object component) => false;

    public override object GetValue(object component) => (object) ((DataRowView) component).CreateChildView(this.relation);

    public override void ResetValue(object component)
    {
    }

    public override void SetValue(object component, object value)
    {
    }

    public override bool ShouldSerializeValue(object component) => false;
  }
}
