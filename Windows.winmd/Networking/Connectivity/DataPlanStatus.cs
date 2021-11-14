// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.DataPlanStatus
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
  public sealed class DataPlanStatus : IDataPlanStatus
  {
    public extern DataPlanUsage DataPlanUsage { [MethodImpl] get; }

    public extern IReference<uint> DataLimitInMegabytes { [MethodImpl] get; }

    public extern IReference<ulong> InboundBitsPerSecond { [MethodImpl] get; }

    public extern IReference<ulong> OutboundBitsPerSecond { [MethodImpl] get; }

    public extern IReference<DateTime> NextBillingCycle { [MethodImpl] get; }

    public extern IReference<uint> MaxTransferSizeInMegabytes { [MethodImpl] get; }
  }
}
