// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaElement3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Casting;
using Windows.Media.Playback;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MediaElement))]
  [Guid(1201630995, 4059, 20184, 146, 138, 77, 57, 22, 156, 60, 210)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaElement3
  {
    MediaTransportControls TransportControls { get; set; }

    event TypedEventHandler<MediaElement, PartialMediaFailureDetectedEventArgs> PartialMediaFailureDetected;

    void SetPlaybackSource(IMediaPlaybackSource source);

    CastingSource GetAsCastingSource();
  }
}
