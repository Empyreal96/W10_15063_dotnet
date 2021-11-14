// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.ISocialManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [ExclusiveTo(typeof (SocialManager))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(340881686, 35706, 17036, 170, 151, 135, 42, 158, 5, 183, 157)]
  [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  internal interface ISocialManagerStatics
  {
    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncOperation<OperationQueue> GetOperationQueueAsync();

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncOperation<Feed> OpenHomeFeedAsync(
      FeedOperationDetails FeedOperationDetails);

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncOperation<Feed> OpenContactFeedAsync(
      FeedOperationDetails FeedOperationDetails);

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncOperation<DashboardItem> OpenContactDashboardAsync(
      FeedOperationDetails FeedOperationDetails);

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncAction UpdateReactionDisplayCountAsync(string itemRemoteId, int count);

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncAction MarkFeedAsStaleAsync(string ownerRemoteId, FeedType feedType);

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncAction ProvisionAsync();

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncAction DeprovisionAsync();
  }
}
