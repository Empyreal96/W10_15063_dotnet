// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandModem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMobileBroadbandModemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class MobileBroadbandModem : IMobileBroadbandModem
  {
    public extern MobileBroadbandAccount CurrentAccount { [MethodImpl] get; }

    public extern MobileBroadbandDeviceInformation DeviceInformation { [MethodImpl] get; }

    public extern uint MaxDeviceServiceCommandSizeInBytes { [MethodImpl] get; }

    public extern uint MaxDeviceServiceDataSizeInBytes { [MethodImpl] get; }

    public extern IVectorView<MobileBroadbandDeviceServiceInformation> DeviceServices { [MethodImpl] get; }

    [MethodImpl]
    public extern MobileBroadbandDeviceService GetDeviceService(
      Guid deviceServiceId);

    public extern bool IsResetSupported { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ResetAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandModemConfiguration> GetCurrentConfigurationAsync();

    public extern MobileBroadbandNetwork CurrentNetwork { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [MethodImpl]
    public static extern MobileBroadbandModem FromId(string deviceId);

    [MethodImpl]
    public static extern MobileBroadbandModem GetDefault();
  }
}
