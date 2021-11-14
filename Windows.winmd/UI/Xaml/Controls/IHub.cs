// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHub
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2926128770, 29460, 20305, 171, 17, 42, 241, 237, 74, 25, 248)]
  [ExclusiveTo(typeof (Hub))]
  internal interface IHub
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    Orientation Orientation { get; set; }

    int DefaultSectionIndex { get; set; }

    IVector<HubSection> Sections { get; }

    IVector<HubSection> SectionsInView { get; }

    IObservableVector<object> SectionHeaders { get; }

    event HubSectionHeaderClickEventHandler SectionHeaderClick;

    event SectionsInViewChangedEventHandler SectionsInViewChanged;

    void ScrollToSection(HubSection section);
  }
}
