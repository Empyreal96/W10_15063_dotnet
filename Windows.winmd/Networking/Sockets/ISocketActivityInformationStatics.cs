// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ISocketActivityInformationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2238755962, 32381, 18230, 128, 65, 19, 39, 166, 84, 60, 86)]
  [ExclusiveTo(typeof (SocketActivityInformation))]
  internal interface ISocketActivityInformationStatics
  {
    IMapView<string, SocketActivityInformation> AllSockets { get; }
  }
}
