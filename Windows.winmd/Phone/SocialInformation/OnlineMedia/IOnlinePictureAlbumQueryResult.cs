// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.IOnlinePictureAlbumQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [ExclusiveTo(typeof (OnlinePictureAlbumQueryResult))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(313569653, 841, 17897, 177, 29, 25, 42, 182, 208, 232, 131)]
  internal interface IOnlinePictureAlbumQueryResult
  {
    IAsyncOperation<uint> GetPictureAlbumCountAsync();

    [Overload("GetPictureAlbumsAsync")]
    IAsyncOperation<IVector<OnlinePictureAlbum>> GetPictureAlbumsAsync();

    [Overload("GetPictureAlbumsAsyncEx")]
    IAsyncOperation<IVector<OnlinePictureAlbum>> GetPictureAlbumsAsync(
      int count);
  }
}
