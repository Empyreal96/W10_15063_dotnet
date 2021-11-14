// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallItem2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [Guid(3549899512, 16576, 20439, 170, 108, 10, 161, 60, 166, 24, 140)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (AppInstallItem))]
  internal interface IAppInstallItem2
  {
    [Overload("CancelWithTelemetry")]
    void Cancel(string correlationVector);

    [Overload("PauseWithTelemetry")]
    void Pause(string correlationVector);

    [Overload("RestartWithTelemetry")]
    void Restart(string correlationVector);
  }
}
