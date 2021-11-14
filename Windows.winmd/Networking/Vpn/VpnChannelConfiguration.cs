// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnChannelConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VpnChannelConfiguration : IVpnChannelConfiguration, IVpnChannelConfiguration2
  {
    public extern string ServerServiceName { [MethodImpl] get; }

    public extern IVectorView<HostName> ServerHostNameList { [MethodImpl] get; }

    public extern string CustomField { [MethodImpl] get; }

    public extern IVectorView<Uri> ServerUris { [MethodImpl] get; }
  }
}
