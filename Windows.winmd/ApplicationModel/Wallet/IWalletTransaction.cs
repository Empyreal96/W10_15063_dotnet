// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletTransaction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WalletTransaction))]
  [Guid(1088547136, 9734, 17689, 129, 203, 191, 241, 198, 13, 31, 121)]
  internal interface IWalletTransaction
  {
    string Description { get; set; }

    string DisplayAmount { get; set; }

    bool IgnoreTimeOfDay { get; set; }

    string DisplayLocation { get; set; }

    IReference<DateTime> TransactionDate { get; set; }

    bool IsLaunchable { get; set; }
  }
}
