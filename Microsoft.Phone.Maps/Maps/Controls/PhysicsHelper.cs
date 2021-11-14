// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.PhysicsHelper
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Microsoft.Phone.Maps.Controls
{
  internal static class PhysicsHelper
  {
    internal const float FrictionCoefficient = 500f;

    internal static IEasingFunction GetEasingFunction()
    {
      QuadraticEase quadraticEase = new QuadraticEase();
      quadraticEase.EasingMode = EasingMode.EaseOut;
      return (IEasingFunction) quadraticEase;
    }

    internal static Point GetStopPoint(Point velocity, Point initialPosition)
    {
      double stopTime = PhysicsHelper.GetStopTime(velocity);
      double num = Math.Sqrt(velocity.X * velocity.X + velocity.Y * velocity.Y);
      Point point = new Point(500.0 * velocity.X / num, 500.0 * velocity.Y / num);
      return new Point(initialPosition.X + stopTime * velocity.X - point.X * stopTime * stopTime / 2.0, initialPosition.Y + stopTime * velocity.Y - point.Y * stopTime * stopTime / 2.0);
    }

    internal static double GetStopTime(Point velocity) => Math.Sqrt(velocity.X * velocity.X + velocity.Y * velocity.Y) / 500.0;

    internal static int GetAngleFromVelocity(Point velocity)
    {
      double x = velocity.X;
      double y = velocity.Y;
      return x != 0.0 || y != 0.0 ? (x != 0.0 ? (y != 0.0 ? (int) PhysicsHelper.RadianToDegree(Math.Atan2(y, x)) : (x <= 0.0 ? 180 : 0)) : (y <= 0.0 ? 270 : 90)) : 0;
    }

    internal static double DegreeToRadian(double angle) => Math.PI * angle / 180.0;

    internal static double RadianToDegree(double angle) => angle * (180.0 / Math.PI);

    internal static bool ExceedsThreshold(Point delta, long threshold) => Math.Abs(delta.X) > (double) threshold || Math.Abs(delta.Y) > (double) threshold;

    internal static bool ExceedsThreshold(TimeSpan delta, long threshold) => delta > TimeSpan.FromMilliseconds((double) threshold);

    internal static Point Delta(Point p1, Point p2) => new Point(p1.X - p2.X, p1.Y - p2.Y);

    internal static Point Center(Point p1, Point p2) => new Point((p1.X + p2.X) / 2.0, (p1.Y + p2.Y) / 2.0);

    internal static double Distance(Point p1, Point p2)
    {
      Point point = PhysicsHelper.Delta(p1, p2);
      return Math.Sqrt(point.X * point.X + point.Y * point.Y);
    }

    internal static Point NextPoint(Point initial, Point velocity, TimeSpan duration) => new Point(initial.X + velocity.X * duration.TotalSeconds, initial.Y + velocity.Y * duration.TotalSeconds);
  }
}
