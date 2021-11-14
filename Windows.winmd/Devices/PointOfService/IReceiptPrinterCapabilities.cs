// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IReceiptPrinterCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ReceiptPrinterCapabilities))]
  [Guid(3102782863, 20904, 17404, 155, 213, 141, 226, 114, 166, 65, 91)]
  internal interface IReceiptPrinterCapabilities : 
    ICommonReceiptSlipCapabilities,
    ICommonPosPrintStationCapabilities
  {
    bool CanCutPaper { get; }

    bool IsStampSupported { get; }

    PosPrinterMarkFeedCapabilities MarkFeedCapabilities { get; }
  }
}
