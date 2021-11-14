// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IArcSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ArcSegment))]
  [Guid(127143007, 25595, 17513, 145, 190, 241, 9, 124, 22, 128, 82)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IArcSegment
  {
    Point Point { get; set; }

    Size Size { get; set; }

    double RotationAngle { get; set; }

    bool IsLargeArc { get; set; }

    SweepDirection SweepDirection { get; set; }
  }
}
