// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletRelevantLocation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WalletRelevantLocation : IWalletRelevantLocation
  {
    [MethodImpl]
    public extern WalletRelevantLocation();

    public extern BasicGeoposition Position { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayMessage { [MethodImpl] get; [MethodImpl] set; }
  }
}
