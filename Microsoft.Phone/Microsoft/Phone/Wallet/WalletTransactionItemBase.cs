// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletTransactionItemBase
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.SecureElement;
using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Microsoft.Phone.Wallet
{
  public abstract class WalletTransactionItemBase : 
    WalletItem,
    IWalletTransactionHistory,
    ISecureElementItem
  {
    private WalletTransactionDictionary _transactionHistory;
    private SecureElementProperties _secureElementProperties;
    private WalletAddresses _issuerAddress;
    private WalletPhoneNumbers _issuerPhone;
    private WalletAddress _billingAddress;

    internal WalletTransactionItemBase()
    {
    }

    internal WalletTransactionItemBase(string id)
      : base(id)
    {
    }

    internal WalletTransactionItemBase(string internalId, string id)
      : base(internalId, id)
    {
    }

    internal override void Initialize()
    {
      base.Initialize();
      this._secureElementProperties = new SecureElementProperties((WalletItem) this);
      this._issuerPhone = new WalletPhoneNumbers((WalletItem) this);
      this._issuerAddress = new WalletAddresses((WalletItem) this);
      this._billingAddress = new WalletAddress((WalletItem) this, WalletItemPropertyType.BillingAddressStreet, WalletItemPropertyType.BillingAddressCity, WalletItemPropertyType.BillingAddressZip, WalletItemPropertyType.BillingAddressState, WalletItemPropertyType.BillingAddressCountry);
      this._transactionHistory = new WalletTransactionDictionary((WalletItem) this);
    }

    internal override void ThrowIfRequiredPropertiesNotSet()
    {
      using (NativeWalletItem nativeWalletItem = new NativeWalletItem((WalletItem) this))
      {
        this.ThrowIfValueIsFalse(nativeWalletItem.IsImagePropertySet(WalletItemPropertyType.BrandImageSmall), "Logo99x99");
        this.ThrowIfValueIsFalse(nativeWalletItem.IsImagePropertySet(WalletItemPropertyType.BrandImageMedium), "Logo159x159");
        this.ThrowIfValueIsFalse(nativeWalletItem.IsImagePropertySet(WalletItemPropertyType.BrandImageLarge), "Logo336x336");
      }
      base.ThrowIfRequiredPropertiesNotSet();
    }

    internal override void ClearPropertyCaches()
    {
      base.ClearPropertyCaches();
      this._transactionHistory.RefreshCacheFromDB();
    }

    public Uri TransactionHistoryNavigationUri
    {
      get => new Uri(this.GetWalletProperty<string>(WalletItemPropertyType.MoreTransactionsNavigationUri).Value, UriKind.Relative);
      set
      {
        this.EnsureRelativeUri(value);
        this.GetWalletProperty<string>(WalletItemPropertyType.MoreTransactionsNavigationUri).Value = value.ToString();
      }
    }

    public IDictionary<string, WalletTransaction> TransactionHistory => (IDictionary<string, WalletTransaction>) this._transactionHistory;

    internal void SetTransactionHistory(WalletTransactionDictionary wtd) => this._transactionHistory = wtd;

    public SecureElementProperties SecureElementProperties => this._secureElementProperties;

    public void NotifyActivationAuthenticationCompleted(ActivationAuthenticationResultKind result)
    {
      using (NativeWalletItem nativeWalletItem = new NativeWalletItem((WalletItem) this))
        nativeWalletItem.ActivationAuthenticationCompleted(result);
      ApplicationHost.Current.RootTask.Complete(0);
    }

    internal override InternalWalletProperty<string> ItemSpecificName => this.GetWalletProperty<string>(WalletItemPropertyType.CardName);

    public Color? BackgroundColor
    {
      get
      {
        Color? nullable1 = new Color?();
        int? nullable2 = this.GetWalletProperty<int?>(WalletItemPropertyType.BrandColor).Value;
        if (nullable2.HasValue)
        {
          ref Color? local = ref nullable1;
          int? nullable3 = nullable2;
          int num1 = 24;
          int? nullable4 = nullable3.HasValue ? new int?(nullable3.GetValueOrDefault() >> num1 & (int) byte.MaxValue) : new int?();
          int num2 = (int) (byte) nullable4.Value;
          nullable4 = nullable2;
          int num3 = 16;
          int? nullable5 = nullable4.HasValue ? new int?(nullable4.GetValueOrDefault() >> num3 & (int) byte.MaxValue) : new int?();
          int num4 = (int) (byte) nullable5.Value;
          nullable5 = nullable2;
          int num5 = 8;
          int? nullable6;
          if (!nullable5.HasValue)
          {
            nullable4 = new int?();
            nullable6 = nullable4;
          }
          else
            nullable6 = new int?(nullable5.GetValueOrDefault() >> num5 & (int) byte.MaxValue);
          nullable4 = nullable6;
          int num6 = (int) (byte) nullable4.Value;
          nullable4 = nullable2;
          int maxValue = (int) byte.MaxValue;
          int? nullable7;
          if (!nullable4.HasValue)
          {
            nullable5 = new int?();
            nullable7 = nullable5;
          }
          else
            nullable7 = new int?(nullable4.GetValueOrDefault() & maxValue);
          nullable5 = nullable7;
          int num7 = (int) (byte) nullable5.Value;
          Color color = Color.FromArgb((byte) num2, (byte) num4, (byte) num6, (byte) num7);
          local = new Color?(color);
        }
        return nullable1;
      }
      set
      {
        int? nullable = new int?();
        if (value.HasValue)
        {
          ref int? local = ref nullable;
          Color color = value.Value;
          int num1 = (int) color.A << 24;
          color = value.Value;
          int num2 = (int) color.R << 16;
          int num3 = num1 | num2;
          color = value.Value;
          int num4 = (int) color.G << 8;
          int num5 = num3 | num4;
          color = value.Value;
          int b = (int) color.B;
          int num6 = num5 | b;
          local = new int?(num6);
        }
        this.GetWalletProperty<int?>(WalletItemPropertyType.BrandColor).Value = nullable;
      }
    }

    public WalletItemUsages SupportedUsages
    {
      get
      {
        WalletItemUsages walletItemUsages = WalletItemUsages.None;
        if (this.IsSavedInWallet)
        {
          using (NativeWalletItem nativeWalletItem = new NativeWalletItem((WalletItem) this))
            walletItemUsages = nativeWalletItem.GetItemAbilities();
        }
        return walletItemUsages;
      }
    }

    public string Nickname
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.Nickname).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.Nickname).Value = value;
    }

    public string DisplayBalance
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.Balance).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.Balance).Value = value;
    }

    public string DisplayAvailableBalance
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.AvailableBalance).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.AvailableBalance).Value = value;
    }

    public string DisplayCreditLimit
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.CreditLimit).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.CreditLimit).Value = value;
    }

    public string DisplayAvailableCredit
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.AvailableCredit).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.AvailableCredit).Value = value;
    }

    public virtual WalletAddresses IssuerAddress => this._issuerAddress;

    public WalletPhoneNumbers IssuerPhone => this._issuerPhone;

    public WalletAddress BillingAddress
    {
      get => this._billingAddress;
      set => this._billingAddress.CopyFromAddress(value);
    }

    public string BillingPhone
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.BillingPhone).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.BillingPhone).Value = value;
    }
  }
}
