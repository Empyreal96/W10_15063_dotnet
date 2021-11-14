// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpStringContent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpStringContentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpStringContent : IHttpContent, IClosable, IStringable
  {
    [MethodImpl]
    public extern HttpStringContent(string content);

    [MethodImpl]
    public extern HttpStringContent(string content, UnicodeEncoding encoding);

    [MethodImpl]
    public extern HttpStringContent(string content, UnicodeEncoding encoding, string mediaType);

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

    [MethodImpl]
    public new extern string ToString();
  }
}
