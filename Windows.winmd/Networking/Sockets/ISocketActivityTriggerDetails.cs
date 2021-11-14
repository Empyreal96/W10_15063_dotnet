// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ISocketActivityTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (SocketActivityTriggerDetails))]
  [Guid(1173620391, 64671, 20353, 172, 173, 53, 95, 239, 81, 230, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISocketActivityTriggerDetails
  {
    SocketActivityTriggerReason Reason { get; }

    SocketActivityInformation SocketInformation { get; }
  }
}
