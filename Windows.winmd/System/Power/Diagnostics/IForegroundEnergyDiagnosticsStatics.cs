// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.Diagnostics.IForegroundEnergyDiagnosticsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(600443159, 52487, 17929, 190, 21, 143, 232, 148, 197, 228, 30)]
  [ExclusiveTo(typeof (ForegroundEnergyDiagnostics))]
  internal interface IForegroundEnergyDiagnosticsStatics
  {
    double DeviceSpecificConversionFactor { get; }

    ulong ComputeTotalEnergyUsage();

    void ResetTotalEnergyUsage();
  }
}
