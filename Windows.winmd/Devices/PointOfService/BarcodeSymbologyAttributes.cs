// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeSymbologyAttributes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class BarcodeSymbologyAttributes : IBarcodeSymbologyAttributes
  {
    public extern bool IsCheckDigitValidationEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCheckDigitValidationSupported { [MethodImpl] get; }

    public extern bool IsCheckDigitTransmissionEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCheckDigitTransmissionSupported { [MethodImpl] get; }

    public extern uint DecodeLength1 { [MethodImpl] get; [MethodImpl] set; }

    public extern uint DecodeLength2 { [MethodImpl] get; [MethodImpl] set; }

    public extern BarcodeSymbologyDecodeLengthKind DecodeLengthKind { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDecodeLengthSupported { [MethodImpl] get; }
  }
}
