// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ArcadeStickButtons
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
  public enum ArcadeStickButtons : uint
  {
    None = 0,
    StickUp = 1,
    StickDown = 2,
    StickLeft = 4,
    StickRight = 8,
    Action1 = 16, // 0x00000010
    Action2 = 32, // 0x00000020
    Action3 = 64, // 0x00000040
    Action4 = 128, // 0x00000080
    Action5 = 256, // 0x00000100
    Action6 = 512, // 0x00000200
    Special1 = 1024, // 0x00000400
    Special2 = 2048, // 0x00000800
  }
}
