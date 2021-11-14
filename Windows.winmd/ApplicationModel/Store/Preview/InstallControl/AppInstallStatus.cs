// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AppInstallStatus : IAppInstallStatus, IAppInstallStatus2
  {
    public extern AppInstallState InstallState { [MethodImpl] get; }

    public extern ulong DownloadSizeInBytes { [MethodImpl] get; }

    public extern ulong BytesDownloaded { [MethodImpl] get; }

    public extern double PercentComplete { [MethodImpl] get; }

    public extern HResult ErrorCode { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }

    public extern bool ReadyForLaunch { [MethodImpl] get; }
  }
}
