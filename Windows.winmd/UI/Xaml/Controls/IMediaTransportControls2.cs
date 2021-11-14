// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControls2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(730460140, 7146, 17694, 139, 205, 207, 226, 217, 66, 50, 98)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MediaTransportControls))]
  internal interface IMediaTransportControls2
  {
    bool IsSkipForwardButtonVisible { get; set; }

    bool IsSkipForwardEnabled { get; set; }

    bool IsSkipBackwardButtonVisible { get; set; }

    bool IsSkipBackwardEnabled { get; set; }

    bool IsNextTrackButtonVisible { get; set; }

    bool IsPreviousTrackButtonVisible { get; set; }

    FastPlayFallbackBehaviour FastPlayFallbackBehaviour { get; set; }

    event TypedEventHandler<MediaTransportControls, MediaTransportControlsThumbnailRequestedEventArgs> ThumbnailRequested;
  }
}
