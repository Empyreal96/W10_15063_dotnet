// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Quaternion
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
  public struct Quaternion : IEquatable<Quaternion>
  {
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float X;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float Y;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float Z;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float W;

    public static Quaternion Identity => new Quaternion(0.0f, 0.0f, 0.0f, 1f);

    public Quaternion(float x, float y, float z, float w)
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
      this.W = w;
    }

    public Quaternion(Vector3 vectorPart, float scalarPart)
    {
      this.X = vectorPart.X;
      this.Y = vectorPart.Y;
      this.Z = vectorPart.Z;
      this.W = scalarPart;
    }

    public override string ToString()
    {
      CultureInfo currentCulture = CultureInfo.CurrentCulture;
      return string.Format((IFormatProvider) currentCulture, "{{X:{0} Y:{1} Z:{2} W:{3}}}", (object) this.X.ToString((IFormatProvider) currentCulture), (object) this.Y.ToString((IFormatProvider) currentCulture), (object) this.Z.ToString((IFormatProvider) currentCulture), (object) this.W.ToString((IFormatProvider) currentCulture));
    }

    public bool Equals(Quaternion other) => (double) this.X == (double) other.X && (double) this.Y == (double) other.Y && (double) this.Z == (double) other.Z && (double) this.W == (double) other.W;

    public override bool Equals(object obj)
    {
      bool flag = false;
      if (obj is Quaternion other)
        flag = this.Equals(other);
      return flag;
    }

    public override int GetHashCode() => this.X.GetHashCode() + this.Y.GetHashCode() + this.Z.GetHashCode() + this.W.GetHashCode();

    public float LengthSquared() => (float) ((double) this.X * (double) this.X + (double) this.Y * (double) this.Y + (double) this.Z * (double) this.Z + (double) this.W * (double) this.W);

    public float Length() => (float) Math.Sqrt((double) this.X * (double) this.X + (double) this.Y * (double) this.Y + (double) this.Z * (double) this.Z + (double) this.W * (double) this.W);

    public void Normalize()
    {
      float num = 1f / (float) Math.Sqrt((double) this.X * (double) this.X + (double) this.Y * (double) this.Y + (double) this.Z * (double) this.Z + (double) this.W * (double) this.W);
      this.X *= num;
      this.Y *= num;
      this.Z *= num;
      this.W *= num;
    }

    public static Quaternion Normalize(Quaternion quaternion)
    {
      float num = 1f / (float) Math.Sqrt((double) quaternion.X * (double) quaternion.X + (double) quaternion.Y * (double) quaternion.Y + (double) quaternion.Z * (double) quaternion.Z + (double) quaternion.W * (double) quaternion.W);
      Quaternion quaternion1;
      quaternion1.X = quaternion.X * num;
      quaternion1.Y = quaternion.Y * num;
      quaternion1.Z = quaternion.Z * num;
      quaternion1.W = quaternion.W * num;
      return quaternion1;
    }

    public static void Normalize(ref Quaternion quaternion, out Quaternion result)
    {
      float num = 1f / (float) Math.Sqrt((double) quaternion.X * (double) quaternion.X + (double) quaternion.Y * (double) quaternion.Y + (double) quaternion.Z * (double) quaternion.Z + (double) quaternion.W * (double) quaternion.W);
      result.X = quaternion.X * num;
      result.Y = quaternion.Y * num;
      result.Z = quaternion.Z * num;
      result.W = quaternion.W * num;
    }

    public void Conjugate()
    {
      this.X = -this.X;
      this.Y = -this.Y;
      this.Z = -this.Z;
    }

    public static Quaternion Conjugate(Quaternion value)
    {
      Quaternion quaternion;
      quaternion.X = -value.X;
      quaternion.Y = -value.Y;
      quaternion.Z = -value.Z;
      quaternion.W = value.W;
      return quaternion;
    }

    public static void Conjugate(ref Quaternion value, out Quaternion result)
    {
      result.X = -value.X;
      result.Y = -value.Y;
      result.Z = -value.Z;
      result.W = value.W;
    }

    public static Quaternion Inverse(Quaternion quaternion)
    {
      float num = 1f / (float) ((double) quaternion.X * (double) quaternion.X + (double) quaternion.Y * (double) quaternion.Y + (double) quaternion.Z * (double) quaternion.Z + (double) quaternion.W * (double) quaternion.W);
      Quaternion quaternion1;
      quaternion1.X = -quaternion.X * num;
      quaternion1.Y = -quaternion.Y * num;
      quaternion1.Z = -quaternion.Z * num;
      quaternion1.W = quaternion.W * num;
      return quaternion1;
    }

    public static void Inverse(ref Quaternion quaternion, out Quaternion result)
    {
      float num = 1f / (float) ((double) quaternion.X * (double) quaternion.X + (double) quaternion.Y * (double) quaternion.Y + (double) quaternion.Z * (double) quaternion.Z + (double) quaternion.W * (double) quaternion.W);
      result.X = -quaternion.X * num;
      result.Y = -quaternion.Y * num;
      result.Z = -quaternion.Z * num;
      result.W = quaternion.W * num;
    }

    public static Quaternion CreateFromAxisAngle(Vector3 axis, float angle)
    {
      double d;
      float num1 = (float) Math.Sin(d = (double) angle * 0.5);
      float num2 = (float) Math.Cos(d);
      Quaternion quaternion;
      quaternion.X = axis.X * num1;
      quaternion.Y = axis.Y * num1;
      quaternion.Z = axis.Z * num1;
      quaternion.W = num2;
      return quaternion;
    }

    public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Quaternion result)
    {
      double d;
      float num1 = (float) Math.Sin(d = (double) angle * 0.5);
      float num2 = (float) Math.Cos(d);
      result.X = axis.X * num1;
      result.Y = axis.Y * num1;
      result.Z = axis.Z * num1;
      result.W = num2;
    }

    public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll)
    {
      double d1;
      float num1 = (float) Math.Sin(d1 = (double) roll * 0.5);
      float num2 = (float) Math.Cos(d1);
      double d2;
      float num3 = (float) Math.Sin(d2 = (double) pitch * 0.5);
      float num4 = (float) Math.Cos(d2);
      double d3;
      float num5 = (float) Math.Sin(d3 = (double) yaw * 0.5);
      float num6 = (float) Math.Cos(d3);
      Quaternion quaternion;
      quaternion.X = (float) ((double) num6 * (double) num3 * (double) num2 + (double) num5 * (double) num4 * (double) num1);
      quaternion.Y = (float) ((double) num5 * (double) num4 * (double) num2 - (double) num6 * (double) num3 * (double) num1);
      quaternion.Z = (float) ((double) num6 * (double) num4 * (double) num1 - (double) num5 * (double) num3 * (double) num2);
      quaternion.W = (float) ((double) num6 * (double) num4 * (double) num2 + (double) num5 * (double) num3 * (double) num1);
      return quaternion;
    }

    public static void CreateFromYawPitchRoll(
      float yaw,
      float pitch,
      float roll,
      out Quaternion result)
    {
      double d1;
      float num1 = (float) Math.Sin(d1 = (double) roll * 0.5);
      float num2 = (float) Math.Cos(d1);
      double d2;
      float num3 = (float) Math.Sin(d2 = (double) pitch * 0.5);
      float num4 = (float) Math.Cos(d2);
      double d3;
      float num5 = (float) Math.Sin(d3 = (double) yaw * 0.5);
      float num6 = (float) Math.Cos(d3);
      result.X = (float) ((double) num6 * (double) num3 * (double) num2 + (double) num5 * (double) num4 * (double) num1);
      result.Y = (float) ((double) num5 * (double) num4 * (double) num2 - (double) num6 * (double) num3 * (double) num1);
      result.Z = (float) ((double) num6 * (double) num4 * (double) num1 - (double) num5 * (double) num3 * (double) num2);
      result.W = (float) ((double) num6 * (double) num4 * (double) num2 + (double) num5 * (double) num3 * (double) num1);
    }

    public static Quaternion CreateFromRotationMatrix(Matrix matrix)
    {
      float num1 = matrix.M11 + matrix.M22 + matrix.M33;
      Quaternion quaternion = new Quaternion();
      if ((double) num1 > 0.0)
      {
        float num2 = (float) Math.Sqrt((double) num1 + 1.0);
        quaternion.W = num2 * 0.5f;
        float num3 = 0.5f / num2;
        quaternion.X = (matrix.M23 - matrix.M32) * num3;
        quaternion.Y = (matrix.M31 - matrix.M13) * num3;
        quaternion.Z = (matrix.M12 - matrix.M21) * num3;
      }
      else if ((double) matrix.M11 >= (double) matrix.M22 && (double) matrix.M11 >= (double) matrix.M33)
      {
        float num2 = (float) Math.Sqrt(1.0 + (double) matrix.M11 - (double) matrix.M22 - (double) matrix.M33);
        float num3 = 0.5f / num2;
        quaternion.X = 0.5f * num2;
        quaternion.Y = (matrix.M12 + matrix.M21) * num3;
        quaternion.Z = (matrix.M13 + matrix.M31) * num3;
        quaternion.W = (matrix.M23 - matrix.M32) * num3;
      }
      else if ((double) matrix.M22 > (double) matrix.M33)
      {
        float num2 = (float) Math.Sqrt(1.0 + (double) matrix.M22 - (double) matrix.M11 - (double) matrix.M33);
        float num3 = 0.5f / num2;
        quaternion.X = (matrix.M21 + matrix.M12) * num3;
        quaternion.Y = 0.5f * num2;
        quaternion.Z = (matrix.M32 + matrix.M23) * num3;
        quaternion.W = (matrix.M31 - matrix.M13) * num3;
      }
      else
      {
        float num2 = (float) Math.Sqrt(1.0 + (double) matrix.M33 - (double) matrix.M11 - (double) matrix.M22);
        float num3 = 0.5f / num2;
        quaternion.X = (matrix.M31 + matrix.M13) * num3;
        quaternion.Y = (matrix.M32 + matrix.M23) * num3;
        quaternion.Z = 0.5f * num2;
        quaternion.W = (matrix.M12 - matrix.M21) * num3;
      }
      return quaternion;
    }

    public static void CreateFromRotationMatrix(ref Matrix matrix, out Quaternion result)
    {
      float num1 = matrix.M11 + matrix.M22 + matrix.M33;
      if ((double) num1 > 0.0)
      {
        float num2 = (float) Math.Sqrt((double) num1 + 1.0);
        result.W = num2 * 0.5f;
        float num3 = 0.5f / num2;
        result.X = (matrix.M23 - matrix.M32) * num3;
        result.Y = (matrix.M31 - matrix.M13) * num3;
        result.Z = (matrix.M12 - matrix.M21) * num3;
      }
      else if ((double) matrix.M11 >= (double) matrix.M22 && (double) matrix.M11 >= (double) matrix.M33)
      {
        float num2 = (float) Math.Sqrt(1.0 + (double) matrix.M11 - (double) matrix.M22 - (double) matrix.M33);
        float num3 = 0.5f / num2;
        result.X = 0.5f * num2;
        result.Y = (matrix.M12 + matrix.M21) * num3;
        result.Z = (matrix.M13 + matrix.M31) * num3;
        result.W = (matrix.M23 - matrix.M32) * num3;
      }
      else if ((double) matrix.M22 > (double) matrix.M33)
      {
        float num2 = (float) Math.Sqrt(1.0 + (double) matrix.M22 - (double) matrix.M11 - (double) matrix.M33);
        float num3 = 0.5f / num2;
        result.X = (matrix.M21 + matrix.M12) * num3;
        result.Y = 0.5f * num2;
        result.Z = (matrix.M32 + matrix.M23) * num3;
        result.W = (matrix.M31 - matrix.M13) * num3;
      }
      else
      {
        float num2 = (float) Math.Sqrt(1.0 + (double) matrix.M33 - (double) matrix.M11 - (double) matrix.M22);
        float num3 = 0.5f / num2;
        result.X = (matrix.M31 + matrix.M13) * num3;
        result.Y = (matrix.M32 + matrix.M23) * num3;
        result.Z = 0.5f * num2;
        result.W = (matrix.M12 - matrix.M21) * num3;
      }
    }

    public static float Dot(Quaternion quaternion1, Quaternion quaternion2) => (float) ((double) quaternion1.X * (double) quaternion2.X + (double) quaternion1.Y * (double) quaternion2.Y + (double) quaternion1.Z * (double) quaternion2.Z + (double) quaternion1.W * (double) quaternion2.W);

    public static void Dot(
      ref Quaternion quaternion1,
      ref Quaternion quaternion2,
      out float result)
    {
      result = (float) ((double) quaternion1.X * (double) quaternion2.X + (double) quaternion1.Y * (double) quaternion2.Y + (double) quaternion1.Z * (double) quaternion2.Z + (double) quaternion1.W * (double) quaternion2.W);
    }

    public static Quaternion Slerp(
      Quaternion quaternion1,
      Quaternion quaternion2,
      float amount)
    {
      float num1 = amount;
      float num2 = (float) ((double) quaternion1.X * (double) quaternion2.X + (double) quaternion1.Y * (double) quaternion2.Y + (double) quaternion1.Z * (double) quaternion2.Z + (double) quaternion1.W * (double) quaternion2.W);
      bool flag = false;
      if ((double) num2 < 0.0)
      {
        flag = true;
        num2 = -num2;
      }
      float num3;
      float num4;
      if ((double) num2 > 0.999998986721039)
      {
        num3 = 1f - num1;
        num4 = flag ? -num1 : num1;
      }
      else
      {
        float num5 = (float) Math.Acos((double) num2);
        float num6 = (float) (1.0 / Math.Sin((double) num5));
        num3 = (float) Math.Sin((1.0 - (double) num1) * (double) num5) * num6;
        num4 = flag ? (float) -Math.Sin((double) num1 * (double) num5) * num6 : (float) Math.Sin((double) num1 * (double) num5) * num6;
      }
      Quaternion quaternion;
      quaternion.X = (float) ((double) num3 * (double) quaternion1.X + (double) num4 * (double) quaternion2.X);
      quaternion.Y = (float) ((double) num3 * (double) quaternion1.Y + (double) num4 * (double) quaternion2.Y);
      quaternion.Z = (float) ((double) num3 * (double) quaternion1.Z + (double) num4 * (double) quaternion2.Z);
      quaternion.W = (float) ((double) num3 * (double) quaternion1.W + (double) num4 * (double) quaternion2.W);
      return quaternion;
    }

    public static void Slerp(
      ref Quaternion quaternion1,
      ref Quaternion quaternion2,
      float amount,
      out Quaternion result)
    {
      float num1 = amount;
      float num2 = (float) ((double) quaternion1.X * (double) quaternion2.X + (double) quaternion1.Y * (double) quaternion2.Y + (double) quaternion1.Z * (double) quaternion2.Z + (double) quaternion1.W * (double) quaternion2.W);
      bool flag = false;
      if ((double) num2 < 0.0)
      {
        flag = true;
        num2 = -num2;
      }
      float num3;
      float num4;
      if ((double) num2 > 0.999998986721039)
      {
        num3 = 1f - num1;
        num4 = flag ? -num1 : num1;
      }
      else
      {
        float num5 = (float) Math.Acos((double) num2);
        float num6 = (float) (1.0 / Math.Sin((double) num5));
        num3 = (float) Math.Sin((1.0 - (double) num1) * (double) num5) * num6;
        num4 = flag ? (float) -Math.Sin((double) num1 * (double) num5) * num6 : (float) Math.Sin((double) num1 * (double) num5) * num6;
      }
      result.X = (float) ((double) num3 * (double) quaternion1.X + (double) num4 * (double) quaternion2.X);
      result.Y = (float) ((double) num3 * (double) quaternion1.Y + (double) num4 * (double) quaternion2.Y);
      result.Z = (float) ((double) num3 * (double) quaternion1.Z + (double) num4 * (double) quaternion2.Z);
      result.W = (float) ((double) num3 * (double) quaternion1.W + (double) num4 * (double) quaternion2.W);
    }

    public static Quaternion Lerp(
      Quaternion quaternion1,
      Quaternion quaternion2,
      float amount)
    {
      float num1 = amount;
      float num2 = 1f - num1;
      Quaternion quaternion = new Quaternion();
      if ((double) quaternion1.X * (double) quaternion2.X + (double) quaternion1.Y * (double) quaternion2.Y + (double) quaternion1.Z * (double) quaternion2.Z + (double) quaternion1.W * (double) quaternion2.W >= 0.0)
      {
        quaternion.X = (float) ((double) num2 * (double) quaternion1.X + (double) num1 * (double) quaternion2.X);
        quaternion.Y = (float) ((double) num2 * (double) quaternion1.Y + (double) num1 * (double) quaternion2.Y);
        quaternion.Z = (float) ((double) num2 * (double) quaternion1.Z + (double) num1 * (double) quaternion2.Z);
        quaternion.W = (float) ((double) num2 * (double) quaternion1.W + (double) num1 * (double) quaternion2.W);
      }
      else
      {
        quaternion.X = (float) ((double) num2 * (double) quaternion1.X - (double) num1 * (double) quaternion2.X);
        quaternion.Y = (float) ((double) num2 * (double) quaternion1.Y - (double) num1 * (double) quaternion2.Y);
        quaternion.Z = (float) ((double) num2 * (double) quaternion1.Z - (double) num1 * (double) quaternion2.Z);
        quaternion.W = (float) ((double) num2 * (double) quaternion1.W - (double) num1 * (double) quaternion2.W);
      }
      float num3 = 1f / (float) Math.Sqrt((double) quaternion.X * (double) quaternion.X + (double) quaternion.Y * (double) quaternion.Y + (double) quaternion.Z * (double) quaternion.Z + (double) quaternion.W * (double) quaternion.W);
      quaternion.X *= num3;
      quaternion.Y *= num3;
      quaternion.Z *= num3;
      quaternion.W *= num3;
      return quaternion;
    }

    public static void Lerp(
      ref Quaternion quaternion1,
      ref Quaternion quaternion2,
      float amount,
      out Quaternion result)
    {
      float num1 = amount;
      float num2 = 1f - num1;
      if ((double) quaternion1.X * (double) quaternion2.X + (double) quaternion1.Y * (double) quaternion2.Y + (double) quaternion1.Z * (double) quaternion2.Z + (double) quaternion1.W * (double) quaternion2.W >= 0.0)
      {
        result.X = (float) ((double) num2 * (double) quaternion1.X + (double) num1 * (double) quaternion2.X);
        result.Y = (float) ((double) num2 * (double) quaternion1.Y + (double) num1 * (double) quaternion2.Y);
        result.Z = (float) ((double) num2 * (double) quaternion1.Z + (double) num1 * (double) quaternion2.Z);
        result.W = (float) ((double) num2 * (double) quaternion1.W + (double) num1 * (double) quaternion2.W);
      }
      else
      {
        result.X = (float) ((double) num2 * (double) quaternion1.X - (double) num1 * (double) quaternion2.X);
        result.Y = (float) ((double) num2 * (double) quaternion1.Y - (double) num1 * (double) quaternion2.Y);
        result.Z = (float) ((double) num2 * (double) quaternion1.Z - (double) num1 * (double) quaternion2.Z);
        result.W = (float) ((double) num2 * (double) quaternion1.W - (double) num1 * (double) quaternion2.W);
      }
      float num3 = 1f / (float) Math.Sqrt((double) result.X * (double) result.X + (double) result.Y * (double) result.Y + (double) result.Z * (double) result.Z + (double) result.W * (double) result.W);
      result.X *= num3;
      result.Y *= num3;
      result.Z *= num3;
      result.W *= num3;
    }

    public static Quaternion Concatenate(Quaternion value1, Quaternion value2)
    {
      float x1 = value2.X;
      float y1 = value2.Y;
      float z1 = value2.Z;
      float w1 = value2.W;
      float x2 = value1.X;
      float y2 = value1.Y;
      float z2 = value1.Z;
      float w2 = value1.W;
      float num1 = (float) ((double) y1 * (double) z2 - (double) z1 * (double) y2);
      float num2 = (float) ((double) z1 * (double) x2 - (double) x1 * (double) z2);
      float num3 = (float) ((double) x1 * (double) y2 - (double) y1 * (double) x2);
      float num4 = (float) ((double) x1 * (double) x2 + (double) y1 * (double) y2 + (double) z1 * (double) z2);
      Quaternion quaternion;
      quaternion.X = (float) ((double) x1 * (double) w2 + (double) x2 * (double) w1) + num1;
      quaternion.Y = (float) ((double) y1 * (double) w2 + (double) y2 * (double) w1) + num2;
      quaternion.Z = (float) ((double) z1 * (double) w2 + (double) z2 * (double) w1) + num3;
      quaternion.W = w1 * w2 - num4;
      return quaternion;
    }

    public static void Concatenate(
      ref Quaternion value1,
      ref Quaternion value2,
      out Quaternion result)
    {
      float x1 = value2.X;
      float y1 = value2.Y;
      float z1 = value2.Z;
      float w1 = value2.W;
      float x2 = value1.X;
      float y2 = value1.Y;
      float z2 = value1.Z;
      float w2 = value1.W;
      float num1 = (float) ((double) y1 * (double) z2 - (double) z1 * (double) y2);
      float num2 = (float) ((double) z1 * (double) x2 - (double) x1 * (double) z2);
      float num3 = (float) ((double) x1 * (double) y2 - (double) y1 * (double) x2);
      float num4 = (float) ((double) x1 * (double) x2 + (double) y1 * (double) y2 + (double) z1 * (double) z2);
      result.X = (float) ((double) x1 * (double) w2 + (double) x2 * (double) w1) + num1;
      result.Y = (float) ((double) y1 * (double) w2 + (double) y2 * (double) w1) + num2;
      result.Z = (float) ((double) z1 * (double) w2 + (double) z2 * (double) w1) + num3;
      result.W = w1 * w2 - num4;
    }

    public static Quaternion Negate(Quaternion quaternion)
    {
      Quaternion quaternion1;
      quaternion1.X = -quaternion.X;
      quaternion1.Y = -quaternion.Y;
      quaternion1.Z = -quaternion.Z;
      quaternion1.W = -quaternion.W;
      return quaternion1;
    }

    public static void Negate(ref Quaternion quaternion, out Quaternion result)
    {
      result.X = -quaternion.X;
      result.Y = -quaternion.Y;
      result.Z = -quaternion.Z;
      result.W = -quaternion.W;
    }

    public static Quaternion Add(Quaternion quaternion1, Quaternion quaternion2)
    {
      Quaternion quaternion;
      quaternion.X = quaternion1.X + quaternion2.X;
      quaternion.Y = quaternion1.Y + quaternion2.Y;
      quaternion.Z = quaternion1.Z + quaternion2.Z;
      quaternion.W = quaternion1.W + quaternion2.W;
      return quaternion;
    }

    public static void Add(
      ref Quaternion quaternion1,
      ref Quaternion quaternion2,
      out Quaternion result)
    {
      result.X = quaternion1.X + quaternion2.X;
      result.Y = quaternion1.Y + quaternion2.Y;
      result.Z = quaternion1.Z + quaternion2.Z;
      result.W = quaternion1.W + quaternion2.W;
    }

    public static Quaternion Subtract(Quaternion quaternion1, Quaternion quaternion2)
    {
      Quaternion quaternion;
      quaternion.X = quaternion1.X - quaternion2.X;
      quaternion.Y = quaternion1.Y - quaternion2.Y;
      quaternion.Z = quaternion1.Z - quaternion2.Z;
      quaternion.W = quaternion1.W - quaternion2.W;
      return quaternion;
    }

    public static void Subtract(
      ref Quaternion quaternion1,
      ref Quaternion quaternion2,
      out Quaternion result)
    {
      result.X = quaternion1.X - quaternion2.X;
      result.Y = quaternion1.Y - quaternion2.Y;
      result.Z = quaternion1.Z - quaternion2.Z;
      result.W = quaternion1.W - quaternion2.W;
    }

    public static Quaternion Multiply(Quaternion quaternion1, Quaternion quaternion2)
    {
      float x1 = quaternion1.X;
      float y1 = quaternion1.Y;
      float z1 = quaternion1.Z;
      float w1 = quaternion1.W;
      float x2 = quaternion2.X;
      float y2 = quaternion2.Y;
      float z2 = quaternion2.Z;
      float w2 = quaternion2.W;
      float num1 = (float) ((double) y1 * (double) z2 - (double) z1 * (double) y2);
      float num2 = (float) ((double) z1 * (double) x2 - (double) x1 * (double) z2);
      float num3 = (float) ((double) x1 * (double) y2 - (double) y1 * (double) x2);
      float num4 = (float) ((double) x1 * (double) x2 + (double) y1 * (double) y2 + (double) z1 * (double) z2);
      Quaternion quaternion;
      quaternion.X = (float) ((double) x1 * (double) w2 + (double) x2 * (double) w1) + num1;
      quaternion.Y = (float) ((double) y1 * (double) w2 + (double) y2 * (double) w1) + num2;
      quaternion.Z = (float) ((double) z1 * (double) w2 + (double) z2 * (double) w1) + num3;
      quaternion.W = w1 * w2 - num4;
      return quaternion;
    }

    public static void Multiply(
      ref Quaternion quaternion1,
      ref Quaternion quaternion2,
      out Quaternion result)
    {
      float x1 = quaternion1.X;
      float y1 = quaternion1.Y;
      float z1 = quaternion1.Z;
      float w1 = quaternion1.W;
      float x2 = quaternion2.X;
      float y2 = quaternion2.Y;
      float z2 = quaternion2.Z;
      float w2 = quaternion2.W;
      float num1 = (float) ((double) y1 * (double) z2 - (double) z1 * (double) y2);
      float num2 = (float) ((double) z1 * (double) x2 - (double) x1 * (double) z2);
      float num3 = (float) ((double) x1 * (double) y2 - (double) y1 * (double) x2);
      float num4 = (float) ((double) x1 * (double) x2 + (double) y1 * (double) y2 + (double) z1 * (double) z2);
      result.X = (float) ((double) x1 * (double) w2 + (double) x2 * (double) w1) + num1;
      result.Y = (float) ((double) y1 * (double) w2 + (double) y2 * (double) w1) + num2;
      result.Z = (float) ((double) z1 * (double) w2 + (double) z2 * (double) w1) + num3;
      result.W = w1 * w2 - num4;
    }

    public static Quaternion Multiply(Quaternion quaternion1, float scaleFactor)
    {
      Quaternion quaternion;
      quaternion.X = quaternion1.X * scaleFactor;
      quaternion.Y = quaternion1.Y * scaleFactor;
      quaternion.Z = quaternion1.Z * scaleFactor;
      quaternion.W = quaternion1.W * scaleFactor;
      return quaternion;
    }

    public static void Multiply(
      ref Quaternion quaternion1,
      float scaleFactor,
      out Quaternion result)
    {
      result.X = quaternion1.X * scaleFactor;
      result.Y = quaternion1.Y * scaleFactor;
      result.Z = quaternion1.Z * scaleFactor;
      result.W = quaternion1.W * scaleFactor;
    }

    public static Quaternion Divide(Quaternion quaternion1, Quaternion quaternion2)
    {
      float x = quaternion1.X;
      float y = quaternion1.Y;
      float z = quaternion1.Z;
      float w = quaternion1.W;
      float num1 = 1f / (float) ((double) quaternion2.X * (double) quaternion2.X + (double) quaternion2.Y * (double) quaternion2.Y + (double) quaternion2.Z * (double) quaternion2.Z + (double) quaternion2.W * (double) quaternion2.W);
      float num2 = -quaternion2.X * num1;
      float num3 = -quaternion2.Y * num1;
      float num4 = -quaternion2.Z * num1;
      float num5 = quaternion2.W * num1;
      float num6 = (float) ((double) y * (double) num4 - (double) z * (double) num3);
      float num7 = (float) ((double) z * (double) num2 - (double) x * (double) num4);
      float num8 = (float) ((double) x * (double) num3 - (double) y * (double) num2);
      float num9 = (float) ((double) x * (double) num2 + (double) y * (double) num3 + (double) z * (double) num4);
      Quaternion quaternion;
      quaternion.X = (float) ((double) x * (double) num5 + (double) num2 * (double) w) + num6;
      quaternion.Y = (float) ((double) y * (double) num5 + (double) num3 * (double) w) + num7;
      quaternion.Z = (float) ((double) z * (double) num5 + (double) num4 * (double) w) + num8;
      quaternion.W = w * num5 - num9;
      return quaternion;
    }

    public static void Divide(
      ref Quaternion quaternion1,
      ref Quaternion quaternion2,
      out Quaternion result)
    {
      float x = quaternion1.X;
      float y = quaternion1.Y;
      float z = quaternion1.Z;
      float w = quaternion1.W;
      float num1 = 1f / (float) ((double) quaternion2.X * (double) quaternion2.X + (double) quaternion2.Y * (double) quaternion2.Y + (double) quaternion2.Z * (double) quaternion2.Z + (double) quaternion2.W * (double) quaternion2.W);
      float num2 = -quaternion2.X * num1;
      float num3 = -quaternion2.Y * num1;
      float num4 = -quaternion2.Z * num1;
      float num5 = quaternion2.W * num1;
      float num6 = (float) ((double) y * (double) num4 - (double) z * (double) num3);
      float num7 = (float) ((double) z * (double) num2 - (double) x * (double) num4);
      float num8 = (float) ((double) x * (double) num3 - (double) y * (double) num2);
      float num9 = (float) ((double) x * (double) num2 + (double) y * (double) num3 + (double) z * (double) num4);
      result.X = (float) ((double) x * (double) num5 + (double) num2 * (double) w) + num6;
      result.Y = (float) ((double) y * (double) num5 + (double) num3 * (double) w) + num7;
      result.Z = (float) ((double) z * (double) num5 + (double) num4 * (double) w) + num8;
      result.W = w * num5 - num9;
    }

    public static Quaternion operator -(Quaternion quaternion)
    {
      Quaternion quaternion1;
      quaternion1.X = -quaternion.X;
      quaternion1.Y = -quaternion.Y;
      quaternion1.Z = -quaternion.Z;
      quaternion1.W = -quaternion.W;
      return quaternion1;
    }

    public static bool operator ==(Quaternion quaternion1, Quaternion quaternion2) => (double) quaternion1.X == (double) quaternion2.X && (double) quaternion1.Y == (double) quaternion2.Y && (double) quaternion1.Z == (double) quaternion2.Z && (double) quaternion1.W == (double) quaternion2.W;

    public static bool operator !=(Quaternion quaternion1, Quaternion quaternion2) => (double) quaternion1.X != (double) quaternion2.X || (double) quaternion1.Y != (double) quaternion2.Y || (double) quaternion1.Z != (double) quaternion2.Z || (double) quaternion1.W != (double) quaternion2.W;

    public static Quaternion operator +(Quaternion quaternion1, Quaternion quaternion2)
    {
      Quaternion quaternion;
      quaternion.X = quaternion1.X + quaternion2.X;
      quaternion.Y = quaternion1.Y + quaternion2.Y;
      quaternion.Z = quaternion1.Z + quaternion2.Z;
      quaternion.W = quaternion1.W + quaternion2.W;
      return quaternion;
    }

    public static Quaternion operator -(Quaternion quaternion1, Quaternion quaternion2)
    {
      Quaternion quaternion;
      quaternion.X = quaternion1.X - quaternion2.X;
      quaternion.Y = quaternion1.Y - quaternion2.Y;
      quaternion.Z = quaternion1.Z - quaternion2.Z;
      quaternion.W = quaternion1.W - quaternion2.W;
      return quaternion;
    }

    public static Quaternion operator *(Quaternion quaternion1, Quaternion quaternion2)
    {
      float x1 = quaternion1.X;
      float y1 = quaternion1.Y;
      float z1 = quaternion1.Z;
      float w1 = quaternion1.W;
      float x2 = quaternion2.X;
      float y2 = quaternion2.Y;
      float z2 = quaternion2.Z;
      float w2 = quaternion2.W;
      float num1 = (float) ((double) y1 * (double) z2 - (double) z1 * (double) y2);
      float num2 = (float) ((double) z1 * (double) x2 - (double) x1 * (double) z2);
      float num3 = (float) ((double) x1 * (double) y2 - (double) y1 * (double) x2);
      float num4 = (float) ((double) x1 * (double) x2 + (double) y1 * (double) y2 + (double) z1 * (double) z2);
      Quaternion quaternion;
      quaternion.X = (float) ((double) x1 * (double) w2 + (double) x2 * (double) w1) + num1;
      quaternion.Y = (float) ((double) y1 * (double) w2 + (double) y2 * (double) w1) + num2;
      quaternion.Z = (float) ((double) z1 * (double) w2 + (double) z2 * (double) w1) + num3;
      quaternion.W = w1 * w2 - num4;
      return quaternion;
    }

    public static Quaternion operator *(Quaternion quaternion1, float scaleFactor)
    {
      Quaternion quaternion;
      quaternion.X = quaternion1.X * scaleFactor;
      quaternion.Y = quaternion1.Y * scaleFactor;
      quaternion.Z = quaternion1.Z * scaleFactor;
      quaternion.W = quaternion1.W * scaleFactor;
      return quaternion;
    }

    public static Quaternion operator /(Quaternion quaternion1, Quaternion quaternion2)
    {
      float x = quaternion1.X;
      float y = quaternion1.Y;
      float z = quaternion1.Z;
      float w = quaternion1.W;
      float num1 = 1f / (float) ((double) quaternion2.X * (double) quaternion2.X + (double) quaternion2.Y * (double) quaternion2.Y + (double) quaternion2.Z * (double) quaternion2.Z + (double) quaternion2.W * (double) quaternion2.W);
      float num2 = -quaternion2.X * num1;
      float num3 = -quaternion2.Y * num1;
      float num4 = -quaternion2.Z * num1;
      float num5 = quaternion2.W * num1;
      float num6 = (float) ((double) y * (double) num4 - (double) z * (double) num3);
      float num7 = (float) ((double) z * (double) num2 - (double) x * (double) num4);
      float num8 = (float) ((double) x * (double) num3 - (double) y * (double) num2);
      float num9 = (float) ((double) x * (double) num2 + (double) y * (double) num3 + (double) z * (double) num4);
      Quaternion quaternion;
      quaternion.X = (float) ((double) x * (double) num5 + (double) num2 * (double) w) + num6;
      quaternion.Y = (float) ((double) y * (double) num5 + (double) num3 * (double) w) + num7;
      quaternion.Z = (float) ((double) z * (double) num5 + (double) num4 * (double) w) + num8;
      quaternion.W = w * num5 - num9;
      return quaternion;
    }
  }
}
