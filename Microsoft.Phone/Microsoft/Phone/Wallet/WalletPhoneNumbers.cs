// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletPhoneNumbers
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Wallet
{
  public class WalletPhoneNumbers
  {
    private WalletItem OwnerItem { get; set; }

    internal WalletPhoneNumbers(WalletItem owner) => this.OwnerItem = owner;

    public string CustomerService
    {
      get
      {
        this.EnsureWalletTransactionItemBase();
        return this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.CustomerServicePhone).Value;
      }
      set
      {
        this.EnsureWalletTransactionItemBase();
        this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.CustomerServicePhone).Value = value;
      }
    }

    public string InternationalCustomerService
    {
      get
      {
        this.EnsureWalletTransactionItemBase();
        return this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.CustomerService2Phone).Value;
      }
      set
      {
        this.EnsureWalletTransactionItemBase();
        this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.CustomerService2Phone).Value = value;
      }
    }

    public string Business
    {
      get => this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.BusinessPhone).Value;
      set => this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.BusinessPhone).Value = value;
    }

    public string ReportLostCard
    {
      get
      {
        this.EnsureWalletTransactionItemBase();
        return this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.ReportLostCardPhone).Value;
      }
      set
      {
        this.EnsureWalletTransactionItemBase();
        this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.ReportLostCardPhone).Value = value;
      }
    }

    public string InternationalReportLostCard
    {
      get
      {
        this.EnsureWalletTransactionItemBase();
        return this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.ReportLostCard2Phone).Value;
      }
      set
      {
        this.EnsureWalletTransactionItemBase();
        this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.ReportLostCard2Phone).Value = value;
      }
    }

    public string Fax
    {
      get => this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.FaxPhone).Value;
      set => this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.FaxPhone).Value = value;
    }

    public string Other
    {
      get => this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.OtherPhone).Value;
      set => this.OwnerItem.GetWalletProperty<string>(WalletItemPropertyType.OtherPhone).Value = value;
    }

    private void EnsureWalletTransactionItemBase()
    {
      if (!(this.OwnerItem is WalletTransactionItemBase))
        throw new NotSupportedException();
    }
  }
}
