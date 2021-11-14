// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.ButtonValues
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework.Input
{
  [Flags]
  internal enum ButtonValues : ushort
  {
    A = 4096, // 0x1000
    B = 8192, // 0x2000
    Back = 32, // 0x0020
    Down = 2,
    Left = 4,
    LeftShoulder = 256, // 0x0100
    LeftThumb = 64, // 0x0040
    Right = 8,
    RightShoulder = 512, // 0x0200
    RightThumb = 128, // 0x0080
    Start = 16, // 0x0010
    Up = 1,
    X = 16384, // 0x4000
    Y = 32768, // 0x8000
    BigButton = 2048, // 0x0800
  }
}
