// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommServiceProvider2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ExclusiveTo(typeof (RfcommServiceProvider))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1936449478, 15489, 19742, 186, 242, 221, 187, 129, 40, 69, 18)]
  internal interface IRfcommServiceProvider2 : IRfcommServiceProvider
  {
    [Overload("StartAdvertisingWithRadioDiscoverability")]
    void StartAdvertising(StreamSocketListener listener, bool radioDiscoverable);
  }
}
