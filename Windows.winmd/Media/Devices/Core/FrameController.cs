// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FrameController : IFrameController, IFrameController2
  {
    [MethodImpl]
    public extern FrameController();

    public extern FrameExposureControl ExposureControl { [MethodImpl] get; }

    public extern FrameExposureCompensationControl ExposureCompensationControl { [MethodImpl] get; }

    public extern FrameIsoSpeedControl IsoSpeedControl { [MethodImpl] get; }

    public extern FrameFocusControl FocusControl { [MethodImpl] get; }

    public extern IReference<bool> PhotoConfirmationEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern FrameFlashControl FlashControl { [MethodImpl] get; }
  }
}
