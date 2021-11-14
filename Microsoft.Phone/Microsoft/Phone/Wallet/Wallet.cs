// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.Wallet
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Threading.Tasks;

namespace Microsoft.Phone.Wallet
{
  public static class Wallet
  {
    public static Task<WalletItemCollection> GetItemsAsync() => new TaskFactory<WalletItemCollection>().StartNew((Func<WalletItemCollection>) (() => new WalletItemCollection()));

    public static void Clear() => NativeWallet.DeleteAllAppOwnedWalletItems();

    public static bool Remove(string id)
    {
      bool flag = false;
      using (NativeWalletItem byId = NativeWalletItem.GetById(id))
      {
        if (byId != null)
        {
          byId.DeleteItemFromWallet();
          flag = true;
        }
      }
      return flag;
    }

    public static bool Remove(WalletItem item)
    {
      bool flag = false;
      if (item.IsSavedInWallet)
      {
        string id = item.Id;
        flag = Microsoft.Phone.Wallet.Wallet.Remove(item.Id);
        if (flag)
        {
          item.ResetItem();
          item.SetId(id);
        }
      }
      return flag;
    }

    public static WalletItem FindItem(string id)
    {
      WalletItem walletItem = (WalletItem) null;
      using (NativeWalletItem byId = NativeWalletItem.GetById(id))
      {
        if (byId != null)
          walletItem = byId.WalletItem;
      }
      return walletItem;
    }

    internal static WalletItem FindItemByInternalId(string id)
    {
      WalletItem walletItem = (WalletItem) null;
      using (NativeWalletItem byInternalId = NativeWalletItem.GetByInternalId(id))
      {
        if (byInternalId != null)
          walletItem = byInternalId.WalletItem;
      }
      return walletItem;
    }
  }
}
