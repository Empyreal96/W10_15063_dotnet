// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.VertexBufferReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework.Content
{
  internal class VertexBufferReader : ContentTypeReader<VertexBuffer>
  {
    protected internal override VertexBuffer Read(
      ContentReader input,
      VertexBuffer existingInstance)
    {
      VertexDeclaration vertexDeclaration = input.ReadRawObject<VertexDeclaration>();
      int vertexCount = input.ReadInt32();
      int num = vertexCount * vertexDeclaration.VertexStride;
      byte[] data = input.ReadByteBuffer(num);
      VertexBuffer vertexBuffer = new VertexBuffer(GraphicsContentHelper.GraphicsDeviceFromContentReader(input), vertexDeclaration, vertexCount, BufferUsage.None);
      vertexBuffer.SetData<byte>(data, 0, num);
      return vertexBuffer;
    }
  }
}
