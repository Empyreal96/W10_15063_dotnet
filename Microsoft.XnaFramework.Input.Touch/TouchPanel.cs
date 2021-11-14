// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.TouchPanel
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using Microsoft.Phone;
using System;
using System.Windows;

namespace Microsoft.Xna.Framework.Input.Touch
{
  public static class TouchPanel
  {
    private static bool nointerop = false;
    private static XNAINPUT_TOUCH_LOCATION_STATE prevState;
    private static TouchCollection touchState = new TouchCollection();
    private static DisplayOrientation displayOrientation = DisplayOrientation.Portrait;
    private static int displayWidth = 480;
    private static int displayHeight = 800;
    private static int displayHeightHD = 853;
    private static bool displaySettingsChanged = true;
    private static Vector2 touchOffset = Vector2.Zero;
    private static Vector2 touchScale = Vector2.One;
    private static Vector2 touchMax = new Vector2(float.MaxValue);
    private static bool swapXY = false;
    private static GestureType _enabledGestures;
    private static bool _haveGestureBeenEnabled;
    private const GestureType AllGestureTypes = GestureType.Tap | GestureType.DoubleTap | GestureType.Hold | GestureType.HorizontalDrag | GestureType.VerticalDrag | GestureType.FreeDrag | GestureType.Pinch | GestureType.Flick | GestureType.DragComplete | GestureType.PinchComplete;

    public static TouchPanelCapabilities GetCapabilities() => TouchPanelCapabilities.GetCaps();

    public static GestureType EnabledGestures
    {
      get => TouchPanel._enabledGestures;
      set
      {
        if ((value & ~(GestureType.Tap | GestureType.DoubleTap | GestureType.Hold | GestureType.HorizontalDrag | GestureType.VerticalDrag | GestureType.FreeDrag | GestureType.Pinch | GestureType.Flick | GestureType.DragComplete | GestureType.PinchComplete)) != GestureType.None)
          throw new ArgumentException(nameof (EnabledGestures));
        Microsoft.Xna.Framework.Input.Touch.Touch.SetEnabledGestures(value);
        TouchPanel._enabledGestures = value;
        TouchPanel._haveGestureBeenEnabled = true;
      }
    }

    public static bool IsGestureAvailable
    {
      get
      {
        if (!TouchPanel._haveGestureBeenEnabled)
          throw new InvalidOperationException(FrameworkResources.GesturesNotEnabled);
        return Microsoft.Xna.Framework.Input.Touch.Touch.IsGestureAvailable;
      }
    }

    public static GestureSample ReadGesture()
    {
      if (!TouchPanel._haveGestureBeenEnabled)
        throw new InvalidOperationException(FrameworkResources.GesturesNotEnabled);
      GestureSample sample;
      Microsoft.Xna.Framework.Input.Touch.Touch.ReadGesture(out sample);
      return sample;
    }

    public static TouchCollection GetState()
    {
      XNAINPUT_TOUCH_LOCATION_STATE state = new XNAINPUT_TOUCH_LOCATION_STATE();
      if (!TouchPanel.nointerop)
      {
        try
        {
          if (TouchPanel.displaySettingsChanged)
            TouchPanel.OnDisplaySettingsChanged();
          Microsoft.Xna.Framework.Input.Touch.Touch.GetTouchState(out state);
          TouchPanel.TransformTouchState(ref state);
          TouchPanel.touchState.Update(ref TouchPanel.prevState, ref state, true);
          TouchPanel.prevState = state;
        }
        catch
        {
          TouchPanel.nointerop = true;
          TouchPanel.touchState.Update(ref TouchPanel.prevState, ref state, false);
        }
      }
      return TouchPanel.touchState;
    }

    public static IntPtr WindowHandle { get; set; }

    internal static uint GamePageHandle { get; set; }

    public static DisplayOrientation DisplayOrientation
    {
      get => TouchPanel.displayOrientation;
      set
      {
        Helpers.ValidateOrientation(value);
        TouchPanel.displayOrientation = value;
        TouchPanel.displaySettingsChanged = true;
      }
    }

    public static int DisplayWidth
    {
      get => TouchPanel.displayWidth;
      set
      {
        TouchPanel.displayWidth = value;
        TouchPanel.displaySettingsChanged = true;
      }
    }

    public static int DisplayHeight
    {
      get => TouchPanel.displayHeight;
      set
      {
        TouchPanel.displayHeight = value;
        TouchPanel.displaySettingsChanged = true;
      }
    }

    private static void OnDisplaySettingsChanged()
    {
      TouchPanel.prevState = new XNAINPUT_TOUCH_LOCATION_STATE();
      TouchPanel.touchState = new TouchCollection();
      TouchPanel.ConfigureTouchTransform();
      TouchPanel.displaySettingsChanged = false;
    }

    private static void ConfigureTouchTransform()
    {
      if (TouchPanel.displayWidth <= 0 || TouchPanel.displayHeight <= 0)
      {
        TouchPanel.touchOffset = Vector2.Zero;
        TouchPanel.touchScale = Vector2.One;
        TouchPanel.touchMax = new Vector2(float.MaxValue);
        TouchPanel.swapXY = false;
      }
      else
      {
        DisplayOrientation orientation = Helpers.ChooseOrientation(TouchPanel.displayOrientation, TouchPanel.displayWidth, TouchPanel.displayHeight, false);
        bool flag1;
        bool flag2;
        switch (orientation)
        {
          case DisplayOrientation.LandscapeLeft:
            TouchPanel.swapXY = true;
            flag1 = true;
            flag2 = false;
            break;
          case DisplayOrientation.LandscapeRight:
            TouchPanel.swapXY = true;
            flag1 = false;
            flag2 = true;
            break;
          default:
            TouchPanel.swapXY = false;
            flag1 = false;
            flag2 = false;
            break;
        }
        Microsoft.Xna.Framework.Input.Touch.Touch.SetEffectiveOrientation(orientation);
        int num1 = TouchPanel.swapXY ? TouchPanel.displayHeight : TouchPanel.displayWidth;
        int num2 = TouchPanel.swapXY ? TouchPanel.displayWidth : TouchPanel.displayHeight;
        int left = 0;
        int top = 0;
        int width = num1;
        int height = num2;
        if (SafeTouchNativeMethods.GamePage_GetClientBounds(TouchPanel.GamePageHandle, ref left, ref top, ref width, ref height, false) != 0U)
        {
          int clientBounds = (int) SafeTouchNativeMethods.GamePage_GetClientBounds(TouchPanel.GamePageHandle, ref left, ref top, ref width, ref height, true);
          if (!QuirksMode.ShouldXnaUseMangoDisplaySize() && (width == 720 && height == 1280 || width == 1080 && height == 1920))
          {
            num1 = TouchPanel.swapXY ? TouchPanel.displayHeightHD : TouchPanel.displayWidth;
            num2 = TouchPanel.swapXY ? TouchPanel.displayWidth : TouchPanel.displayHeightHD;
          }
          if (width == 480 && height == 854)
            height = 800;
        }
        int num3 = width;
        int num4 = width * num2 / num1;
        if (num4 > height)
        {
          num3 = height * num1 / num2;
          num4 = height;
        }
        TouchPanel.touchOffset.X = (float) (-left - (width - num3) / 2);
        if (Application.Current.LetterboxingStrategy == 1)
          TouchPanel.touchOffset.Y = (float) (-top - (height - num4) / 2);
        else if (Application.Current.LetterboxingStrategy == null)
          TouchPanel.touchOffset.Y = (float) (-top - (height - num4));
        else if (Application.Current.LetterboxingStrategy == 2)
          TouchPanel.touchOffset.Y = (float) -top;
        TouchPanel.touchScale.X = (float) num1 / (float) num3;
        TouchPanel.touchScale.Y = (float) num2 / (float) num4;
        if (flag1)
        {
          TouchPanel.touchOffset.X -= (float) (num3 - 1);
          TouchPanel.touchScale.X *= -1f;
        }
        if (flag2)
        {
          TouchPanel.touchOffset.Y -= (float) (num4 - 1);
          TouchPanel.touchScale.Y *= -1f;
        }
        TouchPanel.touchMax.X = (float) (num1 - 1);
        TouchPanel.touchMax.Y = (float) (num2 - 1);
      }
    }

    private static void TransformTouchState(ref XNAINPUT_TOUCH_LOCATION_STATE state)
    {
      if (state.Count > 0)
        TouchPanel.TransformPosition(ref state.X0, ref state.Y0);
      if (state.Count > 1)
        TouchPanel.TransformPosition(ref state.X1, ref state.Y1);
      if (state.Count > 2)
        TouchPanel.TransformPosition(ref state.X2, ref state.Y2);
      if (state.Count <= 3)
        return;
      TouchPanel.TransformPosition(ref state.X3, ref state.Y3);
    }

    internal static void TransformPosition(ref float x, ref float y)
    {
      if (TouchPanel.displaySettingsChanged)
        TouchPanel.OnDisplaySettingsChanged();
      ref float local1 = ref x;
      local1 = (float) (int) (((double) local1 + (double) TouchPanel.touchOffset.X) * (double) TouchPanel.touchScale.X + 0.5);
      ref float local2 = ref y;
      local2 = (float) (int) (((double) local2 + (double) TouchPanel.touchOffset.Y) * (double) TouchPanel.touchScale.Y + 0.5);
      if ((double) x > (double) TouchPanel.touchMax.X)
        x = TouchPanel.touchMax.X;
      else if ((double) x < 0.0)
        x = 0.0f;
      if ((double) y > (double) TouchPanel.touchMax.Y)
        y = TouchPanel.touchMax.Y;
      else if ((double) y < 0.0)
        y = 0.0f;
      if (!TouchPanel.swapXY)
        return;
      float num = x;
      x = y;
      y = num;
    }

    internal static void TransformVector(ref float x, ref float y)
    {
      if (TouchPanel.displaySettingsChanged)
        TouchPanel.OnDisplaySettingsChanged();
      x *= TouchPanel.touchScale.X;
      y *= TouchPanel.touchScale.Y;
      if (!TouchPanel.swapXY)
        return;
      float num = x;
      x = y;
      y = num;
    }
  }
}
