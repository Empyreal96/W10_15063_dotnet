// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Magnetometer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [Static(typeof (IMagnetometerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Magnetometer : IMagnetometer, IMagnetometerDeviceId, IMagnetometer2
  {
    [MethodImpl]
    public extern MagnetometerReading GetCurrentReading();

    public extern uint MinimumReportInterval { [MethodImpl] get; }

    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<Magnetometer, MagnetometerReadingChangedEventArgs> ReadingChanged;

    public extern string DeviceId { [MethodImpl] get; }

    public extern DisplayOrientations ReadingTransform { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public static extern Magnetometer GetDefault();
  }
}
