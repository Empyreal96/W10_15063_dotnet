// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionDrawingSurface2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CompositionDrawingSurface))]
  [WebHostHidden]
  [Guid(4207995019, 58196, 17640, 142, 61, 196, 136, 13, 90, 33, 63)]
  internal interface ICompositionDrawingSurface2
  {
    SizeInt32 SizeInt32 { get; }

    void Resize(SizeInt32 sizePixels);

    [Overload("Scroll")]
    void Scroll(PointInt32 offset);

    [Overload("ScrollRect")]
    void Scroll(PointInt32 offset, RectInt32 scrollRect);

    [Overload("ScrollWithClip")]
    void ScrollWithClip(PointInt32 offset, RectInt32 clipRect);

    [Overload("ScrollRectWithClip")]
    void ScrollWithClip(PointInt32 offset, RectInt32 clipRect, RectInt32 scrollRect);
  }
}
