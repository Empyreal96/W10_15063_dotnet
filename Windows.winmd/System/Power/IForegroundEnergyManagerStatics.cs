// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.IForegroundEnergyManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  [ExclusiveTo(typeof (ForegroundEnergyManager))]
  [Guid(2683857010, 58999, 18452, 154, 32, 83, 55, 202, 115, 43, 152)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IForegroundEnergyManagerStatics
  {
    uint LowUsageLevel { get; }

    uint NearMaxAcceptableUsageLevel { get; }

    uint MaxAcceptableUsageLevel { get; }

    uint ExcessiveUsageLevel { get; }

    uint RecentEnergyUsage { get; }

    uint RecentEnergyUsageLevel { get; }

    event EventHandler<object> RecentEnergyUsageIncreased;

    event EventHandler<object> RecentEnergyUsageReturnedToLow;
  }
}
