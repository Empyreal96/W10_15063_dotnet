﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Matrix
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security;

namespace Microsoft.Xna.Framework
{
  public struct Matrix : IEquatable<Matrix>
  {
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M11;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M12;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M13;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M14;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M21;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M22;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M23;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M24;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M31;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M32;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M33;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M34;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M41;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M42;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M43;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public float M44;
    private static Matrix _identity = new Matrix(1f, 0.0f, 0.0f, 0.0f, 0.0f, 1f, 0.0f, 0.0f, 0.0f, 0.0f, 1f, 0.0f, 0.0f, 0.0f, 0.0f, 1f);

    public static Matrix Identity => Matrix._identity;

    public Vector3 Up
    {
      get
      {
        Vector3 vector3;
        vector3.X = this.M21;
        vector3.Y = this.M22;
        vector3.Z = this.M23;
        return vector3;
      }
      set
      {
        this.M21 = value.X;
        this.M22 = value.Y;
        this.M23 = value.Z;
      }
    }

    public Vector3 Down
    {
      get
      {
        Vector3 vector3;
        vector3.X = -this.M21;
        vector3.Y = -this.M22;
        vector3.Z = -this.M23;
        return vector3;
      }
      set
      {
        this.M21 = -value.X;
        this.M22 = -value.Y;
        this.M23 = -value.Z;
      }
    }

    public Vector3 Right
    {
      get
      {
        Vector3 vector3;
        vector3.X = this.M11;
        vector3.Y = this.M12;
        vector3.Z = this.M13;
        return vector3;
      }
      set
      {
        this.M11 = value.X;
        this.M12 = value.Y;
        this.M13 = value.Z;
      }
    }

    public Vector3 Left
    {
      get
      {
        Vector3 vector3;
        vector3.X = -this.M11;
        vector3.Y = -this.M12;
        vector3.Z = -this.M13;
        return vector3;
      }
      set
      {
        this.M11 = -value.X;
        this.M12 = -value.Y;
        this.M13 = -value.Z;
      }
    }

    public Vector3 Forward
    {
      get
      {
        Vector3 vector3;
        vector3.X = -this.M31;
        vector3.Y = -this.M32;
        vector3.Z = -this.M33;
        return vector3;
      }
      set
      {
        this.M31 = -value.X;
        this.M32 = -value.Y;
        this.M33 = -value.Z;
      }
    }

    public Vector3 Backward
    {
      get
      {
        Vector3 vector3;
        vector3.X = this.M31;
        vector3.Y = this.M32;
        vector3.Z = this.M33;
        return vector3;
      }
      set
      {
        this.M31 = value.X;
        this.M32 = value.Y;
        this.M33 = value.Z;
      }
    }

    public Vector3 Translation
    {
      get
      {
        Vector3 vector3;
        vector3.X = this.M41;
        vector3.Y = this.M42;
        vector3.Z = this.M43;
        return vector3;
      }
      set
      {
        this.M41 = value.X;
        this.M42 = value.Y;
        this.M43 = value.Z;
      }
    }

    [SuppressMessage("Microsoft.Design", "CA1025")]
    public Matrix(
      float m11,
      float m12,
      float m13,
      float m14,
      float m21,
      float m22,
      float m23,
      float m24,
      float m31,
      float m32,
      float m33,
      float m34,
      float m41,
      float m42,
      float m43,
      float m44)
    {
      this.M11 = m11;
      this.M12 = m12;
      this.M13 = m13;
      this.M14 = m14;
      this.M21 = m21;
      this.M22 = m22;
      this.M23 = m23;
      this.M24 = m24;
      this.M31 = m31;
      this.M32 = m32;
      this.M33 = m33;
      this.M34 = m34;
      this.M41 = m41;
      this.M42 = m42;
      this.M43 = m43;
      this.M44 = m44;
    }

    public static Matrix CreateBillboard(
      Vector3 objectPosition,
      Vector3 cameraPosition,
      Vector3 cameraUpVector,
      Vector3? cameraForwardVector)
    {
      Vector3 result1;
      result1.X = objectPosition.X - cameraPosition.X;
      result1.Y = objectPosition.Y - cameraPosition.Y;
      result1.Z = objectPosition.Z - cameraPosition.Z;
      float num = result1.LengthSquared();
      if ((double) num < 9.99999974737875E-05)
        result1 = cameraForwardVector.HasValue ? -cameraForwardVector.Value : Vector3.Forward;
      else
        Vector3.Multiply(ref result1, 1f / (float) Math.Sqrt((double) num), out result1);
      Vector3 result2;
      Vector3.Cross(ref cameraUpVector, ref result1, out result2);
      result2.Normalize();
      Vector3 result3;
      Vector3.Cross(ref result1, ref result2, out result3);
      Matrix matrix;
      matrix.M11 = result2.X;
      matrix.M12 = result2.Y;
      matrix.M13 = result2.Z;
      matrix.M14 = 0.0f;
      matrix.M21 = result3.X;
      matrix.M22 = result3.Y;
      matrix.M23 = result3.Z;
      matrix.M24 = 0.0f;
      matrix.M31 = result1.X;
      matrix.M32 = result1.Y;
      matrix.M33 = result1.Z;
      matrix.M34 = 0.0f;
      matrix.M41 = objectPosition.X;
      matrix.M42 = objectPosition.Y;
      matrix.M43 = objectPosition.Z;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateBillboard(
      ref Vector3 objectPosition,
      ref Vector3 cameraPosition,
      ref Vector3 cameraUpVector,
      Vector3? cameraForwardVector,
      out Matrix result)
    {
      Vector3 result1;
      result1.X = objectPosition.X - cameraPosition.X;
      result1.Y = objectPosition.Y - cameraPosition.Y;
      result1.Z = objectPosition.Z - cameraPosition.Z;
      float num = result1.LengthSquared();
      if ((double) num < 9.99999974737875E-05)
        result1 = cameraForwardVector.HasValue ? -cameraForwardVector.Value : Vector3.Forward;
      else
        Vector3.Multiply(ref result1, 1f / (float) Math.Sqrt((double) num), out result1);
      Vector3 result2;
      Vector3.Cross(ref cameraUpVector, ref result1, out result2);
      result2.Normalize();
      Vector3 result3;
      Vector3.Cross(ref result1, ref result2, out result3);
      result.M11 = result2.X;
      result.M12 = result2.Y;
      result.M13 = result2.Z;
      result.M14 = 0.0f;
      result.M21 = result3.X;
      result.M22 = result3.Y;
      result.M23 = result3.Z;
      result.M24 = 0.0f;
      result.M31 = result1.X;
      result.M32 = result1.Y;
      result.M33 = result1.Z;
      result.M34 = 0.0f;
      result.M41 = objectPosition.X;
      result.M42 = objectPosition.Y;
      result.M43 = objectPosition.Z;
      result.M44 = 1f;
    }

    public static Matrix CreateConstrainedBillboard(
      Vector3 objectPosition,
      Vector3 cameraPosition,
      Vector3 rotateAxis,
      Vector3? cameraForwardVector,
      Vector3? objectForwardVector)
    {
      Vector3 result1;
      result1.X = objectPosition.X - cameraPosition.X;
      result1.Y = objectPosition.Y - cameraPosition.Y;
      result1.Z = objectPosition.Z - cameraPosition.Z;
      float num = result1.LengthSquared();
      if ((double) num < 9.99999974737875E-05)
        result1 = cameraForwardVector.HasValue ? -cameraForwardVector.Value : Vector3.Forward;
      else
        Vector3.Multiply(ref result1, 1f / (float) Math.Sqrt((double) num), out result1);
      Vector3 vector2 = rotateAxis;
      float result2;
      Vector3.Dot(ref rotateAxis, ref result1, out result2);
      Vector3 result3;
      Vector3 result4;
      if ((double) Math.Abs(result2) > 0.998254656791687)
      {
        if (objectForwardVector.HasValue)
        {
          result3 = objectForwardVector.Value;
          Vector3.Dot(ref rotateAxis, ref result3, out result2);
          if ((double) Math.Abs(result2) > 0.998254656791687)
            result3 = (double) Math.Abs((float) ((double) rotateAxis.X * (double) Vector3.Forward.X + (double) rotateAxis.Y * (double) Vector3.Forward.Y + (double) rotateAxis.Z * (double) Vector3.Forward.Z)) > 0.998254656791687 ? Vector3.Right : Vector3.Forward;
        }
        else
          result3 = (double) Math.Abs((float) ((double) rotateAxis.X * (double) Vector3.Forward.X + (double) rotateAxis.Y * (double) Vector3.Forward.Y + (double) rotateAxis.Z * (double) Vector3.Forward.Z)) > 0.998254656791687 ? Vector3.Right : Vector3.Forward;
        Vector3.Cross(ref rotateAxis, ref result3, out result4);
        result4.Normalize();
        Vector3.Cross(ref result4, ref rotateAxis, out result3);
        result3.Normalize();
      }
      else
      {
        Vector3.Cross(ref rotateAxis, ref result1, out result4);
        result4.Normalize();
        Vector3.Cross(ref result4, ref vector2, out result3);
        result3.Normalize();
      }
      Matrix matrix;
      matrix.M11 = result4.X;
      matrix.M12 = result4.Y;
      matrix.M13 = result4.Z;
      matrix.M14 = 0.0f;
      matrix.M21 = vector2.X;
      matrix.M22 = vector2.Y;
      matrix.M23 = vector2.Z;
      matrix.M24 = 0.0f;
      matrix.M31 = result3.X;
      matrix.M32 = result3.Y;
      matrix.M33 = result3.Z;
      matrix.M34 = 0.0f;
      matrix.M41 = objectPosition.X;
      matrix.M42 = objectPosition.Y;
      matrix.M43 = objectPosition.Z;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateConstrainedBillboard(
      ref Vector3 objectPosition,
      ref Vector3 cameraPosition,
      ref Vector3 rotateAxis,
      Vector3? cameraForwardVector,
      Vector3? objectForwardVector,
      out Matrix result)
    {
      Vector3 result1;
      result1.X = objectPosition.X - cameraPosition.X;
      result1.Y = objectPosition.Y - cameraPosition.Y;
      result1.Z = objectPosition.Z - cameraPosition.Z;
      float num = result1.LengthSquared();
      if ((double) num < 9.99999974737875E-05)
        result1 = cameraForwardVector.HasValue ? -cameraForwardVector.Value : Vector3.Forward;
      else
        Vector3.Multiply(ref result1, 1f / (float) Math.Sqrt((double) num), out result1);
      Vector3 vector2 = rotateAxis;
      float result2;
      Vector3.Dot(ref rotateAxis, ref result1, out result2);
      Vector3 result3;
      Vector3 result4;
      if ((double) Math.Abs(result2) > 0.998254656791687)
      {
        if (objectForwardVector.HasValue)
        {
          result3 = objectForwardVector.Value;
          Vector3.Dot(ref rotateAxis, ref result3, out result2);
          if ((double) Math.Abs(result2) > 0.998254656791687)
            result3 = (double) Math.Abs((float) ((double) rotateAxis.X * (double) Vector3.Forward.X + (double) rotateAxis.Y * (double) Vector3.Forward.Y + (double) rotateAxis.Z * (double) Vector3.Forward.Z)) > 0.998254656791687 ? Vector3.Right : Vector3.Forward;
        }
        else
          result3 = (double) Math.Abs((float) ((double) rotateAxis.X * (double) Vector3.Forward.X + (double) rotateAxis.Y * (double) Vector3.Forward.Y + (double) rotateAxis.Z * (double) Vector3.Forward.Z)) > 0.998254656791687 ? Vector3.Right : Vector3.Forward;
        Vector3.Cross(ref rotateAxis, ref result3, out result4);
        result4.Normalize();
        Vector3.Cross(ref result4, ref rotateAxis, out result3);
        result3.Normalize();
      }
      else
      {
        Vector3.Cross(ref rotateAxis, ref result1, out result4);
        result4.Normalize();
        Vector3.Cross(ref result4, ref vector2, out result3);
        result3.Normalize();
      }
      result.M11 = result4.X;
      result.M12 = result4.Y;
      result.M13 = result4.Z;
      result.M14 = 0.0f;
      result.M21 = vector2.X;
      result.M22 = vector2.Y;
      result.M23 = vector2.Z;
      result.M24 = 0.0f;
      result.M31 = result3.X;
      result.M32 = result3.Y;
      result.M33 = result3.Z;
      result.M34 = 0.0f;
      result.M41 = objectPosition.X;
      result.M42 = objectPosition.Y;
      result.M43 = objectPosition.Z;
      result.M44 = 1f;
    }

    public static Matrix CreateTranslation(Vector3 position)
    {
      Matrix matrix;
      matrix.M11 = 1f;
      matrix.M12 = 0.0f;
      matrix.M13 = 0.0f;
      matrix.M14 = 0.0f;
      matrix.M21 = 0.0f;
      matrix.M22 = 1f;
      matrix.M23 = 0.0f;
      matrix.M24 = 0.0f;
      matrix.M31 = 0.0f;
      matrix.M32 = 0.0f;
      matrix.M33 = 1f;
      matrix.M34 = 0.0f;
      matrix.M41 = position.X;
      matrix.M42 = position.Y;
      matrix.M43 = position.Z;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateTranslation(ref Vector3 position, out Matrix result)
    {
      result.M11 = 1f;
      result.M12 = 0.0f;
      result.M13 = 0.0f;
      result.M14 = 0.0f;
      result.M21 = 0.0f;
      result.M22 = 1f;
      result.M23 = 0.0f;
      result.M24 = 0.0f;
      result.M31 = 0.0f;
      result.M32 = 0.0f;
      result.M33 = 1f;
      result.M34 = 0.0f;
      result.M41 = position.X;
      result.M42 = position.Y;
      result.M43 = position.Z;
      result.M44 = 1f;
    }

    public static Matrix CreateTranslation(float xPosition, float yPosition, float zPosition)
    {
      Matrix matrix;
      matrix.M11 = 1f;
      matrix.M12 = 0.0f;
      matrix.M13 = 0.0f;
      matrix.M14 = 0.0f;
      matrix.M21 = 0.0f;
      matrix.M22 = 1f;
      matrix.M23 = 0.0f;
      matrix.M24 = 0.0f;
      matrix.M31 = 0.0f;
      matrix.M32 = 0.0f;
      matrix.M33 = 1f;
      matrix.M34 = 0.0f;
      matrix.M41 = xPosition;
      matrix.M42 = yPosition;
      matrix.M43 = zPosition;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateTranslation(
      float xPosition,
      float yPosition,
      float zPosition,
      out Matrix result)
    {
      result.M11 = 1f;
      result.M12 = 0.0f;
      result.M13 = 0.0f;
      result.M14 = 0.0f;
      result.M21 = 0.0f;
      result.M22 = 1f;
      result.M23 = 0.0f;
      result.M24 = 0.0f;
      result.M31 = 0.0f;
      result.M32 = 0.0f;
      result.M33 = 1f;
      result.M34 = 0.0f;
      result.M41 = xPosition;
      result.M42 = yPosition;
      result.M43 = zPosition;
      result.M44 = 1f;
    }

    public static Matrix CreateScale(float xScale, float yScale, float zScale)
    {
      float num1 = xScale;
      float num2 = yScale;
      float num3 = zScale;
      Matrix matrix;
      matrix.M11 = num1;
      matrix.M12 = 0.0f;
      matrix.M13 = 0.0f;
      matrix.M14 = 0.0f;
      matrix.M21 = 0.0f;
      matrix.M22 = num2;
      matrix.M23 = 0.0f;
      matrix.M24 = 0.0f;
      matrix.M31 = 0.0f;
      matrix.M32 = 0.0f;
      matrix.M33 = num3;
      matrix.M34 = 0.0f;
      matrix.M41 = 0.0f;
      matrix.M42 = 0.0f;
      matrix.M43 = 0.0f;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateScale(float xScale, float yScale, float zScale, out Matrix result)
    {
      float num1 = xScale;
      float num2 = yScale;
      float num3 = zScale;
      result.M11 = num1;
      result.M12 = 0.0f;
      result.M13 = 0.0f;
      result.M14 = 0.0f;
      result.M21 = 0.0f;
      result.M22 = num2;
      result.M23 = 0.0f;
      result.M24 = 0.0f;
      result.M31 = 0.0f;
      result.M32 = 0.0f;
      result.M33 = num3;
      result.M34 = 0.0f;
      result.M41 = 0.0f;
      result.M42 = 0.0f;
      result.M43 = 0.0f;
      result.M44 = 1f;
    }

    public static Matrix CreateScale(Vector3 scales)
    {
      float x = scales.X;
      float y = scales.Y;
      float z = scales.Z;
      Matrix matrix;
      matrix.M11 = x;
      matrix.M12 = 0.0f;
      matrix.M13 = 0.0f;
      matrix.M14 = 0.0f;
      matrix.M21 = 0.0f;
      matrix.M22 = y;
      matrix.M23 = 0.0f;
      matrix.M24 = 0.0f;
      matrix.M31 = 0.0f;
      matrix.M32 = 0.0f;
      matrix.M33 = z;
      matrix.M34 = 0.0f;
      matrix.M41 = 0.0f;
      matrix.M42 = 0.0f;
      matrix.M43 = 0.0f;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateScale(ref Vector3 scales, out Matrix result)
    {
      float x = scales.X;
      float y = scales.Y;
      float z = scales.Z;
      result.M11 = x;
      result.M12 = 0.0f;
      result.M13 = 0.0f;
      result.M14 = 0.0f;
      result.M21 = 0.0f;
      result.M22 = y;
      result.M23 = 0.0f;
      result.M24 = 0.0f;
      result.M31 = 0.0f;
      result.M32 = 0.0f;
      result.M33 = z;
      result.M34 = 0.0f;
      result.M41 = 0.0f;
      result.M42 = 0.0f;
      result.M43 = 0.0f;
      result.M44 = 1f;
    }

    public static Matrix CreateScale(float scale)
    {
      float num = scale;
      Matrix matrix;
      matrix.M11 = num;
      matrix.M12 = 0.0f;
      matrix.M13 = 0.0f;
      matrix.M14 = 0.0f;
      matrix.M21 = 0.0f;
      matrix.M22 = num;
      matrix.M23 = 0.0f;
      matrix.M24 = 0.0f;
      matrix.M31 = 0.0f;
      matrix.M32 = 0.0f;
      matrix.M33 = num;
      matrix.M34 = 0.0f;
      matrix.M41 = 0.0f;
      matrix.M42 = 0.0f;
      matrix.M43 = 0.0f;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateScale(float scale, out Matrix result)
    {
      float num = scale;
      result.M11 = num;
      result.M12 = 0.0f;
      result.M13 = 0.0f;
      result.M14 = 0.0f;
      result.M21 = 0.0f;
      result.M22 = num;
      result.M23 = 0.0f;
      result.M24 = 0.0f;
      result.M31 = 0.0f;
      result.M32 = 0.0f;
      result.M33 = num;
      result.M34 = 0.0f;
      result.M41 = 0.0f;
      result.M42 = 0.0f;
      result.M43 = 0.0f;
      result.M44 = 1f;
    }

    public static Matrix CreateRotationX(float radians)
    {
      float num1 = (float) Math.Cos((double) radians);
      float num2 = (float) Math.Sin((double) radians);
      Matrix matrix;
      matrix.M11 = 1f;
      matrix.M12 = 0.0f;
      matrix.M13 = 0.0f;
      matrix.M14 = 0.0f;
      matrix.M21 = 0.0f;
      matrix.M22 = num1;
      matrix.M23 = num2;
      matrix.M24 = 0.0f;
      matrix.M31 = 0.0f;
      matrix.M32 = -num2;
      matrix.M33 = num1;
      matrix.M34 = 0.0f;
      matrix.M41 = 0.0f;
      matrix.M42 = 0.0f;
      matrix.M43 = 0.0f;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateRotationX(float radians, out Matrix result)
    {
      float num1 = (float) Math.Cos((double) radians);
      float num2 = (float) Math.Sin((double) radians);
      result.M11 = 1f;
      result.M12 = 0.0f;
      result.M13 = 0.0f;
      result.M14 = 0.0f;
      result.M21 = 0.0f;
      result.M22 = num1;
      result.M23 = num2;
      result.M24 = 0.0f;
      result.M31 = 0.0f;
      result.M32 = -num2;
      result.M33 = num1;
      result.M34 = 0.0f;
      result.M41 = 0.0f;
      result.M42 = 0.0f;
      result.M43 = 0.0f;
      result.M44 = 1f;
    }

    public static Matrix CreateRotationY(float radians)
    {
      float num1 = (float) Math.Cos((double) radians);
      float num2 = (float) Math.Sin((double) radians);
      Matrix matrix;
      matrix.M11 = num1;
      matrix.M12 = 0.0f;
      matrix.M13 = -num2;
      matrix.M14 = 0.0f;
      matrix.M21 = 0.0f;
      matrix.M22 = 1f;
      matrix.M23 = 0.0f;
      matrix.M24 = 0.0f;
      matrix.M31 = num2;
      matrix.M32 = 0.0f;
      matrix.M33 = num1;
      matrix.M34 = 0.0f;
      matrix.M41 = 0.0f;
      matrix.M42 = 0.0f;
      matrix.M43 = 0.0f;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateRotationY(float radians, out Matrix result)
    {
      float num1 = (float) Math.Cos((double) radians);
      float num2 = (float) Math.Sin((double) radians);
      result.M11 = num1;
      result.M12 = 0.0f;
      result.M13 = -num2;
      result.M14 = 0.0f;
      result.M21 = 0.0f;
      result.M22 = 1f;
      result.M23 = 0.0f;
      result.M24 = 0.0f;
      result.M31 = num2;
      result.M32 = 0.0f;
      result.M33 = num1;
      result.M34 = 0.0f;
      result.M41 = 0.0f;
      result.M42 = 0.0f;
      result.M43 = 0.0f;
      result.M44 = 1f;
    }

    public static Matrix CreateRotationZ(float radians)
    {
      float num1 = (float) Math.Cos((double) radians);
      float num2 = (float) Math.Sin((double) radians);
      Matrix matrix;
      matrix.M11 = num1;
      matrix.M12 = num2;
      matrix.M13 = 0.0f;
      matrix.M14 = 0.0f;
      matrix.M21 = -num2;
      matrix.M22 = num1;
      matrix.M23 = 0.0f;
      matrix.M24 = 0.0f;
      matrix.M31 = 0.0f;
      matrix.M32 = 0.0f;
      matrix.M33 = 1f;
      matrix.M34 = 0.0f;
      matrix.M41 = 0.0f;
      matrix.M42 = 0.0f;
      matrix.M43 = 0.0f;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateRotationZ(float radians, out Matrix result)
    {
      float num1 = (float) Math.Cos((double) radians);
      float num2 = (float) Math.Sin((double) radians);
      result.M11 = num1;
      result.M12 = num2;
      result.M13 = 0.0f;
      result.M14 = 0.0f;
      result.M21 = -num2;
      result.M22 = num1;
      result.M23 = 0.0f;
      result.M24 = 0.0f;
      result.M31 = 0.0f;
      result.M32 = 0.0f;
      result.M33 = 1f;
      result.M34 = 0.0f;
      result.M41 = 0.0f;
      result.M42 = 0.0f;
      result.M43 = 0.0f;
      result.M44 = 1f;
    }

    public static Matrix CreateFromAxisAngle(Vector3 axis, float angle)
    {
      float x = axis.X;
      float y = axis.Y;
      float z = axis.Z;
      float num1 = (float) Math.Sin((double) angle);
      float num2 = (float) Math.Cos((double) angle);
      double num3 = (double) x;
      float num4 = (float) (num3 * num3);
      double num5 = (double) y;
      float num6 = (float) (num5 * num5);
      double num7 = (double) z;
      float num8 = (float) (num7 * num7);
      float num9 = x * y;
      float num10 = x * z;
      float num11 = y * z;
      Matrix matrix;
      matrix.M11 = num4 + num2 * (1f - num4);
      matrix.M12 = (float) ((double) num9 - (double) num2 * (double) num9 + (double) num1 * (double) z);
      matrix.M13 = (float) ((double) num10 - (double) num2 * (double) num10 - (double) num1 * (double) y);
      matrix.M14 = 0.0f;
      matrix.M21 = (float) ((double) num9 - (double) num2 * (double) num9 - (double) num1 * (double) z);
      matrix.M22 = num6 + num2 * (1f - num6);
      matrix.M23 = (float) ((double) num11 - (double) num2 * (double) num11 + (double) num1 * (double) x);
      matrix.M24 = 0.0f;
      matrix.M31 = (float) ((double) num10 - (double) num2 * (double) num10 + (double) num1 * (double) y);
      matrix.M32 = (float) ((double) num11 - (double) num2 * (double) num11 - (double) num1 * (double) x);
      matrix.M33 = num8 + num2 * (1f - num8);
      matrix.M34 = 0.0f;
      matrix.M41 = 0.0f;
      matrix.M42 = 0.0f;
      matrix.M43 = 0.0f;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Matrix result)
    {
      float x = axis.X;
      float y = axis.Y;
      float z = axis.Z;
      float num1 = (float) Math.Sin((double) angle);
      float num2 = (float) Math.Cos((double) angle);
      double num3 = (double) x;
      float num4 = (float) (num3 * num3);
      double num5 = (double) y;
      float num6 = (float) (num5 * num5);
      double num7 = (double) z;
      float num8 = (float) (num7 * num7);
      float num9 = x * y;
      float num10 = x * z;
      float num11 = y * z;
      result.M11 = num4 + num2 * (1f - num4);
      result.M12 = (float) ((double) num9 - (double) num2 * (double) num9 + (double) num1 * (double) z);
      result.M13 = (float) ((double) num10 - (double) num2 * (double) num10 - (double) num1 * (double) y);
      result.M14 = 0.0f;
      result.M21 = (float) ((double) num9 - (double) num2 * (double) num9 - (double) num1 * (double) z);
      result.M22 = num6 + num2 * (1f - num6);
      result.M23 = (float) ((double) num11 - (double) num2 * (double) num11 + (double) num1 * (double) x);
      result.M24 = 0.0f;
      result.M31 = (float) ((double) num10 - (double) num2 * (double) num10 + (double) num1 * (double) y);
      result.M32 = (float) ((double) num11 - (double) num2 * (double) num11 - (double) num1 * (double) x);
      result.M33 = num8 + num2 * (1f - num8);
      result.M34 = 0.0f;
      result.M41 = 0.0f;
      result.M42 = 0.0f;
      result.M43 = 0.0f;
      result.M44 = 1f;
    }

    public static Matrix CreatePerspectiveFieldOfView(
      float fieldOfView,
      float aspectRatio,
      float nearPlaneDistance,
      float farPlaneDistance)
    {
      if ((double) fieldOfView <= 0.0 || (double) fieldOfView >= 3.14159274101257)
        throw new ArgumentOutOfRangeException(nameof (fieldOfView), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.OutRangeFieldOfView, (object) nameof (fieldOfView)));
      if ((double) nearPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (nearPlaneDistance)));
      if ((double) farPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (farPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (farPlaneDistance)));
      if ((double) nearPlaneDistance >= (double) farPlaneDistance)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), FrameworkResources.OppositePlanes);
      float num1 = 1f / (float) Math.Tan((double) fieldOfView * 0.5);
      float num2 = num1 / aspectRatio;
      Matrix matrix;
      matrix.M11 = num2;
      ref Matrix local1 = ref matrix;
      double num3;
      float num4 = (float) (num3 = 0.0);
      local1.M14 = (float) num3;
      double num5;
      float num6 = (float) (num5 = (double) num4);
      local1.M13 = (float) num5;
      local1.M12 = num6;
      matrix.M22 = num1;
      ref Matrix local2 = ref matrix;
      double num7;
      float num8 = (float) (num7 = 0.0);
      local2.M24 = (float) num7;
      double num9;
      float num10 = (float) (num9 = (double) num8);
      local2.M23 = (float) num9;
      local2.M21 = num10;
      ref Matrix local3 = ref matrix;
      double num11;
      float num12 = (float) (num11 = 0.0);
      local3.M32 = (float) num11;
      local3.M31 = num12;
      matrix.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
      matrix.M34 = -1f;
      ref Matrix local4 = ref matrix;
      double num13;
      float num14 = (float) (num13 = 0.0);
      local4.M44 = (float) num13;
      double num15;
      float num16 = (float) (num15 = (double) num14);
      local4.M42 = (float) num15;
      local4.M41 = num16;
      matrix.M43 = (float) ((double) nearPlaneDistance * (double) farPlaneDistance / ((double) nearPlaneDistance - (double) farPlaneDistance));
      return matrix;
    }

    public static void CreatePerspectiveFieldOfView(
      float fieldOfView,
      float aspectRatio,
      float nearPlaneDistance,
      float farPlaneDistance,
      out Matrix result)
    {
      if ((double) fieldOfView <= 0.0 || (double) fieldOfView >= 3.14159274101257)
        throw new ArgumentOutOfRangeException(nameof (fieldOfView), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.OutRangeFieldOfView, (object) nameof (fieldOfView)));
      if ((double) nearPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (nearPlaneDistance)));
      if ((double) farPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (farPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (farPlaneDistance)));
      if ((double) nearPlaneDistance >= (double) farPlaneDistance)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), FrameworkResources.OppositePlanes);
      float num1 = 1f / (float) Math.Tan((double) fieldOfView * 0.5);
      float num2 = num1 / aspectRatio;
      result.M11 = num2;
      ref Matrix local1 = ref result;
      double num3;
      float num4 = (float) (num3 = 0.0);
      local1.M14 = (float) num3;
      double num5;
      float num6 = (float) (num5 = (double) num4);
      local1.M13 = (float) num5;
      local1.M12 = num6;
      result.M22 = num1;
      ref Matrix local2 = ref result;
      double num7;
      float num8 = (float) (num7 = 0.0);
      local2.M24 = (float) num7;
      double num9;
      float num10 = (float) (num9 = (double) num8);
      local2.M23 = (float) num9;
      local2.M21 = num10;
      ref Matrix local3 = ref result;
      double num11;
      float num12 = (float) (num11 = 0.0);
      local3.M32 = (float) num11;
      local3.M31 = num12;
      result.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
      result.M34 = -1f;
      ref Matrix local4 = ref result;
      double num13;
      float num14 = (float) (num13 = 0.0);
      local4.M44 = (float) num13;
      double num15;
      float num16 = (float) (num15 = (double) num14);
      local4.M42 = (float) num15;
      local4.M41 = num16;
      result.M43 = (float) ((double) nearPlaneDistance * (double) farPlaneDistance / ((double) nearPlaneDistance - (double) farPlaneDistance));
    }

    public static Matrix CreatePerspective(
      float width,
      float height,
      float nearPlaneDistance,
      float farPlaneDistance)
    {
      if ((double) nearPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (nearPlaneDistance)));
      if ((double) farPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (farPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (farPlaneDistance)));
      if ((double) nearPlaneDistance >= (double) farPlaneDistance)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), FrameworkResources.OppositePlanes);
      Matrix matrix;
      matrix.M11 = 2f * nearPlaneDistance / width;
      ref Matrix local1 = ref matrix;
      double num1;
      float num2 = (float) (num1 = 0.0);
      local1.M14 = (float) num1;
      double num3;
      float num4 = (float) (num3 = (double) num2);
      local1.M13 = (float) num3;
      local1.M12 = num4;
      matrix.M22 = 2f * nearPlaneDistance / height;
      ref Matrix local2 = ref matrix;
      double num5;
      float num6 = (float) (num5 = 0.0);
      local2.M24 = (float) num5;
      double num7;
      float num8 = (float) (num7 = (double) num6);
      local2.M23 = (float) num7;
      local2.M21 = num8;
      matrix.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
      ref Matrix local3 = ref matrix;
      double num9;
      float num10 = (float) (num9 = 0.0);
      local3.M32 = (float) num9;
      local3.M31 = num10;
      matrix.M34 = -1f;
      ref Matrix local4 = ref matrix;
      double num11;
      float num12 = (float) (num11 = 0.0);
      local4.M44 = (float) num11;
      double num13;
      float num14 = (float) (num13 = (double) num12);
      local4.M42 = (float) num13;
      local4.M41 = num14;
      matrix.M43 = (float) ((double) nearPlaneDistance * (double) farPlaneDistance / ((double) nearPlaneDistance - (double) farPlaneDistance));
      return matrix;
    }

    public static void CreatePerspective(
      float width,
      float height,
      float nearPlaneDistance,
      float farPlaneDistance,
      out Matrix result)
    {
      if ((double) nearPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (nearPlaneDistance)));
      if ((double) farPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (farPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (farPlaneDistance)));
      if ((double) nearPlaneDistance >= (double) farPlaneDistance)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), FrameworkResources.OppositePlanes);
      result.M11 = 2f * nearPlaneDistance / width;
      ref Matrix local1 = ref result;
      double num1;
      float num2 = (float) (num1 = 0.0);
      local1.M14 = (float) num1;
      double num3;
      float num4 = (float) (num3 = (double) num2);
      local1.M13 = (float) num3;
      local1.M12 = num4;
      result.M22 = 2f * nearPlaneDistance / height;
      ref Matrix local2 = ref result;
      double num5;
      float num6 = (float) (num5 = 0.0);
      local2.M24 = (float) num5;
      double num7;
      float num8 = (float) (num7 = (double) num6);
      local2.M23 = (float) num7;
      local2.M21 = num8;
      result.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
      ref Matrix local3 = ref result;
      double num9;
      float num10 = (float) (num9 = 0.0);
      local3.M32 = (float) num9;
      local3.M31 = num10;
      result.M34 = -1f;
      ref Matrix local4 = ref result;
      double num11;
      float num12 = (float) (num11 = 0.0);
      local4.M44 = (float) num11;
      double num13;
      float num14 = (float) (num13 = (double) num12);
      local4.M42 = (float) num13;
      local4.M41 = num14;
      result.M43 = (float) ((double) nearPlaneDistance * (double) farPlaneDistance / ((double) nearPlaneDistance - (double) farPlaneDistance));
    }

    public static Matrix CreatePerspectiveOffCenter(
      float left,
      float right,
      float bottom,
      float top,
      float nearPlaneDistance,
      float farPlaneDistance)
    {
      if ((double) nearPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (nearPlaneDistance)));
      if ((double) farPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (farPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (farPlaneDistance)));
      if ((double) nearPlaneDistance >= (double) farPlaneDistance)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), FrameworkResources.OppositePlanes);
      Matrix matrix;
      matrix.M11 = (float) (2.0 * (double) nearPlaneDistance / ((double) right - (double) left));
      ref Matrix local1 = ref matrix;
      double num1;
      float num2 = (float) (num1 = 0.0);
      local1.M14 = (float) num1;
      double num3;
      float num4 = (float) (num3 = (double) num2);
      local1.M13 = (float) num3;
      local1.M12 = num4;
      matrix.M22 = (float) (2.0 * (double) nearPlaneDistance / ((double) top - (double) bottom));
      ref Matrix local2 = ref matrix;
      double num5;
      float num6 = (float) (num5 = 0.0);
      local2.M24 = (float) num5;
      double num7;
      float num8 = (float) (num7 = (double) num6);
      local2.M23 = (float) num7;
      local2.M21 = num8;
      matrix.M31 = (float) (((double) left + (double) right) / ((double) right - (double) left));
      matrix.M32 = (float) (((double) top + (double) bottom) / ((double) top - (double) bottom));
      matrix.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
      matrix.M34 = -1f;
      matrix.M43 = (float) ((double) nearPlaneDistance * (double) farPlaneDistance / ((double) nearPlaneDistance - (double) farPlaneDistance));
      ref Matrix local3 = ref matrix;
      double num9;
      float num10 = (float) (num9 = 0.0);
      local3.M44 = (float) num9;
      double num11;
      float num12 = (float) (num11 = (double) num10);
      local3.M42 = (float) num11;
      local3.M41 = num12;
      return matrix;
    }

    public static void CreatePerspectiveOffCenter(
      float left,
      float right,
      float bottom,
      float top,
      float nearPlaneDistance,
      float farPlaneDistance,
      out Matrix result)
    {
      if ((double) nearPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (nearPlaneDistance)));
      if ((double) farPlaneDistance <= 0.0)
        throw new ArgumentOutOfRangeException(nameof (farPlaneDistance), string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.NegativePlaneDistance, (object) nameof (farPlaneDistance)));
      if ((double) nearPlaneDistance >= (double) farPlaneDistance)
        throw new ArgumentOutOfRangeException(nameof (nearPlaneDistance), FrameworkResources.OppositePlanes);
      result.M11 = (float) (2.0 * (double) nearPlaneDistance / ((double) right - (double) left));
      ref Matrix local1 = ref result;
      double num1;
      float num2 = (float) (num1 = 0.0);
      local1.M14 = (float) num1;
      double num3;
      float num4 = (float) (num3 = (double) num2);
      local1.M13 = (float) num3;
      local1.M12 = num4;
      result.M22 = (float) (2.0 * (double) nearPlaneDistance / ((double) top - (double) bottom));
      ref Matrix local2 = ref result;
      double num5;
      float num6 = (float) (num5 = 0.0);
      local2.M24 = (float) num5;
      double num7;
      float num8 = (float) (num7 = (double) num6);
      local2.M23 = (float) num7;
      local2.M21 = num8;
      result.M31 = (float) (((double) left + (double) right) / ((double) right - (double) left));
      result.M32 = (float) (((double) top + (double) bottom) / ((double) top - (double) bottom));
      result.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
      result.M34 = -1f;
      result.M43 = (float) ((double) nearPlaneDistance * (double) farPlaneDistance / ((double) nearPlaneDistance - (double) farPlaneDistance));
      ref Matrix local3 = ref result;
      double num9;
      float num10 = (float) (num9 = 0.0);
      local3.M44 = (float) num9;
      double num11;
      float num12 = (float) (num11 = (double) num10);
      local3.M42 = (float) num11;
      local3.M41 = num12;
    }

    public static Matrix CreateOrthographic(
      float width,
      float height,
      float zNearPlane,
      float zFarPlane)
    {
      Matrix matrix;
      matrix.M11 = 2f / width;
      ref Matrix local1 = ref matrix;
      double num1;
      float num2 = (float) (num1 = 0.0);
      local1.M14 = (float) num1;
      double num3;
      float num4 = (float) (num3 = (double) num2);
      local1.M13 = (float) num3;
      local1.M12 = num4;
      matrix.M22 = 2f / height;
      ref Matrix local2 = ref matrix;
      double num5;
      float num6 = (float) (num5 = 0.0);
      local2.M24 = (float) num5;
      double num7;
      float num8 = (float) (num7 = (double) num6);
      local2.M23 = (float) num7;
      local2.M21 = num8;
      matrix.M33 = (float) (1.0 / ((double) zNearPlane - (double) zFarPlane));
      ref Matrix local3 = ref matrix;
      double num9;
      float num10 = (float) (num9 = 0.0);
      local3.M34 = (float) num9;
      double num11;
      float num12 = (float) (num11 = (double) num10);
      local3.M32 = (float) num11;
      local3.M31 = num12;
      ref Matrix local4 = ref matrix;
      double num13;
      float num14 = (float) (num13 = 0.0);
      local4.M42 = (float) num13;
      local4.M41 = num14;
      ref Matrix local5 = ref matrix;
      double num15 = (double) zNearPlane;
      double num16 = num15 / (num15 - (double) zFarPlane);
      local5.M43 = (float) num16;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateOrthographic(
      float width,
      float height,
      float zNearPlane,
      float zFarPlane,
      out Matrix result)
    {
      result.M11 = 2f / width;
      ref Matrix local1 = ref result;
      double num1;
      float num2 = (float) (num1 = 0.0);
      local1.M14 = (float) num1;
      double num3;
      float num4 = (float) (num3 = (double) num2);
      local1.M13 = (float) num3;
      local1.M12 = num4;
      result.M22 = 2f / height;
      ref Matrix local2 = ref result;
      double num5;
      float num6 = (float) (num5 = 0.0);
      local2.M24 = (float) num5;
      double num7;
      float num8 = (float) (num7 = (double) num6);
      local2.M23 = (float) num7;
      local2.M21 = num8;
      result.M33 = (float) (1.0 / ((double) zNearPlane - (double) zFarPlane));
      ref Matrix local3 = ref result;
      double num9;
      float num10 = (float) (num9 = 0.0);
      local3.M34 = (float) num9;
      double num11;
      float num12 = (float) (num11 = (double) num10);
      local3.M32 = (float) num11;
      local3.M31 = num12;
      ref Matrix local4 = ref result;
      double num13;
      float num14 = (float) (num13 = 0.0);
      local4.M42 = (float) num13;
      local4.M41 = num14;
      ref Matrix local5 = ref result;
      double num15 = (double) zNearPlane;
      double num16 = num15 / (num15 - (double) zFarPlane);
      local5.M43 = (float) num16;
      result.M44 = 1f;
    }

    public static Matrix CreateOrthographicOffCenter(
      float left,
      float right,
      float bottom,
      float top,
      float zNearPlane,
      float zFarPlane)
    {
      Matrix matrix;
      matrix.M11 = (float) (2.0 / ((double) right - (double) left));
      ref Matrix local1 = ref matrix;
      double num1;
      float num2 = (float) (num1 = 0.0);
      local1.M14 = (float) num1;
      double num3;
      float num4 = (float) (num3 = (double) num2);
      local1.M13 = (float) num3;
      local1.M12 = num4;
      matrix.M22 = (float) (2.0 / ((double) top - (double) bottom));
      ref Matrix local2 = ref matrix;
      double num5;
      float num6 = (float) (num5 = 0.0);
      local2.M24 = (float) num5;
      double num7;
      float num8 = (float) (num7 = (double) num6);
      local2.M23 = (float) num7;
      local2.M21 = num8;
      matrix.M33 = (float) (1.0 / ((double) zNearPlane - (double) zFarPlane));
      ref Matrix local3 = ref matrix;
      double num9;
      float num10 = (float) (num9 = 0.0);
      local3.M34 = (float) num9;
      double num11;
      float num12 = (float) (num11 = (double) num10);
      local3.M32 = (float) num11;
      local3.M31 = num12;
      matrix.M41 = (float) (((double) left + (double) right) / ((double) left - (double) right));
      matrix.M42 = (float) (((double) top + (double) bottom) / ((double) bottom - (double) top));
      ref Matrix local4 = ref matrix;
      double num13 = (double) zNearPlane;
      double num14 = num13 / (num13 - (double) zFarPlane);
      local4.M43 = (float) num14;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateOrthographicOffCenter(
      float left,
      float right,
      float bottom,
      float top,
      float zNearPlane,
      float zFarPlane,
      out Matrix result)
    {
      result.M11 = (float) (2.0 / ((double) right - (double) left));
      ref Matrix local1 = ref result;
      double num1;
      float num2 = (float) (num1 = 0.0);
      local1.M14 = (float) num1;
      double num3;
      float num4 = (float) (num3 = (double) num2);
      local1.M13 = (float) num3;
      local1.M12 = num4;
      result.M22 = (float) (2.0 / ((double) top - (double) bottom));
      ref Matrix local2 = ref result;
      double num5;
      float num6 = (float) (num5 = 0.0);
      local2.M24 = (float) num5;
      double num7;
      float num8 = (float) (num7 = (double) num6);
      local2.M23 = (float) num7;
      local2.M21 = num8;
      result.M33 = (float) (1.0 / ((double) zNearPlane - (double) zFarPlane));
      ref Matrix local3 = ref result;
      double num9;
      float num10 = (float) (num9 = 0.0);
      local3.M34 = (float) num9;
      double num11;
      float num12 = (float) (num11 = (double) num10);
      local3.M32 = (float) num11;
      local3.M31 = num12;
      result.M41 = (float) (((double) left + (double) right) / ((double) left - (double) right));
      result.M42 = (float) (((double) top + (double) bottom) / ((double) bottom - (double) top));
      ref Matrix local4 = ref result;
      double num13 = (double) zNearPlane;
      double num14 = num13 / (num13 - (double) zFarPlane);
      local4.M43 = (float) num14;
      result.M44 = 1f;
    }

    public static Matrix CreateLookAt(
      Vector3 cameraPosition,
      Vector3 cameraTarget,
      Vector3 cameraUpVector)
    {
      Vector3 vector3_1 = Vector3.Normalize(cameraPosition - cameraTarget);
      Vector3 vector3_2 = Vector3.Normalize(Vector3.Cross(cameraUpVector, vector3_1));
      Vector3 vector1 = Vector3.Cross(vector3_1, vector3_2);
      Matrix matrix;
      matrix.M11 = vector3_2.X;
      matrix.M12 = vector1.X;
      matrix.M13 = vector3_1.X;
      matrix.M14 = 0.0f;
      matrix.M21 = vector3_2.Y;
      matrix.M22 = vector1.Y;
      matrix.M23 = vector3_1.Y;
      matrix.M24 = 0.0f;
      matrix.M31 = vector3_2.Z;
      matrix.M32 = vector1.Z;
      matrix.M33 = vector3_1.Z;
      matrix.M34 = 0.0f;
      matrix.M41 = -Vector3.Dot(vector3_2, cameraPosition);
      matrix.M42 = -Vector3.Dot(vector1, cameraPosition);
      matrix.M43 = -Vector3.Dot(vector3_1, cameraPosition);
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateLookAt(
      ref Vector3 cameraPosition,
      ref Vector3 cameraTarget,
      ref Vector3 cameraUpVector,
      out Matrix result)
    {
      Vector3 vector3_1 = Vector3.Normalize(cameraPosition - cameraTarget);
      Vector3 vector3_2 = Vector3.Normalize(Vector3.Cross(cameraUpVector, vector3_1));
      Vector3 vector1 = Vector3.Cross(vector3_1, vector3_2);
      result.M11 = vector3_2.X;
      result.M12 = vector1.X;
      result.M13 = vector3_1.X;
      result.M14 = 0.0f;
      result.M21 = vector3_2.Y;
      result.M22 = vector1.Y;
      result.M23 = vector3_1.Y;
      result.M24 = 0.0f;
      result.M31 = vector3_2.Z;
      result.M32 = vector1.Z;
      result.M33 = vector3_1.Z;
      result.M34 = 0.0f;
      result.M41 = -Vector3.Dot(vector3_2, cameraPosition);
      result.M42 = -Vector3.Dot(vector1, cameraPosition);
      result.M43 = -Vector3.Dot(vector3_1, cameraPosition);
      result.M44 = 1f;
    }

    public static Matrix CreateWorld(Vector3 position, Vector3 forward, Vector3 up)
    {
      Vector3 vector3_1 = Vector3.Normalize(-forward);
      Vector3 vector2 = Vector3.Normalize(Vector3.Cross(up, vector3_1));
      Vector3 vector3_2 = Vector3.Cross(vector3_1, vector2);
      Matrix matrix;
      matrix.M11 = vector2.X;
      matrix.M12 = vector2.Y;
      matrix.M13 = vector2.Z;
      matrix.M14 = 0.0f;
      matrix.M21 = vector3_2.X;
      matrix.M22 = vector3_2.Y;
      matrix.M23 = vector3_2.Z;
      matrix.M24 = 0.0f;
      matrix.M31 = vector3_1.X;
      matrix.M32 = vector3_1.Y;
      matrix.M33 = vector3_1.Z;
      matrix.M34 = 0.0f;
      matrix.M41 = position.X;
      matrix.M42 = position.Y;
      matrix.M43 = position.Z;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateWorld(
      ref Vector3 position,
      ref Vector3 forward,
      ref Vector3 up,
      out Matrix result)
    {
      Vector3 vector3_1 = Vector3.Normalize(-forward);
      Vector3 vector2 = Vector3.Normalize(Vector3.Cross(up, vector3_1));
      Vector3 vector3_2 = Vector3.Cross(vector3_1, vector2);
      result.M11 = vector2.X;
      result.M12 = vector2.Y;
      result.M13 = vector2.Z;
      result.M14 = 0.0f;
      result.M21 = vector3_2.X;
      result.M22 = vector3_2.Y;
      result.M23 = vector3_2.Z;
      result.M24 = 0.0f;
      result.M31 = vector3_1.X;
      result.M32 = vector3_1.Y;
      result.M33 = vector3_1.Z;
      result.M34 = 0.0f;
      result.M41 = position.X;
      result.M42 = position.Y;
      result.M43 = position.Z;
      result.M44 = 1f;
    }

    public static Matrix CreateFromQuaternion(Quaternion quaternion)
    {
      float num1 = quaternion.X * quaternion.X;
      float num2 = quaternion.Y * quaternion.Y;
      float num3 = quaternion.Z * quaternion.Z;
      float num4 = quaternion.X * quaternion.Y;
      float num5 = quaternion.Z * quaternion.W;
      float num6 = quaternion.Z * quaternion.X;
      float num7 = quaternion.Y * quaternion.W;
      float num8 = quaternion.Y * quaternion.Z;
      float num9 = quaternion.X * quaternion.W;
      Matrix matrix;
      matrix.M11 = (float) (1.0 - 2.0 * ((double) num2 + (double) num3));
      matrix.M12 = (float) (2.0 * ((double) num4 + (double) num5));
      matrix.M13 = (float) (2.0 * ((double) num6 - (double) num7));
      matrix.M14 = 0.0f;
      matrix.M21 = (float) (2.0 * ((double) num4 - (double) num5));
      matrix.M22 = (float) (1.0 - 2.0 * ((double) num3 + (double) num1));
      matrix.M23 = (float) (2.0 * ((double) num8 + (double) num9));
      matrix.M24 = 0.0f;
      matrix.M31 = (float) (2.0 * ((double) num6 + (double) num7));
      matrix.M32 = (float) (2.0 * ((double) num8 - (double) num9));
      matrix.M33 = (float) (1.0 - 2.0 * ((double) num2 + (double) num1));
      matrix.M34 = 0.0f;
      matrix.M41 = 0.0f;
      matrix.M42 = 0.0f;
      matrix.M43 = 0.0f;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix result)
    {
      float num1 = quaternion.X * quaternion.X;
      float num2 = quaternion.Y * quaternion.Y;
      float num3 = quaternion.Z * quaternion.Z;
      float num4 = quaternion.X * quaternion.Y;
      float num5 = quaternion.Z * quaternion.W;
      float num6 = quaternion.Z * quaternion.X;
      float num7 = quaternion.Y * quaternion.W;
      float num8 = quaternion.Y * quaternion.Z;
      float num9 = quaternion.X * quaternion.W;
      result.M11 = (float) (1.0 - 2.0 * ((double) num2 + (double) num3));
      result.M12 = (float) (2.0 * ((double) num4 + (double) num5));
      result.M13 = (float) (2.0 * ((double) num6 - (double) num7));
      result.M14 = 0.0f;
      result.M21 = (float) (2.0 * ((double) num4 - (double) num5));
      result.M22 = (float) (1.0 - 2.0 * ((double) num3 + (double) num1));
      result.M23 = (float) (2.0 * ((double) num8 + (double) num9));
      result.M24 = 0.0f;
      result.M31 = (float) (2.0 * ((double) num6 + (double) num7));
      result.M32 = (float) (2.0 * ((double) num8 - (double) num9));
      result.M33 = (float) (1.0 - 2.0 * ((double) num2 + (double) num1));
      result.M34 = 0.0f;
      result.M41 = 0.0f;
      result.M42 = 0.0f;
      result.M43 = 0.0f;
      result.M44 = 1f;
    }

    public static Matrix CreateFromYawPitchRoll(float yaw, float pitch, float roll)
    {
      Quaternion result1;
      Quaternion.CreateFromYawPitchRoll(yaw, pitch, roll, out result1);
      Matrix result2;
      Matrix.CreateFromQuaternion(ref result1, out result2);
      return result2;
    }

    public static void CreateFromYawPitchRoll(
      float yaw,
      float pitch,
      float roll,
      out Matrix result)
    {
      Quaternion result1;
      Quaternion.CreateFromYawPitchRoll(yaw, pitch, roll, out result1);
      Matrix.CreateFromQuaternion(ref result1, out result);
    }

    public static Matrix CreateShadow(Vector3 lightDirection, Plane plane)
    {
      Plane result;
      Plane.Normalize(ref plane, out result);
      float num1 = (float) ((double) result.Normal.X * (double) lightDirection.X + (double) result.Normal.Y * (double) lightDirection.Y + (double) result.Normal.Z * (double) lightDirection.Z);
      float num2 = -result.Normal.X;
      float num3 = -result.Normal.Y;
      float num4 = -result.Normal.Z;
      float num5 = -result.D;
      Matrix matrix;
      matrix.M11 = num2 * lightDirection.X + num1;
      matrix.M21 = num3 * lightDirection.X;
      matrix.M31 = num4 * lightDirection.X;
      matrix.M41 = num5 * lightDirection.X;
      matrix.M12 = num2 * lightDirection.Y;
      matrix.M22 = num3 * lightDirection.Y + num1;
      matrix.M32 = num4 * lightDirection.Y;
      matrix.M42 = num5 * lightDirection.Y;
      matrix.M13 = num2 * lightDirection.Z;
      matrix.M23 = num3 * lightDirection.Z;
      matrix.M33 = num4 * lightDirection.Z + num1;
      matrix.M43 = num5 * lightDirection.Z;
      matrix.M14 = 0.0f;
      matrix.M24 = 0.0f;
      matrix.M34 = 0.0f;
      matrix.M44 = num1;
      return matrix;
    }

    public static void CreateShadow(ref Vector3 lightDirection, ref Plane plane, out Matrix result)
    {
      Plane result1;
      Plane.Normalize(ref plane, out result1);
      float num1 = (float) ((double) result1.Normal.X * (double) lightDirection.X + (double) result1.Normal.Y * (double) lightDirection.Y + (double) result1.Normal.Z * (double) lightDirection.Z);
      float num2 = -result1.Normal.X;
      float num3 = -result1.Normal.Y;
      float num4 = -result1.Normal.Z;
      float num5 = -result1.D;
      result.M11 = num2 * lightDirection.X + num1;
      result.M21 = num3 * lightDirection.X;
      result.M31 = num4 * lightDirection.X;
      result.M41 = num5 * lightDirection.X;
      result.M12 = num2 * lightDirection.Y;
      result.M22 = num3 * lightDirection.Y + num1;
      result.M32 = num4 * lightDirection.Y;
      result.M42 = num5 * lightDirection.Y;
      result.M13 = num2 * lightDirection.Z;
      result.M23 = num3 * lightDirection.Z;
      result.M33 = num4 * lightDirection.Z + num1;
      result.M43 = num5 * lightDirection.Z;
      result.M14 = 0.0f;
      result.M24 = 0.0f;
      result.M34 = 0.0f;
      result.M44 = num1;
    }

    public static Matrix CreateReflection(Plane value)
    {
      value.Normalize();
      float x = value.Normal.X;
      float y = value.Normal.Y;
      float z = value.Normal.Z;
      float num1 = -2f * x;
      float num2 = -2f * y;
      float num3 = -2f * z;
      Matrix matrix;
      matrix.M11 = (float) ((double) num1 * (double) x + 1.0);
      matrix.M12 = num2 * x;
      matrix.M13 = num3 * x;
      matrix.M14 = 0.0f;
      matrix.M21 = num1 * y;
      matrix.M22 = (float) ((double) num2 * (double) y + 1.0);
      matrix.M23 = num3 * y;
      matrix.M24 = 0.0f;
      matrix.M31 = num1 * z;
      matrix.M32 = num2 * z;
      matrix.M33 = (float) ((double) num3 * (double) z + 1.0);
      matrix.M34 = 0.0f;
      matrix.M41 = num1 * value.D;
      matrix.M42 = num2 * value.D;
      matrix.M43 = num3 * value.D;
      matrix.M44 = 1f;
      return matrix;
    }

    public static void CreateReflection(ref Plane value, out Matrix result)
    {
      Plane result1;
      Plane.Normalize(ref value, out result1);
      value.Normalize();
      float x = result1.Normal.X;
      float y = result1.Normal.Y;
      float z = result1.Normal.Z;
      float num1 = -2f * x;
      float num2 = -2f * y;
      float num3 = -2f * z;
      result.M11 = (float) ((double) num1 * (double) x + 1.0);
      result.M12 = num2 * x;
      result.M13 = num3 * x;
      result.M14 = 0.0f;
      result.M21 = num1 * y;
      result.M22 = (float) ((double) num2 * (double) y + 1.0);
      result.M23 = num3 * y;
      result.M24 = 0.0f;
      result.M31 = num1 * z;
      result.M32 = num2 * z;
      result.M33 = (float) ((double) num3 * (double) z + 1.0);
      result.M34 = 0.0f;
      result.M41 = num1 * result1.D;
      result.M42 = num2 * result1.D;
      result.M43 = num3 * result1.D;
      result.M44 = 1f;
    }

    [SecuritySafeCritical]
    public unsafe bool Decompose(
      out Vector3 scale,
      out Quaternion rotation,
      out Vector3 translation)
    {
      bool flag = true;
      fixed (float* numPtr = &scale.X)
      {
        Matrix.VectorBasis vectorBasis;
        Vector3** vector3Ptr1 = (Vector3**) &vectorBasis;
        Matrix identity = Matrix.Identity;
        Matrix.CanonicalBasis canonicalBasis = new Matrix.CanonicalBasis();
        Vector3* vector3Ptr2 = &canonicalBasis.Row0;
        canonicalBasis.Row0 = new Vector3(1f, 0.0f, 0.0f);
        canonicalBasis.Row1 = new Vector3(0.0f, 1f, 0.0f);
        canonicalBasis.Row2 = new Vector3(0.0f, 0.0f, 1f);
        translation.X = this.M41;
        translation.Y = this.M42;
        translation.Z = this.M43;
        *vector3Ptr1 = (Vector3*) &identity.M11;
        vector3Ptr1[1] = (Vector3*) &identity.M21;
        vector3Ptr1[2] = (Vector3*) &identity.M31;
        **vector3Ptr1 = new Vector3(this.M11, this.M12, this.M13);
        *vector3Ptr1[1] = new Vector3(this.M21, this.M22, this.M23);
        *vector3Ptr1[2] = new Vector3(this.M31, this.M32, this.M33);
        scale.X = (*vector3Ptr1)->Length();
        scale.Y = vector3Ptr1[1]->Length();
        scale.Z = vector3Ptr1[2]->Length();
        float num1 = *numPtr;
        float num2 = numPtr[1];
        float num3 = numPtr[2];
        uint num4;
        uint num5;
        uint num6;
        if ((double) num1 < (double) num2)
        {
          if ((double) num2 < (double) num3)
          {
            num4 = 2U;
            num5 = 1U;
            num6 = 0U;
          }
          else
          {
            num4 = 1U;
            if ((double) num1 < (double) num3)
            {
              num5 = 2U;
              num6 = 0U;
            }
            else
            {
              num5 = 0U;
              num6 = 2U;
            }
          }
        }
        else if ((double) num1 < (double) num3)
        {
          num4 = 2U;
          num5 = 0U;
          num6 = 1U;
        }
        else
        {
          num4 = 0U;
          if ((double) num2 < (double) num3)
          {
            num5 = 2U;
            num6 = 1U;
          }
          else
          {
            num5 = 1U;
            num6 = 2U;
          }
        }
        if ((double) *(float*) ((IntPtr) numPtr + (IntPtr) ((long) num4 * 4L)) < 9.99999974737875E-05)
          *(Vector3*) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num4 * (long) sizeof (Vector3*))) = *(Vector3*) ((IntPtr) vector3Ptr2 + (IntPtr) ((long) num4 * (long) sizeof (Vector3)));
        ((Vector3*) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num4 * (long) sizeof (Vector3*))))->Normalize();
        if ((double) *(float*) ((IntPtr) numPtr + (IntPtr) ((long) num5 * 4L)) < 9.99999974737875E-05)
        {
          float num7 = Math.Abs(((Vector3*) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num4 * (long) sizeof (Vector3*))))->X);
          float num8 = Math.Abs(((Vector3*) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num4 * (long) sizeof (Vector3*))))->Y);
          float num9 = Math.Abs(((Vector3*) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num4 * (long) sizeof (Vector3*))))->Z);
          uint num10 = (double) num7 >= (double) num8 ? ((double) num7 >= (double) num9 ? ((double) num8 >= (double) num9 ? 2U : 1U) : 1U) : ((double) num8 >= (double) num9 ? ((double) num7 >= (double) num9 ? 2U : 0U) : 0U);
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          Vector3.Cross((Vector3&) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num5 * (long) sizeof (Vector3*))), (Vector3&) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num4 * (long) sizeof (Vector3*))), (Vector3&) ((IntPtr) vector3Ptr2 + (IntPtr) ((long) num10 * (long) sizeof (Vector3))));
        }
        ((Vector3*) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num5 * (long) sizeof (Vector3*))))->Normalize();
        if ((double) *(float*) ((IntPtr) numPtr + (IntPtr) ((long) num6 * 4L)) < 9.99999974737875E-05)
        {
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          Vector3.Cross((Vector3&) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num6 * (long) sizeof (Vector3*))), (Vector3&) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num4 * (long) sizeof (Vector3*))), (Vector3&) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num5 * (long) sizeof (Vector3*))));
        }
        ((Vector3*) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num6 * (long) sizeof (Vector3*))))->Normalize();
        float num11 = identity.Determinant();
        if ((double) num11 < 0.0)
        {
          *(float*) ((IntPtr) numPtr + (IntPtr) ((long) num4 * 4L)) = -*(float*) ((IntPtr) numPtr + (IntPtr) ((long) num4 * 4L));
          *(Vector3*) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num4 * (long) sizeof (Vector3*))) = -*(Vector3*) *(IntPtr*) ((IntPtr) vector3Ptr1 + (IntPtr) ((long) num4 * (long) sizeof (Vector3*)));
          num11 = -num11;
        }
        double num12 = (double) (num11 - 1f);
        if (9.99999974737875E-05 < num12 * num12)
        {
          rotation = Quaternion.Identity;
          flag = false;
        }
        else
          Quaternion.CreateFromRotationMatrix(ref identity, out rotation);
      }
      return flag;
    }

    public static Matrix Transform(Matrix value, Quaternion rotation)
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
      Matrix matrix;
      matrix.M11 = (float) ((double) value.M11 * (double) num13 + (double) value.M12 * (double) num14 + (double) value.M13 * (double) num15);
      matrix.M12 = (float) ((double) value.M11 * (double) num16 + (double) value.M12 * (double) num17 + (double) value.M13 * (double) num18);
      matrix.M13 = (float) ((double) value.M11 * (double) num19 + (double) value.M12 * (double) num20 + (double) value.M13 * (double) num21);
      matrix.M14 = value.M14;
      matrix.M21 = (float) ((double) value.M21 * (double) num13 + (double) value.M22 * (double) num14 + (double) value.M23 * (double) num15);
      matrix.M22 = (float) ((double) value.M21 * (double) num16 + (double) value.M22 * (double) num17 + (double) value.M23 * (double) num18);
      matrix.M23 = (float) ((double) value.M21 * (double) num19 + (double) value.M22 * (double) num20 + (double) value.M23 * (double) num21);
      matrix.M24 = value.M24;
      matrix.M31 = (float) ((double) value.M31 * (double) num13 + (double) value.M32 * (double) num14 + (double) value.M33 * (double) num15);
      matrix.M32 = (float) ((double) value.M31 * (double) num16 + (double) value.M32 * (double) num17 + (double) value.M33 * (double) num18);
      matrix.M33 = (float) ((double) value.M31 * (double) num19 + (double) value.M32 * (double) num20 + (double) value.M33 * (double) num21);
      matrix.M34 = value.M34;
      matrix.M41 = (float) ((double) value.M41 * (double) num13 + (double) value.M42 * (double) num14 + (double) value.M43 * (double) num15);
      matrix.M42 = (float) ((double) value.M41 * (double) num16 + (double) value.M42 * (double) num17 + (double) value.M43 * (double) num18);
      matrix.M43 = (float) ((double) value.M41 * (double) num19 + (double) value.M42 * (double) num20 + (double) value.M43 * (double) num21);
      matrix.M44 = value.M44;
      return matrix;
    }

    public static void Transform(ref Matrix value, ref Quaternion rotation, out Matrix result)
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
      float num22 = (float) ((double) value.M11 * (double) num13 + (double) value.M12 * (double) num14 + (double) value.M13 * (double) num15);
      float num23 = (float) ((double) value.M11 * (double) num16 + (double) value.M12 * (double) num17 + (double) value.M13 * (double) num18);
      float num24 = (float) ((double) value.M11 * (double) num19 + (double) value.M12 * (double) num20 + (double) value.M13 * (double) num21);
      float m14 = value.M14;
      float num25 = (float) ((double) value.M21 * (double) num13 + (double) value.M22 * (double) num14 + (double) value.M23 * (double) num15);
      float num26 = (float) ((double) value.M21 * (double) num16 + (double) value.M22 * (double) num17 + (double) value.M23 * (double) num18);
      float num27 = (float) ((double) value.M21 * (double) num19 + (double) value.M22 * (double) num20 + (double) value.M23 * (double) num21);
      float m24 = value.M24;
      float num28 = (float) ((double) value.M31 * (double) num13 + (double) value.M32 * (double) num14 + (double) value.M33 * (double) num15);
      float num29 = (float) ((double) value.M31 * (double) num16 + (double) value.M32 * (double) num17 + (double) value.M33 * (double) num18);
      float num30 = (float) ((double) value.M31 * (double) num19 + (double) value.M32 * (double) num20 + (double) value.M33 * (double) num21);
      float m34 = value.M34;
      float num31 = (float) ((double) value.M41 * (double) num13 + (double) value.M42 * (double) num14 + (double) value.M43 * (double) num15);
      float num32 = (float) ((double) value.M41 * (double) num16 + (double) value.M42 * (double) num17 + (double) value.M43 * (double) num18);
      float num33 = (float) ((double) value.M41 * (double) num19 + (double) value.M42 * (double) num20 + (double) value.M43 * (double) num21);
      float m44 = value.M44;
      result.M11 = num22;
      result.M12 = num23;
      result.M13 = num24;
      result.M14 = m14;
      result.M21 = num25;
      result.M22 = num26;
      result.M23 = num27;
      result.M24 = m24;
      result.M31 = num28;
      result.M32 = num29;
      result.M33 = num30;
      result.M34 = m34;
      result.M41 = num31;
      result.M42 = num32;
      result.M43 = num33;
      result.M44 = m44;
    }

    public override string ToString()
    {
      CultureInfo currentCulture = CultureInfo.CurrentCulture;
      return "{ " + string.Format((IFormatProvider) currentCulture, "{{M11:{0} M12:{1} M13:{2} M14:{3}}} ", (object) this.M11.ToString((IFormatProvider) currentCulture), (object) this.M12.ToString((IFormatProvider) currentCulture), (object) this.M13.ToString((IFormatProvider) currentCulture), (object) this.M14.ToString((IFormatProvider) currentCulture)) + string.Format((IFormatProvider) currentCulture, "{{M21:{0} M22:{1} M23:{2} M24:{3}}} ", (object) this.M21.ToString((IFormatProvider) currentCulture), (object) this.M22.ToString((IFormatProvider) currentCulture), (object) this.M23.ToString((IFormatProvider) currentCulture), (object) this.M24.ToString((IFormatProvider) currentCulture)) + string.Format((IFormatProvider) currentCulture, "{{M31:{0} M32:{1} M33:{2} M34:{3}}} ", (object) this.M31.ToString((IFormatProvider) currentCulture), (object) this.M32.ToString((IFormatProvider) currentCulture), (object) this.M33.ToString((IFormatProvider) currentCulture), (object) this.M34.ToString((IFormatProvider) currentCulture)) + string.Format((IFormatProvider) currentCulture, "{{M41:{0} M42:{1} M43:{2} M44:{3}}} ", (object) this.M41.ToString((IFormatProvider) currentCulture), (object) this.M42.ToString((IFormatProvider) currentCulture), (object) this.M43.ToString((IFormatProvider) currentCulture), (object) this.M44.ToString((IFormatProvider) currentCulture)) + "}";
    }

    public bool Equals(Matrix other) => (double) this.M11 == (double) other.M11 && (double) this.M22 == (double) other.M22 && ((double) this.M33 == (double) other.M33 && (double) this.M44 == (double) other.M44) && ((double) this.M12 == (double) other.M12 && (double) this.M13 == (double) other.M13 && ((double) this.M14 == (double) other.M14 && (double) this.M21 == (double) other.M21)) && ((double) this.M23 == (double) other.M23 && (double) this.M24 == (double) other.M24 && ((double) this.M31 == (double) other.M31 && (double) this.M32 == (double) other.M32) && ((double) this.M34 == (double) other.M34 && (double) this.M41 == (double) other.M41 && (double) this.M42 == (double) other.M42)) && (double) this.M43 == (double) other.M43;

    public override bool Equals(object obj)
    {
      bool flag = false;
      if (obj is Matrix other)
        flag = this.Equals(other);
      return flag;
    }

    public override int GetHashCode() => this.M11.GetHashCode() + this.M12.GetHashCode() + this.M13.GetHashCode() + this.M14.GetHashCode() + this.M21.GetHashCode() + this.M22.GetHashCode() + this.M23.GetHashCode() + this.M24.GetHashCode() + this.M31.GetHashCode() + this.M32.GetHashCode() + this.M33.GetHashCode() + this.M34.GetHashCode() + this.M41.GetHashCode() + this.M42.GetHashCode() + this.M43.GetHashCode() + this.M44.GetHashCode();

    public static Matrix Transpose(Matrix matrix)
    {
      Matrix matrix1;
      matrix1.M11 = matrix.M11;
      matrix1.M12 = matrix.M21;
      matrix1.M13 = matrix.M31;
      matrix1.M14 = matrix.M41;
      matrix1.M21 = matrix.M12;
      matrix1.M22 = matrix.M22;
      matrix1.M23 = matrix.M32;
      matrix1.M24 = matrix.M42;
      matrix1.M31 = matrix.M13;
      matrix1.M32 = matrix.M23;
      matrix1.M33 = matrix.M33;
      matrix1.M34 = matrix.M43;
      matrix1.M41 = matrix.M14;
      matrix1.M42 = matrix.M24;
      matrix1.M43 = matrix.M34;
      matrix1.M44 = matrix.M44;
      return matrix1;
    }

    public static void Transpose(ref Matrix matrix, out Matrix result)
    {
      float m11 = matrix.M11;
      float m12 = matrix.M12;
      float m13 = matrix.M13;
      float m14 = matrix.M14;
      float m21 = matrix.M21;
      float m22 = matrix.M22;
      float m23 = matrix.M23;
      float m24 = matrix.M24;
      float m31 = matrix.M31;
      float m32 = matrix.M32;
      float m33 = matrix.M33;
      float m34 = matrix.M34;
      float m41 = matrix.M41;
      float m42 = matrix.M42;
      float m43 = matrix.M43;
      float m44 = matrix.M44;
      result.M11 = m11;
      result.M12 = m21;
      result.M13 = m31;
      result.M14 = m41;
      result.M21 = m12;
      result.M22 = m22;
      result.M23 = m32;
      result.M24 = m42;
      result.M31 = m13;
      result.M32 = m23;
      result.M33 = m33;
      result.M34 = m43;
      result.M41 = m14;
      result.M42 = m24;
      result.M43 = m34;
      result.M44 = m44;
    }

    public float Determinant()
    {
      double m11 = (double) this.M11;
      float m12 = this.M12;
      float m13 = this.M13;
      float m14 = this.M14;
      float m21 = this.M21;
      float m22 = this.M22;
      float m23 = this.M23;
      float m24 = this.M24;
      double m31 = (double) this.M31;
      float m32 = this.M32;
      float m33 = this.M33;
      float m34 = this.M34;
      float m41 = this.M41;
      float m42 = this.M42;
      float m43 = this.M43;
      float m44 = this.M44;
      float num1 = (float) ((double) m33 * (double) m44 - (double) m34 * (double) m43);
      float num2 = (float) ((double) m32 * (double) m44 - (double) m34 * (double) m42);
      float num3 = (float) ((double) m32 * (double) m43 - (double) m33 * (double) m42);
      float num4 = (float) (m31 * (double) m44 - (double) m34 * (double) m41);
      float num5 = (float) (m31 * (double) m43 - (double) m33 * (double) m41);
      float num6 = (float) (m31 * (double) m42 - (double) m32 * (double) m41);
      double num7 = (double) m22 * (double) num1 - (double) m23 * (double) num2 + (double) m24 * (double) num3;
      return (float) (m11 * num7 - (double) m12 * ((double) m21 * (double) num1 - (double) m23 * (double) num4 + (double) m24 * (double) num5) + (double) m13 * ((double) m21 * (double) num2 - (double) m22 * (double) num4 + (double) m24 * (double) num6) - (double) m14 * ((double) m21 * (double) num3 - (double) m22 * (double) num5 + (double) m23 * (double) num6));
    }

    public static Matrix Invert(Matrix matrix)
    {
      float m11 = matrix.M11;
      float m12 = matrix.M12;
      float m13 = matrix.M13;
      float m14 = matrix.M14;
      double m21 = (double) matrix.M21;
      float m22 = matrix.M22;
      float m23 = matrix.M23;
      float m24 = matrix.M24;
      float m31 = matrix.M31;
      float m32 = matrix.M32;
      float m33 = matrix.M33;
      float m34 = matrix.M34;
      float m41 = matrix.M41;
      float m42 = matrix.M42;
      float m43 = matrix.M43;
      float m44 = matrix.M44;
      float num1 = (float) ((double) m33 * (double) m44 - (double) m34 * (double) m43);
      float num2 = (float) ((double) m32 * (double) m44 - (double) m34 * (double) m42);
      float num3 = (float) ((double) m32 * (double) m43 - (double) m33 * (double) m42);
      float num4 = (float) ((double) m31 * (double) m44 - (double) m34 * (double) m41);
      float num5 = (float) ((double) m31 * (double) m43 - (double) m33 * (double) m41);
      float num6 = (float) ((double) m31 * (double) m42 - (double) m32 * (double) m41);
      float num7 = (float) ((double) m22 * (double) num1 - (double) m23 * (double) num2 + (double) m24 * (double) num3);
      float num8 = (float) -(m21 * (double) num1 - (double) m23 * (double) num4 + (double) m24 * (double) num5);
      float num9 = (float) (m21 * (double) num2 - (double) m22 * (double) num4 + (double) m24 * (double) num6);
      float num10 = (float) -(m21 * (double) num3 - (double) m22 * (double) num5 + (double) m23 * (double) num6);
      float num11 = (float) (1.0 / ((double) m11 * (double) num7 + (double) m12 * (double) num8 + (double) m13 * (double) num9 + (double) m14 * (double) num10));
      Matrix matrix1;
      matrix1.M11 = num7 * num11;
      matrix1.M21 = num8 * num11;
      matrix1.M31 = num9 * num11;
      matrix1.M41 = num10 * num11;
      matrix1.M12 = (float) -((double) m12 * (double) num1 - (double) m13 * (double) num2 + (double) m14 * (double) num3) * num11;
      matrix1.M22 = (float) ((double) m11 * (double) num1 - (double) m13 * (double) num4 + (double) m14 * (double) num5) * num11;
      matrix1.M32 = (float) -((double) m11 * (double) num2 - (double) m12 * (double) num4 + (double) m14 * (double) num6) * num11;
      matrix1.M42 = (float) ((double) m11 * (double) num3 - (double) m12 * (double) num5 + (double) m13 * (double) num6) * num11;
      float num12 = (float) ((double) m23 * (double) m44 - (double) m24 * (double) m43);
      float num13 = (float) ((double) m22 * (double) m44 - (double) m24 * (double) m42);
      float num14 = (float) ((double) m22 * (double) m43 - (double) m23 * (double) m42);
      float num15 = (float) (m21 * (double) m44 - (double) m24 * (double) m41);
      float num16 = (float) (m21 * (double) m43 - (double) m23 * (double) m41);
      float num17 = (float) (m21 * (double) m42 - (double) m22 * (double) m41);
      matrix1.M13 = (float) ((double) m12 * (double) num12 - (double) m13 * (double) num13 + (double) m14 * (double) num14) * num11;
      matrix1.M23 = (float) -((double) m11 * (double) num12 - (double) m13 * (double) num15 + (double) m14 * (double) num16) * num11;
      matrix1.M33 = (float) ((double) m11 * (double) num13 - (double) m12 * (double) num15 + (double) m14 * (double) num17) * num11;
      matrix1.M43 = (float) -((double) m11 * (double) num14 - (double) m12 * (double) num16 + (double) m13 * (double) num17) * num11;
      float num18 = (float) ((double) m23 * (double) m34 - (double) m24 * (double) m33);
      float num19 = (float) ((double) m22 * (double) m34 - (double) m24 * (double) m32);
      float num20 = (float) ((double) m22 * (double) m33 - (double) m23 * (double) m32);
      float num21 = (float) (m21 * (double) m34 - (double) m24 * (double) m31);
      float num22 = (float) (m21 * (double) m33 - (double) m23 * (double) m31);
      float num23 = (float) (m21 * (double) m32 - (double) m22 * (double) m31);
      matrix1.M14 = (float) -((double) m12 * (double) num18 - (double) m13 * (double) num19 + (double) m14 * (double) num20) * num11;
      matrix1.M24 = (float) ((double) m11 * (double) num18 - (double) m13 * (double) num21 + (double) m14 * (double) num22) * num11;
      matrix1.M34 = (float) -((double) m11 * (double) num19 - (double) m12 * (double) num21 + (double) m14 * (double) num23) * num11;
      matrix1.M44 = (float) ((double) m11 * (double) num20 - (double) m12 * (double) num22 + (double) m13 * (double) num23) * num11;
      return matrix1;
    }

    public static void Invert(ref Matrix matrix, out Matrix result)
    {
      float m11 = matrix.M11;
      float m12 = matrix.M12;
      float m13 = matrix.M13;
      float m14 = matrix.M14;
      double m21 = (double) matrix.M21;
      float m22 = matrix.M22;
      float m23 = matrix.M23;
      float m24 = matrix.M24;
      float m31 = matrix.M31;
      float m32 = matrix.M32;
      float m33 = matrix.M33;
      float m34 = matrix.M34;
      float m41 = matrix.M41;
      float m42 = matrix.M42;
      float m43 = matrix.M43;
      float m44 = matrix.M44;
      float num1 = (float) ((double) m33 * (double) m44 - (double) m34 * (double) m43);
      float num2 = (float) ((double) m32 * (double) m44 - (double) m34 * (double) m42);
      float num3 = (float) ((double) m32 * (double) m43 - (double) m33 * (double) m42);
      float num4 = (float) ((double) m31 * (double) m44 - (double) m34 * (double) m41);
      float num5 = (float) ((double) m31 * (double) m43 - (double) m33 * (double) m41);
      float num6 = (float) ((double) m31 * (double) m42 - (double) m32 * (double) m41);
      float num7 = (float) ((double) m22 * (double) num1 - (double) m23 * (double) num2 + (double) m24 * (double) num3);
      float num8 = (float) -(m21 * (double) num1 - (double) m23 * (double) num4 + (double) m24 * (double) num5);
      float num9 = (float) (m21 * (double) num2 - (double) m22 * (double) num4 + (double) m24 * (double) num6);
      float num10 = (float) -(m21 * (double) num3 - (double) m22 * (double) num5 + (double) m23 * (double) num6);
      float num11 = (float) (1.0 / ((double) m11 * (double) num7 + (double) m12 * (double) num8 + (double) m13 * (double) num9 + (double) m14 * (double) num10));
      result.M11 = num7 * num11;
      result.M21 = num8 * num11;
      result.M31 = num9 * num11;
      result.M41 = num10 * num11;
      result.M12 = (float) -((double) m12 * (double) num1 - (double) m13 * (double) num2 + (double) m14 * (double) num3) * num11;
      result.M22 = (float) ((double) m11 * (double) num1 - (double) m13 * (double) num4 + (double) m14 * (double) num5) * num11;
      result.M32 = (float) -((double) m11 * (double) num2 - (double) m12 * (double) num4 + (double) m14 * (double) num6) * num11;
      result.M42 = (float) ((double) m11 * (double) num3 - (double) m12 * (double) num5 + (double) m13 * (double) num6) * num11;
      float num12 = (float) ((double) m23 * (double) m44 - (double) m24 * (double) m43);
      float num13 = (float) ((double) m22 * (double) m44 - (double) m24 * (double) m42);
      float num14 = (float) ((double) m22 * (double) m43 - (double) m23 * (double) m42);
      float num15 = (float) (m21 * (double) m44 - (double) m24 * (double) m41);
      float num16 = (float) (m21 * (double) m43 - (double) m23 * (double) m41);
      float num17 = (float) (m21 * (double) m42 - (double) m22 * (double) m41);
      result.M13 = (float) ((double) m12 * (double) num12 - (double) m13 * (double) num13 + (double) m14 * (double) num14) * num11;
      result.M23 = (float) -((double) m11 * (double) num12 - (double) m13 * (double) num15 + (double) m14 * (double) num16) * num11;
      result.M33 = (float) ((double) m11 * (double) num13 - (double) m12 * (double) num15 + (double) m14 * (double) num17) * num11;
      result.M43 = (float) -((double) m11 * (double) num14 - (double) m12 * (double) num16 + (double) m13 * (double) num17) * num11;
      float num18 = (float) ((double) m23 * (double) m34 - (double) m24 * (double) m33);
      float num19 = (float) ((double) m22 * (double) m34 - (double) m24 * (double) m32);
      float num20 = (float) ((double) m22 * (double) m33 - (double) m23 * (double) m32);
      float num21 = (float) (m21 * (double) m34 - (double) m24 * (double) m31);
      float num22 = (float) (m21 * (double) m33 - (double) m23 * (double) m31);
      float num23 = (float) (m21 * (double) m32 - (double) m22 * (double) m31);
      result.M14 = (float) -((double) m12 * (double) num18 - (double) m13 * (double) num19 + (double) m14 * (double) num20) * num11;
      result.M24 = (float) ((double) m11 * (double) num18 - (double) m13 * (double) num21 + (double) m14 * (double) num22) * num11;
      result.M34 = (float) -((double) m11 * (double) num19 - (double) m12 * (double) num21 + (double) m14 * (double) num23) * num11;
      result.M44 = (float) ((double) m11 * (double) num20 - (double) m12 * (double) num22 + (double) m13 * (double) num23) * num11;
    }

    public static Matrix Lerp(Matrix matrix1, Matrix matrix2, float amount)
    {
      Matrix matrix;
      matrix.M11 = matrix1.M11 + (matrix2.M11 - matrix1.M11) * amount;
      matrix.M12 = matrix1.M12 + (matrix2.M12 - matrix1.M12) * amount;
      matrix.M13 = matrix1.M13 + (matrix2.M13 - matrix1.M13) * amount;
      matrix.M14 = matrix1.M14 + (matrix2.M14 - matrix1.M14) * amount;
      matrix.M21 = matrix1.M21 + (matrix2.M21 - matrix1.M21) * amount;
      matrix.M22 = matrix1.M22 + (matrix2.M22 - matrix1.M22) * amount;
      matrix.M23 = matrix1.M23 + (matrix2.M23 - matrix1.M23) * amount;
      matrix.M24 = matrix1.M24 + (matrix2.M24 - matrix1.M24) * amount;
      matrix.M31 = matrix1.M31 + (matrix2.M31 - matrix1.M31) * amount;
      matrix.M32 = matrix1.M32 + (matrix2.M32 - matrix1.M32) * amount;
      matrix.M33 = matrix1.M33 + (matrix2.M33 - matrix1.M33) * amount;
      matrix.M34 = matrix1.M34 + (matrix2.M34 - matrix1.M34) * amount;
      matrix.M41 = matrix1.M41 + (matrix2.M41 - matrix1.M41) * amount;
      matrix.M42 = matrix1.M42 + (matrix2.M42 - matrix1.M42) * amount;
      matrix.M43 = matrix1.M43 + (matrix2.M43 - matrix1.M43) * amount;
      matrix.M44 = matrix1.M44 + (matrix2.M44 - matrix1.M44) * amount;
      return matrix;
    }

    public static void Lerp(
      ref Matrix matrix1,
      ref Matrix matrix2,
      float amount,
      out Matrix result)
    {
      result.M11 = matrix1.M11 + (matrix2.M11 - matrix1.M11) * amount;
      result.M12 = matrix1.M12 + (matrix2.M12 - matrix1.M12) * amount;
      result.M13 = matrix1.M13 + (matrix2.M13 - matrix1.M13) * amount;
      result.M14 = matrix1.M14 + (matrix2.M14 - matrix1.M14) * amount;
      result.M21 = matrix1.M21 + (matrix2.M21 - matrix1.M21) * amount;
      result.M22 = matrix1.M22 + (matrix2.M22 - matrix1.M22) * amount;
      result.M23 = matrix1.M23 + (matrix2.M23 - matrix1.M23) * amount;
      result.M24 = matrix1.M24 + (matrix2.M24 - matrix1.M24) * amount;
      result.M31 = matrix1.M31 + (matrix2.M31 - matrix1.M31) * amount;
      result.M32 = matrix1.M32 + (matrix2.M32 - matrix1.M32) * amount;
      result.M33 = matrix1.M33 + (matrix2.M33 - matrix1.M33) * amount;
      result.M34 = matrix1.M34 + (matrix2.M34 - matrix1.M34) * amount;
      result.M41 = matrix1.M41 + (matrix2.M41 - matrix1.M41) * amount;
      result.M42 = matrix1.M42 + (matrix2.M42 - matrix1.M42) * amount;
      result.M43 = matrix1.M43 + (matrix2.M43 - matrix1.M43) * amount;
      result.M44 = matrix1.M44 + (matrix2.M44 - matrix1.M44) * amount;
    }

    public static Matrix Negate(Matrix matrix)
    {
      Matrix matrix1;
      matrix1.M11 = -matrix.M11;
      matrix1.M12 = -matrix.M12;
      matrix1.M13 = -matrix.M13;
      matrix1.M14 = -matrix.M14;
      matrix1.M21 = -matrix.M21;
      matrix1.M22 = -matrix.M22;
      matrix1.M23 = -matrix.M23;
      matrix1.M24 = -matrix.M24;
      matrix1.M31 = -matrix.M31;
      matrix1.M32 = -matrix.M32;
      matrix1.M33 = -matrix.M33;
      matrix1.M34 = -matrix.M34;
      matrix1.M41 = -matrix.M41;
      matrix1.M42 = -matrix.M42;
      matrix1.M43 = -matrix.M43;
      matrix1.M44 = -matrix.M44;
      return matrix1;
    }

    public static void Negate(ref Matrix matrix, out Matrix result)
    {
      result.M11 = -matrix.M11;
      result.M12 = -matrix.M12;
      result.M13 = -matrix.M13;
      result.M14 = -matrix.M14;
      result.M21 = -matrix.M21;
      result.M22 = -matrix.M22;
      result.M23 = -matrix.M23;
      result.M24 = -matrix.M24;
      result.M31 = -matrix.M31;
      result.M32 = -matrix.M32;
      result.M33 = -matrix.M33;
      result.M34 = -matrix.M34;
      result.M41 = -matrix.M41;
      result.M42 = -matrix.M42;
      result.M43 = -matrix.M43;
      result.M44 = -matrix.M44;
    }

    public static Matrix Add(Matrix matrix1, Matrix matrix2)
    {
      Matrix matrix;
      matrix.M11 = matrix1.M11 + matrix2.M11;
      matrix.M12 = matrix1.M12 + matrix2.M12;
      matrix.M13 = matrix1.M13 + matrix2.M13;
      matrix.M14 = matrix1.M14 + matrix2.M14;
      matrix.M21 = matrix1.M21 + matrix2.M21;
      matrix.M22 = matrix1.M22 + matrix2.M22;
      matrix.M23 = matrix1.M23 + matrix2.M23;
      matrix.M24 = matrix1.M24 + matrix2.M24;
      matrix.M31 = matrix1.M31 + matrix2.M31;
      matrix.M32 = matrix1.M32 + matrix2.M32;
      matrix.M33 = matrix1.M33 + matrix2.M33;
      matrix.M34 = matrix1.M34 + matrix2.M34;
      matrix.M41 = matrix1.M41 + matrix2.M41;
      matrix.M42 = matrix1.M42 + matrix2.M42;
      matrix.M43 = matrix1.M43 + matrix2.M43;
      matrix.M44 = matrix1.M44 + matrix2.M44;
      return matrix;
    }

    public static void Add(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
    {
      result.M11 = matrix1.M11 + matrix2.M11;
      result.M12 = matrix1.M12 + matrix2.M12;
      result.M13 = matrix1.M13 + matrix2.M13;
      result.M14 = matrix1.M14 + matrix2.M14;
      result.M21 = matrix1.M21 + matrix2.M21;
      result.M22 = matrix1.M22 + matrix2.M22;
      result.M23 = matrix1.M23 + matrix2.M23;
      result.M24 = matrix1.M24 + matrix2.M24;
      result.M31 = matrix1.M31 + matrix2.M31;
      result.M32 = matrix1.M32 + matrix2.M32;
      result.M33 = matrix1.M33 + matrix2.M33;
      result.M34 = matrix1.M34 + matrix2.M34;
      result.M41 = matrix1.M41 + matrix2.M41;
      result.M42 = matrix1.M42 + matrix2.M42;
      result.M43 = matrix1.M43 + matrix2.M43;
      result.M44 = matrix1.M44 + matrix2.M44;
    }

    public static Matrix Subtract(Matrix matrix1, Matrix matrix2)
    {
      Matrix matrix;
      matrix.M11 = matrix1.M11 - matrix2.M11;
      matrix.M12 = matrix1.M12 - matrix2.M12;
      matrix.M13 = matrix1.M13 - matrix2.M13;
      matrix.M14 = matrix1.M14 - matrix2.M14;
      matrix.M21 = matrix1.M21 - matrix2.M21;
      matrix.M22 = matrix1.M22 - matrix2.M22;
      matrix.M23 = matrix1.M23 - matrix2.M23;
      matrix.M24 = matrix1.M24 - matrix2.M24;
      matrix.M31 = matrix1.M31 - matrix2.M31;
      matrix.M32 = matrix1.M32 - matrix2.M32;
      matrix.M33 = matrix1.M33 - matrix2.M33;
      matrix.M34 = matrix1.M34 - matrix2.M34;
      matrix.M41 = matrix1.M41 - matrix2.M41;
      matrix.M42 = matrix1.M42 - matrix2.M42;
      matrix.M43 = matrix1.M43 - matrix2.M43;
      matrix.M44 = matrix1.M44 - matrix2.M44;
      return matrix;
    }

    public static void Subtract(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
    {
      result.M11 = matrix1.M11 - matrix2.M11;
      result.M12 = matrix1.M12 - matrix2.M12;
      result.M13 = matrix1.M13 - matrix2.M13;
      result.M14 = matrix1.M14 - matrix2.M14;
      result.M21 = matrix1.M21 - matrix2.M21;
      result.M22 = matrix1.M22 - matrix2.M22;
      result.M23 = matrix1.M23 - matrix2.M23;
      result.M24 = matrix1.M24 - matrix2.M24;
      result.M31 = matrix1.M31 - matrix2.M31;
      result.M32 = matrix1.M32 - matrix2.M32;
      result.M33 = matrix1.M33 - matrix2.M33;
      result.M34 = matrix1.M34 - matrix2.M34;
      result.M41 = matrix1.M41 - matrix2.M41;
      result.M42 = matrix1.M42 - matrix2.M42;
      result.M43 = matrix1.M43 - matrix2.M43;
      result.M44 = matrix1.M44 - matrix2.M44;
    }

    public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
    {
      Matrix matrix;
      matrix.M11 = (float) ((double) matrix1.M11 * (double) matrix2.M11 + (double) matrix1.M12 * (double) matrix2.M21 + (double) matrix1.M13 * (double) matrix2.M31 + (double) matrix1.M14 * (double) matrix2.M41);
      matrix.M12 = (float) ((double) matrix1.M11 * (double) matrix2.M12 + (double) matrix1.M12 * (double) matrix2.M22 + (double) matrix1.M13 * (double) matrix2.M32 + (double) matrix1.M14 * (double) matrix2.M42);
      matrix.M13 = (float) ((double) matrix1.M11 * (double) matrix2.M13 + (double) matrix1.M12 * (double) matrix2.M23 + (double) matrix1.M13 * (double) matrix2.M33 + (double) matrix1.M14 * (double) matrix2.M43);
      matrix.M14 = (float) ((double) matrix1.M11 * (double) matrix2.M14 + (double) matrix1.M12 * (double) matrix2.M24 + (double) matrix1.M13 * (double) matrix2.M34 + (double) matrix1.M14 * (double) matrix2.M44);
      matrix.M21 = (float) ((double) matrix1.M21 * (double) matrix2.M11 + (double) matrix1.M22 * (double) matrix2.M21 + (double) matrix1.M23 * (double) matrix2.M31 + (double) matrix1.M24 * (double) matrix2.M41);
      matrix.M22 = (float) ((double) matrix1.M21 * (double) matrix2.M12 + (double) matrix1.M22 * (double) matrix2.M22 + (double) matrix1.M23 * (double) matrix2.M32 + (double) matrix1.M24 * (double) matrix2.M42);
      matrix.M23 = (float) ((double) matrix1.M21 * (double) matrix2.M13 + (double) matrix1.M22 * (double) matrix2.M23 + (double) matrix1.M23 * (double) matrix2.M33 + (double) matrix1.M24 * (double) matrix2.M43);
      matrix.M24 = (float) ((double) matrix1.M21 * (double) matrix2.M14 + (double) matrix1.M22 * (double) matrix2.M24 + (double) matrix1.M23 * (double) matrix2.M34 + (double) matrix1.M24 * (double) matrix2.M44);
      matrix.M31 = (float) ((double) matrix1.M31 * (double) matrix2.M11 + (double) matrix1.M32 * (double) matrix2.M21 + (double) matrix1.M33 * (double) matrix2.M31 + (double) matrix1.M34 * (double) matrix2.M41);
      matrix.M32 = (float) ((double) matrix1.M31 * (double) matrix2.M12 + (double) matrix1.M32 * (double) matrix2.M22 + (double) matrix1.M33 * (double) matrix2.M32 + (double) matrix1.M34 * (double) matrix2.M42);
      matrix.M33 = (float) ((double) matrix1.M31 * (double) matrix2.M13 + (double) matrix1.M32 * (double) matrix2.M23 + (double) matrix1.M33 * (double) matrix2.M33 + (double) matrix1.M34 * (double) matrix2.M43);
      matrix.M34 = (float) ((double) matrix1.M31 * (double) matrix2.M14 + (double) matrix1.M32 * (double) matrix2.M24 + (double) matrix1.M33 * (double) matrix2.M34 + (double) matrix1.M34 * (double) matrix2.M44);
      matrix.M41 = (float) ((double) matrix1.M41 * (double) matrix2.M11 + (double) matrix1.M42 * (double) matrix2.M21 + (double) matrix1.M43 * (double) matrix2.M31 + (double) matrix1.M44 * (double) matrix2.M41);
      matrix.M42 = (float) ((double) matrix1.M41 * (double) matrix2.M12 + (double) matrix1.M42 * (double) matrix2.M22 + (double) matrix1.M43 * (double) matrix2.M32 + (double) matrix1.M44 * (double) matrix2.M42);
      matrix.M43 = (float) ((double) matrix1.M41 * (double) matrix2.M13 + (double) matrix1.M42 * (double) matrix2.M23 + (double) matrix1.M43 * (double) matrix2.M33 + (double) matrix1.M44 * (double) matrix2.M43);
      matrix.M44 = (float) ((double) matrix1.M41 * (double) matrix2.M14 + (double) matrix1.M42 * (double) matrix2.M24 + (double) matrix1.M43 * (double) matrix2.M34 + (double) matrix1.M44 * (double) matrix2.M44);
      return matrix;
    }

    public static void Multiply(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
    {
      float num1 = (float) ((double) matrix1.M11 * (double) matrix2.M11 + (double) matrix1.M12 * (double) matrix2.M21 + (double) matrix1.M13 * (double) matrix2.M31 + (double) matrix1.M14 * (double) matrix2.M41);
      float num2 = (float) ((double) matrix1.M11 * (double) matrix2.M12 + (double) matrix1.M12 * (double) matrix2.M22 + (double) matrix1.M13 * (double) matrix2.M32 + (double) matrix1.M14 * (double) matrix2.M42);
      float num3 = (float) ((double) matrix1.M11 * (double) matrix2.M13 + (double) matrix1.M12 * (double) matrix2.M23 + (double) matrix1.M13 * (double) matrix2.M33 + (double) matrix1.M14 * (double) matrix2.M43);
      float num4 = (float) ((double) matrix1.M11 * (double) matrix2.M14 + (double) matrix1.M12 * (double) matrix2.M24 + (double) matrix1.M13 * (double) matrix2.M34 + (double) matrix1.M14 * (double) matrix2.M44);
      float num5 = (float) ((double) matrix1.M21 * (double) matrix2.M11 + (double) matrix1.M22 * (double) matrix2.M21 + (double) matrix1.M23 * (double) matrix2.M31 + (double) matrix1.M24 * (double) matrix2.M41);
      float num6 = (float) ((double) matrix1.M21 * (double) matrix2.M12 + (double) matrix1.M22 * (double) matrix2.M22 + (double) matrix1.M23 * (double) matrix2.M32 + (double) matrix1.M24 * (double) matrix2.M42);
      float num7 = (float) ((double) matrix1.M21 * (double) matrix2.M13 + (double) matrix1.M22 * (double) matrix2.M23 + (double) matrix1.M23 * (double) matrix2.M33 + (double) matrix1.M24 * (double) matrix2.M43);
      float num8 = (float) ((double) matrix1.M21 * (double) matrix2.M14 + (double) matrix1.M22 * (double) matrix2.M24 + (double) matrix1.M23 * (double) matrix2.M34 + (double) matrix1.M24 * (double) matrix2.M44);
      float num9 = (float) ((double) matrix1.M31 * (double) matrix2.M11 + (double) matrix1.M32 * (double) matrix2.M21 + (double) matrix1.M33 * (double) matrix2.M31 + (double) matrix1.M34 * (double) matrix2.M41);
      float num10 = (float) ((double) matrix1.M31 * (double) matrix2.M12 + (double) matrix1.M32 * (double) matrix2.M22 + (double) matrix1.M33 * (double) matrix2.M32 + (double) matrix1.M34 * (double) matrix2.M42);
      float num11 = (float) ((double) matrix1.M31 * (double) matrix2.M13 + (double) matrix1.M32 * (double) matrix2.M23 + (double) matrix1.M33 * (double) matrix2.M33 + (double) matrix1.M34 * (double) matrix2.M43);
      float num12 = (float) ((double) matrix1.M31 * (double) matrix2.M14 + (double) matrix1.M32 * (double) matrix2.M24 + (double) matrix1.M33 * (double) matrix2.M34 + (double) matrix1.M34 * (double) matrix2.M44);
      float num13 = (float) ((double) matrix1.M41 * (double) matrix2.M11 + (double) matrix1.M42 * (double) matrix2.M21 + (double) matrix1.M43 * (double) matrix2.M31 + (double) matrix1.M44 * (double) matrix2.M41);
      float num14 = (float) ((double) matrix1.M41 * (double) matrix2.M12 + (double) matrix1.M42 * (double) matrix2.M22 + (double) matrix1.M43 * (double) matrix2.M32 + (double) matrix1.M44 * (double) matrix2.M42);
      float num15 = (float) ((double) matrix1.M41 * (double) matrix2.M13 + (double) matrix1.M42 * (double) matrix2.M23 + (double) matrix1.M43 * (double) matrix2.M33 + (double) matrix1.M44 * (double) matrix2.M43);
      float num16 = (float) ((double) matrix1.M41 * (double) matrix2.M14 + (double) matrix1.M42 * (double) matrix2.M24 + (double) matrix1.M43 * (double) matrix2.M34 + (double) matrix1.M44 * (double) matrix2.M44);
      result.M11 = num1;
      result.M12 = num2;
      result.M13 = num3;
      result.M14 = num4;
      result.M21 = num5;
      result.M22 = num6;
      result.M23 = num7;
      result.M24 = num8;
      result.M31 = num9;
      result.M32 = num10;
      result.M33 = num11;
      result.M34 = num12;
      result.M41 = num13;
      result.M42 = num14;
      result.M43 = num15;
      result.M44 = num16;
    }

    public static Matrix Multiply(Matrix matrix1, float scaleFactor)
    {
      float num = scaleFactor;
      Matrix matrix;
      matrix.M11 = matrix1.M11 * num;
      matrix.M12 = matrix1.M12 * num;
      matrix.M13 = matrix1.M13 * num;
      matrix.M14 = matrix1.M14 * num;
      matrix.M21 = matrix1.M21 * num;
      matrix.M22 = matrix1.M22 * num;
      matrix.M23 = matrix1.M23 * num;
      matrix.M24 = matrix1.M24 * num;
      matrix.M31 = matrix1.M31 * num;
      matrix.M32 = matrix1.M32 * num;
      matrix.M33 = matrix1.M33 * num;
      matrix.M34 = matrix1.M34 * num;
      matrix.M41 = matrix1.M41 * num;
      matrix.M42 = matrix1.M42 * num;
      matrix.M43 = matrix1.M43 * num;
      matrix.M44 = matrix1.M44 * num;
      return matrix;
    }

    public static void Multiply(ref Matrix matrix1, float scaleFactor, out Matrix result)
    {
      float num = scaleFactor;
      result.M11 = matrix1.M11 * num;
      result.M12 = matrix1.M12 * num;
      result.M13 = matrix1.M13 * num;
      result.M14 = matrix1.M14 * num;
      result.M21 = matrix1.M21 * num;
      result.M22 = matrix1.M22 * num;
      result.M23 = matrix1.M23 * num;
      result.M24 = matrix1.M24 * num;
      result.M31 = matrix1.M31 * num;
      result.M32 = matrix1.M32 * num;
      result.M33 = matrix1.M33 * num;
      result.M34 = matrix1.M34 * num;
      result.M41 = matrix1.M41 * num;
      result.M42 = matrix1.M42 * num;
      result.M43 = matrix1.M43 * num;
      result.M44 = matrix1.M44 * num;
    }

    public static Matrix Divide(Matrix matrix1, Matrix matrix2)
    {
      Matrix matrix;
      matrix.M11 = matrix1.M11 / matrix2.M11;
      matrix.M12 = matrix1.M12 / matrix2.M12;
      matrix.M13 = matrix1.M13 / matrix2.M13;
      matrix.M14 = matrix1.M14 / matrix2.M14;
      matrix.M21 = matrix1.M21 / matrix2.M21;
      matrix.M22 = matrix1.M22 / matrix2.M22;
      matrix.M23 = matrix1.M23 / matrix2.M23;
      matrix.M24 = matrix1.M24 / matrix2.M24;
      matrix.M31 = matrix1.M31 / matrix2.M31;
      matrix.M32 = matrix1.M32 / matrix2.M32;
      matrix.M33 = matrix1.M33 / matrix2.M33;
      matrix.M34 = matrix1.M34 / matrix2.M34;
      matrix.M41 = matrix1.M41 / matrix2.M41;
      matrix.M42 = matrix1.M42 / matrix2.M42;
      matrix.M43 = matrix1.M43 / matrix2.M43;
      matrix.M44 = matrix1.M44 / matrix2.M44;
      return matrix;
    }

    public static void Divide(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
    {
      result.M11 = matrix1.M11 / matrix2.M11;
      result.M12 = matrix1.M12 / matrix2.M12;
      result.M13 = matrix1.M13 / matrix2.M13;
      result.M14 = matrix1.M14 / matrix2.M14;
      result.M21 = matrix1.M21 / matrix2.M21;
      result.M22 = matrix1.M22 / matrix2.M22;
      result.M23 = matrix1.M23 / matrix2.M23;
      result.M24 = matrix1.M24 / matrix2.M24;
      result.M31 = matrix1.M31 / matrix2.M31;
      result.M32 = matrix1.M32 / matrix2.M32;
      result.M33 = matrix1.M33 / matrix2.M33;
      result.M34 = matrix1.M34 / matrix2.M34;
      result.M41 = matrix1.M41 / matrix2.M41;
      result.M42 = matrix1.M42 / matrix2.M42;
      result.M43 = matrix1.M43 / matrix2.M43;
      result.M44 = matrix1.M44 / matrix2.M44;
    }

    public static Matrix Divide(Matrix matrix1, float divider)
    {
      float num = 1f / divider;
      Matrix matrix;
      matrix.M11 = matrix1.M11 * num;
      matrix.M12 = matrix1.M12 * num;
      matrix.M13 = matrix1.M13 * num;
      matrix.M14 = matrix1.M14 * num;
      matrix.M21 = matrix1.M21 * num;
      matrix.M22 = matrix1.M22 * num;
      matrix.M23 = matrix1.M23 * num;
      matrix.M24 = matrix1.M24 * num;
      matrix.M31 = matrix1.M31 * num;
      matrix.M32 = matrix1.M32 * num;
      matrix.M33 = matrix1.M33 * num;
      matrix.M34 = matrix1.M34 * num;
      matrix.M41 = matrix1.M41 * num;
      matrix.M42 = matrix1.M42 * num;
      matrix.M43 = matrix1.M43 * num;
      matrix.M44 = matrix1.M44 * num;
      return matrix;
    }

    public static void Divide(ref Matrix matrix1, float divider, out Matrix result)
    {
      float num = 1f / divider;
      result.M11 = matrix1.M11 * num;
      result.M12 = matrix1.M12 * num;
      result.M13 = matrix1.M13 * num;
      result.M14 = matrix1.M14 * num;
      result.M21 = matrix1.M21 * num;
      result.M22 = matrix1.M22 * num;
      result.M23 = matrix1.M23 * num;
      result.M24 = matrix1.M24 * num;
      result.M31 = matrix1.M31 * num;
      result.M32 = matrix1.M32 * num;
      result.M33 = matrix1.M33 * num;
      result.M34 = matrix1.M34 * num;
      result.M41 = matrix1.M41 * num;
      result.M42 = matrix1.M42 * num;
      result.M43 = matrix1.M43 * num;
      result.M44 = matrix1.M44 * num;
    }

    public static Matrix operator -(Matrix matrix1)
    {
      Matrix matrix;
      matrix.M11 = -matrix1.M11;
      matrix.M12 = -matrix1.M12;
      matrix.M13 = -matrix1.M13;
      matrix.M14 = -matrix1.M14;
      matrix.M21 = -matrix1.M21;
      matrix.M22 = -matrix1.M22;
      matrix.M23 = -matrix1.M23;
      matrix.M24 = -matrix1.M24;
      matrix.M31 = -matrix1.M31;
      matrix.M32 = -matrix1.M32;
      matrix.M33 = -matrix1.M33;
      matrix.M34 = -matrix1.M34;
      matrix.M41 = -matrix1.M41;
      matrix.M42 = -matrix1.M42;
      matrix.M43 = -matrix1.M43;
      matrix.M44 = -matrix1.M44;
      return matrix;
    }

    public static bool operator ==(Matrix matrix1, Matrix matrix2) => (double) matrix1.M11 == (double) matrix2.M11 && (double) matrix1.M22 == (double) matrix2.M22 && ((double) matrix1.M33 == (double) matrix2.M33 && (double) matrix1.M44 == (double) matrix2.M44) && ((double) matrix1.M12 == (double) matrix2.M12 && (double) matrix1.M13 == (double) matrix2.M13 && ((double) matrix1.M14 == (double) matrix2.M14 && (double) matrix1.M21 == (double) matrix2.M21)) && ((double) matrix1.M23 == (double) matrix2.M23 && (double) matrix1.M24 == (double) matrix2.M24 && ((double) matrix1.M31 == (double) matrix2.M31 && (double) matrix1.M32 == (double) matrix2.M32) && ((double) matrix1.M34 == (double) matrix2.M34 && (double) matrix1.M41 == (double) matrix2.M41 && (double) matrix1.M42 == (double) matrix2.M42)) && (double) matrix1.M43 == (double) matrix2.M43;

    public static bool operator !=(Matrix matrix1, Matrix matrix2) => (double) matrix1.M11 != (double) matrix2.M11 || (double) matrix1.M12 != (double) matrix2.M12 || ((double) matrix1.M13 != (double) matrix2.M13 || (double) matrix1.M14 != (double) matrix2.M14) || ((double) matrix1.M21 != (double) matrix2.M21 || (double) matrix1.M22 != (double) matrix2.M22 || ((double) matrix1.M23 != (double) matrix2.M23 || (double) matrix1.M24 != (double) matrix2.M24)) || ((double) matrix1.M31 != (double) matrix2.M31 || (double) matrix1.M32 != (double) matrix2.M32 || ((double) matrix1.M33 != (double) matrix2.M33 || (double) matrix1.M34 != (double) matrix2.M34) || ((double) matrix1.M41 != (double) matrix2.M41 || (double) matrix1.M42 != (double) matrix2.M42 || (double) matrix1.M43 != (double) matrix2.M43)) || (double) matrix1.M44 != (double) matrix2.M44;

    public static Matrix operator +(Matrix matrix1, Matrix matrix2)
    {
      Matrix matrix;
      matrix.M11 = matrix1.M11 + matrix2.M11;
      matrix.M12 = matrix1.M12 + matrix2.M12;
      matrix.M13 = matrix1.M13 + matrix2.M13;
      matrix.M14 = matrix1.M14 + matrix2.M14;
      matrix.M21 = matrix1.M21 + matrix2.M21;
      matrix.M22 = matrix1.M22 + matrix2.M22;
      matrix.M23 = matrix1.M23 + matrix2.M23;
      matrix.M24 = matrix1.M24 + matrix2.M24;
      matrix.M31 = matrix1.M31 + matrix2.M31;
      matrix.M32 = matrix1.M32 + matrix2.M32;
      matrix.M33 = matrix1.M33 + matrix2.M33;
      matrix.M34 = matrix1.M34 + matrix2.M34;
      matrix.M41 = matrix1.M41 + matrix2.M41;
      matrix.M42 = matrix1.M42 + matrix2.M42;
      matrix.M43 = matrix1.M43 + matrix2.M43;
      matrix.M44 = matrix1.M44 + matrix2.M44;
      return matrix;
    }

    public static Matrix operator -(Matrix matrix1, Matrix matrix2)
    {
      Matrix matrix;
      matrix.M11 = matrix1.M11 - matrix2.M11;
      matrix.M12 = matrix1.M12 - matrix2.M12;
      matrix.M13 = matrix1.M13 - matrix2.M13;
      matrix.M14 = matrix1.M14 - matrix2.M14;
      matrix.M21 = matrix1.M21 - matrix2.M21;
      matrix.M22 = matrix1.M22 - matrix2.M22;
      matrix.M23 = matrix1.M23 - matrix2.M23;
      matrix.M24 = matrix1.M24 - matrix2.M24;
      matrix.M31 = matrix1.M31 - matrix2.M31;
      matrix.M32 = matrix1.M32 - matrix2.M32;
      matrix.M33 = matrix1.M33 - matrix2.M33;
      matrix.M34 = matrix1.M34 - matrix2.M34;
      matrix.M41 = matrix1.M41 - matrix2.M41;
      matrix.M42 = matrix1.M42 - matrix2.M42;
      matrix.M43 = matrix1.M43 - matrix2.M43;
      matrix.M44 = matrix1.M44 - matrix2.M44;
      return matrix;
    }

    public static Matrix operator *(Matrix matrix1, Matrix matrix2)
    {
      Matrix matrix;
      matrix.M11 = (float) ((double) matrix1.M11 * (double) matrix2.M11 + (double) matrix1.M12 * (double) matrix2.M21 + (double) matrix1.M13 * (double) matrix2.M31 + (double) matrix1.M14 * (double) matrix2.M41);
      matrix.M12 = (float) ((double) matrix1.M11 * (double) matrix2.M12 + (double) matrix1.M12 * (double) matrix2.M22 + (double) matrix1.M13 * (double) matrix2.M32 + (double) matrix1.M14 * (double) matrix2.M42);
      matrix.M13 = (float) ((double) matrix1.M11 * (double) matrix2.M13 + (double) matrix1.M12 * (double) matrix2.M23 + (double) matrix1.M13 * (double) matrix2.M33 + (double) matrix1.M14 * (double) matrix2.M43);
      matrix.M14 = (float) ((double) matrix1.M11 * (double) matrix2.M14 + (double) matrix1.M12 * (double) matrix2.M24 + (double) matrix1.M13 * (double) matrix2.M34 + (double) matrix1.M14 * (double) matrix2.M44);
      matrix.M21 = (float) ((double) matrix1.M21 * (double) matrix2.M11 + (double) matrix1.M22 * (double) matrix2.M21 + (double) matrix1.M23 * (double) matrix2.M31 + (double) matrix1.M24 * (double) matrix2.M41);
      matrix.M22 = (float) ((double) matrix1.M21 * (double) matrix2.M12 + (double) matrix1.M22 * (double) matrix2.M22 + (double) matrix1.M23 * (double) matrix2.M32 + (double) matrix1.M24 * (double) matrix2.M42);
      matrix.M23 = (float) ((double) matrix1.M21 * (double) matrix2.M13 + (double) matrix1.M22 * (double) matrix2.M23 + (double) matrix1.M23 * (double) matrix2.M33 + (double) matrix1.M24 * (double) matrix2.M43);
      matrix.M24 = (float) ((double) matrix1.M21 * (double) matrix2.M14 + (double) matrix1.M22 * (double) matrix2.M24 + (double) matrix1.M23 * (double) matrix2.M34 + (double) matrix1.M24 * (double) matrix2.M44);
      matrix.M31 = (float) ((double) matrix1.M31 * (double) matrix2.M11 + (double) matrix1.M32 * (double) matrix2.M21 + (double) matrix1.M33 * (double) matrix2.M31 + (double) matrix1.M34 * (double) matrix2.M41);
      matrix.M32 = (float) ((double) matrix1.M31 * (double) matrix2.M12 + (double) matrix1.M32 * (double) matrix2.M22 + (double) matrix1.M33 * (double) matrix2.M32 + (double) matrix1.M34 * (double) matrix2.M42);
      matrix.M33 = (float) ((double) matrix1.M31 * (double) matrix2.M13 + (double) matrix1.M32 * (double) matrix2.M23 + (double) matrix1.M33 * (double) matrix2.M33 + (double) matrix1.M34 * (double) matrix2.M43);
      matrix.M34 = (float) ((double) matrix1.M31 * (double) matrix2.M14 + (double) matrix1.M32 * (double) matrix2.M24 + (double) matrix1.M33 * (double) matrix2.M34 + (double) matrix1.M34 * (double) matrix2.M44);
      matrix.M41 = (float) ((double) matrix1.M41 * (double) matrix2.M11 + (double) matrix1.M42 * (double) matrix2.M21 + (double) matrix1.M43 * (double) matrix2.M31 + (double) matrix1.M44 * (double) matrix2.M41);
      matrix.M42 = (float) ((double) matrix1.M41 * (double) matrix2.M12 + (double) matrix1.M42 * (double) matrix2.M22 + (double) matrix1.M43 * (double) matrix2.M32 + (double) matrix1.M44 * (double) matrix2.M42);
      matrix.M43 = (float) ((double) matrix1.M41 * (double) matrix2.M13 + (double) matrix1.M42 * (double) matrix2.M23 + (double) matrix1.M43 * (double) matrix2.M33 + (double) matrix1.M44 * (double) matrix2.M43);
      matrix.M44 = (float) ((double) matrix1.M41 * (double) matrix2.M14 + (double) matrix1.M42 * (double) matrix2.M24 + (double) matrix1.M43 * (double) matrix2.M34 + (double) matrix1.M44 * (double) matrix2.M44);
      return matrix;
    }

    public static Matrix operator *(Matrix matrix, float scaleFactor)
    {
      float num = scaleFactor;
      Matrix matrix1;
      matrix1.M11 = matrix.M11 * num;
      matrix1.M12 = matrix.M12 * num;
      matrix1.M13 = matrix.M13 * num;
      matrix1.M14 = matrix.M14 * num;
      matrix1.M21 = matrix.M21 * num;
      matrix1.M22 = matrix.M22 * num;
      matrix1.M23 = matrix.M23 * num;
      matrix1.M24 = matrix.M24 * num;
      matrix1.M31 = matrix.M31 * num;
      matrix1.M32 = matrix.M32 * num;
      matrix1.M33 = matrix.M33 * num;
      matrix1.M34 = matrix.M34 * num;
      matrix1.M41 = matrix.M41 * num;
      matrix1.M42 = matrix.M42 * num;
      matrix1.M43 = matrix.M43 * num;
      matrix1.M44 = matrix.M44 * num;
      return matrix1;
    }

    public static Matrix operator *(float scaleFactor, Matrix matrix)
    {
      float num = scaleFactor;
      Matrix matrix1;
      matrix1.M11 = matrix.M11 * num;
      matrix1.M12 = matrix.M12 * num;
      matrix1.M13 = matrix.M13 * num;
      matrix1.M14 = matrix.M14 * num;
      matrix1.M21 = matrix.M21 * num;
      matrix1.M22 = matrix.M22 * num;
      matrix1.M23 = matrix.M23 * num;
      matrix1.M24 = matrix.M24 * num;
      matrix1.M31 = matrix.M31 * num;
      matrix1.M32 = matrix.M32 * num;
      matrix1.M33 = matrix.M33 * num;
      matrix1.M34 = matrix.M34 * num;
      matrix1.M41 = matrix.M41 * num;
      matrix1.M42 = matrix.M42 * num;
      matrix1.M43 = matrix.M43 * num;
      matrix1.M44 = matrix.M44 * num;
      return matrix1;
    }

    public static Matrix operator /(Matrix matrix1, Matrix matrix2)
    {
      Matrix matrix;
      matrix.M11 = matrix1.M11 / matrix2.M11;
      matrix.M12 = matrix1.M12 / matrix2.M12;
      matrix.M13 = matrix1.M13 / matrix2.M13;
      matrix.M14 = matrix1.M14 / matrix2.M14;
      matrix.M21 = matrix1.M21 / matrix2.M21;
      matrix.M22 = matrix1.M22 / matrix2.M22;
      matrix.M23 = matrix1.M23 / matrix2.M23;
      matrix.M24 = matrix1.M24 / matrix2.M24;
      matrix.M31 = matrix1.M31 / matrix2.M31;
      matrix.M32 = matrix1.M32 / matrix2.M32;
      matrix.M33 = matrix1.M33 / matrix2.M33;
      matrix.M34 = matrix1.M34 / matrix2.M34;
      matrix.M41 = matrix1.M41 / matrix2.M41;
      matrix.M42 = matrix1.M42 / matrix2.M42;
      matrix.M43 = matrix1.M43 / matrix2.M43;
      matrix.M44 = matrix1.M44 / matrix2.M44;
      return matrix;
    }

    public static Matrix operator /(Matrix matrix1, float divider)
    {
      float num = 1f / divider;
      Matrix matrix;
      matrix.M11 = matrix1.M11 * num;
      matrix.M12 = matrix1.M12 * num;
      matrix.M13 = matrix1.M13 * num;
      matrix.M14 = matrix1.M14 * num;
      matrix.M21 = matrix1.M21 * num;
      matrix.M22 = matrix1.M22 * num;
      matrix.M23 = matrix1.M23 * num;
      matrix.M24 = matrix1.M24 * num;
      matrix.M31 = matrix1.M31 * num;
      matrix.M32 = matrix1.M32 * num;
      matrix.M33 = matrix1.M33 * num;
      matrix.M34 = matrix1.M34 * num;
      matrix.M41 = matrix1.M41 * num;
      matrix.M42 = matrix1.M42 * num;
      matrix.M43 = matrix1.M43 * num;
      matrix.M44 = matrix1.M44 * num;
      return matrix;
    }

    private struct CanonicalBasis
    {
      public Vector3 Row0;
      public Vector3 Row1;
      public Vector3 Row2;
    }

    private struct VectorBasis
    {
      public unsafe Vector3* Element0;
      public unsafe Vector3* Element1;
      public unsafe Vector3* Element2;
    }
  }
}
