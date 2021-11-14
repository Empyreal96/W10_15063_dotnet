// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionVideoProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.Perception
{
  [Guid(1970683555, 282, 18190, 130, 37, 111, 5, 173, 226, 86, 72)]
  [ExclusiveTo(typeof (PerceptionVideoProfile))]
  [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionVideoProfile
  {
    BitmapPixelFormat BitmapPixelFormat { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    BitmapAlphaMode BitmapAlphaMode { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    int Width { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    int Height { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    TimeSpan FrameDuration { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    bool IsEqual(PerceptionVideoProfile other);
  }
}
