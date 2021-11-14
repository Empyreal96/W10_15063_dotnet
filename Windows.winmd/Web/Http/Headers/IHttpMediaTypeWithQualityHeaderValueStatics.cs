// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMediaTypeWithQualityHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpMediaTypeWithQualityHeaderValue))]
  [Guid(1527188697, 46432, 20424, 152, 53, 126, 108, 10, 101, 123, 36)]
  internal interface IHttpMediaTypeWithQualityHeaderValueStatics
  {
    HttpMediaTypeWithQualityHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpMediaTypeWithQualityHeaderValue mediaTypeWithQualityHeaderValue);
  }
}
