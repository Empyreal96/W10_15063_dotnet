// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.TextureCollection
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
  [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
  public sealed class TextureCollection
  {
    private GraphicsDevice _parent;
    private int _textureOffset;
    private int _maxTextures;

    internal TextureCollection(GraphicsDevice graphicsDevice, int textureOffset, int maxTextures)
    {
      this._parent = graphicsDevice;
      this._textureOffset = textureOffset;
      this._maxTextures = maxTextures;
    }

    private void ValidateIndex(int index)
    {
      if (index < 0 || index >= this._maxTextures)
        throw new ArgumentOutOfRangeException(nameof (index));
    }

    internal void ResetState()
    {
      for (int index = 0; index < this._maxTextures; ++index)
        this[index] = (Texture) null;
    }

    [SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")]
    public Texture this[int index]
    {
      get
      {
        this.ValidateIndex(index);
        TextureType textureType;
        UnsafeNativeStructures.TEXTURE_CREATION_PARAMS parameters;
        uint texture = UnsafeNativeMethods.Device.GetGlobal(this._parent).GetTexture(this._parent.pComPtr, (uint) (index + this._textureOffset), out textureType, out parameters);
        if (texture == uint.MaxValue)
          return (Texture) null;
        object resourceFromHandle = this._parent.GetKnownResourceFromHandle(texture);
        if (resourceFromHandle != null)
          return resourceFromHandle as Texture;
        switch (textureType)
        {
          case TextureType.Texture2D:
            return (Texture) new Texture2D(this._parent, texture, parameters);
          case TextureType.Texture3D:
            return (Texture) new Texture3D(this._parent, texture, parameters);
          case TextureType.TextureCube:
            return (Texture) new TextureCube(this._parent, texture, parameters);
          default:
            return (Texture) null;
        }
      }
      set
      {
        if (value != null)
        {
          if (value._isDisposed)
            throw new ObjectDisposedException(value.GetType().Name);
          if (value.isActiveRenderTarget)
            throw new InvalidOperationException(FrameworkResources.MustResolveRenderTarget);
          if (this._textureOffset > 0 && !value.isValidVertexTexture)
            this._parent._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileVertexTextureFormatNotSupported, (object) value.Format);
        }
        this.ValidateIndex(index);
        PacketHelpers.SendSetTexturePacket(this._parent, HLCBPacketType.SetTexture, (GraphicsResource) value, index + this._textureOffset);
      }
    }
  }
}
