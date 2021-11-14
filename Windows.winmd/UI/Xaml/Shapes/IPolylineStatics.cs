// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IPolylineStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Polyline))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3349818577, 41580, 17328, 170, 165, 130, 47, 166, 74, 17, 185)]
  internal interface IPolylineStatics
  {
    DependencyProperty FillRuleProperty { get; }

    DependencyProperty PointsProperty { get; }
  }
}
