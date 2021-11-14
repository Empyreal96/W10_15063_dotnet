// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IFaceDetectionEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Core
{
  [Guid(1138532481, 47176, 20275, 183, 2, 31, 210, 98, 79, 176, 22)]
  [ExclusiveTo(typeof (FaceDetectionEffectDefinition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFaceDetectionEffectDefinition : IVideoEffectDefinition
  {
    FaceDetectionMode DetectionMode { set; get; }

    bool SynchronousDetectionEnabled { set; get; }
  }
}
