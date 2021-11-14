// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionGraphicsDevice
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
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class CompositionGraphicsDevice : 
    CompositionObject,
    ICompositionGraphicsDevice,
    ICompositionGraphicsDevice2
  {
    [MethodImpl]
    public extern CompositionDrawingSurface CreateDrawingSurface(
      Size sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);

    public extern event TypedEventHandler<CompositionGraphicsDevice, RenderingDeviceReplacedEventArgs> RenderingDeviceReplaced;

    [MethodImpl]
    public extern CompositionDrawingSurface CreateDrawingSurface2(
      SizeInt32 sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);

    [MethodImpl]
    public extern CompositionVirtualDrawingSurface CreateVirtualDrawingSurface(
      SizeInt32 sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);
  }
}
