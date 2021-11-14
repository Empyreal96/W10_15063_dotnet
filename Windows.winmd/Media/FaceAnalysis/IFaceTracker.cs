// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.IFaceTracker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.FaceAnalysis
{
  [Guid(1806073228, 43073, 17440, 147, 230, 36, 32, 161, 136, 79, 207)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FaceTracker))]
  internal interface IFaceTracker
  {
    [RemoteAsync]
    IAsyncOperation<IVector<DetectedFace>> ProcessNextFrameAsync(
      VideoFrame videoFrame);

    BitmapSize MinDetectableFaceSize { get; set; }

    BitmapSize MaxDetectableFaceSize { get; set; }
  }
}
