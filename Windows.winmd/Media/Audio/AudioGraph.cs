// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioGraph
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;

namespace Windows.Media.Audio
{
  [Static(typeof (IAudioGraphStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AudioGraph : IAudioGraph, IClosable, IAudioGraph2
  {
    [Overload("CreateFrameInputNode")]
    [MethodImpl]
    public extern AudioFrameInputNode CreateFrameInputNode();

    [Overload("CreateFrameInputNodeWithFormat")]
    [MethodImpl]
    public extern AudioFrameInputNode CreateFrameInputNode(
      AudioEncodingProperties encodingProperties);

    [Overload("CreateDeviceInputNodeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CreateAudioDeviceInputNodeResult> CreateDeviceInputNodeAsync(
      MediaCategory category);

    [Overload("CreateDeviceInputNodeWithFormatAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CreateAudioDeviceInputNodeResult> CreateDeviceInputNodeAsync(
      MediaCategory category,
      AudioEncodingProperties encodingProperties);

    [RemoteAsync]
    [Overload("CreateDeviceInputNodeWithFormatOnDeviceAsync")]
    [MethodImpl]
    public extern IAsyncOperation<CreateAudioDeviceInputNodeResult> CreateDeviceInputNodeAsync(
      MediaCategory category,
      AudioEncodingProperties encodingProperties,
      DeviceInformation device);

    [Overload("CreateFrameOutputNode")]
    [MethodImpl]
    public extern AudioFrameOutputNode CreateFrameOutputNode();

    [Overload("CreateFrameOutputNodeWithFormat")]
    [MethodImpl]
    public extern AudioFrameOutputNode CreateFrameOutputNode(
      AudioEncodingProperties encodingProperties);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CreateAudioDeviceOutputNodeResult> CreateDeviceOutputNodeAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CreateAudioFileInputNodeResult> CreateFileInputNodeAsync(
      IStorageFile file);

    [RemoteAsync]
    [Overload("CreateFileOutputNodeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<CreateAudioFileOutputNodeResult> CreateFileOutputNodeAsync(
      IStorageFile file);

    [Overload("CreateFileOutputNodeWithFileProfileAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CreateAudioFileOutputNodeResult> CreateFileOutputNodeAsync(
      IStorageFile file,
      MediaEncodingProfile fileEncodingProfile);

    [Overload("CreateSubmixNode")]
    [MethodImpl]
    public extern AudioSubmixNode CreateSubmixNode();

    [Overload("CreateSubmixNodeWithFormat")]
    [MethodImpl]
    public extern AudioSubmixNode CreateSubmixNode(
      AudioEncodingProperties encodingProperties);

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void ResetAllNodes();

    public extern event TypedEventHandler<AudioGraph, object> QuantumStarted;

    public extern event TypedEventHandler<AudioGraph, object> QuantumProcessed;

    public extern event TypedEventHandler<AudioGraph, AudioGraphUnrecoverableErrorOccurredEventArgs> UnrecoverableErrorOccurred;

    public extern ulong CompletedQuantumCount { [MethodImpl] get; }

    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; }

    public extern int LatencyInSamples { [MethodImpl] get; }

    public extern DeviceInformation PrimaryRenderDevice { [MethodImpl] get; }

    public extern AudioProcessing RenderDeviceAudioProcessing { [MethodImpl] get; }

    public extern int SamplesPerQuantum { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    [Overload("CreateFrameInputNodeWithFormatAndEmitter")]
    [MethodImpl]
    public extern AudioFrameInputNode CreateFrameInputNode(
      AudioEncodingProperties encodingProperties,
      AudioNodeEmitter emitter);

    [Overload("CreateDeviceInputNodeWithFormatAndEmitterOnDeviceAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CreateAudioDeviceInputNodeResult> CreateDeviceInputNodeAsync(
      MediaCategory category,
      AudioEncodingProperties encodingProperties,
      DeviceInformation device,
      AudioNodeEmitter emitter);

    [RemoteAsync]
    [Overload("CreateFileInputNodeWithEmitterAsync")]
    [MethodImpl]
    public extern IAsyncOperation<CreateAudioFileInputNodeResult> CreateFileInputNodeAsync(
      IStorageFile file,
      AudioNodeEmitter emitter);

    [Overload("CreateSubmixNodeWithFormatAndEmitter")]
    [MethodImpl]
    public extern AudioSubmixNode CreateSubmixNode(
      AudioEncodingProperties encodingProperties,
      AudioNodeEmitter emitter);

    [MethodImpl]
    public extern AudioGraphBatchUpdater CreateBatchUpdater();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CreateAudioGraphResult> CreateAsync(
      AudioGraphSettings settings);
  }
}
