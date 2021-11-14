// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPlaneProjection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlaneProjection))]
  [WebHostHidden]
  [Guid(3875023866, 26406, 18074, 178, 89, 165, 24, 131, 71, 202, 143)]
  internal interface IPlaneProjection
  {
    double LocalOffsetX { get; set; }

    double LocalOffsetY { get; set; }

    double LocalOffsetZ { get; set; }

    double RotationX { get; set; }

    double RotationY { get; set; }

    double RotationZ { get; set; }

    double CenterOfRotationX { get; set; }

    double CenterOfRotationY { get; set; }

    double CenterOfRotationZ { get; set; }

    double GlobalOffsetX { get; set; }

    double GlobalOffsetY { get; set; }

    double GlobalOffsetZ { get; set; }

    Matrix3D ProjectionMatrix { get; }
  }
}
