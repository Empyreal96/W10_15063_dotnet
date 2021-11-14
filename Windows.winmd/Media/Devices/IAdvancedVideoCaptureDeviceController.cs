// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(3731879123, 11158, 17795, 128, 171, 181, 176, 29, 198, 168, 215)]
  [ExclusiveTo(typeof (VideoDeviceController))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdvancedVideoCaptureDeviceController
  {
    void SetDeviceProperty(string propertyId, [Variant] object propertyValue);

    [return: Variant]
    object GetDeviceProperty(string propertyId);
  }
}
