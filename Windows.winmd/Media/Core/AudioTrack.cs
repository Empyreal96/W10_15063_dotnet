// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.AudioTrack
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AudioTrack : IMediaTrack, IAudioTrack
  {
    public extern string Id { [MethodImpl] get; }

    public extern string Language { [MethodImpl] get; }

    public extern MediaTrackKind TrackKind { [MethodImpl] get; }

    public extern string Label { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<AudioTrack, AudioTrackOpenFailedEventArgs> OpenFailed;

    [MethodImpl]
    public extern AudioEncodingProperties GetEncodingProperties();

    public extern MediaPlaybackItem PlaybackItem { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern AudioTrackSupportInfo SupportInfo { [MethodImpl] get; }
  }
}
