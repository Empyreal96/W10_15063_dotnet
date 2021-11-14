// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IControlChannelTriggerResetEventDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [WebHostHidden]
  [Guid(1750139790, 36548, 17150, 155, 178, 33, 233, 27, 123, 252, 177)]
  [ContractVersion(typeof (ControlChannelTriggerContract), 65536)]
  public interface IControlChannelTriggerResetEventDetails
  {
    ControlChannelTriggerResetReason ResetReason { get; }

    bool HardwareSlotReset { get; }

    bool SoftwareSlotReset { get; }
  }
}
