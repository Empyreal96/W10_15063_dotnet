// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpCacheDirectiveHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpCacheDirectiveHeaderValueCollection : 
    IHttpCacheDirectiveHeaderValueCollection,
    IVector<HttpNameValueHeaderValue>,
    IIterable<HttpNameValueHeaderValue>,
    IStringable
  {
    public extern IReference<TimeSpan> MaxAge { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> MaxStale { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> MinFresh { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> SharedMaxAge { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void ParseAdd(string input);

    [MethodImpl]
    public extern bool TryParseAdd(string input);

    [MethodImpl]
    public extern HttpNameValueHeaderValue GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<HttpNameValueHeaderValue> GetView();

    [MethodImpl]
    public extern bool IndexOf(HttpNameValueHeaderValue value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, HttpNameValueHeaderValue value);

    [MethodImpl]
    public extern void InsertAt(uint index, HttpNameValueHeaderValue value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(HttpNameValueHeaderValue value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] HttpNameValueHeaderValue[] items);

    [MethodImpl]
    public extern void ReplaceAll(HttpNameValueHeaderValue[] items);

    [MethodImpl]
    public extern IIterator<HttpNameValueHeaderValue> First();

    [MethodImpl]
    public new extern string ToString();
  }
}
