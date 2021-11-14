// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppInstallItem : IAppInstallItem, IAppInstallItem2, IAppInstallItem3
  {
    public extern string ProductId { [MethodImpl] get; }

    public extern string PackageFamilyName { [MethodImpl] get; }

    public extern AppInstallType InstallType { [MethodImpl] get; }

    public extern bool IsUserInitiated { [MethodImpl] get; }

    [MethodImpl]
    public extern AppInstallStatus GetCurrentStatus();

    [MethodImpl]
    public extern void Cancel();

    [MethodImpl]
    public extern void Pause();

    [MethodImpl]
    public extern void Restart();

    public extern event TypedEventHandler<AppInstallItem, object> Completed;

    public extern event TypedEventHandler<AppInstallItem, object> StatusChanged;

    [Overload("CancelWithTelemetry")]
    [MethodImpl]
    public extern void Cancel(string correlationVector);

    [Overload("PauseWithTelemetry")]
    [MethodImpl]
    public extern void Pause(string correlationVector);

    [Overload("RestartWithTelemetry")]
    [MethodImpl]
    public extern void Restart(string correlationVector);

    public extern IVectorView<AppInstallItem> Children { [MethodImpl] get; }

    public extern bool ItemOperationsMightAffectOtherItems { [MethodImpl] get; }
  }
}
