// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.CustomSensor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICustomSensorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CustomSensor : ICustomSensor
  {
    [MethodImpl]
    public extern CustomSensorReading GetCurrentReading();

    public extern uint MinimumReportInterval { [MethodImpl] get; }

    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }

    public extern event TypedEventHandler<CustomSensor, CustomSensorReadingChangedEventArgs> ReadingChanged;

    [MethodImpl]
    public static extern string GetDeviceSelector(Guid interfaceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CustomSensor> FromIdAsync(
      string sensorId);
  }
}
