// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpTransferCodingHeaderValueCollection
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpTransferCodingHeaderValueCollection : 
    IHttpTransferCodingHeaderValueCollection,
    IVector<HttpTransferCodingHeaderValue>,
    IIterable<HttpTransferCodingHeaderValue>,
    IStringable
  {
    [MethodImpl]
    public extern void ParseAdd(string input);

    [MethodImpl]
    public extern bool TryParseAdd(string input);

    [MethodImpl]
    public extern HttpTransferCodingHeaderValue GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<HttpTransferCodingHeaderValue> GetView();

    [MethodImpl]
    public extern bool IndexOf(HttpTransferCodingHeaderValue value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, HttpTransferCodingHeaderValue value);

    [MethodImpl]
    public extern void InsertAt(uint index, HttpTransferCodingHeaderValue value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(HttpTransferCodingHeaderValue value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] HttpTransferCodingHeaderValue[] items);

    [MethodImpl]
    public extern void ReplaceAll(HttpTransferCodingHeaderValue[] items);

    [MethodImpl]
    public extern IIterator<HttpTransferCodingHeaderValue> First();

    [MethodImpl]
    public new extern string ToString();
  }
}
