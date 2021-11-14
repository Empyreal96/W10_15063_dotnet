// Decompiled with JetBrains decompiler
// Type: Windows.System.AppMemoryReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AppMemoryReport : IAppMemoryReport
  {
    public extern ulong PrivateCommitUsage { [MethodImpl] get; }

    public extern ulong PeakPrivateCommitUsage { [MethodImpl] get; }

    public extern ulong TotalCommitUsage { [MethodImpl] get; }

    public extern ulong TotalCommitLimit { [MethodImpl] get; }
  }
}
