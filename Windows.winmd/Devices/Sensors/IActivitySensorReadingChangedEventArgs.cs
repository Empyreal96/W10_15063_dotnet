// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IActivitySensorReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3728238359, 44726, 20167, 148, 106, 217, 204, 25, 185, 81, 236)]
  [ExclusiveTo(typeof (ActivitySensorReadingChangedEventArgs))]
  internal interface IActivitySensorReadingChangedEventArgs
  {
    ActivitySensorReading Reading { get; }
  }
}
