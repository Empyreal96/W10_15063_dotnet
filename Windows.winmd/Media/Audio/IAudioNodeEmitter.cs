// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(913741597, 34826, 18360, 173, 247, 19, 35, 169, 217, 101, 190)]
  [ExclusiveTo(typeof (AudioNodeEmitter))]
  internal interface IAudioNodeEmitter
  {
    Vector3 Position { get; set; }

    Vector3 Direction { get; set; }

    AudioNodeEmitterShape Shape { get; }

    AudioNodeEmitterDecayModel DecayModel { get; }

    double Gain { get; set; }

    double DistanceScale { get; set; }

    double DopplerScale { get; set; }

    Vector3 DopplerVelocity { get; set; }

    bool IsDopplerDisabled { get; }
  }
}
