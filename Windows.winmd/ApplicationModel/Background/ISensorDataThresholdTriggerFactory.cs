// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISensorDataThresholdTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (SensorDataThresholdTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2451564149, 32240, 19875, 151, 179, 229, 68, 238, 133, 127, 230)]
  internal interface ISensorDataThresholdTriggerFactory
  {
    SensorDataThresholdTrigger Create(ISensorDataThreshold threshold);
  }
}
