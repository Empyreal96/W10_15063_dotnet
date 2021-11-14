﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.EffectReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework.Content
{
  internal class EffectReader : ContentTypeReader<Effect>
  {
    protected internal override Effect Read(ContentReader input, Effect existingInstance)
    {
      int count = input.ReadInt32();
      byte[] effectCode = input.ReadBytes(count);
      return new Effect(GraphicsContentHelper.GraphicsDeviceFromContentReader(input), effectCode);
    }
  }
}
