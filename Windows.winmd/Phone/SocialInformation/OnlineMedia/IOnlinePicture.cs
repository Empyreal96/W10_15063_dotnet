// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.IOnlinePicture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [ExclusiveTo(typeof (OnlinePicture))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(3818194866, 55947, 17650, 182, 78, 124, 11, 135, 45, 197, 142)]
  internal interface IOnlinePicture : IOnlineMediaItem
  {
    uint Width { get; }

    uint Height { get; }

    IAsyncOperation<IRandomAccessStream> GetThumbnailSmallAsync();

    IAsyncAction SetThumbnailSmallAsync(IInputStream pValue);

    IAsyncOperation<IRandomAccessStream> GetThumbnailLargeAsync();

    IAsyncAction SetThumbnailLargeAsync(IInputStream pValue);

    IAsyncOperation<IRandomAccessStream> GetContentAsync();

    IAsyncAction SetContentAsync(IInputStream pValue);

    Uri ThumbnailSmallUrl { get; set; }

    Uri ThumbnailLargeUrl { get; set; }

    Uri ContentUrl { get; set; }

    IAsyncOperation<OnlinePictureAlbum> GetPictureAlbumAsync();
  }
}
