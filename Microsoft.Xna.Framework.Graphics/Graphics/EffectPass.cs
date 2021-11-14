// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.EffectPass
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Text;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class EffectPass
  {
    internal uint _handle;
    internal string _name = string.Empty;
    internal uint _index;
    internal EffectStateFlags _stateFlags;
    internal uint _textureFlags;
    private EffectAnnotationCollection _annotations;
    private EffectTechnique _technique;
    private bool _canDrawVertexShader;
    private bool _canDrawPixelShader;

    internal EffectPass(Effect parent, EffectTechnique technique, uint index)
    {
      StringBuilder sb = new StringBuilder(260);
      UnsafeNativeStructures.EFFECT_PASS_DESC desc;
      this._handle = UnsafeNativeMethods.Effect.GetGlobal(parent.GraphicsDevice).GetPass(parent.GraphicsDevice.pComPtr, parent.pComPtr, technique._handle, index, out desc, sb);
      this._name = string.Intern(sb.ToString());
      this._index = index;
      this._canDrawVertexShader = desc.vs > 0U;
      this._canDrawPixelShader = desc.ps > 0U;
      if (desc.Annotations > 0U)
        this._annotations = new EffectAnnotationCollection(parent, this._handle, desc.Annotations);
      this._technique = technique;
    }

    public EffectAnnotationCollection Annotations => this._annotations == null ? EffectAnnotationCollection.Empty : this._annotations;

    public string Name => this._name;

    public void Apply()
    {
      Effect parent = this._technique._parent;
      if (parent._currentTechnique != this._technique)
        throw new InvalidOperationException(FrameworkResources.NotCurrentTechnique);
      parent.OnApply();
      GraphicsDevice graphicsDevice = parent.GraphicsDevice;
      PacketHelpers.SendEffectApplyPacket(graphicsDevice, parent, this._index, this._stateFlags, this._textureFlags);
      if (this._stateFlags != EffectStateFlags.None)
        this.SyncEffectState();
      if (this._canDrawVertexShader)
        graphicsDevice._vertexShaderActive = true;
      if (!this._canDrawPixelShader)
        return;
      graphicsDevice._pixelShaderActive = true;
    }

    private void SyncEffectState()
    {
      GraphicsDevice graphicsDevice = this._technique._parent.GraphicsDevice;
      if ((this._stateFlags & EffectStateFlags.Blend) != EffectStateFlags.None)
        graphicsDevice.ClearBlendState();
      if ((this._stateFlags & EffectStateFlags.DepthStencil) != EffectStateFlags.None)
        graphicsDevice.ClearDepthStencilState();
      if ((this._stateFlags & EffectStateFlags.Rasterizer) != EffectStateFlags.None)
        graphicsDevice.ClearRasterizerState();
      if ((this._stateFlags & EffectStateFlags.AllSamplers) != EffectStateFlags.None)
      {
        for (int index = 0; index < 16; ++index)
        {
          if ((this._stateFlags & (EffectStateFlags) (8 << index)) != EffectStateFlags.None)
            graphicsDevice.SamplerStates.ClearState(index);
        }
      }
      if ((this._stateFlags & EffectStateFlags.AllVertexSamplers) == EffectStateFlags.None)
        return;
      for (int index = 0; index < 4; ++index)
      {
        if ((this._stateFlags & (EffectStateFlags) (524288 << index)) != EffectStateFlags.None)
          graphicsDevice.VertexSamplerStates.ClearState(index);
      }
    }
  }
}
