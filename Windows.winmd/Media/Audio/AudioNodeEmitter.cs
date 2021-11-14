// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeEmitter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Audio
{
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IAudioNodeEmitterFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class AudioNodeEmitter : IAudioNodeEmitter, IAudioNodeEmitter2
  {
    [MethodImpl]
    public extern AudioNodeEmitter(
      AudioNodeEmitterShape shape,
      AudioNodeEmitterDecayModel decayModel,
      AudioNodeEmitterSettings settings);

    [MethodImpl]
    public extern AudioNodeEmitter();

    public extern Vector3 Position { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 Direction { [MethodImpl] get; [MethodImpl] set; }

    public extern AudioNodeEmitterShape Shape { [MethodImpl] get; }

    public extern AudioNodeEmitterDecayModel DecayModel { [MethodImpl] get; }

    public extern double Gain { [MethodImpl] get; [MethodImpl] set; }

    public extern double DistanceScale { [MethodImpl] get; [MethodImpl] set; }

    public extern double DopplerScale { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 DopplerVelocity { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDopplerDisabled { [MethodImpl] get; }

    public extern SpatialAudioModel SpatialAudioModel { [MethodImpl] get; [MethodImpl] set; }
  }
}
