// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpResponseHeaderCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(2056849769, 64063, 16877, 170, 198, 191, 149, 121, 117, 193, 107)]
  [ExclusiveTo(typeof (HttpResponseHeaderCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpResponseHeaderCollection : 
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>
  {
    IReference<TimeSpan> Age { get; set; }

    HttpMethodHeaderValueCollection Allow { get; }

    HttpCacheDirectiveHeaderValueCollection CacheControl { get; }

    HttpConnectionOptionHeaderValueCollection Connection { get; }

    IReference<DateTime> Date { get; set; }

    Uri Location { get; set; }

    HttpChallengeHeaderValueCollection ProxyAuthenticate { get; }

    HttpDateOrDeltaHeaderValue RetryAfter { get; set; }

    HttpTransferCodingHeaderValueCollection TransferEncoding { get; }

    HttpChallengeHeaderValueCollection WwwAuthenticate { get; }

    void Append(string name, string value);

    bool TryAppendWithoutValidation(string name, string value);
  }
}
