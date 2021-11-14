// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletTransaction
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Wallet
{
  public class WalletTransaction : WalletPropertyBase
  {
    internal WalletTransactionValues _values;
    private string _internalKey;

    internal WalletTransactionValues Values
    {
      get => this._values;
      set => this._values = value;
    }

    internal string InternalTransactionId
    {
      get
      {
        string str = (string) null;
        if (this.Values != null)
          str = this.Values.InternalId;
        return str;
      }
    }

    internal string OwningItemInternalId
    {
      get
      {
        string str = (string) null;
        if (this.OwnerItem != null)
          str = this.OwnerItem.InternalId;
        return str;
      }
    }

    public WalletTransaction() => this.Values = new WalletTransactionValues();

    internal WalletTransaction(WalletTransactionValues values)
    {
      this.Values = values;
      this.Key = this.Values.Id;
    }

    public DateTime? TransactionDate
    {
      get => this.Values.TransactionDate;
      set
      {
        this.Values.TransactionDate = value;
        this.HasPendingWrite = true;
      }
    }

    public string Id => this.Key;

    internal override string InternalKey
    {
      get
      {
        if (this.Values != null && this.Values.IsSavedInWallet)
          this._internalKey = this.Values.InternalId;
        return this._internalKey;
      }
      set => this._internalKey = value;
    }

    public Uri NavigationUri
    {
      get => this.Values.NavigationUri;
      set
      {
        this.Values.NavigationUri = value;
        this.HasPendingWrite = true;
      }
    }

    public string Location
    {
      get => this.Values.Location;
      set
      {
        this.Values.Location = value;
        this.HasPendingWrite = true;
      }
    }

    public string Description
    {
      get => this.Values.DisplayName;
      set
      {
        this.Values.DisplayName = value;
        this.HasPendingWrite = true;
      }
    }

    public string DisplayAmount
    {
      get => this.Values.Amount;
      set
      {
        this.Values.Amount = value;
        this.HasPendingWrite = true;
      }
    }

    public bool IsTransactionTimeValid
    {
      get => this.Values.DisplayTime;
      set
      {
        this.Values.DisplayTime = value;
        this.HasPendingWrite = true;
      }
    }

    internal override bool IsEmpty => string.IsNullOrEmpty(this.Description) || !this.TransactionDate.HasValue;
  }
}
