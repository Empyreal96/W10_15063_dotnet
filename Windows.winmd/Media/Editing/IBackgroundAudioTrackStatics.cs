// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IBackgroundAudioTrackStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Editing
{
  [Guid(3652305111, 53272, 17064, 165, 89, 203, 77, 158, 151, 230, 100)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BackgroundAudioTrack))]
  internal interface IBackgroundAudioTrackStatics
  {
    BackgroundAudioTrack CreateFromEmbeddedAudioTrack(
      EmbeddedAudioTrack embeddedAudioTrack);

    [RemoteAsync]
    IAsyncOperation<BackgroundAudioTrack> CreateFromFileAsync(
      IStorageFile file);
  }
}
