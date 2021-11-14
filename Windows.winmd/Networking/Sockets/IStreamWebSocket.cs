// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamWebSocket
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamWebSocket))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3175762392, 45705, 17851, 151, 235, 199, 82, 82, 5, 168, 67)]
  internal interface IStreamWebSocket : IWebSocket, IClosable
  {
    StreamWebSocketControl Control { get; }

    StreamWebSocketInformation Information { get; }

    IInputStream InputStream { get; }
  }
}
