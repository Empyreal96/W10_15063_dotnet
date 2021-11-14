// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IActivitySensorTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (ActivitySensorTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2804322755, 14391, 17655, 131, 27, 1, 50, 204, 135, 43, 195)]
  internal interface IActivitySensorTriggerFactory
  {
    ActivitySensorTrigger Create(uint reportIntervalInMilliseconds);
  }
}
