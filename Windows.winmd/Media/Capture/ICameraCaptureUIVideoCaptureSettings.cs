// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICameraCaptureUIVideoCaptureSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1693003039, 41613, 16986, 184, 79, 229, 104, 51, 95, 242, 78)]
  [ExclusiveTo(typeof (CameraCaptureUIVideoCaptureSettings))]
  internal interface ICameraCaptureUIVideoCaptureSettings
  {
    CameraCaptureUIVideoFormat Format { get; set; }

    CameraCaptureUIMaxVideoResolution MaxResolution { get; set; }

    float MaxDurationInSeconds { get; set; }

    bool AllowTrimming { get; set; }
  }
}
