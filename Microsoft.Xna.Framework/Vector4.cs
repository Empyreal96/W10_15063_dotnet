// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Vector4
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
  public struct Vector4 : IEquatable<Vector4>
  {
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float X;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float Y;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float Z;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float W;

    public static Vector4 Zero => new Vector4();

    public static Vector4 One => new Vector4(1f, 1f, 1f, 1f);

    public static Vector4 UnitX => new Vector4(1f, 0.0f, 0.0f, 0.0f);

    public static Vector4 UnitY => new Vector4(0.0f, 1f, 0.0f, 0.0f);

    public static Vector4 UnitZ => new Vector4(0.0f, 0.0f, 1f, 0.0f);

    public static Vector4 UnitW => new Vector4(0.0f, 0.0f, 0.0f, 1f);

    public Vector4(float x, float y, float z, float w)
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
      this.W = w;
    }

    public Vector4(Vector2 value, float z, float w)
    {
      this.X = value.X;
      this.Y = value.Y;
      this.Z = z;
      this.W = w;
    }

    public Vector4(Vector3 value, float w)
    {
      this.X = value.X;
      this.Y = value.Y;
      this.Z = value.Z;
      this.W = w;
    }

    public Vector4(float value) => this.X = this.Y = this.Z = this.W = value;

    public override string ToString()
    {
      CultureInfo currentCulture = CultureInfo.CurrentCulture;
      return string.Format((IFormatProvider) currentCulture, "{{X:{0} Y:{1} Z:{2} W:{3}}}", (object) this.X.ToString((IFormatProvider) currentCulture), (object) this.Y.ToString((IFormatProvider) currentCulture), (object) this.Z.ToString((IFormatProvider) currentCulture), (object) this.W.ToString((IFormatProvider) currentCulture));
    }

    public bool Equals(Vector4 other) => (double) this.X == (double) other.X && (double) this.Y == (double) other.Y && (double) this.Z == (double) other.Z && (double) this.W == (double) other.W;

    public override bool Equals(object obj)
    {
      bool flag = false;
      if (obj is Vector4 other)
        flag = this.Equals(other);
      return flag;
    }

    public override int GetHashCode() => this.X.GetHashCode() + this.Y.GetHashCode() + this.Z.GetHashCode() + this.W.GetHashCode();

    public float Length() => (float) Math.Sqrt((double) this.X * (double) this.X + (double) this.Y * (double) this.Y + (double) this.Z * (double) this.Z + (double) this.W * (double) this.W);

    public float LengthSquared() => (float) ((double) this.X * (double) this.X + (double) this.Y * (double) this.Y + (double) this.Z * (double) this.Z + (double) this.W * (double) this.W);

    public static float Distance(Vector4 value1, Vector4 value2)
    {
      double num1 = (double) value1.X - (double) value2.X;
      float num2 = value1.Y - value2.Y;
      float num3 = value1.Z - value2.Z;
      float num4 = value1.W - value2.W;
      double num5 = num1 * num1;
      double num6 = (double) num2;
      double num7 = num6 * num6;
      double num8 = num5 + num7;
      double num9 = (double) num3;
      double num10 = num9 * num9;
      double num11 = num8 + num10;
      double num12 = (double) num4;
      double num13 = num12 * num12;
      return (float) Math.Sqrt(num11 + num13);
    }

    public static void Distance(ref Vector4 value1, ref Vector4 value2, out float result)
    {
      double num1 = (double) value1.X - (double) value2.X;
      float num2 = value1.Y - value2.Y;
      float num3 = value1.Z - value2.Z;
      float num4 = value1.W - value2.W;
      double num5 = num1 * num1;
      double num6 = (double) num2;
      double num7 = num6 * num6;
      double num8 = num5 + num7;
      double num9 = (double) num3;
      double num10 = num9 * num9;
      double num11 = num8 + num10;
      double num12 = (double) num4;
      double num13 = num12 * num12;
      float num14 = (float) (num11 + num13);
      result = (float) Math.Sqrt((double) num14);
    }

    public static float DistanceSquared(Vector4 value1, Vector4 value2)
    {
      double num1 = (double) value1.X - (double) value2.X;
      float num2 = value1.Y - value2.Y;
      float num3 = value1.Z - value2.Z;
      float num4 = value1.W - value2.W;
      double num5 = num1 * num1;
      double num6 = (double) num2;
      double num7 = num6 * num6;
      double num8 = num5 + num7;
      double num9 = (double) num3;
      double num10 = num9 * num9;
      double num11 = num8 + num10;
      double num12 = (double) num4;
      double num13 = num12 * num12;
      return (float) (num11 + num13);
    }

    public static void DistanceSquared(ref Vector4 value1, ref Vector4 value2, out float result)
    {
      float num1 = value1.X - value2.X;
      float num2 = value1.Y - value2.Y;
      float num3 = value1.Z - value2.Z;
      float num4 = value1.W - value2.W;
      ref float local = ref result;
      double num5 = (double) num1;
      double num6 = num5 * num5;
      double num7 = (double) num2;
      double num8 = num7 * num7;
      double num9 = num6 + num8;
      double num10 = (double) num3;
      double num11 = num10 * num10;
      double num12 = num9 + num11;
      double num13 = (double) num4;
      double num14 = num13 * num13;
      double num15 = num12 + num14;
      local = (float) num15;
    }

    public static float Dot(Vector4 vector1, Vector4 vector2) => (float) ((double) vector1.X * (double) vector2.X + (double) vector1.Y * (double) vector2.Y + (double) vector1.Z * (double) vector2.Z + (double) vector1.W * (double) vector2.W);

    public static void Dot(ref Vector4 vector1, ref Vector4 vector2, out float result) => result = (float) ((double) vector1.X * (double) vector2.X + (double) vector1.Y * (double) vector2.Y + (double) vector1.Z * (double) vector2.Z + (double) vector1.W * (double) vector2.W);

    public void Normalize()
    {
      float num = 1f / (float) Math.Sqrt((double) this.X * (double) this.X + (double) this.Y * (double) this.Y + (double) this.Z * (double) this.Z + (double) this.W * (double) this.W);
      this.X *= num;
      this.Y *= num;
      this.Z *= num;
      this.W *= num;
    }

    public static Vector4 Normalize(Vector4 vector)
    {
      float num = 1f / (float) Math.Sqrt((double) vector.X * (double) vector.X + (double) vector.Y * (double) vector.Y + (double) vector.Z * (double) vector.Z + (double) vector.W * (double) vector.W);
      Vector4 vector4;
      vector4.X = vector.X * num;
      vector4.Y = vector.Y * num;
      vector4.Z = vector.Z * num;
      vector4.W = vector.W * num;
      return vector4;
    }

    public static void Normalize(ref Vector4 vector, out Vector4 result)
    {
      float num = 1f / (float) Math.Sqrt((double) vector.X * (double) vector.X + (double) vector.Y * (double) vector.Y + (double) vector.Z * (double) vector.Z + (double) vector.W * (double) vector.W);
      result.X = vector.X * num;
      result.Y = vector.Y * num;
      result.Z = vector.Z * num;
      result.W = vector.W * num;
    }

    public static Vector4 Min(Vector4 value1, Vector4 value2)
    {
      Vector4 vector4;
      vector4.X = (double) value1.X < (double) value2.X ? value1.X : value2.X;
      vector4.Y = (double) value1.Y < (double) value2.Y ? value1.Y : value2.Y;
      vector4.Z = (double) value1.Z < (double) value2.Z ? value1.Z : value2.Z;
      vector4.W = (double) value1.W < (double) value2.W ? value1.W : value2.W;
      return vector4;
    }

    public static void Min(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
    {
      result.X = (double) value1.X < (double) value2.X ? value1.X : value2.X;
      result.Y = (double) value1.Y < (double) value2.Y ? value1.Y : value2.Y;
      result.Z = (double) value1.Z < (double) value2.Z ? value1.Z : value2.Z;
      result.W = (double) value1.W < (double) value2.W ? value1.W : value2.W;
    }

    public static Vector4 Max(Vector4 value1, Vector4 value2)
    {
      Vector4 vector4;
      vector4.X = (double) value1.X > (double) value2.X ? value1.X : value2.X;
      vector4.Y = (double) value1.Y > (double) value2.Y ? value1.Y : value2.Y;
      vector4.Z = (double) value1.Z > (double) value2.Z ? value1.Z : value2.Z;
      vector4.W = (double) value1.W > (double) value2.W ? value1.W : value2.W;
      return vector4;
    }

    public static void Max(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
    {
      result.X = (double) value1.X > (double) value2.X ? value1.X : value2.X;
      result.Y = (double) value1.Y > (double) value2.Y ? value1.Y : value2.Y;
      result.Z = (double) value1.Z > (double) value2.Z ? value1.Z : value2.Z;
      result.W = (double) value1.W > (double) value2.W ? value1.W : value2.W;
    }

    public static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max)
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
      float w = value1.W;
      float num7 = (double) w > (double) max.W ? max.W : w;
      float num8 = (double) num7 < (double) min.W ? min.W : num7;
      Vector4 vector4;
      vector4.X = num2;
      vector4.Y = num4;
      vector4.Z = num6;
      vector4.W = num8;
      return vector4;
    }

    public static void Clamp(
      ref Vector4 value1,
      ref Vector4 min,
      ref Vector4 max,
      out Vector4 result)
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
      float w = value1.W;
      float num7 = (double) w > (double) max.W ? max.W : w;
      float num8 = (double) num7 < (double) min.W ? min.W : num7;
      result.X = num2;
      result.Y = num4;
      result.Z = num6;
      result.W = num8;
    }

    public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount)
    {
      Vector4 vector4;
      vector4.X = value1.X + (value2.X - value1.X) * amount;
      vector4.Y = value1.Y + (value2.Y - value1.Y) * amount;
      vector4.Z = value1.Z + (value2.Z - value1.Z) * amount;
      vector4.W = value1.W + (value2.W - value1.W) * amount;
      return vector4;
    }

    public static void Lerp(
      ref Vector4 value1,
      ref Vector4 value2,
      float amount,
      out Vector4 result)
    {
      result.X = value1.X + (value2.X - value1.X) * amount;
      result.Y = value1.Y + (value2.Y - value1.Y) * amount;
      result.Z = value1.Z + (value2.Z - value1.Z) * amount;
      result.W = value1.W + (value2.W - value1.W) * amount;
    }

    public static Vector4 Barycentric(
      Vector4 value1,
      Vector4 value2,
      Vector4 value3,
      float amount1,
      float amount2)
    {
      Vector4 vector4;
      vector4.X = (float) ((double) value1.X + (double) amount1 * ((double) value2.X - (double) value1.X) + (double) amount2 * ((double) value3.X - (double) value1.X));
      vector4.Y = (float) ((double) value1.Y + (double) amount1 * ((double) value2.Y - (double) value1.Y) + (double) amount2 * ((double) value3.Y - (double) value1.Y));
      vector4.Z = (float) ((double) value1.Z + (double) amount1 * ((double) value2.Z - (double) value1.Z) + (double) amount2 * ((double) value3.Z - (double) value1.Z));
      vector4.W = (float) ((double) value1.W + (double) amount1 * ((double) value2.W - (double) value1.W) + (double) amount2 * ((double) value3.W - (double) value1.W));
      return vector4;
    }

    public static void Barycentric(
      ref Vector4 value1,
      ref Vector4 value2,
      ref Vector4 value3,
      float amount1,
      float amount2,
      out Vector4 result)
    {
      result.X = (float) ((double) value1.X + (double) amount1 * ((double) value2.X - (double) value1.X) + (double) amount2 * ((double) value3.X - (double) value1.X));
      result.Y = (float) ((double) value1.Y + (double) amount1 * ((double) value2.Y - (double) value1.Y) + (double) amount2 * ((double) value3.Y - (double) value1.Y));
      result.Z = (float) ((double) value1.Z + (double) amount1 * ((double) value2.Z - (double) value1.Z) + (double) amount2 * ((double) value3.Z - (double) value1.Z));
      result.W = (float) ((double) value1.W + (double) amount1 * ((double) value2.W - (double) value1.W) + (double) amount2 * ((double) value3.W - (double) value1.W));
    }

    public static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount)
    {
      amount = (double) amount > 1.0 ? 1f : ((double) amount < 0.0 ? 0.0f : amount);
      double num = (double) amount;
      amount = (float) (num * num * (3.0 - 2.0 * (double) amount));
      Vector4 vector4;
      vector4.X = value1.X + (value2.X - value1.X) * amount;
      vector4.Y = value1.Y + (value2.Y - value1.Y) * amount;
      vector4.Z = value1.Z + (value2.Z - value1.Z) * amount;
      vector4.W = value1.W + (value2.W - value1.W) * amount;
      return vector4;
    }

    public static void SmoothStep(
      ref Vector4 value1,
      ref Vector4 value2,
      float amount,
      out Vector4 result)
    {
      amount = (double) amount > 1.0 ? 1f : ((double) amount < 0.0 ? 0.0f : amount);
      double num = (double) amount;
      amount = (float) (num * num * (3.0 - 2.0 * (double) amount));
      result.X = value1.X + (value2.X - value1.X) * amount;
      result.Y = value1.Y + (value2.Y - value1.Y) * amount;
      result.Z = value1.Z + (value2.Z - value1.Z) * amount;
      result.W = value1.W + (value2.W - value1.W) * amount;
    }

    public static Vector4 CatmullRom(
      Vector4 value1,
      Vector4 value2,
      Vector4 value3,
      Vector4 value4,
      float amount)
    {
      double num1 = (double) amount;
      float num2 = (float) (num1 * num1);
      float num3 = amount * num2;
      Vector4 vector4;
      vector4.X = (float) (0.5 * (2.0 * (double) value2.X + (-(double) value1.X + (double) value3.X) * (double) amount + (2.0 * (double) value1.X - 5.0 * (double) value2.X + 4.0 * (double) value3.X - (double) value4.X) * (double) num2 + (-(double) value1.X + 3.0 * (double) value2.X - 3.0 * (double) value3.X + (double) value4.X) * (double) num3));
      vector4.Y = (float) (0.5 * (2.0 * (double) value2.Y + (-(double) value1.Y + (double) value3.Y) * (double) amount + (2.0 * (double) value1.Y - 5.0 * (double) value2.Y + 4.0 * (double) value3.Y - (double) value4.Y) * (double) num2 + (-(double) value1.Y + 3.0 * (double) value2.Y - 3.0 * (double) value3.Y + (double) value4.Y) * (double) num3));
      vector4.Z = (float) (0.5 * (2.0 * (double) value2.Z + (-(double) value1.Z + (double) value3.Z) * (double) amount + (2.0 * (double) value1.Z - 5.0 * (double) value2.Z + 4.0 * (double) value3.Z - (double) value4.Z) * (double) num2 + (-(double) value1.Z + 3.0 * (double) value2.Z - 3.0 * (double) value3.Z + (double) value4.Z) * (double) num3));
      vector4.W = (float) (0.5 * (2.0 * (double) value2.W + (-(double) value1.W + (double) value3.W) * (double) amount + (2.0 * (double) value1.W - 5.0 * (double) value2.W + 4.0 * (double) value3.W - (double) value4.W) * (double) num2 + (-(double) value1.W + 3.0 * (double) value2.W - 3.0 * (double) value3.W + (double) value4.W) * (double) num3));
      return vector4;
    }

    public static void CatmullRom(
      ref Vector4 value1,
      ref Vector4 value2,
      ref Vector4 value3,
      ref Vector4 value4,
      float amount,
      out Vector4 result)
    {
      double num1 = (double) amount;
      float num2 = (float) (num1 * num1);
      float num3 = amount * num2;
      result.X = (float) (0.5 * (2.0 * (double) value2.X + (-(double) value1.X + (double) value3.X) * (double) amount + (2.0 * (double) value1.X - 5.0 * (double) value2.X + 4.0 * (double) value3.X - (double) value4.X) * (double) num2 + (-(double) value1.X + 3.0 * (double) value2.X - 3.0 * (double) value3.X + (double) value4.X) * (double) num3));
      result.Y = (float) (0.5 * (2.0 * (double) value2.Y + (-(double) value1.Y + (double) value3.Y) * (double) amount + (2.0 * (double) value1.Y - 5.0 * (double) value2.Y + 4.0 * (double) value3.Y - (double) value4.Y) * (double) num2 + (-(double) value1.Y + 3.0 * (double) value2.Y - 3.0 * (double) value3.Y + (double) value4.Y) * (double) num3));
      result.Z = (float) (0.5 * (2.0 * (double) value2.Z + (-(double) value1.Z + (double) value3.Z) * (double) amount + (2.0 * (double) value1.Z - 5.0 * (double) value2.Z + 4.0 * (double) value3.Z - (double) value4.Z) * (double) num2 + (-(double) value1.Z + 3.0 * (double) value2.Z - 3.0 * (double) value3.Z + (double) value4.Z) * (double) num3));
      result.W = (float) (0.5 * (2.0 * (double) value2.W + (-(double) value1.W + (double) value3.W) * (double) amount + (2.0 * (double) value1.W - 5.0 * (double) value2.W + 4.0 * (double) value3.W - (double) value4.W) * (double) num2 + (-(double) value1.W + 3.0 * (double) value2.W - 3.0 * (double) value3.W + (double) value4.W) * (double) num3));
    }

    public static Vector4 Hermite(
      Vector4 value1,
      Vector4 tangent1,
      Vector4 value2,
      Vector4 tangent2,
      float amount)
    {
      double num1 = (double) amount;
      float num2 = (float) (num1 * num1);
      float num3 = amount * num2;
      float num4 = (float) (2.0 * (double) num3 - 3.0 * (double) num2 + 1.0);
      float num5 = (float) (-2.0 * (double) num3 + 3.0 * (double) num2);
      float num6 = num3 - 2f * num2 + amount;
      float num7 = num3 - num2;
      Vector4 vector4;
      vector4.X = (float) ((double) value1.X * (double) num4 + (double) value2.X * (double) num5 + (double) tangent1.X * (double) num6 + (double) tangent2.X * (double) num7);
      vector4.Y = (float) ((double) value1.Y * (double) num4 + (double) value2.Y * (double) num5 + (double) tangent1.Y * (double) num6 + (double) tangent2.Y * (double) num7);
      vector4.Z = (float) ((double) value1.Z * (double) num4 + (double) value2.Z * (double) num5 + (double) tangent1.Z * (double) num6 + (double) tangent2.Z * (double) num7);
      vector4.W = (float) ((double) value1.W * (double) num4 + (double) value2.W * (double) num5 + (double) tangent1.W * (double) num6 + (double) tangent2.W * (double) num7);
      return vector4;
    }

    public static void Hermite(
      ref Vector4 value1,
      ref Vector4 tangent1,
      ref Vector4 value2,
      ref Vector4 tangent2,
      float amount,
      out Vector4 result)
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
      result.W = (float) ((double) value1.W * (double) num4 + (double) value2.W * (double) num5 + (double) tangent1.W * (double) num6 + (double) tangent2.W * (double) num7);
    }

    public static Vector4 Transform(Vector2 position, Matrix matrix)
    {
      float num1 = (float) ((double) position.X * (double) matrix.M11 + (double) position.Y * (double) matrix.M21) + matrix.M41;
      float num2 = (float) ((double) position.X * (double) matrix.M12 + (double) position.Y * (double) matrix.M22) + matrix.M42;
      float num3 = (float) ((double) position.X * (double) matrix.M13 + (double) position.Y * (double) matrix.M23) + matrix.M43;
      float num4 = (float) ((double) position.X * (double) matrix.M14 + (double) position.Y * (double) matrix.M24) + matrix.M44;
      Vector4 vector4;
      vector4.X = num1;
      vector4.Y = num2;
      vector4.Z = num3;
      vector4.W = num4;
      return vector4;
    }

    public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector4 result)
    {
      float num1 = (float) ((double) position.X * (double) matrix.M11 + (double) position.Y * (double) matrix.M21) + matrix.M41;
      float num2 = (float) ((double) position.X * (double) matrix.M12 + (double) position.Y * (double) matrix.M22) + matrix.M42;
      float num3 = (float) ((double) position.X * (double) matrix.M13 + (double) position.Y * (double) matrix.M23) + matrix.M43;
      float num4 = (float) ((double) position.X * (double) matrix.M14 + (double) position.Y * (double) matrix.M24) + matrix.M44;
      result.X = num1;
      result.Y = num2;
      result.Z = num3;
      result.W = num4;
    }

    public static Vector4 Transform(Vector3 position, Matrix matrix)
    {
      float num1 = (float) ((double) position.X * (double) matrix.M11 + (double) position.Y * (double) matrix.M21 + (double) position.Z * (double) matrix.M31) + matrix.M41;
      float num2 = (float) ((double) position.X * (double) matrix.M12 + (double) position.Y * (double) matrix.M22 + (double) position.Z * (double) matrix.M32) + matrix.M42;
      float num3 = (float) ((double) position.X * (double) matrix.M13 + (double) position.Y * (double) matrix.M23 + (double) position.Z * (double) matrix.M33) + matrix.M43;
      float num4 = (float) ((double) position.X * (double) matrix.M14 + (double) position.Y * (double) matrix.M24 + (double) position.Z * (double) matrix.M34) + matrix.M44;
      Vector4 vector4;
      vector4.X = num1;
      vector4.Y = num2;
      vector4.Z = num3;
      vector4.W = num4;
      return vector4;
    }

    public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector4 result)
    {
      float num1 = (float) ((double) position.X * (double) matrix.M11 + (double) position.Y * (double) matrix.M21 + (double) position.Z * (double) matrix.M31) + matrix.M41;
      float num2 = (float) ((double) position.X * (double) matrix.M12 + (double) position.Y * (double) matrix.M22 + (double) position.Z * (double) matrix.M32) + matrix.M42;
      float num3 = (float) ((double) position.X * (double) matrix.M13 + (double) position.Y * (double) matrix.M23 + (double) position.Z * (double) matrix.M33) + matrix.M43;
      float num4 = (float) ((double) position.X * (double) matrix.M14 + (double) position.Y * (double) matrix.M24 + (double) position.Z * (double) matrix.M34) + matrix.M44;
      result.X = num1;
      result.Y = num2;
      result.Z = num3;
      result.W = num4;
    }

    public static Vector4 Transform(Vector4 vector, Matrix matrix)
    {
      float num1 = (float) ((double) vector.X * (double) matrix.M11 + (double) vector.Y * (double) matrix.M21 + (double) vector.Z * (double) matrix.M31 + (double) vector.W * (double) matrix.M41);
      float num2 = (float) ((double) vector.X * (double) matrix.M12 + (double) vector.Y * (double) matrix.M22 + (double) vector.Z * (double) matrix.M32 + (double) vector.W * (double) matrix.M42);
      float num3 = (float) ((double) vector.X * (double) matrix.M13 + (double) vector.Y * (double) matrix.M23 + (double) vector.Z * (double) matrix.M33 + (double) vector.W * (double) matrix.M43);
      float num4 = (float) ((double) vector.X * (double) matrix.M14 + (double) vector.Y * (double) matrix.M24 + (double) vector.Z * (double) matrix.M34 + (double) vector.W * (double) matrix.M44);
      Vector4 vector4;
      vector4.X = num1;
      vector4.Y = num2;
      vector4.Z = num3;
      vector4.W = num4;
      return vector4;
    }

    public static void Transform(ref Vector4 vector, ref Matrix matrix, out Vector4 result)
    {
      float num1 = (float) ((double) vector.X * (double) matrix.M11 + (double) vector.Y * (double) matrix.M21 + (double) vector.Z * (double) matrix.M31 + (double) vector.W * (double) matrix.M41);
      float num2 = (float) ((double) vector.X * (double) matrix.M12 + (double) vector.Y * (double) matrix.M22 + (double) vector.Z * (double) matrix.M32 + (double) vector.W * (double) matrix.M42);
      float num3 = (float) ((double) vector.X * (double) matrix.M13 + (double) vector.Y * (double) matrix.M23 + (double) vector.Z * (double) matrix.M33 + (double) vector.W * (double) matrix.M43);
      float num4 = (float) ((double) vector.X * (double) matrix.M14 + (double) vector.Y * (double) matrix.M24 + (double) vector.Z * (double) matrix.M34 + (double) vector.W * (double) matrix.M44);
      result.X = num1;
      result.Y = num2;
      result.Z = num3;
      result.W = num4;
    }

    public static Vector4 Transform(Vector2 value, Quaternion rotation)
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
      float num13 = (float) ((double) value.X * (1.0 - (double) num10 - (double) num12) + (double) value.Y * ((double) num8 - (double) num6));
      float num14 = (float) ((double) value.X * ((double) num8 + (double) num6) + (double) value.Y * (1.0 - (double) num7 - (double) num12));
      float num15 = (float) ((double) value.X * ((double) num9 - (double) num5) + (double) value.Y * ((double) num11 + (double) num4));
      Vector4 vector4;
      vector4.X = num13;
      vector4.Y = num14;
      vector4.Z = num15;
      vector4.W = 1f;
      return vector4;
    }

    public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector4 result)
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
      float num13 = (float) ((double) value.X * (1.0 - (double) num10 - (double) num12) + (double) value.Y * ((double) num8 - (double) num6));
      float num14 = (float) ((double) value.X * ((double) num8 + (double) num6) + (double) value.Y * (1.0 - (double) num7 - (double) num12));
      float num15 = (float) ((double) value.X * ((double) num9 - (double) num5) + (double) value.Y * ((double) num11 + (double) num4));
      result.X = num13;
      result.Y = num14;
      result.Z = num15;
      result.W = 1f;
    }

    public static Vector4 Transform(Vector3 value, Quaternion rotation)
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
      Vector4 vector4;
      vector4.X = num13;
      vector4.Y = num14;
      vector4.Z = num15;
      vector4.W = 1f;
      return vector4;
    }

    public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector4 result)
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
      result.W = 1f;
    }

    public static Vector4 Transform(Vector4 value, Quaternion rotation)
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
      Vector4 vector4;
      vector4.X = num13;
      vector4.Y = num14;
      vector4.Z = num15;
      vector4.W = value.W;
      return vector4;
    }

    public static void Transform(ref Vector4 value, ref Quaternion rotation, out Vector4 result)
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
      result.W = value.W;
    }

    public static void Transform(
      Vector4[] sourceArray,
      ref Matrix matrix,
      Vector4[] destinationArray)
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
        float w = sourceArray[index].W;
        destinationArray[index].X = (float) ((double) x * (double) matrix.M11 + (double) y * (double) matrix.M21 + (double) z * (double) matrix.M31 + (double) w * (double) matrix.M41);
        destinationArray[index].Y = (float) ((double) x * (double) matrix.M12 + (double) y * (double) matrix.M22 + (double) z * (double) matrix.M32 + (double) w * (double) matrix.M42);
        destinationArray[index].Z = (float) ((double) x * (double) matrix.M13 + (double) y * (double) matrix.M23 + (double) z * (double) matrix.M33 + (double) w * (double) matrix.M43);
        destinationArray[index].W = (float) ((double) x * (double) matrix.M14 + (double) y * (double) matrix.M24 + (double) z * (double) matrix.M34 + (double) w * (double) matrix.M44);
      }
    }

    [SuppressMessage("Microsoft.Usage", "CA2233")]
    public static void Transform(
      Vector4[] sourceArray,
      int sourceIndex,
      ref Matrix matrix,
      Vector4[] destinationArray,
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
        float w = sourceArray[sourceIndex].W;
        destinationArray[destinationIndex].X = (float) ((double) x * (double) matrix.M11 + (double) y * (double) matrix.M21 + (double) z * (double) matrix.M31 + (double) w * (double) matrix.M41);
        destinationArray[destinationIndex].Y = (float) ((double) x * (double) matrix.M12 + (double) y * (double) matrix.M22 + (double) z * (double) matrix.M32 + (double) w * (double) matrix.M42);
        destinationArray[destinationIndex].Z = (float) ((double) x * (double) matrix.M13 + (double) y * (double) matrix.M23 + (double) z * (double) matrix.M33 + (double) w * (double) matrix.M43);
        destinationArray[destinationIndex].W = (float) ((double) x * (double) matrix.M14 + (double) y * (double) matrix.M24 + (double) z * (double) matrix.M34 + (double) w * (double) matrix.M44);
        ++sourceIndex;
        ++destinationIndex;
      }
    }

    public static void Transform(
      Vector4[] sourceArray,
      ref Quaternion rotation,
      Vector4[] destinationArray)
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
        destinationArray[index].W = sourceArray[index].W;
      }
    }

    [SuppressMessage("Microsoft.Usage", "CA2233")]
    public static void Transform(
      Vector4[] sourceArray,
      int sourceIndex,
      ref Quaternion rotation,
      Vector4[] destinationArray,
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
        float w = sourceArray[sourceIndex].W;
        destinationArray[destinationIndex].X = (float) ((double) x * (double) num13 + (double) y * (double) num14 + (double) z * (double) num15);
        destinationArray[destinationIndex].Y = (float) ((double) x * (double) num16 + (double) y * (double) num17 + (double) z * (double) num18);
        destinationArray[destinationIndex].Z = (float) ((double) x * (double) num19 + (double) y * (double) num20 + (double) z * (double) num21);
        destinationArray[destinationIndex].W = w;
        ++sourceIndex;
        ++destinationIndex;
      }
    }

    public static Vector4 Negate(Vector4 value)
    {
      Vector4 vector4;
      vector4.X = -value.X;
      vector4.Y = -value.Y;
      vector4.Z = -value.Z;
      vector4.W = -value.W;
      return vector4;
    }

    public static void Negate(ref Vector4 value, out Vector4 result)
    {
      result.X = -value.X;
      result.Y = -value.Y;
      result.Z = -value.Z;
      result.W = -value.W;
    }

    public static Vector4 Add(Vector4 value1, Vector4 value2)
    {
      Vector4 vector4;
      vector4.X = value1.X + value2.X;
      vector4.Y = value1.Y + value2.Y;
      vector4.Z = value1.Z + value2.Z;
      vector4.W = value1.W + value2.W;
      return vector4;
    }

    public static void Add(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
    {
      result.X = value1.X + value2.X;
      result.Y = value1.Y + value2.Y;
      result.Z = value1.Z + value2.Z;
      result.W = value1.W + value2.W;
    }

    public static Vector4 Subtract(Vector4 value1, Vector4 value2)
    {
      Vector4 vector4;
      vector4.X = value1.X - value2.X;
      vector4.Y = value1.Y - value2.Y;
      vector4.Z = value1.Z - value2.Z;
      vector4.W = value1.W - value2.W;
      return vector4;
    }

    public static void Subtract(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
    {
      result.X = value1.X - value2.X;
      result.Y = value1.Y - value2.Y;
      result.Z = value1.Z - value2.Z;
      result.W = value1.W - value2.W;
    }

    public static Vector4 Multiply(Vector4 value1, Vector4 value2)
    {
      Vector4 vector4;
      vector4.X = value1.X * value2.X;
      vector4.Y = value1.Y * value2.Y;
      vector4.Z = value1.Z * value2.Z;
      vector4.W = value1.W * value2.W;
      return vector4;
    }

    public static void Multiply(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
    {
      result.X = value1.X * value2.X;
      result.Y = value1.Y * value2.Y;
      result.Z = value1.Z * value2.Z;
      result.W = value1.W * value2.W;
    }

    public static Vector4 Multiply(Vector4 value1, float scaleFactor)
    {
      Vector4 vector4;
      vector4.X = value1.X * scaleFactor;
      vector4.Y = value1.Y * scaleFactor;
      vector4.Z = value1.Z * scaleFactor;
      vector4.W = value1.W * scaleFactor;
      return vector4;
    }

    public static void Multiply(ref Vector4 value1, float scaleFactor, out Vector4 result)
    {
      result.X = value1.X * scaleFactor;
      result.Y = value1.Y * scaleFactor;
      result.Z = value1.Z * scaleFactor;
      result.W = value1.W * scaleFactor;
    }

    public static Vector4 Divide(Vector4 value1, Vector4 value2)
    {
      Vector4 vector4;
      vector4.X = value1.X / value2.X;
      vector4.Y = value1.Y / value2.Y;
      vector4.Z = value1.Z / value2.Z;
      vector4.W = value1.W / value2.W;
      return vector4;
    }

    public static void Divide(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
    {
      result.X = value1.X / value2.X;
      result.Y = value1.Y / value2.Y;
      result.Z = value1.Z / value2.Z;
      result.W = value1.W / value2.W;
    }

    public static Vector4 Divide(Vector4 value1, float divider)
    {
      float num = 1f / divider;
      Vector4 vector4;
      vector4.X = value1.X * num;
      vector4.Y = value1.Y * num;
      vector4.Z = value1.Z * num;
      vector4.W = value1.W * num;
      return vector4;
    }

    public static void Divide(ref Vector4 value1, float divider, out Vector4 result)
    {
      float num = 1f / divider;
      result.X = value1.X * num;
      result.Y = value1.Y * num;
      result.Z = value1.Z * num;
      result.W = value1.W * num;
    }

    public static Vector4 operator -(Vector4 value)
    {
      Vector4 vector4;
      vector4.X = -value.X;
      vector4.Y = -value.Y;
      vector4.Z = -value.Z;
      vector4.W = -value.W;
      return vector4;
    }

    public static bool operator ==(Vector4 value1, Vector4 value2) => (double) value1.X == (double) value2.X && (double) value1.Y == (double) value2.Y && (double) value1.Z == (double) value2.Z && (double) value1.W == (double) value2.W;

    public static bool operator !=(Vector4 value1, Vector4 value2) => (double) value1.X != (double) value2.X || (double) value1.Y != (double) value2.Y || (double) value1.Z != (double) value2.Z || (double) value1.W != (double) value2.W;

    public static Vector4 operator +(Vector4 value1, Vector4 value2)
    {
      Vector4 vector4;
      vector4.X = value1.X + value2.X;
      vector4.Y = value1.Y + value2.Y;
      vector4.Z = value1.Z + value2.Z;
      vector4.W = value1.W + value2.W;
      return vector4;
    }

    public static Vector4 operator -(Vector4 value1, Vector4 value2)
    {
      Vector4 vector4;
      vector4.X = value1.X - value2.X;
      vector4.Y = value1.Y - value2.Y;
      vector4.Z = value1.Z - value2.Z;
      vector4.W = value1.W - value2.W;
      return vector4;
    }

    public static Vector4 operator *(Vector4 value1, Vector4 value2)
    {
      Vector4 vector4;
      vector4.X = value1.X * value2.X;
      vector4.Y = value1.Y * value2.Y;
      vector4.Z = value1.Z * value2.Z;
      vector4.W = value1.W * value2.W;
      return vector4;
    }

    public static Vector4 operator *(Vector4 value1, float scaleFactor)
    {
      Vector4 vector4;
      vector4.X = value1.X * scaleFactor;
      vector4.Y = value1.Y * scaleFactor;
      vector4.Z = value1.Z * scaleFactor;
      vector4.W = value1.W * scaleFactor;
      return vector4;
    }

    public static Vector4 operator *(float scaleFactor, Vector4 value1)
    {
      Vector4 vector4;
      vector4.X = value1.X * scaleFactor;
      vector4.Y = value1.Y * scaleFactor;
      vector4.Z = value1.Z * scaleFactor;
      vector4.W = value1.W * scaleFactor;
      return vector4;
    }

    public static Vector4 operator /(Vector4 value1, Vector4 value2)
    {
      Vector4 vector4;
      vector4.X = value1.X / value2.X;
      vector4.Y = value1.Y / value2.Y;
      vector4.Z = value1.Z / value2.Z;
      vector4.W = value1.W / value2.W;
      return vector4;
    }

    public static Vector4 operator /(Vector4 value1, float divider)
    {
      float num = 1f / divider;
      Vector4 vector4;
      vector4.X = value1.X * num;
      vector4.Y = value1.Y * num;
      vector4.Z = value1.Z * num;
      vector4.W = value1.W * num;
      return vector4;
    }
  }
}
