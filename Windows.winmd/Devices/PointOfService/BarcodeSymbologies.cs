// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeSymbologies
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Static(typeof (IBarcodeSymbologiesStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBarcodeSymbologiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class BarcodeSymbologies
  {
    public static extern uint Gs1DWCode { [MethodImpl] get; }

    public static extern uint Unknown { [MethodImpl] get; }

    public static extern uint Ean8 { [MethodImpl] get; }

    public static extern uint Ean8Add2 { [MethodImpl] get; }

    public static extern uint Ean8Add5 { [MethodImpl] get; }

    public static extern uint Eanv { [MethodImpl] get; }

    public static extern uint EanvAdd2 { [MethodImpl] get; }

    public static extern uint EanvAdd5 { [MethodImpl] get; }

    public static extern uint Ean13 { [MethodImpl] get; }

    public static extern uint Ean13Add2 { [MethodImpl] get; }

    public static extern uint Ean13Add5 { [MethodImpl] get; }

    public static extern uint Isbn { [MethodImpl] get; }

    public static extern uint IsbnAdd5 { [MethodImpl] get; }

    public static extern uint Ismn { [MethodImpl] get; }

    public static extern uint IsmnAdd2 { [MethodImpl] get; }

    public static extern uint IsmnAdd5 { [MethodImpl] get; }

    public static extern uint Issn { [MethodImpl] get; }

    public static extern uint IssnAdd2 { [MethodImpl] get; }

    public static extern uint IssnAdd5 { [MethodImpl] get; }

    public static extern uint Ean99 { [MethodImpl] get; }

    public static extern uint Ean99Add2 { [MethodImpl] get; }

    public static extern uint Ean99Add5 { [MethodImpl] get; }

    public static extern uint Upca { [MethodImpl] get; }

    public static extern uint UpcaAdd2 { [MethodImpl] get; }

    public static extern uint UpcaAdd5 { [MethodImpl] get; }

    public static extern uint Upce { [MethodImpl] get; }

    public static extern uint UpceAdd2 { [MethodImpl] get; }

    public static extern uint UpceAdd5 { [MethodImpl] get; }

    public static extern uint UpcCoupon { [MethodImpl] get; }

    public static extern uint TfStd { [MethodImpl] get; }

    public static extern uint TfDis { [MethodImpl] get; }

    public static extern uint TfInt { [MethodImpl] get; }

    public static extern uint TfInd { [MethodImpl] get; }

    public static extern uint TfMat { [MethodImpl] get; }

    public static extern uint TfIata { [MethodImpl] get; }

    public static extern uint Gs1DatabarType1 { [MethodImpl] get; }

    public static extern uint Gs1DatabarType2 { [MethodImpl] get; }

    public static extern uint Gs1DatabarType3 { [MethodImpl] get; }

    public static extern uint Code39 { [MethodImpl] get; }

    public static extern uint Code39Ex { [MethodImpl] get; }

    public static extern uint Trioptic39 { [MethodImpl] get; }

    public static extern uint Code32 { [MethodImpl] get; }

    public static extern uint Pzn { [MethodImpl] get; }

    public static extern uint Code93 { [MethodImpl] get; }

    public static extern uint Code93Ex { [MethodImpl] get; }

    public static extern uint Code128 { [MethodImpl] get; }

    public static extern uint Gs1128 { [MethodImpl] get; }

    public static extern uint Gs1128Coupon { [MethodImpl] get; }

    public static extern uint UccEan128 { [MethodImpl] get; }

    public static extern uint Sisac { [MethodImpl] get; }

    public static extern uint Isbt { [MethodImpl] get; }

    public static extern uint Codabar { [MethodImpl] get; }

    public static extern uint Code11 { [MethodImpl] get; }

    public static extern uint Msi { [MethodImpl] get; }

    public static extern uint Plessey { [MethodImpl] get; }

    public static extern uint Telepen { [MethodImpl] get; }

    public static extern uint Code16k { [MethodImpl] get; }

    public static extern uint CodablockA { [MethodImpl] get; }

    public static extern uint CodablockF { [MethodImpl] get; }

    public static extern uint Codablock128 { [MethodImpl] get; }

    public static extern uint Code49 { [MethodImpl] get; }

    public static extern uint Aztec { [MethodImpl] get; }

    public static extern uint DataCode { [MethodImpl] get; }

    public static extern uint DataMatrix { [MethodImpl] get; }

    public static extern uint HanXin { [MethodImpl] get; }

    public static extern uint Maxicode { [MethodImpl] get; }

    public static extern uint MicroPdf417 { [MethodImpl] get; }

    public static extern uint MicroQr { [MethodImpl] get; }

    public static extern uint Pdf417 { [MethodImpl] get; }

    public static extern uint Qr { [MethodImpl] get; }

    public static extern uint MsTag { [MethodImpl] get; }

    public static extern uint Ccab { [MethodImpl] get; }

    public static extern uint Ccc { [MethodImpl] get; }

    public static extern uint Tlc39 { [MethodImpl] get; }

    public static extern uint AusPost { [MethodImpl] get; }

    public static extern uint CanPost { [MethodImpl] get; }

    public static extern uint ChinaPost { [MethodImpl] get; }

    public static extern uint DutchKix { [MethodImpl] get; }

    public static extern uint InfoMail { [MethodImpl] get; }

    public static extern uint ItalianPost25 { [MethodImpl] get; }

    public static extern uint ItalianPost39 { [MethodImpl] get; }

    public static extern uint JapanPost { [MethodImpl] get; }

    public static extern uint KoreanPost { [MethodImpl] get; }

    public static extern uint SwedenPost { [MethodImpl] get; }

    public static extern uint UkPost { [MethodImpl] get; }

    public static extern uint UsIntelligent { [MethodImpl] get; }

    public static extern uint UsIntelligentPkg { [MethodImpl] get; }

    public static extern uint UsPlanet { [MethodImpl] get; }

    public static extern uint UsPostNet { [MethodImpl] get; }

    public static extern uint Us4StateFics { [MethodImpl] get; }

    public static extern uint OcrA { [MethodImpl] get; }

    public static extern uint OcrB { [MethodImpl] get; }

    public static extern uint Micr { [MethodImpl] get; }

    public static extern uint ExtendedBase { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetName(uint scanDataType);
  }
}
