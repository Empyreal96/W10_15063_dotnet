// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.FaceTracker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.FaceAnalysis
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IFaceTrackerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FaceTracker : IFaceTracker
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVector<DetectedFace>> ProcessNextFrameAsync(
      VideoFrame videoFrame);

    public extern BitmapSize MinDetectableFaceSize { [MethodImpl] get; [MethodImpl] set; }

    public extern BitmapSize MaxDetectableFaceSize { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FaceTracker> CreateAsync();

    [MethodImpl]
    public static extern IVectorView<BitmapPixelFormat> GetSupportedBitmapPixelFormats();

    [MethodImpl]
    public static extern bool IsBitmapPixelFormatSupported(BitmapPixelFormat bitmapPixelFormat);

    public static extern bool IsSupported { [MethodImpl] get; }
  }
}
