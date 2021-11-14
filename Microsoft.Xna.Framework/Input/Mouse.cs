// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Mouse
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework.Input
{
  public static class Mouse
  {
    private static MouseState currentState;
    private static object syncObject = new object();
    private static IntPtr windowHandle;

    public static MouseState GetState()
    {
      lock (Mouse.syncObject)
        return Mouse.currentState;
    }

    public static void SetPosition(int x, int y)
    {
      lock (Mouse.syncObject)
      {
        Mouse.currentState.x = x;
        Mouse.currentState.y = y;
      }
    }

    internal static void SetState(MouseState state)
    {
      lock (Mouse.syncObject)
        Mouse.currentState = state;
    }

    public static IntPtr WindowHandle
    {
      get => Mouse.windowHandle;
      set => Mouse.windowHandle = value;
    }
  }
}
