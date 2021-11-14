// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpRequestHeaderCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Web.Http.Headers
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpRequestHeaderCollection : 
    IHttpRequestHeaderCollection,
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>,
    IStringable
  {
    public extern HttpMediaTypeWithQualityHeaderValueCollection Accept { [MethodImpl] get; }

    public extern HttpContentCodingWithQualityHeaderValueCollection AcceptEncoding { [MethodImpl] get; }

    public extern HttpLanguageRangeWithQualityHeaderValueCollection AcceptLanguage { [MethodImpl] get; }

    public extern HttpCredentialsHeaderValue Authorization { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpCacheDirectiveHeaderValueCollection CacheControl { [MethodImpl] get; }

    public extern HttpConnectionOptionHeaderValueCollection Connection { [MethodImpl] get; }

    public extern HttpCookiePairHeaderValueCollection Cookie { [MethodImpl] get; }

    public extern IReference<DateTime> Date { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpExpectationHeaderValueCollection Expect { [MethodImpl] get; }

    public extern string From { [MethodImpl] get; [MethodImpl] set; }

    public extern HostName Host { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> IfModifiedSince { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> IfUnmodifiedSince { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<uint> MaxForwards { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpCredentialsHeaderValue ProxyAuthorization { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri Referer { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpTransferCodingHeaderValueCollection TransferEncoding { [MethodImpl] get; }

    public extern HttpProductInfoHeaderValueCollection UserAgent { [MethodImpl] get; }

    [MethodImpl]
    public extern void Append(string name, string value);

    [MethodImpl]
    public extern bool TryAppendWithoutValidation(string name, string value);

    [MethodImpl]
    public extern string Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, string> GetView();

    [MethodImpl]
    public extern bool Insert(string key, string value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, string>> First();

    [MethodImpl]
    public new extern string ToString();
  }
}
