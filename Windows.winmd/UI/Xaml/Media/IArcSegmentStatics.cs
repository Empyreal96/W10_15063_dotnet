// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IArcSegmentStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2184482670, 35433, 16900, 156, 18, 114, 7, 223, 49, 118, 67)]
  [ExclusiveTo(typeof (ArcSegment))]
  internal interface IArcSegmentStatics
  {
    DependencyProperty PointProperty { get; }

    DependencyProperty SizeProperty { get; }

    DependencyProperty RotationAngleProperty { get; }

    DependencyProperty IsLargeArcProperty { get; }

    DependencyProperty SweepDirectionProperty { get; }
  }
}
