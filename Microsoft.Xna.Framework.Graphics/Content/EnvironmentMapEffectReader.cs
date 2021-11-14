// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.EnvironmentMapEffectReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System;

namespace Microsoft.Xna.Framework.Content
{
  internal class EnvironmentMapEffectReader : BuiltInEffectReader<EnvironmentMapEffect>
  {
    protected internal override EnvironmentMapEffect Read(
      ContentReader input,
      EnvironmentMapEffect existingInstance)
    {
      EnvironmentMapEffect clonedEffect = BuiltInEffectReader<EnvironmentMapEffect>.GetClonedEffect(input, (Converter<GraphicsDevice, EnvironmentMapEffect>) (device => new EnvironmentMapEffect(device)));
      clonedEffect.Texture = BuiltInEffectReader<EnvironmentMapEffect>.ReadTexture<Texture2D>(input);
      clonedEffect.EnvironmentMap = BuiltInEffectReader<EnvironmentMapEffect>.ReadTexture<TextureCube>(input);
      clonedEffect.EnvironmentMapAmount = input.ReadSingle();
      clonedEffect.EnvironmentMapSpecular = input.ReadVector3();
      clonedEffect.FresnelFactor = input.ReadSingle();
      clonedEffect.DiffuseColor = input.ReadVector3();
      clonedEffect.EmissiveColor = input.ReadVector3();
      clonedEffect.Alpha = input.ReadSingle();
      return clonedEffect;
    }
  }
}
