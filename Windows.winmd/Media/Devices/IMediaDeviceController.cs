// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IMediaDeviceController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4143510990, 8346, 18683, 134, 252, 212, 69, 120, 243, 23, 230)]
  public interface IMediaDeviceController
  {
    IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties(
      MediaStreamType mediaStreamType);

    IMediaEncodingProperties GetMediaStreamProperties(
      MediaStreamType mediaStreamType);

    IAsyncAction SetMediaStreamPropertiesAsync(
      MediaStreamType mediaStreamType,
      IMediaEncodingProperties mediaEncodingProperties);
  }
}
