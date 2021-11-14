// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletItemCollection
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Phone.Wallet
{
  public class WalletItemCollection : ICollection<WalletItem>, IEnumerable<WalletItem>, IEnumerable
  {
    private List<WalletItem> _itemList = new List<WalletItem>();

    internal WalletItemCollection() => this.RefreshLocalListOfAppOwnedItems();

    public void Add(WalletItem item) => throw new NotSupportedException("This collection is readonly.");

    public void Clear() => throw new NotSupportedException("This collection is readonly.");

    public bool Contains(WalletItem item) => this._itemList.Contains(item);

    public bool Contains(string id) => this.GetById(id) != null;

    public void CopyTo(WalletItem[] array, int arrayIndex) => throw new NotSupportedException();

    public int Count => this._itemList.Count;

    public bool IsReadOnly => true;

    public bool Remove(WalletItem item) => throw new NotSupportedException("This collection is readonly.");

    public IEnumerator<WalletItem> GetEnumerator() => (IEnumerator<WalletItem>) this._itemList.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this._itemList.GetEnumerator();

    public WalletItem GetById(string id)
    {
      WalletItem walletItem1 = (WalletItem) null;
      foreach (WalletItem walletItem2 in this._itemList)
      {
        if (walletItem2.Id == id)
        {
          walletItem1 = walletItem2;
          break;
        }
      }
      return walletItem1;
    }

    internal WalletItem GetByInternalId(string internalId)
    {
      WalletItem walletItem1 = (WalletItem) null;
      foreach (WalletItem walletItem2 in this._itemList)
      {
        if (walletItem2.InternalId == internalId)
        {
          walletItem1 = walletItem2;
          break;
        }
      }
      return walletItem1;
    }

    internal void RefreshLocalListOfAppOwnedItems()
    {
      using (NativeWalletItemList listOfAppOwnedItems = NativeWalletItemList.GetListOfAppOwnedItems())
      {
        this._itemList.Clear();
        int count = listOfAppOwnedItems.Count;
        for (uint index = 0; (long) index < (long) count; ++index)
        {
          WalletItem itemAt = listOfAppOwnedItems.GetItemAt(index);
          if (itemAt != null)
            this._itemList.Add(itemAt);
        }
      }
    }
  }
}
