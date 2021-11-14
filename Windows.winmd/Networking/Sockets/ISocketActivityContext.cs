// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ISocketActivityContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [Guid(1135627620, 19589, 17302, 166, 55, 29, 151, 63, 110, 189, 73)]
  [ExclusiveTo(typeof (SocketActivityContext))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISocketActivityContext
  {
    IBuffer Data { get; }
  }
}
