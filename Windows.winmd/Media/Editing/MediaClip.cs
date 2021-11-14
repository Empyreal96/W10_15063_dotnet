// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.MediaClip
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.UI;

namespace Windows.Media.Editing
{
  [Static(typeof (IMediaClipStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [GCPressure(amount = GCPressureAmount.High)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaClipStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaClip : IMediaClip
  {
    public extern TimeSpan TrimTimeFromStart { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan TrimTimeFromEnd { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan OriginalDuration { [MethodImpl] get; }

    public extern TimeSpan TrimmedDuration { [MethodImpl] get; }

    public extern IMap<string, string> UserData { [MethodImpl] get; }

    [MethodImpl]
    public extern MediaClip Clone();

    public extern TimeSpan StartTimeInComposition { [MethodImpl] get; }

    public extern TimeSpan EndTimeInComposition { [MethodImpl] get; }

    public extern IVectorView<EmbeddedAudioTrack> EmbeddedAudioTracks { [MethodImpl] get; }

    public extern uint SelectedEmbeddedAudioTrackIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern double Volume { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern VideoEncodingProperties GetVideoEncodingProperties();

    public extern IVector<IAudioEffectDefinition> AudioEffectDefinitions { [MethodImpl] get; }

    public extern IVector<IVideoEffectDefinition> VideoEffectDefinitions { [MethodImpl] get; }

    [MethodImpl]
    public static extern MediaClip CreateFromSurface(
      IDirect3DSurface surface,
      TimeSpan originalDuration);

    [MethodImpl]
    public static extern MediaClip CreateFromColor(Color color, TimeSpan originalDuration);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaClip> CreateFromFileAsync(
      IStorageFile file);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaClip> CreateFromImageFileAsync(
      IStorageFile file,
      TimeSpan originalDuration);
  }
}
