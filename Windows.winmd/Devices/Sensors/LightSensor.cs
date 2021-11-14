// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.LightSensor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ILightSensorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class LightSensor : ILightSensor, ILightSensorDeviceId
  {
    [MethodImpl]
    public extern LightSensorReading GetCurrentReading();

    public extern uint MinimumReportInterval { [MethodImpl] get; }

    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<LightSensor, LightSensorReadingChangedEventArgs> ReadingChanged;

    public extern string DeviceId { [MethodImpl] get; }

    [MethodImpl]
    public static extern LightSensor GetDefault();
  }
}
