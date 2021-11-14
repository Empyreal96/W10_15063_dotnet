// Decompiled with JetBrains decompiler
// Type: Windows.Media.IVideoFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Imaging;

namespace Windows.Media
{
  [Guid(213935653, 37116, 19602, 189, 149, 125, 237, 33, 129, 157, 28)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoFrame))]
  internal interface IVideoFrame : IMediaFrame, IClosable
  {
    SoftwareBitmap SoftwareBitmap { get; }

    [RemoteAsync]
    IAsyncAction CopyToAsync(VideoFrame frame);

    IDirect3DSurface Direct3DSurface { get; }
  }
}
