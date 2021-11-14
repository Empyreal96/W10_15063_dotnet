// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameIsoSpeedCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(381550433, 28150, 19145, 185, 42, 159, 110, 205, 26, 210, 250)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameIsoSpeedCapabilities))]
  internal interface IFrameIsoSpeedCapabilities
  {
    bool Supported { get; }

    uint Min { get; }

    uint Max { get; }

    uint Step { get; }
  }
}
