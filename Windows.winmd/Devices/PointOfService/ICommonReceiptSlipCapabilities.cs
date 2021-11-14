// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICommonReceiptSlipCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(153643915, 39027, 19717, 191, 190, 71, 39, 166, 3, 143, 105)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICommonReceiptSlipCapabilities : ICommonPosPrintStationCapabilities
  {
    bool IsBarcodeSupported { get; }

    bool IsBitmapSupported { get; }

    bool IsLeft90RotationSupported { get; }

    bool IsRight90RotationSupported { get; }

    bool Is180RotationSupported { get; }

    bool IsPrintAreaSupported { get; }

    PosPrinterRuledLineCapabilities RuledLineCapabilities { get; }

    IVectorView<PosPrinterRotation> SupportedBarcodeRotations { get; }

    IVectorView<PosPrinterRotation> SupportedBitmapRotations { get; }
  }
}
