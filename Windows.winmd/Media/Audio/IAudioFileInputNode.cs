// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioFileInputNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioFileInputNode))]
  [Guid(2421909448, 28517, 19668, 136, 144, 70, 148, 132, 60, 39, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioFileInputNode : IAudioInputNode, IAudioNode, IClosable
  {
    double PlaybackSpeedFactor { set; get; }

    TimeSpan Position { get; }

    void Seek(TimeSpan position);

    IReference<TimeSpan> StartTime { get; set; }

    IReference<TimeSpan> EndTime { get; set; }

    IReference<int> LoopCount { get; set; }

    TimeSpan Duration { get; }

    StorageFile SourceFile { get; }

    event TypedEventHandler<AudioFileInputNode, object> FileCompleted;
  }
}
