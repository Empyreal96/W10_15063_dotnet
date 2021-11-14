// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.VertexDeclarationReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework.Content
{
  internal class VertexDeclarationReader : ContentTypeReader<VertexDeclaration>
  {
    protected internal override VertexDeclaration Read(
      ContentReader input,
      VertexDeclaration existingInstance)
    {
      int vertexStride = input.ReadInt32();
      int length = input.ReadInt32();
      VertexElement[] vertexElementArray = new VertexElement[length];
      for (int index = 0; index < length; ++index)
      {
        int offset = input.ReadInt32();
        VertexElementFormat elementFormat = (VertexElementFormat) input.ReadInt32();
        VertexElementUsage elementUsage = (VertexElementUsage) input.ReadInt32();
        int usageIndex = input.ReadInt32();
        vertexElementArray[index] = new VertexElement(offset, elementFormat, elementUsage, usageIndex);
      }
      return new VertexDeclaration(vertexStride, vertexElementArray);
    }
  }
}
