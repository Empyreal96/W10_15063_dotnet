// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.IOnlinePictureAlbum
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [ExclusiveTo(typeof (OnlinePictureAlbum))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(3188426489, 29566, 19037, 165, 211, 222, 188, 105, 9, 47, 9)]
  internal interface IOnlinePictureAlbum
  {
    string Id { get; }

    string Title { get; set; }

    string RemoteId { get; }

    DateTime CreationTime { get; set; }

    string ParentPictureAlbumId { get; }

    IAsyncOperation<IRandomAccessStream> GetCoverImageAsync();

    IAsyncAction SetCoverImageAsync(IInputStream pValue);

    Uri CoverImageUrl { get; set; }

    bool RequiresAuthentication { get; set; }

    string VersionStamp { get; set; }

    OnlinePictureAlbumQueryResult GetPictureAlbumsQuery();

    OnlineMediaItemQueryResult GetContentsQuery();
  }
}
