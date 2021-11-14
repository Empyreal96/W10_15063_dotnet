// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.OrientationSensorReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class OrientationSensorReading : 
    IOrientationSensorReading,
    IOrientationSensorReadingYawAccuracy
  {
    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern SensorRotationMatrix RotationMatrix { [MethodImpl] get; }

    public extern SensorQuaternion Quaternion { [MethodImpl] get; }

    public extern MagnetometerAccuracy YawAccuracy { [MethodImpl] get; }
  }
}
