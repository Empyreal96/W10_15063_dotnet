// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedBarcodeScanner1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ClaimedBarcodeScanner))]
  [Guid(4128943372, 34129, 17076, 153, 140, 151, 12, 32, 33, 10, 34)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IClaimedBarcodeScanner1 : IClosable
  {
    [RemoteAsync]
    IAsyncAction StartSoftwareTriggerAsync();

    [RemoteAsync]
    IAsyncAction StopSoftwareTriggerAsync();
  }
}
