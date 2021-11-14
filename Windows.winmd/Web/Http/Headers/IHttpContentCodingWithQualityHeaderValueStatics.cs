// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingWithQualityHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3905500540, 36745, 18433, 142, 117, 76, 154, 191, 195, 222, 113)]
  [ExclusiveTo(typeof (HttpContentCodingWithQualityHeaderValue))]
  internal interface IHttpContentCodingWithQualityHeaderValueStatics
  {
    HttpContentCodingWithQualityHeaderValue Parse(
      string input);

    bool TryParse(
      string input,
      out HttpContentCodingWithQualityHeaderValue contentCodingWithQualityHeaderValue);
  }
}
