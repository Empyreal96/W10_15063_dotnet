// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.IOnlineMediaItemQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [ExclusiveTo(typeof (OnlineMediaItemQueryResult))]
  [Guid(437272485, 42603, 18148, 178, 152, 149, 101, 181, 138, 235, 133)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IOnlineMediaItemQueryResult
  {
    IAsyncOperation<uint> GetItemCountAsync();

    [Overload("GetItemsAsync")]
    IAsyncOperation<IVector<IOnlineMediaItem>> GetItemsAsync();

    [Overload("GetItemsAsyncEx")]
    IAsyncOperation<IVector<IOnlineMediaItem>> GetItemsAsync(
      int count);
  }
}
