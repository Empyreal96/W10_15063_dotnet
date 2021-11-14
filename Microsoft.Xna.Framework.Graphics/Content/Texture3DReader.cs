// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.Texture3DReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System;

namespace Microsoft.Xna.Framework.Content
{
  internal class Texture3DReader : ContentTypeReader<Texture3D>
  {
    protected internal override Texture3D Read(
      ContentReader input,
      Texture3D existingInstance)
    {
      SurfaceFormat format = (SurfaceFormat) input.ReadInt32();
      int num1 = input.ReadInt32();
      int num2 = input.ReadInt32();
      int num3 = input.ReadInt32();
      int num4 = input.ReadInt32();
      Texture3D texture3D = new Texture3D(GraphicsContentHelper.GraphicsDeviceFromContentReader(input), num1, num2, num3, num4 > 1, format);
      for (int level = 0; level < num4; ++level)
      {
        int num5 = input.ReadInt32();
        byte[] data = input.ReadByteBuffer(num5);
        texture3D.SetData<byte>(level, 0, 0, num1, num2, 0, num3, data, 0, num5);
        num1 = Math.Max(num1 >> 1, 1);
        num2 = Math.Max(num2 >> 1, 1);
        num3 = Math.Max(num3 >> 1, 1);
      }
      return texture3D;
    }
  }
}
