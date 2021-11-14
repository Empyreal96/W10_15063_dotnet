// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.InternalWalletProperty
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace Microsoft.Phone.Wallet
{
  internal abstract class InternalWalletProperty
  {
    private WalletItem _ownerItem;
    private bool _valuePendingWrite;
    private WalletItemPropertyType _propertyType;

    internal InternalWalletProperty(WalletItem owner, WalletItemPropertyType propertyType)
    {
      this.OwnerItem = owner;
      this._propertyType = propertyType;
    }

    internal WalletItem OwnerItem
    {
      get => this._ownerItem;
      set => this._ownerItem = value;
    }

    internal bool ValuePendingWrite
    {
      get => this._valuePendingWrite;
      set => this._valuePendingWrite = value;
    }

    internal WalletItemPropertyType PropertyType => this._propertyType;

    protected abstract void SetValue(object val);

    protected abstract object GetValue();

    public virtual object Value
    {
      get => this.GetValue();
      set => this.SetValue(value);
    }
  }
}
