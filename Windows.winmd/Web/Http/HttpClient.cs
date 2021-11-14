// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpClient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http.Filters;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IHttpClientFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HttpClient : IHttpClient, IClosable, IStringable
  {
    [MethodImpl]
    public extern HttpClient(IHttpFilter filter);

    [MethodImpl]
    public extern HttpClient();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> DeleteAsync(
      Uri uri);

    [Overload("GetAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> GetAsync(
      Uri uri);

    [RemoteAsync]
    [Overload("GetWithOptionAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> GetAsync(
      Uri uri,
      HttpCompletionOption completionOption);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, HttpProgress> GetBufferAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IInputStream, HttpProgress> GetInputStreamAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<string, HttpProgress> GetStringAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> PostAsync(
      Uri uri,
      IHttpContent content);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> PutAsync(
      Uri uri,
      IHttpContent content);

    [Overload("SendRequestAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request);

    [Overload("SendRequestWithOptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request,
      HttpCompletionOption completionOption);

    public extern HttpRequestHeaderCollection DefaultRequestHeaders { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public new extern string ToString();
  }
}
