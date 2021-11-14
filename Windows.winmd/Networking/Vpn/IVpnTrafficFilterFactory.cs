// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnTrafficFilterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnTrafficFilter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1208828373, 32665, 18252, 134, 238, 150, 223, 22, 131, 24, 241)]
  internal interface IVpnTrafficFilterFactory
  {
    VpnTrafficFilter Create(VpnAppId appId);
  }
}
