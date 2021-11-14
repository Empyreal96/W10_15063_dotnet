// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Plane
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
  public struct Plane : IEquatable<Plane>
  {
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public Vector3 Normal;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float D;

    public Plane(float a, float b, float c, float d)
    {
      this.Normal.X = a;
      this.Normal.Y = b;
      this.Normal.Z = c;
      this.D = d;
    }

    public Plane(Vector3 normal, float d)
    {
      this.Normal = normal;
      this.D = d;
    }

    public Plane(Vector4 value)
    {
      this.Normal.X = value.X;
      this.Normal.Y = value.Y;
      this.Normal.Z = value.Z;
      this.D = value.W;
    }

    public Plane(Vector3 point1, Vector3 point2, Vector3 point3)
    {
      float num1 = point2.X - point1.X;
      float num2 = point2.Y - point1.Y;
      float num3 = point2.Z - point1.Z;
      float num4 = point3.X - point1.X;
      float num5 = point3.Y - point1.Y;
      float num6 = point3.Z - point1.Z;
      float num7 = (float) ((double) num2 * (double) num6 - (double) num3 * (double) num5);
      float num8 = (float) ((double) num3 * (double) num4 - (double) num1 * (double) num6);
      float num9 = (float) ((double) num1 * (double) num5 - (double) num2 * (double) num4);
      double num10 = (double) num7;
      double num11 = num10 * num10;
      double num12 = (double) num8;
      double num13 = num12 * num12;
      double num14 = num11 + num13;
      double num15 = (double) num9;
      double num16 = num15 * num15;
      float num17 = 1f / (float) Math.Sqrt(num14 + num16);
      this.Normal.X = num7 * num17;
      this.Normal.Y = num8 * num17;
      this.Normal.Z = num9 * num17;
      this.D = (float) -((double) this.Normal.X * (double) point1.X + (double) this.Normal.Y * (double) point1.Y + (double) this.Normal.Z * (double) point1.Z);
    }

    public bool Equals(Plane other) => (double) this.Normal.X == (double) other.Normal.X && (double) this.Normal.Y == (double) other.Normal.Y && (double) this.Normal.Z == (double) other.Normal.Z && (double) this.D == (double) other.D;

    public override bool Equals(object obj)
    {
      bool flag = false;
      if (obj is Plane other)
        flag = this.Equals(other);
      return flag;
    }

    public override int GetHashCode() => this.Normal.GetHashCode() + this.D.GetHashCode();

    public override string ToString()
    {
      CultureInfo currentCulture = CultureInfo.CurrentCulture;
      return string.Format((IFormatProvider) currentCulture, "{{Normal:{0} D:{1}}}", (object) this.Normal.ToString(), (object) this.D.ToString((IFormatProvider) currentCulture));
    }

    public void Normalize()
    {
      float num1 = (float) ((double) this.Normal.X * (double) this.Normal.X + (double) this.Normal.Y * (double) this.Normal.Y + (double) this.Normal.Z * (double) this.Normal.Z);
      if ((double) Math.Abs(num1 - 1f) < 1.19209289550781E-07)
        return;
      float num2 = 1f / (float) Math.Sqrt((double) num1);
      this.Normal.X *= num2;
      this.Normal.Y *= num2;
      this.Normal.Z *= num2;
      this.D *= num2;
    }

    public static Plane Normalize(Plane value)
    {
      float num1 = (float) ((double) value.Normal.X * (double) value.Normal.X + (double) value.Normal.Y * (double) value.Normal.Y + (double) value.Normal.Z * (double) value.Normal.Z);
      if ((double) Math.Abs(num1 - 1f) < 1.19209289550781E-07)
      {
        Plane plane;
        plane.Normal = value.Normal;
        plane.D = value.D;
        return plane;
      }
      float num2 = 1f / (float) Math.Sqrt((double) num1);
      Plane plane1;
      plane1.Normal.X = value.Normal.X * num2;
      plane1.Normal.Y = value.Normal.Y * num2;
      plane1.Normal.Z = value.Normal.Z * num2;
      plane1.D = value.D * num2;
      return plane1;
    }

    public static void Normalize(ref Plane value, out Plane result)
    {
      float num1 = (float) ((double) value.Normal.X * (double) value.Normal.X + (double) value.Normal.Y * (double) value.Normal.Y + (double) value.Normal.Z * (double) value.Normal.Z);
      if ((double) Math.Abs(num1 - 1f) < 1.19209289550781E-07)
      {
        result.Normal = value.Normal;
        result.D = value.D;
      }
      else
      {
        float num2 = 1f / (float) Math.Sqrt((double) num1);
        result.Normal.X = value.Normal.X * num2;
        result.Normal.Y = value.Normal.Y * num2;
        result.Normal.Z = value.Normal.Z * num2;
        result.D = value.D * num2;
      }
    }

    public static Plane Transform(Plane plane, Matrix matrix)
    {
      Matrix result;
      Matrix.Invert(ref matrix, out result);
      float x = plane.Normal.X;
      float y = plane.Normal.Y;
      float z = plane.Normal.Z;
      float d = plane.D;
      Plane plane1;
      plane1.Normal.X = (float) ((double) x * (double) result.M11 + (double) y * (double) result.M12 + (double) z * (double) result.M13 + (double) d * (double) result.M14);
      plane1.Normal.Y = (float) ((double) x * (double) result.M21 + (double) y * (double) result.M22 + (double) z * (double) result.M23 + (double) d * (double) result.M24);
      plane1.Normal.Z = (float) ((double) x * (double) result.M31 + (double) y * (double) result.M32 + (double) z * (double) result.M33 + (double) d * (double) result.M34);
      plane1.D = (float) ((double) x * (double) result.M41 + (double) y * (double) result.M42 + (double) z * (double) result.M43 + (double) d * (double) result.M44);
      return plane1;
    }

    public static void Transform(ref Plane plane, ref Matrix matrix, out Plane result)
    {
      Matrix result1;
      Matrix.Invert(ref matrix, out result1);
      float x = plane.Normal.X;
      float y = plane.Normal.Y;
      float z = plane.Normal.Z;
      float d = plane.D;
      result.Normal.X = (float) ((double) x * (double) result1.M11 + (double) y * (double) result1.M12 + (double) z * (double) result1.M13 + (double) d * (double) result1.M14);
      result.Normal.Y = (float) ((double) x * (double) result1.M21 + (double) y * (double) result1.M22 + (double) z * (double) result1.M23 + (double) d * (double) result1.M24);
      result.Normal.Z = (float) ((double) x * (double) result1.M31 + (double) y * (double) result1.M32 + (double) z * (double) result1.M33 + (double) d * (double) result1.M34);
      result.D = (float) ((double) x * (double) result1.M41 + (double) y * (double) result1.M42 + (double) z * (double) result1.M43 + (double) d * (double) result1.M44);
    }

    public static Plane Transform(Plane plane, Quaternion rotation)
    {
      float num1 = rotation.X + rotation.X;
      float num2 = rotation.Y + rotation.Y;
      float num3 = rotation.Z + rotation.Z;
      float num4 = rotation.W * num1;
      float num5 = rotation.W * num2;
      float num6 = rotation.W * num3;
      float num7 = rotation.X * num1;
      double num8 = (double) rotation.X * (double) num2;
      float num9 = rotation.X * num3;
      float num10 = rotation.Y * num2;
      float num11 = rotation.Y * num3;
      float num12 = rotation.Z * num3;
      float num13 = 1f - num10 - num12;
      float num14 = (float) num8 - num6;
      float num15 = num9 + num5;
      float num16 = (float) num8 + num6;
      float num17 = 1f - num7 - num12;
      float num18 = num11 - num4;
      float num19 = num9 - num5;
      float num20 = num11 + num4;
      float num21 = 1f - num7 - num10;
      float x = plane.Normal.X;
      float y = plane.Normal.Y;
      float z = plane.Normal.Z;
      Plane plane1;
      plane1.Normal.X = (float) ((double) x * (double) num13 + (double) y * (double) num14 + (double) z * (double) num15);
      plane1.Normal.Y = (float) ((double) x * (double) num16 + (double) y * (double) num17 + (double) z * (double) num18);
      plane1.Normal.Z = (float) ((double) x * (double) num19 + (double) y * (double) num20 + (double) z * (double) num21);
      plane1.D = plane.D;
      return plane1;
    }

    public static void Transform(ref Plane plane, ref Quaternion rotation, out Plane result)
    {
      float num1 = rotation.X + rotation.X;
      float num2 = rotation.Y + rotation.Y;
      float num3 = rotation.Z + rotation.Z;
      float num4 = rotation.W * num1;
      float num5 = rotation.W * num2;
      float num6 = rotation.W * num3;
      float num7 = rotation.X * num1;
      double num8 = (double) rotation.X * (double) num2;
      float num9 = rotation.X * num3;
      float num10 = rotation.Y * num2;
      float num11 = rotation.Y * num3;
      float num12 = rotation.Z * num3;
      float num13 = 1f - num10 - num12;
      float num14 = (float) num8 - num6;
      float num15 = num9 + num5;
      float num16 = (float) num8 + num6;
      float num17 = 1f - num7 - num12;
      float num18 = num11 - num4;
      float num19 = num9 - num5;
      float num20 = num11 + num4;
      float num21 = 1f - num7 - num10;
      float x = plane.Normal.X;
      float y = plane.Normal.Y;
      float z = plane.Normal.Z;
      result.Normal.X = (float) ((double) x * (double) num13 + (double) y * (double) num14 + (double) z * (double) num15);
      result.Normal.Y = (float) ((double) x * (double) num16 + (double) y * (double) num17 + (double) z * (double) num18);
      result.Normal.Z = (float) ((double) x * (double) num19 + (double) y * (double) num20 + (double) z * (double) num21);
      result.D = plane.D;
    }

    public float Dot(Vector4 value) => (float) ((double) this.Normal.X * (double) value.X + (double) this.Normal.Y * (double) value.Y + (double) this.Normal.Z * (double) value.Z + (double) this.D * (double) value.W);

    public void Dot(ref Vector4 value, out float result) => result = (float) ((double) this.Normal.X * (double) value.X + (double) this.Normal.Y * (double) value.Y + (double) this.Normal.Z * (double) value.Z + (double) this.D * (double) value.W);

    public float DotCoordinate(Vector3 value) => (float) ((double) this.Normal.X * (double) value.X + (double) this.Normal.Y * (double) value.Y + (double) this.Normal.Z * (double) value.Z) + this.D;

    public void DotCoordinate(ref Vector3 value, out float result) => result = (float) ((double) this.Normal.X * (double) value.X + (double) this.Normal.Y * (double) value.Y + (double) this.Normal.Z * (double) value.Z) + this.D;

    public float DotNormal(Vector3 value) => (float) ((double) this.Normal.X * (double) value.X + (double) this.Normal.Y * (double) value.Y + (double) this.Normal.Z * (double) value.Z);

    public void DotNormal(ref Vector3 value, out float result) => result = (float) ((double) this.Normal.X * (double) value.X + (double) this.Normal.Y * (double) value.Y + (double) this.Normal.Z * (double) value.Z);

    public PlaneIntersectionType Intersects(BoundingBox box)
    {
      Vector3 vector3_1;
      vector3_1.X = (double) this.Normal.X >= 0.0 ? box.Min.X : box.Max.X;
      vector3_1.Y = (double) this.Normal.Y >= 0.0 ? box.Min.Y : box.Max.Y;
      vector3_1.Z = (double) this.Normal.Z >= 0.0 ? box.Min.Z : box.Max.Z;
      Vector3 vector3_2;
      vector3_2.X = (double) this.Normal.X >= 0.0 ? box.Max.X : box.Min.X;
      vector3_2.Y = (double) this.Normal.Y >= 0.0 ? box.Max.Y : box.Min.Y;
      vector3_2.Z = (double) this.Normal.Z >= 0.0 ? box.Max.Z : box.Min.Z;
      if ((double) this.Normal.X * (double) vector3_1.X + (double) this.Normal.Y * (double) vector3_1.Y + (double) this.Normal.Z * (double) vector3_1.Z + (double) this.D > 0.0)
        return PlaneIntersectionType.Front;
      return (double) this.Normal.X * (double) vector3_2.X + (double) this.Normal.Y * (double) vector3_2.Y + (double) this.Normal.Z * (double) vector3_2.Z + (double) this.D < 0.0 ? PlaneIntersectionType.Back : PlaneIntersectionType.Intersecting;
    }

    public void Intersects(ref BoundingBox box, out PlaneIntersectionType result)
    {
      Vector3 vector3_1;
      vector3_1.X = (double) this.Normal.X >= 0.0 ? box.Min.X : box.Max.X;
      vector3_1.Y = (double) this.Normal.Y >= 0.0 ? box.Min.Y : box.Max.Y;
      vector3_1.Z = (double) this.Normal.Z >= 0.0 ? box.Min.Z : box.Max.Z;
      Vector3 vector3_2;
      vector3_2.X = (double) this.Normal.X >= 0.0 ? box.Max.X : box.Min.X;
      vector3_2.Y = (double) this.Normal.Y >= 0.0 ? box.Max.Y : box.Min.Y;
      vector3_2.Z = (double) this.Normal.Z >= 0.0 ? box.Max.Z : box.Min.Z;
      if ((double) this.Normal.X * (double) vector3_1.X + (double) this.Normal.Y * (double) vector3_1.Y + (double) this.Normal.Z * (double) vector3_1.Z + (double) this.D > 0.0)
        result = PlaneIntersectionType.Front;
      else if ((double) this.Normal.X * (double) vector3_2.X + (double) this.Normal.Y * (double) vector3_2.Y + (double) this.Normal.Z * (double) vector3_2.Z + (double) this.D < 0.0)
        result = PlaneIntersectionType.Back;
      else
        result = PlaneIntersectionType.Intersecting;
    }

    public PlaneIntersectionType Intersects(BoundingFrustum frustum) => !((BoundingFrustum) null == frustum) ? frustum.Intersects(this) : throw new ArgumentNullException(nameof (frustum), FrameworkResources.NullNotAllowed);

    public PlaneIntersectionType Intersects(BoundingSphere sphere)
    {
      float num = (float) ((double) sphere.Center.X * (double) this.Normal.X + (double) sphere.Center.Y * (double) this.Normal.Y + (double) sphere.Center.Z * (double) this.Normal.Z) + this.D;
      if ((double) num > (double) sphere.Radius)
        return PlaneIntersectionType.Front;
      return (double) num < -(double) sphere.Radius ? PlaneIntersectionType.Back : PlaneIntersectionType.Intersecting;
    }

    public void Intersects(ref BoundingSphere sphere, out PlaneIntersectionType result)
    {
      float num = (float) ((double) sphere.Center.X * (double) this.Normal.X + (double) sphere.Center.Y * (double) this.Normal.Y + (double) sphere.Center.Z * (double) this.Normal.Z) + this.D;
      if ((double) num > (double) sphere.Radius)
        result = PlaneIntersectionType.Front;
      else if ((double) num < -(double) sphere.Radius)
        result = PlaneIntersectionType.Back;
      else
        result = PlaneIntersectionType.Intersecting;
    }

    public static bool operator ==(Plane lhs, Plane rhs) => lhs.Equals(rhs);

    public static bool operator !=(Plane lhs, Plane rhs) => (double) lhs.Normal.X != (double) rhs.Normal.X || (double) lhs.Normal.Y != (double) rhs.Normal.Y || (double) lhs.Normal.Z != (double) rhs.Normal.Z || (double) lhs.D != (double) rhs.D;
  }
}
