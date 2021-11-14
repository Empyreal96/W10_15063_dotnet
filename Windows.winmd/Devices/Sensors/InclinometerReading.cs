// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.InclinometerReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  public sealed class InclinometerReading : IInclinometerReading, IInclinometerReadingYawAccuracy
  {
    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern float PitchDegrees { [MethodImpl] get; }

    public extern float RollDegrees { [MethodImpl] get; }

    public extern float YawDegrees { [MethodImpl] get; }

    public extern MagnetometerAccuracy YawAccuracy { [MethodImpl] get; }
  }
}
