// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IBezierSegmentStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(3223878572, 5136, 17712, 132, 82, 28, 157, 10, 209, 243, 65)]
  [ExclusiveTo(typeof (BezierSegment))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBezierSegmentStatics
  {
    DependencyProperty Point1Property { get; }

    DependencyProperty Point2Property { get; }

    DependencyProperty Point3Property { get; }
  }
}
