// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IControlChannelTrigger2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (ControlChannelTriggerContract), 131072)]
  [ExclusiveTo(typeof (ControlChannelTrigger))]
  [Guid(2936066615, 20926, 17684, 151, 37, 53, 86, 225, 135, 149, 128)]
  internal interface IControlChannelTrigger2
  {
    bool IsWakeFromLowPowerSupported { get; }
  }
}
