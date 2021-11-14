// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaClip
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;

namespace Windows.Media.Editing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1408389990, 24506, 16036, 134, 147, 36, 118, 24, 17, 20, 10)]
  [ExclusiveTo(typeof (MediaClip))]
  internal interface IMediaClip
  {
    TimeSpan TrimTimeFromStart { get; set; }

    TimeSpan TrimTimeFromEnd { get; set; }

    TimeSpan OriginalDuration { get; }

    TimeSpan TrimmedDuration { get; }

    IMap<string, string> UserData { get; }

    MediaClip Clone();

    TimeSpan StartTimeInComposition { get; }

    TimeSpan EndTimeInComposition { get; }

    IVectorView<EmbeddedAudioTrack> EmbeddedAudioTracks { get; }

    uint SelectedEmbeddedAudioTrackIndex { get; set; }

    double Volume { set; get; }

    VideoEncodingProperties GetVideoEncodingProperties();

    IVector<IAudioEffectDefinition> AudioEffectDefinitions { get; }

    IVector<IVideoEffectDefinition> VideoEffectDefinitions { get; }
  }
}
