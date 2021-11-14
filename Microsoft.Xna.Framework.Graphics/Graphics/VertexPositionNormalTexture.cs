// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.VertexPositionNormalTexture
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics
{
  public struct VertexPositionNormalTexture : IVertexType
  {
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public Vector3 Position;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public Vector3 Normal;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public Vector2 TextureCoordinate;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly VertexDeclaration VertexDeclaration;

    public VertexPositionNormalTexture(Vector3 position, Vector3 normal, Vector2 textureCoordinate)
    {
      this.Position = position;
      this.Normal = normal;
      this.TextureCoordinate = textureCoordinate;
    }

    VertexDeclaration IVertexType.VertexDeclaration => VertexPositionNormalTexture.VertexDeclaration;

    public override int GetHashCode() => Helpers.SmartGetHashCode((object) this);

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Position:{0} Normal:{1} TextureCoordinate:{2}}}", (object) this.Position, (object) this.Normal, (object) this.TextureCoordinate);

    public static bool operator ==(
      VertexPositionNormalTexture left,
      VertexPositionNormalTexture right)
    {
      return left.Position == right.Position && left.Normal == right.Normal && left.TextureCoordinate == right.TextureCoordinate;
    }

    public static bool operator !=(
      VertexPositionNormalTexture left,
      VertexPositionNormalTexture right)
    {
      return !(left == right);
    }

    public override bool Equals(object obj) => obj != null && obj.GetType() == this.GetType() && this == (VertexPositionNormalTexture) obj;

    static VertexPositionNormalTexture()
    {
      VertexDeclaration vertexDeclaration = new VertexDeclaration(new VertexElement[3]
      {
        new VertexElement(0, VertexElementFormat.Vector3, VertexElementUsage.Position, 0),
        new VertexElement(12, VertexElementFormat.Vector3, VertexElementUsage.Normal, 0),
        new VertexElement(24, VertexElementFormat.Vector2, VertexElementUsage.TextureCoordinate, 0)
      });
      vertexDeclaration.Name = "VertexPositionNormalTexture.VertexDeclaration";
      VertexPositionNormalTexture.VertexDeclaration = vertexDeclaration;
    }
  }
}
