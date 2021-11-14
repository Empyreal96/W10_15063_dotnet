// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITimelineMarkerRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(2084257523, 11400, 19868, 153, 182, 70, 205, 189, 72, 212, 193)]
  [ExclusiveTo(typeof (TimelineMarkerRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ITimelineMarkerRoutedEventArgs
  {
    TimelineMarker Marker { get; set; }
  }
}
