// Decompiled with JetBrains decompiler
// Type: Windows.Media.Transcoding.MediaTranscoder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Transcoding
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public sealed class MediaTranscoder : IMediaTranscoder, IMediaTranscoder2
  {
    [MethodImpl]
    public extern MediaTranscoder();

    public extern TimeSpan TrimStartTime { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan TrimStopTime { [MethodImpl] set; [MethodImpl] get; }

    public extern bool AlwaysReencode { [MethodImpl] set; [MethodImpl] get; }

    public extern bool HardwareAccelerationEnabled { [MethodImpl] set; [MethodImpl] get; }

    [Overload("AddAudioEffect")]
    [MethodImpl]
    public extern void AddAudioEffect(string activatableClassId);

    [Overload("AddAudioEffectWithSettings")]
    [MethodImpl]
    public extern void AddAudioEffect(
      string activatableClassId,
      bool effectRequired,
      IPropertySet configuration);

    [Overload("AddVideoEffect")]
    [MethodImpl]
    public extern void AddVideoEffect(string activatableClassId);

    [Overload("AddVideoEffectWithSettings")]
    [MethodImpl]
    public extern void AddVideoEffect(
      string activatableClassId,
      bool effectRequired,
      IPropertySet configuration);

    [MethodImpl]
    public extern void ClearEffects();

    [MethodImpl]
    public extern IAsyncOperation<PrepareTranscodeResult> PrepareFileTranscodeAsync(
      IStorageFile source,
      IStorageFile destination,
      MediaEncodingProfile profile);

    [MethodImpl]
    public extern IAsyncOperation<PrepareTranscodeResult> PrepareStreamTranscodeAsync(
      IRandomAccessStream source,
      IRandomAccessStream destination,
      MediaEncodingProfile profile);

    [MethodImpl]
    public extern IAsyncOperation<PrepareTranscodeResult> PrepareMediaStreamSourceTranscodeAsync(
      IMediaSource source,
      IRandomAccessStream destination,
      MediaEncodingProfile profile);

    public extern MediaVideoProcessingAlgorithm VideoProcessingAlgorithm { [MethodImpl] set; [MethodImpl] get; }
  }
}
