// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ConnectionProfileFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Connectivity
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ConnectionProfileFilter : IConnectionProfileFilter, IConnectionProfileFilter2
  {
    [MethodImpl]
    public extern ConnectionProfileFilter();

    public extern bool IsConnected { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsWwanConnectionProfile { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsWlanConnectionProfile { [MethodImpl] set; [MethodImpl] get; }

    public extern NetworkCostType NetworkCostType { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Guid> ServiceProviderGuid { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<bool> IsRoaming { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<bool> IsOverDataLimit { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<bool> IsBackgroundDataUsageRestricted { [MethodImpl] set; [MethodImpl] get; }

    public extern IBuffer RawData { [MethodImpl] get; }
  }
}
