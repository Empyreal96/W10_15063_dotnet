// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.ForegroundEnergyManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  [Static(typeof (IForegroundEnergyManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class ForegroundEnergyManager
  {
    public static extern uint LowUsageLevel { [MethodImpl] get; }

    public static extern uint NearMaxAcceptableUsageLevel { [MethodImpl] get; }

    public static extern uint MaxAcceptableUsageLevel { [MethodImpl] get; }

    public static extern uint ExcessiveUsageLevel { [MethodImpl] get; }

    public static extern uint RecentEnergyUsage { [MethodImpl] get; }

    public static extern uint RecentEnergyUsageLevel { [MethodImpl] get; }

    public static extern event EventHandler<object> RecentEnergyUsageIncreased;

    public static extern event EventHandler<object> RecentEnergyUsageReturnedToLow;
  }
}
