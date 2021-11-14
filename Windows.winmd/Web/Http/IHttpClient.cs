// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpClient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpClient))]
  [Guid(2144997713, 13684, 18560, 168, 186, 230, 177, 224, 6, 31, 61)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpClient : IClosable
  {
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> DeleteAsync(
      Uri uri);

    [RemoteAsync]
    [Overload("GetAsync")]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> GetAsync(
      Uri uri);

    [RemoteAsync]
    [Overload("GetWithOptionAsync")]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> GetAsync(
      Uri uri,
      HttpCompletionOption completionOption);

    [RemoteAsync]
    IAsyncOperationWithProgress<IBuffer, HttpProgress> GetBufferAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<IInputStream, HttpProgress> GetInputStreamAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<string, HttpProgress> GetStringAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> PostAsync(
      Uri uri,
      IHttpContent content);

    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> PutAsync(
      Uri uri,
      IHttpContent content);

    [Overload("SendRequestAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request);

    [RemoteAsync]
    [Overload("SendRequestWithOptionAsync")]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request,
      HttpCompletionOption completionOption);

    HttpRequestHeaderCollection DefaultRequestHeaders { get; }
  }
}
