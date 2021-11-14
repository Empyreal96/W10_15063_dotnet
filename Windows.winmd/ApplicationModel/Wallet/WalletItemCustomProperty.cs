// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletItemCustomProperty
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IWalletItemCustomPropertyFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WalletItemCustomProperty : IWalletItemCustomProperty
  {
    [MethodImpl]
    public extern WalletItemCustomProperty(string name, string value);

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string Value { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AutoDetectLinks { [MethodImpl] get; [MethodImpl] set; }

    public extern WalletDetailViewPosition DetailViewPosition { [MethodImpl] get; [MethodImpl] set; }

    public extern WalletSummaryViewPosition SummaryViewPosition { [MethodImpl] get; [MethodImpl] set; }
  }
}
