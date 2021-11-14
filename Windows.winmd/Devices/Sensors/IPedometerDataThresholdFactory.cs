// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometerDataThresholdFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3417149264, 31316, 18027, 144, 16, 119, 161, 98, 252, 165, 215)]
  [ExclusiveTo(typeof (PedometerDataThreshold))]
  internal interface IPedometerDataThresholdFactory
  {
    PedometerDataThreshold Create(Pedometer sensor, int stepGoal);
  }
}
