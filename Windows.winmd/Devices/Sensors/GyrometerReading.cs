// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.GyrometerReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  public sealed class GyrometerReading : IGyrometerReading
  {
    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern double AngularVelocityX { [MethodImpl] get; }

    public extern double AngularVelocityY { [MethodImpl] get; }

    public extern double AngularVelocityZ { [MethodImpl] get; }
  }
}
