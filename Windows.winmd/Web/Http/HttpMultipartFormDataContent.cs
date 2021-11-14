// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpMultipartFormDataContent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [Activatable(typeof (IHttpMultipartFormDataContentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HttpMultipartFormDataContent : 
    IHttpContent,
    IClosable,
    IHttpMultipartFormDataContent,
    IIterable<IHttpContent>,
    IStringable
  {
    [MethodImpl]
    public extern HttpMultipartFormDataContent(string boundary);

    [MethodImpl]
    public extern HttpMultipartFormDataContent();

    public extern HttpContentHeaderCollection Headers { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, ulong> ReadAsBufferAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IInputStream, ulong> ReadAsInputStreamAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync();

    [MethodImpl]
    public extern bool TryComputeLength(out ulong length);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ulong, ulong> WriteToStreamAsync(
      IOutputStream outputStream);

    [MethodImpl]
    public extern void Close();

    [Overload("Add")]
    [MethodImpl]
    public extern void Add(IHttpContent content);

    [Overload("AddWithName")]
    [MethodImpl]
    public extern void Add(IHttpContent content, string name);

    [Overload("AddWithNameAndFileName")]
    [MethodImpl]
    public extern void Add(IHttpContent content, string name, string fileName);

    [MethodImpl]
    public extern IIterator<IHttpContent> First();

    [MethodImpl]
    public new extern string ToString();
  }
}
