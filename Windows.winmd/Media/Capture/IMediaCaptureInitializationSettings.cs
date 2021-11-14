// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  [Guid(2541927024, 60005, 18688, 147, 86, 140, 168, 135, 114, 104, 132)]
  internal interface IMediaCaptureInitializationSettings
  {
    string AudioDeviceId { set; get; }

    string VideoDeviceId { set; get; }

    StreamingCaptureMode StreamingCaptureMode { set; get; }

    PhotoCaptureSource PhotoCaptureSource { set; get; }
  }
}
