// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Vector2
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
  public struct Vector2 : IEquatable<Vector2>
  {
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float X;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float Y;

    public static Vector2 Zero => new Vector2();

    public static Vector2 One => new Vector2(1f, 1f);

    public static Vector2 UnitX => new Vector2(1f, 0.0f);

    public static Vector2 UnitY => new Vector2(0.0f, 1f);

    public Vector2(float x, float y)
    {
      this.X = x;
      this.Y = y;
    }

    public Vector2(float value) => this.X = this.Y = value;

    public override string ToString()
    {
      CultureInfo currentCulture = CultureInfo.CurrentCulture;
      return string.Format((IFormatProvider) currentCulture, "{{X:{0} Y:{1}}}", (object) this.X.ToString((IFormatProvider) currentCulture), (object) this.Y.ToString((IFormatProvider) currentCulture));
    }

    public bool Equals(Vector2 other) => (double) this.X == (double) other.X && (double) this.Y == (double) other.Y;

    public override bool Equals(object obj)
    {
      bool flag = false;
      if (obj is Vector2 other)
        flag = this.Equals(other);
      return flag;
    }

    public override int GetHashCode() => this.X.GetHashCode() + this.Y.GetHashCode();

    public float Length() => (float) Math.Sqrt((double) this.X * (double) this.X + (double) this.Y * (double) this.Y);

    public float LengthSquared() => (float) ((double) this.X * (double) this.X + (double) this.Y * (double) this.Y);

    public static float Distance(Vector2 value1, Vector2 value2)
    {
      double num1 = (double) value1.X - (double) value2.X;
      float num2 = value1.Y - value2.Y;
      double num3 = num1 * num1;
      double num4 = (double) num2;
      double num5 = num4 * num4;
      return (float) Math.Sqrt(num3 + num5);
    }

    public static void Distance(ref Vector2 value1, ref Vector2 value2, out float result)
    {
      double num1 = (double) value1.X - (double) value2.X;
      float num2 = value1.Y - value2.Y;
      double num3 = num1 * num1;
      double num4 = (double) num2;
      double num5 = num4 * num4;
      float num6 = (float) (num3 + num5);
      result = (float) Math.Sqrt((double) num6);
    }

    public static float DistanceSquared(Vector2 value1, Vector2 value2)
    {
      double num1 = (double) value1.X - (double) value2.X;
      float num2 = value1.Y - value2.Y;
      double num3 = num1 * num1;
      double num4 = (double) num2;
      double num5 = num4 * num4;
      return (float) (num3 + num5);
    }

    public static void DistanceSquared(ref Vector2 value1, ref Vector2 value2, out float result)
    {
      float num1 = value1.X - value2.X;
      float num2 = value1.Y - value2.Y;
      ref float local = ref result;
      double num3 = (double) num1;
      double num4 = num3 * num3;
      double num5 = (double) num2;
      double num6 = num5 * num5;
      double num7 = num4 + num6;
      local = (float) num7;
    }

    public static float Dot(Vector2 value1, Vector2 value2) => (float) ((double) value1.X * (double) value2.X + (double) value1.Y * (double) value2.Y);

    public static void Dot(ref Vector2 value1, ref Vector2 value2, out float result) => result = (float) ((double) value1.X * (double) value2.X + (double) value1.Y * (double) value2.Y);

    public void Normalize()
    {
      float num = 1f / (float) Math.Sqrt((double) this.X * (double) this.X + (double) this.Y * (double) this.Y);
      this.X *= num;
      this.Y *= num;
    }

    public static Vector2 Normalize(Vector2 value)
    {
      float num = 1f / (float) Math.Sqrt((double) value.X * (double) value.X + (double) value.Y * (double) value.Y);
      Vector2 vector2;
      vector2.X = value.X * num;
      vector2.Y = value.Y * num;
      return vector2;
    }

    public static void Normalize(ref Vector2 value, out Vector2 result)
    {
      float num = 1f / (float) Math.Sqrt((double) value.X * (double) value.X + (double) value.Y * (double) value.Y);
      result.X = value.X * num;
      result.Y = value.Y * num;
    }

    public static Vector2 Reflect(Vector2 vector, Vector2 normal)
    {
      float num = (float) ((double) vector.X * (double) normal.X + (double) vector.Y * (double) normal.Y);
      Vector2 vector2;
      vector2.X = vector.X - 2f * num * normal.X;
      vector2.Y = vector.Y - 2f * num * normal.Y;
      return vector2;
    }

    public static void Reflect(ref Vector2 vector, ref Vector2 normal, out Vector2 result)
    {
      float num = (float) ((double) vector.X * (double) normal.X + (double) vector.Y * (double) normal.Y);
      result.X = vector.X - 2f * num * normal.X;
      result.Y = vector.Y - 2f * num * normal.Y;
    }

    public static Vector2 Min(Vector2 value1, Vector2 value2)
    {
      Vector2 vector2;
      vector2.X = (double) value1.X < (double) value2.X ? value1.X : value2.X;
      vector2.Y = (double) value1.Y < (double) value2.Y ? value1.Y : value2.Y;
      return vector2;
    }

    public static void Min(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
    {
      result.X = (double) value1.X < (double) value2.X ? value1.X : value2.X;
      result.Y = (double) value1.Y < (double) value2.Y ? value1.Y : value2.Y;
    }

    public static Vector2 Max(Vector2 value1, Vector2 value2)
    {
      Vector2 vector2;
      vector2.X = (double) value1.X > (double) value2.X ? value1.X : value2.X;
      vector2.Y = (double) value1.Y > (double) value2.Y ? value1.Y : value2.Y;
      return vector2;
    }

    public static void Max(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
    {
      result.X = (double) value1.X > (double) value2.X ? value1.X : value2.X;
      result.Y = (double) value1.Y > (double) value2.Y ? value1.Y : value2.Y;
    }

    public static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max)
    {
      float x = value1.X;
      float num1 = (double) x > (double) max.X ? max.X : x;
      float num2 = (double) num1 < (double) min.X ? min.X : num1;
      float y = value1.Y;
      float num3 = (double) y > (double) max.Y ? max.Y : y;
      float num4 = (double) num3 < (double) min.Y ? min.Y : num3;
      Vector2 vector2;
      vector2.X = num2;
      vector2.Y = num4;
      return vector2;
    }

    public static void Clamp(
      ref Vector2 value1,
      ref Vector2 min,
      ref Vector2 max,
      out Vector2 result)
    {
      float x = value1.X;
      float num1 = (double) x > (double) max.X ? max.X : x;
      float num2 = (double) num1 < (double) min.X ? min.X : num1;
      float y = value1.Y;
      float num3 = (double) y > (double) max.Y ? max.Y : y;
      float num4 = (double) num3 < (double) min.Y ? min.Y : num3;
      result.X = num2;
      result.Y = num4;
    }

    public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)
    {
      Vector2 vector2;
      vector2.X = value1.X + (value2.X - value1.X) * amount;
      vector2.Y = value1.Y + (value2.Y - value1.Y) * amount;
      return vector2;
    }

    public static void Lerp(
      ref Vector2 value1,
      ref Vector2 value2,
      float amount,
      out Vector2 result)
    {
      result.X = value1.X + (value2.X - value1.X) * amount;
      result.Y = value1.Y + (value2.Y - value1.Y) * amount;
    }

    public static Vector2 Barycentric(
      Vector2 value1,
      Vector2 value2,
      Vector2 value3,
      float amount1,
      float amount2)
    {
      Vector2 vector2;
      vector2.X = (float) ((double) value1.X + (double) amount1 * ((double) value2.X - (double) value1.X) + (double) amount2 * ((double) value3.X - (double) value1.X));
      vector2.Y = (float) ((double) value1.Y + (double) amount1 * ((double) value2.Y - (double) value1.Y) + (double) amount2 * ((double) value3.Y - (double) value1.Y));
      return vector2;
    }

    public static void Barycentric(
      ref Vector2 value1,
      ref Vector2 value2,
      ref Vector2 value3,
      float amount1,
      float amount2,
      out Vector2 result)
    {
      result.X = (float) ((double) value1.X + (double) amount1 * ((double) value2.X - (double) value1.X) + (double) amount2 * ((double) value3.X - (double) value1.X));
      result.Y = (float) ((double) value1.Y + (double) amount1 * ((double) value2.Y - (double) value1.Y) + (double) amount2 * ((double) value3.Y - (double) value1.Y));
    }

    public static Vector2 SmoothStep(Vector2 value1, Vector2 value2, float amount)
    {
      amount = (double) amount > 1.0 ? 1f : ((double) amount < 0.0 ? 0.0f : amount);
      double num = (double) amount;
      amount = (float) (num * num * (3.0 - 2.0 * (double) amount));
      Vector2 vector2;
      vector2.X = value1.X + (value2.X - value1.X) * amount;
      vector2.Y = value1.Y + (value2.Y - value1.Y) * amount;
      return vector2;
    }

    public static void SmoothStep(
      ref Vector2 value1,
      ref Vector2 value2,
      float amount,
      out Vector2 result)
    {
      amount = (double) amount > 1.0 ? 1f : ((double) amount < 0.0 ? 0.0f : amount);
      double num = (double) amount;
      amount = (float) (num * num * (3.0 - 2.0 * (double) amount));
      result.X = value1.X + (value2.X - value1.X) * amount;
      result.Y = value1.Y + (value2.Y - value1.Y) * amount;
    }

    public static Vector2 CatmullRom(
      Vector2 value1,
      Vector2 value2,
      Vector2 value3,
      Vector2 value4,
      float amount)
    {
      double num1 = (double) amount;
      float num2 = (float) (num1 * num1);
      float num3 = amount * num2;
      Vector2 vector2;
      vector2.X = (float) (0.5 * (2.0 * (double) value2.X + (-(double) value1.X + (double) value3.X) * (double) amount + (2.0 * (double) value1.X - 5.0 * (double) value2.X + 4.0 * (double) value3.X - (double) value4.X) * (double) num2 + (-(double) value1.X + 3.0 * (double) value2.X - 3.0 * (double) value3.X + (double) value4.X) * (double) num3));
      vector2.Y = (float) (0.5 * (2.0 * (double) value2.Y + (-(double) value1.Y + (double) value3.Y) * (double) amount + (2.0 * (double) value1.Y - 5.0 * (double) value2.Y + 4.0 * (double) value3.Y - (double) value4.Y) * (double) num2 + (-(double) value1.Y + 3.0 * (double) value2.Y - 3.0 * (double) value3.Y + (double) value4.Y) * (double) num3));
      return vector2;
    }

    public static void CatmullRom(
      ref Vector2 value1,
      ref Vector2 value2,
      ref Vector2 value3,
      ref Vector2 value4,
      float amount,
      out Vector2 result)
    {
      double num1 = (double) amount;
      float num2 = (float) (num1 * num1);
      float num3 = amount * num2;
      result.X = (float) (0.5 * (2.0 * (double) value2.X + (-(double) value1.X + (double) value3.X) * (double) amount + (2.0 * (double) value1.X - 5.0 * (double) value2.X + 4.0 * (double) value3.X - (double) value4.X) * (double) num2 + (-(double) value1.X + 3.0 * (double) value2.X - 3.0 * (double) value3.X + (double) value4.X) * (double) num3));
      result.Y = (float) (0.5 * (2.0 * (double) value2.Y + (-(double) value1.Y + (double) value3.Y) * (double) amount + (2.0 * (double) value1.Y - 5.0 * (double) value2.Y + 4.0 * (double) value3.Y - (double) value4.Y) * (double) num2 + (-(double) value1.Y + 3.0 * (double) value2.Y - 3.0 * (double) value3.Y + (double) value4.Y) * (double) num3));
    }

    public static Vector2 Hermite(
      Vector2 value1,
      Vector2 tangent1,
      Vector2 value2,
      Vector2 tangent2,
      float amount)
    {
      double num1 = (double) amount;
      float num2 = (float) (num1 * num1);
      float num3 = amount * num2;
      float num4 = (float) (2.0 * (double) num3 - 3.0 * (double) num2 + 1.0);
      float num5 = (float) (-2.0 * (double) num3 + 3.0 * (double) num2);
      float num6 = num3 - 2f * num2 + amount;
      float num7 = num3 - num2;
      Vector2 vector2;
      vector2.X = (float) ((double) value1.X * (double) num4 + (double) value2.X * (double) num5 + (double) tangent1.X * (double) num6 + (double) tangent2.X * (double) num7);
      vector2.Y = (float) ((double) value1.Y * (double) num4 + (double) value2.Y * (double) num5 + (double) tangent1.Y * (double) num6 + (double) tangent2.Y * (double) num7);
      return vector2;
    }

    public static void Hermite(
      ref Vector2 value1,
      ref Vector2 tangent1,
      ref Vector2 value2,
      ref Vector2 tangent2,
      float amount,
      out Vector2 result)
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
    }

    public static Vector2 Transform(Vector2 position, Matrix matrix)
    {
      float num1 = (float) ((double) position.X * (double) matrix.M11 + (double) position.Y * (double) matrix.M21) + matrix.M41;
      float num2 = (float) ((double) position.X * (double) matrix.M12 + (double) position.Y * (double) matrix.M22) + matrix.M42;
      Vector2 vector2;
      vector2.X = num1;
      vector2.Y = num2;
      return vector2;
    }

    public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector2 result)
    {
      float num1 = (float) ((double) position.X * (double) matrix.M11 + (double) position.Y * (double) matrix.M21) + matrix.M41;
      float num2 = (float) ((double) position.X * (double) matrix.M12 + (double) position.Y * (double) matrix.M22) + matrix.M42;
      result.X = num1;
      result.Y = num2;
    }

    public static Vector2 TransformNormal(Vector2 normal, Matrix matrix)
    {
      float num1 = (float) ((double) normal.X * (double) matrix.M11 + (double) normal.Y * (double) matrix.M21);
      float num2 = (float) ((double) normal.X * (double) matrix.M12 + (double) normal.Y * (double) matrix.M22);
      Vector2 vector2;
      vector2.X = num1;
      vector2.Y = num2;
      return vector2;
    }

    public static void TransformNormal(ref Vector2 normal, ref Matrix matrix, out Vector2 result)
    {
      float num1 = (float) ((double) normal.X * (double) matrix.M11 + (double) normal.Y * (double) matrix.M21);
      float num2 = (float) ((double) normal.X * (double) matrix.M12 + (double) normal.Y * (double) matrix.M22);
      result.X = num1;
      result.Y = num2;
    }

    public static Vector2 Transform(Vector2 value, Quaternion rotation)
    {
      float num1 = rotation.X + rotation.X;
      float num2 = rotation.Y + rotation.Y;
      float num3 = rotation.Z + rotation.Z;
      float num4 = rotation.W * num3;
      float num5 = rotation.X * num1;
      float num6 = rotation.X * num2;
      float num7 = rotation.Y * num2;
      float num8 = rotation.Z * num3;
      float num9 = (float) ((double) value.X * (1.0 - (double) num7 - (double) num8) + (double) value.Y * ((double) num6 - (double) num4));
      float num10 = (float) ((double) value.X * ((double) num6 + (double) num4) + (double) value.Y * (1.0 - (double) num5 - (double) num8));
      Vector2 vector2;
      vector2.X = num9;
      vector2.Y = num10;
      return vector2;
    }

    public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector2 result)
    {
      float num1 = rotation.X + rotation.X;
      float num2 = rotation.Y + rotation.Y;
      float num3 = rotation.Z + rotation.Z;
      float num4 = rotation.W * num3;
      float num5 = rotation.X * num1;
      float num6 = rotation.X * num2;
      float num7 = rotation.Y * num2;
      float num8 = rotation.Z * num3;
      float num9 = (float) ((double) value.X * (1.0 - (double) num7 - (double) num8) + (double) value.Y * ((double) num6 - (double) num4));
      float num10 = (float) ((double) value.X * ((double) num6 + (double) num4) + (double) value.Y * (1.0 - (double) num5 - (double) num8));
      result.X = num9;
      result.Y = num10;
    }

    public static void Transform(
      Vector2[] sourceArray,
      ref Matrix matrix,
      Vector2[] destinationArray)
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
        destinationArray[index].X = (float) ((double) x * (double) matrix.M11 + (double) y * (double) matrix.M21) + matrix.M41;
        destinationArray[index].Y = (float) ((double) x * (double) matrix.M12 + (double) y * (double) matrix.M22) + matrix.M42;
      }
    }

    [SuppressMessage("Microsoft.Usage", "CA2233")]
    public static void Transform(
      Vector2[] sourceArray,
      int sourceIndex,
      ref Matrix matrix,
      Vector2[] destinationArray,
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
        destinationArray[destinationIndex].X = (float) ((double) x * (double) matrix.M11 + (double) y * (double) matrix.M21) + matrix.M41;
        destinationArray[destinationIndex].Y = (float) ((double) x * (double) matrix.M12 + (double) y * (double) matrix.M22) + matrix.M42;
        ++sourceIndex;
        ++destinationIndex;
      }
    }

    public static void TransformNormal(
      Vector2[] sourceArray,
      ref Matrix matrix,
      Vector2[] destinationArray)
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
        destinationArray[index].X = (float) ((double) x * (double) matrix.M11 + (double) y * (double) matrix.M21);
        destinationArray[index].Y = (float) ((double) x * (double) matrix.M12 + (double) y * (double) matrix.M22);
      }
    }

    [SuppressMessage("Microsoft.Usage", "CA2233")]
    public static void TransformNormal(
      Vector2[] sourceArray,
      int sourceIndex,
      ref Matrix matrix,
      Vector2[] destinationArray,
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
        destinationArray[destinationIndex].X = (float) ((double) x * (double) matrix.M11 + (double) y * (double) matrix.M21);
        destinationArray[destinationIndex].Y = (float) ((double) x * (double) matrix.M12 + (double) y * (double) matrix.M22);
        ++sourceIndex;
        ++destinationIndex;
      }
    }

    public static void Transform(
      Vector2[] sourceArray,
      ref Quaternion rotation,
      Vector2[] destinationArray)
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
      float num4 = rotation.W * num3;
      float num5 = rotation.X * num1;
      double num6 = (double) rotation.X * (double) num2;
      float num7 = rotation.Y * num2;
      float num8 = rotation.Z * num3;
      float num9 = 1f - num7 - num8;
      float num10 = (float) num6 - num4;
      float num11 = (float) num6 + num4;
      float num12 = 1f - num5 - num8;
      for (int index = 0; index < sourceArray.Length; ++index)
      {
        float x = sourceArray[index].X;
        float y = sourceArray[index].Y;
        destinationArray[index].X = (float) ((double) x * (double) num9 + (double) y * (double) num10);
        destinationArray[index].Y = (float) ((double) x * (double) num11 + (double) y * (double) num12);
      }
    }

    [SuppressMessage("Microsoft.Usage", "CA2233")]
    public static void Transform(
      Vector2[] sourceArray,
      int sourceIndex,
      ref Quaternion rotation,
      Vector2[] destinationArray,
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
      float num4 = rotation.W * num3;
      float num5 = rotation.X * num1;
      double num6 = (double) rotation.X * (double) num2;
      float num7 = rotation.Y * num2;
      float num8 = rotation.Z * num3;
      float num9 = 1f - num7 - num8;
      float num10 = (float) num6 - num4;
      float num11 = (float) num6 + num4;
      float num12 = 1f - num5 - num8;
      for (; length > 0; --length)
      {
        float x = sourceArray[sourceIndex].X;
        float y = sourceArray[sourceIndex].Y;
        destinationArray[destinationIndex].X = (float) ((double) x * (double) num9 + (double) y * (double) num10);
        destinationArray[destinationIndex].Y = (float) ((double) x * (double) num11 + (double) y * (double) num12);
        ++sourceIndex;
        ++destinationIndex;
      }
    }

    public static Vector2 Negate(Vector2 value)
    {
      Vector2 vector2;
      vector2.X = -value.X;
      vector2.Y = -value.Y;
      return vector2;
    }

    public static void Negate(ref Vector2 value, out Vector2 result)
    {
      result.X = -value.X;
      result.Y = -value.Y;
    }

    public static Vector2 Add(Vector2 value1, Vector2 value2)
    {
      Vector2 vector2;
      vector2.X = value1.X + value2.X;
      vector2.Y = value1.Y + value2.Y;
      return vector2;
    }

    public static void Add(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
    {
      result.X = value1.X + value2.X;
      result.Y = value1.Y + value2.Y;
    }

    public static Vector2 Subtract(Vector2 value1, Vector2 value2)
    {
      Vector2 vector2;
      vector2.X = value1.X - value2.X;
      vector2.Y = value1.Y - value2.Y;
      return vector2;
    }

    public static void Subtract(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
    {
      result.X = value1.X - value2.X;
      result.Y = value1.Y - value2.Y;
    }

    public static Vector2 Multiply(Vector2 value1, Vector2 value2)
    {
      Vector2 vector2;
      vector2.X = value1.X * value2.X;
      vector2.Y = value1.Y * value2.Y;
      return vector2;
    }

    public static void Multiply(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
    {
      result.X = value1.X * value2.X;
      result.Y = value1.Y * value2.Y;
    }

    public static Vector2 Multiply(Vector2 value1, float scaleFactor)
    {
      Vector2 vector2;
      vector2.X = value1.X * scaleFactor;
      vector2.Y = value1.Y * scaleFactor;
      return vector2;
    }

    public static void Multiply(ref Vector2 value1, float scaleFactor, out Vector2 result)
    {
      result.X = value1.X * scaleFactor;
      result.Y = value1.Y * scaleFactor;
    }

    public static Vector2 Divide(Vector2 value1, Vector2 value2)
    {
      Vector2 vector2;
      vector2.X = value1.X / value2.X;
      vector2.Y = value1.Y / value2.Y;
      return vector2;
    }

    public static void Divide(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
    {
      result.X = value1.X / value2.X;
      result.Y = value1.Y / value2.Y;
    }

    public static Vector2 Divide(Vector2 value1, float divider)
    {
      float num = 1f / divider;
      Vector2 vector2;
      vector2.X = value1.X * num;
      vector2.Y = value1.Y * num;
      return vector2;
    }

    public static void Divide(ref Vector2 value1, float divider, out Vector2 result)
    {
      float num = 1f / divider;
      result.X = value1.X * num;
      result.Y = value1.Y * num;
    }

    public static Vector2 operator -(Vector2 value)
    {
      Vector2 vector2;
      vector2.X = -value.X;
      vector2.Y = -value.Y;
      return vector2;
    }

    public static bool operator ==(Vector2 value1, Vector2 value2) => (double) value1.X == (double) value2.X && (double) value1.Y == (double) value2.Y;

    public static bool operator !=(Vector2 value1, Vector2 value2) => (double) value1.X != (double) value2.X || (double) value1.Y != (double) value2.Y;

    public static Vector2 operator +(Vector2 value1, Vector2 value2)
    {
      Vector2 vector2;
      vector2.X = value1.X + value2.X;
      vector2.Y = value1.Y + value2.Y;
      return vector2;
    }

    public static Vector2 operator -(Vector2 value1, Vector2 value2)
    {
      Vector2 vector2;
      vector2.X = value1.X - value2.X;
      vector2.Y = value1.Y - value2.Y;
      return vector2;
    }

    public static Vector2 operator *(Vector2 value1, Vector2 value2)
    {
      Vector2 vector2;
      vector2.X = value1.X * value2.X;
      vector2.Y = value1.Y * value2.Y;
      return vector2;
    }

    public static Vector2 operator *(Vector2 value, float scaleFactor)
    {
      Vector2 vector2;
      vector2.X = value.X * scaleFactor;
      vector2.Y = value.Y * scaleFactor;
      return vector2;
    }

    public static Vector2 operator *(float scaleFactor, Vector2 value)
    {
      Vector2 vector2;
      vector2.X = value.X * scaleFactor;
      vector2.Y = value.Y * scaleFactor;
      return vector2;
    }

    public static Vector2 operator /(Vector2 value1, Vector2 value2)
    {
      Vector2 vector2;
      vector2.X = value1.X / value2.X;
      vector2.Y = value1.Y / value2.Y;
      return vector2;
    }

    public static Vector2 operator /(Vector2 value1, float divider)
    {
      float num = 1f / divider;
      Vector2 vector2;
      vector2.X = value1.X * num;
      vector2.Y = value1.Y * num;
      return vector2;
    }
  }
}
