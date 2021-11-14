// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValueCollection
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HttpMediaTypeWithQualityHeaderValueCollection : 
    IHttpMediaTypeWithQualityHeaderValueCollection,
    IVector<HttpMediaTypeWithQualityHeaderValue>,
    IIterable<HttpMediaTypeWithQualityHeaderValue>,
    IStringable
  {
    [MethodImpl]
    public extern void ParseAdd(string input);

    [MethodImpl]
    public extern bool TryParseAdd(string input);

    [MethodImpl]
    public extern HttpMediaTypeWithQualityHeaderValue GetAt(
      uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<HttpMediaTypeWithQualityHeaderValue> GetView();

    [MethodImpl]
    public extern bool IndexOf(HttpMediaTypeWithQualityHeaderValue value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, HttpMediaTypeWithQualityHeaderValue value);

    [MethodImpl]
    public extern void InsertAt(uint index, HttpMediaTypeWithQualityHeaderValue value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(HttpMediaTypeWithQualityHeaderValue value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] HttpMediaTypeWithQualityHeaderValue[] items);

    [MethodImpl]
    public extern void ReplaceAll(HttpMediaTypeWithQualityHeaderValue[] items);

    [MethodImpl]
    public extern IIterator<HttpMediaTypeWithQualityHeaderValue> First();

    [MethodImpl]
    public new extern string ToString();
  }
}
