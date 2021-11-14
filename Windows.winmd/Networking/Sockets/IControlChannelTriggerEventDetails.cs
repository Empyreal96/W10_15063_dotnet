// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IControlChannelTriggerEventDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [WebHostHidden]
  [Guid(456581191, 35259, 16950, 150, 172, 113, 208, 18, 187, 72, 105)]
  [ContractVersion(typeof (ControlChannelTriggerContract), 65536)]
  public interface IControlChannelTriggerEventDetails
  {
    ControlChannelTrigger ControlChannelTrigger { get; }
  }
}
