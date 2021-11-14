// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IUnconstrainedTransferRequestResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1277474847, 55620, 16658, 169, 142, 106, 105, 82, 43, 126, 187)]
  [ExclusiveTo(typeof (UnconstrainedTransferRequestResult))]
  [Deprecated("IUnconstrainedTransferRequestResult is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  internal interface IUnconstrainedTransferRequestResult
  {
    bool IsUnconstrained { [Deprecated("IsUnconstrained is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
