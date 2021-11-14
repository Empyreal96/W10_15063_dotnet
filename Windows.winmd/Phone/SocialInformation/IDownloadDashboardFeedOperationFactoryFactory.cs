// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.IDownloadDashboardFeedOperationFactoryFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Deprecated("IDownloadDashboardFeedOperationFactoryFactory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [Guid(4176363788, 15628, 19965, 164, 45, 255, 229, 6, 66, 239, 173)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (DownloadDashboardFeedOperationFactory))]
  internal interface IDownloadDashboardFeedOperationFactoryFactory
  {
    [Deprecated("IDownloadDashboardFeedOperationFactoryFactory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    DownloadDashboardFeedOperationFactory CreateInstance1(
      string ownerRemoteId);
  }
}
