// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.TouchSession
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using System;

namespace Microsoft.Xna.Framework.Input.Touch
{
  internal class TouchSession
  {
    private IntPtr _handle;
    private GestureType _enabledGestures;
    private bool _lastMessageIsEnd;
    private bool _dragIsActive;
    private bool _pinchIsActive;
    private bool _flipOrientation;
    private static readonly int MAX_GESTURE_HISTORY = 200;
    private GestureSample[] _gestureHistory = new GestureSample[TouchSession.MAX_GESTURE_HISTORY];
    private int _gestureHistoryReadIndex;
    private int _gestureHistoryCount;
    private static uint _tapDataSize = (uint) SafeTouchNativeMethods.SizeOf(typeof (GestureTapData));
    private static uint _holdDataSize = (uint) SafeTouchNativeMethods.SizeOf(typeof (GestureHoldData));
    private static uint _dragDataSize = (uint) SafeTouchNativeMethods.SizeOf(typeof (GestureDragData));
    private static uint _pinchStretchDataSize = (uint) SafeTouchNativeMethods.SizeOf(typeof (GesturePinchStretchData));
    private static uint _flickDataSize = (uint) SafeTouchNativeMethods.SizeOf(typeof (GestureFlickData));

    internal TouchSession() => Helpers.ThrowExceptionFromResult(SafeTouchNativeMethods.CreateTouchSession(out this._handle));

    internal void Dispose() => Helpers.ThrowExceptionFromResult(SafeTouchNativeMethods.TouchSessionRelease(this._handle));

    internal void Add(ref TouchInfoBuffer touch)
    {
      if (this._handle == IntPtr.Zero)
        return;
      Helpers.ThrowExceptionFromResult(SafeTouchNativeMethods.TouchSessionAdd(this._handle, ref touch));
      this._lastMessageIsEnd = (uint) (touch.dwFlags & GestureInfoFlags.End) > 0U;
      this.UpdateGestureHistory(touch.dwTimeStamp);
    }

    internal void SetEnabledGestures(GestureType gestures, bool forceSet)
    {
      if (!forceSet && gestures == this._enabledGestures)
        return;
      GestureTypeInternal expected = GestureTypeInternal.None;
      if ((gestures & GestureType.Tap) != GestureType.None)
        expected |= GestureTypeInternal.Tap;
      if ((gestures & GestureType.DoubleTap) != GestureType.None)
        expected |= GestureTypeInternal.DoubleTap;
      if ((gestures & GestureType.Hold) != GestureType.None)
        expected |= GestureTypeInternal.Hold;
      if ((gestures & GestureType.HorizontalDrag) != GestureType.None)
        expected |= this._flipOrientation ? GestureTypeInternal.VertDrag : GestureTypeInternal.HorzDrag;
      if ((gestures & GestureType.VerticalDrag) != GestureType.None)
        expected |= this._flipOrientation ? GestureTypeInternal.HorzDrag : GestureTypeInternal.VertDrag;
      if ((gestures & GestureType.FreeDrag) != GestureType.None)
        expected |= GestureTypeInternal.FreeDrag;
      if ((gestures & GestureType.Pinch) != GestureType.None)
        expected |= GestureTypeInternal.PinchStretch;
      if ((gestures & GestureType.Flick) != GestureType.None)
        expected |= GestureTypeInternal.Flick;
      Helpers.ThrowExceptionFromResult(SafeTouchNativeMethods.TouchSessionSetExpected(this._handle, expected));
      this._enabledGestures = gestures;
    }

    internal void SetEffectiveOrientation(DisplayOrientation orientation)
    {
      int num1 = this._flipOrientation ? 1 : 0;
      this._flipOrientation = orientation == DisplayOrientation.LandscapeLeft || orientation == DisplayOrientation.LandscapeRight;
      int num2 = this._flipOrientation ? 1 : 0;
      if (num1 == num2 || (this._enabledGestures & GestureType.HorizontalDrag) == GestureType.None && (this._enabledGestures & GestureType.VerticalDrag) == GestureType.None)
        return;
      this.SetEnabledGestures(this._enabledGestures, true);
    }

    private void AddToHistory(ref GestureSample gesture)
    {
      this._gestureHistory[(this._gestureHistoryReadIndex + this._gestureHistoryCount) % TouchSession.MAX_GESTURE_HISTORY] = gesture;
      if (this._gestureHistoryCount == TouchSession.MAX_GESTURE_HISTORY)
        this._gestureHistoryReadIndex = (this._gestureHistoryReadIndex + 1) % TouchSession.MAX_GESTURE_HISTORY;
      else
        ++this._gestureHistoryCount;
    }

    internal bool IsGestureAvailable => this._gestureHistoryCount > 0;

    internal void ReadGesture(out GestureSample sample)
    {
      if (this._gestureHistoryCount <= 0)
        throw new InvalidOperationException(FrameworkResources.GesturesNotAvailable);
      sample = this._gestureHistory[this._gestureHistoryReadIndex];
      --this._gestureHistoryCount;
      this._gestureHistoryReadIndex = (this._gestureHistoryReadIndex + 1) % TouchSession.MAX_GESTURE_HISTORY;
    }

    private void UpdateGestureHistory(uint timestamp)
    {
      GestureSample sample = new GestureSample();
      sample._timestamp = TimeSpan.FromTicks((long) timestamp * 10000L);
      while (true)
      {
        GestureTypeInternal potentials;
        do
        {
          Helpers.ThrowExceptionFromResult(SafeTouchNativeMethods.TouchSessionQueryPotentials(this._handle, out potentials));
          if (potentials == GestureTypeInternal.None || potentials == GestureTypeInternal.ShortHold)
          {
            if (this._lastMessageIsEnd && this._dragIsActive)
              this.AddDragCompleteSample(ref sample);
            if (this._lastMessageIsEnd && this._pinchIsActive)
            {
              this.AddPinchCompleteSample(ref sample);
              goto label_19;
            }
            else
              goto label_19;
          }
          else
          {
            if ((potentials & GestureTypeInternal.Tap) != GestureTypeInternal.None)
              this.AddTapSample(false, ref sample);
            if ((potentials & GestureTypeInternal.DoubleTap) != GestureTypeInternal.None)
              this.AddTapSample(true, ref sample);
            if ((potentials & GestureTypeInternal.Hold) != GestureTypeInternal.None)
              this.AddHoldSample(ref sample);
            if ((potentials & GestureTypeInternal.PinchStretch) != GestureTypeInternal.None)
            {
              if (((potentials & GestureTypeInternal.HorzDrag) != GestureTypeInternal.None || (potentials & GestureTypeInternal.VertDrag) != GestureTypeInternal.None || (potentials & GestureTypeInternal.FreeDrag) != GestureTypeInternal.None) && this._dragIsActive)
              {
                this.HandleDragSamples(potentials, ref sample);
                this.AddPinchSample(ref sample);
              }
              else
              {
                this.AddPinchSample(ref sample);
                this.HandleDragSamples(potentials, ref sample);
              }
            }
            else
              this.HandleDragSamples(potentials, ref sample);
          }
        }
        while ((potentials & GestureTypeInternal.Flick) == GestureTypeInternal.None);
        this.AddFlickSample(ref sample);
      }
label_19:
      this._lastMessageIsEnd = false;
    }

    private void AddTapSample(bool doubleTap, ref GestureSample sample)
    {
      GestureTapData data;
      data.Size = TouchSession._tapDataSize;
      Helpers.ThrowExceptionFromResult(UnsafeTouchNativeMethods.TouchSessionGetInfoTap(this._handle, doubleTap, out data));
      sample._gestureType = doubleTap ? GestureType.DoubleTap : GestureType.Tap;
      sample._position = new Vector2((float) data.Location.X, (float) data.Location.Y);
      sample._position2 = Vector2.Zero;
      sample._delta = Vector2.Zero;
      sample._delta2 = Vector2.Zero;
      TouchPanel.TransformPosition(ref sample._position.X, ref sample._position.Y);
      this.AddToHistory(ref sample);
    }

    private void AddHoldSample(ref GestureSample sample)
    {
      GestureHoldData data;
      data.Size = TouchSession._holdDataSize;
      Helpers.ThrowExceptionFromResult(UnsafeTouchNativeMethods.TouchSessionGetInfoHold(this._handle, false, out data));
      if (data.Status != GestureHoldStatus.Completed)
        return;
      sample._gestureType = GestureType.Hold;
      sample._position = new Vector2((float) data.Location.X, (float) data.Location.Y);
      sample._position2 = Vector2.Zero;
      sample._delta = Vector2.Zero;
      sample._delta2 = Vector2.Zero;
      TouchPanel.TransformPosition(ref sample._position.X, ref sample._position.Y);
      this.AddToHistory(ref sample);
    }

    private void HandleDragSamples(GestureTypeInternal potentials, ref GestureSample sample)
    {
      if ((potentials & GestureTypeInternal.HorzDrag) != GestureTypeInternal.None)
        this.AddDragSample(this._flipOrientation ? GestureType.VerticalDrag : GestureType.HorizontalDrag, ref sample);
      else if ((potentials & GestureTypeInternal.VertDrag) != GestureTypeInternal.None)
      {
        this.AddDragSample(this._flipOrientation ? GestureType.HorizontalDrag : GestureType.VerticalDrag, ref sample);
      }
      else
      {
        if ((potentials & GestureTypeInternal.FreeDrag) == GestureTypeInternal.None)
          return;
        this.AddDragSample(GestureType.FreeDrag, ref sample);
      }
    }

    private void AddDragSample(GestureType gestureType, ref GestureSample sample)
    {
      GestureDragData data;
      data.Size = TouchSession._dragDataSize;
      Helpers.ThrowExceptionFromResult(UnsafeTouchNativeMethods.TouchSessionGetInfoDrag(this._handle, out data));
      sample._gestureType = gestureType;
      sample._position = new Vector2((float) data.Location.X, (float) data.Location.Y);
      sample._position2 = Vector2.Zero;
      sample._delta = new Vector2((float) data.DragDelta.X, (float) data.DragDelta.Y);
      sample._delta2 = Vector2.Zero;
      TouchPanel.TransformPosition(ref sample._position.X, ref sample._position.Y);
      TouchPanel.TransformVector(ref sample._delta.X, ref sample._delta.Y);
      switch (gestureType)
      {
        case GestureType.HorizontalDrag:
          sample._delta.Y = 0.0f;
          break;
        case GestureType.VerticalDrag:
          sample._delta.X = 0.0f;
          break;
      }
      this.AddToHistory(ref sample);
      this._dragIsActive = true;
      if (!data.ContactsChanging)
        return;
      this.AddDragCompleteSample(ref sample);
    }

    private void AddDragCompleteSample(ref GestureSample sample)
    {
      if ((this._enabledGestures & GestureType.DragComplete) != GestureType.None)
      {
        sample._gestureType = GestureType.DragComplete;
        sample._position = Vector2.Zero;
        sample._position2 = Vector2.Zero;
        sample._delta = Vector2.Zero;
        sample._delta2 = Vector2.Zero;
        this.AddToHistory(ref sample);
      }
      this._dragIsActive = false;
    }

    private void AddPinchSample(ref GestureSample sample)
    {
      GesturePinchStretchData data;
      data.Size = TouchSession._pinchStretchDataSize;
      Helpers.ThrowExceptionFromResult(UnsafeTouchNativeMethods.TouchSessionGetInfoPinchStretch(this._handle, out data));
      sample._gestureType = GestureType.Pinch;
      sample._position = new Vector2((float) data.Contact1.X, (float) data.Contact1.Y);
      sample._position2 = new Vector2((float) data.Contact2.X, (float) data.Contact2.Y);
      sample._delta = new Vector2((float) data.Contact1Delta.X, (float) data.Contact1Delta.Y);
      sample._delta2 = new Vector2((float) data.Contact2Delta.X, (float) data.Contact2Delta.Y);
      TouchPanel.TransformPosition(ref sample._position.X, ref sample._position.Y);
      TouchPanel.TransformPosition(ref sample._position2.X, ref sample._position2.Y);
      TouchPanel.TransformVector(ref sample._delta.X, ref sample._delta.Y);
      TouchPanel.TransformVector(ref sample._delta2.X, ref sample._delta2.Y);
      this.AddToHistory(ref sample);
      this._pinchIsActive = true;
      if (!data.ContactsChanging)
        return;
      this.AddPinchCompleteSample(ref sample);
    }

    private void AddPinchCompleteSample(ref GestureSample sample)
    {
      if ((this._enabledGestures & GestureType.PinchComplete) != GestureType.None)
      {
        sample._gestureType = GestureType.PinchComplete;
        sample._position = Vector2.Zero;
        sample._position2 = Vector2.Zero;
        sample._delta = Vector2.Zero;
        sample._delta2 = Vector2.Zero;
        this.AddToHistory(ref sample);
      }
      this._pinchIsActive = false;
    }

    private void AddFlickSample(ref GestureSample sample)
    {
      GestureFlickData data;
      data.Size = TouchSession._flickDataSize;
      Helpers.ThrowExceptionFromResult(UnsafeTouchNativeMethods.TouchSessionGetInfoFlick(this._handle, out data));
      sample._gestureType = GestureType.Flick;
      sample._position = Vector2.Zero;
      sample._position2 = Vector2.Zero;
      sample._delta = new Vector2((float) data.HorizontalVelocity, (float) data.VerticalVelocity);
      sample._delta2 = Vector2.Zero;
      TouchPanel.TransformVector(ref sample._delta.X, ref sample._delta.Y);
      this.AddToHistory(ref sample);
    }
  }
}
