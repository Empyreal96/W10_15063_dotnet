// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1353104733, 26351, 19667, 149, 121, 158, 102, 5, 7, 220, 63)]
  internal interface IAdaptiveMediaSourceStatics
  {
    bool IsContentTypeSupported(string contentType);

    [Overload("CreateFromUriAsync")]
    [RemoteAsync]
    IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromUriAsync(
      Uri uri);

    [RemoteAsync]
    [Overload("CreateFromUriWithDownloaderAsync")]
    IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromUriAsync(
      Uri uri,
      HttpClient httpClient);

    [RemoteAsync]
    [Overload("CreateFromStreamAsync")]
    IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromStreamAsync(
      IInputStream stream,
      Uri uri,
      string contentType);

    [Overload("CreateFromStreamWithDownloaderAsync")]
    [RemoteAsync]
    IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromStreamAsync(
      IInputStream stream,
      Uri uri,
      string contentType,
      HttpClient httpClient);
  }
}
