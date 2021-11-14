// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.RacingWheelButtons
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Flags]
  public enum RacingWheelButtons : uint
  {
    None = 0,
    PreviousGear = 1,
    NextGear = 2,
    DPadUp = 4,
    DPadDown = 8,
    DPadLeft = 16, // 0x00000010
    DPadRight = 32, // 0x00000020
    Button1 = 64, // 0x00000040
    Button2 = 128, // 0x00000080
    Button3 = 256, // 0x00000100
    Button4 = 512, // 0x00000200
    Button5 = 1024, // 0x00000400
    Button6 = 2048, // 0x00000800
    Button7 = 4096, // 0x00001000
    Button8 = 8192, // 0x00002000
    Button9 = 16384, // 0x00004000
    Button10 = 32768, // 0x00008000
    Button11 = 65536, // 0x00010000
    Button12 = 131072, // 0x00020000
    Button13 = 262144, // 0x00040000
    Button14 = 524288, // 0x00080000
    Button15 = 1048576, // 0x00100000
    Button16 = 2097152, // 0x00200000
  }
}
