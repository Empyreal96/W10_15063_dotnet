// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletAddress
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Device.Location;

namespace Microsoft.Phone.Wallet
{
  public class WalletAddress
  {
    private WalletItemPropertyType _streetProperty;
    private WalletItemPropertyType _cityProperty;
    private WalletItemPropertyType _stateProperty;
    private WalletItemPropertyType _zipProperty;
    private WalletItemPropertyType _countryProperty;

    private WalletItem OwnerItem { get; set; }

    internal WalletAddress(
      WalletItem ownerItem,
      WalletItemPropertyType streetProperty,
      WalletItemPropertyType cityProperty,
      WalletItemPropertyType zipProperty,
      WalletItemPropertyType stateProperty,
      WalletItemPropertyType countryProperty)
    {
      this.SetWalletProperties(ownerItem, streetProperty, cityProperty, zipProperty, stateProperty, countryProperty);
    }

    internal void SetWalletProperties(
      WalletItem ownerItem,
      WalletItemPropertyType streetProperty,
      WalletItemPropertyType cityProperty,
      WalletItemPropertyType zipProperty,
      WalletItemPropertyType stateProperty,
      WalletItemPropertyType countryProperty)
    {
      this.OwnerItem = ownerItem;
      this._streetProperty = streetProperty;
      this._cityProperty = cityProperty;
      this._stateProperty = stateProperty;
      this._zipProperty = zipProperty;
      this._countryProperty = countryProperty;
    }

    internal WalletAddress()
    {
    }

    internal void CopyFromAddress(WalletAddress source)
    {
      this.City = source.City;
      this.Street = source.Street;
      this.PostalCode = source.PostalCode;
      this.StateProvince = source.StateProvince;
      this.CountryRegion = source.CountryRegion;
    }

    public string Street
    {
      get => this.OwnerItem.GetWalletProperty<string>(this._streetProperty).Value;
      set => this.OwnerItem.GetWalletProperty<string>(this._streetProperty).Value = value;
    }

    public string City
    {
      get => this.OwnerItem.GetWalletProperty<string>(this._cityProperty).Value;
      set => this.OwnerItem.GetWalletProperty<string>(this._cityProperty).Value = value;
    }

    public string StateProvince
    {
      get => this.OwnerItem.GetWalletProperty<string>(this._stateProperty).Value;
      set => this.OwnerItem.GetWalletProperty<string>(this._stateProperty).Value = value;
    }

    public string PostalCode
    {
      get => this.OwnerItem.GetWalletProperty<string>(this._zipProperty).Value;
      set => this.OwnerItem.GetWalletProperty<string>(this._zipProperty).Value = value;
    }

    public string CountryRegion
    {
      get => this.OwnerItem.GetWalletProperty<string>(this._countryProperty).Value;
      set => this.OwnerItem.GetWalletProperty<string>(this._countryProperty).Value = value;
    }

    public CivicAddress ToCivicAddress() => new CivicAddress()
    {
      AddressLine1 = this.Street,
      City = this.City,
      PostalCode = this.PostalCode,
      StateProvince = this.StateProvince,
      CountryRegion = this.CountryRegion
    };

    public static WalletAddress FromCivicAddress(CivicAddress civicAddress) => new WalletAddress()
    {
      Street = civicAddress.AddressLine1,
      City = civicAddress.City,
      PostalCode = civicAddress.PostalCode,
      StateProvince = civicAddress.StateProvince,
      CountryRegion = civicAddress.CountryRegion
    };
  }
}
