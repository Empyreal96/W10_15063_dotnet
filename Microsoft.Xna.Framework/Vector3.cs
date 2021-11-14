// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Vector3
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
  public struct Vector3 : IEquatable<Vector3>
  {
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float X;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float Y;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float Z;

    public static Vector3 Zero => new Vector3();

    public static Vector3 One => new Vector3(1f, 1f, 1f);

    public static Vector3 UnitX => new Vector3(1f, 0.0f, 0.0f);

    public static Vector3 UnitY => new Vector3(0.0f, 1f, 0.0f);

    public static Vector3 UnitZ => new Vector3(0.0f, 0.0f, 1f);

    public static Vector3 Up => new Vector3(0.0f, 1f, 0.0f);

    public static Vector3 Down => new Vector3(0.0f, -1f, 0.0f);

    public static Vector3 Right => new Vector3(1f, 0.0f, 0.0f);

    public static Vector3 Left => new Vector3(-1f, 0.0f, 0.0f);

    public static Vector3 Forward => new Vector3(0.0f, 0.0f, -1f);

    public static Vector3 Backward => new Vector3(0.0f, 0.0f, 1f);

    public Vector3(float x, float y, float z)
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
    }

    public Vector3(float value) => this.X = this.Y = this.Z = value;

    public Vector3(Vector2 value, float z)
    {
      this.X = value.X;
      this.Y = value.Y;
      this.Z = z;
    }

    public override string ToString()
    {
      CultureInfo currentCulture = CultureInfo.CurrentCulture;
      return string.Format((IFormatProvider) currentCulture, "{{X:{0} Y:{1} Z:{2}}}", (object) this.X.ToString((IFormatProvider) currentCulture), (object) this.Y.ToString((IFormatProvider) currentCulture), (object) this.Z.ToString((IFormatProvider) currentCulture));
    }

    public bool Equals(Vector3 other) => (double) this.X == (double) other.X && (double) this.Y == (double) other.Y && (double) this.Z == (double) other.Z;

    public override bool Equals(object obj)
    {
      bool flag = false;
      if (obj is Vector3 other)
        flag = this.Equals(other);
      return flag;
    }

    public override int GetHashCode() => this.X.GetHashCode() + this.Y.GetHashCode() + this.Z.GetHashCode();

    public float Length() => (float) Math.Sqrt((double) this.X * (double) this.X + (double) this.Y * (double) this.Y + (double) this.Z * (double) this.Z);

    public float LengthSquared() => (float) ((double) this.X * (double) this.X + (double) this.Y * (double) this.Y + (double) this.Z * (double) this.Z);

    public static float Distance(Vector3 value1, Vector3 value2)
    {
      double num1 = (double) value1.X - (double) value2.X;
      float num2 = value1.Y - value2.Y;
      float num3 = value1.Z - value2.Z;
      double num4 = num1 * num1;
      double num5 = (double) num2;
      double num6 = num5 * num5;
      double num7 = num4 + num6;
      double num8 = (double) num3;
      double num9 = num8 * num8;
      return (float) Math.Sqrt(num7 + num9);
    }

    public static void Distance(ref Vector3 value1, ref Vector3 value2, out float result)
    {
      double num1 = (double) value1.X - (double) value2.X;
      float num2 = value1.Y - value2.Y;
      float num3 = value1.Z - value2.Z;
      double num4 = num1 * num1;
      double num5 = (double) num2;
      double num6 = num5 * num5;
      double num7 = num4 + num6;
      double num8 = (double) num3;
      double num9 = num8 * num8;
      float num10 = (float) (num7 + num9);
      result = (float) Math.Sqrt((double) num10);
    }

    public static float DistanceSquared(Vector3 value1, Vector3 value2)
    {
      double num1 = (double) value1.X - (double) value2.X;
      float num2 = value1.Y - value2.Y;
      float num3 = value1.Z - value2.Z;
      double num4 = num1 * num1;
      double num5 = (double) num2;
      double num6 = num5 * num5;
      double num7 = num4 + num6;
      double num8 = (double) num3;
      double num9 = num8 * num8;
      return (float) (num7 + num9);
    }

    public static void DistanceSquared(ref Vector3 value1, ref Vector3 value2, out float result)
    {
      float num1 = value1.X - value2.X;
      float num2 = value1.Y - value2.Y;
      float num3 = value1.Z - value2.Z;
      ref float local = ref result;
      double num4 = (double) num1;
      double num5 = num4 * num4;
      double num6 = (double) num2;
      double num7 = num6 * num6;
      double num8 = num5 + num7;
      double num9 = (double) num3;
      double num10 = num9 * num9;
      double num11 = num8 + num10;
      local = (float) num11;
    }

    public static float Dot(Vector3 vector1, Vector3 vector2) => (float) ((double) vector1.X * (double) vector2.X + (double) vector1.Y * (double) vector2.Y + (double) vector1.Z * (double) vector2.Z);

    public static void Dot(ref Vector3 vector1, ref Vector3 vector2, out float result) => result = (float) ((double) vector1.X * (double) vector2.X + (double) vector1.Y * (double) vector2.Y + (double) vector1.Z * (double) vector2.Z);

    public void Normalize()
    {
      float num = 1f / (float) Math.Sqrt((double) this.X * (double) this.X + (double) this.Y * (double) this.Y + (double) this.Z * (double) this.Z);
      this.X *= num;
      this.Y *= num;
      this.Z *= num;
    }

    public static Vector3 Normalize(Vector3 value)
    {
      float num = 1f / (float) Math.Sqrt((double) value.X * (double) value.X + (double) value.Y * (double) value.Y + (double) value.Z * (double) value.Z);
      Vector3 vector3;
      vector3.X = value.X * num;
      vector3.Y = value.Y * num;
      vector3.Z = value.Z * num;
      return vector3;
    }

    public static void Normalize(ref Vector3 value, out Vector3 result)
    {
      float num = 1f / (float) Math.Sqrt((double) value.X * (double) value.X + (double) value.Y * (double) value.Y + (double) value.Z * (double) value.Z);
      result.X = value.X * num;
      result.Y = value.Y * num;
      result.Z = value.Z * num;
    }

    public static Vector3 Cross(Vector3 vector1, Vector3 vector2)
    {
      Vector3 vector3;
      vector3.X = (float) ((double) vector1.Y * (double) vector2.Z - (double) vector1.Z * (double) vector2.Y);
      vector3.Y = (float) ((double) vector1.Z * (double) vector2.X - (double) vector1.X * (double) vector2.Z);
      vector3.Z = (float) ((double) vector1.X * (double) vector2.Y - (double) vector1.Y * (double) vector2.X);
      return vector3;
    }

    public static void Cross(ref Vector3 vector1, ref Vector3 vector2, out Vector3 result)
    {
      float num1 = (float) ((double) vector1.Y * (double) vector2.Z - (double) vector1.Z * (double) vector2.Y);
      float num2 = (float) ((double) vector1.Z * (double) vector2.X - (double) vector1.X * (double) vector2.Z);
      float num3 = (float) ((double) vector1.X * (double) vector2.Y - (double) vector1.Y * (double) vector2.X);
      result.X = num1;
      result.Y = num2;
      result.Z = num3;
    }

    public static Vector3 Reflect(Vector3 vector, Vector3 normal)
    {
      float num = (float) ((double) vector.X * (double) normal.X + (double) vector.Y * (double) normal.Y + (double) vector.Z * (double) normal.Z);
      Vector3 vector3;
      vector3.X = vector.X - 2f * num * normal.X;
      vector3.Y = vector.Y - 2f * num * normal.Y;
      vector3.Z = vector.Z - 2f * num * normal.Z;
      return vector3;
    }

    public static void Reflect(ref Vector3 vector, ref Vector3 normal, out Vector3 result)
    {
      float num = (float) ((double) vector.X * (double) normal.X + (double) vector.Y * (double) normal.Y + (double) vector.Z * (double) normal.Z);
      result.X = vector.X - 2f * num * normal.X;
      result.Y = vector.Y - 2f * num * normal.Y;
      result.Z = vector.Z - 2f * num * normal.Z;
    }

    public static Vector3 Min(Vector3 value1, Vector3 value2)
    {
      Vector3 vector3;
      vector3.X = (double) value1.X < (double) value2.X ? value1.X : value2.X;
      vector3.Y = (double) value1.Y < (double) value2.Y ? value1.Y : value2.Y;
      vector3.Z = (double) value1.Z < (double) value2.Z ? value1.Z : value2.Z;
      return vector3;
    }

    public static void Min(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
    {
      result.X = (double) value1.X < (double) value2.X ? value1.X : value2.X;
      result.Y = (double) value1.Y < (double) value2.Y ? value1.Y : value2.Y;
      result.Z = (double) value1.Z < (double) value2.Z ? value1.Z : value2.Z;
    }

    public static Vector3 Max(Vector3 value1, Vector3 value2)
    {
      Vector3 vector3;
      vector3.X = (double) value1.X > (double) value2.X ? value1.X : value2.X;
      vector3.Y = (double) value1.Y > (double) value2.Y ? value1.Y : value2.Y;
      vector3.Z = (double) value1.Z > (double) value2.Z ? value1.Z : value2.Z;
      return vector3;
    }

    public static void Max(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
    {
      result.X = (double) value1.X > (double) value2.X ? value1.X : value2.X;
      result.Y = (double) value1.Y > (double) value2.Y ? value1.Y : value2.Y;
      result.Z = (double) value1.Z > (double) value2.Z ? value1.Z : value2.Z;
    }

    public static Vector3 Clamp(Vector3 value1, Vector3 min, Vector3 max)
    {
      float x = value1.X;
      float num1 = (double) x > (double) max.X ? max.X : x;
      float num2 = (double) num1 < (double) min.X ? min.X : num1;
      float y = value1.Y;
      float num3 = (double) y > (double) max.Y ? max.Y : y;
      float num4 = (double) num3 < (double) min.Y ? min.Y : num3;
      float z = value1.Z;
      float num5 = (double) z > (double) max.Z ? max.Z : z;
      float num6 = (double) num5 < (double) min.Z ? min.Z : num5;
      Vector3 vector3;
      vector3.X = num2;
      vector3.Y = num4;
      vector3.Z = num6;
      return vector3;
    }

    public static void Clamp(
      ref Vector3 value1,
      ref Vector3 min,
      ref Vector3 max,
      out Vector3 result)
    {
      float x = value1.X;
      float num1 = (double) x > (double) max.X ? max.X : x;
      float num2 = (double) num1 < (double) min.X ? min.X : num1;
      float y = value1.Y;
      float num3 = (double) y > (double) max.Y ? max.Y : y;
      float num4 = (double) num3 < (double) min.Y ? min.Y : num3;
      float z = value1.Z;
      float num5 = (double) z > (double) max.Z ? max.Z : z;
      float num6 = (double) num5 < (double) min.Z ? min.Z : num5;
      result.X = num2;
      result.Y = num4;
      result.Z = num6;
    }

    public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount)
    {
      Vector3 vector3;
      vector3.X = value1.X + (value2.X - value1.X) * amount;
      vector3.Y = value1.Y + (value2.Y - value1.Y) * amount;
      vector3.Z = value1.Z + (value2.Z - value1.Z) * amount;
      return vector3;
    }

    public static void Lerp(
      ref Vector3 value1,
      ref Vector3 value2,
      float amount,
      out Vector3 result)
    {
      result.X = value1.X + (value2.X - value1.X) * amount;
      result.Y = value1.Y + (value2.Y - value1.Y) * amount;
      result.Z = value1.Z + (value2.Z - value1.Z) * amount;
    }

    public static Vector3 Barycentric(
      Vector3 value1,
      Vector3 value2,
      Vector3 value3,
      float amount1,
      float amount2)
    {
      Vector3 vector3;
      vector3.X = (float) ((double) value1.X + (double) amount1 * ((double) value2.X - (double) value1.X) + (double) amount2 * ((double) value3.X - (double) value1.X));
      vector3.Y = (float) ((double) value1.Y + (double) amount1 * ((double) value2.Y - (double) value1.Y) + (double) amount2 * ((double) value3.Y - (double) value1.Y));
      vector3.Z = (float) ((double) value1.Z + (double) amount1 * ((double) value2.Z - (double) value1.Z) + (double) amount2 * ((double) value3.Z - (double) value1.Z));
      return vector3;
    }

    public static void Barycentric(
      ref Vector3 value1,
      ref Vector3 value2,
      ref Vector3 value3,
      float amount1,
      float amount2,
      out Vector3 result)
    {
      result.X = (float) ((double) value1.X + (double) amount1 * ((double) value2.X - (double) value1.X) + (double) amount2 * ((double) value3.X - (double) value1.X));
      result.Y = (float) ((double) value1.Y + (double) amount1 * ((double) value2.Y - (double) value1.Y) + (double) amount2 * ((double) value3.Y - (double) value1.Y));
      result.Z = (float) ((double) value1.Z + (double) amount1 * ((double) value2.Z - (double) value1.Z) + (double) amount2 * ((double) value3.Z - (double) value1.Z));
    }

    public static Vector3 SmoothStep(Vector3 value1, Vector3 value2, float amount)
    {
      amount = (double) amount > 1.0 ? 1f : ((double) amount < 0.0 ? 0.0f : amount);
      double num = (double) amount;
      amount = (float) (num * num * (3.0 - 2.0 * (double) amount));
      Vector3 vector3;
      vector3.X = value1.X + (value2.X - value1.X) * amount;
      vector3.Y = value1.Y + (value2.Y - value1.Y) * amount;
      vector3.Z = value1.Z + (value2.Z - value1.Z) * amount;
      return vector3;
    }

    public static void SmoothStep(
      ref Vector3 value1,
      ref Vector3 value2,
      float amount,
      out Vector3 result)
    {
      amount = (double) amount > 1.0 ? 1f : ((double) amount < 0.0 ? 0.0f : amount);
      double num = (double) amount;
      amount = (float) (num * num * (3.0 - 2.0 * (double) amount));
      result.X = value1.X + (value2.X - value1.X) * amount;
      result.Y = value1.Y + (value2.Y - value1.Y) * amount;
      result.Z = value1.Z + (value2.Z - value1.Z) * amount;
    }

    public static Vector3 CatmullRom(
      Vector3 value1,
      Vector3 value2,
      Vector3 value3,
      Vector3 value4,
      float amount)
    {
      double num1 = (double) amount;
      float num2 = (float) (num1 * num1);
      float num3 = amount * num2;
      Vector3 vector3;
      vector3.X = (float) (0.5 * (2.0 * (double) value2.X + (-(double) value1.X + (double) value3.X) * (double) amount + (2.0 * (double) value1.X - 5.0 * (double) value2.X + 4.0 * (double) value3.X - (double) value4.X) * (double) num2 + (-(double) value1.X + 3.0 * (double) value2.X - 3.0 * (double) value3.X + (double) value4.X) * (double) num3));
      vector3.Y = (float) (0.5 * (2.0 * (double) value2.Y + (-(double) value1.Y + (double) value3.Y) * (double) amount + (2.0 * (double) value1.Y - 5.0 * (double) value2.Y + 4.0 * (double) value3.Y - (double) value4.Y) * (double) num2 + (-(double) value1.Y + 3.0 * (double) value2.Y - 3.0 * (double) value3.Y + (double) value4.Y) * (double) num3));
      vector3.Z = (float) (0.5 * (2.0 * (double) value2.Z + (-(double) value1.Z + (double) value3.Z) * (double) amount + (2.0 * (double) value1.Z - 5.0 * (double) value2.Z + 4.0 * (double) value3.Z - (double) value4.Z) * (double) num2 + (-(double) value1.Z + 3.0 * (double) value2.Z - 3.0 * (double) value3.Z + (double) value4.Z) * (double) num3));
      return vector3;
    }

    public static void CatmullRom(
      ref Vector3 value1,
      ref Vector3 value2,
      ref Vector3 value3,
      ref Vector3 value4,
      float amount,
      out Vector3 result)
    {
      double num1 = (double) amount;
      float num2 = (float) (num1 * num1);
      float num3 = amount * num2;
      result.X = (float) (0.5 * (2.0 * (double) value2.X + (-(double) value1.X + (double) value3.X) * (double) amount + (2.0 * (double) value1.X - 5.0 * (double) value2.X + 4.0 * (double) value3.X - (double) value4.X) * (double) num2 + (-(double) value1.X + 3.0 * (double) value2.X - 3.0 * (double) value3.X + (double) value4.X) * (double) num3));
      result.Y = (float) (0.5 * (2.0 * (double) value2.Y + (-(double) value1.Y + (double) value3.Y) * (double) amount + (2.0 * (double) value1.Y - 5.0 * (double) value2.Y + 4.0 * (double) value3.Y - (double) value4.Y) * (double) num2 + (-(double) value1.Y + 3.0 * (double) value2.Y - 3.0 * (double) value3.Y + (double) value4.Y) * (double) num3));
      result.Z = (float) (0.5 * (2.0 * (double) value2.Z + (-(double) value1.Z + (double) value3.Z) * (double) amount + (2.0 * (double) value1.Z - 5.0 * (double) value2.Z + 4.0 * (double) value3.Z - (double) value4.Z) * (double) num2 + (-(double) value1.Z + 3.0 * (double) value2.Z - 3.0 * (double) value3.Z + (double) value4.Z) * (double) num3));
    }

    public static Vector3 Hermite(
      Vector3 value1,
      Vector3 tangent1,
      Vector3 value2,
      Vector3 tangent2,
      float amount)
    {
      double num1 = (double) amount;
      float num2 = (float) (num1 * num1);
      float num3 = amount * num2;
      float num4 = (float) (2.0 * (double) num3 - 3.0 * (double) num2 + 1.0);
      float num5 = (float) (-2.0 * (double) num3 + 3.0 * (double) num2);
      float num6 = num3 - 2f * num2 + amount;
      float num7 = num3 - num2;
      Vector3 vector3;
      vector3.X = (float) ((double) value1.X * (double) num4 + (double) value2.X * (double) num5 + (double) tangent1.X * (double) num6 + (double) tangent2.X * (double) num7);
      vector3.Y = (float) ((double) value1.Y * (double) num4 + (double) value2.Y * (double) num5 + (double) tangent1.Y * (double) num6 + (double) tangent2.Y * (double) num7);
      vector3.Z = (float) ((double) value1.Z * (double) num4 + (double) value2.Z * (double) num5 + (double) tangent1.Z * (double) num6 + (double) tangent2.Z * (double) num7);
      return vector3;
    }

    public static void Hermite(
      ref Vector3 value1,
      ref Vector3 tangent1,
      ref Vector3 value2,
      ref Vector3 tangent2,
      float amount,
      out Vector3 result)
    {
      double num1 = (double) amount;
      float num2 = (float) (num1 * num1);
      float num3 = amount * num2;
      float num4 = (float) (2.0 * (double) num3 - 3.0 * (double) num2 + 1.0);
      float num5 = (float) (-2.0 * (double) num3 + 3.0 * (double) num2);
      float num6 = num3 - 2f * num2 + amount;
      float num7 = num3 - num2;
      result.X = (float) ((double) value1.X * (double) num4 + (double) value2.X * (double) num5 + (double) tangent1.X * (double) num6 + (double) tangent2.X * (double) num7);
      result.Y = (float) ((double) value1.Y * (double) num4 + (double) value2.Y * (double) num5 + (double) tangent1.Y * (double) num6 + (double) tangent2.Y * (double) num7);
      result.Z = (float) ((double) value1.Z * (double) num4 + (double) value2.Z * (double) num5 + (double) tangent1.Z * (double) num6 + (double) tangent2.Z * (double) num7);
    }

    public static Vector3 Transform(Vector3 position, Matrix matrix)
    {
      float num1 = (float) ((double) position.X * (double) matrix.M11 + (double) position.Y * (double) matrix.M21 + (double) position.Z * (double) matrix.M31) + matrix.M41;
      float num2 = (float) ((double) position.X * (double) matrix.M12 + (double) position.Y * (double) matrix.M22 + (double) position.Z * (double) matrix.M32) + matrix.M42;
      float num3 = (float) ((double) position.X * (double) matrix.M13 + (double) position.Y * (double) matrix.M23 + (double) position.Z * (double) matrix.M33) + matrix.M43;
      Vector3 vector3;
      vector3.X = num1;
      vector3.Y = num2;
      vector3.Z = num3;
      return vector3;
    }

    public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector3 result)
    {
      float num1 = (float) ((double) position.X * (double) matrix.M11 + (double) position.Y * (double) matrix.M21 + (double) position.Z * (double) matrix.M31) + matrix.M41;
      float num2 = (float) ((double) position.X * (double) matrix.M12 + (double) position.Y * (double) matrix.M22 + (double) position.Z * (double) matrix.M32) + matrix.M42;
      float num3 = (float) ((double) position.X * (double) matrix.M13 + (double) position.Y * (double) matrix.M23 + (double) position.Z * (double) matrix.M33) + matrix.M43;
      result.X = num1;
      result.Y = num2;
      result.Z = num3;
    }

    public static Vector3 TransformNormal(Vector3 normal, Matrix matrix)
    {
      float num1 = (float) ((double) normal.X * (double) matrix.M11 + (double) normal.Y * (double) matrix.M21 + (double) normal.Z * (double) matrix.M31);
      float num2 = (float) ((double) normal.X * (double) matrix.M12 + (double) normal.Y * (double) matrix.M22 + (double) normal.Z * (double) matrix.M32);
      float num3 = (float) ((double) normal.X * (double) matrix.M13 + (double) normal.Y * (double) matrix.M23 + (double) normal.Z * (double) matrix.M33);
      Vector3 vector3;
      vector3.X = num1;
      vector3.Y = num2;
      vector3.Z = num3;
      return vector3;
    }

    public static void TransformNormal(ref Vector3 normal, ref Matrix matrix, out Vector3 result)
    {
      float num1 = (float) ((double) normal.X * (double) matrix.M11 + (double) normal.Y * (double) matrix.M21 + (double) normal.Z * (double) matrix.M31);
      float num2 = (float) ((double) normal.X * (double) matrix.M12 + (double) normal.Y * (double) matrix.M22 + (double) normal.Z * (double) matrix.M32);
      float num3 = (float) ((double) normal.X * (double) matrix.M13 + (double) normal.Y * (double) matrix.M23 + (double) normal.Z * (double) matrix.M33);
      result.X = num1;
      result.Y = num2;
      result.Z = num3;
    }

    public static Vector3 Transform(Vector3 value, Quaternion rotation)
    {
      float num1 = rotation.X + rotation.X;
      float num2 = rotation.Y + rotation.Y;
      float num3 = rotation.Z + rotation.Z;
      float num4 = rotation.W * num1;
      float num5 = rotation.W * num2;
      float num6 = rotation.W * num3;
      float num7 = rotation.X * num1;
      float num8 = rotation.X * num2;
      float num9 = rotation.X * num3;
      float num10 = rotation.Y * num2;
      float num11 = rotation.Y * num3;
      float num12 = rotation.Z * num3;
      float num13 = (float) ((double) value.X * (1.0 - (double) num10 - (double) num12) + (double) value.Y * ((double) num8 - (double) num6) + (double) value.Z * ((double) num9 + (double) num5));
      float num14 = (float) ((double) value.X * ((double) num8 + (double) num6) + (double) value.Y * (1.0 - (double) num7 - (double) num12) + (double) value.Z * ((double) num11 - (double) num4));
      float num15 = (float) ((double) value.X * ((double) num9 - (double) num5) + (double) value.Y * ((double) num11 + (double) num4) + (double) value.Z * (1.0 - (double) num7 - (double) num10));
      Vector3 vector3;
      vector3.X = num13;
      vector3.Y = num14;
      vector3.Z = num15;
      return vector3;
    }

    public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector3 result)
    {
      float num1 = rotation.X + rotation.X;
      float num2 = rotation.Y + rotation.Y;
      float num3 = rotation.Z + rotation.Z;
      float num4 = rotation.W * num1;
      float num5 = rotation.W * num2;
      float num6 = rotation.W * num3;
      float num7 = rotation.X * num1;
      float num8 = rotation.X * num2;
      float num9 = rotation.X * num3;
      float num10 = rotation.Y * num2;
      float num11 = rotation.Y * num3;
      float num12 = rotation.Z * num3;
      float num13 = (float) ((double) value.X * (1.0 - (double) num10 - (double) num12) + (double) value.Y * ((double) num8 - (double) num6) + (double) value.Z * ((double) num9 + (double) num5));
      float num14 = (float) ((double) value.X * ((double) num8 + (double) num6) + (double) value.Y * (1.0 - (double) num7 - (double) num12) + (double) value.Z * ((double) num11 - (double) num4));
      float num15 = (float) ((double) value.X * ((double) num9 - (double) num5) + (double) value.Y * ((double) num11 + (double) num4) + (double) value.Z * (1.0 - (double) num7 - (double) num10));
      result.X = num13;
      result.Y = num14;
      result.Z = num15;
    }

    public static void Transform(
      Vector3[] sourceArray,
      ref Matrix matrix,
      Vector3[] destinationArray)
    {
      if (sourceArray == null)
        throw new ArgumentNullException(nameof (sourceArray));
      if (destinationArray == null)
        throw new ArgumentNullException(nameof (destinationArray));
      if (destinationArray.Length < sourceArray.Length)
        throw new ArgumentException(FrameworkResources.NotEnoughTargetSize);
      for (int index = 0; index < sourceArray.Length; ++index)
      {
        float x = sourceArray[index].X;
        float y = sourceArray[index].Y;
        float z = sourceArray[index].Z;
        destinationArray[index].X = (float) ((double) x * (double) matrix.M11 + (double) y * (double) matrix.M21 + (double) z * (double) matrix.M31) + matrix.M41;
        destinationArray[index].Y = (float) ((double) x * (double) matrix.M12 + (double) y * (double) matrix.M22 + (double) z * (double) matrix.M32) + matrix.M42;
        destinationArray[index].Z = (float) ((double) x * (double) matrix.M13 + (double) y * (double) matrix.M23 + (double) z * (double) matrix.M33) + matrix.M43;
      }
    }

    [SuppressMessage("Microsoft.Usage", "CA2233")]
    public static void Transform(
      Vector3[] sourceArray,
      int sourceIndex,
      ref Matrix matrix,
      Vector3[] destinationArray,
      int destinationIndex,
      int length)
    {
      if (sourceArray == null)
        throw new ArgumentNullException(nameof (sourceArray));
      if (destinationArray == null)
        throw new ArgumentNullException(nameof (destinationArray));
      if ((long) sourceArray.Length < (long) sourceIndex + (long) length)
        throw new ArgumentException(FrameworkResources.NotEnoughSourceSize);
      if ((long) destinationArray.Length < (long) destinationIndex + (long) length)
        throw new ArgumentException(FrameworkResources.NotEnoughTargetSize);
      for (; length > 0; --length)
      {
        float x = sourceArray[sourceIndex].X;
        float y = sourceArray[sourceIndex].Y;
        float z = sourceArray[sourceIndex].Z;
        destinationArray[destinationIndex].X = (float) ((double) x * (double) matrix.M11 + (double) y * (double) matrix.M21 + (double) z * (double) matrix.M31) + matrix.M41;
        destinationArray[destinationIndex].Y = (float) ((double) x * (double) matrix.M12 + (double) y * (double) matrix.M22 + (double) z * (double) matrix.M32) + matrix.M42;
        destinationArray[destinationIndex].Z = (float) ((double) x * (double) matrix.M13 + (double) y * (double) matrix.M23 + (double) z * (double) matrix.M33) + matrix.M43;
        ++sourceIndex;
        ++destinationIndex;
      }
    }

    public static void TransformNormal(
      Vector3[] sourceArray,
      ref Matrix matrix,
      Vector3[] destinationArray)
    {
      if (sourceArray == null)
        throw new ArgumentNullException(nameof (sourceArray));
      if (destinationArray == null)
        throw new ArgumentNullException(nameof (destinationArray));
      if (destinationArray.Length < sourceArray.Length)
        throw new ArgumentException(FrameworkResources.NotEnoughTargetSize);
      for (int index = 0; index < sourceArray.Length; ++index)
      {
        float x = sourceArray[index].X;
        float y = sourceArray[index].Y;
        float z = sourceArray[index].Z;
        destinationArray[index].X = (float) ((double) x * (double) matrix.M11 + (double) y * (double) matrix.M21 + (double) z * (double) matrix.M31);
        destinationArray[index].Y = (float) ((double) x * (double) matrix.M12 + (double) y * (double) matrix.M22 + (double) z * (double) matrix.M32);
        destinationArray[index].Z = (float) ((double) x * (double) matrix.M13 + (double) y * (double) matrix.M23 + (double) z * (double) matrix.M33);
      }
    }

    [SuppressMessage("Microsoft.Usage", "CA2233")]
    public static void TransformNormal(
      Vector3[] sourceArray,
      int sourceIndex,
      ref Matrix matrix,
      Vector3[] destinationArray,
      int destinationIndex,
      int length)
    {
      if (sourceArray == null)
        throw new ArgumentNullException(nameof (sourceArray));
      if (destinationArray == null)
        throw new ArgumentNullException(nameof (destinationArray));
      if ((long) sourceArray.Length < (long) sourceIndex + (long) length)
        throw new ArgumentException(FrameworkResources.NotEnoughSourceSize);
      if ((long) destinationArray.Length < (long) destinationIndex + (long) length)
        throw new ArgumentException(FrameworkResources.NotEnoughTargetSize);
      for (; length > 0; --length)
      {
        float x = sourceArray[sourceIndex].X;
        float y = sourceArray[sourceIndex].Y;
        float z = sourceArray[sourceIndex].Z;
        destinationArray[destinationIndex].X = (float) ((double) x * (double) matrix.M11 + (double) y * (double) matrix.M21 + (double) z * (double) matrix.M31);
        destinationArray[destinationIndex].Y = (float) ((double) x * (double) matrix.M12 + (double) y * (double) matrix.M22 + (double) z * (double) matrix.M32);
        destinationArray[destinationIndex].Z = (float) ((double) x * (double) matrix.M13 + (double) y * (double) matrix.M23 + (double) z * (double) matrix.M33);
        ++sourceIndex;
        ++destinationIndex;
      }
    }

    public static void Transform(
      Vector3[] sourceArray,
      ref Quaternion rotation,
      Vector3[] destinationArray)
    {
      if (sourceArray == null)
        throw new ArgumentNullException(nameof (sourceArray));
      if (destinationArray == null)
        throw new ArgumentNullException(nameof (destinationArray));
      if (destinationArray.Length < sourceArray.Length)
        throw new ArgumentException(FrameworkResources.NotEnoughTargetSize);
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
      for (int index = 0; index < sourceArray.Length; ++index)
      {
        float x = sourceArray[index].X;
        float y = sourceArray[index].Y;
        float z = sourceArray[index].Z;
        destinationArray[index].X = (float) ((double) x * (double) num13 + (double) y * (double) num14 + (double) z * (double) num15);
        destinationArray[index].Y = (float) ((double) x * (double) num16 + (double) y * (double) num17 + (double) z * (double) num18);
        destinationArray[index].Z = (float) ((double) x * (double) num19 + (double) y * (double) num20 + (double) z * (double) num21);
      }
    }

    [SuppressMessage("Microsoft.Usage", "CA2233")]
    public static void Transform(
      Vector3[] sourceArray,
      int sourceIndex,
      ref Quaternion rotation,
      Vector3[] destinationArray,
      int destinationIndex,
      int length)
    {
      if (sourceArray == null)
        throw new ArgumentNullException(nameof (sourceArray));
      if (destinationArray == null)
        throw new ArgumentNullException(nameof (destinationArray));
      if ((long) sourceArray.Length < (long) sourceIndex + (long) length)
        throw new ArgumentException(FrameworkResources.NotEnoughSourceSize);
      if ((long) destinationArray.Length < (long) destinationIndex + (long) length)
        throw new ArgumentException(FrameworkResources.NotEnoughTargetSize);
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
      for (; length > 0; --length)
      {
        float x = sourceArray[sourceIndex].X;
        float y = sourceArray[sourceIndex].Y;
        float z = sourceArray[sourceIndex].Z;
        destinationArray[destinationIndex].X = (float) ((double) x * (double) num13 + (double) y * (double) num14 + (double) z * (double) num15);
        destinationArray[destinationIndex].Y = (float) ((double) x * (double) num16 + (double) y * (double) num17 + (double) z * (double) num18);
        destinationArray[destinationIndex].Z = (float) ((double) x * (double) num19 + (double) y * (double) num20 + (double) z * (double) num21);
        ++sourceIndex;
        ++destinationIndex;
      }
    }

    public static Vector3 Negate(Vector3 value)
    {
      Vector3 vector3;
      vector3.X = -value.X;
      vector3.Y = -value.Y;
      vector3.Z = -value.Z;
      return vector3;
    }

    public static void Negate(ref Vector3 value, out Vector3 result)
    {
      result.X = -value.X;
      result.Y = -value.Y;
      result.Z = -value.Z;
    }

    public static Vector3 Add(Vector3 value1, Vector3 value2)
    {
      Vector3 vector3;
      vector3.X = value1.X + value2.X;
      vector3.Y = value1.Y + value2.Y;
      vector3.Z = value1.Z + value2.Z;
      return vector3;
    }

    public static void Add(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
    {
      result.X = value1.X + value2.X;
      result.Y = value1.Y + value2.Y;
      result.Z = value1.Z + value2.Z;
    }

    public static Vector3 Subtract(Vector3 value1, Vector3 value2)
    {
      Vector3 vector3;
      vector3.X = value1.X - value2.X;
      vector3.Y = value1.Y - value2.Y;
      vector3.Z = value1.Z - value2.Z;
      return vector3;
    }

    public static void Subtract(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
    {
      result.X = value1.X - value2.X;
      result.Y = value1.Y - value2.Y;
      result.Z = value1.Z - value2.Z;
    }

    public static Vector3 Multiply(Vector3 value1, Vector3 value2)
    {
      Vector3 vector3;
      vector3.X = value1.X * value2.X;
      vector3.Y = value1.Y * value2.Y;
      vector3.Z = value1.Z * value2.Z;
      return vector3;
    }

    public static void Multiply(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
    {
      result.X = value1.X * value2.X;
      result.Y = value1.Y * value2.Y;
      result.Z = value1.Z * value2.Z;
    }

    public static Vector3 Multiply(Vector3 value1, float scaleFactor)
    {
      Vector3 vector3;
      vector3.X = value1.X * scaleFactor;
      vector3.Y = value1.Y * scaleFactor;
      vector3.Z = value1.Z * scaleFactor;
      return vector3;
    }

    public static void Multiply(ref Vector3 value1, float scaleFactor, out Vector3 result)
    {
      result.X = value1.X * scaleFactor;
      result.Y = value1.Y * scaleFactor;
      result.Z = value1.Z * scaleFactor;
    }

    public static Vector3 Divide(Vector3 value1, Vector3 value2)
    {
      Vector3 vector3;
      vector3.X = value1.X / value2.X;
      vector3.Y = value1.Y / value2.Y;
      vector3.Z = value1.Z / value2.Z;
      return vector3;
    }

    public static void Divide(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
    {
      result.X = value1.X / value2.X;
      result.Y = value1.Y / value2.Y;
      result.Z = value1.Z / value2.Z;
    }

    public static Vector3 Divide(Vector3 value1, float value2)
    {
      float num = 1f / value2;
      Vector3 vector3;
      vector3.X = value1.X * num;
      vector3.Y = value1.Y * num;
      vector3.Z = value1.Z * num;
      return vector3;
    }

    public static void Divide(ref Vector3 value1, float value2, out Vector3 result)
    {
      float num = 1f / value2;
      result.X = value1.X * num;
      result.Y = value1.Y * num;
      result.Z = value1.Z * num;
    }

    public static Vector3 operator -(Vector3 value)
    {
      Vector3 vector3;
      vector3.X = -value.X;
      vector3.Y = -value.Y;
      vector3.Z = -value.Z;
      return vector3;
    }

    public static bool operator ==(Vector3 value1, Vector3 value2) => (double) value1.X == (double) value2.X && (double) value1.Y == (double) value2.Y && (double) value1.Z == (double) value2.Z;

    public static bool operator !=(Vector3 value1, Vector3 value2) => (double) value1.X != (double) value2.X || (double) value1.Y != (double) value2.Y || (double) value1.Z != (double) value2.Z;

    public static Vector3 operator +(Vector3 value1, Vector3 value2)
    {
      Vector3 vector3;
      vector3.X = value1.X + value2.X;
      vector3.Y = value1.Y + value2.Y;
      vector3.Z = value1.Z + value2.Z;
      return vector3;
    }

    public static Vector3 operator -(Vector3 value1, Vector3 value2)
    {
      Vector3 vector3;
      vector3.X = value1.X - value2.X;
      vector3.Y = value1.Y - value2.Y;
      vector3.Z = value1.Z - value2.Z;
      return vector3;
    }

    public static Vector3 operator *(Vector3 value1, Vector3 value2)
    {
      Vector3 vector3;
      vector3.X = value1.X * value2.X;
      vector3.Y = value1.Y * value2.Y;
      vector3.Z = value1.Z * value2.Z;
      return vector3;
    }

    public static Vector3 operator *(Vector3 value, float scaleFactor)
    {
      Vector3 vector3;
      vector3.X = value.X * scaleFactor;
      vector3.Y = value.Y * scaleFactor;
      vector3.Z = value.Z * scaleFactor;
      return vector3;
    }

    public static Vector3 operator *(float scaleFactor, Vector3 value)
    {
      Vector3 vector3;
      vector3.X = value.X * scaleFactor;
      vector3.Y = value.Y * scaleFactor;
      vector3.Z = value.Z * scaleFactor;
      return vector3;
    }

    public static Vector3 operator /(Vector3 value1, Vector3 value2)
    {
      Vector3 vector3;
      vector3.X = value1.X / value2.X;
      vector3.Y = value1.Y / value2.Y;
      vector3.Z = value1.Z / value2.Z;
      return vector3;
    }

    public static Vector3 operator /(Vector3 value, float divider)
    {
      float num = 1f / divider;
      Vector3 vector3;
      vector3.X = value.X * num;
      vector3.Y = value.Y * num;
      vector3.Z = value.Z * num;
      return vector3;
    }
  }
}
