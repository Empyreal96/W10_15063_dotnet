// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IGattServiceProviderConnectionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattServiceProviderConnection))]
  [Guid(1028693835, 2830, 17510, 184, 205, 110, 189, 218, 31, 161, 125)]
  internal interface IGattServiceProviderConnectionStatics
  {
    IMapView<string, GattServiceProviderConnection> AllServices { get; }
  }
}
