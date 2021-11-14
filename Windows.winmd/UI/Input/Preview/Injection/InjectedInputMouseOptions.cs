// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputMouseOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum InjectedInputMouseOptions : uint
  {
    None = 0,
    Move = 1,
    LeftDown = 2,
    LeftUp = 4,
    RightDown = 8,
    RightUp = 16, // 0x00000010
    MiddleDown = 32, // 0x00000020
    MiddleUp = 64, // 0x00000040
    XDown = 128, // 0x00000080
    XUp = 256, // 0x00000100
    Wheel = 2048, // 0x00000800
    HWheel = 4096, // 0x00001000
    MoveNoCoalesce = 8192, // 0x00002000
    VirtualDesk = 16384, // 0x00004000
    Absolute = 32768, // 0x00008000
  }
}
