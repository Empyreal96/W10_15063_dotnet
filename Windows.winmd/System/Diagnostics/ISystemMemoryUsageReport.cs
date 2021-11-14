// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ISystemMemoryUsageReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (SystemMemoryUsageReport))]
  [Guid(946224263, 10911, 16442, 189, 25, 44, 243, 232, 22, 149, 0)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISystemMemoryUsageReport
  {
    ulong TotalPhysicalSizeInBytes { get; }

    ulong AvailableSizeInBytes { get; }

    ulong CommittedSizeInBytes { get; }
  }
}
