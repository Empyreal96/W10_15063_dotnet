// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Inclinometer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [Static(typeof (IInclinometerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IInclinometerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IInclinometerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class Inclinometer : IInclinometer, IInclinometerDeviceId, IInclinometer2
  {
    [MethodImpl]
    public extern InclinometerReading GetCurrentReading();

    public extern uint MinimumReportInterval { [MethodImpl] get; }

    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<Inclinometer, InclinometerReadingChangedEventArgs> ReadingChanged;

    public extern string DeviceId { [MethodImpl] get; }

    public extern DisplayOrientations ReadingTransform { [MethodImpl] set; [MethodImpl] get; }

    public extern SensorReadingType ReadingType { [MethodImpl] get; }

    [Overload("GetDefaultWithSensorReadingType")]
    [MethodImpl]
    public static extern Inclinometer GetDefault(SensorReadingType sensorReadingtype);

    [MethodImpl]
    public static extern Inclinometer GetDefaultForRelativeReadings();

    [MethodImpl]
    public static extern Inclinometer GetDefault();
  }
}
