// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IGattCharacteristicNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GattCharacteristicNotificationTriggerDetails))]
  [Guid(2610969368, 4076, 17258, 147, 177, 244, 108, 105, 117, 50, 162)]
  internal interface IGattCharacteristicNotificationTriggerDetails
  {
    GattCharacteristic Characteristic { get; }

    IBuffer Value { get; }
  }
}
