// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.VertexPositionColor
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics
{
  public struct VertexPositionColor : IVertexType
  {
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public Vector3 Position;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public Color Color;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly VertexDeclaration VertexDeclaration;

    public VertexPositionColor(Vector3 position, Color color)
    {
      this.Position = position;
      this.Color = color;
    }

    VertexDeclaration IVertexType.VertexDeclaration => VertexPositionColor.VertexDeclaration;

    public override int GetHashCode() => Helpers.SmartGetHashCode((object) this);

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Position:{0} Color:{1}}}", (object) this.Position, (object) this.Color);

    public static bool operator ==(VertexPositionColor left, VertexPositionColor right) => left.Color == right.Color && left.Position == right.Position;

    public static bool operator !=(VertexPositionColor left, VertexPositionColor right) => !(left == right);

    public override bool Equals(object obj) => obj != null && obj.GetType() == this.GetType() && this == (VertexPositionColor) obj;

    static VertexPositionColor()
    {
      VertexDeclaration vertexDeclaration = new VertexDeclaration(new VertexElement[2]
      {
        new VertexElement(0, VertexElementFormat.Vector3, VertexElementUsage.Position, 0),
        new VertexElement(12, VertexElementFormat.Color, VertexElementUsage.Color, 0)
      });
      vertexDeclaration.Name = "VertexPositionColor.VertexDeclaration";
      VertexPositionColor.VertexDeclaration = vertexDeclaration;
    }
  }
}
