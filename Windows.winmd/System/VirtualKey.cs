﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.VirtualKey
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VirtualKey
  {
    None = 0,
    LeftButton = 1,
    RightButton = 2,
    Cancel = 3,
    MiddleButton = 4,
    XButton1 = 5,
    XButton2 = 6,
    Back = 8,
    Tab = 9,
    Clear = 12, // 0x0000000C
    Enter = 13, // 0x0000000D
    Shift = 16, // 0x00000010
    Control = 17, // 0x00000011
    Menu = 18, // 0x00000012
    Pause = 19, // 0x00000013
    CapitalLock = 20, // 0x00000014
    Hangul = 21, // 0x00000015
    Kana = 21, // 0x00000015
    Junja = 23, // 0x00000017
    Final = 24, // 0x00000018
    Hanja = 25, // 0x00000019
    Kanji = 25, // 0x00000019
    Escape = 27, // 0x0000001B
    Convert = 28, // 0x0000001C
    NonConvert = 29, // 0x0000001D
    Accept = 30, // 0x0000001E
    ModeChange = 31, // 0x0000001F
    Space = 32, // 0x00000020
    PageUp = 33, // 0x00000021
    PageDown = 34, // 0x00000022
    End = 35, // 0x00000023
    Home = 36, // 0x00000024
    Left = 37, // 0x00000025
    Up = 38, // 0x00000026
    Right = 39, // 0x00000027
    Down = 40, // 0x00000028
    Select = 41, // 0x00000029
    Print = 42, // 0x0000002A
    Execute = 43, // 0x0000002B
    Snapshot = 44, // 0x0000002C
    Insert = 45, // 0x0000002D
    Delete = 46, // 0x0000002E
    Help = 47, // 0x0000002F
    Number0 = 48, // 0x00000030
    Number1 = 49, // 0x00000031
    Number2 = 50, // 0x00000032
    Number3 = 51, // 0x00000033
    Number4 = 52, // 0x00000034
    Number5 = 53, // 0x00000035
    Number6 = 54, // 0x00000036
    Number7 = 55, // 0x00000037
    Number8 = 56, // 0x00000038
    Number9 = 57, // 0x00000039
    A = 65, // 0x00000041
    B = 66, // 0x00000042
    C = 67, // 0x00000043
    D = 68, // 0x00000044
    E = 69, // 0x00000045
    F = 70, // 0x00000046
    G = 71, // 0x00000047
    H = 72, // 0x00000048
    I = 73, // 0x00000049
    J = 74, // 0x0000004A
    K = 75, // 0x0000004B
    L = 76, // 0x0000004C
    M = 77, // 0x0000004D
    N = 78, // 0x0000004E
    O = 79, // 0x0000004F
    P = 80, // 0x00000050
    Q = 81, // 0x00000051
    R = 82, // 0x00000052
    S = 83, // 0x00000053
    T = 84, // 0x00000054
    U = 85, // 0x00000055
    V = 86, // 0x00000056
    W = 87, // 0x00000057
    X = 88, // 0x00000058
    Y = 89, // 0x00000059
    Z = 90, // 0x0000005A
    LeftWindows = 91, // 0x0000005B
    RightWindows = 92, // 0x0000005C
    Application = 93, // 0x0000005D
    Sleep = 95, // 0x0000005F
    NumberPad0 = 96, // 0x00000060
    NumberPad1 = 97, // 0x00000061
    NumberPad2 = 98, // 0x00000062
    NumberPad3 = 99, // 0x00000063
    NumberPad4 = 100, // 0x00000064
    NumberPad5 = 101, // 0x00000065
    NumberPad6 = 102, // 0x00000066
    NumberPad7 = 103, // 0x00000067
    NumberPad8 = 104, // 0x00000068
    NumberPad9 = 105, // 0x00000069
    Multiply = 106, // 0x0000006A
    Add = 107, // 0x0000006B
    Separator = 108, // 0x0000006C
    Subtract = 109, // 0x0000006D
    Decimal = 110, // 0x0000006E
    Divide = 111, // 0x0000006F
    F1 = 112, // 0x00000070
    F2 = 113, // 0x00000071
    F3 = 114, // 0x00000072
    F4 = 115, // 0x00000073
    F5 = 116, // 0x00000074
    F6 = 117, // 0x00000075
    F7 = 118, // 0x00000076
    F8 = 119, // 0x00000077
    F9 = 120, // 0x00000078
    F10 = 121, // 0x00000079
    F11 = 122, // 0x0000007A
    F12 = 123, // 0x0000007B
    F13 = 124, // 0x0000007C
    F14 = 125, // 0x0000007D
    F15 = 126, // 0x0000007E
    F16 = 127, // 0x0000007F
    F17 = 128, // 0x00000080
    F18 = 129, // 0x00000081
    F19 = 130, // 0x00000082
    F20 = 131, // 0x00000083
    F21 = 132, // 0x00000084
    F22 = 133, // 0x00000085
    F23 = 134, // 0x00000086
    F24 = 135, // 0x00000087
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationView = 136, // 0x00000088
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationMenu = 137, // 0x00000089
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationUp = 138, // 0x0000008A
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationDown = 139, // 0x0000008B
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationLeft = 140, // 0x0000008C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationRight = 141, // 0x0000008D
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationAccept = 142, // 0x0000008E
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationCancel = 143, // 0x0000008F
    NumberKeyLock = 144, // 0x00000090
    Scroll = 145, // 0x00000091
    LeftShift = 160, // 0x000000A0
    RightShift = 161, // 0x000000A1
    LeftControl = 162, // 0x000000A2
    RightControl = 163, // 0x000000A3
    LeftMenu = 164, // 0x000000A4
    RightMenu = 165, // 0x000000A5
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GoBack = 166, // 0x000000A6
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GoForward = 167, // 0x000000A7
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Refresh = 168, // 0x000000A8
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Stop = 169, // 0x000000A9
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Search = 170, // 0x000000AA
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Favorites = 171, // 0x000000AB
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GoHome = 172, // 0x000000AC
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadA = 195, // 0x000000C3
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadB = 196, // 0x000000C4
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadX = 197, // 0x000000C5
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadY = 198, // 0x000000C6
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightShoulder = 199, // 0x000000C7
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftShoulder = 200, // 0x000000C8
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftTrigger = 201, // 0x000000C9
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightTrigger = 202, // 0x000000CA
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadDPadUp = 203, // 0x000000CB
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadDPadDown = 204, // 0x000000CC
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadDPadLeft = 205, // 0x000000CD
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadDPadRight = 206, // 0x000000CE
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadMenu = 207, // 0x000000CF
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadView = 208, // 0x000000D0
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftThumbstickButton = 209, // 0x000000D1
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightThumbstickButton = 210, // 0x000000D2
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftThumbstickUp = 211, // 0x000000D3
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftThumbstickDown = 212, // 0x000000D4
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftThumbstickRight = 213, // 0x000000D5
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftThumbstickLeft = 214, // 0x000000D6
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightThumbstickUp = 215, // 0x000000D7
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightThumbstickDown = 216, // 0x000000D8
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightThumbstickRight = 217, // 0x000000D9
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightThumbstickLeft = 218, // 0x000000DA
  }
}