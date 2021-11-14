// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpContentHeaderCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http.Headers
{
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpContentHeaderCollection : 
    IHttpContentHeaderCollection,
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>,
    IStringable
  {
    [MethodImpl]
    public extern HttpContentHeaderCollection();

    public extern HttpContentDispositionHeaderValue ContentDisposition { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpContentCodingHeaderValueCollection ContentEncoding { [MethodImpl] get; }

    public extern HttpLanguageHeaderValueCollection ContentLanguage { [MethodImpl] get; }

    public extern IReference<ulong> ContentLength { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri ContentLocation { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer ContentMD5 { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpContentRangeHeaderValue ContentRange { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpMediaTypeHeaderValue ContentType { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> Expires { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> LastModified { [MethodImpl] get; [MethodImpl] set; }

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
