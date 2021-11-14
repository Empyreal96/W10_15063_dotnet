// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpLanguageRangeWithQualityHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpLanguageRangeWithQualityHeaderValue))]
  [Guid(625074502, 62216, 18165, 182, 149, 66, 245, 64, 36, 236, 104)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpLanguageRangeWithQualityHeaderValueStatics
  {
    HttpLanguageRangeWithQualityHeaderValue Parse(
      string input);

    bool TryParse(
      string input,
      out HttpLanguageRangeWithQualityHeaderValue languageRangeWithQualityHeaderValue);
  }
}
