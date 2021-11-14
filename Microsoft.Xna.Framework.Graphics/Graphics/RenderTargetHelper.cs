// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.RenderTargetHelper
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  internal class RenderTargetHelper
  {
    internal int width;
    internal int height;
    internal SurfaceFormat format;
    internal DepthFormat depthFormat;
    internal int multiSampleCount;
    internal RenderTargetUsage usage;
    internal int pixelSize;
    internal uint renderTargetHandle = uint.MaxValue;

    internal RenderTargetHelper(
      int width,
      int height,
      SurfaceFormat format,
      DepthFormat depthFormat,
      int multiSampleCount,
      RenderTargetUsage usage)
    {
      this.width = width;
      this.height = height;
      this.format = format;
      this.depthFormat = depthFormat;
      this.multiSampleCount = multiSampleCount;
      this.usage = usage;
      this.pixelSize = Texture.GetByteSizeFromFormat(format);
    }

    internal uint CreateRenderTarget(
      GraphicsDevice device,
      bool mipMap,
      bool isCubeMap,
      out uint levelCount)
    {
      uint textureHandle = uint.MaxValue;
      this.renderTargetHandle = UnsafeNativeMethods.Device.GetGlobal(device).CreateRenderTarget(device.pComPtr, UnsafeNativeStructures.D3D_RENDERTARGET_CREATION_PARAMS.GetStructure(this.width, this.height, mipMap, this.format, this.depthFormat, this.multiSampleCount, this.usage), isCubeMap, out textureHandle, out levelCount);
      return this.renderTargetHandle != uint.MaxValue && textureHandle != uint.MaxValue ? textureHandle : throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
    }

    internal void ReleaseRenderTargetHandle(GraphicsDevice device)
    {
      if (this.renderTargetHandle == uint.MaxValue)
        return;
      UnsafeNativeMethods.Device.GetGlobal(device).ReleaseRenderTargetHandle(device != null ? device.pComPtr : 0U, this.renderTargetHandle);
    }

    internal static RenderTargetHelper FromRenderTarget(Texture renderTarget)
    {
      switch (renderTarget)
      {
        case RenderTarget2D renderTarget2D:
          return renderTarget2D.helper;
        case RenderTargetCube renderTargetCube:
          return renderTargetCube.helper;
        default:
          return (RenderTargetHelper) null;
      }
    }

    internal static bool IsSameSize(Texture renderTargetA, Texture renderTargetB)
    {
      RenderTargetHelper renderTargetHelper1 = RenderTargetHelper.FromRenderTarget(renderTargetA);
      RenderTargetHelper renderTargetHelper2 = RenderTargetHelper.FromRenderTarget(renderTargetB);
      return renderTargetHelper1.width == renderTargetHelper2.width && renderTargetHelper1.height == renderTargetHelper2.height && renderTargetHelper1.multiSampleCount == renderTargetHelper2.multiSampleCount && renderTargetHelper1.pixelSize == renderTargetHelper2.pixelSize;
    }
  }
}
