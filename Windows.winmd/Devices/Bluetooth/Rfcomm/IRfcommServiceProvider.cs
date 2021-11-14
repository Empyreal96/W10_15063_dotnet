// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommServiceProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [Guid(3940285892, 45558, 17663, 159, 124, 231, 168, 42, 184, 104, 33)]
  [ExclusiveTo(typeof (RfcommServiceProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRfcommServiceProvider
  {
    RfcommServiceId ServiceId { get; }

    IMap<uint, IBuffer> SdpRawAttributes { get; }

    void StartAdvertising(StreamSocketListener listener);

    void StopAdvertising();
  }
}
