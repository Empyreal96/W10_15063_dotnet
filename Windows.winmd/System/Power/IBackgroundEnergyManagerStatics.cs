// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.IBackgroundEnergyManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  [Guid(3004571029, 4480, 17270, 150, 225, 64, 149, 86, 129, 71, 206)]
  [ExclusiveTo(typeof (BackgroundEnergyManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundEnergyManagerStatics
  {
    uint LowUsageLevel { get; }

    uint NearMaxAcceptableUsageLevel { get; }

    uint MaxAcceptableUsageLevel { get; }

    uint ExcessiveUsageLevel { get; }

    uint NearTerminationUsageLevel { get; }

    uint TerminationUsageLevel { get; }

    uint RecentEnergyUsage { get; }

    uint RecentEnergyUsageLevel { get; }

    event EventHandler<object> RecentEnergyUsageIncreased;

    event EventHandler<object> RecentEnergyUsageReturnedToLow;
  }
}
