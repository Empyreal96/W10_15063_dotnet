// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeEmitterDecayModel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IAudioNodeEmitterDecayModelStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class AudioNodeEmitterDecayModel : IAudioNodeEmitterDecayModel
  {
    public extern AudioNodeEmitterDecayKind Kind { [MethodImpl] get; }

    public extern double MinGain { [MethodImpl] get; }

    public extern double MaxGain { [MethodImpl] get; }

    public extern AudioNodeEmitterNaturalDecayModelProperties NaturalProperties { [MethodImpl] get; }

    [MethodImpl]
    public static extern AudioNodeEmitterDecayModel CreateNatural(
      double minGain,
      double maxGain,
      double unityGainDistance,
      double cutoffDistance);

    [MethodImpl]
    public static extern AudioNodeEmitterDecayModel CreateCustom(
      double minGain,
      double maxGain);
  }
}
