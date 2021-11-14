// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.SensorRotationMatrix
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SensorRotationMatrix : ISensorRotationMatrix
  {
    public extern float M11 { [MethodImpl] get; }

    public extern float M12 { [MethodImpl] get; }

    public extern float M13 { [MethodImpl] get; }

    public extern float M21 { [MethodImpl] get; }

    public extern float M22 { [MethodImpl] get; }

    public extern float M23 { [MethodImpl] get; }

    public extern float M31 { [MethodImpl] get; }

    public extern float M32 { [MethodImpl] get; }

    public extern float M33 { [MethodImpl] get; }
  }
}
