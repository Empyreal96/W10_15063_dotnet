// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IVideoEncodingProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1995336858, 14274, 20266, 136, 10, 18, 130, 187, 180, 55, 61)]
  [ExclusiveTo(typeof (VideoEncodingProperties))]
  internal interface IVideoEncodingProperties : IMediaEncodingProperties
  {
    uint Bitrate { set; get; }

    uint Width { set; get; }

    uint Height { set; get; }

    MediaRatio FrameRate { get; }

    MediaRatio PixelAspectRatio { get; }
  }
}
