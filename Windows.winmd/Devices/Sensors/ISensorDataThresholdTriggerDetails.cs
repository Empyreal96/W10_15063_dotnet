// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISensorDataThresholdTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2433151415, 59533, 18609, 188, 144, 97, 156, 123, 52, 147, 145)]
  [ExclusiveTo(typeof (SensorDataThresholdTriggerDetails))]
  internal interface ISensorDataThresholdTriggerDetails
  {
    string DeviceId { get; }

    SensorType SensorType { get; }
  }
}
