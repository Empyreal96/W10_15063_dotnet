// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioFrameInputNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioFrameInputNode))]
  [Guid(28468935, 64918, 20469, 163, 197, 210, 122, 155, 244, 66, 55)]
  internal interface IAudioFrameInputNode : IAudioInputNode, IAudioNode, IClosable
  {
    double PlaybackSpeedFactor { set; get; }

    void AddFrame(AudioFrame frame);

    void DiscardQueuedFrames();

    ulong QueuedSampleCount { get; }

    event TypedEventHandler<AudioFrameInputNode, AudioFrameCompletedEventArgs> AudioFrameCompleted;

    event TypedEventHandler<AudioFrameInputNode, FrameInputNodeQuantumStartedEventArgs> QuantumStarted;
  }
}
