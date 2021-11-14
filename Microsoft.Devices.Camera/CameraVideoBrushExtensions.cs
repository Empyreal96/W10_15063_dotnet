// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.CameraVideoBrushExtensions
// Assembly: Microsoft.Devices.Camera, Version=0.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: EF9A4555-242B-4723-B191-4FF24D598391
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI27EF~1.DLL

using System;
using System.Security;
using System.Windows.Media;
using Windows.Phone.Media.Capture;

namespace Microsoft.Devices
{
  public static class CameraVideoBrushExtensions
  {
    [SecuritySafeCritical]
    public static void SetSource(this VideoBrush brush, Camera camera) => camera.InitializeVideoSession(brush);

    [SecuritySafeCritical]
    public static void SetSource(this VideoBrush brush, object camera)
    {
      switch (camera)
      {
        case ICameraCaptureDevice _:
          string property = ((ICameraCaptureDevice) camera).GetProperty(Camera.videoPortNamePropertyGuid) as string;
          brush.SetExternalVideoPortSource(property);
          break;
        case IMediaCapturePreviewSink _:
          IMediaCapturePreviewSink capturePreviewSink = (IMediaCapturePreviewSink) camera;
          brush.SetExternalVideoPortSource(capturePreviewSink.ConnectionPort);
          break;
        case string _:
          brush.SetExternalVideoPortSource(camera as string);
          break;
        default:
          throw new ArgumentException("The camera parameter did not implement the ICameraCaptureDevice interface.");
      }
    }
  }
}
