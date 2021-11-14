// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaCapture))]
  [Guid(2901377535, 39405, 17989, 150, 94, 25, 37, 207, 198, 56, 52)]
  internal interface IMediaCaptureStatics
  {
    bool IsVideoProfileSupported(string videoDeviceId);

    IVectorView<MediaCaptureVideoProfile> FindAllVideoProfiles(
      string videoDeviceId);

    IVectorView<MediaCaptureVideoProfile> FindConcurrentProfiles(
      string videoDeviceId);

    IVectorView<MediaCaptureVideoProfile> FindKnownVideoProfiles(
      string videoDeviceId,
      KnownVideoProfile name);
  }
}
