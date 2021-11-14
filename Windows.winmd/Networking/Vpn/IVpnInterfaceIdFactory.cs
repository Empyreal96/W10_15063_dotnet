// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnInterfaceIdFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(2653805730, 5906, 19684, 177, 121, 140, 101, 44, 109, 16, 0)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVpnInterfaceIdFactory
  {
    VpnInterfaceId CreateVpnInterfaceId([Range(0, 8)] byte[] address);
  }
}
