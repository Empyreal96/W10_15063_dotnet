// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommDeviceService2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ExclusiveTo(typeof (RfcommDeviceService))]
  [Guid(1399647508, 60365, 18942, 191, 159, 64, 239, 198, 137, 178, 13)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRfcommDeviceService2 : IRfcommDeviceService
  {
    BluetoothDevice Device { get; }
  }
}
