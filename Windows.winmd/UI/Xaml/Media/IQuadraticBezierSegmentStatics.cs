// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IQuadraticBezierSegmentStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (QuadraticBezierSegment))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1774682744, 15371, 19279, 183, 162, 240, 3, 222, 212, 27, 176)]
  internal interface IQuadraticBezierSegmentStatics
  {
    DependencyProperty Point1Property { get; }

    DependencyProperty Point2Property { get; }
  }
}
