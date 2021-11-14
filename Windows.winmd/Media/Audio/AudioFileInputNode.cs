// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioFileInputNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;
using Windows.Storage;

namespace Windows.Media.Audio
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AudioFileInputNode : 
    IAudioFileInputNode,
    IAudioInputNode,
    IAudioNode,
    IClosable,
    IAudioInputNode2
  {
    public extern double PlaybackSpeedFactor { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan Position { [MethodImpl] get; }

    [MethodImpl]
    public extern void Seek(TimeSpan position);

    public extern IReference<TimeSpan> StartTime { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> EndTime { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> LoopCount { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan Duration { [MethodImpl] get; }

    public extern StorageFile SourceFile { [MethodImpl] get; }

    public extern event TypedEventHandler<AudioFileInputNode, object> FileCompleted;

    public extern IVectorView<AudioGraphConnection> OutgoingConnections { [MethodImpl] get; }

    [Overload("AddOutgoingConnection")]
    [MethodImpl]
    public extern void AddOutgoingConnection(IAudioNode destination);

    [Overload("AddOutgoingConnectionWithGain")]
    [MethodImpl]
    public extern void AddOutgoingConnection(IAudioNode destination, double gain);

    [MethodImpl]
    public extern void RemoveOutgoingConnection(IAudioNode destination);

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

    public extern AudioNodeEmitter Emitter { [MethodImpl] get; }
  }
}
