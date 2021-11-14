// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IProximitySensorReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(1898089817, 4909, 19807, 143, 249, 47, 13, 184, 117, 28, 237)]
  [ExclusiveTo(typeof (ProximitySensorReading))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProximitySensorReading
  {
    DateTime Timestamp { get; }

    bool IsDetected { get; }

    IReference<uint> DistanceInMillimeters { get; }
  }
}
