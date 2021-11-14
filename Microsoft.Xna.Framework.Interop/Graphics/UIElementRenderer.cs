// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.UIElementRenderer
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
  public class UIElementRenderer : IDisposable
  {
    private DirectRenderingTexture directRenderingTexture;
    private uint textureHandle = uint.MaxValue;
    private int width;
    private int height;
    private object renderSyncObject = new object();
    private bool _disposed;

    public UIElement Element { get; private set; }

    public Texture2D Texture { get; private set; }

    public UIElementRenderer(UIElement rootElement, int textureWidth, int textureHeight)
    {
      ProfileCapabilities profileCapabilities = SharedGraphicsDeviceManager.Current.GraphicsDevice._profileCapabilities;
      if (ApplicationHost.Current.ApplicationType == ApplicationType.Xna)
        throw new InvalidOperationException(FrameworkResources.DirectRenderingWrongAppType);
      if (rootElement == null)
        throw new ArgumentNullException(nameof (rootElement));
      if (textureWidth < 1)
        throw new ArgumentOutOfRangeException(nameof (textureWidth));
      if (textureHeight < 1)
        throw new ArgumentOutOfRangeException(nameof (textureHeight));
      if (textureWidth > profileCapabilities.MaxTextureSize || textureHeight > profileCapabilities.MaxTextureSize)
        profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileTooBig, (object) typeof (Texture2D).Name, (object) profileCapabilities.MaxTextureSize);
      this.Element = rootElement;
      this.directRenderingTexture = new DirectRenderingTexture(rootElement, textureWidth, textureHeight);
      this.width = textureWidth;
      this.height = textureHeight;
    }

    [SecuritySafeCritical]
    public void Render()
    {
      lock (this.renderSyncObject)
      {
        if (this._disposed)
          throw new ObjectDisposedException(nameof (UIElementRenderer), FrameworkResources.ObjectDisposedException);
        uint textureHandle = this.textureHandle;
        int num = (int) UnsafeSharedGraphicsNativeMethods.DirectRendering_RenderSharedTexture(SharedGraphicsDeviceManager.Current.GraphicsDevice.pComPtr, (DependencyObject) this.directRenderingTexture, (uint) this.width, (uint) this.height, ref this.textureHandle);
        if (num == -2013263620)
          throw new InvalidOperationException(Resources.UIElementNotInVisualTree);
        GraphicsHelpers.ThrowExceptionFromResult((uint) num);
        if (this.Texture != null && (int) this.textureHandle != (int) textureHandle)
        {
          this.Texture.Dispose();
          this.Texture = (Texture2D) null;
        }
        if (this.Texture != null)
          return;
        this.Texture = new Texture2D(SharedGraphicsDeviceManager.Current.GraphicsDevice, this.textureHandle, new UnsafeNativeStructures.TEXTURE_CREATION_PARAMS((uint) this.width, (uint) this.height, 0U, false, SurfaceFormat.Color, 0));
      }
    }

    protected virtual void Dispose(bool disposing)
    {
      if (!disposing)
        return;
      lock (this.renderSyncObject)
      {
        if (this._disposed)
          return;
        this._disposed = true;
        if (this.directRenderingTexture != null)
        {
          this.directRenderingTexture.Dispose();
          this.directRenderingTexture = (DirectRenderingTexture) null;
        }
        if (this.Texture == null)
          return;
        this.Texture.Dispose();
        this.Texture = (Texture2D) null;
      }
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }
  }
}
