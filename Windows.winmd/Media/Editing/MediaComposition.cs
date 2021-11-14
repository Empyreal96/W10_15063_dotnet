// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.MediaComposition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
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
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [GCPressure(amount = GCPressureAmount.High)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaCompositionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaComposition : IMediaComposition, IMediaComposition2
  {
    [MethodImpl]
    public extern MediaComposition();

    public extern TimeSpan Duration { [MethodImpl] get; }

    public extern IVector<MediaClip> Clips { [MethodImpl] get; }

    public extern IVector<BackgroundAudioTrack> BackgroundAudioTracks { [MethodImpl] get; }

    public extern IMap<string, string> UserData { [MethodImpl] get; }

    [MethodImpl]
    public extern MediaComposition Clone();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync(IStorageFile file);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ImageStream> GetThumbnailAsync(
      TimeSpan timeFromStart,
      int scaledWidth,
      int scaledHeight,
      VideoFramePrecision framePrecision);

    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ImageStream>> GetThumbnailsAsync(
      IIterable<TimeSpan> timesFromStart,
      int scaledWidth,
      int scaledHeight,
      VideoFramePrecision framePrecision);

    [RemoteAsync]
    [Overload("RenderToFileAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination);

    [RemoteAsync]
    [Overload("RenderToFileWithTrimmingPreferenceAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination,
      MediaTrimmingPreference trimmingPreference);

    [Overload("RenderToFileWithProfileAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination,
      MediaTrimmingPreference trimmingPreference,
      MediaEncodingProfile encodingProfile);

    [MethodImpl]
    public extern MediaEncodingProfile CreateDefaultEncodingProfile();

    [Overload("GenerateMediaStreamSource")]
    [MethodImpl]
    public extern MediaStreamSource GenerateMediaStreamSource();

    [Overload("GenerateMediaStreamSourceWithProfile")]
    [MethodImpl]
    public extern MediaStreamSource GenerateMediaStreamSource(
      MediaEncodingProfile encodingProfile);

    [MethodImpl]
    public extern MediaStreamSource GeneratePreviewMediaStreamSource(
      int scaledWidth,
      int scaledHeight);

    public extern IVector<MediaOverlayLayer> OverlayLayers { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaComposition> LoadAsync(
      StorageFile file);
  }
}
