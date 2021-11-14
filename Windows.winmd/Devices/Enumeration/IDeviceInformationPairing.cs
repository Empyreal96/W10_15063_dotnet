// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationPairing
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DeviceInformationPairing))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(742877685, 63108, 16597, 132, 105, 232, 219, 170, 183, 4, 133)]
  internal interface IDeviceInformationPairing
  {
    bool IsPaired { get; }

    bool CanPair { get; }

    [Overload("PairAsync")]
    [RemoteAsync]
    IAsyncOperation<DevicePairingResult> PairAsync();

    [RemoteAsync]
    [Overload("PairWithProtectionLevelAsync")]
    IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingProtectionLevel minProtectionLevel);
  }
}
