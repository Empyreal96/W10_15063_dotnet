// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.DownloadRichConnectDataOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Deprecated("DownloadRichConnectDataOperation is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DownloadRichConnectDataOperation : 
    ISocialOperation,
    IDownloadRichConnectDataOperation
  {
    [Deprecated("ISocialOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [Overload("NotifyCompletion1")]
    [MethodImpl]
    public extern void NotifyCompletion(bool success);

    [Deprecated("ISocialOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [Overload("NotifyCompletion2")]
    [MethodImpl]
    public extern void NotifyCompletion();

    public extern uint Id { [Deprecated("ISocialOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    public extern SocialOperationType Type { [Deprecated("ISocialOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    public extern IVector<string> Ids { [Deprecated("IDownloadRichConnectDataOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }
  }
}
