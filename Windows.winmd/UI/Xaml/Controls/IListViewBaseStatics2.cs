// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBaseStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2182873288, 30924, 16671, 159, 46, 165, 87, 88, 34, 127, 62)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewBase))]
  internal interface IListViewBaseStatics2
  {
    DependencyProperty ShowsScrollingPlaceholdersProperty { get; }

    DependencyProperty FooterProperty { get; }

    DependencyProperty FooterTemplateProperty { get; }

    DependencyProperty FooterTransitionsProperty { get; }
  }
}
