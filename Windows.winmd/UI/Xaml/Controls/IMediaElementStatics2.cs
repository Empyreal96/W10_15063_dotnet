// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaElementStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (MediaElement))]
  [Guid(2666002470, 61780, 19910, 128, 20, 166, 235, 169, 135, 248, 71)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaElementStatics2
  {
    DependencyProperty AreTransportControlsEnabledProperty { get; }

    DependencyProperty StretchProperty { get; }

    DependencyProperty IsFullWindowProperty { get; }

    DependencyProperty PlayToPreferredSourceUriProperty { [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
