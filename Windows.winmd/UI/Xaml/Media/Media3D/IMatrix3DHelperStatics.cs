// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.IMatrix3DHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [ExclusiveTo(typeof (Matrix3DHelper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2456048734, 57688, 20084, 136, 153, 104, 145, 96, 189, 47, 140)]
  internal interface IMatrix3DHelperStatics
  {
    Matrix3D Identity { get; }

    Matrix3D Multiply(Matrix3D matrix1, Matrix3D matrix2);

    Matrix3D FromElements(
      double m11,
      double m12,
      double m13,
      double m14,
      double m21,
      double m22,
      double m23,
      double m24,
      double m31,
      double m32,
      double m33,
      double m34,
      double offsetX,
      double offsetY,
      double offsetZ,
      double m44);

    bool GetHasInverse(Matrix3D target);

    bool GetIsIdentity(Matrix3D target);

    Matrix3D Invert(Matrix3D target);
  }
}
