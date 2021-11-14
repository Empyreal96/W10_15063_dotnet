// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.IDownloadFeedOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Deprecated("IDownloadFeedOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [Guid(1236571660, 31633, 14408, 148, 251, 244, 188, 197, 60, 7, 78)]
  [ExclusiveTo(typeof (DownloadFeedOperation))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IDownloadFeedOperation : ISocialOperation
  {
    IVector<global::Windows.Phone.SocialInformation.FeedOperationDetails> FeedOperationDetails { [Deprecated("IDownloadFeedOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }
  }
}
