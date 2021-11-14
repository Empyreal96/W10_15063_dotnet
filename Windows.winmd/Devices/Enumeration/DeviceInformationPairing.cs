// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceInformationPairing
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDeviceInformationPairingStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DeviceInformationPairing : 
    IDeviceInformationPairing,
    IDeviceInformationPairing2
  {
    public extern bool IsPaired { [MethodImpl] get; }

    public extern bool CanPair { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("PairAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync();

    [RemoteAsync]
    [Overload("PairWithProtectionLevelAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingProtectionLevel minProtectionLevel);

    public extern DevicePairingProtectionLevel ProtectionLevel { [MethodImpl] get; }

    public extern DeviceInformationCustomPairing Custom { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("PairWithProtectionLevelAndSettingsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingProtectionLevel minProtectionLevel,
      IDevicePairingSettings devicePairingSettings);

    [RemoteAsync]
    [Overload("UnpairAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DeviceUnpairingResult> UnpairAsync();

    [MethodImpl]
    public static extern bool TryRegisterForAllInboundPairingRequests(
      DevicePairingKinds pairingKindsSupported);
  }
}
