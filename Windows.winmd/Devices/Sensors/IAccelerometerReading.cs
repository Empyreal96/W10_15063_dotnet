// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometerReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (AccelerometerReading))]
  [Guid(3120462539, 54097, 16559, 139, 182, 122, 169, 174, 100, 31, 183)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAccelerometerReading
  {
    DateTime Timestamp { get; }

    double AccelerationX { get; }

    double AccelerationY { get; }

    double AccelerationZ { get; }
  }
}
