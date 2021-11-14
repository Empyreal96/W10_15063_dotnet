// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensorReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2745365711, 9611, 16908, 184, 171, 142, 221, 96, 30, 207, 80)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LightSensorReadingChangedEventArgs))]
  internal interface ILightSensorReadingChangedEventArgs
  {
    LightSensorReading Reading { get; }
  }
}
