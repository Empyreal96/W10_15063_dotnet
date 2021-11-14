// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Matrix3DProjection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml.Media
{
  [ContentProperty(Name = "ProjectionMatrix")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMatrix3DProjectionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Matrix3DProjection : Projection, IMatrix3DProjection
  {
    [MethodImpl]
    public extern Matrix3DProjection();

    public extern Matrix3D ProjectionMatrix { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ProjectionMatrixProperty { [MethodImpl] get; }
  }
}
