// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Accelerometer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IAccelerometerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAccelerometerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Accelerometer : 
    IAccelerometer,
    IAccelerometerDeviceId,
    IAccelerometer2,
    IAccelerometer3,
    IAccelerometer4
  {
    [MethodImpl]
    public extern AccelerometerReading GetCurrentReading();

    public extern uint MinimumReportInterval { [MethodImpl] get; }

    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs> ReadingChanged;

    public extern event TypedEventHandler<Accelerometer, AccelerometerShakenEventArgs> Shaken;

    public extern string DeviceId { [MethodImpl] get; }

    public extern DisplayOrientations ReadingTransform { [MethodImpl] set; [MethodImpl] get; }

    public extern uint ReportLatency { [MethodImpl] set; [MethodImpl] get; }

    public extern uint MaxBatchSize { [MethodImpl] get; }

    public extern AccelerometerReadingType ReadingType { [MethodImpl] get; }

    [Overload("GetDefaultWithAccelerometerReadingType")]
    [MethodImpl]
    public static extern Accelerometer GetDefault(AccelerometerReadingType readingType);

    [Overload("GetDefault")]
    [MethodImpl]
    public static extern Accelerometer GetDefault();
  }
}
