// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterDecayModelStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(3346562216, 61816, 17967, 188, 129, 141, 213, 203, 229, 218, 232)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AudioNodeEmitterDecayModel))]
  internal interface IAudioNodeEmitterDecayModelStatics
  {
    AudioNodeEmitterDecayModel CreateNatural(
      double minGain,
      double maxGain,
      double unityGainDistance,
      double cutoffDistance);

    AudioNodeEmitterDecayModel CreateCustom(
      double minGain,
      double maxGain);
  }
}
