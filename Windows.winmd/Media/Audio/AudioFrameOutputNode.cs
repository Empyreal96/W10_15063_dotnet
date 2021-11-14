// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioFrameOutputNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;

namespace Windows.Media.Audio
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AudioFrameOutputNode : IAudioFrameOutputNode, IAudioNode, IClosable
  {
    [MethodImpl]
    public extern AudioFrame GetFrame();

    public extern IVector<IAudioEffectDefinition> EffectDefinitions { [MethodImpl] get; }

    public extern double OutgoingGain { [MethodImpl] set; [MethodImpl] get; }

    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; }

    public extern bool ConsumeInput { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void Reset();

    [MethodImpl]
    public extern void DisableEffectsByDefinition(IAudioEffectDefinition definition);

    [MethodImpl]
    public extern void EnableEffectsByDefinition(IAudioEffectDefinition definition);

    [MethodImpl]
    public extern void Close();
  }
}
