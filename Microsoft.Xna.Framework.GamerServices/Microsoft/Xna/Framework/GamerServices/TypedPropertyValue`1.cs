// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.TypedPropertyValue`1
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class TypedPropertyValue<T> : PropertyValue where T : IEquatable<T>
  {
    protected T currentValue;

    public override object GetValue() => (object) this.currentValue;

    public T GetTypedValue() => this.currentValue;

    public override void SetValue(object value) => this.SetTypedValue((T) Convert.ChangeType(value, typeof (T), (IFormatProvider) CultureInfo.InvariantCulture));

    public void SetTypedValue(T value)
    {
      if (value.Equals(this.currentValue))
        return;
      this.currentValue = value;
      this.IsChanged = true;
    }
  }
}
