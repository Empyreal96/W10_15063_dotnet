// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskCancellationReason
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BackgroundTaskCancellationReason
  {
    Abort,
    Terminating,
    LoggingOff,
    ServicingUpdate,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] IdleTask,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Uninstall,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ConditionLoss,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] SystemPolicy,
    [Deprecated("QuietHoursEntered is deprecated after Windows 8.1", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] QuietHoursEntered,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ExecutionTimeExceeded,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ResourceRevocation,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] EnergySaver,
  }
}
