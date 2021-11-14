// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ProximitySensor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IProximitySensorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IProximitySensorStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class ProximitySensor : IProximitySensor
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern IReference<uint> MaxDistanceInMillimeters { [MethodImpl] get; }

    public extern IReference<uint> MinDistanceInMillimeters { [MethodImpl] get; }

    [MethodImpl]
    public extern ProximitySensorReading GetCurrentReading();

    public extern event TypedEventHandler<ProximitySensor, ProximitySensorReadingChangedEventArgs> ReadingChanged;

    [MethodImpl]
    public extern ProximitySensorDisplayOnOffController CreateDisplayOnOffController();

    [MethodImpl]
    public static extern IVectorView<ProximitySensorReading> GetReadingsFromTriggerDetails(
      SensorDataThresholdTriggerDetails triggerDetails);

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [MethodImpl]
    public static extern ProximitySensor FromId(string sensorId);
  }
}
