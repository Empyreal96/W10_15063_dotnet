// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Altimeter
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
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IAltimeterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Altimeter : IAltimeter
  {
    [MethodImpl]
    public extern AltimeterReading GetCurrentReading();

    public extern string DeviceId { [MethodImpl] get; }

    public extern uint MinimumReportInterval { [MethodImpl] get; }

    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<Altimeter, AltimeterReadingChangedEventArgs> ReadingChanged;

    [MethodImpl]
    public static extern Altimeter GetDefault();
  }
}
