// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.AltimeterReading
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
  [DualApiPartition(version = 167772160)]
  public sealed class AltimeterReading : IAltimeterReading
  {
    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern double AltitudeChangeInMeters { [MethodImpl] get; }
  }
}
