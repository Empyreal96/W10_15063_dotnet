// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.RenderTargetCube
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  public class RenderTargetCube : TextureCube
  {
    internal RenderTargetHelper helper;

    public RenderTargetCube(
      GraphicsDevice graphicsDevice,
      int size,
      bool mipMap,
      SurfaceFormat preferredFormat,
      DepthFormat preferredDepthFormat)
      : this(graphicsDevice, size, mipMap, preferredFormat, preferredDepthFormat, 0, RenderTargetUsage.DiscardContents)
    {
    }

    public RenderTargetCube(
      GraphicsDevice graphicsDevice,
      int size,
      bool mipMap,
      SurfaceFormat preferredFormat,
      DepthFormat preferredDepthFormat,
      int preferredMultiSampleCount,
      RenderTargetUsage usage)
    {
      if (graphicsDevice == null)
        throw new ArgumentNullException(nameof (graphicsDevice), FrameworkResources.DeviceCannotBeNullOnResourceCreate);
      SurfaceFormat selectedFormat;
      DepthFormat selectedDepthFormat;
      int selectedMultiSampleCount;
      graphicsDevice.Adapter.QueryRenderTargetFormat(graphicsDevice.GraphicsProfile, preferredFormat, preferredDepthFormat, preferredMultiSampleCount, out selectedFormat, out selectedDepthFormat, out selectedMultiSampleCount);
      TextureCube.ValidateCreationParameters(graphicsDevice._profileCapabilities, size, selectedFormat);
      int num = size;
      this.helper = new RenderTargetHelper(num, num, selectedFormat, selectedDepthFormat, selectedMultiSampleCount, usage);
      uint levelCount;
      this.pComPtr = this.helper.CreateRenderTarget(graphicsDevice, mipMap, true, out levelCount);
      this.InitializeDescription(graphicsDevice, selectedFormat, levelCount);
      this._size = size;
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        if (this._isDisposed || this.helper == null)
          return;
        this.helper.ReleaseRenderTargetHandle(this._parent);
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    public DepthFormat DepthStencilFormat => this.helper.depthFormat;

    public int MultiSampleCount => this.helper.multiSampleCount;

    public RenderTargetUsage RenderTargetUsage => this.helper.usage;

    public bool IsContentLost => false;

    public event EventHandler<EventArgs> ContentLost;
  }
}
