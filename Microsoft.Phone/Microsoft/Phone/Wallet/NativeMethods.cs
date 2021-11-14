// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.NativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Phone.Wallet
{
  internal static class NativeMethods
  {
    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int CreateWalletItem(WalletItemType offerId, out IntPtr itemContext);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern void FreeWalletItem(IntPtr itemContext);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetWalletItemType(
      IntPtr itemContext,
      out WalletItemType walletItemType);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetWalletItemInternalId(
      IntPtr itemContext,
      StringBuilder pszBuffer,
      int cchBuffer);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetWalletItemByAppItemId(string appItemId, out IntPtr itemContext);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetWalletItemByInternalId(string internalId, out IntPtr itemContext);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetWalletItemImageProperty(
      IntPtr itemContext,
      WalletItemPropertyType type,
      StringBuilder pszBuffer,
      int cchBuffer);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int SetWalletItemImageProperty(
      IntPtr itemContext,
      WalletItemPropertyType type,
      string value);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetWalletItemStringProperty(
      IntPtr itemContext,
      WalletItemPropertyType type,
      StringBuilder pszBuffer,
      int cchBuffer);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int SetWalletItemStringProperty(
      IntPtr itemContext,
      WalletItemPropertyType type,
      string value);

    [DllImport("WalletX.dll")]
    internal static extern int GetWalletItemBlobProperty(
      IntPtr itemContext,
      WalletItemPropertyType type,
      byte[] value,
      ref uint cbValue);

    [DllImport("WalletX.dll")]
    internal static extern int GetWalletItemBlobPropertySize(
      IntPtr itemContext,
      WalletItemPropertyType type,
      out uint cbValue);

    [DllImport("WalletX.dll")]
    internal static extern int SetWalletItemBlobProperty(
      IntPtr itemContext,
      WalletItemPropertyType type,
      byte[] value,
      int cbValue);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetWalletItemIntProperty(
      IntPtr itemContext,
      WalletItemPropertyType type,
      out int value);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int SetWalletItemIntProperty(
      IntPtr itemContext,
      WalletItemPropertyType type,
      int value);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetWalletItemFileTimeProperty(
      IntPtr itemContext,
      WalletItemPropertyType type,
      out long value);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int SetWalletItemFileTimeProperty(
      IntPtr itemContext,
      WalletItemPropertyType type,
      long value);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int SaveWalletItem(IntPtr itemContext);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int DeleteWalletItem(IntPtr itemContext);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int DeleteWalletItemProperty(
      IntPtr itemContext,
      WalletItemPropertyType type);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int AddWalletItem(
      IntPtr itemContext,
      out int userResult,
      StringBuilder pszBuffer,
      int cchBuffer);

    [DllImport("WalletX.dll")]
    internal static extern int AddWalletItemNotification(
      IntPtr itemContext,
      InternalNotificationType notificationType);

    [DllImport("WalletX.dll")]
    internal static extern int ItemHasUserAttentionRequired(
      IntPtr itemContext,
      out bool itemHasUserAttentionRequired);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetCustomPropertyKeys(IntPtr itemContext, [MarshalAs(UnmanagedType.LPWStr | UnmanagedType.U4)] ref string[] keys);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int SetCustomProperty(
      IntPtr itemContext,
      string pszKey,
      string pszLabel,
      string pszValue);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetCustomProperty(
      IntPtr itemContext,
      string pszKey,
      StringBuilder pszLabel,
      int cchLabel,
      StringBuilder pszValue,
      int cchValue);

    [DllImport("WalletX.dll")]
    internal static extern int GetItemAbilities(IntPtr itemContext, out int dwAbilities);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int UpdateAppItemId(IntPtr itemContext, string newId);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetTransactionsForWalletItem(
      IntPtr itemContext,
      out IntPtr listContext);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int CreateTransactionEntry(
      string internalWalletItemId,
      out IntPtr itemContext);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int DeleteTransactionEntry(string internalTransactionId);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int ActivationAuthenticationCompleted(IntPtr itemContext, int success);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int CreateWalletItemList(out IntPtr listContext);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern void FreeWalletItemList(IntPtr listContext);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetItemByIndex(
      IntPtr listContext,
      uint index,
      out IntPtr itemContext);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetListCount(IntPtr listContext, out uint count);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int DeleteAllAppOwnedWalletItems();

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetMaxCustomPropertiesAllowed(
      IntPtr itemContext,
      out uint maxCustomProperties);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetMaxTransactionsPerItemAllowed(out uint maxTransactions);

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetMaxLocationsPerItemAllowed(out uint maxLocations);

    [DllImport("WalletX.dll")]
    internal static extern int FreeWalletX();

    [DllImport("WalletX.dll", CharSet = CharSet.Unicode)]
    internal static extern string GetAppTempDirectory();
  }
}
