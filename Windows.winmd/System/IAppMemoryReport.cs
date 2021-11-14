// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppMemoryReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(1835348891, 19823, 17852, 156, 94, 228, 155, 63, 242, 117, 141)]
  [ExclusiveTo(typeof (AppMemoryReport))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppMemoryReport
  {
    ulong PrivateCommitUsage { get; }

    ulong PeakPrivateCommitUsage { get; }

    ulong TotalCommitUsage { get; }

    ulong TotalCommitLimit { get; }
  }
}
