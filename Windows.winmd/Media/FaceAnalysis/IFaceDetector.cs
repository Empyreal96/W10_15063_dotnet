// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.IFaceDetector
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
  [Guid(381055708, 65135, 12567, 141, 149, 195, 240, 77, 81, 99, 12)]
  internal interface IFaceDetector
  {
    [RemoteAsync]
    [Overload("DetectFacesAsync")]
    IAsyncOperation<IVector<DetectedFace>> DetectFacesAsync(
      SoftwareBitmap image);

    [Overload("DetectFacesWithSearchAreaAsync")]
    [RemoteAsync]
    IAsyncOperation<IVector<DetectedFace>> DetectFacesAsync(
      SoftwareBitmap image,
      BitmapBounds searchArea);

    BitmapSize MinDetectableFaceSize { get; set; }

    BitmapSize MaxDetectableFaceSize { get; set; }
  }
}
