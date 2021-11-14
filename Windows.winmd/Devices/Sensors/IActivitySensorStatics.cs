// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IActivitySensorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (ActivitySensor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2803764893, 61067, 17873, 178, 91, 8, 204, 13, 249, 42, 182)]
  internal interface IActivitySensorStatics
  {
    [RemoteAsync]
    IAsyncOperation<ActivitySensor> GetDefaultAsync();

    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<ActivitySensor> FromIdAsync(string deviceId);

    [Overload("GetSystemHistoryAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<ActivitySensorReading>> GetSystemHistoryAsync(
      DateTime fromTime);

    [Overload("GetSystemHistoryWithDurationAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<ActivitySensorReading>> GetSystemHistoryAsync(
      DateTime fromTime,
      TimeSpan duration);
  }
}
