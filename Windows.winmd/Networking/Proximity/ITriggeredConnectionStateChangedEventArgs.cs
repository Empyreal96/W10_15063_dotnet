// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.ITriggeredConnectionStateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Networking.Proximity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TriggeredConnectionStateChangedEventArgs))]
  [Guid(3332866221, 63201, 19796, 150, 226, 51, 246, 32, 188, 168, 138)]
  internal interface ITriggeredConnectionStateChangedEventArgs
  {
    TriggeredConnectState State { get; }

    uint Id { get; }

    StreamSocket Socket { get; }
  }
}
