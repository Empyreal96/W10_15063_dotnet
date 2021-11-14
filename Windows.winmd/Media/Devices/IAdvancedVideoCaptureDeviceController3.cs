// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoDeviceController))]
  [Guid(2844495668, 60941, 18188, 185, 240, 66, 41, 196, 187, 208, 137)]
  internal interface IAdvancedVideoCaptureDeviceController3
  {
    VariablePhotoSequenceController VariablePhotoSequenceController { get; }

    PhotoConfirmationControl PhotoConfirmationControl { get; }

    ZoomControl ZoomControl { get; }
  }
}
