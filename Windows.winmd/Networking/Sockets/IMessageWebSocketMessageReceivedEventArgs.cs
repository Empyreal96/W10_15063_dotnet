﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IMessageWebSocketMessageReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1200366252, 19531, 17133, 158, 215, 30, 249, 249, 79, 163, 213)]
  [ExclusiveTo(typeof (MessageWebSocketMessageReceivedEventArgs))]
  internal interface IMessageWebSocketMessageReceivedEventArgs
  {
    SocketMessageType MessageType { get; }

    DataReader GetDataReader();

    IInputStream GetDataStream();
  }
}
