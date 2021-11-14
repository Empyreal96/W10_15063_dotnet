// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(1916725771, 53550, 17165, 169, 240, 155, 179, 43, 191, 153, 19)]
  [ExclusiveTo(typeof (FlyoutBase))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFlyoutBase
  {
    FlyoutPlacementMode Placement { get; set; }

    event EventHandler<object> Opened;

    event EventHandler<object> Closed;

    event EventHandler<object> Opening;

    void ShowAt(FrameworkElement placementTarget);

    void Hide();
  }
}
