// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletTransactionValues
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Wallet
{
  internal class WalletTransactionValues : WalletItem
  {
    internal WalletTransactionValues()
    {
    }

    internal WalletTransactionValues(string id)
      : base(id)
    {
    }

    internal WalletTransactionValues(string internalId, string id)
      : base(internalId, id)
    {
    }

    internal override void ThrowIfRequiredPropertiesNotSet()
    {
      this.ThrowIfValueIsFalse(this.TransactionDate.HasValue, "TransactionDate");
      base.ThrowIfRequiredPropertiesNotSet();
    }

    internal override InternalWalletProperty<string> ItemSpecificName => this.GetWalletProperty<string>(WalletItemPropertyType.TransactionDescription);

    public DateTime? TransactionDate
    {
      get => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.TransactionDate).Value;
      set => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.TransactionDate).Value = value;
    }

    public string Location
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.TransactionLocation).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.TransactionLocation).Value = value;
    }

    public string Description
    {
      get => this.DisplayName;
      set => this.DisplayName = value;
    }

    public string Amount
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.TransactionAmount).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.TransactionAmount).Value = value;
    }

    public bool DisplayTime
    {
      get => this.GetWalletProperty<bool?>(WalletItemPropertyType.TransactionTimeIsValid).Value.GetValueOrDefault(false);
      set => this.GetWalletProperty<bool?>(WalletItemPropertyType.TransactionTimeIsValid).Value = new bool?(value);
    }
  }
}
