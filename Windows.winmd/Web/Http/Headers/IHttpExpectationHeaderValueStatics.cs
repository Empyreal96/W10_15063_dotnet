// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpExpectationHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpExpectationHeaderValue))]
  [Guid(806988770, 53221, 18235, 165, 127, 251, 165, 177, 78, 178, 87)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpExpectationHeaderValueStatics
  {
    HttpExpectationHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpExpectationHeaderValue expectationHeaderValue);
  }
}
