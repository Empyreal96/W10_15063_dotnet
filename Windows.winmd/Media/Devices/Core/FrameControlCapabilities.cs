// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameControlCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FrameControlCapabilities : 
    IFrameControlCapabilities,
    IFrameControlCapabilities2
  {
    public extern FrameExposureCapabilities Exposure { [MethodImpl] get; }

    public extern FrameExposureCompensationCapabilities ExposureCompensation { [MethodImpl] get; }

    public extern FrameIsoSpeedCapabilities IsoSpeed { [MethodImpl] get; }

    public extern FrameFocusCapabilities Focus { [MethodImpl] get; }

    public extern bool PhotoConfirmationSupported { [MethodImpl] get; }

    public extern FrameFlashCapabilities Flash { [MethodImpl] get; }
  }
}
