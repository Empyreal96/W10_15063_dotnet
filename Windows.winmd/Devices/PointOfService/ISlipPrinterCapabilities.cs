// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ISlipPrinterCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SlipPrinterCapabilities))]
  [Guid(2578539417, 18572, 16727, 138, 194, 159, 87, 247, 8, 211, 219)]
  internal interface ISlipPrinterCapabilities : 
    ICommonReceiptSlipCapabilities,
    ICommonPosPrintStationCapabilities
  {
    bool IsFullLengthSupported { get; }

    bool IsBothSidesPrintingSupported { get; }
  }
}
