// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerInformationWithHostAndService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [ExclusiveTo(typeof (PeerInformation))]
  [Guid(3972517037, 7024, 20107, 146, 219, 187, 231, 129, 65, 147, 8)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPeerInformationWithHostAndService
  {
    HostName HostName { get; }

    string ServiceName { get; }
  }
}
