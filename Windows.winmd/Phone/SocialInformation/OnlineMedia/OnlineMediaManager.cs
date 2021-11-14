// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.OnlineMediaManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Static(typeof (IOnlineMediaManagerStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  public sealed class OnlineMediaManager : IOnlineMediaManager
  {
    [MethodImpl]
    public extern IAsyncAction ProvisionAsync();

    [MethodImpl]
    public extern OnlineVideoQueryResult CreateVideoQuery();

    [MethodImpl]
    public extern OnlinePictureQueryResult CreatePictureQuery();

    [MethodImpl]
    public extern OnlinePictureAlbumQueryResult CreatePictureAlbumQuery();

    [MethodImpl]
    public extern OnlineVideo CreateVideo(string remoteId, string parentPictureAlbumId);

    [MethodImpl]
    public extern OnlinePicture CreatePicture(
      string remoteId,
      string parentPictureAlbumId);

    [MethodImpl]
    public extern OnlinePictureAlbum CreatePictureAlbum(
      string remoteId,
      string parentPictureAlbumId);

    [MethodImpl]
    public extern IAsyncOperation<OnlineVideo> GetVideoAsync(string id);

    [MethodImpl]
    public extern IAsyncOperation<OnlinePicture> GetPictureAsync(
      string id);

    [MethodImpl]
    public extern IAsyncOperation<OnlinePictureAlbum> GetPictureAlbumAsync(
      string id);

    [MethodImpl]
    public extern IAsyncOperation<OnlineVideo> GetVideoByRemoteIdAsync(
      string remoteId);

    [MethodImpl]
    public extern IAsyncOperation<OnlinePicture> GetPictureByRemoteIdAsync(
      string remoteId);

    [MethodImpl]
    public extern IAsyncOperation<OnlinePictureAlbum> GetPictureAlbumByRemoteIdAsync(
      string remoteId);

    [MethodImpl]
    public extern IAsyncOperation<OnlinePictureAlbum> GetRootPictureAlbumAsync();

    [MethodImpl]
    public extern IAsyncAction SavePictureAlbumsAsync(
      IIterable<OnlinePictureAlbum> pictureAlbums);

    [MethodImpl]
    public extern IAsyncAction SaveMediaItemsAsync(IIterable<IOnlineMediaItem> videos);

    [MethodImpl]
    public extern IAsyncAction SaveMediaItemAsync(IOnlineMediaItem item);

    [MethodImpl]
    public extern IAsyncAction SavePictureAlbumAsync(OnlinePictureAlbum item);

    [MethodImpl]
    public extern IAsyncAction DeleteMediaItemAsync(IOnlineMediaItem item);

    [MethodImpl]
    public extern IAsyncAction DeletePictureAlbumAsync(OnlinePictureAlbum item);

    [MethodImpl]
    public extern IAsyncAction DeletePictureAlbumContentsAsync(OnlinePictureAlbum item);

    [MethodImpl]
    public extern IAsyncAction DeprovisionAsync();

    [MethodImpl]
    public static extern IAsyncOperation<OnlineMediaManager> RequestMediaManagerAsync();
  }
}
