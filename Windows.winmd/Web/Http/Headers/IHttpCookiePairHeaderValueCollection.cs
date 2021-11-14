// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCookiePairHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4092871504, 22558, 20172, 159, 89, 229, 7, 208, 79, 6, 230)]
  [ExclusiveTo(typeof (HttpCookiePairHeaderValueCollection))]
  internal interface IHttpCookiePairHeaderValueCollection : 
    IVector<HttpCookiePairHeaderValue>,
    IIterable<HttpCookiePairHeaderValue>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
