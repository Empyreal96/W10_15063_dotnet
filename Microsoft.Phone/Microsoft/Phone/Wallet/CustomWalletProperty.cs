// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.CustomWalletProperty
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace Microsoft.Phone.Wallet
{
  public class CustomWalletProperty : WalletPropertyBase
  {
    private string _label;
    private string _value;

    internal CustomWalletProperty(WalletItem ownerItem, string key)
      : base(ownerItem, key)
    {
      CustomWalletProperty customPropFromDb = this.GetCustomPropFromDB();
      this._label = customPropFromDb.Label;
      this._value = customPropFromDb.Value;
    }

    public CustomWalletProperty()
    {
      this.Value = (string) null;
      this.Label = (string) null;
    }

    public CustomWalletProperty(string value)
    {
      this.Value = value;
      this.Label = (string) null;
    }

    public CustomWalletProperty(string value, string label)
    {
      this.Value = value;
      this.Label = label;
    }

    internal override bool IsEmpty => this.Value == null;

    public string Label
    {
      get
      {
        string label = this._label;
        if (!this.HasPendingWrite && this.OwnerItem != null && this.OwnerItem.IsSavedInWallet)
          label = this.GetCustomPropFromDB().Label;
        return label;
      }
      set
      {
        this._label = value;
        this.HasPendingWrite = true;
      }
    }

    public string Value
    {
      get
      {
        string str = this._value;
        if (!this.HasPendingWrite && this.OwnerItem != null && this.OwnerItem.IsSavedInWallet)
          str = this.GetCustomPropFromDB().Value;
        return str;
      }
      set
      {
        this._value = value;
        this.HasPendingWrite = true;
      }
    }

    internal override string InternalKey
    {
      get => this.Key;
      set => this.Key = value;
    }

    private CustomWalletProperty GetCustomPropFromDB()
    {
      CustomWalletProperty customWalletProperty = (CustomWalletProperty) null;
      if (this.OwnerItem != null)
        customWalletProperty = this.OwnerItem.GetCustomPropertyFromNativeItem(this.Key);
      return customWalletProperty;
    }
  }
}
