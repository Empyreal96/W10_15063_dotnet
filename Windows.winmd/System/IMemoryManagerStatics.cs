// Decompiled with JetBrains decompiler
// Type: Windows.System.IMemoryManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MemoryManager))]
  [Guid(1550591900, 55242, 18297, 145, 136, 64, 87, 33, 156, 230, 76)]
  internal interface IMemoryManagerStatics
  {
    ulong AppMemoryUsage { get; }

    ulong AppMemoryUsageLimit { get; }

    AppMemoryUsageLevel AppMemoryUsageLevel { get; }

    event EventHandler<object> AppMemoryUsageIncreased;

    event EventHandler<object> AppMemoryUsageDecreased;

    event EventHandler<AppMemoryUsageLimitChangingEventArgs> AppMemoryUsageLimitChanging;
  }
}
