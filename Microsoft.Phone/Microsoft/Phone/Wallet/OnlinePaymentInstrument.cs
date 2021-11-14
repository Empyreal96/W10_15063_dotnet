// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.OnlinePaymentInstrument
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace Microsoft.Phone.Wallet
{
  public sealed class OnlinePaymentInstrument : WalletTransactionItemBase
  {
    internal OnlinePaymentInstrument()
    {
    }

    internal OnlinePaymentInstrument(string id)
      : base(id)
    {
    }

    internal OnlinePaymentInstrument(string internalId, string id)
      : base(internalId, id)
    {
    }

    public string OnlinePaymentInstrumentKind
    {
      get
      {
        PaymentCardKinds? nullable = this.GetWalletProperty<PaymentCardKinds?>(WalletItemPropertyType.PaymentCardType).Value;
        string str = (string) null;
        if (nullable.HasValue)
          str = Microsoft.Phone.Wallet.OnlinePaymentInstrumentKind.MapNativeValueToManagedString((int) nullable.Value);
        return str;
      }
    }

    public string FirstName
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.FirstName).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.FirstName).Value = value;
    }

    public string LastName
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.LastName).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.LastName).Value = value;
    }

    public string UserEmail => this.GetWalletProperty<string>(WalletItemPropertyType.UserEmail).Value;
  }
}
