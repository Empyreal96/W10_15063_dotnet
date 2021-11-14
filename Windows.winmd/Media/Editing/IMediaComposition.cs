// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaComposition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Media.Core;
using Windows.Media.MediaProperties;
using Windows.Media.Transcoding;
using Windows.Storage;

namespace Windows.Media.Editing
{
  [ExclusiveTo(typeof (MediaComposition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(772204037, 56433, 16854, 184, 55, 45, 43, 193, 74, 41, 71)]
  internal interface IMediaComposition
  {
    TimeSpan Duration { get; }

    IVector<MediaClip> Clips { get; }

    IVector<BackgroundAudioTrack> BackgroundAudioTracks { get; }

    IMap<string, string> UserData { get; }

    MediaComposition Clone();

    [RemoteAsync]
    IAsyncAction SaveAsync(IStorageFile file);

    [RemoteAsync]
    IAsyncOperation<ImageStream> GetThumbnailAsync(
      TimeSpan timeFromStart,
      int scaledWidth,
      int scaledHeight,
      VideoFramePrecision framePrecision);

    IAsyncOperation<IVectorView<ImageStream>> GetThumbnailsAsync(
      IIterable<TimeSpan> timesFromStart,
      int scaledWidth,
      int scaledHeight,
      VideoFramePrecision framePrecision);

    [RemoteAsync]
    [Overload("RenderToFileAsync")]
    IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination);

    [Overload("RenderToFileWithTrimmingPreferenceAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination,
      MediaTrimmingPreference trimmingPreference);

    [Overload("RenderToFileWithProfileAsync")]
    IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination,
      MediaTrimmingPreference trimmingPreference,
      MediaEncodingProfile encodingProfile);

    MediaEncodingProfile CreateDefaultEncodingProfile();

    [Overload("GenerateMediaStreamSource")]
    MediaStreamSource GenerateMediaStreamSource();

    [Overload("GenerateMediaStreamSourceWithProfile")]
    MediaStreamSource GenerateMediaStreamSource(
      MediaEncodingProfile encodingProfile);

    MediaStreamSource GeneratePreviewMediaStreamSource(
      int scaledWidth,
      int scaledHeight);
  }
}
