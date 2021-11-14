// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometerReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3017203292, 7908, 17775, 157, 231, 226, 73, 59, 92, 142, 3)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GyrometerReading))]
  internal interface IGyrometerReading
  {
    DateTime Timestamp { get; }

    double AngularVelocityX { get; }

    double AngularVelocityY { get; }

    double AngularVelocityZ { get; }
  }
}
