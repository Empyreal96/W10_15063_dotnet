// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.ModelMeshPart
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class ModelMeshPart
  {
    internal VertexBuffer vertexBuffer;
    internal IndexBuffer indexBuffer;
    private int startIndex;
    private int primitiveCount;
    private int vertexOffset;
    private int numVertices;
    private Effect effect;
    private object tag;
    internal ModelMesh parent;

    internal ModelMeshPart(
      int vertexOffset,
      int numVertices,
      int startIndex,
      int primitiveCount,
      object tag)
    {
      this.vertexOffset = vertexOffset;
      this.numVertices = numVertices;
      this.startIndex = startIndex;
      this.primitiveCount = primitiveCount;
      this.tag = tag;
    }

    internal void Draw()
    {
      if (this.NumVertices <= 0)
        return;
      GraphicsDevice graphicsDevice = this.vertexBuffer.GraphicsDevice;
      graphicsDevice.SetVertexBuffer(this.vertexBuffer, this.vertexOffset);
      graphicsDevice.Indices = this.indexBuffer;
      graphicsDevice.DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, this.numVertices, this.startIndex, this.primitiveCount);
    }

    public int StartIndex => this.startIndex;

    public int PrimitiveCount => this.primitiveCount;

    public int VertexOffset => this.vertexOffset;

    public int NumVertices => this.numVertices;

    public IndexBuffer IndexBuffer => this.indexBuffer;

    public VertexBuffer VertexBuffer => this.vertexBuffer;

    public Effect Effect
    {
      get => this.effect;
      set
      {
        if (value == this.effect)
          return;
        bool flag1 = false;
        bool flag2 = false;
        int count = this.parent.MeshParts.Count;
        for (int index = 0; index < count; ++index)
        {
          ModelMeshPart meshPart = this.parent.MeshParts[index];
          if (meshPart != this)
          {
            Effect effect = meshPart.Effect;
            if (effect == this.effect)
              flag1 = true;
            else if (effect == value)
              flag2 = true;
          }
        }
        if (!flag1 && this.effect != null)
          this.parent.Effects.Remove(this.effect);
        if (!flag2 && value != null)
          this.parent.Effects.Add(value);
        this.effect = value;
      }
    }

    public object Tag
    {
      get => this.tag;
      set => this.tag = value;
    }
  }
}
