// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraph2
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
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1313618901, 20417, 17910, 169, 71, 60, 211, 143, 79, 216, 57)]
  [ExclusiveTo(typeof (AudioGraph))]
  internal interface IAudioGraph2 : IClosable, IAudioGraph
  {
    [Overload("CreateFrameInputNodeWithFormatAndEmitter")]
    AudioFrameInputNode CreateFrameInputNode(
      AudioEncodingProperties encodingProperties,
      AudioNodeEmitter emitter);

    [Overload("CreateDeviceInputNodeWithFormatAndEmitterOnDeviceAsync")]
    [RemoteAsync]
    IAsyncOperation<CreateAudioDeviceInputNodeResult> CreateDeviceInputNodeAsync(
      MediaCategory category,
      AudioEncodingProperties encodingProperties,
      DeviceInformation device,
      AudioNodeEmitter emitter);

    [Overload("CreateFileInputNodeWithEmitterAsync")]
    [RemoteAsync]
    IAsyncOperation<CreateAudioFileInputNodeResult> CreateFileInputNodeAsync(
      IStorageFile file,
      AudioNodeEmitter emitter);

    [Overload("CreateSubmixNodeWithFormatAndEmitter")]
    AudioSubmixNode CreateSubmixNode(
      AudioEncodingProperties encodingProperties,
      AudioNodeEmitter emitter);

    AudioGraphBatchUpdater CreateBatchUpdater();
  }
}
