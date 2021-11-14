// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.IOnlineVideo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(35957482, 57273, 16556, 144, 34, 191, 188, 190, 182, 155, 231)]
  [ExclusiveTo(typeof (OnlineVideo))]
  internal interface IOnlineVideo : IOnlineMediaItem
  {
    TimeSpan Duration { get; set; }

    uint Width { get; }

    uint Height { get; }

    Uri ThumbnailSmallUrl { get; set; }

    Uri ThumbnailLargeUrl { get; set; }

    Uri ContentUrl { get; set; }

    IAsyncOperation<IRandomAccessStream> GetThumbnailSmallAsync();

    IAsyncAction SetThumbnailSmallAsync(IInputStream pValue);

    IAsyncOperation<IRandomAccessStream> GetThumbnailLargeAsync();

    IAsyncAction SetThumbnailLargeAsync(IInputStream pValue);

    IAsyncOperation<IRandomAccessStream> GetContentAsync();

    IAsyncAction SetContentAsync(IInputStream pValue);

    IAsyncOperation<OnlinePictureAlbum> GetPictureAlbumAsync();
  }
}
