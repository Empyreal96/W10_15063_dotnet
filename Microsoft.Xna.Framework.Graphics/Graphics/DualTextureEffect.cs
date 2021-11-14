// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.DualTextureEffect
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

namespace Microsoft.Xna.Framework.Graphics
{
  public class DualTextureEffect : Effect, IEffectMatrices, IEffectFog
  {
    private EffectParameter textureParam;
    private EffectParameter texture2Param;
    private EffectParameter diffuseColorParam;
    private EffectParameter fogColorParam;
    private EffectParameter fogVectorParam;
    private EffectParameter worldViewProjParam;
    private EffectParameter shaderIndexParam;
    private bool fogEnabled;
    private bool vertexColorEnabled;
    private Matrix world = Matrix.Identity;
    private Matrix view = Matrix.Identity;
    private Matrix projection = Matrix.Identity;
    private Matrix worldView;
    private Vector3 diffuseColor = Vector3.One;
    private float alpha = 1f;
    private float fogStart;
    private float fogEnd = 1f;
    private EffectDirtyFlags dirtyFlags = EffectDirtyFlags.All;

    public Matrix World
    {
      get => this.world;
      set
      {
        this.world = value;
        this.dirtyFlags |= EffectDirtyFlags.WorldViewProj | EffectDirtyFlags.Fog;
      }
    }

    public Matrix View
    {
      get => this.view;
      set
      {
        this.view = value;
        this.dirtyFlags |= EffectDirtyFlags.WorldViewProj | EffectDirtyFlags.Fog;
      }
    }

    public Matrix Projection
    {
      get => this.projection;
      set
      {
        this.projection = value;
        this.dirtyFlags |= EffectDirtyFlags.WorldViewProj;
      }
    }

    public Vector3 DiffuseColor
    {
      get => this.diffuseColor;
      set
      {
        this.diffuseColor = value;
        this.dirtyFlags |= EffectDirtyFlags.MaterialColor;
      }
    }

    public float Alpha
    {
      get => this.alpha;
      set
      {
        this.alpha = value;
        this.dirtyFlags |= EffectDirtyFlags.MaterialColor;
      }
    }

    public bool FogEnabled
    {
      get => this.fogEnabled;
      set
      {
        if (this.fogEnabled == value)
          return;
        this.fogEnabled = value;
        this.dirtyFlags |= EffectDirtyFlags.FogEnable | EffectDirtyFlags.ShaderIndex;
      }
    }

    public float FogStart
    {
      get => this.fogStart;
      set
      {
        this.fogStart = value;
        this.dirtyFlags |= EffectDirtyFlags.Fog;
      }
    }

    public float FogEnd
    {
      get => this.fogEnd;
      set
      {
        this.fogEnd = value;
        this.dirtyFlags |= EffectDirtyFlags.Fog;
      }
    }

    public Vector3 FogColor
    {
      get => this.fogColorParam.GetValueVector3();
      set => this.fogColorParam.SetValue(value);
    }

    public Texture2D Texture
    {
      get => this.textureParam.GetValueTexture2D();
      set => this.textureParam.SetValue((Microsoft.Xna.Framework.Graphics.Texture) value);
    }

    public Texture2D Texture2
    {
      get => this.texture2Param.GetValueTexture2D();
      set => this.texture2Param.SetValue((Microsoft.Xna.Framework.Graphics.Texture) value);
    }

    public bool VertexColorEnabled
    {
      get => this.vertexColorEnabled;
      set
      {
        if (this.vertexColorEnabled == value)
          return;
        this.vertexColorEnabled = value;
        this.dirtyFlags |= EffectDirtyFlags.ShaderIndex;
      }
    }

    public DualTextureEffect(GraphicsDevice device)
      : base(device, DualTextureEffectCode.Code)
    {
      this.CacheEffectParameters();
    }

    protected DualTextureEffect(DualTextureEffect cloneSource)
      : base((Effect) cloneSource)
    {
      this.CacheEffectParameters();
      this.fogEnabled = cloneSource.fogEnabled;
      this.vertexColorEnabled = cloneSource.vertexColorEnabled;
      this.world = cloneSource.world;
      this.view = cloneSource.view;
      this.projection = cloneSource.projection;
      this.diffuseColor = cloneSource.diffuseColor;
      this.alpha = cloneSource.alpha;
      this.fogStart = cloneSource.fogStart;
      this.fogEnd = cloneSource.fogEnd;
    }

    public override Effect Clone() => (Effect) new DualTextureEffect(this);

    private void CacheEffectParameters()
    {
      this.textureParam = this.Parameters["Texture"];
      this.texture2Param = this.Parameters["Texture2"];
      this.diffuseColorParam = this.Parameters["DiffuseColor"];
      this.fogColorParam = this.Parameters["FogColor"];
      this.fogVectorParam = this.Parameters["FogVector"];
      this.worldViewProjParam = this.Parameters["WorldViewProj"];
      this.shaderIndexParam = this.Parameters["ShaderIndex"];
    }

    internal override bool WantParameter(EffectParameter parameter) => parameter.Name != "VSIndices" && parameter.Name != "PSIndices";

    protected internal override void OnApply()
    {
      this.dirtyFlags = EffectHelpers.SetWorldViewProjAndFog(this.dirtyFlags, ref this.world, ref this.view, ref this.projection, ref this.worldView, this.fogEnabled, this.fogStart, this.fogEnd, this.worldViewProjParam, this.fogVectorParam);
      if ((this.dirtyFlags & EffectDirtyFlags.MaterialColor) != ~EffectDirtyFlags.All)
      {
        this.diffuseColorParam.SetValue(new Vector4(this.diffuseColor * this.alpha, this.alpha));
        this.dirtyFlags &= ~EffectDirtyFlags.MaterialColor;
      }
      if ((this.dirtyFlags & EffectDirtyFlags.ShaderIndex) == ~EffectDirtyFlags.All)
        return;
      int num = 0;
      if (!this.fogEnabled)
        ++num;
      if (this.vertexColorEnabled)
        num += 2;
      this.shaderIndexParam.SetValue(num);
      this.dirtyFlags &= ~EffectDirtyFlags.ShaderIndex;
    }
  }
}
