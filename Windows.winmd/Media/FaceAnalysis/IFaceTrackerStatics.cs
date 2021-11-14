// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.IFaceTrackerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.FaceAnalysis
{
  [ExclusiveTo(typeof (FaceTracker))]
  [Guid(3915551128, 6145, 16293, 147, 46, 49, 215, 103, 175, 108, 77)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFaceTrackerStatics
  {
    [RemoteAsync]
    IAsyncOperation<FaceTracker> CreateAsync();

    IVectorView<BitmapPixelFormat> GetSupportedBitmapPixelFormats();

    bool IsBitmapPixelFormatSupported(BitmapPixelFormat bitmapPixelFormat);

    bool IsSupported { get; }
  }
}
