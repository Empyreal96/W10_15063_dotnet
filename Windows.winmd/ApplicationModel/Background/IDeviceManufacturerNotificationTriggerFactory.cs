// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceManufacturerNotificationTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceManufacturerNotificationTrigger))]
  [Guid(2035670645, 9659, 16723, 161, 162, 48, 41, 252, 171, 182, 82)]
  internal interface IDeviceManufacturerNotificationTriggerFactory
  {
    DeviceManufacturerNotificationTrigger Create(
      string triggerQualifier,
      bool oneShot);
  }
}
