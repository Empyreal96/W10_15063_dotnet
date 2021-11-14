// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemDiscoveryTypeFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IRemoteSystemDiscoveryTypeFilterFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class RemoteSystemDiscoveryTypeFilter : 
    IRemoteSystemDiscoveryTypeFilter,
    IRemoteSystemFilter
  {
    [MethodImpl]
    public extern RemoteSystemDiscoveryTypeFilter(RemoteSystemDiscoveryType discoveryType);

    public extern RemoteSystemDiscoveryType RemoteSystemDiscoveryType { [MethodImpl] get; }
  }
}
