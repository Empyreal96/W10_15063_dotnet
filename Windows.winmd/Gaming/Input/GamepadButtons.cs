// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.GamepadButtons
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum GamepadButtons : uint
  {
    None = 0,
    Menu = 1,
    View = 2,
    A = 4,
    B = 8,
    X = 16, // 0x00000010
    Y = 32, // 0x00000020
    DPadUp = 64, // 0x00000040
    DPadDown = 128, // 0x00000080
    DPadLeft = 256, // 0x00000100
    DPadRight = 512, // 0x00000200
    LeftShoulder = 1024, // 0x00000400
    RightShoulder = 2048, // 0x00000800
    LeftThumbstick = 4096, // 0x00001000
    RightThumbstick = 8192, // 0x00002000
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Paddle1 = 16384, // 0x00004000
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Paddle2 = 32768, // 0x00008000
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Paddle3 = 65536, // 0x00010000
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Paddle4 = 131072, // 0x00020000
  }
}
