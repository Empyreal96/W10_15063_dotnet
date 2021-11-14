// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionGraphicsDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionGraphicsDevice))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [Guid(4213360353, 32930, 18023, 153, 54, 219, 234, 246, 238, 254, 149)]
  internal interface ICompositionGraphicsDevice
  {
    CompositionDrawingSurface CreateDrawingSurface(
      Size sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);

    event TypedEventHandler<CompositionGraphicsDevice, RenderingDeviceReplacedEventArgs> RenderingDeviceReplaced;
  }
}
