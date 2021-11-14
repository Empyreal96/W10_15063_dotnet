// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.LimiterEffectDefinition
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
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ILimiterEffectDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LimiterEffectDefinition : ILimiterEffectDefinition, IAudioEffectDefinition
  {
    [MethodImpl]
    public extern LimiterEffectDefinition(AudioGraph audioGraph);

    public extern uint Release { [MethodImpl] set; [MethodImpl] get; }

    public extern uint Loudness { [MethodImpl] set; [MethodImpl] get; }

    public extern string ActivatableClassId { [MethodImpl] get; }

    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
