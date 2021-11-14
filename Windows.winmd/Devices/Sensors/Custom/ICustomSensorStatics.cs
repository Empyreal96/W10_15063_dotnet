// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.ICustomSensorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  [ExclusiveTo(typeof (CustomSensor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2569032399, 62498, 19581, 131, 107, 231, 220, 116, 167, 18, 75)]
  internal interface ICustomSensorStatics
  {
    string GetDeviceSelector(Guid interfaceId);

    [RemoteAsync]
    IAsyncOperation<CustomSensor> FromIdAsync(string sensorId);
  }
}
