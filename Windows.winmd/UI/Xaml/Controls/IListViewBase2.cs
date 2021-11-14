// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3519194359, 30883, 17553, 134, 224, 45, 222, 188, 0, 122, 197)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewBase))]
  internal interface IListViewBase2
  {
    bool ShowsScrollingPlaceholders { get; set; }

    event TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> ContainerContentChanging;

    void SetDesiredContainerUpdateDuration(TimeSpan duration);

    object Footer { get; set; }

    DataTemplate FooterTemplate { get; set; }

    TransitionCollection FooterTransitions { get; set; }
  }
}
