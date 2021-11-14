// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppInstallStatus))]
  [Guid(2473446650, 9296, 16678, 136, 177, 97, 39, 166, 68, 221, 92)]
  internal interface IAppInstallStatus
  {
    AppInstallState InstallState { get; }

    ulong DownloadSizeInBytes { get; }

    ulong BytesDownloaded { get; }

    double PercentComplete { get; }

    HResult ErrorCode { get; }
  }
}
