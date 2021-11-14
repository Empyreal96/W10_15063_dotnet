// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4110591287, 19639, 19752, 149, 237, 79, 159, 1, 46, 5, 24)]
  internal interface IMediaCaptureInitializationSettings4
  {
    MediaCaptureVideoProfile VideoProfile { get; set; }

    MediaCaptureVideoProfileMediaDescription PreviewMediaDescription { get; set; }

    MediaCaptureVideoProfileMediaDescription RecordMediaDescription { get; set; }

    MediaCaptureVideoProfileMediaDescription PhotoMediaDescription { get; set; }
  }
}
