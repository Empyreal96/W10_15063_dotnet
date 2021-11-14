// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ISocketActivityContextFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3114255299, 2188, 17288, 131, 174, 37, 37, 19, 142, 4, 154)]
  [ExclusiveTo(typeof (SocketActivityContext))]
  internal interface ISocketActivityContextFactory
  {
    SocketActivityContext Create(IBuffer data);
  }
}
