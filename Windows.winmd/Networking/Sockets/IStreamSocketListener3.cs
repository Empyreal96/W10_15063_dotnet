// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListener3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(1201152028, 48632, 18713, 133, 66, 40, 212, 80, 231, 69, 7)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StreamSocketListener))]
  internal interface IStreamSocketListener3
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
  }
}
