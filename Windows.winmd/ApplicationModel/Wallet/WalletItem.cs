// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.Wallet
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IWalletItemFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WalletItem : IWalletItem
  {
    [MethodImpl]
    public extern WalletItem(WalletItemKind kind, string displayName);

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern string Id { [MethodImpl] get; }

    public extern bool IsAcknowledged { [MethodImpl] get; [MethodImpl] set; }

    public extern string IssuerDisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> LastUpdated { [MethodImpl] get; [MethodImpl] set; }

    public extern WalletItemKind Kind { [MethodImpl] get; }

    public extern WalletBarcode Barcode { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> ExpirationDate { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Logo159x159 { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Logo336x336 { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Logo99x99 { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayMessage { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDisplayMessageLaunchable { [MethodImpl] get; [MethodImpl] set; }

    public extern string LogoText { [MethodImpl] get; [MethodImpl] set; }

    public extern Color HeaderColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color BodyColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color HeaderFontColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color BodyFontColor { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference HeaderBackgroundImage { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference BodyBackgroundImage { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference LogoImage { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference PromotionalImage { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> RelevantDate { [MethodImpl] get; [MethodImpl] set; }

    public extern string RelevantDateDisplayMessage { [MethodImpl] get; [MethodImpl] set; }

    public extern IMap<string, WalletTransaction> TransactionHistory { [MethodImpl] get; }

    public extern IMap<string, WalletRelevantLocation> RelevantLocations { [MethodImpl] get; }

    public extern bool IsMoreTransactionHistoryLaunchable { [MethodImpl] get; [MethodImpl] set; }

    public extern IMap<string, WalletItemCustomProperty> DisplayProperties { [MethodImpl] get; }

    public extern IMap<string, WalletVerb> Verbs { [MethodImpl] get; }
  }
}
