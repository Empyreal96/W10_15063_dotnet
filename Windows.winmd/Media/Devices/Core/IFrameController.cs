// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3244579289, 47855, 16466, 145, 119, 72, 175, 242, 175, 117, 34)]
  [ExclusiveTo(typeof (FrameController))]
  internal interface IFrameController
  {
    FrameExposureControl ExposureControl { get; }

    FrameExposureCompensationControl ExposureCompensationControl { get; }

    FrameIsoSpeedControl IsoSpeedControl { get; }

    FrameFocusControl FocusControl { get; }

    IReference<bool> PhotoConfirmationEnabled { get; set; }
  }
}
