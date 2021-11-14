// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IRoutePolicy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (RoutePolicy))]
  [Guid(296469676, 4039, 17124, 135, 66, 86, 153, 35, 177, 202, 17)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRoutePolicy
  {
    ConnectionProfile ConnectionProfile { get; }

    HostName HostName { get; }

    DomainNameType HostNameType { get; }
  }
}
