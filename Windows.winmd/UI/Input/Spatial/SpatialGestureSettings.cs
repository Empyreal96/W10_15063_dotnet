// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialGestureSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum SpatialGestureSettings : uint
  {
    None = 0,
    Tap = 1,
    DoubleTap = 2,
    Hold = 4,
    ManipulationTranslate = 8,
    NavigationX = 16, // 0x00000010
    NavigationY = 32, // 0x00000020
    NavigationZ = 64, // 0x00000040
    NavigationRailsX = 128, // 0x00000080
    NavigationRailsY = 256, // 0x00000100
    NavigationRailsZ = 512, // 0x00000200
  }
}
