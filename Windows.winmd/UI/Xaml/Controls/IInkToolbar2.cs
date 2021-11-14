// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbar2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbar))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2263925009, 46212, 17738, 174, 120, 29, 37, 163, 61, 28, 103)]
  [WebHostHidden]
  internal interface IInkToolbar2
  {
    bool IsStencilButtonChecked { get; set; }

    InkToolbarButtonFlyoutPlacement ButtonFlyoutPlacement { get; set; }

    Orientation Orientation { get; set; }

    event TypedEventHandler<InkToolbar, InkToolbarIsStencilButtonCheckedChangedEventArgs> IsStencilButtonCheckedChanged;

    InkToolbarMenuButton GetMenuButton(InkToolbarMenuKind menu);
  }
}
