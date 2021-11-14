// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.GestureType
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using System;

namespace Microsoft.Xna.Framework.Input.Touch
{
  [Flags]
  public enum GestureType
  {
    None = 0,
    Tap = 1,
    DoubleTap = 2,
    Hold = 4,
    HorizontalDrag = 8,
    VerticalDrag = 16, // 0x00000010
    FreeDrag = 32, // 0x00000020
    Pinch = 64, // 0x00000040
    Flick = 128, // 0x00000080
    DragComplete = 256, // 0x00000100
    PinchComplete = 512, // 0x00000200
  }
}
