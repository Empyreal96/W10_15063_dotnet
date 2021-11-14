// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITimelineMarkerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TimelineMarker))]
  [Guid(3299799238, 5795, 18507, 135, 245, 101, 40, 184, 240, 74, 71)]
  internal interface ITimelineMarkerStatics
  {
    DependencyProperty TimeProperty { get; }

    DependencyProperty TypeProperty { get; }

    DependencyProperty TextProperty { get; }
  }
}
