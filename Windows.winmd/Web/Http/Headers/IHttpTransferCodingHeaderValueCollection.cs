// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpTransferCodingHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpTransferCodingHeaderValueCollection))]
  [Guid(539790388, 11267, 18872, 150, 101, 115, 226, 124, 178, 252, 121)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpTransferCodingHeaderValueCollection : 
    IVector<HttpTransferCodingHeaderValue>,
    IIterable<HttpTransferCodingHeaderValue>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
