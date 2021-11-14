// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.EllipseGeometry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IEllipseGeometryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class EllipseGeometry : Geometry, IEllipseGeometry
  {
    [MethodImpl]
    public extern EllipseGeometry();

    public extern Point Center { [MethodImpl] get; [MethodImpl] set; }

    public extern double RadiusX { [MethodImpl] get; [MethodImpl] set; }

    public extern double RadiusY { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty CenterProperty { [MethodImpl] get; }

    public static extern DependencyProperty RadiusXProperty { [MethodImpl] get; }

    public static extern DependencyProperty RadiusYProperty { [MethodImpl] get; }
  }
}
