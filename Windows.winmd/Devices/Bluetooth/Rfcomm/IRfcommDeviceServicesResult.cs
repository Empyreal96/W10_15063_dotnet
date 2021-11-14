// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommDeviceServicesResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ExclusiveTo(typeof (RfcommDeviceServicesResult))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(994588812, 31951, 18574, 150, 37, 210, 89, 165, 115, 45, 85)]
  internal interface IRfcommDeviceServicesResult
  {
    BluetoothError Error { get; }

    IVectorView<RfcommDeviceService> Services { get; }
  }
}
