// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.SensorDataThresholdTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SensorDataThresholdTriggerDetails : ISensorDataThresholdTriggerDetails
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern SensorType SensorType { [MethodImpl] get; }
  }
}
