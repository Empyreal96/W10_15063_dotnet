// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionVideoFrameAllocatorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.Perception.Provider
{
  [Guid(442020065, 59674, 18462, 184, 118, 168, 158, 43, 188, 107, 51)]
  [ExclusiveTo(typeof (PerceptionVideoFrameAllocator))]
  [Deprecated("PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionVideoFrameAllocatorFactory
  {
    [Deprecated("PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionVideoFrameAllocator Create(
      uint maxOutstandingFrameCountForWrite,
      BitmapPixelFormat format,
      Size resolution,
      BitmapAlphaMode alpha);
  }
}
