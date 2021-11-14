// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.BackgroundAudioTrack
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;
using Windows.Storage;

namespace Windows.Media.Editing
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBackgroundAudioTrackStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [GCPressure(amount = GCPressureAmount.High)]
  public sealed class BackgroundAudioTrack : IBackgroundAudioTrack
  {
    public extern TimeSpan TrimTimeFromStart { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan TrimTimeFromEnd { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan OriginalDuration { [MethodImpl] get; }

    public extern TimeSpan TrimmedDuration { [MethodImpl] get; }

    public extern IMap<string, string> UserData { [MethodImpl] get; }

    public extern TimeSpan Delay { [MethodImpl] set; [MethodImpl] get; }

    public extern double Volume { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern BackgroundAudioTrack Clone();

    [MethodImpl]
    public extern AudioEncodingProperties GetAudioEncodingProperties();

    public extern IVector<IAudioEffectDefinition> AudioEffectDefinitions { [MethodImpl] get; }

    [MethodImpl]
    public static extern BackgroundAudioTrack CreateFromEmbeddedAudioTrack(
      EmbeddedAudioTrack embeddedAudioTrack);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BackgroundAudioTrack> CreateFromFileAsync(
      IStorageFile file);
  }
}
