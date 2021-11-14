// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkAdapter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NetworkAdapter : INetworkAdapter
  {
    public extern ulong OutboundMaxBitsPerSecond { [MethodImpl] get; }

    public extern ulong InboundMaxBitsPerSecond { [MethodImpl] get; }

    public extern uint IanaInterfaceType { [MethodImpl] get; }

    public extern NetworkItem NetworkItem { [MethodImpl] get; }

    public extern Guid NetworkAdapterId { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ConnectionProfile> GetConnectedProfileAsync();
  }
}
