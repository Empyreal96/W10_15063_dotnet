// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAltimeterReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(1885982839, 17517, 18423, 153, 140, 235, 194, 59, 69, 228, 162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AltimeterReadingChangedEventArgs))]
  internal interface IAltimeterReadingChangedEventArgs
  {
    AltimeterReading Reading { get; }
  }
}
