// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.OnlinePhotos.IOnlinePictureAlbumManagerStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.OnlinePhotos
{
  [ExclusiveTo(typeof (OnlinePictureAlbumManager))]
  [Version(100859904)]
  [Guid(633269072, 46907, 15140, 174, 86, 93, 160, 96, 91, 249, 238)]
  internal interface IOnlinePictureAlbumManagerStatics
  {
    IAsyncAction FetchAlbumItemsAsync(
      RequestPriority priority,
      Guid appId,
      AlbumType photoType,
      string albumRemoteId,
      uint startIndex,
      uint count);

    IAsyncAction FetchAlbumArtAsync(
      RequestPriority priority,
      Guid appId,
      string albumRemoteId);

    IAsyncAction FetchPhotoAsync(
      RequestPriority priority,
      Guid appId,
      string photoRemoteId,
      PhotoType photoType,
      uint desiredWidth,
      uint desiredHeight);
  }
}
