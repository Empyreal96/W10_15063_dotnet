// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.PhysicsConstants
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Microsoft.Phone.Controls
{
  internal static class PhysicsConstants
  {
    internal static double GetStopTime(Point initialVelocity)
    {
      double num = Math.Min(Math.Sqrt(initialVelocity.X * initialVelocity.X + initialVelocity.Y * initialVelocity.Y), MotionParameters.MaximumSpeed);
      return MotionParameters.ParkingSpeed >= num ? 0.0 : Math.Log(MotionParameters.ParkingSpeed / num) / Math.Log(MotionParameters.Friction);
    }

    internal static Point GetStopPoint(Point initialVelocity)
    {
      double num1 = Math.Sqrt(initialVelocity.X * initialVelocity.X + initialVelocity.Y * initialVelocity.Y);
      Point initialVelocity1 = initialVelocity;
      if (num1 > MotionParameters.MaximumSpeed && num1 > 0.0)
      {
        initialVelocity1.X *= MotionParameters.MaximumSpeed / num1;
        initialVelocity1.Y *= MotionParameters.MaximumSpeed / num1;
      }
      double num2 = (Math.Pow(MotionParameters.Friction, PhysicsConstants.GetStopTime(initialVelocity1)) - 1.0) / Math.Log(MotionParameters.Friction);
      return new Point(initialVelocity1.X * num2, initialVelocity1.Y * num2);
    }

    internal static IEasingFunction GetEasingFunction(double stopTime)
    {
      ExponentialEase exponentialEase = new ExponentialEase();
      exponentialEase.Exponent = stopTime * Math.Log(MotionParameters.Friction);
      exponentialEase.EasingMode = EasingMode.EaseIn;
      return (IEasingFunction) exponentialEase;
    }

    internal static double InverseEase(double position)
    {
      double d = 1.0 * Math.Log(MotionParameters.Friction);
      return Math.Log((Math.Exp(d) - 1.0) * position + 1.0) / d;
    }
  }
}
