// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControlsStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(388550620, 22047, 17286, 167, 248, 9, 13, 149, 246, 141, 150)]
  [ExclusiveTo(typeof (MediaTransportControls))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaTransportControlsStatics2
  {
    DependencyProperty IsSkipForwardButtonVisibleProperty { get; }

    DependencyProperty IsSkipForwardEnabledProperty { get; }

    DependencyProperty IsSkipBackwardButtonVisibleProperty { get; }

    DependencyProperty IsSkipBackwardEnabledProperty { get; }

    DependencyProperty IsNextTrackButtonVisibleProperty { get; }

    DependencyProperty IsPreviousTrackButtonVisibleProperty { get; }

    DependencyProperty FastPlayFallbackBehaviourProperty { get; }
  }
}
