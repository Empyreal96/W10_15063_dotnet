// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnTrafficFilterAssignment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(1456264284, 58980, 18206, 137, 205, 96, 22, 3, 185, 224, 243)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnTrafficFilterAssignment))]
  internal interface IVpnTrafficFilterAssignment
  {
    IVector<VpnTrafficFilter> TrafficFilterList { get; }

    bool AllowOutbound { get; set; }

    bool AllowInbound { get; set; }
  }
}
