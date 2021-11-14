// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.BoundingBox
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
  public struct BoundingBox : IEquatable<BoundingBox>
  {
    public const int CornerCount = 8;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public Vector3 Min;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public Vector3 Max;

    public Vector3[] GetCorners() => new Vector3[8]
    {
      new Vector3(this.Min.X, this.Max.Y, this.Max.Z),
      new Vector3(this.Max.X, this.Max.Y, this.Max.Z),
      new Vector3(this.Max.X, this.Min.Y, this.Max.Z),
      new Vector3(this.Min.X, this.Min.Y, this.Max.Z),
      new Vector3(this.Min.X, this.Max.Y, this.Min.Z),
      new Vector3(this.Max.X, this.Max.Y, this.Min.Z),
      new Vector3(this.Max.X, this.Min.Y, this.Min.Z),
      new Vector3(this.Min.X, this.Min.Y, this.Min.Z)
    };

    public void GetCorners(Vector3[] corners)
    {
      if (corners == null)
        throw new ArgumentNullException(nameof (corners));
      if (corners.Length < 8)
        throw new ArgumentOutOfRangeException(nameof (corners), FrameworkResources.NotEnoughCorners);
      corners[0].X = this.Min.X;
      corners[0].Y = this.Max.Y;
      corners[0].Z = this.Max.Z;
      corners[1].X = this.Max.X;
      corners[1].Y = this.Max.Y;
      corners[1].Z = this.Max.Z;
      corners[2].X = this.Max.X;
      corners[2].Y = this.Min.Y;
      corners[2].Z = this.Max.Z;
      corners[3].X = this.Min.X;
      corners[3].Y = this.Min.Y;
      corners[3].Z = this.Max.Z;
      corners[4].X = this.Min.X;
      corners[4].Y = this.Max.Y;
      corners[4].Z = this.Min.Z;
      corners[5].X = this.Max.X;
      corners[5].Y = this.Max.Y;
      corners[5].Z = this.Min.Z;
      corners[6].X = this.Max.X;
      corners[6].Y = this.Min.Y;
      corners[6].Z = this.Min.Z;
      corners[7].X = this.Min.X;
      corners[7].Y = this.Min.Y;
      corners[7].Z = this.Min.Z;
    }

    public BoundingBox(Vector3 min, Vector3 max)
    {
      this.Min = min;
      this.Max = max;
    }

    public bool Equals(BoundingBox other) => this.Min == other.Min && this.Max == other.Max;

    public override bool Equals(object obj)
    {
      bool flag = false;
      if (obj is BoundingBox other)
        flag = this.Equals(other);
      return flag;
    }

    public override int GetHashCode() => this.Min.GetHashCode() + this.Max.GetHashCode();

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Min:{0} Max:{1}}}", (object) this.Min.ToString(), (object) this.Max.ToString());

    public static BoundingBox CreateMerged(BoundingBox original, BoundingBox additional)
    {
      BoundingBox boundingBox;
      Vector3.Min(ref original.Min, ref additional.Min, out boundingBox.Min);
      Vector3.Max(ref original.Max, ref additional.Max, out boundingBox.Max);
      return boundingBox;
    }

    public static void CreateMerged(
      ref BoundingBox original,
      ref BoundingBox additional,
      out BoundingBox result)
    {
      Vector3 result1;
      Vector3.Min(ref original.Min, ref additional.Min, out result1);
      Vector3 result2;
      Vector3.Max(ref original.Max, ref additional.Max, out result2);
      result.Min = result1;
      result.Max = result2;
    }

    public static BoundingBox CreateFromSphere(BoundingSphere sphere)
    {
      BoundingBox boundingBox;
      boundingBox.Min.X = sphere.Center.X - sphere.Radius;
      boundingBox.Min.Y = sphere.Center.Y - sphere.Radius;
      boundingBox.Min.Z = sphere.Center.Z - sphere.Radius;
      boundingBox.Max.X = sphere.Center.X + sphere.Radius;
      boundingBox.Max.Y = sphere.Center.Y + sphere.Radius;
      boundingBox.Max.Z = sphere.Center.Z + sphere.Radius;
      return boundingBox;
    }

    public static void CreateFromSphere(ref BoundingSphere sphere, out BoundingBox result)
    {
      result.Min.X = sphere.Center.X - sphere.Radius;
      result.Min.Y = sphere.Center.Y - sphere.Radius;
      result.Min.Z = sphere.Center.Z - sphere.Radius;
      result.Max.X = sphere.Center.X + sphere.Radius;
      result.Max.Y = sphere.Center.Y + sphere.Radius;
      result.Max.Z = sphere.Center.Z + sphere.Radius;
    }

    public static BoundingBox CreateFromPoints(IEnumerable<Vector3> points)
    {
      if (points == null)
        throw new ArgumentNullException();
      bool flag = false;
      Vector3 result1 = new Vector3(float.MaxValue);
      Vector3 result2 = new Vector3(float.MinValue);
      foreach (Vector3 point in points)
      {
        Vector3.Min(ref result1, ref point, out result1);
        Vector3.Max(ref result2, ref point, out result2);
        flag = true;
      }
      if (!flag)
        throw new ArgumentException(FrameworkResources.BoundingBoxZeroPoints);
      return new BoundingBox(result1, result2);
    }

    public bool Intersects(BoundingBox box) => (double) this.Max.X >= (double) box.Min.X && (double) this.Min.X <= (double) box.Max.X && ((double) this.Max.Y >= (double) box.Min.Y && (double) this.Min.Y <= (double) box.Max.Y) && ((double) this.Max.Z >= (double) box.Min.Z && (double) this.Min.Z <= (double) box.Max.Z);

    public void Intersects(ref BoundingBox box, out bool result)
    {
      result = false;
      if ((double) this.Max.X < (double) box.Min.X || (double) this.Min.X > (double) box.Max.X || ((double) this.Max.Y < (double) box.Min.Y || (double) this.Min.Y > (double) box.Max.Y) || ((double) this.Max.Z < (double) box.Min.Z || (double) this.Min.Z > (double) box.Max.Z))
        return;
      result = true;
    }

    public bool Intersects(BoundingFrustum frustum) => !((BoundingFrustum) null == frustum) ? frustum.Intersects(this) : throw new ArgumentNullException(nameof (frustum), FrameworkResources.NullNotAllowed);

    public PlaneIntersectionType Intersects(Plane plane)
    {
      Vector3 vector3_1;
      vector3_1.X = (double) plane.Normal.X >= 0.0 ? this.Min.X : this.Max.X;
      vector3_1.Y = (double) plane.Normal.Y >= 0.0 ? this.Min.Y : this.Max.Y;
      vector3_1.Z = (double) plane.Normal.Z >= 0.0 ? this.Min.Z : this.Max.Z;
      Vector3 vector3_2;
      vector3_2.X = (double) plane.Normal.X >= 0.0 ? this.Max.X : this.Min.X;
      vector3_2.Y = (double) plane.Normal.Y >= 0.0 ? this.Max.Y : this.Min.Y;
      vector3_2.Z = (double) plane.Normal.Z >= 0.0 ? this.Max.Z : this.Min.Z;
      if ((double) plane.Normal.X * (double) vector3_1.X + (double) plane.Normal.Y * (double) vector3_1.Y + (double) plane.Normal.Z * (double) vector3_1.Z + (double) plane.D > 0.0)
        return PlaneIntersectionType.Front;
      return (double) plane.Normal.X * (double) vector3_2.X + (double) plane.Normal.Y * (double) vector3_2.Y + (double) plane.Normal.Z * (double) vector3_2.Z + (double) plane.D < 0.0 ? PlaneIntersectionType.Back : PlaneIntersectionType.Intersecting;
    }

    public void Intersects(ref Plane plane, out PlaneIntersectionType result)
    {
      Vector3 vector3_1;
      vector3_1.X = (double) plane.Normal.X >= 0.0 ? this.Min.X : this.Max.X;
      vector3_1.Y = (double) plane.Normal.Y >= 0.0 ? this.Min.Y : this.Max.Y;
      vector3_1.Z = (double) plane.Normal.Z >= 0.0 ? this.Min.Z : this.Max.Z;
      Vector3 vector3_2;
      vector3_2.X = (double) plane.Normal.X >= 0.0 ? this.Max.X : this.Min.X;
      vector3_2.Y = (double) plane.Normal.Y >= 0.0 ? this.Max.Y : this.Min.Y;
      vector3_2.Z = (double) plane.Normal.Z >= 0.0 ? this.Max.Z : this.Min.Z;
      if ((double) plane.Normal.X * (double) vector3_1.X + (double) plane.Normal.Y * (double) vector3_1.Y + (double) plane.Normal.Z * (double) vector3_1.Z + (double) plane.D > 0.0)
        result = PlaneIntersectionType.Front;
      else if ((double) plane.Normal.X * (double) vector3_2.X + (double) plane.Normal.Y * (double) vector3_2.Y + (double) plane.Normal.Z * (double) vector3_2.Z + (double) plane.D < 0.0)
        result = PlaneIntersectionType.Back;
      else
        result = PlaneIntersectionType.Intersecting;
    }

    public float? Intersects(Ray ray)
    {
      float num1 = 0.0f;
      float num2 = float.MaxValue;
      if ((double) Math.Abs(ray.Direction.X) < 9.99999997475243E-07)
      {
        if ((double) ray.Position.X < (double) this.Min.X || (double) ray.Position.X > (double) this.Max.X)
          return new float?();
      }
      else
      {
        float num3 = 1f / ray.Direction.X;
        float num4 = (this.Min.X - ray.Position.X) * num3;
        float num5 = (this.Max.X - ray.Position.X) * num3;
        if ((double) num4 > (double) num5)
        {
          double num6 = (double) num4;
          num4 = num5;
          num5 = (float) num6;
        }
        num1 = MathHelper.Max(num4, num1);
        num2 = MathHelper.Min(num5, num2);
        if ((double) num1 > (double) num2)
          return new float?();
      }
      if ((double) Math.Abs(ray.Direction.Y) < 9.99999997475243E-07)
      {
        if ((double) ray.Position.Y < (double) this.Min.Y || (double) ray.Position.Y > (double) this.Max.Y)
          return new float?();
      }
      else
      {
        float num3 = 1f / ray.Direction.Y;
        float num4 = (this.Min.Y - ray.Position.Y) * num3;
        float num5 = (this.Max.Y - ray.Position.Y) * num3;
        if ((double) num4 > (double) num5)
        {
          double num6 = (double) num4;
          num4 = num5;
          num5 = (float) num6;
        }
        num1 = MathHelper.Max(num4, num1);
        num2 = MathHelper.Min(num5, num2);
        if ((double) num1 > (double) num2)
          return new float?();
      }
      if ((double) Math.Abs(ray.Direction.Z) < 9.99999997475243E-07)
      {
        if ((double) ray.Position.Z < (double) this.Min.Z || (double) ray.Position.Z > (double) this.Max.Z)
          return new float?();
      }
      else
      {
        float num3 = 1f / ray.Direction.Z;
        float num4 = (this.Min.Z - ray.Position.Z) * num3;
        float num5 = (this.Max.Z - ray.Position.Z) * num3;
        if ((double) num4 > (double) num5)
        {
          double num6 = (double) num4;
          num4 = num5;
          num5 = (float) num6;
        }
        num1 = MathHelper.Max(num4, num1);
        float num7 = MathHelper.Min(num5, num2);
        if ((double) num1 > (double) num7)
          return new float?();
      }
      return new float?(num1);
    }

    public void Intersects(ref Ray ray, out float? result)
    {
      result = new float?();
      float num1 = 0.0f;
      float num2 = float.MaxValue;
      if ((double) Math.Abs(ray.Direction.X) < 9.99999997475243E-07)
      {
        if ((double) ray.Position.X < (double) this.Min.X || (double) ray.Position.X > (double) this.Max.X)
          return;
      }
      else
      {
        float num3 = 1f / ray.Direction.X;
        float num4 = (this.Min.X - ray.Position.X) * num3;
        float num5 = (this.Max.X - ray.Position.X) * num3;
        if ((double) num4 > (double) num5)
        {
          double num6 = (double) num4;
          num4 = num5;
          num5 = (float) num6;
        }
        num1 = MathHelper.Max(num4, num1);
        num2 = MathHelper.Min(num5, num2);
        if ((double) num1 > (double) num2)
          return;
      }
      if ((double) Math.Abs(ray.Direction.Y) < 9.99999997475243E-07)
      {
        if ((double) ray.Position.Y < (double) this.Min.Y || (double) ray.Position.Y > (double) this.Max.Y)
          return;
      }
      else
      {
        float num3 = 1f / ray.Direction.Y;
        float num4 = (this.Min.Y - ray.Position.Y) * num3;
        float num5 = (this.Max.Y - ray.Position.Y) * num3;
        if ((double) num4 > (double) num5)
        {
          double num6 = (double) num4;
          num4 = num5;
          num5 = (float) num6;
        }
        num1 = MathHelper.Max(num4, num1);
        num2 = MathHelper.Min(num5, num2);
        if ((double) num1 > (double) num2)
          return;
      }
      if ((double) Math.Abs(ray.Direction.Z) < 9.99999997475243E-07)
      {
        if ((double) ray.Position.Z < (double) this.Min.Z || (double) ray.Position.Z > (double) this.Max.Z)
          return;
      }
      else
      {
        float num3 = 1f / ray.Direction.Z;
        float num4 = (this.Min.Z - ray.Position.Z) * num3;
        float num5 = (this.Max.Z - ray.Position.Z) * num3;
        if ((double) num4 > (double) num5)
        {
          double num6 = (double) num4;
          num4 = num5;
          num5 = (float) num6;
        }
        num1 = MathHelper.Max(num4, num1);
        float num7 = MathHelper.Min(num5, num2);
        if ((double) num1 > (double) num7)
          return;
      }
      result = new float?(num1);
    }

    public bool Intersects(BoundingSphere sphere)
    {
      Vector3 result1;
      Vector3.Clamp(ref sphere.Center, ref this.Min, ref this.Max, out result1);
      float result2;
      Vector3.DistanceSquared(ref sphere.Center, ref result1, out result2);
      return (double) result2 <= (double) sphere.Radius * (double) sphere.Radius;
    }

    public void Intersects(ref BoundingSphere sphere, out bool result)
    {
      Vector3 result1;
      Vector3.Clamp(ref sphere.Center, ref this.Min, ref this.Max, out result1);
      float result2;
      Vector3.DistanceSquared(ref sphere.Center, ref result1, out result2);
      result = (double) result2 <= (double) sphere.Radius * (double) sphere.Radius;
    }

    public ContainmentType Contains(BoundingBox box)
    {
      if ((double) this.Max.X < (double) box.Min.X || (double) this.Min.X > (double) box.Max.X || ((double) this.Max.Y < (double) box.Min.Y || (double) this.Min.Y > (double) box.Max.Y) || ((double) this.Max.Z < (double) box.Min.Z || (double) this.Min.Z > (double) box.Max.Z))
        return ContainmentType.Disjoint;
      return (double) this.Min.X > (double) box.Min.X || (double) box.Max.X > (double) this.Max.X || ((double) this.Min.Y > (double) box.Min.Y || (double) box.Max.Y > (double) this.Max.Y) || ((double) this.Min.Z > (double) box.Min.Z || (double) box.Max.Z > (double) this.Max.Z) ? ContainmentType.Intersects : ContainmentType.Contains;
    }

    public void Contains(ref BoundingBox box, out ContainmentType result)
    {
      result = ContainmentType.Disjoint;
      if ((double) this.Max.X < (double) box.Min.X || (double) this.Min.X > (double) box.Max.X || ((double) this.Max.Y < (double) box.Min.Y || (double) this.Min.Y > (double) box.Max.Y) || ((double) this.Max.Z < (double) box.Min.Z || (double) this.Min.Z > (double) box.Max.Z))
        return;
      result = (double) this.Min.X > (double) box.Min.X || (double) box.Max.X > (double) this.Max.X || ((double) this.Min.Y > (double) box.Min.Y || (double) box.Max.Y > (double) this.Max.Y) || ((double) this.Min.Z > (double) box.Min.Z || (double) box.Max.Z > (double) this.Max.Z) ? ContainmentType.Intersects : ContainmentType.Contains;
    }

    public ContainmentType Contains(BoundingFrustum frustum)
    {
      if ((BoundingFrustum) null == frustum)
        throw new ArgumentNullException(nameof (frustum), FrameworkResources.NullNotAllowed);
      if (!frustum.Intersects(this))
        return ContainmentType.Disjoint;
      foreach (Vector3 corner in frustum.cornerArray)
      {
        if (this.Contains(corner) == ContainmentType.Disjoint)
          return ContainmentType.Intersects;
      }
      return ContainmentType.Contains;
    }

    public ContainmentType Contains(Vector3 point) => (double) this.Min.X > (double) point.X || (double) point.X > (double) this.Max.X || ((double) this.Min.Y > (double) point.Y || (double) point.Y > (double) this.Max.Y) || ((double) this.Min.Z > (double) point.Z || (double) point.Z > (double) this.Max.Z) ? ContainmentType.Disjoint : ContainmentType.Contains;

    public void Contains(ref Vector3 point, out ContainmentType result) => result = (double) this.Min.X > (double) point.X || (double) point.X > (double) this.Max.X || ((double) this.Min.Y > (double) point.Y || (double) point.Y > (double) this.Max.Y) || ((double) this.Min.Z > (double) point.Z || (double) point.Z > (double) this.Max.Z) ? ContainmentType.Disjoint : ContainmentType.Contains;

    public ContainmentType Contains(BoundingSphere sphere)
    {
      Vector3 result1;
      Vector3.Clamp(ref sphere.Center, ref this.Min, ref this.Max, out result1);
      float result2;
      Vector3.DistanceSquared(ref sphere.Center, ref result1, out result2);
      float radius = sphere.Radius;
      double num1 = (double) result2;
      double num2 = (double) radius;
      double num3 = num2 * num2;
      if (num1 > num3)
        return ContainmentType.Disjoint;
      return (double) this.Min.X + (double) radius > (double) sphere.Center.X || (double) sphere.Center.X > (double) this.Max.X - (double) radius || ((double) this.Max.X - (double) this.Min.X <= (double) radius || (double) this.Min.Y + (double) radius > (double) sphere.Center.Y) || ((double) sphere.Center.Y > (double) this.Max.Y - (double) radius || (double) this.Max.Y - (double) this.Min.Y <= (double) radius || ((double) this.Min.Z + (double) radius > (double) sphere.Center.Z || (double) sphere.Center.Z > (double) this.Max.Z - (double) radius)) || (double) this.Max.X - (double) this.Min.X <= (double) radius ? ContainmentType.Intersects : ContainmentType.Contains;
    }

    public void Contains(ref BoundingSphere sphere, out ContainmentType result)
    {
      Vector3 result1;
      Vector3.Clamp(ref sphere.Center, ref this.Min, ref this.Max, out result1);
      float result2;
      Vector3.DistanceSquared(ref sphere.Center, ref result1, out result2);
      float radius = sphere.Radius;
      double num1 = (double) result2;
      double num2 = (double) radius;
      double num3 = num2 * num2;
      if (num1 > num3)
        result = ContainmentType.Disjoint;
      else
        result = (double) this.Min.X + (double) radius > (double) sphere.Center.X || (double) sphere.Center.X > (double) this.Max.X - (double) radius || ((double) this.Max.X - (double) this.Min.X <= (double) radius || (double) this.Min.Y + (double) radius > (double) sphere.Center.Y) || ((double) sphere.Center.Y > (double) this.Max.Y - (double) radius || (double) this.Max.Y - (double) this.Min.Y <= (double) radius || ((double) this.Min.Z + (double) radius > (double) sphere.Center.Z || (double) sphere.Center.Z > (double) this.Max.Z - (double) radius)) || (double) this.Max.X - (double) this.Min.X <= (double) radius ? ContainmentType.Intersects : ContainmentType.Contains;
    }

    internal void SupportMapping(ref Vector3 v, out Vector3 result)
    {
      result.X = (double) v.X >= 0.0 ? this.Max.X : this.Min.X;
      result.Y = (double) v.Y >= 0.0 ? this.Max.Y : this.Min.Y;
      result.Z = (double) v.Z >= 0.0 ? this.Max.Z : this.Min.Z;
    }

    public static bool operator ==(BoundingBox a, BoundingBox b) => a.Equals(b);

    public static bool operator !=(BoundingBox a, BoundingBox b) => a.Min != b.Min || a.Max != b.Max;
  }
}
