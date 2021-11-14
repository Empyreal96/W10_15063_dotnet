// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SystemTriggerType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SystemTriggerType
  {
    Invalid,
    SmsReceived,
    UserPresent,
    UserAway,
    NetworkStateChange,
    ControlChannelReset,
    InternetAvailable,
    SessionConnected,
    ServicingComplete,
    LockScreenApplicationAdded,
    LockScreenApplicationRemoved,
    TimeZoneChange,
    OnlineIdConnectedStateChange,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] BackgroundWorkCostChange,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PowerStateChange,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DefaultSignInAccountChange,
  }
}
