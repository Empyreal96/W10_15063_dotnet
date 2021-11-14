// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IPolygonStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [Guid(908757675, 54371, 17254, 158, 26, 190, 186, 114, 129, 15, 183)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Polygon))]
  internal interface IPolygonStatics
  {
    DependencyProperty FillRuleProperty { get; }

    DependencyProperty PointsProperty { get; }
  }
}
