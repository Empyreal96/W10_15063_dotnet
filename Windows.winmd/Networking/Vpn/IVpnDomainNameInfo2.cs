// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnDomainNameInfo2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(2877755729, 27731, 18472, 152, 131, 216, 134, 222, 16, 68, 7)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (VpnDomainNameInfo))]
  internal interface IVpnDomainNameInfo2
  {
    IVector<Uri> WebProxyUris { get; }
  }
}
