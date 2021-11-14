// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPlugInProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnPlugInProfile))]
  [Guid(249499044, 20224, 17801, 141, 123, 75, 249, 136, 246, 84, 44)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnPlugInProfile : IVpnProfile
  {
    IVector<Uri> ServerUris { get; }

    string CustomConfiguration { get; set; }

    string VpnPluginPackageFamilyName { get; set; }
  }
}
