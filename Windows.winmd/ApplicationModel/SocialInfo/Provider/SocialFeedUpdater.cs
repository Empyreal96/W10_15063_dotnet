// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.Provider.SocialFeedUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.SocialInfo.Provider
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("SocialFeedUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  public sealed class SocialFeedUpdater : ISocialFeedUpdater
  {
    public extern string OwnerRemoteId { [Deprecated("ISocialFeedUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; }

    public extern SocialFeedKind Kind { [Deprecated("ISocialFeedUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; }

    public extern IVector<SocialFeedItem> Items { [Deprecated("ISocialFeedUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; }

    [Deprecated("ISocialFeedUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CommitAsync();
  }
}
