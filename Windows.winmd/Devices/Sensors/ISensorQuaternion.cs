// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISensorQuaternion
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3385182247, 50972, 18151, 157, 163, 54, 161, 147, 178, 50, 188)]
  [ExclusiveTo(typeof (SensorQuaternion))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISensorQuaternion
  {
    float W { get; }

    float X { get; }

    float Y { get; }

    float Z { get; }
  }
}
