// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IBarometerReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (BarometerReadingChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1032098911, 891, 16463, 155, 187, 98, 50, 214, 149, 67, 195)]
  internal interface IBarometerReadingChangedEventArgs
  {
    BarometerReading Reading { get; }
  }
}
