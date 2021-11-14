// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristicUuidsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GattCharacteristicUuids))]
  [Guid(1492796806, 45534, 18188, 183, 222, 13, 17, 255, 68, 244, 183)]
  internal interface IGattCharacteristicUuidsStatics
  {
    Guid BatteryLevel { get; }

    Guid BloodPressureFeature { get; }

    Guid BloodPressureMeasurement { get; }

    Guid BodySensorLocation { get; }

    Guid CscFeature { get; }

    Guid CscMeasurement { get; }

    Guid GlucoseFeature { get; }

    Guid GlucoseMeasurement { get; }

    Guid GlucoseMeasurementContext { get; }

    Guid HeartRateControlPoint { get; }

    Guid HeartRateMeasurement { get; }

    Guid IntermediateCuffPressure { get; }

    Guid IntermediateTemperature { get; }

    Guid MeasurementInterval { get; }

    Guid RecordAccessControlPoint { get; }

    Guid RscFeature { get; }

    Guid RscMeasurement { get; }

    Guid SCControlPoint { get; }

    Guid SensorLocation { get; }

    Guid TemperatureMeasurement { get; }

    Guid TemperatureType { get; }
  }
}
