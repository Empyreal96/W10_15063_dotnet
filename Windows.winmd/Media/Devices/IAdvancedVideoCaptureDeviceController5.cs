// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (VideoDeviceController))]
  [Guid(860957463, 47563, 18979, 184, 117, 249, 234, 171, 83, 84, 146)]
  internal interface IAdvancedVideoCaptureDeviceController5
  {
    string Id { get; }

    VideoDeviceControllerGetDevicePropertyResult GetDevicePropertyById(
      string propertyId,
      IReference<uint> maxPropertyValueSize);

    VideoDeviceControllerSetDevicePropertyStatus SetDevicePropertyById(
      string propertyId,
      [Variant] object propertyValue);

    VideoDeviceControllerGetDevicePropertyResult GetDevicePropertyByExtendedId(
      byte[] extendedPropertyId,
      IReference<uint> maxPropertyValueSize);

    VideoDeviceControllerSetDevicePropertyStatus SetDevicePropertyByExtendedId(
      byte[] extendedPropertyId,
      byte[] propertyValue);
  }
}
