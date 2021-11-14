// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioNodeEmitter))]
  [Guid(4257761434, 27350, 19684, 183, 247, 169, 147, 112, 223, 126, 233)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAudioNodeEmitterFactory
  {
    AudioNodeEmitter CreateAudioNodeEmitter(
      AudioNodeEmitterShape shape,
      AudioNodeEmitterDecayModel decayModel,
      AudioNodeEmitterSettings settings);
  }
}
