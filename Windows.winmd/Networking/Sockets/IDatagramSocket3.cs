// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocket3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(928272137, 43922, 17158, 154, 193, 12, 56, 18, 131, 217, 198)]
  [ExclusiveTo(typeof (DatagramSocket))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatagramSocket3
  {
    [RemoteAsync]
    IAsyncAction CancelIOAsync();

    [Overload("EnableTransferOwnership")]
    void EnableTransferOwnership(Guid taskId);

    [Overload("EnableTransferOwnershipWithConnectedStandbyAction")]
    void EnableTransferOwnership(
      Guid taskId,
      SocketActivityConnectedStandbyAction connectedStandbyAction);

    [Overload("TransferOwnership")]
    void TransferOwnership(string socketId);

    [Overload("TransferOwnershipWithContext")]
    void TransferOwnership(string socketId, SocketActivityContext data);

    [Overload("TransferOwnershipWithContextAndKeepAliveTime")]
    void TransferOwnership(string socketId, SocketActivityContext data, global::Windows.Foundation.TimeSpan keepAliveTime);
  }
}
