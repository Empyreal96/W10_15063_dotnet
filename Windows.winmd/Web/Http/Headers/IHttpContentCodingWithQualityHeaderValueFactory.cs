// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingWithQualityHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpContentCodingWithQualityHeaderValue))]
  [Guid(3294555674, 50515, 18172, 173, 226, 215, 92, 29, 83, 223, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpContentCodingWithQualityHeaderValueFactory
  {
    HttpContentCodingWithQualityHeaderValue CreateFromValue(
      string contentCoding);

    HttpContentCodingWithQualityHeaderValue CreateFromValueWithQuality(
      string contentCoding,
      double quality);
  }
}
