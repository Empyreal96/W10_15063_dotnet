// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioFileOutputNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Transcoding;
using Windows.Storage;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1356863872, 20838, 16531, 128, 248, 173, 160, 0, 137, 233, 207)]
  [ExclusiveTo(typeof (AudioFileOutputNode))]
  internal interface IAudioFileOutputNode : IAudioNode, IClosable
  {
    IStorageFile File { get; }

    MediaEncodingProfile FileEncodingProfile { get; }

    [RemoteAsync]
    IAsyncOperation<TranscodeFailureReason> FinalizeAsync();
  }
}
