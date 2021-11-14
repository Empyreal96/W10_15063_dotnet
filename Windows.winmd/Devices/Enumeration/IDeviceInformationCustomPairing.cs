// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationCustomPairing
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DeviceInformationCustomPairing))]
  [Guid(2232650754, 20198, 18708, 131, 112, 16, 122, 57, 20, 76, 14)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IDeviceInformationCustomPairing
  {
    [RemoteAsync]
    [Overload("PairAsync")]
    IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported);

    [RemoteAsync]
    [Overload("PairWithProtectionLevelAsync")]
    IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported,
      DevicePairingProtectionLevel minProtectionLevel);

    [RemoteAsync]
    [Overload("PairWithProtectionLevelAndSettingsAsync")]
    IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported,
      DevicePairingProtectionLevel minProtectionLevel,
      IDevicePairingSettings devicePairingSettings);

    event TypedEventHandler<DeviceInformationCustomPairing, DevicePairingRequestedEventArgs> PairingRequested;
  }
}
