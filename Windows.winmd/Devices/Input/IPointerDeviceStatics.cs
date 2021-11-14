// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IPointerDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [Guid(3635976865, 53702, 16750, 189, 141, 87, 144, 145, 77, 197, 99)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PointerDevice))]
  internal interface IPointerDeviceStatics
  {
    PointerDevice GetPointerDevice(uint pointerId);

    IVectorView<PointerDevice> GetPointerDevices();
  }
}
