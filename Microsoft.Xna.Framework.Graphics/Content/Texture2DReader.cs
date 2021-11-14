// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.Texture2DReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework.Content
{
  internal class Texture2DReader : ContentTypeReader<Texture2D>
  {
    protected internal override Texture2D Read(
      ContentReader input,
      Texture2D existingInstance)
    {
      SurfaceFormat format = (SurfaceFormat) input.ReadInt32();
      int width = input.ReadInt32();
      int height = input.ReadInt32();
      int num1 = input.ReadInt32();
      Texture2D texture2D = new Texture2D(GraphicsContentHelper.GraphicsDeviceFromContentReader(input), width, height, num1 > 1, format);
      for (int level = 0; level < num1; ++level)
      {
        int num2 = input.ReadInt32();
        byte[] data = input.ReadByteBuffer(num2);
        texture2D.SetData<byte>(level, new Rectangle?(), data, 0, num2);
      }
      return texture2D;
    }
  }
}
