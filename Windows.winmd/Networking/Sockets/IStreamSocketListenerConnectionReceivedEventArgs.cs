// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListenerConnectionReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(205991593, 14143, 17531, 133, 177, 221, 212, 84, 136, 3, 186)]
  [ExclusiveTo(typeof (StreamSocketListenerConnectionReceivedEventArgs))]
  internal interface IStreamSocketListenerConnectionReceivedEventArgs
  {
    StreamSocket Socket { get; }
  }
}
