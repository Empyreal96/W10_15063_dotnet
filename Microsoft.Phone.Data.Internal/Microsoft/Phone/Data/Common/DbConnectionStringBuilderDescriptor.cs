// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbConnectionStringBuilderDescriptor
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;

namespace Microsoft.Phone.Data.Common
{
  internal class DbConnectionStringBuilderDescriptor : PropertyDescriptor
  {
    private Type _componentType;
    private Type _propertyType;
    private bool _isReadOnly;
    private bool _refreshOnChange;

    internal DbConnectionStringBuilderDescriptor(
      string propertyName,
      Type componentType,
      Type propertyType,
      bool isReadOnly,
      Attribute[] attributes)
      : base(propertyName, attributes)
    {
      this._componentType = componentType;
      this._propertyType = propertyType;
      this._isReadOnly = isReadOnly;
    }

    internal bool RefreshOnChange
    {
      get => this._refreshOnChange;
      set => this._refreshOnChange = value;
    }

    public override Type ComponentType => this._componentType;

    public override bool IsReadOnly => this._isReadOnly;

    public override Type PropertyType => this._propertyType;

    public override bool CanResetValue(object component) => component is DbConnectionStringBuilder connectionStringBuilder && connectionStringBuilder.ShouldSerialize(this.DisplayName);

    public override object GetValue(object component)
    {
      object obj;
      return component is DbConnectionStringBuilder connectionStringBuilder && connectionStringBuilder.TryGetValue(this.DisplayName, out obj) ? obj : (object) null;
    }

    public override void ResetValue(object component)
    {
      if (!(component is DbConnectionStringBuilder connectionStringBuilder))
        return;
      connectionStringBuilder.Remove(this.DisplayName);
      if (!this.RefreshOnChange)
        return;
      connectionStringBuilder.ClearPropertyDescriptors();
    }

    public override void SetValue(object component, object value)
    {
      if (!(component is DbConnectionStringBuilder connectionStringBuilder))
        return;
      if (typeof (string) == this.PropertyType && string.Empty.Equals(value))
        value = (object) null;
      connectionStringBuilder[this.DisplayName] = value;
      if (!this.RefreshOnChange)
        return;
      connectionStringBuilder.ClearPropertyDescriptors();
    }

    public override bool ShouldSerializeValue(object component) => component is DbConnectionStringBuilder connectionStringBuilder && connectionStringBuilder.ShouldSerialize(this.DisplayName);
  }
}
