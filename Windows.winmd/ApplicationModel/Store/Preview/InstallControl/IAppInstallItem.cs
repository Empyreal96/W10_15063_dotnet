// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [Guid(1238622123, 5770, 19647, 169, 58, 158, 68, 140, 130, 115, 125)]
  [ExclusiveTo(typeof (AppInstallItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppInstallItem
  {
    string ProductId { get; }

    string PackageFamilyName { get; }

    AppInstallType InstallType { get; }

    bool IsUserInitiated { get; }

    AppInstallStatus GetCurrentStatus();

    void Cancel();

    void Pause();

    void Restart();

    event TypedEventHandler<AppInstallItem, object> Completed;

    event TypedEventHandler<AppInstallItem, object> StatusChanged;
  }
}
