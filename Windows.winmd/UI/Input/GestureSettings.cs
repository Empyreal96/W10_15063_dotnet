// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.GestureSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum GestureSettings : uint
  {
    None = 0,
    Tap = 1,
    DoubleTap = 2,
    Hold = 4,
    HoldWithMouse = 8,
    RightTap = 16, // 0x00000010
    Drag = 32, // 0x00000020
    ManipulationTranslateX = 64, // 0x00000040
    ManipulationTranslateY = 128, // 0x00000080
    ManipulationTranslateRailsX = 256, // 0x00000100
    ManipulationTranslateRailsY = 512, // 0x00000200
    ManipulationRotate = 1024, // 0x00000400
    ManipulationScale = 2048, // 0x00000800
    ManipulationTranslateInertia = 4096, // 0x00001000
    ManipulationRotateInertia = 8192, // 0x00002000
    ManipulationScaleInertia = 16384, // 0x00004000
    CrossSlide = 32768, // 0x00008000
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ManipulationMultipleFingerPanning = 65536, // 0x00010000
  }
}
