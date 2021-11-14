// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentRangeHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpContentRangeHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2158184138, 5964, 20398, 130, 28, 19, 76, 210, 148, 170, 56)]
  internal interface IHttpContentRangeHeaderValueStatics
  {
    HttpContentRangeHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpContentRangeHeaderValue contentRangeHeaderValue);
  }
}
