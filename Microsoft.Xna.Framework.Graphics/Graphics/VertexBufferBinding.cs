// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.VertexBufferBinding
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  public struct VertexBufferBinding
  {
    internal VertexBuffer _vertexBuffer;
    internal int _vertexOffset;
    internal int _instanceFrequency;

    public VertexBufferBinding(VertexBuffer vertexBuffer)
    {
      this._vertexBuffer = vertexBuffer != null ? vertexBuffer : throw new ArgumentNullException(nameof (vertexBuffer), FrameworkResources.NullNotAllowed);
      this._vertexOffset = 0;
      this._instanceFrequency = 0;
    }

    public VertexBufferBinding(VertexBuffer vertexBuffer, int vertexOffset)
    {
      if (vertexBuffer == null)
        throw new ArgumentNullException(nameof (vertexBuffer), FrameworkResources.NullNotAllowed);
      if (vertexOffset < 0 || vertexOffset >= vertexBuffer._vertexCount)
        throw new ArgumentOutOfRangeException(nameof (vertexOffset));
      this._vertexBuffer = vertexBuffer;
      this._vertexOffset = vertexOffset;
      this._instanceFrequency = 0;
    }

    public VertexBufferBinding(VertexBuffer vertexBuffer, int vertexOffset, int instanceFrequency)
    {
      if (vertexBuffer == null)
        throw new ArgumentNullException(nameof (vertexBuffer), FrameworkResources.NullNotAllowed);
      if (vertexOffset < 0 || vertexOffset >= vertexBuffer._vertexCount)
        throw new ArgumentOutOfRangeException(nameof (vertexOffset));
      if (instanceFrequency < 0)
        throw new ArgumentOutOfRangeException(nameof (instanceFrequency));
      this._vertexBuffer = vertexBuffer;
      this._vertexOffset = vertexOffset;
      this._instanceFrequency = instanceFrequency;
    }

    public static implicit operator VertexBufferBinding(VertexBuffer vertexBuffer) => new VertexBufferBinding(vertexBuffer);

    public VertexBuffer VertexBuffer => this._vertexBuffer;

    public int VertexOffset => this._vertexOffset;

    public int InstanceFrequency => this._instanceFrequency;
  }
}
