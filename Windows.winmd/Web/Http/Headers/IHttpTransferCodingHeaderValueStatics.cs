// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpTransferCodingHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1790478634, 6808, 19762, 169, 6, 116, 112, 169, 135, 92, 229)]
  [ExclusiveTo(typeof (HttpTransferCodingHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpTransferCodingHeaderValueStatics
  {
    HttpTransferCodingHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpTransferCodingHeaderValue transferCodingHeaderValue);
  }
}
