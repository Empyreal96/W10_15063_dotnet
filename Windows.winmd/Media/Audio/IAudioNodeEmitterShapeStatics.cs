// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterShapeStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioNodeEmitterShape))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1471883121, 65445, 19334, 167, 121, 226, 100, 174, 185, 20, 95)]
  internal interface IAudioNodeEmitterShapeStatics
  {
    AudioNodeEmitterShape CreateCone(
      double innerAngle,
      double outerAngle,
      double outerAngleGain);

    AudioNodeEmitterShape CreateOmnidirectional();
  }
}
