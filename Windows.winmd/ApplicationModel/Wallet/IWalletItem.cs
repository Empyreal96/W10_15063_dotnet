// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.Wallet
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WalletItem))]
  [Guid(548752360, 4493, 20164, 153, 108, 185, 99, 231, 189, 62, 116)]
  internal interface IWalletItem
  {
    string DisplayName { get; set; }

    string Id { get; }

    bool IsAcknowledged { get; set; }

    string IssuerDisplayName { get; set; }

    IReference<DateTime> LastUpdated { get; set; }

    WalletItemKind Kind { get; }

    WalletBarcode Barcode { get; set; }

    IReference<DateTime> ExpirationDate { get; set; }

    IRandomAccessStreamReference Logo159x159 { get; set; }

    IRandomAccessStreamReference Logo336x336 { get; set; }

    IRandomAccessStreamReference Logo99x99 { get; set; }

    string DisplayMessage { get; set; }

    bool IsDisplayMessageLaunchable { get; set; }

    string LogoText { get; set; }

    Color HeaderColor { get; set; }

    Color BodyColor { get; set; }

    Color HeaderFontColor { get; set; }

    Color BodyFontColor { get; set; }

    IRandomAccessStreamReference HeaderBackgroundImage { get; set; }

    IRandomAccessStreamReference BodyBackgroundImage { get; set; }

    IRandomAccessStreamReference LogoImage { get; set; }

    IRandomAccessStreamReference PromotionalImage { get; set; }

    IReference<DateTime> RelevantDate { get; set; }

    string RelevantDateDisplayMessage { get; set; }

    IMap<string, WalletTransaction> TransactionHistory { get; }

    IMap<string, WalletRelevantLocation> RelevantLocations { get; }

    bool IsMoreTransactionHistoryLaunchable { get; set; }

    IMap<string, WalletItemCustomProperty> DisplayProperties { get; }

    IMap<string, WalletVerb> Verbs { get; }
  }
}
