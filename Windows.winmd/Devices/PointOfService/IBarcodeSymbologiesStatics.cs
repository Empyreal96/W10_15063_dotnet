// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeSymbologiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3397732795, 1746, 17396, 164, 75, 198, 32, 103, 159, 216, 208)]
  [ExclusiveTo(typeof (BarcodeSymbologies))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBarcodeSymbologiesStatics
  {
    uint Unknown { get; }

    uint Ean8 { get; }

    uint Ean8Add2 { get; }

    uint Ean8Add5 { get; }

    uint Eanv { get; }

    uint EanvAdd2 { get; }

    uint EanvAdd5 { get; }

    uint Ean13 { get; }

    uint Ean13Add2 { get; }

    uint Ean13Add5 { get; }

    uint Isbn { get; }

    uint IsbnAdd5 { get; }

    uint Ismn { get; }

    uint IsmnAdd2 { get; }

    uint IsmnAdd5 { get; }

    uint Issn { get; }

    uint IssnAdd2 { get; }

    uint IssnAdd5 { get; }

    uint Ean99 { get; }

    uint Ean99Add2 { get; }

    uint Ean99Add5 { get; }

    uint Upca { get; }

    uint UpcaAdd2 { get; }

    uint UpcaAdd5 { get; }

    uint Upce { get; }

    uint UpceAdd2 { get; }

    uint UpceAdd5 { get; }

    uint UpcCoupon { get; }

    uint TfStd { get; }

    uint TfDis { get; }

    uint TfInt { get; }

    uint TfInd { get; }

    uint TfMat { get; }

    uint TfIata { get; }

    uint Gs1DatabarType1 { get; }

    uint Gs1DatabarType2 { get; }

    uint Gs1DatabarType3 { get; }

    uint Code39 { get; }

    uint Code39Ex { get; }

    uint Trioptic39 { get; }

    uint Code32 { get; }

    uint Pzn { get; }

    uint Code93 { get; }

    uint Code93Ex { get; }

    uint Code128 { get; }

    uint Gs1128 { get; }

    uint Gs1128Coupon { get; }

    uint UccEan128 { get; }

    uint Sisac { get; }

    uint Isbt { get; }

    uint Codabar { get; }

    uint Code11 { get; }

    uint Msi { get; }

    uint Plessey { get; }

    uint Telepen { get; }

    uint Code16k { get; }

    uint CodablockA { get; }

    uint CodablockF { get; }

    uint Codablock128 { get; }

    uint Code49 { get; }

    uint Aztec { get; }

    uint DataCode { get; }

    uint DataMatrix { get; }

    uint HanXin { get; }

    uint Maxicode { get; }

    uint MicroPdf417 { get; }

    uint MicroQr { get; }

    uint Pdf417 { get; }

    uint Qr { get; }

    uint MsTag { get; }

    uint Ccab { get; }

    uint Ccc { get; }

    uint Tlc39 { get; }

    uint AusPost { get; }

    uint CanPost { get; }

    uint ChinaPost { get; }

    uint DutchKix { get; }

    uint InfoMail { get; }

    uint ItalianPost25 { get; }

    uint ItalianPost39 { get; }

    uint JapanPost { get; }

    uint KoreanPost { get; }

    uint SwedenPost { get; }

    uint UkPost { get; }

    uint UsIntelligent { get; }

    uint UsIntelligentPkg { get; }

    uint UsPlanet { get; }

    uint UsPostNet { get; }

    uint Us4StateFics { get; }

    uint OcrA { get; }

    uint OcrB { get; }

    uint Micr { get; }

    uint ExtendedBase { get; }

    string GetName(uint scanDataType);
  }
}
