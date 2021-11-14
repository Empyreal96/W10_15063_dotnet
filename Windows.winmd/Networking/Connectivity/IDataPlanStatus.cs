// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IDataPlanStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Guid(2541390732, 14469, 16627, 136, 81, 66, 205, 43, 213, 104, 187)]
  [ExclusiveTo(typeof (DataPlanStatus))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataPlanStatus
  {
    DataPlanUsage DataPlanUsage { get; }

    IReference<uint> DataLimitInMegabytes { get; }

    IReference<ulong> InboundBitsPerSecond { get; }

    IReference<ulong> OutboundBitsPerSecond { get; }

    IReference<DateTime> NextBillingCycle { get; }

    IReference<uint> MaxTransferSizeInMegabytes { get; }
  }
}
