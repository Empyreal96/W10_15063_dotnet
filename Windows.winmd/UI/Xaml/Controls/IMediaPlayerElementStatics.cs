// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaPlayerElementStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlayerElement))]
  [Guid(511459360, 44119, 17117, 173, 28, 62, 188, 45, 127, 8, 186)]
  [WebHostHidden]
  internal interface IMediaPlayerElementStatics
  {
    DependencyProperty SourceProperty { get; }

    DependencyProperty AreTransportControlsEnabledProperty { get; }

    DependencyProperty PosterSourceProperty { get; }

    DependencyProperty StretchProperty { get; }

    DependencyProperty AutoPlayProperty { get; }

    DependencyProperty IsFullWindowProperty { get; }

    DependencyProperty MediaPlayerProperty { get; }
  }
}
