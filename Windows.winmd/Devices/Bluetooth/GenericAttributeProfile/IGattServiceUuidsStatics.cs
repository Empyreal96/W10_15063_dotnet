// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceUuidsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1841655896, 39610, 17431, 184, 242, 220, 224, 22, 211, 78, 226)]
  [ExclusiveTo(typeof (GattServiceUuids))]
  internal interface IGattServiceUuidsStatics
  {
    Guid Battery { get; }

    Guid BloodPressure { get; }

    Guid CyclingSpeedAndCadence { get; }

    Guid GenericAccess { get; }

    Guid GenericAttribute { get; }

    Guid Glucose { get; }

    Guid HealthThermometer { get; }

    Guid HeartRate { get; }

    Guid RunningSpeedAndCadence { get; }
  }
}
