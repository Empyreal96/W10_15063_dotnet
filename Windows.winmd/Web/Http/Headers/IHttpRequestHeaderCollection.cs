// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpRequestHeaderCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2940220059, 46404, 18075, 134, 185, 172, 61, 70, 111, 234, 54)]
  [ExclusiveTo(typeof (HttpRequestHeaderCollection))]
  internal interface IHttpRequestHeaderCollection : 
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>
  {
    HttpMediaTypeWithQualityHeaderValueCollection Accept { get; }

    HttpContentCodingWithQualityHeaderValueCollection AcceptEncoding { get; }

    HttpLanguageRangeWithQualityHeaderValueCollection AcceptLanguage { get; }

    HttpCredentialsHeaderValue Authorization { get; set; }

    HttpCacheDirectiveHeaderValueCollection CacheControl { get; }

    HttpConnectionOptionHeaderValueCollection Connection { get; }

    HttpCookiePairHeaderValueCollection Cookie { get; }

    IReference<DateTime> Date { get; set; }

    HttpExpectationHeaderValueCollection Expect { get; }

    string From { get; set; }

    HostName Host { get; set; }

    IReference<DateTime> IfModifiedSince { get; set; }

    IReference<DateTime> IfUnmodifiedSince { get; set; }

    IReference<uint> MaxForwards { get; set; }

    HttpCredentialsHeaderValue ProxyAuthorization { get; set; }

    Uri Referer { get; set; }

    HttpTransferCodingHeaderValueCollection TransferEncoding { get; }

    HttpProductInfoHeaderValueCollection UserAgent { get; }

    void Append(string name, string value);

    bool TryAppendWithoutValidation(string name, string value);
  }
}
