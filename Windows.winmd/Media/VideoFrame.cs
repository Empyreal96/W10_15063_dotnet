// Decompiled with JetBrains decompiler
// Type: Windows.Media.VideoFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Imaging;

namespace Windows.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IVideoFrameFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [GCPressure(amount = GCPressureAmount.High)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VideoFrame : IVideoFrame, IMediaFrame, IClosable
  {
    [MethodImpl]
    public extern VideoFrame(BitmapPixelFormat format, int width, int height);

    [MethodImpl]
    public extern VideoFrame(
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);

    public extern SoftwareBitmap SoftwareBitmap { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CopyToAsync(VideoFrame frame);

    public extern IDirect3DSurface Direct3DSurface { [MethodImpl] get; }

    public extern string Type { [MethodImpl] get; }

    public extern bool IsReadOnly { [MethodImpl] get; }

    public extern IReference<TimeSpan> RelativeTime { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<TimeSpan> SystemRelativeTime { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<TimeSpan> Duration { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsDiscontinuous { [MethodImpl] set; [MethodImpl] get; }

    public extern IPropertySet ExtendedProperties { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
