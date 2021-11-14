// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnDomainNameAssignment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnDomainNameAssignment))]
  [Guid(1094037825, 52443, 18869, 148, 1, 3, 154, 138, 231, 103, 233)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnDomainNameAssignment
  {
    IVector<VpnDomainNameInfo> DomainNameList { get; }

    Uri ProxyAutoConfigurationUri { set; get; }
  }
}
