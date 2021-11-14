// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.GraphicsDeviceExtensions
// Assembly: Microsoft.Xna.Framework.Interop, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: E258DF81-FBD7-4DF4-930E-981F36DBB495
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI20E9~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using MS.Internal;
using System;
using System.Security;
using System.Windows;

namespace Microsoft.Xna.Framework.Graphics
{
  public static class GraphicsDeviceExtensions
  {
    internal static void ClearDeviceStates(this GraphicsDevice device)
    {
      Viewport viewport = new Viewport();
      device.Indices = (IndexBuffer) null;
      device.SetVertexBuffers((VertexBufferBinding[]) null);
      device.SetRenderTargets((RenderTargetBinding[]) null);
      device.Textures.ResetState();
      device.VertexTextures.ResetState();
      device.vertexDeclarationManager.ReleaseAllDeclarations();
      device._vertexShaderActive = false;
      device._pixelShaderActive = false;
      device._scissorRectDirty = true;
      viewport.Width = device._internalCachedPresentParams.BackBufferWidth;
      viewport.Height = device._internalCachedPresentParams.BackBufferHeight;
      viewport.MaxDepth = 1f;
      device.Viewport = viewport;
      device.InitializeDeviceState();
    }

    [SecuritySafeCritical]
    public static void SetSharingMode(this GraphicsDevice device, bool enabled)
    {
      if (ApplicationHost.Current.ApplicationType == ApplicationType.Xna)
        throw new InvalidOperationException(FrameworkResources.DirectRenderingWrongAppType);
      XcpImports.CheckThread();
      if (!Microsoft.Phone.QuirksMode.ShouldSupportDirectRendering())
        throw new NotSupportedException(FrameworkResources.DirectRenderingNotSupported);
      if (device.inDirectRenderingMode == enabled)
        return;
      if (device.currentRenderTargetCount > 0)
        throw new InvalidOperationException(Resources.DirectRenderCannotChangeActiveRenderTargets);
      if (enabled)
      {
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeSharedGraphicsNativeMethods.DirectRendering_Begin(device.pComPtr));
        device.inDirectRenderingMode = true;
        Application.Current.LetterboxingStrategy = Application.Current.LetterboxingStrategyForXNA;
        device.ClearDeviceStates();
        device.FlushBuffer();
        SharedGraphicsDeviceManager.Current.ChangeDevice(false);
      }
      else
      {
        device.ClearDeviceStates();
        device.FlushBuffer();
        device.inDirectRenderingMode = false;
        Application.Current.LetterboxingStrategy = Application.Current.LetterboxingStrategyForSilverlight;
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeSharedGraphicsNativeMethods.DirectRendering_End(device.pComPtr));
      }
    }
  }
}
