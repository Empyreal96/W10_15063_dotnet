// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameControlCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(2835328608, 20126, 17271, 167, 137, 226, 76, 74, 231, 229, 68)]
  [ExclusiveTo(typeof (FrameControlCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameControlCapabilities
  {
    FrameExposureCapabilities Exposure { get; }

    FrameExposureCompensationCapabilities ExposureCompensation { get; }

    FrameIsoSpeedCapabilities IsoSpeed { get; }

    FrameFocusCapabilities Focus { get; }

    bool PhotoConfirmationSupported { get; }
  }
}
