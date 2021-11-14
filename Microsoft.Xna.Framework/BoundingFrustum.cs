// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.BoundingFrustum
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
  public class BoundingFrustum : IEquatable<BoundingFrustum>
  {
    public const int CornerCount = 8;
    private const int NearPlaneIndex = 0;
    private const int FarPlaneIndex = 1;
    private const int LeftPlaneIndex = 2;
    private const int RightPlaneIndex = 3;
    private const int TopPlaneIndex = 4;
    private const int BottomPlaneIndex = 5;
    private const int NumPlanes = 6;
    private Matrix matrix;
    private Plane[] planes = new Plane[6];
    internal Vector3[] cornerArray = new Vector3[8];
    private Gjk gjk;

    public Plane Near => this.planes[0];

    public Plane Far => this.planes[1];

    public Plane Left => this.planes[2];

    public Plane Right => this.planes[3];

    public Plane Top => this.planes[4];

    public Plane Bottom => this.planes[5];

    public Vector3[] GetCorners() => (Vector3[]) this.cornerArray.Clone();

    public void GetCorners(Vector3[] corners)
    {
      if (corners == null)
        throw new ArgumentNullException(nameof (corners));
      if (corners.Length < 8)
        throw new ArgumentOutOfRangeException(nameof (corners), FrameworkResources.NotEnoughCorners);
      this.cornerArray.CopyTo((Array) corners, 0);
    }

    public Matrix Matrix
    {
      get => this.matrix;
      set => this.SetMatrix(ref value);
    }

    public bool Equals(BoundingFrustum other) => !(other == (BoundingFrustum) null) && this.matrix == other.matrix;

    public override bool Equals(object obj)
    {
      bool flag = false;
      BoundingFrustum boundingFrustum = obj as BoundingFrustum;
      if (boundingFrustum != (BoundingFrustum) null)
        flag = this.matrix == boundingFrustum.matrix;
      return flag;
    }

    public override int GetHashCode() => this.matrix.GetHashCode();

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Near:{0} Far:{1} Left:{2} Right:{3} Top:{4} Bottom:{5}}}", (object) this.Near.ToString(), (object) this.Far.ToString(), (object) this.Left.ToString(), (object) this.Right.ToString(), (object) this.Top.ToString(), (object) this.Bottom.ToString());

    private BoundingFrustum()
    {
    }

    public BoundingFrustum(Matrix value) => this.SetMatrix(ref value);

    private void SetMatrix(ref Matrix value)
    {
      this.matrix = value;
      this.planes[2].Normal.X = -value.M14 - value.M11;
      this.planes[2].Normal.Y = -value.M24 - value.M21;
      this.planes[2].Normal.Z = -value.M34 - value.M31;
      this.planes[2].D = -value.M44 - value.M41;
      this.planes[3].Normal.X = -value.M14 + value.M11;
      this.planes[3].Normal.Y = -value.M24 + value.M21;
      this.planes[3].Normal.Z = -value.M34 + value.M31;
      this.planes[3].D = -value.M44 + value.M41;
      this.planes[4].Normal.X = -value.M14 + value.M12;
      this.planes[4].Normal.Y = -value.M24 + value.M22;
      this.planes[4].Normal.Z = -value.M34 + value.M32;
      this.planes[4].D = -value.M44 + value.M42;
      this.planes[5].Normal.X = -value.M14 - value.M12;
      this.planes[5].Normal.Y = -value.M24 - value.M22;
      this.planes[5].Normal.Z = -value.M34 - value.M32;
      this.planes[5].D = -value.M44 - value.M42;
      this.planes[0].Normal.X = -value.M13;
      this.planes[0].Normal.Y = -value.M23;
      this.planes[0].Normal.Z = -value.M33;
      this.planes[0].D = -value.M43;
      this.planes[1].Normal.X = -value.M14 + value.M13;
      this.planes[1].Normal.Y = -value.M24 + value.M23;
      this.planes[1].Normal.Z = -value.M34 + value.M33;
      this.planes[1].D = -value.M44 + value.M43;
      for (int index = 0; index < 6; ++index)
      {
        float num = this.planes[index].Normal.Length();
        this.planes[index].Normal /= num;
        this.planes[index].D /= num;
      }
      Ray intersectionLine = BoundingFrustum.ComputeIntersectionLine(ref this.planes[0], ref this.planes[2]);
      this.cornerArray[0] = BoundingFrustum.ComputeIntersection(ref this.planes[4], ref intersectionLine);
      this.cornerArray[3] = BoundingFrustum.ComputeIntersection(ref this.planes[5], ref intersectionLine);
      intersectionLine = BoundingFrustum.ComputeIntersectionLine(ref this.planes[3], ref this.planes[0]);
      this.cornerArray[1] = BoundingFrustum.ComputeIntersection(ref this.planes[4], ref intersectionLine);
      this.cornerArray[2] = BoundingFrustum.ComputeIntersection(ref this.planes[5], ref intersectionLine);
      intersectionLine = BoundingFrustum.ComputeIntersectionLine(ref this.planes[2], ref this.planes[1]);
      this.cornerArray[4] = BoundingFrustum.ComputeIntersection(ref this.planes[4], ref intersectionLine);
      this.cornerArray[7] = BoundingFrustum.ComputeIntersection(ref this.planes[5], ref intersectionLine);
      intersectionLine = BoundingFrustum.ComputeIntersectionLine(ref this.planes[1], ref this.planes[3]);
      this.cornerArray[5] = BoundingFrustum.ComputeIntersection(ref this.planes[4], ref intersectionLine);
      this.cornerArray[6] = BoundingFrustum.ComputeIntersection(ref this.planes[5], ref intersectionLine);
    }

    private static Ray ComputeIntersectionLine(ref Plane p1, ref Plane p2)
    {
      Ray ray = new Ray();
      ray.Direction = Vector3.Cross(p1.Normal, p2.Normal);
      float num = ray.Direction.LengthSquared();
      ray.Position = Vector3.Cross(-p1.D * p2.Normal + p2.D * p1.Normal, ray.Direction) / num;
      return ray;
    }

    private static Vector3 ComputeIntersection(ref Plane plane, ref Ray ray)
    {
      float num = (-plane.D - Vector3.Dot(plane.Normal, ray.Position)) / Vector3.Dot(plane.Normal, ray.Direction);
      return ray.Position + ray.Direction * num;
    }

    public bool Intersects(BoundingBox box)
    {
      bool result;
      this.Intersects(ref box, out result);
      return result;
    }

    public void Intersects(ref BoundingBox box, out bool result)
    {
      if (this.gjk == null)
        this.gjk = new Gjk();
      this.gjk.Reset();
      Vector3 result1;
      Vector3.Subtract(ref this.cornerArray[0], ref box.Min, out result1);
      if ((double) result1.LengthSquared() < 9.99999974737875E-06)
        Vector3.Subtract(ref this.cornerArray[0], ref box.Max, out result1);
      float num1 = float.MaxValue;
      result = false;
      float num2;
      do
      {
        Vector3 v;
        v.X = -result1.X;
        v.Y = -result1.Y;
        v.Z = -result1.Z;
        Vector3 result2;
        this.SupportMapping(ref v, out result2);
        Vector3 result3;
        box.SupportMapping(ref result1, out result3);
        Vector3 result4;
        Vector3.Subtract(ref result2, ref result3, out result4);
        if ((double) result1.X * (double) result4.X + (double) result1.Y * (double) result4.Y + (double) result1.Z * (double) result4.Z > 0.0)
          return;
        this.gjk.AddSupportPoint(ref result4);
        result1 = this.gjk.ClosestPoint;
        float num3 = num1;
        num1 = result1.LengthSquared();
        if ((double) num3 - (double) num1 <= 9.99999974737875E-06 * (double) num3)
          return;
        num2 = 4E-05f * this.gjk.MaxLengthSquared;
      }
      while (!this.gjk.FullSimplex && (double) num1 >= (double) num2);
      result = true;
    }

    public bool Intersects(BoundingFrustum frustum)
    {
      if (frustum == (BoundingFrustum) null)
        throw new ArgumentNullException(nameof (frustum));
      if (this.gjk == null)
        this.gjk = new Gjk();
      this.gjk.Reset();
      Vector3 result1;
      Vector3.Subtract(ref this.cornerArray[0], ref frustum.cornerArray[0], out result1);
      if ((double) result1.LengthSquared() < 9.99999974737875E-06)
        Vector3.Subtract(ref this.cornerArray[0], ref frustum.cornerArray[1], out result1);
      float num1 = float.MaxValue;
      float num2;
      do
      {
        Vector3 v;
        v.X = -result1.X;
        v.Y = -result1.Y;
        v.Z = -result1.Z;
        Vector3 result2;
        this.SupportMapping(ref v, out result2);
        Vector3 result3;
        frustum.SupportMapping(ref result1, out result3);
        Vector3 result4;
        Vector3.Subtract(ref result2, ref result3, out result4);
        if ((double) result1.X * (double) result4.X + (double) result1.Y * (double) result4.Y + (double) result1.Z * (double) result4.Z > 0.0)
          return false;
        this.gjk.AddSupportPoint(ref result4);
        result1 = this.gjk.ClosestPoint;
        float num3 = num1;
        num1 = result1.LengthSquared();
        num2 = 4E-05f * this.gjk.MaxLengthSquared;
        if ((double) num3 - (double) num1 <= 9.99999974737875E-06 * (double) num3)
          return false;
      }
      while (!this.gjk.FullSimplex && (double) num1 >= (double) num2);
      return true;
    }

    public PlaneIntersectionType Intersects(Plane plane)
    {
      int num = 0;
      for (int index = 0; index < 8; ++index)
      {
        float result;
        Vector3.Dot(ref this.cornerArray[index], ref plane.Normal, out result);
        if ((double) result + (double) plane.D > 0.0)
          num |= 1;
        else
          num |= 2;
        if (num == 3)
          return PlaneIntersectionType.Intersecting;
      }
      return num != 1 ? PlaneIntersectionType.Back : PlaneIntersectionType.Front;
    }

    public void Intersects(ref Plane plane, out PlaneIntersectionType result)
    {
      int num = 0;
      for (int index = 0; index < 8; ++index)
      {
        float result1;
        Vector3.Dot(ref this.cornerArray[index], ref plane.Normal, out result1);
        if ((double) result1 + (double) plane.D > 0.0)
          num |= 1;
        else
          num |= 2;
        if (num == 3)
        {
          result = PlaneIntersectionType.Intersecting;
          return;
        }
      }
      result = num == 1 ? PlaneIntersectionType.Front : PlaneIntersectionType.Back;
    }

    public float? Intersects(Ray ray)
    {
      float? result;
      this.Intersects(ref ray, out result);
      return result;
    }

    public void Intersects(ref Ray ray, out float? result)
    {
      ContainmentType result1;
      this.Contains(ref ray.Position, out result1);
      if (result1 == ContainmentType.Contains)
      {
        result = new float?(0.0f);
      }
      else
      {
        float num1 = float.MinValue;
        float num2 = float.MaxValue;
        result = new float?();
        foreach (Plane plane in this.planes)
        {
          Vector3 normal = plane.Normal;
          float result2;
          Vector3.Dot(ref ray.Direction, ref normal, out result2);
          float result3;
          Vector3.Dot(ref ray.Position, ref normal, out result3);
          result3 += plane.D;
          if ((double) Math.Abs(result2) < 9.99999974737875E-06)
          {
            if ((double) result3 > 0.0)
              return;
          }
          else
          {
            float num3 = -result3 / result2;
            if ((double) result2 < 0.0)
            {
              if ((double) num3 > (double) num2)
                return;
              if ((double) num3 > (double) num1)
                num1 = num3;
            }
            else
            {
              if ((double) num3 < (double) num1)
                return;
              if ((double) num3 < (double) num2)
                num2 = num3;
            }
          }
        }
        float num4 = (double) num1 >= 0.0 ? num1 : num2;
        if ((double) num4 < 0.0)
          return;
        result = new float?(num4);
      }
    }

    public bool Intersects(BoundingSphere sphere)
    {
      bool result;
      this.Intersects(ref sphere, out result);
      return result;
    }

    public void Intersects(ref BoundingSphere sphere, out bool result)
    {
      if (this.gjk == null)
        this.gjk = new Gjk();
      this.gjk.Reset();
      Vector3 result1;
      Vector3.Subtract(ref this.cornerArray[0], ref sphere.Center, out result1);
      if ((double) result1.LengthSquared() < 9.99999974737875E-06)
        result1 = Vector3.UnitX;
      float num1 = float.MaxValue;
      result = false;
      float num2;
      do
      {
        Vector3 v;
        v.X = -result1.X;
        v.Y = -result1.Y;
        v.Z = -result1.Z;
        Vector3 result2;
        this.SupportMapping(ref v, out result2);
        Vector3 result3;
        sphere.SupportMapping(ref result1, out result3);
        Vector3 result4;
        Vector3.Subtract(ref result2, ref result3, out result4);
        if ((double) result1.X * (double) result4.X + (double) result1.Y * (double) result4.Y + (double) result1.Z * (double) result4.Z > 0.0)
          return;
        this.gjk.AddSupportPoint(ref result4);
        result1 = this.gjk.ClosestPoint;
        float num3 = num1;
        num1 = result1.LengthSquared();
        if ((double) num3 - (double) num1 <= 9.99999974737875E-06 * (double) num3)
          return;
        num2 = 4E-05f * this.gjk.MaxLengthSquared;
      }
      while (!this.gjk.FullSimplex && (double) num1 >= (double) num2);
      result = true;
    }

    public ContainmentType Contains(BoundingBox box)
    {
      bool flag = false;
      foreach (Plane plane in this.planes)
      {
        switch (box.Intersects(plane))
        {
          case PlaneIntersectionType.Front:
            return ContainmentType.Disjoint;
          case PlaneIntersectionType.Intersecting:
            flag = true;
            break;
        }
      }
      return !flag ? ContainmentType.Contains : ContainmentType.Intersects;
    }

    public void Contains(ref BoundingBox box, out ContainmentType result)
    {
      bool flag = false;
      foreach (Plane plane in this.planes)
      {
        switch (box.Intersects(plane))
        {
          case PlaneIntersectionType.Front:
            result = ContainmentType.Disjoint;
            return;
          case PlaneIntersectionType.Intersecting:
            flag = true;
            break;
        }
      }
      result = flag ? ContainmentType.Intersects : ContainmentType.Contains;
    }

    public ContainmentType Contains(BoundingFrustum frustum)
    {
      if (frustum == (BoundingFrustum) null)
        throw new ArgumentNullException(nameof (frustum));
      ContainmentType containmentType = ContainmentType.Disjoint;
      if (this.Intersects(frustum))
      {
        containmentType = ContainmentType.Contains;
        for (int index = 0; index < this.cornerArray.Length; ++index)
        {
          if (this.Contains(frustum.cornerArray[index]) == ContainmentType.Disjoint)
          {
            containmentType = ContainmentType.Intersects;
            break;
          }
        }
      }
      return containmentType;
    }

    public ContainmentType Contains(Vector3 point)
    {
      foreach (Plane plane in this.planes)
      {
        if ((double) plane.Normal.X * (double) point.X + (double) plane.Normal.Y * (double) point.Y + (double) plane.Normal.Z * (double) point.Z + (double) plane.D > 9.99999974737875E-06)
          return ContainmentType.Disjoint;
      }
      return ContainmentType.Contains;
    }

    public void Contains(ref Vector3 point, out ContainmentType result)
    {
      foreach (Plane plane in this.planes)
      {
        if ((double) plane.Normal.X * (double) point.X + (double) plane.Normal.Y * (double) point.Y + (double) plane.Normal.Z * (double) point.Z + (double) plane.D > 9.99999974737875E-06)
        {
          result = ContainmentType.Disjoint;
          return;
        }
      }
      result = ContainmentType.Contains;
    }

    public ContainmentType Contains(BoundingSphere sphere)
    {
      Vector3 center = sphere.Center;
      float radius = sphere.Radius;
      int num1 = 0;
      foreach (Plane plane in this.planes)
      {
        float num2 = (float) ((double) plane.Normal.X * (double) center.X + (double) plane.Normal.Y * (double) center.Y + (double) plane.Normal.Z * (double) center.Z) + plane.D;
        if ((double) num2 > (double) radius)
          return ContainmentType.Disjoint;
        if ((double) num2 < -(double) radius)
          ++num1;
      }
      return num1 != 6 ? ContainmentType.Intersects : ContainmentType.Contains;
    }

    public void Contains(ref BoundingSphere sphere, out ContainmentType result)
    {
      Vector3 center = sphere.Center;
      float radius = sphere.Radius;
      int num1 = 0;
      foreach (Plane plane in this.planes)
      {
        float num2 = (float) ((double) plane.Normal.X * (double) center.X + (double) plane.Normal.Y * (double) center.Y + (double) plane.Normal.Z * (double) center.Z) + plane.D;
        if ((double) num2 > (double) radius)
        {
          result = ContainmentType.Disjoint;
          return;
        }
        if ((double) num2 < -(double) radius)
          ++num1;
      }
      result = num1 == 6 ? ContainmentType.Contains : ContainmentType.Intersects;
    }

    internal void SupportMapping(ref Vector3 v, out Vector3 result)
    {
      int index1 = 0;
      float result1;
      Vector3.Dot(ref this.cornerArray[0], ref v, out result1);
      for (int index2 = 1; index2 < this.cornerArray.Length; ++index2)
      {
        Vector3 vector3;
        vector3.X = -v.X;
        vector3.Y = -v.Y;
        vector3.Z = -v.Z;
        float result2;
        Vector3.Dot(ref this.cornerArray[index2], ref v, out result2);
        if ((double) result2 > (double) result1)
        {
          index1 = index2;
          result1 = result2;
        }
      }
      result = this.cornerArray[index1];
    }

    public static bool operator ==(BoundingFrustum a, BoundingFrustum b) => object.Equals((object) a, (object) b);

    public static bool operator !=(BoundingFrustum a, BoundingFrustum b) => !object.Equals((object) a, (object) b);
  }
}
