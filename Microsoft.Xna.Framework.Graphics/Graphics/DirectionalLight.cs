// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.DirectionalLight
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class DirectionalLight
  {
    private EffectParameter directionParam;
    private EffectParameter diffuseColorParam;
    private EffectParameter specularColorParam;
    private bool enabled;
    private Vector3 cachedDirection;
    private Vector3 cachedDiffuseColor;
    private Vector3 cachedSpecularColor;

    public bool Enabled
    {
      get => this.enabled;
      set
      {
        if (this.enabled == value)
          return;
        this.enabled = value;
        if (this.enabled)
        {
          if (this.diffuseColorParam != null)
            this.diffuseColorParam.SetValue(this.cachedDiffuseColor);
          if (this.specularColorParam == null)
            return;
          this.specularColorParam.SetValue(this.cachedSpecularColor);
        }
        else
        {
          if (this.diffuseColorParam != null)
            this.diffuseColorParam.SetValue(Vector3.Zero);
          if (this.specularColorParam == null)
            return;
          this.specularColorParam.SetValue(Vector3.Zero);
        }
      }
    }

    public Vector3 Direction
    {
      get => this.cachedDirection;
      set
      {
        if (this.directionParam != null)
          this.directionParam.SetValue(value);
        this.cachedDirection = value;
      }
    }

    public Vector3 DiffuseColor
    {
      get => this.cachedDiffuseColor;
      set
      {
        if (this.enabled && this.diffuseColorParam != null)
          this.diffuseColorParam.SetValue(value);
        this.cachedDiffuseColor = value;
      }
    }

    public Vector3 SpecularColor
    {
      get => this.cachedSpecularColor;
      set
      {
        if (this.enabled && this.specularColorParam != null)
          this.specularColorParam.SetValue(value);
        this.cachedSpecularColor = value;
      }
    }

    public DirectionalLight(
      EffectParameter directionParameter,
      EffectParameter diffuseColorParameter,
      EffectParameter specularColorParameter,
      DirectionalLight cloneSource)
    {
      this.directionParam = directionParameter;
      this.diffuseColorParam = diffuseColorParameter;
      this.specularColorParam = specularColorParameter;
      if (cloneSource != null)
      {
        this.enabled = cloneSource.enabled;
        this.cachedDirection = cloneSource.cachedDirection;
        this.cachedDiffuseColor = cloneSource.cachedDiffuseColor;
        this.cachedSpecularColor = cloneSource.cachedSpecularColor;
      }
      else
      {
        this.Direction = Vector3.Down;
        this.DiffuseColor = Vector3.One;
        this.SpecularColor = Vector3.Zero;
      }
    }
  }
}
