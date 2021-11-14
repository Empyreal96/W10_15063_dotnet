// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometerReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4166378622, 43964, 17494, 134, 168, 37, 207, 43, 51, 55, 66)]
  [ExclusiveTo(typeof (PedometerReadingChangedEventArgs))]
  internal interface IPedometerReadingChangedEventArgs
  {
    PedometerReading Reading { get; }
  }
}
