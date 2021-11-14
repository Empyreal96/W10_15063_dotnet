// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.IFaceDetectorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.FaceAnalysis
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FaceDetector))]
  [Guid(3154390375, 36935, 13302, 136, 27, 103, 70, 193, 178, 24, 184)]
  internal interface IFaceDetectorStatics
  {
    [RemoteAsync]
    IAsyncOperation<FaceDetector> CreateAsync();

    IVectorView<BitmapPixelFormat> GetSupportedBitmapPixelFormats();

    bool IsBitmapPixelFormatSupported(BitmapPixelFormat bitmapPixelFormat);

    bool IsSupported { get; }
  }
}
