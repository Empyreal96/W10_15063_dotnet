// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.OnlinePhotos.OnlinePictureAlbumManager
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.OnlinePhotos
{
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [Static(typeof (IOnlinePictureAlbumManagerStatics), 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class OnlinePictureAlbumManager : IOnlinePictureAlbumManager
  {
    [MethodImpl]
    public static extern IAsyncAction FetchAlbumItemsAsync(
      RequestPriority priority,
      Guid appId,
      AlbumType photoType,
      string albumRemoteId,
      uint startIndex,
      uint count);

    [MethodImpl]
    public static extern IAsyncAction FetchAlbumArtAsync(
      RequestPriority priority,
      Guid appId,
      string albumRemoteId);

    [MethodImpl]
    public static extern IAsyncAction FetchPhotoAsync(
      RequestPriority priority,
      Guid appId,
      string photoRemoteId,
      PhotoType photoType,
      uint desiredWidth,
      uint desiredHeight);
  }
}
