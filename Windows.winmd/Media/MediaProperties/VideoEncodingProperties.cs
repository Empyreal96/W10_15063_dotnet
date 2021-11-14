// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.VideoEncodingProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IVideoEncodingPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IVideoEncodingPropertiesStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class VideoEncodingProperties : 
    IVideoEncodingProperties,
    IMediaEncodingProperties,
    IVideoEncodingProperties2,
    IVideoEncodingProperties3,
    IVideoEncodingProperties4
  {
    [MethodImpl]
    public extern VideoEncodingProperties();

    public extern uint Bitrate { [MethodImpl] set; [MethodImpl] get; }

    public extern uint Width { [MethodImpl] set; [MethodImpl] get; }

    public extern uint Height { [MethodImpl] set; [MethodImpl] get; }

    public extern MediaRatio FrameRate { [MethodImpl] get; }

    public extern MediaRatio PixelAspectRatio { [MethodImpl] get; }

    public extern MediaPropertySet Properties { [MethodImpl] get; }

    public extern string Type { [MethodImpl] get; }

    public extern string Subtype { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void SetFormatUserData(byte[] value);

    [MethodImpl]
    public extern void GetFormatUserData(out byte[] value);

    public extern int ProfileId { [MethodImpl] set; [MethodImpl] get; }

    public extern StereoscopicVideoPackingMode StereoscopicVideoPackingMode { [MethodImpl] get; }

    public extern SphericalVideoFrameFormat SphericalVideoFrameFormat { [MethodImpl] get; }

    [MethodImpl]
    public static extern VideoEncodingProperties CreateHevc();

    [MethodImpl]
    public static extern VideoEncodingProperties CreateH264();

    [MethodImpl]
    public static extern VideoEncodingProperties CreateMpeg2();

    [MethodImpl]
    public static extern VideoEncodingProperties CreateUncompressed(
      string subtype,
      uint width,
      uint height);
  }
}
