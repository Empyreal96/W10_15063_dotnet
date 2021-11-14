// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ControlChannelTriggerResetReason
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (ControlChannelTriggerContract), 65536)]
  [WebHostHidden]
  public enum ControlChannelTriggerResetReason
  {
    FastUserSwitched,
    LowPowerExit,
    [ContractVersion("Windows.Networking.Sockets.ControlChannelTriggerContract", 65536)] QuietHoursExit,
    [ContractVersion("Windows.Networking.Sockets.ControlChannelTriggerContract", 65536)] ApplicationRestart,
  }
}
