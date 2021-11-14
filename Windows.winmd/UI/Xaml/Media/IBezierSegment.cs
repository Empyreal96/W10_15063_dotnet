// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IBezierSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BezierSegment))]
  [Guid(2940975598, 35204, 18871, 129, 223, 63, 53, 153, 75, 149, 235)]
  internal interface IBezierSegment
  {
    Point Point1 { get; set; }

    Point Point2 { get; set; }

    Point Point3 { get; set; }
  }
}
