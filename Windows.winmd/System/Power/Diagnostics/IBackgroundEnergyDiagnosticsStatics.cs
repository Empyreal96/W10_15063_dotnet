// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.Diagnostics.IBackgroundEnergyDiagnosticsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BackgroundEnergyDiagnostics))]
  [Guid(3613800194, 54182, 18144, 143, 155, 80, 185, 91, 180, 249, 197)]
  internal interface IBackgroundEnergyDiagnosticsStatics
  {
    double DeviceSpecificConversionFactor { get; }

    ulong ComputeTotalEnergyUsage();

    void ResetTotalEnergyUsage();
  }
}
