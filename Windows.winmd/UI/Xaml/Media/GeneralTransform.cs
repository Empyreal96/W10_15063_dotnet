// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GeneralTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Composable(typeof (IGeneralTransformFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public class GeneralTransform : DependencyObject, IGeneralTransform, IGeneralTransformOverrides
  {
    [MethodImpl]
    protected extern GeneralTransform();

    public extern GeneralTransform Inverse { [MethodImpl] get; }

    [MethodImpl]
    public extern Point TransformPoint(Point point);

    [MethodImpl]
    public extern bool TryTransform(Point inPoint, out Point outPoint);

    [MethodImpl]
    public extern Rect TransformBounds(Rect rect);

    extern GeneralTransform IGeneralTransformOverrides.InverseCore { [MethodImpl] get; }

    [MethodImpl]
    extern bool IGeneralTransformOverrides.TryTransformCore(
      Point inPoint,
      out Point outPoint);

    [MethodImpl]
    extern Rect IGeneralTransformOverrides.TransformBoundsCore(
      Rect rect);
  }
}
