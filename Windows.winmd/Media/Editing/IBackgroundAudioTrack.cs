// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IBackgroundAudioTrack
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
  [ExclusiveTo(typeof (BackgroundAudioTrack))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1267839933, 40481, 16998, 169, 194, 103, 221, 1, 26, 35, 87)]
  internal interface IBackgroundAudioTrack
  {
    TimeSpan TrimTimeFromStart { get; set; }

    TimeSpan TrimTimeFromEnd { get; set; }

    TimeSpan OriginalDuration { get; }

    TimeSpan TrimmedDuration { get; }

    IMap<string, string> UserData { get; }

    TimeSpan Delay { set; get; }

    double Volume { set; get; }

    BackgroundAudioTrack Clone();

    AudioEncodingProperties GetAudioEncodingProperties();

    IVector<IAudioEffectDefinition> AudioEffectDefinitions { get; }
  }
}
