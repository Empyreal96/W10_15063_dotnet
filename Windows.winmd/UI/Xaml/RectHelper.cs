// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.RectHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IRectHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RectHelper : IRectHelper
  {
    public static extern Rect Empty { [MethodImpl] get; }

    [MethodImpl]
    public static extern Rect FromCoordinatesAndDimensions(
      float x,
      float y,
      float width,
      float height);

    [MethodImpl]
    public static extern Rect FromPoints(Point point1, Point point2);

    [MethodImpl]
    public static extern Rect FromLocationAndSize(Point location, Size size);

    [MethodImpl]
    public static extern bool GetIsEmpty(Rect target);

    [MethodImpl]
    public static extern float GetBottom(Rect target);

    [MethodImpl]
    public static extern float GetLeft(Rect target);

    [MethodImpl]
    public static extern float GetRight(Rect target);

    [MethodImpl]
    public static extern float GetTop(Rect target);

    [MethodImpl]
    public static extern bool Contains(Rect target, Point point);

    [MethodImpl]
    public static extern bool Equals(Rect target, Rect value);

    [MethodImpl]
    public static extern Rect Intersect(Rect target, Rect rect);

    [DefaultOverload]
    [Overload("UnionWithPoint")]
    [MethodImpl]
    public static extern Rect Union(Rect target, Point point);

    [Overload("UnionWithRect")]
    [MethodImpl]
    public static extern Rect Union(Rect target, Rect rect);
  }
}
