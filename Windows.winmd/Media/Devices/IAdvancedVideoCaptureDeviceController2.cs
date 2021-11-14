// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (VideoDeviceController))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2344177551, 61722, 17371, 180, 2, 17, 147, 11, 128, 174, 86)]
  internal interface IAdvancedVideoCaptureDeviceController2
  {
    LowLagPhotoSequenceControl LowLagPhotoSequence { get; }

    LowLagPhotoControl LowLagPhoto { get; }

    SceneModeControl SceneModeControl { get; }

    TorchControl TorchControl { get; }

    FlashControl FlashControl { get; }

    WhiteBalanceControl WhiteBalanceControl { get; }

    ExposureControl ExposureControl { get; }

    FocusControl FocusControl { get; }

    ExposureCompensationControl ExposureCompensationControl { get; }

    IsoSpeedControl IsoSpeedControl { get; }

    RegionsOfInterestControl RegionsOfInterestControl { get; }

    CaptureUse PrimaryUse { get; set; }
  }
}
