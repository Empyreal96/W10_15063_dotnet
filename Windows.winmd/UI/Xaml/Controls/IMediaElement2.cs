// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaElement2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(4250131045, 45446, 18004, 191, 219, 24, 14, 210, 108, 173, 7)]
  [ExclusiveTo(typeof (MediaElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaElement2
  {
    bool AreTransportControlsEnabled { get; set; }

    Stretch Stretch { get; set; }

    bool IsFullWindow { get; set; }

    void SetMediaStreamSource(IMediaSource source);

    Uri PlayToPreferredSourceUri { [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }
  }
}
