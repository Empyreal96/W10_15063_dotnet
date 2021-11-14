// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureVideoProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(564163519, 41966, 20175, 158, 246, 80, 176, 188, 78, 19, 5)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaCaptureVideoProfile))]
  internal interface IMediaCaptureVideoProfile
  {
    string Id { get; }

    string VideoDeviceId { get; }

    IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedPreviewMediaDescription { get; }

    IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedRecordMediaDescription { get; }

    IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedPhotoMediaDescription { get; }

    IVectorView<MediaCaptureVideoProfile> GetConcurrency();
  }
}
