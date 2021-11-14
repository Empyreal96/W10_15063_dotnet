// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Streaming.Adaptive;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4152192932, 18002, 16654, 177, 216, 233, 165, 226, 69, 164, 92)]
  internal interface IMediaSourceStatics
  {
    MediaSource CreateFromAdaptiveMediaSource(AdaptiveMediaSource mediaSource);

    MediaSource CreateFromMediaStreamSource(MediaStreamSource mediaSource);

    MediaSource CreateFromMseStreamSource(MseStreamSource mediaSource);

    MediaSource CreateFromIMediaSource(IMediaSource mediaSource);

    MediaSource CreateFromStorageFile(IStorageFile file);

    MediaSource CreateFromStream(IRandomAccessStream stream, string contentType);

    MediaSource CreateFromStreamReference(
      IRandomAccessStreamReference stream,
      string contentType);

    MediaSource CreateFromUri(Uri uri);
  }
}
