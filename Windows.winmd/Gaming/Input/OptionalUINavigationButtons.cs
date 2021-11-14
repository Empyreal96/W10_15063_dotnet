// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.OptionalUINavigationButtons
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
  public enum OptionalUINavigationButtons : uint
  {
    None = 0,
    Context1 = 1,
    Context2 = 2,
    Context3 = 4,
    Context4 = 8,
    PageUp = 16, // 0x00000010
    PageDown = 32, // 0x00000020
    PageLeft = 64, // 0x00000040
    PageRight = 128, // 0x00000080
    ScrollUp = 256, // 0x00000100
    ScrollDown = 512, // 0x00000200
    ScrollLeft = 1024, // 0x00000400
    ScrollRight = 2048, // 0x00000800
  }
}
