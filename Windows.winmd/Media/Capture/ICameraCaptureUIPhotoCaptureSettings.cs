// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICameraCaptureUIPhotoCaptureSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CameraCaptureUIPhotoCaptureSettings))]
  [Guid(3119890071, 13426, 18088, 138, 158, 4, 206, 66, 204, 201, 125)]
  internal interface ICameraCaptureUIPhotoCaptureSettings
  {
    CameraCaptureUIPhotoFormat Format { get; set; }

    CameraCaptureUIMaxPhotoResolution MaxResolution { get; set; }

    Size CroppedSizeInPixels { get; set; }

    Size CroppedAspectRatio { get; set; }

    bool AllowCropping { get; set; }
  }
}
