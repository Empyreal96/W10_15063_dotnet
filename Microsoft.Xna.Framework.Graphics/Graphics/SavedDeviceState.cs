// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.SavedDeviceState
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

namespace Microsoft.Xna.Framework.Graphics
{
  internal class SavedDeviceState
  {
    private GraphicsDevice device;
    private VertexBufferBinding[] vertexBuffers;
    private IndexBuffer indices;
    private Texture[] textures;
    private SamplerState[] samplerStates;
    private Texture[] vertexTextures;
    private SamplerState[] vertexSamplerStates;
    private BlendState blendState;
    private Color blendFactor;
    private int multiSampleMask;
    private DepthStencilState depthStencilState;
    private int referenceStencil;
    private RasterizerState rasterizerState;
    private Viewport? viewport;
    private Rectangle? scissorRectangle;

    public SavedDeviceState(GraphicsDevice device, bool saveViewport)
    {
      this.device = device;
      this.vertexBuffers = device.GetVertexBuffers();
      this.indices = device.Indices;
      int maxSamplers = device._profileCapabilities.MaxSamplers;
      this.textures = new Texture[maxSamplers];
      this.samplerStates = new SamplerState[maxSamplers];
      for (int index = 0; index < maxSamplers; ++index)
      {
        this.textures[index] = device.Textures[index];
        this.samplerStates[index] = device.SamplerStates[index];
      }
      int maxVertexSamplers = device._profileCapabilities.MaxVertexSamplers;
      this.vertexTextures = new Texture[maxVertexSamplers];
      this.vertexSamplerStates = new SamplerState[maxVertexSamplers];
      for (int index = 0; index < maxVertexSamplers; ++index)
      {
        this.vertexTextures[index] = device.VertexTextures[index];
        this.vertexSamplerStates[index] = device.VertexSamplerStates[index];
      }
      this.blendState = device.BlendState;
      this.blendFactor = device.BlendFactor;
      this.multiSampleMask = device.MultiSampleMask;
      this.depthStencilState = device.DepthStencilState;
      this.referenceStencil = device.ReferenceStencil;
      this.rasterizerState = device.RasterizerState;
      if (!saveViewport)
        return;
      this.viewport = new Viewport?(device.Viewport);
      this.scissorRectangle = new Rectangle?(device.ScissorRectangle);
    }

    public void Restore()
    {
      this.device.SetVertexBuffers(this.vertexBuffers);
      this.device.Indices = this.indices;
      for (int index = 0; index < this.device._profileCapabilities.MaxSamplers; ++index)
      {
        if (this.textures[index] != null)
          this.device.Textures[index] = this.textures[index];
        if (this.samplerStates[index] != null)
          this.device.SamplerStates[index] = this.samplerStates[index];
      }
      for (int index = 0; index < this.device._profileCapabilities.MaxVertexSamplers; ++index)
      {
        if (this.vertexTextures[index] != null)
          this.device.VertexTextures[index] = this.vertexTextures[index];
        if (this.vertexSamplerStates[index] != null)
          this.device.VertexSamplerStates[index] = this.vertexSamplerStates[index];
      }
      if (this.blendState != null)
      {
        this.device.BlendState = this.blendState;
        this.device.BlendFactor = this.blendFactor;
        this.device.MultiSampleMask = this.multiSampleMask;
      }
      if (this.depthStencilState != null)
      {
        this.device.DepthStencilState = this.depthStencilState;
        this.device.ReferenceStencil = this.referenceStencil;
      }
      if (this.rasterizerState != null)
        this.device.RasterizerState = this.rasterizerState;
      if (this.viewport.HasValue)
        this.device.Viewport = this.viewport.Value;
      if (!this.scissorRectangle.HasValue)
        return;
      this.device.ScissorRectangle = this.scissorRectangle.Value;
    }
  }
}
