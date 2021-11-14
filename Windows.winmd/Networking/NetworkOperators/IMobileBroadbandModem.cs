// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandModem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandModem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3493161234, 59897, 20327, 160, 61, 67, 24, 154, 49, 107, 241)]
  internal interface IMobileBroadbandModem
  {
    MobileBroadbandAccount CurrentAccount { get; }

    MobileBroadbandDeviceInformation DeviceInformation { get; }

    uint MaxDeviceServiceCommandSizeInBytes { get; }

    uint MaxDeviceServiceDataSizeInBytes { get; }

    IVectorView<MobileBroadbandDeviceServiceInformation> DeviceServices { get; }

    MobileBroadbandDeviceService GetDeviceService(Guid deviceServiceId);

    bool IsResetSupported { get; }

    [RemoteAsync]
    IAsyncAction ResetAsync();

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandModemConfiguration> GetCurrentConfigurationAsync();

    MobileBroadbandNetwork CurrentNetwork { get; }
  }
}
