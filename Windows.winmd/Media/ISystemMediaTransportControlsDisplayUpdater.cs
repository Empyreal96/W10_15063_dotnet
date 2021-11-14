// Decompiled with JetBrains decompiler
// Type: Windows.Media.ISystemMediaTransportControlsDisplayUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media
{
  [Guid(2327561534, 64085, 20175, 173, 142, 201, 132, 229, 221, 21, 80)]
  [ExclusiveTo(typeof (SystemMediaTransportControlsDisplayUpdater))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemMediaTransportControlsDisplayUpdater
  {
    MediaPlaybackType Type { get; set; }

    string AppMediaId { get; set; }

    RandomAccessStreamReference Thumbnail { get; set; }

    MusicDisplayProperties MusicProperties { get; }

    VideoDisplayProperties VideoProperties { get; }

    ImageDisplayProperties ImageProperties { get; }

    [RemoteAsync]
    IAsyncOperation<bool> CopyFromFileAsync(
      MediaPlaybackType type,
      StorageFile source);

    void ClearAll();

    void Update();
  }
}
