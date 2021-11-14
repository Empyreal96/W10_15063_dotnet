// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IMediaDeviceControlCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (MediaDeviceControlCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(587225110, 60293, 17378, 185, 43, 130, 64, 213, 238, 112, 236)]
  internal interface IMediaDeviceControlCapabilities
  {
    bool Supported { get; }

    double Min { get; }

    double Max { get; }

    double Step { get; }

    double Default { get; }

    bool AutoModeSupported { get; }
  }
}
