// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.Matrix3DHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMatrix3DHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Matrix3DHelper : IMatrix3DHelper
  {
    public static extern Matrix3D Identity { [MethodImpl] get; }

    [MethodImpl]
    public static extern Matrix3D Multiply(Matrix3D matrix1, Matrix3D matrix2);

    [MethodImpl]
    public static extern Matrix3D FromElements(
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

    [MethodImpl]
    public static extern bool GetHasInverse(Matrix3D target);

    [MethodImpl]
    public static extern bool GetIsIdentity(Matrix3D target);

    [MethodImpl]
    public static extern Matrix3D Invert(Matrix3D target);
  }
}
