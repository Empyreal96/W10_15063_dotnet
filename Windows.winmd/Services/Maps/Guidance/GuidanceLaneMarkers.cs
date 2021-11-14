// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.GuidanceLaneMarkers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [Flags]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  public enum GuidanceLaneMarkers : uint
  {
    None = 0,
    LightRight = 1,
    Right = 2,
    HardRight = 4,
    Straight = 8,
    UTurnLeft = 16, // 0x00000010
    HardLeft = 32, // 0x00000020
    Left = 64, // 0x00000040
    LightLeft = 128, // 0x00000080
    UTurnRight = 256, // 0x00000100
    Unknown = 4294967295, // 0xFFFFFFFF
  }
}
