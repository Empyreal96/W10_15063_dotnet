// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2497208366, 63935, 17143, 170, 70, 237, 39, 42, 65, 226, 18)]
  [ExclusiveTo(typeof (HttpContentCodingHeaderValue))]
  internal interface IHttpContentCodingHeaderValueStatics
  {
    HttpContentCodingHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpContentCodingHeaderValue contentCodingHeaderValue);
  }
}
