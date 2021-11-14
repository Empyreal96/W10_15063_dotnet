// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSource2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaSource))]
  [Guid(783683656, 25951, 19511, 184, 19, 180, 228, 93, 250, 10, 190)]
  internal interface IMediaSource2 : IMediaPlaybackSource, IClosable
  {
    event TypedEventHandler<MediaSource, MediaSourceOpenOperationCompletedEventArgs> OpenOperationCompleted;

    ValueSet CustomProperties { get; }

    IReference<TimeSpan> Duration { get; }

    bool IsOpen { get; }

    IObservableVector<TimedTextSource> ExternalTimedTextSources { get; }

    IObservableVector<TimedMetadataTrack> ExternalTimedMetadataTracks { get; }
  }
}
