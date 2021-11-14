// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpContentCodingHeaderValueCollection))]
  [Guid(2099386145, 42715, 17262, 142, 131, 145, 89, 97, 146, 129, 156)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpContentCodingHeaderValueCollection : 
    IVector<HttpContentCodingHeaderValue>,
    IIterable<HttpContentCodingHeaderValue>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
