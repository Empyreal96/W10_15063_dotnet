// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationPairing2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(4135981821, 2798, 17192, 133, 204, 28, 116, 43, 177, 121, 13)]
  [ExclusiveTo(typeof (DeviceInformationPairing))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IDeviceInformationPairing2
  {
    DevicePairingProtectionLevel ProtectionLevel { get; }

    DeviceInformationCustomPairing Custom { get; }

    [RemoteAsync]
    [Overload("PairWithProtectionLevelAndSettingsAsync")]
    IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingProtectionLevel minProtectionLevel,
      IDevicePairingSettings devicePairingSettings);

    [RemoteAsync]
    [Overload("UnpairAsync")]
    IAsyncOperation<DeviceUnpairingResult> UnpairAsync();
  }
}
