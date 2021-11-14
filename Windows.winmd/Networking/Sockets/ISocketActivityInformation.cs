// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ISocketActivityInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2374648548, 43134, 19316, 153, 104, 24, 91, 37, 17, 222, 254)]
  [ExclusiveTo(typeof (SocketActivityInformation))]
  internal interface ISocketActivityInformation
  {
    Guid TaskId { get; }

    string Id { get; }

    SocketActivityKind SocketKind { get; }

    SocketActivityContext Context { get; }

    DatagramSocket DatagramSocket { get; }

    StreamSocket StreamSocket { get; }

    StreamSocketListener StreamSocketListener { get; }
  }
}
