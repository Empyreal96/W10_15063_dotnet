// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBorder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Border))]
  [Guid(2038187321, 17853, 17971, 160, 68, 191, 176, 46, 245, 23, 15)]
  [WebHostHidden]
  internal interface IBorder
  {
    Brush BorderBrush { get; set; }

    Thickness BorderThickness { get; set; }

    Brush Background { get; set; }

    CornerRadius CornerRadius { get; set; }

    Thickness Padding { get; set; }

    UIElement Child { get; set; }

    TransitionCollection ChildTransitions { get; set; }
  }
}
