// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.OnlinePictureAlbum
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class OnlinePictureAlbum : IOnlinePictureAlbum
  {
    public extern string Id { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern string RemoteId { [MethodImpl] get; }

    public extern DateTime CreationTime { [MethodImpl] get; [MethodImpl] set; }

    public extern string ParentPictureAlbumId { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetCoverImageAsync();

    [MethodImpl]
    public extern IAsyncAction SetCoverImageAsync(IInputStream pValue);

    public extern Uri CoverImageUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern bool RequiresAuthentication { [MethodImpl] get; [MethodImpl] set; }

    public extern string VersionStamp { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern OnlinePictureAlbumQueryResult GetPictureAlbumsQuery();

    [MethodImpl]
    public extern OnlineMediaItemQueryResult GetContentsQuery();
  }
}
