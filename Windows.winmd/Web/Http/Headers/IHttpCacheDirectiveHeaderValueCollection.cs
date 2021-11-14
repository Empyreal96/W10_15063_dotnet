// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCacheDirectiveHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpCacheDirectiveHeaderValueCollection))]
  [Guid(2589485961, 54736, 20414, 189, 157, 181, 179, 99, 104, 17, 180)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpCacheDirectiveHeaderValueCollection : 
    IVector<HttpNameValueHeaderValue>,
    IIterable<HttpNameValueHeaderValue>
  {
    IReference<TimeSpan> MaxAge { get; set; }

    IReference<TimeSpan> MaxStale { get; set; }

    IReference<TimeSpan> MinFresh { get; set; }

    IReference<TimeSpan> SharedMaxAge { get; set; }

    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
