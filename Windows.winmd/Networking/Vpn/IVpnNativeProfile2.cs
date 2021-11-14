// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnNativeProfile2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(267134055, 52661, 19143, 181, 163, 10, 251, 94, 196, 118, 130)]
  [ExclusiveTo(typeof (VpnNativeProfile))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IVpnNativeProfile2
  {
    bool RequireVpnClientAppUI { get; set; }

    VpnManagementConnectionStatus ConnectionStatus { get; }
  }
}
