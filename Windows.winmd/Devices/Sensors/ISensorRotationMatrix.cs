// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISensorRotationMatrix
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SensorRotationMatrix))]
  [Guid(171792999, 8948, 17298, 149, 56, 101, 208, 189, 6, 74, 166)]
  internal interface ISensorRotationMatrix
  {
    float M11 { get; }

    float M12 { get; }

    float M13 { get; }

    float M21 { get; }

    float M22 { get; }

    float M23 { get; }

    float M31 { get; }

    float M32 { get; }

    float M33 { get; }
  }
}
