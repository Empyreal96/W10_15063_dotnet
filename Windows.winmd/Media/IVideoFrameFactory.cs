// Decompiled with JetBrains decompiler
// Type: Windows.Media.IVideoFrameFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media
{
  [ExclusiveTo(typeof (VideoFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(21720425, 8744, 19602, 146, 255, 80, 195, 128, 211, 231, 118)]
  internal interface IVideoFrameFactory
  {
    VideoFrame Create(BitmapPixelFormat format, int width, int height);

    VideoFrame CreateWithAlpha(
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);
  }
}
