// Decompiled with JetBrains decompiler
// Type: Windows.System.MemoryManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Static(typeof (IMemoryManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMemoryManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMemoryManagerStatics3), 131072, "Windows.Foundation.UniversalApiContract")]
  public static class MemoryManager
  {
    [MethodImpl]
    public static extern bool TrySetAppMemoryUsageLimit(ulong value);

    [MethodImpl]
    public static extern AppMemoryReport GetAppMemoryReport();

    [MethodImpl]
    public static extern ProcessMemoryReport GetProcessMemoryReport();

    public static extern ulong AppMemoryUsage { [MethodImpl] get; }

    public static extern ulong AppMemoryUsageLimit { [MethodImpl] get; }

    public static extern AppMemoryUsageLevel AppMemoryUsageLevel { [MethodImpl] get; }

    public static extern event EventHandler<object> AppMemoryUsageIncreased;

    public static extern event EventHandler<object> AppMemoryUsageDecreased;

    public static extern event EventHandler<AppMemoryUsageLimitChangingEventArgs> AppMemoryUsageLimitChanging;
  }
}
