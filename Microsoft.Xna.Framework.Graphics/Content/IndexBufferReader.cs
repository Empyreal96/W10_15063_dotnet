// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.IndexBufferReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework.Content
{
  internal class IndexBufferReader : ContentTypeReader<IndexBuffer>
  {
    protected internal override IndexBuffer Read(
      ContentReader input,
      IndexBuffer existingInstance)
    {
      int num1 = input.ReadBoolean() ? 1 : 0;
      int num2 = input.ReadInt32();
      byte[] data = input.ReadByteBuffer(num2);
      IndexElementSize indexElementSize;
      int indexCount;
      if (num1 != 0)
      {
        indexElementSize = IndexElementSize.SixteenBits;
        indexCount = num2 / 2;
      }
      else
      {
        indexElementSize = IndexElementSize.ThirtyTwoBits;
        indexCount = num2 / 4;
      }
      IndexBuffer indexBuffer = new IndexBuffer(GraphicsContentHelper.GraphicsDeviceFromContentReader(input), indexElementSize, indexCount, BufferUsage.None);
      indexBuffer.SetData<byte>(data, 0, num2);
      return indexBuffer;
    }
  }
}
