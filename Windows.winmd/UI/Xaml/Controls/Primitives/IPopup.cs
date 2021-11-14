// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPopup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(1648460352, 59091, 18181, 161, 220, 57, 21, 100, 86, 238, 41)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Popup))]
  internal interface IPopup
  {
    UIElement Child { get; set; }

    bool IsOpen { get; set; }

    double HorizontalOffset { get; set; }

    double VerticalOffset { get; set; }

    TransitionCollection ChildTransitions { get; set; }

    bool IsLightDismissEnabled { get; set; }

    event EventHandler<object> Opened;

    event EventHandler<object> Closed;
  }
}
