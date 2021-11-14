// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Buttons
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework.Input
{
  [Flags]
  public enum Buttons
  {
    A = 4096, // 0x00001000
    B = 8192, // 0x00002000
    X = 16384, // 0x00004000
    Y = 32768, // 0x00008000
    Back = 32, // 0x00000020
    Start = 16, // 0x00000010
    DPadUp = 1,
    DPadDown = 2,
    DPadLeft = 4,
    DPadRight = 8,
    LeftShoulder = 256, // 0x00000100
    RightShoulder = 512, // 0x00000200
    LeftStick = 64, // 0x00000040
    RightStick = 128, // 0x00000080
    BigButton = 2048, // 0x00000800
    LeftThumbstickLeft = 2097152, // 0x00200000
    LeftThumbstickRight = 1073741824, // 0x40000000
    LeftThumbstickDown = 536870912, // 0x20000000
    LeftThumbstickUp = 268435456, // 0x10000000
    RightThumbstickLeft = 134217728, // 0x08000000
    RightThumbstickRight = 67108864, // 0x04000000
    RightThumbstickDown = 33554432, // 0x02000000
    RightThumbstickUp = 16777216, // 0x01000000
    LeftTrigger = 8388608, // 0x00800000
    RightTrigger = 4194304, // 0x00400000
  }
}
