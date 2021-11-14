// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometer3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2279604778, 60800, 18923, 191, 138, 164, 234, 49, 229, 205, 132)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Accelerometer))]
  internal interface IAccelerometer3
  {
    uint ReportLatency { set; get; }

    uint MaxBatchSize { get; }
  }
}
