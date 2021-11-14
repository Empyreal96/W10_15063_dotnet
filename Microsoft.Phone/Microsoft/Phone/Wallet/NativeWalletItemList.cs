// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.NativeWalletItemList
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Wallet
{
  internal class NativeWalletItemList : IDisposable
  {
    private IntPtr _nativeWalletItemList = IntPtr.Zero;
    private bool _disposed;

    internal NativeWalletItemList(IntPtr nativeWalletItemList) => this._nativeWalletItemList = !(nativeWalletItemList == IntPtr.Zero) ? nativeWalletItemList : throw new ArgumentException();

    internal int Count
    {
      [SecuritySafeCritical] get
      {
        uint count;
        NativeHelpers.IfFailedHrThrowException(NativeMethods.GetListCount(this._nativeWalletItemList, out count));
        int num = (int) count;
        if (num < 0)
          num = 0;
        return num;
      }
    }

    [SecuritySafeCritical]
    internal WalletItem GetItemAt(uint index)
    {
      WalletItem walletItem = (WalletItem) null;
      IntPtr itemContext = IntPtr.Zero;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.GetItemByIndex(this._nativeWalletItemList, index, out itemContext));
      if (itemContext != IntPtr.Zero)
      {
        using (NativeWalletItem nativeWalletItem = new NativeWalletItem(itemContext))
          walletItem = nativeWalletItem.WalletItem;
      }
      return walletItem;
    }

    [SecuritySafeCritical]
    internal WalletTransaction GetWalletTransactionAt(uint index)
    {
      WalletTransaction walletTransaction = (WalletTransaction) null;
      IntPtr itemContext = IntPtr.Zero;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.GetItemByIndex(this._nativeWalletItemList, index, out itemContext));
      if (itemContext != IntPtr.Zero)
      {
        using (NativeWalletItem nativeWalletItem = new NativeWalletItem(itemContext))
        {
          if (nativeWalletItem.WalletItem is WalletTransactionValues walletItem2)
            walletTransaction = new WalletTransaction(walletItem2);
        }
      }
      return walletTransaction;
    }

    ~NativeWalletItemList() => this.Dispose(false);

    [SecuritySafeCritical]
    internal static NativeWalletItemList GetListOfAppOwnedItems()
    {
      NativeWalletItemList nativeWalletItemList = (NativeWalletItemList) null;
      IntPtr listContext = IntPtr.Zero;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.CreateWalletItemList(out listContext));
      if (listContext != IntPtr.Zero)
        nativeWalletItemList = new NativeWalletItemList(listContext);
      return nativeWalletItemList;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    [SecuritySafeCritical]
    protected virtual void Dispose(bool disposing)
    {
      if (this._disposed)
        return;
      int num = disposing ? 1 : 0;
      if (this._nativeWalletItemList != IntPtr.Zero)
      {
        NativeMethods.FreeWalletItemList(this._nativeWalletItemList);
        this._nativeWalletItemList = IntPtr.Zero;
      }
      this._disposed = true;
    }
  }
}
