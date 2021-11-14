// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplicationViewTitleBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [Guid(7157219, 57841, 17179, 149, 8, 41, 185, 105, 38, 172, 83)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreApplicationViewTitleBar))]
  internal interface ICoreApplicationViewTitleBar
  {
    bool ExtendViewIntoTitleBar { set; get; }

    double SystemOverlayLeftInset { get; }

    double SystemOverlayRightInset { get; }

    double Height { get; }

    event TypedEventHandler<CoreApplicationViewTitleBar, object> LayoutMetricsChanged;

    bool IsVisible { get; }

    event TypedEventHandler<CoreApplicationViewTitleBar, object> IsVisibleChanged;
  }
}
