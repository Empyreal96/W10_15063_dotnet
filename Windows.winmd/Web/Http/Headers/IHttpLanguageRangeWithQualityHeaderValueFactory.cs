// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpLanguageRangeWithQualityHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpLanguageRangeWithQualityHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2075670896, 30735, 19587, 159, 228, 220, 48, 135, 246, 189, 85)]
  internal interface IHttpLanguageRangeWithQualityHeaderValueFactory
  {
    HttpLanguageRangeWithQualityHeaderValue CreateFromLanguageRange(
      string languageRange);

    HttpLanguageRangeWithQualityHeaderValue CreateFromLanguageRangeWithQuality(
      string languageRange,
      double quality);
  }
}
