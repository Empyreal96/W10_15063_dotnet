// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.AlphaTestEffectReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System;

namespace Microsoft.Xna.Framework.Content
{
  internal class AlphaTestEffectReader : BuiltInEffectReader<AlphaTestEffect>
  {
    protected internal override AlphaTestEffect Read(
      ContentReader input,
      AlphaTestEffect existingInstance)
    {
      AlphaTestEffect clonedEffect = BuiltInEffectReader<AlphaTestEffect>.GetClonedEffect(input, (Converter<GraphicsDevice, AlphaTestEffect>) (device => new AlphaTestEffect(device)));
      clonedEffect.Texture = BuiltInEffectReader<AlphaTestEffect>.ReadTexture<Texture2D>(input);
      clonedEffect.AlphaFunction = (CompareFunction) input.ReadInt32();
      clonedEffect.ReferenceAlpha = input.ReadInt32();
      clonedEffect.DiffuseColor = input.ReadVector3();
      clonedEffect.Alpha = input.ReadSingle();
      clonedEffect.VertexColorEnabled = input.ReadBoolean();
      return clonedEffect;
    }
  }
}
