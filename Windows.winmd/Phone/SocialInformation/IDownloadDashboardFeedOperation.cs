// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.IDownloadDashboardFeedOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Guid(3150910510, 49030, 13368, 174, 226, 133, 23, 201, 50, 94, 24)]
  [Deprecated("IDownloadDashboardFeedOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (DownloadDashboardFeedOperation))]
  internal interface IDownloadDashboardFeedOperation : ISocialOperation
  {
    IVector<global::Windows.Phone.SocialInformation.FeedOperationDetails> FeedOperationDetails { [Deprecated("IDownloadDashboardFeedOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }
  }
}
