// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnRouteFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3186275839, 17871, 19353, 131, 251, 219, 59, 194, 103, 43, 2)]
  public interface IVpnRouteFactory
  {
    VpnRoute CreateVpnRoute(HostName address, [Range(0, 128)] byte prefixSize);
  }
}
