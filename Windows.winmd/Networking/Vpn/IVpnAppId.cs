// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnAppId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2064033333, 23640, 16857, 148, 167, 191, 188, 241, 216, 202, 84)]
  [ExclusiveTo(typeof (VpnAppId))]
  internal interface IVpnAppId
  {
    VpnAppIdType Type { get; set; }

    string Value { get; set; }
  }
}
