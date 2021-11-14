// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ReverbEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Audio
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IReverbEffectDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ReverbEffectDefinition : IReverbEffectDefinition, IAudioEffectDefinition
  {
    [MethodImpl]
    public extern ReverbEffectDefinition(AudioGraph audioGraph);

    public extern double WetDryMix { [MethodImpl] set; [MethodImpl] get; }

    public extern uint ReflectionsDelay { [MethodImpl] set; [MethodImpl] get; }

    public extern byte ReverbDelay { [MethodImpl] set; [MethodImpl] get; }

    public extern byte RearDelay { [MethodImpl] set; [MethodImpl] get; }

    public extern byte PositionLeft { [MethodImpl] set; [MethodImpl] get; }

    public extern byte PositionRight { [MethodImpl] set; [MethodImpl] get; }

    public extern byte PositionMatrixLeft { [MethodImpl] set; [MethodImpl] get; }

    public extern byte PositionMatrixRight { [MethodImpl] set; [MethodImpl] get; }

    public extern byte EarlyDiffusion { [MethodImpl] set; [MethodImpl] get; }

    public extern byte LateDiffusion { [MethodImpl] set; [MethodImpl] get; }

    public extern byte LowEQGain { [MethodImpl] set; [MethodImpl] get; }

    public extern byte LowEQCutoff { [MethodImpl] set; [MethodImpl] get; }

    public extern byte HighEQGain { [MethodImpl] set; [MethodImpl] get; }

    public extern byte HighEQCutoff { [MethodImpl] set; [MethodImpl] get; }

    public extern double RoomFilterFreq { [MethodImpl] set; [MethodImpl] get; }

    public extern double RoomFilterMain { [MethodImpl] set; [MethodImpl] get; }

    public extern double RoomFilterHF { [MethodImpl] set; [MethodImpl] get; }

    public extern double ReflectionsGain { [MethodImpl] set; [MethodImpl] get; }

    public extern double ReverbGain { [MethodImpl] set; [MethodImpl] get; }

    public extern double DecayTime { [MethodImpl] set; [MethodImpl] get; }

    public extern double Density { [MethodImpl] set; [MethodImpl] get; }

    public extern double RoomSize { [MethodImpl] set; [MethodImpl] get; }

    public extern bool DisableLateField { [MethodImpl] set; [MethodImpl] get; }

    public extern string ActivatableClassId { [MethodImpl] get; }

    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
