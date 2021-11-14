// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(3936337839, 54129, 16835, 154, 23, 130, 74, 135, 235, 223, 210)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoDeviceController))]
  internal interface IAdvancedVideoCaptureDeviceController4
  {
    ExposurePriorityVideoControl ExposurePriorityVideoControl { get; }

    MediaCaptureOptimization DesiredOptimization { get; set; }

    HdrVideoControl HdrVideoControl { get; }

    OpticalImageStabilizationControl OpticalImageStabilizationControl { get; }

    AdvancedPhotoControl AdvancedPhotoControl { get; }
  }
}
