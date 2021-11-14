// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameIsoSpeedControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameIsoSpeedControl))]
  [Guid(436465645, 30826, 19573, 165, 87, 122, 185, 168, 95, 88, 140)]
  internal interface IFrameIsoSpeedControl
  {
    bool Auto { get; set; }

    IReference<uint> Value { get; set; }
  }
}
