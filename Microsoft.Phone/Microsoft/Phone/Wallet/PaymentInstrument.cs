// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.PaymentInstrument
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Wallet
{
  public sealed class PaymentInstrument : WalletTransactionItemBase
  {
    public PaymentInstrument()
    {
    }

    public PaymentInstrument(string id)
      : base(id)
    {
    }

    internal PaymentInstrument(string internalId, string id)
      : base(internalId, id)
    {
    }

    internal override void Initialize() => base.Initialize();

    internal override void ThrowIfRequiredPropertiesNotSet()
    {
      this.ThrowIfValueIsFalse((uint) this.PaymentInstrumentKinds > 0U, "PaymentInstrumentKinds");
      base.ThrowIfRequiredPropertiesNotSet();
    }

    public PaymentInstrumentKinds PaymentInstrumentKinds
    {
      get => (PaymentInstrumentKinds) this.GetWalletProperty<PaymentCardKinds?>(WalletItemPropertyType.PaymentCardType).Value.GetValueOrDefault(PaymentCardKinds.Undefined);
      set
      {
        PaymentCardKinds paymentCardKinds = Enum.IsDefined(typeof (PaymentInstrumentKinds), (object) value) ? (PaymentCardKinds) value : throw new ArgumentOutOfRangeException("value is outside the bounds of this type");
        this.GetWalletProperty<PaymentCardKinds?>(WalletItemPropertyType.PaymentCardType).Value = new PaymentCardKinds?(paymentCardKinds);
      }
    }

    public string PaymentNetwork
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.CardPaymentNetwork).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.CardPaymentNetwork).Value = value;
    }

    public string OtherPaymentNetworks
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.CardOtherPaymentNetworks).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.CardOtherPaymentNetworks).Value = value;
    }

    public string AccountNumber
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.CardAccountNumber).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.CardAccountNumber).Value = value;
    }

    public DateTime? ExpirationDate
    {
      get => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.ExpirationDate).Value;
      set => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.ExpirationDate).Value = value;
    }

    public DateTime? MemberSince
    {
      get => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.MemberSince).Value;
      set => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.MemberSince).Value = value;
    }

    public string TermsAndConditions
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.Terms).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.Terms).Value = value;
    }
  }
}
