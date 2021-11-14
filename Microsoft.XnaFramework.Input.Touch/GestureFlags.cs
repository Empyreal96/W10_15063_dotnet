// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.GestureFlags
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using System;

namespace Microsoft.Xna.Framework.Input.Touch
{
  [Flags]
  internal enum GestureFlags : ulong
  {
    None = 0,
    Begin = 2,
    End = 4,
    Pan = 16, // 0x0000000000000010
    Scroll = 256, // 0x0000000000000100
    Hold = 512, // 0x0000000000000200
    Select = 1024, // 0x0000000000000400
    DoubleSelect = 2048, // 0x0000000000000800
    DirectManipulation = 4096, // 0x0000000000001000
    All = 18446744073709551615, // 0xFFFFFFFFFFFFFFFF
  }
}
