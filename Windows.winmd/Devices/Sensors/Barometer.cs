// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Barometer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBarometerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Barometer : IBarometer
  {
    [MethodImpl]
    public extern BarometerReading GetCurrentReading();

    public extern string DeviceId { [MethodImpl] get; }

    public extern uint MinimumReportInterval { [MethodImpl] get; }

    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<Barometer, BarometerReadingChangedEventArgs> ReadingChanged;

    [MethodImpl]
    public static extern Barometer GetDefault();
  }
}
