﻿// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.DownloadDashboardFeedOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Deprecated("DownloadDashboardFeedOperation is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DownloadDashboardFeedOperation : 
    ISocialOperation,
    IDownloadDashboardFeedOperation
  {
    [Overload("NotifyCompletion1")]
    [Deprecated("ISocialOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern void NotifyCompletion(bool success);

    [Overload("NotifyCompletion2")]
    [Deprecated("ISocialOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern void NotifyCompletion();

    public extern uint Id { [Deprecated("ISocialOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    public extern SocialOperationType Type { [Deprecated("ISocialOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    public extern IVector<global::Windows.Phone.SocialInformation.FeedOperationDetails> FeedOperationDetails { [Deprecated("IDownloadDashboardFeedOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }
  }
}
