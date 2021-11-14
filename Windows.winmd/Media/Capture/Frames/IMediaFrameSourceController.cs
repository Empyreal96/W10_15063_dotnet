// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSourceController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture.Frames
{
  [Guid(1829201461, 12653, 19343, 183, 182, 238, 176, 74, 140, 101, 37)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaFrameSourceController))]
  internal interface IMediaFrameSourceController
  {
    [RemoteAsync]
    IAsyncOperation<MediaFrameSourceGetPropertyResult> GetPropertyAsync(
      string propertyId);

    [RemoteAsync]
    IAsyncOperation<MediaFrameSourceSetPropertyStatus> SetPropertyAsync(
      string propertyId,
      [Variant] object propertyValue);

    VideoDeviceController VideoDeviceController { get; }
  }
}
