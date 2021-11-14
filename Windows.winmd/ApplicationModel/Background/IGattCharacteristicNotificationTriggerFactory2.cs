// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGattCharacteristicNotificationTriggerFactory2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.Background;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattCharacteristicNotificationTrigger))]
  [Guid(1503193375, 35411, 20127, 163, 44, 35, 205, 51, 102, 76, 238)]
  internal interface IGattCharacteristicNotificationTriggerFactory2
  {
    [Overload("CreateWithEventTriggeringMode")]
    GattCharacteristicNotificationTrigger Create(
      GattCharacteristic characteristic,
      BluetoothEventTriggeringMode eventTriggeringMode);
  }
}
