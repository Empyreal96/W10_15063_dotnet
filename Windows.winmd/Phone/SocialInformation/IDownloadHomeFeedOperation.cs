// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.IDownloadHomeFeedOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Guid(250077683, 13934, 14344, 166, 15, 115, 201, 104, 202, 123, 211)]
  [ExclusiveTo(typeof (DownloadHomeFeedOperation))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Deprecated("IDownloadHomeFeedOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  internal interface IDownloadHomeFeedOperation : ISocialOperation
  {
    FeedOperationDetails FeedOperationDetails { [Deprecated("IDownloadHomeFeedOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }
  }
}
