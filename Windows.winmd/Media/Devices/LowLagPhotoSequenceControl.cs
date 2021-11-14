// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.LowLagPhotoSequenceControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class LowLagPhotoSequenceControl : ILowLagPhotoSequenceControl
  {
    public extern bool Supported { [MethodImpl] get; }

    public extern uint MaxPastPhotos { [MethodImpl] get; }

    public extern float MaxPhotosPerSecond { [MethodImpl] get; }

    public extern uint PastPhotoLimit { [MethodImpl] get; [MethodImpl] set; }

    public extern float PhotosPerSecondLimit { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern MediaRatio GetHighestConcurrentFrameRate(
      IMediaEncodingProperties captureProperties);

    [MethodImpl]
    public extern MediaRatio GetCurrentFrameRate();

    public extern bool ThumbnailEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaThumbnailFormat ThumbnailFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern uint DesiredThumbnailSize { [MethodImpl] get; [MethodImpl] set; }

    public extern uint HardwareAcceleratedThumbnailSupported { [MethodImpl] get; }
  }
}
