// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.SocialManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Deprecated("SocialManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [Static(typeof (ISocialManagerStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  [Static(typeof (ISocialManagerStatics2), 65536, "Windows.Phone.PhoneInternalContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class SocialManager : ISocialManager
  {
    [Deprecated("ISocialManagerStatics2 : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncAction DeleteAllAppUserDataAsync();

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncOperation<OperationQueue> GetOperationQueueAsync();

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncOperation<Feed> OpenHomeFeedAsync(
      FeedOperationDetails FeedOperationDetails);

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncOperation<Feed> OpenContactFeedAsync(
      FeedOperationDetails FeedOperationDetails);

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncOperation<DashboardItem> OpenContactDashboardAsync(
      FeedOperationDetails FeedOperationDetails);

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncAction UpdateReactionDisplayCountAsync(
      string itemRemoteId,
      int count);

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncAction MarkFeedAsStaleAsync(
      string ownerRemoteId,
      FeedType feedType);

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncAction ProvisionAsync();

    [Deprecated("ISocialManagerStatics : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncAction DeprovisionAsync();
  }
}
