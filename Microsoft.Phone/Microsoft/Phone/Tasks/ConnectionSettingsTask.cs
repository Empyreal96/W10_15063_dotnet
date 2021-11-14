// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.ConnectionSettingsTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;

namespace Microsoft.Phone.Tasks
{
  public sealed class ConnectionSettingsTask
  {
    public ConnectionSettingsTask() => this.ConnectionSettingsType = ConnectionSettingsType.WiFi;

    public ConnectionSettingsType ConnectionSettingsType { get; set; }

    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      ChooserHelper.LaunchSession(this.BuildUri(), new ParameterPropertyBag());
    }

    internal Uri BuildUri()
    {
      switch (this.ConnectionSettingsType)
      {
        case ConnectionSettingsType.Bluetooth:
          return new Uri("app://5B04B775-356B-4AA0-AAF8-6491FFEA5620/_default", UriKind.Absolute);
        case ConnectionSettingsType.Cellular:
          return new Uri("ms-settings:network-cellular", UriKind.Absolute);
        case ConnectionSettingsType.AirplaneMode:
          return new Uri("app://5B04B775-356B-4AA0-AAF8-6491FFEA5621/Default", UriKind.Absolute);
        default:
          return new Uri("ms-settings:network-wifi", UriKind.Absolute);
      }
    }
  }
}
