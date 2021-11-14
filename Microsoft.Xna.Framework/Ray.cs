// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Ray
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
  public struct Ray : IEquatable<Ray>
  {
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public Vector3 Position;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public Vector3 Direction;

    public Ray(Vector3 position, Vector3 direction)
    {
      this.Position = position;
      this.Direction = direction;
    }

    public bool Equals(Ray other) => (double) this.Position.X == (double) other.Position.X && (double) this.Position.Y == (double) other.Position.Y && ((double) this.Position.Z == (double) other.Position.Z && (double) this.Direction.X == (double) other.Direction.X) && (double) this.Direction.Y == (double) other.Direction.Y && (double) this.Direction.Z == (double) other.Direction.Z;

    public override bool Equals(object obj)
    {
      bool flag = false;
      if (obj != null && obj is Ray other)
        flag = this.Equals(other);
      return flag;
    }

    public override int GetHashCode() => this.Position.GetHashCode() + this.Direction.GetHashCode();

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Position:{0} Direction:{1}}}", (object) this.Position.ToString(), (object) this.Direction.ToString());

    public float? Intersects(BoundingBox box) => box.Intersects(this);

    public void Intersects(ref BoundingBox box, out float? result) => box.Intersects(ref this, out result);

    public float? Intersects(BoundingFrustum frustum) => !(frustum == (BoundingFrustum) null) ? frustum.Intersects(this) : throw new ArgumentNullException(nameof (frustum));

    public float? Intersects(Plane plane)
    {
      float num1 = (float) ((double) plane.Normal.X * (double) this.Direction.X + (double) plane.Normal.Y * (double) this.Direction.Y + (double) plane.Normal.Z * (double) this.Direction.Z);
      if ((double) Math.Abs(num1) < 9.99999974737875E-06)
        return new float?();
      float num2 = (float) ((double) plane.Normal.X * (double) this.Position.X + (double) plane.Normal.Y * (double) this.Position.Y + (double) plane.Normal.Z * (double) this.Position.Z);
      float num3 = (-plane.D - num2) / num1;
      if ((double) num3 < 0.0)
      {
        if ((double) num3 < -9.99999974737875E-06)
          return new float?();
        num3 = 0.0f;
      }
      return new float?(num3);
    }

    public void Intersects(ref Plane plane, out float? result)
    {
      float num1 = (float) ((double) plane.Normal.X * (double) this.Direction.X + (double) plane.Normal.Y * (double) this.Direction.Y + (double) plane.Normal.Z * (double) this.Direction.Z);
      if ((double) Math.Abs(num1) < 9.99999974737875E-06)
      {
        result = new float?();
      }
      else
      {
        float num2 = (float) ((double) plane.Normal.X * (double) this.Position.X + (double) plane.Normal.Y * (double) this.Position.Y + (double) plane.Normal.Z * (double) this.Position.Z);
        float num3 = (-plane.D - num2) / num1;
        if ((double) num3 < 0.0)
        {
          if ((double) num3 < -9.99999974737875E-06)
          {
            result = new float?();
            return;
          }
          result = new float?(0.0f);
        }
        result = new float?(num3);
      }
    }

    public float? Intersects(BoundingSphere sphere)
    {
      float num1 = sphere.Center.X - this.Position.X;
      float num2 = sphere.Center.Y - this.Position.Y;
      float num3 = sphere.Center.Z - this.Position.Z;
      double num4 = (double) num1;
      double num5 = num4 * num4;
      double num6 = (double) num2;
      double num7 = num6 * num6;
      double num8 = num5 + num7;
      double num9 = (double) num3;
      double num10 = num9 * num9;
      float num11 = (float) (num8 + num10);
      float num12 = sphere.Radius * sphere.Radius;
      if ((double) num11 <= (double) num12)
        return new float?(0.0f);
      float num13 = (float) ((double) num1 * (double) this.Direction.X + (double) num2 * (double) this.Direction.Y + (double) num3 * (double) this.Direction.Z);
      if ((double) num13 < 0.0)
        return new float?();
      double num14 = (double) num11;
      double num15 = (double) num13;
      double num16 = num15 * num15;
      float num17 = (float) (num14 - num16);
      if ((double) num17 > (double) num12)
        return new float?();
      float num18 = (float) Math.Sqrt((double) num12 - (double) num17);
      return new float?(num13 - num18);
    }

    public void Intersects(ref BoundingSphere sphere, out float? result)
    {
      float num1 = sphere.Center.X - this.Position.X;
      float num2 = sphere.Center.Y - this.Position.Y;
      float num3 = sphere.Center.Z - this.Position.Z;
      double num4 = (double) num1;
      double num5 = num4 * num4;
      double num6 = (double) num2;
      double num7 = num6 * num6;
      double num8 = num5 + num7;
      double num9 = (double) num3;
      double num10 = num9 * num9;
      float num11 = (float) (num8 + num10);
      float num12 = sphere.Radius * sphere.Radius;
      if ((double) num11 <= (double) num12)
      {
        result = new float?(0.0f);
      }
      else
      {
        result = new float?();
        float num13 = (float) ((double) num1 * (double) this.Direction.X + (double) num2 * (double) this.Direction.Y + (double) num3 * (double) this.Direction.Z);
        if ((double) num13 < 0.0)
          return;
        double num14 = (double) num11;
        double num15 = (double) num13;
        double num16 = num15 * num15;
        float num17 = (float) (num14 - num16);
        if ((double) num17 > (double) num12)
          return;
        float num18 = (float) Math.Sqrt((double) num12 - (double) num17);
        result = new float?(num13 - num18);
      }
    }

    public static bool operator ==(Ray a, Ray b) => (double) a.Position.X == (double) b.Position.X && (double) a.Position.Y == (double) b.Position.Y && ((double) a.Position.Z == (double) b.Position.Z && (double) a.Direction.X == (double) b.Direction.X) && (double) a.Direction.Y == (double) b.Direction.Y && (double) a.Direction.Z == (double) b.Direction.Z;

    public static bool operator !=(Ray a, Ray b) => (double) a.Position.X != (double) b.Position.X || (double) a.Position.Y != (double) b.Position.Y || ((double) a.Position.Z != (double) b.Position.Z || (double) a.Direction.X != (double) b.Direction.X) || (double) a.Direction.Y != (double) b.Direction.Y || (double) a.Direction.Z != (double) b.Direction.Z;
  }
}
