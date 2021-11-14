// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.Provider.ISocialFeedUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.SocialInfo.Provider
{
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  [ExclusiveTo(typeof (SocialFeedUpdater))]
  [Deprecated("ISocialFeedUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  [Guid(2047609511, 60809, 19413, 168, 217, 21, 244, 217, 134, 28, 16)]
  internal interface ISocialFeedUpdater
  {
    string OwnerRemoteId { [Deprecated("ISocialFeedUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; }

    SocialFeedKind Kind { [Deprecated("ISocialFeedUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; }

    IVector<SocialFeedItem> Items { [Deprecated("ISocialFeedUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; }

    [RemoteAsync]
    [Deprecated("ISocialFeedUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    IAsyncAction CommitAsync();
  }
}
