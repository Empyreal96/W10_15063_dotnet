// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.VertexElement
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics
{
  public struct VertexElement
  {
    internal int _offset;
    internal VertexElementFormat _format;
    internal VertexElementUsage _usage;
    internal int _usageIndex;

    public int Offset
    {
      get => this._offset;
      set => this._offset = value;
    }

    public VertexElementFormat VertexElementFormat
    {
      get => this._format;
      set => this._format = value;
    }

    public VertexElementUsage VertexElementUsage
    {
      get => this._usage;
      set => this._usage = value;
    }

    public int UsageIndex
    {
      get => this._usageIndex;
      set => this._usageIndex = value;
    }

    public VertexElement(
      int offset,
      VertexElementFormat elementFormat,
      VertexElementUsage elementUsage,
      int usageIndex)
    {
      this._offset = offset;
      this._usageIndex = usageIndex;
      this._format = elementFormat;
      this._usage = elementUsage;
    }

    public override int GetHashCode() => Helpers.SmartGetHashCode((object) this);

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Offset:{0} Format:{1} Usage:{2} UsageIndex:{3}}}", (object) this.Offset, (object) this.VertexElementFormat, (object) this.VertexElementUsage, (object) this.UsageIndex);

    public override bool Equals(object obj) => obj != null && obj.GetType() == this.GetType() && this == (VertexElement) obj;

    public static bool operator ==(VertexElement left, VertexElement right) => left._offset == right._offset && left._usageIndex == right._usageIndex && left._usage == right._usage && left._format == right._format;

    public static bool operator !=(VertexElement left, VertexElement right) => !(left == right);
  }
}
