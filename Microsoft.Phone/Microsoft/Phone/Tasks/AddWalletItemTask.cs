// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.AddWalletItemTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using Microsoft.Phone.Wallet;
using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Tasks
{
  public class AddWalletItemTask : ChooserBase<AddWalletItemResult>
  {
    public WalletItem Item { get; set; }

    public override void Show()
    {
      ConfirmAddWalletItemResult walletItemResult = ConfirmAddWalletItemResult.Cancel;
      if (this.Item == null)
        throw new ArgumentNullException("There needs to be an Item to add");
      if (!AddWalletItemTask.AddWalletItemTaskRequired(this.Item))
        throw new ArgumentException("item cannot be added via this task");
      if (this.Item.IsSavedInWallet)
        throw new ArgumentException("Item is already in the wallet");
      this.Item.EnsureRequiredPropertiesAreSet();
      using (NativeWalletItem nativeWalletItem = new NativeWalletItem(this.Item))
        walletItemResult = nativeWalletItem.AddWalletItem();
      switch (walletItemResult)
      {
        case ConfirmAddWalletItemResult.Cancel:
          this.FireCompleted((object) this, new AddWalletItemResult(TaskResult.Cancel)
          {
            Item = this.Item
          }, (Delegate) null);
          break;
        case ConfirmAddWalletItemResult.Review:
          this.FireCompleted((object) this, new AddWalletItemResult(TaskResult.Cancel)
          {
            Item = this.Item
          }, (Delegate) null);
          break;
        case ConfirmAddWalletItemResult.Saved:
          AddWalletItemResult e = new AddWalletItemResult(TaskResult.OK);
          e.Item = this.Item;
          this.SaveTransactions();
          this.FireCompleted((object) this, e, (Delegate) null);
          break;
      }
    }

    internal static bool AddWalletItemTaskRequired(WalletItem item) => item is PaymentInstrument || item is WalletTransactionItem;

    internal override ParameterPropertyBag BuildParameterPropertyBag() => new ParameterPropertyBag();

    private void SaveTransactions()
    {
      if (!(this.Item is WalletTransactionItemBase transactionItemBase) || transactionItemBase.TransactionHistory.Count <= 0)
        return;
      foreach (WalletPropertyBase walletPropertyBase in (IEnumerable<WalletTransaction>) transactionItemBase.TransactionHistory.Values)
        walletPropertyBase.HasPendingWrite = true;
      this.Item.Save();
    }
  }
}
