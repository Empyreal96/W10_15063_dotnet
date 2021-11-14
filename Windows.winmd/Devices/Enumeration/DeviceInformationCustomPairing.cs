// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceInformationCustomPairing
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class DeviceInformationCustomPairing : IDeviceInformationCustomPairing
  {
    [Overload("PairAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported);

    [Overload("PairWithProtectionLevelAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported,
      DevicePairingProtectionLevel minProtectionLevel);

    [RemoteAsync]
    [Overload("PairWithProtectionLevelAndSettingsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported,
      DevicePairingProtectionLevel minProtectionLevel,
      IDevicePairingSettings devicePairingSettings);

    public extern event TypedEventHandler<DeviceInformationCustomPairing, DevicePairingRequestedEventArgs> PairingRequested;
  }
}
