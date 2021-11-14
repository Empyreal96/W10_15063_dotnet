// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IRectHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(1591829476, 49534, 18767, 181, 128, 47, 5, 116, 252, 58, 21)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RectHelper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRectHelperStatics
  {
    Rect Empty { get; }

    Rect FromCoordinatesAndDimensions(float x, float y, float width, float height);

    Rect FromPoints(Point point1, Point point2);

    Rect FromLocationAndSize(Point location, Size size);

    bool GetIsEmpty(Rect target);

    float GetBottom(Rect target);

    float GetLeft(Rect target);

    float GetRight(Rect target);

    float GetTop(Rect target);

    bool Contains(Rect target, Point point);

    bool Equals(Rect target, Rect value);

    Rect Intersect(Rect target, Rect rect);

    [DefaultOverload]
    [Overload("UnionWithPoint")]
    Rect Union(Rect target, Point point);

    [Overload("UnionWithRect")]
    Rect Union(Rect target, Rect rect);
  }
}
