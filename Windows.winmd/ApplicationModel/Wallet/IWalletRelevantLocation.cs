// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletRelevantLocation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [Guid(2681763882, 58361, 19937, 186, 179, 187, 25, 46, 70, 179, 243)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WalletRelevantLocation))]
  internal interface IWalletRelevantLocation
  {
    BasicGeoposition Position { get; set; }

    string DisplayMessage { get; set; }
  }
}
