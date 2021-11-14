// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IProximitySensorReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3485660006, 50152, 16637, 140, 195, 103, 226, 137, 0, 73, 56)]
  [ExclusiveTo(typeof (ProximitySensorReadingChangedEventArgs))]
  internal interface IProximitySensorReadingChangedEventArgs
  {
    ProximitySensorReading Reading { get; }
  }
}
