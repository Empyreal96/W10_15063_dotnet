// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpResponseHeaderCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpResponseHeaderCollection : 
    IHttpResponseHeaderCollection,
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>,
    IStringable
  {
    public extern IReference<TimeSpan> Age { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpMethodHeaderValueCollection Allow { [MethodImpl] get; }

    public extern HttpCacheDirectiveHeaderValueCollection CacheControl { [MethodImpl] get; }

    public extern HttpConnectionOptionHeaderValueCollection Connection { [MethodImpl] get; }

    public extern IReference<DateTime> Date { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri Location { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpChallengeHeaderValueCollection ProxyAuthenticate { [MethodImpl] get; }

    public extern HttpDateOrDeltaHeaderValue RetryAfter { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpTransferCodingHeaderValueCollection TransferEncoding { [MethodImpl] get; }

    public extern HttpChallengeHeaderValueCollection WwwAuthenticate { [MethodImpl] get; }

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
