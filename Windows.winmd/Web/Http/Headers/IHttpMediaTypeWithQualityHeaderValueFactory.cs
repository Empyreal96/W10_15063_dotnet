// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMediaTypeWithQualityHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpMediaTypeWithQualityHeaderValue))]
  [Guid(1282220276, 37975, 17638, 163, 35, 209, 34, 185, 88, 120, 11)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpMediaTypeWithQualityHeaderValueFactory
  {
    HttpMediaTypeWithQualityHeaderValue CreateFromMediaType(
      string mediaType);

    HttpMediaTypeWithQualityHeaderValue CreateFromMediaTypeWithQuality(
      string mediaType,
      double quality);
  }
}
