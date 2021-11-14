// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.EqualizerEffectDefinition
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IEqualizerEffectDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class EqualizerEffectDefinition : IEqualizerEffectDefinition, IAudioEffectDefinition
  {
    [MethodImpl]
    public extern EqualizerEffectDefinition(AudioGraph audioGraph);

    public extern IVectorView<EqualizerBand> Bands { [MethodImpl] get; }

    public extern string ActivatableClassId { [MethodImpl] get; }

    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
