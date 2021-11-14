// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IGattCharacteristicNotificationTriggerDetails2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattCharacteristicNotificationTriggerDetails))]
  [Guid(1920618716, 38045, 17738, 177, 146, 152, 52, 103, 227, 213, 15)]
  internal interface IGattCharacteristicNotificationTriggerDetails2
  {
    BluetoothError Error { get; }

    BluetoothEventTriggeringMode EventTriggeringMode { get; }

    IVectorView<GattValueChangedEventArgs> ValueChangedEvents { get; }
  }
}
