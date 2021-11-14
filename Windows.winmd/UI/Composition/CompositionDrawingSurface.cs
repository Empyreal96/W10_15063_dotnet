// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionDrawingSurface
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [Composable(typeof (ICompositionDrawingSurfaceFactory), CompositionType.Protected, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class CompositionDrawingSurface : 
    CompositionObject,
    ICompositionDrawingSurface,
    ICompositionSurface,
    ICompositionDrawingSurface2
  {
    public extern DirectXAlphaMode AlphaMode { [MethodImpl] get; }

    public extern DirectXPixelFormat PixelFormat { [MethodImpl] get; }

    public extern Size Size { [MethodImpl] get; }

    public extern SizeInt32 SizeInt32 { [MethodImpl] get; }

    [MethodImpl]
    public extern void Resize(SizeInt32 sizePixels);

    [Overload("Scroll")]
    [MethodImpl]
    public extern void Scroll(PointInt32 offset);

    [Overload("ScrollRect")]
    [MethodImpl]
    public extern void Scroll(PointInt32 offset, RectInt32 scrollRect);

    [Overload("ScrollWithClip")]
    [MethodImpl]
    public extern void ScrollWithClip(PointInt32 offset, RectInt32 clipRect);

    [Overload("ScrollRectWithClip")]
    [MethodImpl]
    public extern void ScrollWithClip(PointInt32 offset, RectInt32 clipRect, RectInt32 scrollRect);
  }
}
