// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMethodHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1136410612, 24857, 19167, 147, 140, 52, 191, 255, 207, 146, 237)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpMethodHeaderValueCollection))]
  internal interface IHttpMethodHeaderValueCollection : IVector<HttpMethod>, IIterable<HttpMethod>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
