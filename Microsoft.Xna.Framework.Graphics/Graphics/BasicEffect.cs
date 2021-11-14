// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.BasicEffect
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

namespace Microsoft.Xna.Framework.Graphics
{
  public class BasicEffect : Effect, IEffectMatrices, IEffectLights, IEffectFog
  {
    private EffectParameter textureParam;
    private EffectParameter diffuseColorParam;
    private EffectParameter emissiveColorParam;
    private EffectParameter specularColorParam;
    private EffectParameter specularPowerParam;
    private EffectParameter eyePositionParam;
    private EffectParameter fogColorParam;
    private EffectParameter fogVectorParam;
    private EffectParameter worldParam;
    private EffectParameter worldInverseTransposeParam;
    private EffectParameter worldViewProjParam;
    private EffectParameter shaderIndexParam;
    private bool lightingEnabled;
    private bool preferPerPixelLighting;
    private bool oneLight;
    private bool fogEnabled;
    private bool textureEnabled;
    private bool vertexColorEnabled;
    private Matrix world = Matrix.Identity;
    private Matrix view = Matrix.Identity;
    private Matrix projection = Matrix.Identity;
    private Matrix worldView;
    private Vector3 diffuseColor = Vector3.One;
    private Vector3 emissiveColor = Vector3.Zero;
    private Vector3 ambientLightColor = Vector3.Zero;
    private float alpha = 1f;
    private DirectionalLight light0;
    private DirectionalLight light1;
    private DirectionalLight light2;
    private float fogStart;
    private float fogEnd = 1f;
    private EffectDirtyFlags dirtyFlags = EffectDirtyFlags.All;

    public Matrix World
    {
      get => this.world;
      set
      {
        this.world = value;
        this.dirtyFlags |= EffectDirtyFlags.WorldViewProj | EffectDirtyFlags.World | EffectDirtyFlags.Fog;
      }
    }

    public Matrix View
    {
      get => this.view;
      set
      {
        this.view = value;
        this.dirtyFlags |= EffectDirtyFlags.WorldViewProj | EffectDirtyFlags.EyePosition | EffectDirtyFlags.Fog;
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

    public Vector3 EmissiveColor
    {
      get => this.emissiveColor;
      set
      {
        this.emissiveColor = value;
        this.dirtyFlags |= EffectDirtyFlags.MaterialColor;
      }
    }

    public Vector3 SpecularColor
    {
      get => this.specularColorParam.GetValueVector3();
      set => this.specularColorParam.SetValue(value);
    }

    public float SpecularPower
    {
      get => this.specularPowerParam.GetValueSingle();
      set => this.specularPowerParam.SetValue(value);
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

    public bool LightingEnabled
    {
      get => this.lightingEnabled;
      set
      {
        if (this.lightingEnabled == value)
          return;
        this.lightingEnabled = value;
        this.dirtyFlags |= EffectDirtyFlags.MaterialColor | EffectDirtyFlags.ShaderIndex;
      }
    }

    public bool PreferPerPixelLighting
    {
      get => this.preferPerPixelLighting;
      set
      {
        if (this.preferPerPixelLighting == value)
          return;
        this.preferPerPixelLighting = value;
        this.dirtyFlags |= EffectDirtyFlags.ShaderIndex;
      }
    }

    public Vector3 AmbientLightColor
    {
      get => this.ambientLightColor;
      set
      {
        this.ambientLightColor = value;
        this.dirtyFlags |= EffectDirtyFlags.MaterialColor;
      }
    }

    public DirectionalLight DirectionalLight0 => this.light0;

    public DirectionalLight DirectionalLight1 => this.light1;

    public DirectionalLight DirectionalLight2 => this.light2;

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

    public bool TextureEnabled
    {
      get => this.textureEnabled;
      set
      {
        if (this.textureEnabled == value)
          return;
        this.textureEnabled = value;
        this.dirtyFlags |= EffectDirtyFlags.ShaderIndex;
      }
    }

    public Texture2D Texture
    {
      get => this.textureParam.GetValueTexture2D();
      set => this.textureParam.SetValue((Microsoft.Xna.Framework.Graphics.Texture) value);
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

    public BasicEffect(GraphicsDevice device)
      : base(device, BasicEffectCode.Code)
    {
      this.CacheEffectParameters((BasicEffect) null);
      this.DirectionalLight0.Enabled = true;
      this.SpecularColor = Vector3.One;
      this.SpecularPower = 16f;
    }

    protected BasicEffect(BasicEffect cloneSource)
      : base((Effect) cloneSource)
    {
      this.CacheEffectParameters(cloneSource);
      this.lightingEnabled = cloneSource.lightingEnabled;
      this.preferPerPixelLighting = cloneSource.preferPerPixelLighting;
      this.fogEnabled = cloneSource.fogEnabled;
      this.textureEnabled = cloneSource.textureEnabled;
      this.vertexColorEnabled = cloneSource.vertexColorEnabled;
      this.world = cloneSource.world;
      this.view = cloneSource.view;
      this.projection = cloneSource.projection;
      this.diffuseColor = cloneSource.diffuseColor;
      this.emissiveColor = cloneSource.emissiveColor;
      this.ambientLightColor = cloneSource.ambientLightColor;
      this.alpha = cloneSource.alpha;
      this.fogStart = cloneSource.fogStart;
      this.fogEnd = cloneSource.fogEnd;
    }

    public override Effect Clone() => (Effect) new BasicEffect(this);

    public void EnableDefaultLighting()
    {
      this.LightingEnabled = true;
      this.AmbientLightColor = EffectHelpers.EnableDefaultLighting(this.light0, this.light1, this.light2);
    }

    private void CacheEffectParameters(BasicEffect cloneSource)
    {
      this.textureParam = this.Parameters["Texture"];
      this.diffuseColorParam = this.Parameters["DiffuseColor"];
      this.emissiveColorParam = this.Parameters["EmissiveColor"];
      this.specularColorParam = this.Parameters["SpecularColor"];
      this.specularPowerParam = this.Parameters["SpecularPower"];
      this.eyePositionParam = this.Parameters["EyePosition"];
      this.fogColorParam = this.Parameters["FogColor"];
      this.fogVectorParam = this.Parameters["FogVector"];
      this.worldParam = this.Parameters["World"];
      this.worldInverseTransposeParam = this.Parameters["WorldInverseTranspose"];
      this.worldViewProjParam = this.Parameters["WorldViewProj"];
      this.shaderIndexParam = this.Parameters["ShaderIndex"];
      this.light0 = new DirectionalLight(this.Parameters["DirLight0Direction"], this.Parameters["DirLight0DiffuseColor"], this.Parameters["DirLight0SpecularColor"], cloneSource?.light0);
      this.light1 = new DirectionalLight(this.Parameters["DirLight1Direction"], this.Parameters["DirLight1DiffuseColor"], this.Parameters["DirLight1SpecularColor"], cloneSource?.light1);
      this.light2 = new DirectionalLight(this.Parameters["DirLight2Direction"], this.Parameters["DirLight2DiffuseColor"], this.Parameters["DirLight2SpecularColor"], cloneSource?.light2);
    }

    internal override bool WantParameter(EffectParameter parameter) => parameter.Name != "VSIndices" && parameter.Name != "PSIndices";

    protected internal override void OnApply()
    {
      this.dirtyFlags = EffectHelpers.SetWorldViewProjAndFog(this.dirtyFlags, ref this.world, ref this.view, ref this.projection, ref this.worldView, this.fogEnabled, this.fogStart, this.fogEnd, this.worldViewProjParam, this.fogVectorParam);
      if ((this.dirtyFlags & EffectDirtyFlags.MaterialColor) != ~EffectDirtyFlags.All)
      {
        EffectHelpers.SetMaterialColor(this.lightingEnabled, this.alpha, ref this.diffuseColor, ref this.emissiveColor, ref this.ambientLightColor, this.diffuseColorParam, this.emissiveColorParam);
        this.dirtyFlags &= ~EffectDirtyFlags.MaterialColor;
      }
      if (this.lightingEnabled)
      {
        this.dirtyFlags = EffectHelpers.SetLightingMatrices(this.dirtyFlags, ref this.world, ref this.view, this.worldParam, this.worldInverseTransposeParam, this.eyePositionParam);
        bool flag = !this.light1.Enabled && !this.light2.Enabled;
        if (this.oneLight != flag)
        {
          this.oneLight = flag;
          this.dirtyFlags |= EffectDirtyFlags.ShaderIndex;
        }
      }
      if ((this.dirtyFlags & EffectDirtyFlags.ShaderIndex) == ~EffectDirtyFlags.All)
        return;
      int num = 0;
      if (!this.fogEnabled)
        ++num;
      if (this.vertexColorEnabled)
        num += 2;
      if (this.textureEnabled)
        num += 4;
      if (this.lightingEnabled)
      {
        if (this.preferPerPixelLighting)
          num += 24;
        else if (this.oneLight)
          num += 16;
        else
          num += 8;
      }
      this.shaderIndexParam.SetValue(num);
      this.dirtyFlags &= ~EffectDirtyFlags.ShaderIndex;
    }
  }
}
