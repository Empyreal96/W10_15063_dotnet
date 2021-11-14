// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.LowLagPhotoControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class LowLagPhotoControl : ILowLagPhotoControl
  {
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
