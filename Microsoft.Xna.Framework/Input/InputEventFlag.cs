// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.InputEventFlag
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework.Input
{
  [Flags]
  internal enum InputEventFlag : ushort
  {
    InputEventFlag_None = 0,
    InputEventFlag_Down = 1,
    InputEventFlag_Move = 2,
    InputEventFlag_Hold = InputEventFlag_Move, // 0x0002
    InputEventFlag_Up = 4,
    InputEventFlag_Empty = 4096, // 0x1000
    InputEventFlag_Invalid = 8192, // 0x2000
    InputEventFlag_TestSync = 32768, // 0x8000
  }
}
