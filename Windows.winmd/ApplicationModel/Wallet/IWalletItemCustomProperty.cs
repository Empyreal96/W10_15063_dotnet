// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletItemCustomProperty
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [ExclusiveTo(typeof (WalletItemCustomProperty))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3108716787, 64000, 16637, 152, 220, 157, 228, 102, 151, 241, 231)]
  internal interface IWalletItemCustomProperty
  {
    string Name { get; set; }

    string Value { get; set; }

    bool AutoDetectLinks { get; set; }

    WalletDetailViewPosition DetailViewPosition { get; set; }

    WalletSummaryViewPosition SummaryViewPosition { get; set; }
  }
}
