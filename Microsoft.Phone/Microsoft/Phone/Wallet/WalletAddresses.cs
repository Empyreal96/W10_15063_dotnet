// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletAddresses
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Wallet
{
  public class WalletAddresses
  {
    private WalletAddress _business1Address;
    private WalletAddress _business2Address;
    private WalletAddress _headquartersAddress;
    private WalletAddress _paymentsAddress;

    private WalletItem OwnerItem { get; set; }

    internal WalletAddresses(WalletItem ownerItem)
    {
      this.OwnerItem = ownerItem;
      this._business1Address = new WalletAddress(ownerItem, WalletItemPropertyType.BusinessAddressStreet, WalletItemPropertyType.BusinessAddressCity, WalletItemPropertyType.BusinessAddressZip, WalletItemPropertyType.BusinessAddressState, WalletItemPropertyType.BusinessAddressCountry);
      this._business2Address = new WalletAddress(ownerItem, WalletItemPropertyType.Business2AddressStreet, WalletItemPropertyType.Business2AddressCity, WalletItemPropertyType.Business2AddressZip, WalletItemPropertyType.Business2AddressState, WalletItemPropertyType.Business2AddressCountry);
      this._headquartersAddress = new WalletAddress(ownerItem, WalletItemPropertyType.HeadquartersAddressStreet, WalletItemPropertyType.HeadquartersAddressCity, WalletItemPropertyType.HeadquartersAddressZip, WalletItemPropertyType.HeadquartersAddressState, WalletItemPropertyType.HeadquartersAddressCountry);
      if (!(this.OwnerItem is WalletTransactionItemBase))
        return;
      this._paymentsAddress = new WalletAddress(ownerItem, WalletItemPropertyType.PaymentsAddressStreet, WalletItemPropertyType.PaymentsAddressCity, WalletItemPropertyType.PaymentsAddressZip, WalletItemPropertyType.PaymentsAddressState, WalletItemPropertyType.PaymentsAddressCountry);
    }

    public WalletAddress Business1
    {
      get
      {
        this.EnsureSupportedProperty(this._business1Address);
        return this._business1Address;
      }
      set
      {
        this.EnsureSupportedProperty(this._business1Address);
        this._business1Address.CopyFromAddress(value);
      }
    }

    public WalletAddress Business2
    {
      get
      {
        this.EnsureSupportedProperty(this._business2Address);
        return this._business2Address;
      }
      set
      {
        this.EnsureSupportedProperty(this._business2Address);
        this._business2Address.CopyFromAddress(value);
      }
    }

    public WalletAddress Headquarters
    {
      get
      {
        this.EnsureSupportedProperty(this._headquartersAddress);
        return this._headquartersAddress;
      }
      set
      {
        this.EnsureSupportedProperty(this._headquartersAddress);
        this._headquartersAddress.CopyFromAddress(value);
      }
    }

    public WalletAddress Payments
    {
      get
      {
        this.EnsureSupportedProperty(this._paymentsAddress);
        return this._paymentsAddress;
      }
      set
      {
        this.EnsureSupportedProperty(this._paymentsAddress);
        this._paymentsAddress.CopyFromAddress(value);
      }
    }

    private void EnsureSupportedProperty(WalletAddress address)
    {
      if (address == null)
        throw new NotSupportedException();
    }
  }
}
