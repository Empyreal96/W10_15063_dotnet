// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IActivitySensor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3447350028, 64351, 18667, 176, 155, 162, 112, 141, 28, 97, 239)]
  [ExclusiveTo(typeof (ActivitySensor))]
  internal interface IActivitySensor
  {
    [RemoteAsync]
    IAsyncOperation<ActivitySensorReading> GetCurrentReadingAsync();

    IVector<ActivityType> SubscribedActivities { get; }

    double PowerInMilliwatts { get; }

    string DeviceId { get; }

    IVectorView<ActivityType> SupportedActivities { get; }

    uint MinimumReportInterval { get; }

    event TypedEventHandler<ActivitySensor, ActivitySensorReadingChangedEventArgs> ReadingChanged;
  }
}
