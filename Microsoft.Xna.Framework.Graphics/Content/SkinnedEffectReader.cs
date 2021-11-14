// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.SkinnedEffectReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System;

namespace Microsoft.Xna.Framework.Content
{
  internal class SkinnedEffectReader : BuiltInEffectReader<SkinnedEffect>
  {
    protected internal override SkinnedEffect Read(
      ContentReader input,
      SkinnedEffect existingInstance)
    {
      SkinnedEffect clonedEffect = BuiltInEffectReader<SkinnedEffect>.GetClonedEffect(input, (Converter<GraphicsDevice, SkinnedEffect>) (device => new SkinnedEffect(device)));
      clonedEffect.Texture = BuiltInEffectReader<SkinnedEffect>.ReadTexture<Texture2D>(input);
      clonedEffect.WeightsPerVertex = input.ReadInt32();
      clonedEffect.DiffuseColor = input.ReadVector3();
      clonedEffect.EmissiveColor = input.ReadVector3();
      clonedEffect.SpecularColor = input.ReadVector3();
      clonedEffect.SpecularPower = input.ReadSingle();
      clonedEffect.Alpha = input.ReadSingle();
      return clonedEffect;
    }
  }
}
