// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpContent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [Guid(1796514881, 64423, 19410, 175, 10, 131, 157, 231, 194, 149, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IHttpContent : IClosable
  {
    HttpContentHeaderCollection Headers { get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync();

    [RemoteAsync]
    IAsyncOperationWithProgress<IBuffer, ulong> ReadAsBufferAsync();

    [RemoteAsync]
    IAsyncOperationWithProgress<IInputStream, ulong> ReadAsInputStreamAsync();

    [RemoteAsync]
    IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync();

    bool TryComputeLength(out ulong length);

    [RemoteAsync]
    IAsyncOperationWithProgress<ulong, ulong> WriteToStreamAsync(
      IOutputStream outputStream);
  }
}
