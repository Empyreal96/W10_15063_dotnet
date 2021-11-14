// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.RfcommServiceProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [Static(typeof (IRfcommServiceProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  public sealed class RfcommServiceProvider : IRfcommServiceProvider, IRfcommServiceProvider2
  {
    public extern RfcommServiceId ServiceId { [MethodImpl] get; }

    public extern IMap<uint, IBuffer> SdpRawAttributes { [MethodImpl] get; }

    [MethodImpl]
    public extern void StartAdvertising(StreamSocketListener listener);

    [MethodImpl]
    public extern void StopAdvertising();

    [Overload("StartAdvertisingWithRadioDiscoverability")]
    [MethodImpl]
    public extern void StartAdvertising(StreamSocketListener listener, bool radioDiscoverable);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RfcommServiceProvider> CreateAsync(
      RfcommServiceId serviceId);
  }
}
