// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITimelineMarker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (TimelineMarker))]
  [Guid(2794385453, 17850, 20048, 140, 173, 170, 234, 58, 34, 122, 245)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ITimelineMarker
  {
    TimeSpan Time { get; set; }

    string Type { get; set; }

    string Text { get; set; }
  }
}
