// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.Diagnostics.BackgroundEnergyDiagnostics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBackgroundEnergyDiagnosticsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class BackgroundEnergyDiagnostics
  {
    public static extern double DeviceSpecificConversionFactor { [MethodImpl] get; }

    [MethodImpl]
    public static extern ulong ComputeTotalEnergyUsage();

    [MethodImpl]
    public static extern void ResetTotalEnergyUsage();
  }
}
