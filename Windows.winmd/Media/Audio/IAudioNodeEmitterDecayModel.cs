// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterDecayModel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioNodeEmitterDecayModel))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(488463095, 3411, 20393, 189, 132, 213, 129, 106, 134, 243, 255)]
  internal interface IAudioNodeEmitterDecayModel
  {
    AudioNodeEmitterDecayKind Kind { get; }

    double MinGain { get; }

    double MaxGain { get; }

    AudioNodeEmitterNaturalDecayModelProperties NaturalProperties { get; }
  }
}
