// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnRoute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(3044219779, 2409, 18073, 147, 142, 119, 118, 219, 41, 207, 179)]
  [ExclusiveTo(typeof (VpnRoute))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnRoute
  {
    HostName Address { set; get; }

    byte PrefixSize { [param: Range(0, 128)] set; get; }
  }
}
