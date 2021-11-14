// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpProductInfoHeaderValueCollection
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
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpProductInfoHeaderValueCollection : 
    IHttpProductInfoHeaderValueCollection,
    IVector<HttpProductInfoHeaderValue>,
    IIterable<HttpProductInfoHeaderValue>,
    IStringable
  {
    [MethodImpl]
    public extern void ParseAdd(string input);

    [MethodImpl]
    public extern bool TryParseAdd(string input);

    [MethodImpl]
    public extern HttpProductInfoHeaderValue GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<HttpProductInfoHeaderValue> GetView();

    [MethodImpl]
    public extern bool IndexOf(HttpProductInfoHeaderValue value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, HttpProductInfoHeaderValue value);

    [MethodImpl]
    public extern void InsertAt(uint index, HttpProductInfoHeaderValue value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(HttpProductInfoHeaderValue value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] HttpProductInfoHeaderValue[] items);

    [MethodImpl]
    public extern void ReplaceAll(HttpProductInfoHeaderValue[] items);

    [MethodImpl]
    public extern IIterator<HttpProductInfoHeaderValue> First();

    [MethodImpl]
    public new extern string ToString();
  }
}
