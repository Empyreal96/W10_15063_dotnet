// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.Deal
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Wallet
{
  public sealed class Deal : WalletItem
  {
    private WalletPhoneNumbers _merchantPhone;
    private WalletAddresses _merchantAddress;

    public Deal()
    {
    }

    public Deal(string id)
      : base(id)
    {
    }

    internal Deal(string internalId, string id)
      : base(internalId, id)
    {
    }

    internal override void Initialize()
    {
      this._merchantAddress = new WalletAddresses((WalletItem) this);
      this._merchantPhone = new WalletPhoneNumbers((WalletItem) this);
      base.Initialize();
    }

    internal override void ThrowIfRequiredPropertiesNotSet()
    {
      this.ThrowIfValueNotSet<string>(this.MerchantName, "MerchantName");
      base.ThrowIfRequiredPropertiesNotSet();
    }

    internal override InternalWalletProperty<string> ItemSpecificName => this.GetWalletProperty<string>(WalletItemPropertyType.CouponTitle);

    public string Code
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.CouponCode).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.CouponCode).Value = value;
    }

    public string Description
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.CouponDetails).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.CouponDetails).Value = value;
    }

    public Uri OfferWebsite
    {
      get => this.GetWalletProperty<Uri>(WalletItemPropertyType.CouponUrl).Value;
      set
      {
        this.EnsureAbsoluteUriWithHttpScheme(value);
        this.GetWalletProperty<Uri>(WalletItemPropertyType.CouponUrl).Value = value;
      }
    }

    public string MerchantName
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.CouponMerchant).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.CouponMerchant).Value = value;
    }

    public WalletPhoneNumbers MerchantPhone => this._merchantPhone;

    public bool IsUsed
    {
      get => this.GetWalletProperty<bool?>(WalletItemPropertyType.CouponIsUsed).Value.GetValueOrDefault(false);
      set => this.GetWalletProperty<bool?>(WalletItemPropertyType.CouponIsUsed).Value = new bool?(value);
    }

    public WalletAddresses MerchantAddress => this._merchantAddress;

    public DateTime? StartDate
    {
      get => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.StartDate).Value;
      set => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.StartDate).Value = value;
    }

    public DateTime? ExpirationDate
    {
      get => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.ExpirationDate).Value;
      set => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.ExpirationDate).Value = value;
    }

    public string TermsAndConditions
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.Terms).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.Terms).Value = value;
    }
  }
}
