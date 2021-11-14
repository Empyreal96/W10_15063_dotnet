// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeSymbologyAttributes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (BarcodeSymbologyAttributes))]
  [Guid(1715550840, 43898, 19162, 142, 206, 147, 96, 20, 178, 234, 215)]
  internal interface IBarcodeSymbologyAttributes
  {
    bool IsCheckDigitValidationEnabled { get; set; }

    bool IsCheckDigitValidationSupported { get; }

    bool IsCheckDigitTransmissionEnabled { get; set; }

    bool IsCheckDigitTransmissionSupported { get; }

    uint DecodeLength1 { get; set; }

    uint DecodeLength2 { get; set; }

    BarcodeSymbologyDecodeLengthKind DecodeLengthKind { get; set; }

    bool IsDecodeLengthSupported { get; }
  }
}
