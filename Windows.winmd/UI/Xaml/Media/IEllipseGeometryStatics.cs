// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IEllipseGeometryStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (EllipseGeometry))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(390388551, 63029, 19222, 174, 230, 224, 82, 166, 93, 239, 178)]
  internal interface IEllipseGeometryStatics
  {
    DependencyProperty CenterProperty { get; }

    DependencyProperty RadiusXProperty { get; }

    DependencyProperty RadiusYProperty { get; }
  }
}
