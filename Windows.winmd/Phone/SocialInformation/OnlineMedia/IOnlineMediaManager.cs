// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.IOnlineMediaManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(1125825398, 52177, 17614, 176, 137, 56, 87, 220, 3, 129, 251)]
  [ExclusiveTo(typeof (OnlineMediaManager))]
  internal interface IOnlineMediaManager
  {
    IAsyncAction ProvisionAsync();

    OnlineVideoQueryResult CreateVideoQuery();

    OnlinePictureQueryResult CreatePictureQuery();

    OnlinePictureAlbumQueryResult CreatePictureAlbumQuery();

    OnlineVideo CreateVideo(string remoteId, string parentPictureAlbumId);

    OnlinePicture CreatePicture(string remoteId, string parentPictureAlbumId);

    OnlinePictureAlbum CreatePictureAlbum(
      string remoteId,
      string parentPictureAlbumId);

    IAsyncOperation<OnlineVideo> GetVideoAsync(string id);

    IAsyncOperation<OnlinePicture> GetPictureAsync(string id);

    IAsyncOperation<OnlinePictureAlbum> GetPictureAlbumAsync(
      string id);

    IAsyncOperation<OnlineVideo> GetVideoByRemoteIdAsync(string remoteId);

    IAsyncOperation<OnlinePicture> GetPictureByRemoteIdAsync(
      string remoteId);

    IAsyncOperation<OnlinePictureAlbum> GetPictureAlbumByRemoteIdAsync(
      string remoteId);

    IAsyncOperation<OnlinePictureAlbum> GetRootPictureAlbumAsync();

    IAsyncAction SavePictureAlbumsAsync(IIterable<OnlinePictureAlbum> pictureAlbums);

    IAsyncAction SaveMediaItemsAsync(IIterable<IOnlineMediaItem> videos);

    IAsyncAction SaveMediaItemAsync(IOnlineMediaItem item);

    IAsyncAction SavePictureAlbumAsync(OnlinePictureAlbum item);

    IAsyncAction DeleteMediaItemAsync(IOnlineMediaItem item);

    IAsyncAction DeletePictureAlbumAsync(OnlinePictureAlbum item);

    IAsyncAction DeletePictureAlbumContentsAsync(OnlinePictureAlbum item);

    IAsyncAction DeprovisionAsync();
  }
}
