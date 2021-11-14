// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ConnectionCost
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ConnectionCost : IConnectionCost, IConnectionCost2
  {
    public extern NetworkCostType NetworkCostType { [MethodImpl] get; }

    public extern bool Roaming { [MethodImpl] get; }

    public extern bool OverDataLimit { [MethodImpl] get; }

    public extern bool ApproachingDataLimit { [MethodImpl] get; }

    public extern bool BackgroundDataUsageRestricted { [MethodImpl] get; }
  }
}
