// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionGraphicsDevice2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionGraphicsDevice))]
  [Guid(263765494, 49392, 19404, 159, 184, 8, 73, 130, 73, 13, 125)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ICompositionGraphicsDevice2
  {
    CompositionDrawingSurface CreateDrawingSurface2(
      SizeInt32 sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);

    CompositionVirtualDrawingSurface CreateVirtualDrawingSurface(
      SizeInt32 sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);
  }
}
