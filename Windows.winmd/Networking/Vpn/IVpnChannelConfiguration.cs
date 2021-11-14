// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannelConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnChannelConfiguration))]
  [Guid(237886626, 8210, 20452, 177, 121, 140, 101, 44, 109, 16, 126)]
  internal interface IVpnChannelConfiguration
  {
    string ServerServiceName { get; }

    IVectorView<HostName> ServerHostNameList { get; }

    string CustomField { get; }
  }
}
