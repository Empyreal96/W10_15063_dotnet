// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.DataPlanUsage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DataPlanUsage : IDataPlanUsage
  {
    public extern uint MegabytesUsed { [MethodImpl] get; }

    public extern DateTime LastSyncTime { [MethodImpl] get; }
  }
}
