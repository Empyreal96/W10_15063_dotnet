// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletTransactionItem
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Wallet
{
  public sealed class WalletTransactionItem : WalletTransactionItemBase
  {
    public WalletTransactionItem()
    {
    }

    public WalletTransactionItem(string id)
      : base(id)
    {
    }

    internal WalletTransactionItem(string internalId, string id)
      : base(internalId, id)
    {
    }

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

    public string AccountNumber
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.CardAccountNumber).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.CardAccountNumber).Value = value;
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
