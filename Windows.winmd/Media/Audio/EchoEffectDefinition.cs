// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.EchoEffectDefinition
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IEchoEffectDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EchoEffectDefinition : IEchoEffectDefinition, IAudioEffectDefinition
  {
    [MethodImpl]
    public extern EchoEffectDefinition(AudioGraph audioGraph);

    public extern double WetDryMix { [MethodImpl] set; [MethodImpl] get; }

    public extern double Feedback { [MethodImpl] set; [MethodImpl] get; }

    public extern double Delay { [MethodImpl] set; [MethodImpl] get; }

    public extern string ActivatableClassId { [MethodImpl] get; }

    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
