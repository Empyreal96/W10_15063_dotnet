// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationModes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Flags]
  public enum ManipulationModes : uint
  {
    None = 0,
    TranslateX = 1,
    TranslateY = 2,
    TranslateRailsX = 4,
    TranslateRailsY = 8,
    Rotate = 16, // 0x00000010
    Scale = 32, // 0x00000020
    TranslateInertia = 64, // 0x00000040
    RotateInertia = 128, // 0x00000080
    ScaleInertia = 256, // 0x00000100
    All = 65535, // 0x0000FFFF
    System = 65536, // 0x00010000
  }
}
