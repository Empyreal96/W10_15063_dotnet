// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2864838898, 11295, 20124, 179, 243, 49, 255, 34, 181, 28, 122)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkToolbar))]
  internal interface IInkToolbarStatics2
  {
    DependencyProperty IsStencilButtonCheckedProperty { get; }

    DependencyProperty ButtonFlyoutPlacementProperty { get; }

    DependencyProperty OrientationProperty { get; }
  }
}
