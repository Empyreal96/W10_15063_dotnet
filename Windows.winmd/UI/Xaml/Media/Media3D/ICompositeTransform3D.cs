// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.ICompositeTransform3D
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [WebHostHidden]
  [Guid(2306329345, 44941, 19189, 176, 132, 192, 142, 185, 112, 74, 190)]
  [ExclusiveTo(typeof (CompositeTransform3D))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICompositeTransform3D
  {
    double CenterX { get; set; }

    double CenterY { get; set; }

    double CenterZ { get; set; }

    double RotationX { get; set; }

    double RotationY { get; set; }

    double RotationZ { get; set; }

    double ScaleX { get; set; }

    double ScaleY { get; set; }

    double ScaleZ { get; set; }

    double TranslateX { get; set; }

    double TranslateY { get; set; }

    double TranslateZ { get; set; }
  }
}
