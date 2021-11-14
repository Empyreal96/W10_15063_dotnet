// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnAppIdFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnAppId))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1185807658, 2731, 20443, 130, 29, 211, 221, 201, 25, 120, 139)]
  internal interface IVpnAppIdFactory
  {
    VpnAppId Create(VpnAppIdType type, string value);
  }
}
