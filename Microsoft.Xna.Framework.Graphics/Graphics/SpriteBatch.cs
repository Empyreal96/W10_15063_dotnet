// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.SpriteBatch
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Graphics
{
  public class SpriteBatch : GraphicsResource
  {
    private const int MaxBatchSize = 2048;
    private Effect spriteEffect;
    private EffectParameter effectMatrixTransform;
    private SpriteSortMode spriteSortMode;
    private BlendState blendState;
    private DepthStencilState depthStencilState;
    private RasterizerState rasterizerState;
    private SamplerState samplerState;
    private Effect customEffect;
    private Matrix transformMatrix;
    private bool inBeginEndPair;
    private SpriteBatch.SpriteInfo[] spriteQueue = new SpriteBatch.SpriteInfo[2048];
    private int spriteQueueCount;
    private Texture2D[] spriteTextures;
    private int[] sortIndices;
    private SpriteBatch.SpriteInfo[] sortedSprites;
    private SpriteBatch.TextureComparer textureComparer;
    private SpriteBatch.BackToFrontComparer backToFrontComparer;
    private SpriteBatch.FrontToBackComparer frontToBackComparer;
    private static Vector2 vector2Zero = Vector2.Zero;
    private static Rectangle? nullRectangle = new Rectangle?();

    public SpriteBatch(GraphicsDevice graphicsDevice)
    {
      this._parent = graphicsDevice != null ? graphicsDevice : throw new ArgumentNullException(nameof (graphicsDevice), FrameworkResources.DeviceCannotBeNullOnResourceCreate);
      this.spriteEffect = new Effect(graphicsDevice, SpriteEffectCode.Code);
      this.effectMatrixTransform = this.spriteEffect.Parameters["MatrixTransform"];
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.IsDisposed || this.spriteEffect == null)
          return;
        this.spriteEffect.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    public void Begin() => this.Begin(SpriteSortMode.Deferred, (BlendState) null, (SamplerState) null, (DepthStencilState) null, (RasterizerState) null, (Effect) null, Matrix.Identity);

    public void Begin(SpriteSortMode sortMode, BlendState blendState) => this.Begin(sortMode, blendState, (SamplerState) null, (DepthStencilState) null, (RasterizerState) null, (Effect) null, Matrix.Identity);

    public void Begin(
      SpriteSortMode sortMode,
      BlendState blendState,
      SamplerState samplerState,
      DepthStencilState depthStencilState,
      RasterizerState rasterizerState)
    {
      this.Begin(sortMode, blendState, samplerState, depthStencilState, rasterizerState, (Effect) null, Matrix.Identity);
    }

    public void Begin(
      SpriteSortMode sortMode,
      BlendState blendState,
      SamplerState samplerState,
      DepthStencilState depthStencilState,
      RasterizerState rasterizerState,
      Effect effect)
    {
      this.Begin(sortMode, blendState, samplerState, depthStencilState, rasterizerState, effect, Matrix.Identity);
    }

    public void Begin(
      SpriteSortMode sortMode,
      BlendState blendState,
      SamplerState samplerState,
      DepthStencilState depthStencilState,
      RasterizerState rasterizerState,
      Effect effect,
      Matrix transformMatrix)
    {
      if (this.inBeginEndPair)
        throw new InvalidOperationException(FrameworkResources.EndMustBeCalledBeforeBegin);
      this.spriteSortMode = sortMode;
      this.blendState = blendState;
      this.samplerState = samplerState;
      this.depthStencilState = depthStencilState;
      this.rasterizerState = rasterizerState;
      this.customEffect = effect;
      this.transformMatrix = transformMatrix;
      if (sortMode == SpriteSortMode.Immediate)
      {
        if (this._parent.spriteBeginCount > (ushort) 0)
          throw new InvalidOperationException(FrameworkResources.CannotNextSpriteBeginImmediate);
        this.SetRenderState();
        ++this._parent.spriteImmediateBeginCount;
      }
      else if (this._parent.spriteImmediateBeginCount > (ushort) 0)
        throw new InvalidOperationException(FrameworkResources.CannotNextSpriteBeginImmediate);
      ++this._parent.spriteBeginCount;
      this.inBeginEndPair = true;
    }

    public void End()
    {
      if (!this.inBeginEndPair)
        throw new InvalidOperationException(FrameworkResources.BeginMustBeCalledBeforeEnd);
      if (this.spriteSortMode != SpriteSortMode.Immediate)
        this.SetRenderState();
      else
        --this._parent.spriteImmediateBeginCount;
      if (this.spriteQueueCount > 0)
        this.Flush();
      this.inBeginEndPair = false;
      --this._parent.spriteBeginCount;
    }

    public void Draw(Texture2D texture, Vector2 position, Color color) => this.InternalDraw(texture, ref new Vector4()
    {
      X = position.X,
      Y = position.Y,
      Z = 1f,
      W = 1f
    }, true, ref SpriteBatch.nullRectangle, color, 0.0f, ref SpriteBatch.vector2Zero, SpriteEffects.None, 0.0f);

    public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color) => this.InternalDraw(texture, ref new Vector4()
    {
      X = position.X,
      Y = position.Y,
      Z = 1f,
      W = 1f
    }, true, ref sourceRectangle, color, 0.0f, ref SpriteBatch.vector2Zero, SpriteEffects.None, 0.0f);

    public void Draw(
      Texture2D texture,
      Vector2 position,
      Rectangle? sourceRectangle,
      Color color,
      float rotation,
      Vector2 origin,
      float scale,
      SpriteEffects effects,
      float layerDepth)
    {
      this.InternalDraw(texture, ref new Vector4()
      {
        X = position.X,
        Y = position.Y,
        Z = scale,
        W = scale
      }, true, ref sourceRectangle, color, rotation, ref origin, effects, layerDepth);
    }

    public void Draw(
      Texture2D texture,
      Vector2 position,
      Rectangle? sourceRectangle,
      Color color,
      float rotation,
      Vector2 origin,
      Vector2 scale,
      SpriteEffects effects,
      float layerDepth)
    {
      this.InternalDraw(texture, ref new Vector4()
      {
        X = position.X,
        Y = position.Y,
        Z = scale.X,
        W = scale.Y
      }, true, ref sourceRectangle, color, rotation, ref origin, effects, layerDepth);
    }

    public void Draw(Texture2D texture, Rectangle destinationRectangle, Color color) => this.InternalDraw(texture, ref new Vector4()
    {
      X = (float) destinationRectangle.X,
      Y = (float) destinationRectangle.Y,
      Z = (float) destinationRectangle.Width,
      W = (float) destinationRectangle.Height
    }, false, ref SpriteBatch.nullRectangle, color, 0.0f, ref SpriteBatch.vector2Zero, SpriteEffects.None, 0.0f);

    public void Draw(
      Texture2D texture,
      Rectangle destinationRectangle,
      Rectangle? sourceRectangle,
      Color color)
    {
      this.InternalDraw(texture, ref new Vector4()
      {
        X = (float) destinationRectangle.X,
        Y = (float) destinationRectangle.Y,
        Z = (float) destinationRectangle.Width,
        W = (float) destinationRectangle.Height
      }, false, ref sourceRectangle, color, 0.0f, ref SpriteBatch.vector2Zero, SpriteEffects.None, 0.0f);
    }

    public void Draw(
      Texture2D texture,
      Rectangle destinationRectangle,
      Rectangle? sourceRectangle,
      Color color,
      float rotation,
      Vector2 origin,
      SpriteEffects effects,
      float layerDepth)
    {
      this.InternalDraw(texture, ref new Vector4()
      {
        X = (float) destinationRectangle.X,
        Y = (float) destinationRectangle.Y,
        Z = (float) destinationRectangle.Width,
        W = (float) destinationRectangle.Height
      }, false, ref sourceRectangle, color, rotation, ref origin, effects, layerDepth);
    }

    public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color)
    {
      if (spriteFont == null)
        throw new ArgumentNullException(nameof (spriteFont));
      SpriteFont.StringProxy text1 = text != null ? new SpriteFont.StringProxy(text) : throw new ArgumentNullException(nameof (text));
      Vector2 one = Vector2.One;
      spriteFont.InternalDraw(ref text1, this, position, color, 0.0f, Vector2.Zero, ref one, SpriteEffects.None, 0.0f);
    }

    public void DrawString(
      SpriteFont spriteFont,
      StringBuilder text,
      Vector2 position,
      Color color)
    {
      if (spriteFont == null)
        throw new ArgumentNullException(nameof (spriteFont));
      SpriteFont.StringProxy text1 = text != null ? new SpriteFont.StringProxy(text) : throw new ArgumentNullException(nameof (text));
      Vector2 one = Vector2.One;
      spriteFont.InternalDraw(ref text1, this, position, color, 0.0f, Vector2.Zero, ref one, SpriteEffects.None, 0.0f);
    }

    public void DrawString(
      SpriteFont spriteFont,
      string text,
      Vector2 position,
      Color color,
      float rotation,
      Vector2 origin,
      float scale,
      SpriteEffects effects,
      float layerDepth)
    {
      if (spriteFont == null)
        throw new ArgumentNullException(nameof (spriteFont));
      SpriteFont.StringProxy text1 = text != null ? new SpriteFont.StringProxy(text) : throw new ArgumentNullException(nameof (text));
      spriteFont.InternalDraw(ref text1, this, position, color, rotation, origin, ref new Vector2()
      {
        X = scale,
        Y = scale
      }, effects, layerDepth);
    }

    public void DrawString(
      SpriteFont spriteFont,
      StringBuilder text,
      Vector2 position,
      Color color,
      float rotation,
      Vector2 origin,
      float scale,
      SpriteEffects effects,
      float layerDepth)
    {
      if (spriteFont == null)
        throw new ArgumentNullException(nameof (spriteFont));
      SpriteFont.StringProxy text1 = text != null ? new SpriteFont.StringProxy(text) : throw new ArgumentNullException(nameof (text));
      spriteFont.InternalDraw(ref text1, this, position, color, rotation, origin, ref new Vector2()
      {
        X = scale,
        Y = scale
      }, effects, layerDepth);
    }

    public void DrawString(
      SpriteFont spriteFont,
      string text,
      Vector2 position,
      Color color,
      float rotation,
      Vector2 origin,
      Vector2 scale,
      SpriteEffects effects,
      float layerDepth)
    {
      if (spriteFont == null)
        throw new ArgumentNullException(nameof (spriteFont));
      SpriteFont.StringProxy text1 = text != null ? new SpriteFont.StringProxy(text) : throw new ArgumentNullException(nameof (text));
      spriteFont.InternalDraw(ref text1, this, position, color, rotation, origin, ref scale, effects, layerDepth);
    }

    public void DrawString(
      SpriteFont spriteFont,
      StringBuilder text,
      Vector2 position,
      Color color,
      float rotation,
      Vector2 origin,
      Vector2 scale,
      SpriteEffects effects,
      float layerDepth)
    {
      if (spriteFont == null)
        throw new ArgumentNullException(nameof (spriteFont));
      SpriteFont.StringProxy text1 = text != null ? new SpriteFont.StringProxy(text) : throw new ArgumentNullException(nameof (text));
      spriteFont.InternalDraw(ref text1, this, position, color, rotation, origin, ref scale, effects, layerDepth);
    }

    [SecuritySafeCritical]
    private unsafe void InternalDraw(
      Texture2D texture,
      ref Vector4 destination,
      bool scaleDestination,
      ref Rectangle? sourceRectangle,
      Color color,
      float rotation,
      ref Vector2 origin,
      SpriteEffects effects,
      float depth)
    {
      if (texture == null)
        throw new ArgumentNullException(nameof (texture), FrameworkResources.NullNotAllowed);
      if (!this.inBeginEndPair)
        throw new InvalidOperationException(FrameworkResources.BeginMustBeCalledBeforeDraw);
      if (this.spriteQueueCount >= this.spriteQueue.Length)
        Array.Resize<SpriteBatch.SpriteInfo>(ref this.spriteQueue, this.spriteQueue.Length * 2);
      fixed (SpriteBatch.SpriteInfo* spriteInfoPtr = &this.spriteQueue[this.spriteQueueCount])
      {
        float z = destination.Z;
        float w = destination.W;
        if (sourceRectangle.HasValue)
        {
          Rectangle rectangle = sourceRectangle.Value;
          spriteInfoPtr->Source.X = (float) rectangle.X;
          spriteInfoPtr->Source.Y = (float) rectangle.Y;
          spriteInfoPtr->Source.Z = (float) rectangle.Width;
          spriteInfoPtr->Source.W = (float) rectangle.Height;
          if (scaleDestination)
          {
            z *= (float) rectangle.Width;
            w *= (float) rectangle.Height;
          }
        }
        else
        {
          float width = (float) texture.Width;
          float height = (float) texture.Height;
          spriteInfoPtr->Source.X = 0.0f;
          spriteInfoPtr->Source.Y = 0.0f;
          spriteInfoPtr->Source.Z = width;
          spriteInfoPtr->Source.W = height;
          if (scaleDestination)
          {
            z *= width;
            w *= height;
          }
        }
        spriteInfoPtr->Destination.X = destination.X;
        spriteInfoPtr->Destination.Y = destination.Y;
        spriteInfoPtr->Destination.Z = z;
        spriteInfoPtr->Destination.W = w;
        spriteInfoPtr->Origin.X = origin.X;
        spriteInfoPtr->Origin.Y = origin.Y;
        spriteInfoPtr->Rotation = rotation;
        spriteInfoPtr->Depth = depth;
        spriteInfoPtr->Effects = effects;
        spriteInfoPtr->Color = color;
      }
      if (this.spriteSortMode == SpriteSortMode.Immediate)
      {
        this.RenderBatch(texture, this.spriteQueue, 0, 1);
      }
      else
      {
        if (this.spriteTextures == null || this.spriteTextures.Length != this.spriteQueue.Length)
          Array.Resize<Texture2D>(ref this.spriteTextures, this.spriteQueue.Length);
        this.spriteTextures[this.spriteQueueCount] = texture;
        ++this.spriteQueueCount;
      }
    }

    private void Flush()
    {
      SpriteBatch.SpriteInfo[] sprites;
      if (this.spriteSortMode == SpriteSortMode.Deferred)
      {
        sprites = this.spriteQueue;
      }
      else
      {
        this.SortSprites();
        sprites = this.sortedSprites;
      }
      int offset = 0;
      Texture2D texture = (Texture2D) null;
      for (int index = 0; index < this.spriteQueueCount; ++index)
      {
        Texture2D spriteTexture;
        if (this.spriteSortMode == SpriteSortMode.Deferred)
        {
          spriteTexture = this.spriteTextures[index];
        }
        else
        {
          int sortIndex = this.sortIndices[index];
          sprites[index] = this.spriteQueue[sortIndex];
          spriteTexture = this.spriteTextures[sortIndex];
        }
        if (spriteTexture != texture)
        {
          if (index > offset)
            this.RenderBatch(texture, sprites, offset, index - offset);
          offset = index;
          texture = spriteTexture;
        }
      }
      this.RenderBatch(texture, sprites, offset, this.spriteQueueCount - offset);
      Array.Clear((Array) this.spriteTextures, 0, this.spriteQueueCount);
      this.spriteQueueCount = 0;
    }

    private void SortSprites()
    {
      if (this.sortIndices == null || this.sortIndices.Length < this.spriteQueueCount)
      {
        this.sortIndices = new int[this.spriteQueueCount];
        this.sortedSprites = new SpriteBatch.SpriteInfo[this.spriteQueueCount];
      }
      IComparer<int> comparer;
      switch (this.spriteSortMode)
      {
        case SpriteSortMode.Texture:
          if (this.textureComparer == null)
            this.textureComparer = new SpriteBatch.TextureComparer(this);
          comparer = (IComparer<int>) this.textureComparer;
          break;
        case SpriteSortMode.BackToFront:
          if (this.backToFrontComparer == null)
            this.backToFrontComparer = new SpriteBatch.BackToFrontComparer(this);
          comparer = (IComparer<int>) this.backToFrontComparer;
          break;
        case SpriteSortMode.FrontToBack:
          if (this.frontToBackComparer == null)
            this.frontToBackComparer = new SpriteBatch.FrontToBackComparer(this);
          comparer = (IComparer<int>) this.frontToBackComparer;
          break;
        default:
          throw new NotSupportedException();
      }
      for (int index = 0; index < this.spriteQueueCount; ++index)
        this.sortIndices[index] = index;
      Array.Sort<int>(this.sortIndices, 0, this.spriteQueueCount, comparer);
    }

    private void RenderBatch(
      Texture2D texture,
      SpriteBatch.SpriteInfo[] sprites,
      int offset,
      int count)
    {
      if (this.customEffect != null)
      {
        int count1 = this.customEffect.CurrentTechnique.Passes.Count;
        for (int index = 0; index < count1; ++index)
        {
          this.customEffect.CurrentTechnique.Passes[index].Apply();
          this._parent.Textures[0] = (Texture) texture;
          this.PlatformRenderBatch(texture, sprites, offset, count);
        }
      }
      else
      {
        this._parent.Textures[0] = (Texture) texture;
        this.PlatformRenderBatch(texture, sprites, offset, count);
      }
    }

    private void SetRenderState()
    {
      if (this.blendState != null)
        this._parent.BlendState = this.blendState;
      else
        this._parent.BlendState = BlendState.AlphaBlend;
      if (this.depthStencilState != null)
        this._parent.DepthStencilState = this.depthStencilState;
      else
        this._parent.DepthStencilState = DepthStencilState.None;
      if (this.rasterizerState != null)
        this._parent.RasterizerState = this.rasterizerState;
      else
        this._parent.RasterizerState = RasterizerState.CullCounterClockwise;
      if (this.samplerState != null)
        this._parent.SamplerStates[0] = this.samplerState;
      else
        this._parent.SamplerStates[0] = SamplerState.LinearClamp;
      Viewport viewport = this._parent.Viewport;
      float num1 = viewport.Width > 0 ? 1f / (float) viewport.Width : 0.0f;
      float num2 = viewport.Height > 0 ? -1f / (float) viewport.Height : 0.0f;
      this.effectMatrixTransform.SetValue(this.transformMatrix * new Matrix()
      {
        M11 = num1 * 2f,
        M22 = num2 * 2f,
        M33 = 1f,
        M44 = 1f,
        M41 = -1f,
        M42 = 1f
      });
      this.spriteEffect.CurrentTechnique.Passes[0].Apply();
      this.SetPlatformRenderState();
    }

    private void SetPlatformRenderState()
    {
      this._parent.Indices = (IndexBuffer) null;
      this._parent.BeginUserPrimitives(VertexPositionColorTexture.VertexDeclaration);
    }

    [SecuritySafeCritical]
    private unsafe void PlatformRenderBatch(
      Texture2D texture,
      SpriteBatch.SpriteInfo[] sprites,
      int offset,
      int count)
    {
      int spriteCount;
      for (; count > 0; count -= spriteCount)
      {
        spriteCount = count;
        if (spriteCount > 2048)
          spriteCount = 2048;
        int num = spriteCount * sizeof (SpriteBatch.SpriteInfo);
        fixed (SpriteBatch.SpriteInfo* spriteInfoPtr = &sprites[offset])
        {
          if (num < 1536)
            PacketHelpers.SendDrawSpritesPacket(this._parent, spriteCount, (void*) spriteInfoPtr, (uint) num, texture._width, texture._height);
          else
            GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Device.GetGlobal(this._parent).DrawSprites(this._parent.pComPtr, spriteCount, (void*) spriteInfoPtr, texture._width, texture._height));
        }
        offset += spriteCount;
      }
    }

    private struct SpriteInfo
    {
      public Vector4 Source;
      public Vector4 Destination;
      public Vector2 Origin;
      public float Rotation;
      public float Depth;
      public SpriteEffects Effects;
      public Color Color;
    }

    private class TextureComparer : IComparer<int>
    {
      private SpriteBatch parent;

      public TextureComparer(SpriteBatch parent) => this.parent = parent;

      public int Compare(int x, int y) => this.parent.spriteTextures[x].CompareTo((Texture) this.parent.spriteTextures[y]);
    }

    private class BackToFrontComparer : IComparer<int>
    {
      private SpriteBatch parent;

      public BackToFrontComparer(SpriteBatch parent) => this.parent = parent;

      public int Compare(int x, int y)
      {
        float depth1 = this.parent.spriteQueue[x].Depth;
        float depth2 = this.parent.spriteQueue[y].Depth;
        if ((double) depth1 > (double) depth2)
          return -1;
        return (double) depth1 < (double) depth2 ? 1 : 0;
      }
    }

    private class FrontToBackComparer : IComparer<int>
    {
      private SpriteBatch parent;

      public FrontToBackComparer(SpriteBatch parent) => this.parent = parent;

      public int Compare(int x, int y)
      {
        float depth1 = this.parent.spriteQueue[x].Depth;
        float depth2 = this.parent.spriteQueue[y].Depth;
        if ((double) depth1 > (double) depth2)
          return 1;
        return (double) depth1 < (double) depth2 ? -1 : 0;
      }
    }
  }
}
