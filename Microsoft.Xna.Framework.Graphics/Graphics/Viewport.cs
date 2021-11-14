// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.Viewport
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics
{
  [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes")]
  public struct Viewport
  {
    private int _x;
    private int _y;
    private int _width;
    private int _height;
    private float _minZ;
    private float _maxZ;

    public int X
    {
      get => this._x;
      set => this._x = value;
    }

    public int Y
    {
      get => this._y;
      set => this._y = value;
    }

    public int Width
    {
      get => this._width;
      set => this._width = value;
    }

    public int Height
    {
      get => this._height;
      set => this._height = value;
    }

    public float MinDepth
    {
      get => this._minZ;
      set => this._minZ = value;
    }

    public float MaxDepth
    {
      get => this._maxZ;
      set => this._maxZ = value;
    }

    public Viewport(int x, int y, int width, int height)
    {
      this._x = x;
      this._y = y;
      this._width = width;
      this._height = height;
      this._minZ = 0.0f;
      this._maxZ = 1f;
    }

    public Viewport(Rectangle bounds)
    {
      this._x = bounds.X;
      this._y = bounds.Y;
      this._width = bounds.Width;
      this._height = bounds.Height;
      this._minZ = 0.0f;
      this._maxZ = 1f;
    }

    public Rectangle Bounds
    {
      get
      {
        Rectangle rectangle;
        rectangle.X = this._x;
        rectangle.Y = this._y;
        rectangle.Width = this._width;
        rectangle.Height = this._height;
        return rectangle;
      }
      set
      {
        this._x = value.X;
        this._y = value.Y;
        this._width = value.Width;
        this._height = value.Height;
      }
    }

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{X:{0} Y:{1} Width:{2} Height:{3} MinDepth:{4} MaxDepth:{5}}}", (object) this.X, (object) this.Y, (object) this.Width, (object) this.Height, (object) this.MinDepth, (object) this.MaxDepth);

    private static bool WithinEpsilon(float a, float b)
    {
      float num = a - b;
      return -1.40129846432482E-45 <= (double) num && (double) num <= 1.40129846432482E-45;
    }

    public Vector3 Project(Vector3 source, Matrix projection, Matrix view, Matrix world)
    {
      Matrix matrix = Matrix.Multiply(Matrix.Multiply(world, view), projection);
      Vector3 vector3 = Vector3.Transform(source, matrix);
      float a = (float) ((double) source.X * (double) matrix.M14 + (double) source.Y * (double) matrix.M24 + (double) source.Z * (double) matrix.M34) + matrix.M44;
      if (!Viewport.WithinEpsilon(a, 1f))
        vector3 /= a;
      ref Vector3 local1 = ref vector3;
      local1.X = (float) (((double) local1.X + 1.0) * 0.5) * (float) this.Width + (float) this.X;
      ref Vector3 local2 = ref vector3;
      local2.Y = (float) ((-(double) local2.Y + 1.0) * 0.5) * (float) this.Height + (float) this.Y;
      ref Vector3 local3 = ref vector3;
      local3.Z = local3.Z * (this.MaxDepth - this.MinDepth) + this.MinDepth;
      return vector3;
    }

    public Vector3 Unproject(Vector3 source, Matrix projection, Matrix view, Matrix world)
    {
      Matrix matrix = Matrix.Invert(Matrix.Multiply(Matrix.Multiply(world, view), projection));
      ref Vector3 local1 = ref source;
      local1.X = (float) (((double) local1.X - (double) this.X) / (double) this.Width * 2.0 - 1.0);
      ref Vector3 local2 = ref source;
      local2.Y = (float) -(((double) local2.Y - (double) this.Y) / (double) this.Height * 2.0 - 1.0);
      ref Vector3 local3 = ref source;
      local3.Z = (float) (((double) local3.Z - (double) this.MinDepth) / ((double) this.MaxDepth - (double) this.MinDepth));
      Vector3 vector3 = Vector3.Transform(source, matrix);
      float a = (float) ((double) source.X * (double) matrix.M14 + (double) source.Y * (double) matrix.M24 + (double) source.Z * (double) matrix.M34) + matrix.M44;
      if (!Viewport.WithinEpsilon(a, 1f))
        vector3 /= a;
      return vector3;
    }

    public float AspectRatio => this._height == 0 || this._width == 0 ? 0.0f : (float) this._width / (float) this._height;

    public Rectangle TitleSafeArea => Viewport.GetTitleSafeArea(this._x, this._y, this._width, this._height);

    internal static Rectangle GetTitleSafeArea(int x, int y, int w, int h) => new Rectangle(x, y, w, h);
  }
}
