// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Keyboard
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using MS.Internal;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Windows.Threading;

namespace Microsoft.Xna.Framework.Input
{
  public static class Keyboard
  {
    internal static Keys[] AllKeys = new Keys[159]
    {
      Keys.A,
      Keys.Add,
      Keys.Apps,
      Keys.Attn,
      Keys.B,
      Keys.Back,
      Keys.BrowserBack,
      Keys.BrowserFavorites,
      Keys.BrowserForward,
      Keys.BrowserHome,
      Keys.BrowserRefresh,
      Keys.BrowserSearch,
      Keys.BrowserStop,
      Keys.C,
      Keys.CapsLock,
      Keys.Crsel,
      Keys.D,
      Keys.D0,
      Keys.D1,
      Keys.D2,
      Keys.D3,
      Keys.D4,
      Keys.D5,
      Keys.D6,
      Keys.D7,
      Keys.D8,
      Keys.D9,
      Keys.Decimal,
      Keys.Delete,
      Keys.Divide,
      Keys.Down,
      Keys.E,
      Keys.End,
      Keys.Enter,
      Keys.EraseEof,
      Keys.Escape,
      Keys.Execute,
      Keys.Exsel,
      Keys.F,
      Keys.F1,
      Keys.F10,
      Keys.F11,
      Keys.F12,
      Keys.F13,
      Keys.F14,
      Keys.F15,
      Keys.F16,
      Keys.F17,
      Keys.F18,
      Keys.F19,
      Keys.F2,
      Keys.F20,
      Keys.F21,
      Keys.F22,
      Keys.F23,
      Keys.F24,
      Keys.F3,
      Keys.F4,
      Keys.F5,
      Keys.F6,
      Keys.F7,
      Keys.F8,
      Keys.F9,
      Keys.G,
      Keys.H,
      Keys.Help,
      Keys.Home,
      Keys.I,
      Keys.ImeConvert,
      Keys.ImeNoConvert,
      Keys.Insert,
      Keys.J,
      Keys.K,
      Keys.Kana,
      Keys.Kanji,
      Keys.L,
      Keys.LaunchApplication1,
      Keys.LaunchApplication2,
      Keys.LaunchMail,
      Keys.LeftControl,
      Keys.Left,
      Keys.LeftAlt,
      Keys.LeftShift,
      Keys.LeftWindows,
      Keys.M,
      Keys.MediaNextTrack,
      Keys.MediaPlayPause,
      Keys.MediaPreviousTrack,
      Keys.MediaStop,
      Keys.Multiply,
      Keys.N,
      Keys.NumLock,
      Keys.NumPad0,
      Keys.NumPad1,
      Keys.NumPad2,
      Keys.NumPad3,
      Keys.NumPad4,
      Keys.NumPad5,
      Keys.NumPad6,
      Keys.NumPad7,
      Keys.NumPad8,
      Keys.NumPad9,
      Keys.O,
      Keys.OemAuto,
      Keys.OemCopy,
      Keys.OemEnlW,
      Keys.OemSemicolon,
      Keys.OemBackslash,
      Keys.OemQuestion,
      Keys.OemTilde,
      Keys.OemOpenBrackets,
      Keys.OemPipe,
      Keys.OemCloseBrackets,
      Keys.OemQuotes,
      Keys.Oem8,
      Keys.OemClear,
      Keys.OemComma,
      Keys.OemMinus,
      Keys.OemPeriod,
      Keys.OemPlus,
      Keys.P,
      Keys.Pa1,
      Keys.PageDown,
      Keys.PageUp,
      Keys.Pause,
      Keys.Play,
      Keys.Print,
      Keys.PrintScreen,
      Keys.ProcessKey,
      Keys.Q,
      Keys.R,
      Keys.RightControl,
      Keys.Right,
      Keys.RightAlt,
      Keys.RightShift,
      Keys.RightWindows,
      Keys.S,
      Keys.Scroll,
      Keys.Select,
      Keys.SelectMedia,
      Keys.Separator,
      Keys.Sleep,
      Keys.Space,
      Keys.Subtract,
      Keys.T,
      Keys.Tab,
      Keys.U,
      Keys.Up,
      Keys.V,
      Keys.VolumeDown,
      Keys.VolumeMute,
      Keys.VolumeUp,
      Keys.W,
      Keys.X,
      Keys.Y,
      Keys.Z,
      Keys.Zoom,
      Keys.ChatPadGreen,
      Keys.ChatPadOrange
    };
    private static KeyboardState _lastState;
    private static KeyboardState _mergedState;
    private static IntPtr _windowHandle;
    private static object _syncObject = new object();
    private static Keyboard.KeyboardMessageHooker _keyboardMessageHooker;
    private static ProcessTextInputDelegate _processTextInputDelegate;
    private static bool _isEnabled;
    private static TimeSpan _lastGetState;
    private static Stopwatch _lastGetStateStopwatch = new Stopwatch();
    private const uint WM_KEYDOWN = 256;
    private const uint WM_KEYUP = 257;
    private const uint WM_SYSKEYDOWN = 260;
    private const uint WM_SYSKEYUP = 261;
    private const int VK_ACCENT = 199;
    private const int VK_ACCENT_FN = 200;
    private const int VK_ACCENT_PRESS_HOLD = 201;
    private const int VK_EMOTICON = 202;
    private const int VK_EMOTICON_FN = 203;
    private const int VK_EMOTICON_PRESS_HOLD = 204;
    private const int VK_SYMBOL = 122;
    private const int VK_SYMBOL_FN = 205;
    private const int VK_SYMBOL_PRESS_HOLD = 206;
    private const int VK_FUNCTION = 207;
    private const int VK_CAPS = 16;
    private const int VK_VIB = 227;
    private const int VK_TFLIP = 128;

    static Keyboard() => Keyboard._lastGetStateStopwatch.Start();

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public static KeyboardState GetState() => Keyboard.GetState((PlayerIndex) 255);

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public static KeyboardState GetState(PlayerIndex playerIndex)
    {
      KeyboardState keyboardState;
      lock (Keyboard._syncObject)
      {
        if (Keyboard._keyboardMessageHooker == null)
          Keyboard.EnableKeyboardEvents();
        TimeSpan elapsed = Keyboard._lastGetStateStopwatch.Elapsed;
        keyboardState = !(elapsed - Keyboard._lastGetState < TimeSpan.FromTicks(1250000L)) ? Keyboard._lastState : Keyboard._mergedState;
        Keyboard._lastGetState = elapsed;
        Keyboard._mergedState = Keyboard._lastState;
      }
      return keyboardState;
    }

    internal static IntPtr WindowHandle
    {
      get => Keyboard._windowHandle;
      set
      {
        Keyboard.DisableKeyboardEvents();
        Keyboard._windowHandle = value;
        Keyboard.EnableKeyboardEvents();
      }
    }

    internal static void EnableKeyboardEvents()
    {
      if (Keyboard._keyboardMessageHooker == null)
        Keyboard._keyboardMessageHooker = new Keyboard.KeyboardMessageHooker();
      if (Keyboard._processTextInputDelegate == null)
      {
        Keyboard._processTextInputDelegate = new ProcessTextInputDelegate(Keyboard._keyboardMessageHooker.ProcessKeyboardInput);
        int num = (int) SafeNativeMethods.RegisterTextCallback(Keyboard._processTextInputDelegate);
      }
      Keyboard.EnsureTextInputEndpoint();
    }

    private static void EnsureTextInputEndpoint()
    {
      Dispatcher mainDispatcher = Dispatcher.MainDispatcher;
      if (mainDispatcher.CheckAccess())
      {
        int num = (int) SafeNativeMethods.EnsureTextInputEndpoint();
      }
      else
        mainDispatcher.Invoke(DispatcherPriority.Normal, (Delegate) (() => Keyboard.EnsureTextInputEndpoint()), (object[]) null);
    }

    internal static void DisableKeyboardEvents()
    {
      if (Keyboard._processTextInputDelegate != null)
      {
        int num = (int) SafeNativeMethods.RegisterTextCallback((ProcessTextInputDelegate) null);
        Keyboard._processTextInputDelegate = (ProcessTextInputDelegate) null;
      }
      if (Keyboard._keyboardMessageHooker == null)
        return;
      Keyboard._keyboardMessageHooker = (Keyboard.KeyboardMessageHooker) null;
    }

    internal static bool IsEnabled
    {
      get => Keyboard._isEnabled;
      set
      {
        lock (Keyboard._syncObject)
        {
          if (value)
          {
            Keyboard._isEnabled = true;
          }
          else
          {
            Keyboard._isEnabled = false;
            KeyboardState keyboardState = new KeyboardState();
            Keyboard._lastState = Keyboard._mergedState = keyboardState;
          }
        }
      }
    }

    private class KeyboardMessageHooker
    {
      [AllowReversePInvokeCalls]
      internal void ProcessKeyboardInput(ref KeyEventHostInfo keyInfo)
      {
        lock (Keyboard._syncObject)
        {
          if (Keyboard._isEnabled)
          {
            try
            {
              if ((keyInfo.EventFlags & 1) != null)
              {
                int key = this.TransformKey((int) keyInfo.VirtualKey);
                if (key >= 0)
                {
                  Keyboard._lastState.AddPressedKey(key);
                  Keyboard._mergedState.AddPressedKey(key);
                }
              }
              else if ((keyInfo.EventFlags & 4) != null)
              {
                int key = this.TransformKey((int) keyInfo.VirtualKey);
                if (key >= 0)
                  Keyboard._lastState.RemovePressedKey(key);
              }
            }
            catch
            {
              KeyboardState keyboardState = new KeyboardState();
              Keyboard._lastState = Keyboard._mergedState = keyboardState;
            }
          }
          XcpImports.Host_ProcessKeyEvent(ref keyInfo);
        }
      }

      private int TransformKey(int vk)
      {
        switch (vk)
        {
          case 16:
            return 20;
          case 122:
            return 114;
          case 128:
            return -1;
          case 199:
            return 112;
          case 200:
            return 112;
          case 201:
            return 112;
          case 202:
            return 113;
          case 203:
            return 113;
          case 204:
            return 113;
          case 205:
            return 114;
          case 206:
            return 114;
          case 207:
            return 160;
          case 227:
            return 115;
          default:
            return vk;
        }
      }
    }
  }
}
