// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocketInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DatagramSocketInformation))]
  [Guid(1595561626, 22011, 18637, 151, 6, 122, 151, 79, 123, 21, 133)]
  internal interface IDatagramSocketInformation
  {
    HostName LocalAddress { get; }

    string LocalPort { get; }

    HostName RemoteAddress { get; }

    string RemotePort { get; }
  }
}
