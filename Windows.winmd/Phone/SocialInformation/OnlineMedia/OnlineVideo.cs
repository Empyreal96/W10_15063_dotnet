// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.OnlineVideo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class OnlineVideo : IOnlineMediaItem, IOnlineVideo
  {
    public extern string Id { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern string RemoteId { [MethodImpl] get; }

    public extern DateTime CreationTime { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Width { [MethodImpl] get; }

    public extern uint Height { [MethodImpl] get; }

    public extern Uri ThumbnailSmallUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri ThumbnailLargeUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri ContentUrl { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetThumbnailSmallAsync();

    [MethodImpl]
    public extern IAsyncAction SetThumbnailSmallAsync(IInputStream pValue);

    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetThumbnailLargeAsync();

    [MethodImpl]
    public extern IAsyncAction SetThumbnailLargeAsync(IInputStream pValue);

    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetContentAsync();

    [MethodImpl]
    public extern IAsyncAction SetContentAsync(IInputStream pValue);

    [MethodImpl]
    public extern IAsyncOperation<OnlinePictureAlbum> GetPictureAlbumAsync();
  }
}
