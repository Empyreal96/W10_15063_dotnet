// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.RenderTarget2D
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  public class RenderTarget2D : Texture2D
  {
    internal RenderTargetHelper helper;

    public RenderTarget2D(GraphicsDevice graphicsDevice, int width, int height)
      : this(graphicsDevice, width, height, false, SurfaceFormat.Color, DepthFormat.None, 0, RenderTargetUsage.DiscardContents)
    {
    }

    public RenderTarget2D(
      GraphicsDevice graphicsDevice,
      int width,
      int height,
      bool mipMap,
      SurfaceFormat preferredFormat,
      DepthFormat preferredDepthFormat)
      : this(graphicsDevice, width, height, mipMap, preferredFormat, preferredDepthFormat, 0, RenderTargetUsage.DiscardContents)
    {
    }

    public RenderTarget2D(
      GraphicsDevice graphicsDevice,
      int width,
      int height,
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
      Texture2D.ValidateCreationParameters(graphicsDevice._profileCapabilities, width, height, selectedFormat, mipMap);
      this.helper = new RenderTargetHelper(width, height, selectedFormat, selectedDepthFormat, selectedMultiSampleCount, usage);
      uint levelCount;
      this.pComPtr = this.helper.CreateRenderTarget(graphicsDevice, mipMap, false, out levelCount);
      this.InitializeDescription(graphicsDevice, selectedFormat, levelCount);
      this._width = width;
      this._height = height;
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
