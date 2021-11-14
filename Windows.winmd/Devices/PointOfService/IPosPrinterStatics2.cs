// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (PosPrinter))]
  [Guid(4006423580, 45264, 17127, 177, 55, 184, 155, 22, 36, 77, 65)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPosPrinterStatics2
  {
    [Overload("GetDeviceSelectorWithConnectionTypes")]
    string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
