// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.AlphaTestEffect
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

namespace Microsoft.Xna.Framework.Graphics
{
  public class AlphaTestEffect : Effect, IEffectMatrices, IEffectFog
  {
    private EffectParameter textureParam;
    private EffectParameter diffuseColorParam;
    private EffectParameter alphaTestParam;
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
    private CompareFunction alphaFunction = CompareFunction.Greater;
    private int referenceAlpha;
    private bool isEqNe;
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

    public CompareFunction AlphaFunction
    {
      get => this.alphaFunction;
      set
      {
        this.alphaFunction = value;
        this.dirtyFlags |= EffectDirtyFlags.AlphaTest;
      }
    }

    public int ReferenceAlpha
    {
      get => this.referenceAlpha;
      set
      {
        this.referenceAlpha = value;
        this.dirtyFlags |= EffectDirtyFlags.AlphaTest;
      }
    }

    public AlphaTestEffect(GraphicsDevice device)
      : base(device, AlphaTestEffectCode.Code)
    {
      this.CacheEffectParameters();
    }

    protected AlphaTestEffect(AlphaTestEffect cloneSource)
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
      this.alphaFunction = cloneSource.alphaFunction;
      this.referenceAlpha = cloneSource.referenceAlpha;
    }

    public override Effect Clone() => (Effect) new AlphaTestEffect(this);

    private void CacheEffectParameters()
    {
      this.textureParam = this.Parameters["Texture"];
      this.diffuseColorParam = this.Parameters["DiffuseColor"];
      this.alphaTestParam = this.Parameters["AlphaTest"];
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
      if ((this.dirtyFlags & EffectDirtyFlags.AlphaTest) != ~EffectDirtyFlags.All)
      {
        Vector4 vector4 = new Vector4();
        bool flag = false;
        float num = (float) this.referenceAlpha / (float) byte.MaxValue;
        switch (this.alphaFunction)
        {
          case CompareFunction.Never:
            vector4.Z = -1f;
            vector4.W = -1f;
            break;
          case CompareFunction.Less:
            vector4.X = num - 0.001960784f;
            vector4.Z = 1f;
            vector4.W = -1f;
            break;
          case CompareFunction.LessEqual:
            vector4.X = num + 0.001960784f;
            vector4.Z = 1f;
            vector4.W = -1f;
            break;
          case CompareFunction.Equal:
            vector4.X = num;
            vector4.Y = 0.001960784f;
            vector4.Z = 1f;
            vector4.W = -1f;
            flag = true;
            break;
          case CompareFunction.GreaterEqual:
            vector4.X = num - 0.001960784f;
            vector4.Z = -1f;
            vector4.W = 1f;
            break;
          case CompareFunction.Greater:
            vector4.X = num + 0.001960784f;
            vector4.Z = -1f;
            vector4.W = 1f;
            break;
          case CompareFunction.NotEqual:
            vector4.X = num;
            vector4.Y = 0.001960784f;
            vector4.Z = -1f;
            vector4.W = 1f;
            flag = true;
            break;
          default:
            vector4.Z = 1f;
            vector4.W = 1f;
            break;
        }
        this.alphaTestParam.SetValue(vector4);
        this.dirtyFlags &= ~EffectDirtyFlags.AlphaTest;
        if (this.isEqNe != flag)
        {
          this.isEqNe = flag;
          this.dirtyFlags |= EffectDirtyFlags.ShaderIndex;
        }
      }
      if ((this.dirtyFlags & EffectDirtyFlags.ShaderIndex) == ~EffectDirtyFlags.All)
        return;
      int num1 = 0;
      if (!this.fogEnabled)
        ++num1;
      if (this.vertexColorEnabled)
        num1 += 2;
      if (this.isEqNe)
        num1 += 4;
      this.shaderIndexParam.SetValue(num1);
      this.dirtyFlags &= ~EffectDirtyFlags.ShaderIndex;
    }
  }
}
