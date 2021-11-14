// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.NativeWallet
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Security;

namespace Microsoft.Phone.Wallet
{
  internal class NativeWallet
  {
    [SecuritySafeCritical]
    internal static void DeleteAllAppOwnedWalletItems() => NativeHelpers.IfFailedHrThrowException(NativeMethods.DeleteAllAppOwnedWalletItems());

    [SecuritySafeCritical]
    internal static int GetMaxTransactionsPerItemAllowed()
    {
      uint maxTransactions = 0;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.GetMaxTransactionsPerItemAllowed(out maxTransactions));
      if (maxTransactions > (uint) int.MaxValue)
        maxTransactions = (uint) int.MaxValue;
      return (int) maxTransactions;
    }

    [SecuritySafeCritical]
    internal static int GetMaxLocationsPerItemAllowed()
    {
      uint maxLocations = 0;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.GetMaxLocationsPerItemAllowed(out maxLocations));
      if (maxLocations > (uint) int.MaxValue)
        maxLocations = (uint) int.MaxValue;
      return (int) maxLocations;
    }

    [SecuritySafeCritical]
    internal static void FreeWallet() => NativeHelpers.IfFailedHrThrowException(NativeMethods.FreeWalletX());
  }
}
