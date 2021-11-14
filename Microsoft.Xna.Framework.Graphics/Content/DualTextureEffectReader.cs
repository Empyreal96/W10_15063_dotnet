// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.DualTextureEffectReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System;

namespace Microsoft.Xna.Framework.Content
{
  internal class DualTextureEffectReader : BuiltInEffectReader<DualTextureEffect>
  {
    protected internal override DualTextureEffect Read(
      ContentReader input,
      DualTextureEffect existingInstance)
    {
      DualTextureEffect clonedEffect = BuiltInEffectReader<DualTextureEffect>.GetClonedEffect(input, (Converter<GraphicsDevice, DualTextureEffect>) (device => new DualTextureEffect(device)));
      clonedEffect.Texture = BuiltInEffectReader<DualTextureEffect>.ReadTexture<Texture2D>(input);
      clonedEffect.Texture2 = BuiltInEffectReader<DualTextureEffect>.ReadTexture<Texture2D>(input);
      clonedEffect.DiffuseColor = input.ReadVector3();
      clonedEffect.Alpha = input.ReadSingle();
      clonedEffect.VertexColorEnabled = input.ReadBoolean();
      return clonedEffect;
    }
  }
}
