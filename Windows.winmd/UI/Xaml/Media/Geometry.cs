// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Geometry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IGeometryFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGeometryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class Geometry : DependencyObject, IGeometry
  {
    public extern Transform Transform { [MethodImpl] get; [MethodImpl] set; }

    public extern Rect Bounds { [MethodImpl] get; }

    public static extern Geometry Empty { [MethodImpl] get; }

    public static extern double StandardFlatteningTolerance { [MethodImpl] get; }

    public static extern DependencyProperty TransformProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }
  }
}
