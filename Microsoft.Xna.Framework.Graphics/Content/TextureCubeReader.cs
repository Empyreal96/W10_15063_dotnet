// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.TextureCubeReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework.Content
{
  internal class TextureCubeReader : ContentTypeReader<TextureCube>
  {
    protected internal override TextureCube Read(
      ContentReader input,
      TextureCube existingInstance)
    {
      SurfaceFormat format = (SurfaceFormat) input.ReadInt32();
      int size = input.ReadInt32();
      int num1 = input.ReadInt32();
      TextureCube textureCube = new TextureCube(GraphicsContentHelper.GraphicsDeviceFromContentReader(input), size, num1 > 1, format);
      for (CubeMapFace cubeMapFace = CubeMapFace.PositiveX; cubeMapFace < (CubeMapFace.PositiveY | CubeMapFace.PositiveZ); ++cubeMapFace)
      {
        for (int level = 0; level < num1; ++level)
        {
          int num2 = input.ReadInt32();
          byte[] data = input.ReadByteBuffer(num2);
          textureCube.SetData<byte>(cubeMapFace, level, new Rectangle?(), data, 0, num2);
        }
      }
      return textureCube;
    }
  }
}
