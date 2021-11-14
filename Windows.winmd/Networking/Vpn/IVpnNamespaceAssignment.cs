// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnNamespaceAssignment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnNamespaceAssignment))]
  [Guid(3623344920, 12413, 19470, 189, 98, 143, 162, 112, 187, 173, 214)]
  internal interface IVpnNamespaceAssignment
  {
    IVector<VpnNamespaceInfo> NamespaceList { set; get; }

    Uri ProxyAutoConfigUri { set; get; }
  }
}
