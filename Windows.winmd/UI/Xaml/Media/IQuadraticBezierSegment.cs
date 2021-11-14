// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IQuadraticBezierSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(743479899, 48920, 17754, 160, 120, 145, 75, 82, 50, 216, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (QuadraticBezierSegment))]
  internal interface IQuadraticBezierSegment
  {
    Point Point1 { get; set; }

    Point Point2 { get; set; }
  }
}
