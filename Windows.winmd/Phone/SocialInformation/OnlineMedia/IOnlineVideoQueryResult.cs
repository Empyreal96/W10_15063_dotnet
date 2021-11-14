// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.IOnlineVideoQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [Guid(2330110123, 41988, 19507, 173, 211, 227, 53, 203, 171, 57, 4)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (OnlineVideoQueryResult))]
  internal interface IOnlineVideoQueryResult
  {
    IAsyncOperation<uint> GetVideoCountAsync();

    [Overload("GetVideosAsync")]
    IAsyncOperation<IVector<OnlineVideo>> GetVideosAsync();

    [Overload("GetVideosAsyncEx")]
    IAsyncOperation<IVector<OnlineVideo>> GetVideosAsync(int count);
  }
}
