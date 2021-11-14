// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerCloseAlarm
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1811451079, 28515, 17166, 171, 59, 149, 215, 95, 251, 232, 127)]
  [ExclusiveTo(typeof (CashDrawerCloseAlarm))]
  internal interface ICashDrawerCloseAlarm
  {
    TimeSpan AlarmTimeout { set; get; }

    uint BeepFrequency { set; get; }

    TimeSpan BeepDuration { set; get; }

    TimeSpan BeepDelay { set; get; }

    event TypedEventHandler<CashDrawerCloseAlarm, object> AlarmTimeoutExpired;

    [RemoteAsync]
    IAsyncOperation<bool> StartAsync();
  }
}
