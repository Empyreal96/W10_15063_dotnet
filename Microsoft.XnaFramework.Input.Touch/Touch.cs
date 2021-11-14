// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.Touch
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Threading;

namespace Microsoft.Xna.Framework.Input.Touch
{
  internal static class Touch
  {
    private static ProcessTouchInfoDelegate _processTouchInfoDelegate;
    private static readonly int MAX_TOUCH_POINTS = 4;
    private static uint _touchInfoBufferSize;
    private static TouchSession _touchSession;
    private static FilterSession _filterSession;
    private static bool _touchDisabled;
    private static XNAINPUT_TOUCH_LOCATION_STATE _mergedTouchState;
    private static XNAINPUT_TOUCH_LOCATION_STATE _lastTouchState;
    private static Microsoft.Xna.Framework.Input.Touch.Touch.TouchMessageHooker _touchMessageHooker;
    private static bool _clearMergedTouchState;
    private static bool _lastMessageWasEnd;
    private static bool[] _downTouches;
    private static TimeSpan _lastGetState;
    private static Stopwatch _lastGetStateStopwatch;
    private static object SyncObject = new object();

    static Touch()
    {
      Microsoft.Xna.Framework.Input.Touch.Touch._touchInfoBufferSize = (uint) SafeTouchNativeMethods.SizeOf(typeof (TouchInfoBuffer));
      Microsoft.Xna.Framework.Input.Touch.Touch._downTouches = new bool[Microsoft.Xna.Framework.Input.Touch.Touch.MAX_TOUCH_POINTS];
      Microsoft.Xna.Framework.Input.Touch.Touch._lastGetStateStopwatch = new Stopwatch();
      Microsoft.Xna.Framework.Input.Touch.Touch._lastGetStateStopwatch.Start();
    }

    internal static void EnableTouchEvents()
    {
      if (Microsoft.Xna.Framework.Input.Touch.Touch._touchDisabled)
        return;
      try
      {
        if (TouchPanel.GetCapabilities().IsConnected)
        {
          if (Microsoft.Xna.Framework.Input.Touch.Touch._touchMessageHooker == null)
            Microsoft.Xna.Framework.Input.Touch.Touch._touchMessageHooker = new Microsoft.Xna.Framework.Input.Touch.Touch.TouchMessageHooker();
          if (Microsoft.Xna.Framework.Input.Touch.Touch._touchSession == null)
            Microsoft.Xna.Framework.Input.Touch.Touch._touchSession = new TouchSession();
          if (Microsoft.Xna.Framework.Input.Touch.Touch._filterSession == null)
            Microsoft.Xna.Framework.Input.Touch.Touch._filterSession = new FilterSession();
          if (Microsoft.Xna.Framework.Input.Touch.Touch._processTouchInfoDelegate == null)
          {
            Microsoft.Xna.Framework.Input.Touch.Touch._processTouchInfoDelegate = new ProcessTouchInfoDelegate(Microsoft.Xna.Framework.Input.Touch.Touch._touchMessageHooker.ProcessTouchInfo);
            int num = (int) SafeTouchNativeMethods.RegisterTouchCallback(Microsoft.Xna.Framework.Input.Touch.Touch._processTouchInfoDelegate);
          }
          Microsoft.Xna.Framework.Input.Touch.Touch.EnsureTouchInputEndpoint();
        }
        else
          Microsoft.Xna.Framework.Input.Touch.Touch._touchDisabled = true;
      }
      catch
      {
        Microsoft.Xna.Framework.Input.Touch.Touch._touchDisabled = true;
      }
    }

    private static void EnsureTouchInputEndpoint()
    {
      Dispatcher mainDispatcher = Dispatcher.MainDispatcher;
      if (mainDispatcher.CheckAccess())
      {
        int num = (int) SafeTouchNativeMethods.EnsureTouchInputEndpoint();
      }
      else
        mainDispatcher.Invoke(DispatcherPriority.Normal, (Delegate) (() => Microsoft.Xna.Framework.Input.Touch.Touch.EnsureTouchInputEndpoint()), (object[]) null);
    }

    internal static void DisableTouchEvents()
    {
      if (Microsoft.Xna.Framework.Input.Touch.Touch._touchDisabled)
        return;
      try
      {
        if (Microsoft.Xna.Framework.Input.Touch.Touch._processTouchInfoDelegate != null)
        {
          int num = (int) SafeTouchNativeMethods.RegisterTouchCallback((ProcessTouchInfoDelegate) null);
          Microsoft.Xna.Framework.Input.Touch.Touch._processTouchInfoDelegate = (ProcessTouchInfoDelegate) null;
        }
        if (Microsoft.Xna.Framework.Input.Touch.Touch._touchMessageHooker != null)
          Microsoft.Xna.Framework.Input.Touch.Touch._touchMessageHooker = (Microsoft.Xna.Framework.Input.Touch.Touch.TouchMessageHooker) null;
        if (Microsoft.Xna.Framework.Input.Touch.Touch._touchSession != null)
        {
          Microsoft.Xna.Framework.Input.Touch.Touch._touchSession.Dispose();
          Microsoft.Xna.Framework.Input.Touch.Touch._touchSession = (TouchSession) null;
        }
        if (Microsoft.Xna.Framework.Input.Touch.Touch._filterSession == null)
          return;
        Microsoft.Xna.Framework.Input.Touch.Touch._filterSession.Dispose();
        Microsoft.Xna.Framework.Input.Touch.Touch._filterSession = (FilterSession) null;
      }
      catch
      {
        Microsoft.Xna.Framework.Input.Touch.Touch._touchDisabled = true;
      }
    }

    private static void AddToSavedState(
      ref XNAINPUT_TOUCH_LOCATION_STATE state,
      ref Microsoft.Xna.Framework.Input.Touch.Touch.TouchData touchData,
      bool trackDownTouches,
      bool isDown)
    {
      int index = TouchCollection.FindById(ref state, touchData.Id);
      if (index < 0)
      {
        if (state.Count >= Microsoft.Xna.Framework.Input.Touch.Touch.MAX_TOUCH_POINTS)
          return;
        index = state.Count++;
      }
      if (trackDownTouches)
      {
        if (isDown)
          Microsoft.Xna.Framework.Input.Touch.Touch._downTouches[index] = true;
        else if (Microsoft.Xna.Framework.Input.Touch.Touch._downTouches[index])
          return;
      }
      switch (index)
      {
        case 0:
          state.Id0 = touchData.Id;
          state.X0 = touchData.Position.X;
          state.Y0 = touchData.Position.Y;
          break;
        case 1:
          state.Id1 = touchData.Id;
          state.X1 = touchData.Position.X;
          state.Y1 = touchData.Position.Y;
          break;
        case 2:
          state.Id2 = touchData.Id;
          state.X2 = touchData.Position.X;
          state.Y2 = touchData.Position.Y;
          break;
        case 3:
          state.Id3 = touchData.Id;
          state.X3 = touchData.Position.X;
          state.Y3 = touchData.Position.Y;
          break;
      }
    }

    internal static void GetTouchState(out XNAINPUT_TOUCH_LOCATION_STATE state)
    {
      lock (Microsoft.Xna.Framework.Input.Touch.Touch.SyncObject)
      {
        if (Microsoft.Xna.Framework.Input.Touch.Touch._touchMessageHooker == null)
          Microsoft.Xna.Framework.Input.Touch.Touch.EnableTouchEvents();
        TimeSpan elapsed = Microsoft.Xna.Framework.Input.Touch.Touch._lastGetStateStopwatch.Elapsed;
        state = !(elapsed - Microsoft.Xna.Framework.Input.Touch.Touch._lastGetState < TimeSpan.FromTicks(1250000L)) ? Microsoft.Xna.Framework.Input.Touch.Touch._lastTouchState : Microsoft.Xna.Framework.Input.Touch.Touch._mergedTouchState;
        Microsoft.Xna.Framework.Input.Touch.Touch._lastGetState = elapsed;
        if (Microsoft.Xna.Framework.Input.Touch.Touch._lastMessageWasEnd)
        {
          Microsoft.Xna.Framework.Input.Touch.Touch._lastTouchState = new XNAINPUT_TOUCH_LOCATION_STATE();
          Microsoft.Xna.Framework.Input.Touch.Touch._lastMessageWasEnd = false;
          Microsoft.Xna.Framework.Input.Touch.Touch.ClearDownTouches();
        }
        else
          Microsoft.Xna.Framework.Input.Touch.Touch._clearMergedTouchState = true;
        Microsoft.Xna.Framework.Input.Touch.Touch._mergedTouchState = Microsoft.Xna.Framework.Input.Touch.Touch._lastTouchState;
      }
    }

    internal static bool IsGestureAvailable
    {
      get
      {
        lock (Microsoft.Xna.Framework.Input.Touch.Touch.SyncObject)
          return Microsoft.Xna.Framework.Input.Touch.Touch._touchSession != null && Microsoft.Xna.Framework.Input.Touch.Touch._touchSession.IsGestureAvailable;
      }
    }

    internal static void ReadGesture(out GestureSample sample)
    {
      lock (Microsoft.Xna.Framework.Input.Touch.Touch.SyncObject)
      {
        if (Microsoft.Xna.Framework.Input.Touch.Touch._touchSession == null)
          throw new InvalidOperationException(FrameworkResources.GesturesNotAvailable);
        Microsoft.Xna.Framework.Input.Touch.Touch._touchSession.ReadGesture(out sample);
      }
    }

    internal static void SetEnabledGestures(GestureType gestures)
    {
      lock (Microsoft.Xna.Framework.Input.Touch.Touch.SyncObject)
      {
        if (Microsoft.Xna.Framework.Input.Touch.Touch._touchMessageHooker == null)
          Microsoft.Xna.Framework.Input.Touch.Touch.EnableTouchEvents();
        if (Microsoft.Xna.Framework.Input.Touch.Touch._touchSession == null)
          return;
        Microsoft.Xna.Framework.Input.Touch.Touch._touchSession.SetEnabledGestures(gestures, false);
      }
    }

    internal static void SetEffectiveOrientation(DisplayOrientation orientation)
    {
      lock (Microsoft.Xna.Framework.Input.Touch.Touch.SyncObject)
      {
        if (Microsoft.Xna.Framework.Input.Touch.Touch._touchMessageHooker == null)
          Microsoft.Xna.Framework.Input.Touch.Touch.EnableTouchEvents();
        if (Microsoft.Xna.Framework.Input.Touch.Touch._touchSession == null)
          return;
        Microsoft.Xna.Framework.Input.Touch.Touch._touchSession.SetEffectiveOrientation(orientation);
      }
    }

    internal static void ClearAllTouches()
    {
      Microsoft.Xna.Framework.Input.Touch.Touch._lastTouchState.Count = 0;
      Microsoft.Xna.Framework.Input.Touch.Touch._mergedTouchState.Count = 0;
      Microsoft.Xna.Framework.Input.Touch.Touch._clearMergedTouchState = false;
      Microsoft.Xna.Framework.Input.Touch.Touch.ClearDownTouches();
      Microsoft.Xna.Framework.Input.Touch.Touch._lastGetState = Microsoft.Xna.Framework.Input.Touch.Touch._lastGetStateStopwatch.Elapsed;
    }

    private static void ClearDownTouches()
    {
      for (int index = 0; index < Microsoft.Xna.Framework.Input.Touch.Touch.MAX_TOUCH_POINTS; ++index)
        Microsoft.Xna.Framework.Input.Touch.Touch._downTouches[index] = false;
    }

    internal class TouchMessageHooker
    {
      [AllowReversePInvokeCalls]
      internal void ProcessTouchInfo(ref TouchInfoBuffer touchInfoBuffer)
      {
        Microsoft.Xna.Framework.Input.Touch.Touch._touchSession.Add(ref touchInfoBuffer);
        Microsoft.Xna.Framework.Input.Touch.Touch._filterSession.Filter(ref touchInfoBuffer);
        Microsoft.Xna.Framework.Input.Touch.Touch._lastMessageWasEnd = (uint) (touchInfoBuffer.dwFlags & GestureInfoFlags.End) > 0U;
        lock (Microsoft.Xna.Framework.Input.Touch.Touch.SyncObject)
        {
          if (Microsoft.Xna.Framework.Input.Touch.Touch._clearMergedTouchState)
          {
            Microsoft.Xna.Framework.Input.Touch.Touch._mergedTouchState.Count = 0;
            Microsoft.Xna.Framework.Input.Touch.Touch._clearMergedTouchState = false;
            Microsoft.Xna.Framework.Input.Touch.Touch.ClearDownTouches();
          }
          Microsoft.Xna.Framework.Input.Touch.Touch._lastTouchState.Count = 0;
          for (int i = 0; i < (int) touchInfoBuffer.cContacts; ++i)
          {
            TouchContact rgContact = touchInfoBuffer.rgContacts[i];
            if ((rgContact.wFlags & TouchEventFlags.Move) != (TouchEventFlags) 0 || (rgContact.wFlags & TouchEventFlags.Down) != (TouchEventFlags) 0)
            {
              Microsoft.Xna.Framework.Input.Touch.Touch.TouchData touchData = new Microsoft.Xna.Framework.Input.Touch.Touch.TouchData()
              {
                Id = (int) touchInfoBuffer.dwSessionID << 16 | (int) rgContact.wContactID & (int) ushort.MaxValue,
                Position = new Vector2((float) rgContact.xWindow, (float) rgContact.yWindow)
              };
              Microsoft.Xna.Framework.Input.Touch.Touch.AddToSavedState(ref Microsoft.Xna.Framework.Input.Touch.Touch._lastTouchState, ref touchData, false, false);
              Microsoft.Xna.Framework.Input.Touch.Touch.AddToSavedState(ref Microsoft.Xna.Framework.Input.Touch.Touch._mergedTouchState, ref touchData, true, (uint) (rgContact.wFlags & TouchEventFlags.Down) > 0U);
            }
          }
        }
        if (Microsoft.Xna.Framework.Input.Touch.Touch._lastTouchState.Count > 0)
        {
          float x0 = Microsoft.Xna.Framework.Input.Touch.Touch._lastTouchState.X0;
          float y0 = Microsoft.Xna.Framework.Input.Touch.Touch._lastTouchState.Y0;
          TouchPanel.TransformPosition(ref x0, ref y0);
          Mouse.SetState(new MouseState((int) x0, (int) y0, 0, ButtonState.Pressed, ButtonState.Released, ButtonState.Released, ButtonState.Released, ButtonState.Released));
        }
        else
        {
          MouseState state = Mouse.GetState();
          state.leftButton = ButtonState.Released;
          Mouse.SetState(state);
        }
      }
    }

    private struct TouchData
    {
      public int Id;
      public Vector2 Position;
    }
  }
}
