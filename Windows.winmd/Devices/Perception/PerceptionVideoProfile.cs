// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionVideoProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.Perception
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PerceptionVideoProfile : IPerceptionVideoProfile
  {
    public extern BitmapPixelFormat BitmapPixelFormat { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern BitmapAlphaMode BitmapAlphaMode { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern int Width { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern int Height { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern TimeSpan FrameDuration { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool IsEqual(PerceptionVideoProfile other);
  }
}
