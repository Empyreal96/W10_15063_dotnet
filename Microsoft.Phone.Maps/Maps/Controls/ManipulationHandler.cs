// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.ManipulationHandler
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Windows;
using System.Windows.Input;

namespace Microsoft.Phone.Maps.Controls
{
  internal class ManipulationHandler
  {
    private const ushort TapDistanceThreshold = 30;
    private const ushort DoubleTapTimeThreshold = 500;
    private const ushort TapAndHoldTimeThreshold = 2000;
    private const ushort DragThresholdForFlick = 3;
    private bool isTap;
    private bool isTapPending;
    private Timeout lastTap;
    private Point lastTapOrigin;
    private long lastTapTimestamp;
    private long tapStartTimestamp;
    private UIElement root;
    private Point lastTranslation;

    public ManipulationHandler(UIElement element)
    {
      if (element == null)
        throw new ArgumentNullException(nameof (element));
      element.ManipulationStarted += new EventHandler<ManipulationStartedEventArgs>(this.OnManipulationStarted);
      element.ManipulationCompleted += new EventHandler<ManipulationCompletedEventArgs>(this.OnManipulationCompleted);
      element.ManipulationDelta += new EventHandler<ManipulationDeltaEventArgs>(this.OnManipulationDelta);
      this.root = element;
    }

    public event EventHandler<GestureEventArgs> Tap;

    public event EventHandler<GestureEventArgs> DoubleTap;

    public event EventHandler<GestureEventArgs> TapAndHold;

    public event EventHandler<GestureEventArgs> Pan;

    public event EventHandler<GestureEventArgs> Flick;

    public event EventHandler<GestureEventArgs> Pinch;

    public event EventHandler<GestureEventArgs> Stretch;

    public event EventHandler<GestureEndedEventArgs> GestureEnded;

    internal void Unload()
    {
      if (this.lastTap == null)
        return;
      this.lastTap.Cancel();
    }

    private static bool IsDoubleTap(
      Point previousPoint,
      long previousTimestamp,
      Point currentPoint,
      long currentTimestamp)
    {
      return !PhysicsHelper.ExceedsThreshold(TimeSpan.FromTicks(currentTimestamp - previousTimestamp), 500L) && !PhysicsHelper.ExceedsThreshold(PhysicsHelper.Delta(previousPoint, currentPoint), 30L);
    }

    private void OnManipulationStarted(object sender, ManipulationStartedEventArgs e)
    {
      if (e.Handled)
        return;
      e.Handled = true;
      this.isTap = true;
      this.tapStartTimestamp = DateTime.Now.Ticks;
    }

    private void OnManipulationDelta(object sender, ManipulationDeltaEventArgs e)
    {
      DateTime now = DateTime.Now;
      if (e.Handled)
        return;
      e.Handled = true;
      UIElement originalSource = e.OriginalSource as UIElement;
      UIElement visual = sender as UIElement;
      if (originalSource == null || visual == null)
        return;
      Point point1 = originalSource.TransformToVisual(visual).Transform(e.ManipulationOrigin);
      bool flag1 = false;
      bool flag2 = false;
      Point point2 = e.DeltaManipulation.Scale;
      if (point2.X > 0.0)
      {
        point2 = e.DeltaManipulation.Scale;
        if (point2.Y > 0.0)
        {
          point2 = e.DeltaManipulation.Scale;
          if (Math.Abs(1.0 - point2.X) <= 0.02)
          {
            point2 = e.DeltaManipulation.Scale;
            if (Math.Abs(1.0 - point2.Y) <= 0.02)
              goto label_8;
          }
          flag1 = true;
        }
      }
label_8:
      if (!flag1)
      {
        point2 = e.DeltaManipulation.Translation;
        if (Math.Abs(point2.X) <= 2.0)
        {
          point2 = e.DeltaManipulation.Translation;
          if (Math.Abs(point2.Y) <= 2.0)
            goto label_15;
        }
        point2 = e.CumulativeManipulation.Translation;
        int num;
        if (Math.Abs(point2.X) <= 30.0)
        {
          point2 = e.CumulativeManipulation.Translation;
          num = Math.Abs(point2.Y) > 30.0 ? 1 : 0;
        }
        else
          num = 1;
        flag2 = num != 0;
      }
label_15:
      if (flag1 | flag2)
      {
        this.isTap = false;
        if (this.lastTap != null)
        {
          this.lastTap.DoItNow();
          this.lastTap = (Timeout) null;
        }
      }
      if (this.isTap && PhysicsHelper.ExceedsThreshold(TimeSpan.FromTicks(now.Ticks - this.tapStartTimestamp), 2000L))
      {
        object sender1 = sender;
        TapAndHoldGestureEventArgs gestureEventArgs = new TapAndHoldGestureEventArgs();
        gestureEventArgs.Origin = point1;
        this.FireTapAndHoldEvent(sender1, (GestureEventArgs) gestureEventArgs);
        this.isTap = false;
        e.Complete();
      }
      if (flag1)
      {
        point2 = e.DeltaManipulation.Scale;
        if (point2.X >= 1.0)
        {
          point2 = e.DeltaManipulation.Scale;
          if (point2.Y >= 1.0)
          {
            object sender1 = sender;
            StretchGestureEventArgs gestureEventArgs = new StretchGestureEventArgs();
            gestureEventArgs.Origin = point1;
            gestureEventArgs.ScaleDelta = e.DeltaManipulation.Scale;
            gestureEventArgs.ScaleCumulativeDelta = e.CumulativeManipulation.Scale;
            this.FireStretchEvent(sender1, (GestureEventArgs) gestureEventArgs);
            goto label_27;
          }
        }
        object sender2 = sender;
        PinchGestureEventArgs gestureEventArgs1 = new PinchGestureEventArgs();
        gestureEventArgs1.Origin = point1;
        gestureEventArgs1.ScaleDelta = e.DeltaManipulation.Scale;
        gestureEventArgs1.ScaleCumulativeDelta = e.CumulativeManipulation.Scale;
        this.FirePinchEvent(sender2, (GestureEventArgs) gestureEventArgs1);
      }
      else if (flag2)
      {
        object sender1 = sender;
        PanGestureEventArgs gestureEventArgs = new PanGestureEventArgs();
        gestureEventArgs.Origin = point1;
        gestureEventArgs.Translation = e.DeltaManipulation.Translation;
        this.FirePanEvent(sender1, (GestureEventArgs) gestureEventArgs);
      }
label_27:
      this.lastTranslation = e.DeltaManipulation.Translation;
    }

    private void OnManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
    {
      DateTime now = DateTime.Now;
      if (e.Handled)
        return;
      e.Handled = true;
      UIElement originalSource = e.OriginalSource as UIElement;
      UIElement visual = sender as UIElement;
      if (originalSource == null || visual == null)
        return;
      Point origin = originalSource.TransformToVisual(visual).Transform(e.ManipulationOrigin);
      if (this.isTap)
      {
        if (this.isTapPending && ManipulationHandler.IsDoubleTap(this.lastTapOrigin, this.lastTapTimestamp, origin, now.Ticks))
        {
          if (this.lastTap != null)
          {
            this.lastTap.Cancel();
            this.lastTap = (Timeout) null;
          }
          this.isTapPending = false;
          object sender1 = sender;
          DoubleTapGestureEventArgs gestureEventArgs = new DoubleTapGestureEventArgs();
          gestureEventArgs.Origin = origin;
          this.FireDoubleTapEvent(sender1, (GestureEventArgs) gestureEventArgs);
        }
        else
        {
          if (this.lastTap != null)
          {
            this.lastTap.DoItNow();
            this.lastTap = (Timeout) null;
          }
          this.isTapPending = true;
          this.lastTapTimestamp = now.Ticks;
          this.lastTapOrigin = origin;
          this.lastTap = new Timeout((Action) (() =>
          {
            object sender1 = sender;
            this.FireTapEvent(sender1, (GestureEventArgs) new TapGestureEventArgs()
            {
              Origin = origin
            });
          }), 600L);
        }
      }
      else
        this.isTapPending = false;
      if (e.IsInertial && (Math.Abs(this.lastTranslation.X) > 3.0 || Math.Abs(this.lastTranslation.Y) > 3.0))
      {
        Point scale = e.TotalManipulation.Scale;
        if (scale.X == 0.0)
        {
          scale = e.TotalManipulation.Scale;
          if (scale.Y == 0.0)
          {
            object sender1 = sender;
            FlickGestureEventArgs gestureEventArgs = new FlickGestureEventArgs();
            gestureEventArgs.Origin = origin;
            gestureEventArgs.Velocity = e.FinalVelocities.LinearVelocity;
            this.FireFlickEvent(sender1, (GestureEventArgs) gestureEventArgs);
          }
        }
      }
      this.GestureEnded(sender, new GestureEndedEventArgs()
      {
        Origin = origin
      });
    }

    private void FireTapEvent(object sender, GestureEventArgs e)
    {
      EventHandler<GestureEventArgs> tap = this.Tap;
      if (tap == null)
        return;
      tap(sender, e);
    }

    private void FireDoubleTapEvent(object sender, GestureEventArgs e)
    {
      EventHandler<GestureEventArgs> doubleTap = this.DoubleTap;
      if (doubleTap == null)
        return;
      doubleTap(sender, e);
    }

    private void FireTapAndHoldEvent(object sender, GestureEventArgs e)
    {
      EventHandler<GestureEventArgs> tapAndHold = this.TapAndHold;
      if (tapAndHold == null)
        return;
      tapAndHold(sender, e);
    }

    private void FirePanEvent(object sender, GestureEventArgs e)
    {
      EventHandler<GestureEventArgs> pan = this.Pan;
      if (pan == null)
        return;
      pan(sender, e);
    }

    private void FireFlickEvent(object sender, GestureEventArgs e)
    {
      EventHandler<GestureEventArgs> flick = this.Flick;
      if (flick == null)
        return;
      flick(sender, e);
    }

    private void FirePinchEvent(object sender, GestureEventArgs e)
    {
      EventHandler<GestureEventArgs> pinch = this.Pinch;
      if (pinch == null)
        return;
      pinch(sender, e);
    }

    private void FireStretchEvent(object sender, GestureEventArgs e)
    {
      EventHandler<GestureEventArgs> stretch = this.Stretch;
      if (stretch == null)
        return;
      stretch(sender, e);
    }
  }
}
