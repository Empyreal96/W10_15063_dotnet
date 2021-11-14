// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.InternalWalletProperty`1
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Windows.Media.Imaging;

namespace Microsoft.Phone.Wallet
{
  internal class InternalWalletProperty<T> : InternalWalletProperty
  {
    private T _pendingValue;

    internal InternalWalletProperty(WalletItem owner, WalletItemPropertyType propertyType)
      : base(owner, propertyType)
    {
    }

    internal event ValueValidationHandler ValueSet;

    public T Value
    {
      get => (T) this.GetValue();
      set => this.SetValue((object) value);
    }

    public T GetValueOrDefault(T defaultValue) => this.Value ?? defaultValue;

    protected override object GetValue()
    {
      object obj = (object) null;
      if (this.ValuePendingWrite)
        obj = (object) this._pendingValue;
      else if (typeof (T) == typeof (string))
        obj = (object) this.OwnerItem.GetStringPropertyFromNativeItem(this.PropertyType);
      else if (typeof (T) == typeof (int?))
        obj = (object) this.OwnerItem.GetIntPropertyFromNativeItem(this.PropertyType);
      else if (typeof (T) == typeof (byte[]))
        obj = (object) this.OwnerItem.GetBlobPropertyFromNativeItem(this.PropertyType);
      else if (typeof (T) == typeof (PaymentCardKinds?))
      {
        int? propertyFromNativeItem = this.OwnerItem.GetIntPropertyFromNativeItem(this.PropertyType);
        if (propertyFromNativeItem.HasValue)
          obj = (object) (PaymentCardKinds) propertyFromNativeItem.Value;
      }
      else if (typeof (T) == typeof (DateTime?))
        obj = (object) this.OwnerItem.GetDateTimePropertyFromNativeItem(this.PropertyType);
      else if (typeof (T) == typeof (bool?))
      {
        int? propertyFromNativeItem = this.OwnerItem.GetIntPropertyFromNativeItem(this.PropertyType);
        if (propertyFromNativeItem.HasValue)
          obj = (object) ((uint) propertyFromNativeItem.Value > 0U);
      }
      else if (typeof (T) == typeof (Uri))
        obj = (object) new Uri(this.OwnerItem.GetStringPropertyFromNativeItem(this.PropertyType));
      else if (typeof (T) == typeof (BitmapSource))
        obj = (object) this.OwnerItem.GetImagePropertyFromNativeItem(this.PropertyType);
      return obj;
    }

    protected override void SetValue(object val)
    {
      ValueValidationEventArgs args = new ValueValidationEventArgs();
      if (this.ValueSet != null)
        this.ValueSet((InternalWalletProperty) this, args);
      else
        args.IsValid = true;
      if (!args.IsValid)
        return;
      if (this.OwnerItem == null)
        throw new InvalidOperationException("Item must be new or in edit mode in order to write properties");
      this._pendingValue = (T) val;
      this.ValuePendingWrite = true;
    }
  }
}
