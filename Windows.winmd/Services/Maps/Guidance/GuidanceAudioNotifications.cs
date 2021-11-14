// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.GuidanceAudioNotifications
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [Flags]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [WebHostHidden]
  public enum GuidanceAudioNotifications : uint
  {
    None = 0,
    Maneuver = 1,
    Route = 2,
    Gps = 4,
    SpeedLimit = 8,
    Traffic = 16, // 0x00000010
    TrafficCamera = 32, // 0x00000020
  }
}
