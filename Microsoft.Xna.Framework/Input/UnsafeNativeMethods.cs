// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.UnsafeNativeMethods
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Xna.Framework.Input
{
  internal static class UnsafeNativeMethods
  {
    [DllImport("XnaFrameworkCore.dll")]
    internal static extern int GamePage_GetWindowHandle(uint handle);

    [DllImport("aygshell.dll")]
    internal static extern int SHSetImeMode(int hwnd, int imeMode);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint InitializeInput(bool isUnhosted);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint GetTouchInputEndpoint(out IntPtr touchEndpoint);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint GetTextInputEndpoint(out IntPtr textEndpoint);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint RegisterTextCallback(
      [MarshalAs(UnmanagedType.FunctionPtr)] ProcessTextInputDelegate processTextInputDelegate);
  }
}
