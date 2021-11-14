// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2015540173, 10377, 20358, 160, 81, 63, 10, 237, 28, 39, 96)]
  [ExclusiveTo(typeof (GattServiceProvider))]
  internal interface IGattServiceProvider
  {
    GattLocalService Service { get; }

    GattServiceProviderAdvertisementStatus AdvertisementStatus { get; }

    event TypedEventHandler<GattServiceProvider, GattServiceProviderAdvertisementStatusChangedEventArgs> AdvertisementStatusChanged;

    [Overload("StartAdvertising")]
    void StartAdvertising();

    [Overload("StartAdvertisingWithParameters")]
    void StartAdvertising(
      GattServiceProviderAdvertisingParameters parameters);

    void StopAdvertising();
  }
}
