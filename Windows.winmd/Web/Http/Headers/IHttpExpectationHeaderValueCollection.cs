// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpExpectationHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpExpectationHeaderValueCollection))]
  [Guid(3884261811, 41186, 19140, 158, 102, 121, 112, 108, 185, 253, 88)]
  internal interface IHttpExpectationHeaderValueCollection : 
    IVector<HttpExpectationHeaderValue>,
    IIterable<HttpExpectationHeaderValue>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
