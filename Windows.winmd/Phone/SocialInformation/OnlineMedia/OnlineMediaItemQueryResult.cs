// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.OnlineMediaItemQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class OnlineMediaItemQueryResult : IOnlineMediaItemQueryResult
  {
    [MethodImpl]
    public extern IAsyncOperation<uint> GetItemCountAsync();

    [Overload("GetItemsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<IOnlineMediaItem>> GetItemsAsync();

    [Overload("GetItemsAsyncEx")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<IOnlineMediaItem>> GetItemsAsync(
      int count);
  }
}
