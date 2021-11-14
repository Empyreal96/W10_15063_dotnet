// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPlugInProfile2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnPlugInProfile))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1629243538, 53140, 19158, 186, 153, 0, 244, 255, 52, 86, 94)]
  internal interface IVpnPlugInProfile2 : IVpnProfile
  {
    bool RequireVpnClientAppUI { get; set; }

    VpnManagementConnectionStatus ConnectionStatus { get; }
  }
}
