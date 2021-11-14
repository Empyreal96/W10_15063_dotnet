// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.IFeed
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(2959382203, 55759, 15352, 164, 138, 159, 116, 87, 134, 80, 117)]
  [ExclusiveTo(typeof (Feed))]
  [Deprecated("IFeed : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  internal interface IFeed
  {
    string OwnerRemoteId { [Deprecated("IFeed : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    FeedType Type { [Deprecated("IFeed : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    [Deprecated("IFeed : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncAction SaveAsync();

    IVector<FeedItem> Items { [Deprecated("IFeed : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }
  }
}
