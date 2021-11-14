// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.DownloadDashboardFeedOperationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Deprecated("DownloadDashboardFeedOperationFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IDownloadDashboardFeedOperationFactoryFactory), 65536, "Windows.Phone.PhoneInternalContract")]
  public sealed class DownloadDashboardFeedOperationFactory : ISocialOperationFactory
  {
    [Deprecated("IDownloadDashboardFeedOperationFactoryFactory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern DownloadDashboardFeedOperationFactory(string ownerRemoteId);

    public extern SocialOperationType Type { [Deprecated("ISocialOperationFactory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    [Deprecated("ISocialOperationFactory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern IAsyncOperation<ISocialOperation> GetOperationAsync();
  }
}
