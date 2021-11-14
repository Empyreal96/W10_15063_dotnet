// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocket3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(1061358336, 40232, 18516, 186, 195, 35, 1, 148, 30, 194, 35)]
  [ExclusiveTo(typeof (StreamSocket))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocket3
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
