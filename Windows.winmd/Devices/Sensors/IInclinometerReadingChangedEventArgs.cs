// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(1256791489, 59371, 18744, 133, 17, 174, 13, 107, 68, 4, 56)]
  [ExclusiveTo(typeof (InclinometerReadingChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInclinometerReadingChangedEventArgs
  {
    InclinometerReading Reading { get; }
  }
}
