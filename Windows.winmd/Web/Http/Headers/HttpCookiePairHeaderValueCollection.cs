// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpCookiePairHeaderValueCollection
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
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpCookiePairHeaderValueCollection : 
    IHttpCookiePairHeaderValueCollection,
    IVector<HttpCookiePairHeaderValue>,
    IIterable<HttpCookiePairHeaderValue>,
    IStringable
  {
    [MethodImpl]
    public extern void ParseAdd(string input);

    [MethodImpl]
    public extern bool TryParseAdd(string input);

    [MethodImpl]
    public extern HttpCookiePairHeaderValue GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<HttpCookiePairHeaderValue> GetView();

    [MethodImpl]
    public extern bool IndexOf(HttpCookiePairHeaderValue value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, HttpCookiePairHeaderValue value);

    [MethodImpl]
    public extern void InsertAt(uint index, HttpCookiePairHeaderValue value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(HttpCookiePairHeaderValue value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] HttpCookiePairHeaderValue[] items);

    [MethodImpl]
    public extern void ReplaceAll(HttpCookiePairHeaderValue[] items);

    [MethodImpl]
    public extern IIterator<HttpCookiePairHeaderValue> First();

    [MethodImpl]
    public new extern string ToString();
  }
}
