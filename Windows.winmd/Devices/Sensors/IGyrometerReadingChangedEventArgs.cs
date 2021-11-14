// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometerReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (GyrometerReadingChangedEventArgs))]
  [Guid(266279061, 28574, 17102, 141, 88, 56, 140, 10, 184, 53, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGyrometerReadingChangedEventArgs
  {
    GyrometerReading Reading { get; }
  }
}
