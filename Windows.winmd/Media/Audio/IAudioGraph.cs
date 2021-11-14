// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraph
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;

namespace Windows.Media.Audio
{
  [Guid(450129645, 58508, 19988, 150, 96, 44, 79, 131, 233, 205, 216)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioGraph))]
  internal interface IAudioGraph : IClosable
  {
    [Overload("CreateFrameInputNode")]
    AudioFrameInputNode CreateFrameInputNode();

    [Overload("CreateFrameInputNodeWithFormat")]
    AudioFrameInputNode CreateFrameInputNode(
      AudioEncodingProperties encodingProperties);

    [RemoteAsync]
    [Overload("CreateDeviceInputNodeAsync")]
    IAsyncOperation<CreateAudioDeviceInputNodeResult> CreateDeviceInputNodeAsync(
      MediaCategory category);

    [Overload("CreateDeviceInputNodeWithFormatAsync")]
    [RemoteAsync]
    IAsyncOperation<CreateAudioDeviceInputNodeResult> CreateDeviceInputNodeAsync(
      MediaCategory category,
      AudioEncodingProperties encodingProperties);

    [Overload("CreateDeviceInputNodeWithFormatOnDeviceAsync")]
    [RemoteAsync]
    IAsyncOperation<CreateAudioDeviceInputNodeResult> CreateDeviceInputNodeAsync(
      MediaCategory category,
      AudioEncodingProperties encodingProperties,
      DeviceInformation device);

    [Overload("CreateFrameOutputNode")]
    AudioFrameOutputNode CreateFrameOutputNode();

    [Overload("CreateFrameOutputNodeWithFormat")]
    AudioFrameOutputNode CreateFrameOutputNode(
      AudioEncodingProperties encodingProperties);

    [RemoteAsync]
    IAsyncOperation<CreateAudioDeviceOutputNodeResult> CreateDeviceOutputNodeAsync();

    [RemoteAsync]
    IAsyncOperation<CreateAudioFileInputNodeResult> CreateFileInputNodeAsync(
      IStorageFile file);

    [Overload("CreateFileOutputNodeAsync")]
    [RemoteAsync]
    IAsyncOperation<CreateAudioFileOutputNodeResult> CreateFileOutputNodeAsync(
      IStorageFile file);

    [Overload("CreateFileOutputNodeWithFileProfileAsync")]
    [RemoteAsync]
    IAsyncOperation<CreateAudioFileOutputNodeResult> CreateFileOutputNodeAsync(
      IStorageFile file,
      MediaEncodingProfile fileEncodingProfile);

    [Overload("CreateSubmixNode")]
    AudioSubmixNode CreateSubmixNode();

    [Overload("CreateSubmixNodeWithFormat")]
    AudioSubmixNode CreateSubmixNode(AudioEncodingProperties encodingProperties);

    void Start();

    void Stop();

    void ResetAllNodes();

    event TypedEventHandler<AudioGraph, object> QuantumStarted;

    event TypedEventHandler<AudioGraph, object> QuantumProcessed;

    event TypedEventHandler<AudioGraph, AudioGraphUnrecoverableErrorOccurredEventArgs> UnrecoverableErrorOccurred;

    ulong CompletedQuantumCount { get; }

    AudioEncodingProperties EncodingProperties { get; }

    int LatencyInSamples { get; }

    DeviceInformation PrimaryRenderDevice { get; }

    AudioProcessing RenderDeviceAudioProcessing { get; }

    int SamplesPerQuantum { get; }
  }
}
