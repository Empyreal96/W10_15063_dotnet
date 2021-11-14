// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.FeedItemSharedStory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("FeedItemSharedStory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [Activatable(65536, "Windows.Phone.PhoneInternalContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class FeedItemSharedStory : IFeedItemSharedStory
  {
    [MethodImpl]
    public extern FeedItemSharedStory();

    public extern string Source { [Deprecated("IFeedItemSharedStory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; [Deprecated("IFeedItemSharedStory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] set; }

    public extern FeedContent Content { [Deprecated("IFeedItemSharedStory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    public extern DateTime Timestamp { [Deprecated("IFeedItemSharedStory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; [Deprecated("IFeedItemSharedStory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] set; }

    public extern string DefaultTarget { [Deprecated("IFeedItemSharedStory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; [Deprecated("IFeedItemSharedStory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] set; }

    public extern FeedMediaThumbnail Thumbnail { [Deprecated("IFeedItemSharedStory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] set; [Deprecated("IFeedItemSharedStory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }
  }
}
