// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaElementStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (MediaElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3704433849, 30056, 18050, 167, 42, 141, 223, 42, 38, 101, 202)]
  internal interface IMediaElementStatics
  {
    DependencyProperty PosterSourceProperty { get; }

    DependencyProperty SourceProperty { get; }

    DependencyProperty IsMutedProperty { get; }

    DependencyProperty IsAudioOnlyProperty { get; }

    DependencyProperty AutoPlayProperty { get; }

    DependencyProperty VolumeProperty { get; }

    DependencyProperty BalanceProperty { get; }

    DependencyProperty NaturalVideoHeightProperty { get; }

    DependencyProperty NaturalVideoWidthProperty { get; }

    DependencyProperty NaturalDurationProperty { get; }

    DependencyProperty PositionProperty { get; }

    DependencyProperty DownloadProgressProperty { get; }

    DependencyProperty BufferingProgressProperty { get; }

    DependencyProperty DownloadProgressOffsetProperty { get; }

    DependencyProperty CurrentStateProperty { get; }

    DependencyProperty CanSeekProperty { get; }

    DependencyProperty CanPauseProperty { get; }

    DependencyProperty AudioStreamCountProperty { get; }

    DependencyProperty AudioStreamIndexProperty { get; }

    DependencyProperty PlaybackRateProperty { get; }

    DependencyProperty IsLoopingProperty { get; }

    DependencyProperty PlayToSourceProperty { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty DefaultPlaybackRateProperty { get; }

    DependencyProperty AspectRatioWidthProperty { get; }

    DependencyProperty AspectRatioHeightProperty { get; }

    DependencyProperty RealTimePlaybackProperty { get; }

    DependencyProperty AudioCategoryProperty { get; }

    DependencyProperty AudioDeviceTypeProperty { get; }

    DependencyProperty ProtectionManagerProperty { get; }

    DependencyProperty Stereo3DVideoPackingModeProperty { get; }

    DependencyProperty Stereo3DVideoRenderModeProperty { get; }

    DependencyProperty IsStereo3DVideoProperty { get; }

    DependencyProperty ActualStereo3DVideoPackingModeProperty { get; }
  }
}
