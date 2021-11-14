// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IFaceDetectionEffectFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.FaceAnalysis;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (FaceDetectionEffectFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2326825363, 24008, 17531, 162, 71, 82, 112, 189, 128, 46, 206)]
  internal interface IFaceDetectionEffectFrame : IMediaFrame, IClosable
  {
    IVectorView<DetectedFace> DetectedFaces { get; }
  }
}
