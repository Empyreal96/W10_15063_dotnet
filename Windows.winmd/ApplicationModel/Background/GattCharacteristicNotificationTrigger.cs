// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.GattCharacteristicNotificationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Background;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Activatable(typeof (IGattCharacteristicNotificationTriggerFactory2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IGattCharacteristicNotificationTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class GattCharacteristicNotificationTrigger : 
    IGattCharacteristicNotificationTrigger,
    IBackgroundTrigger,
    IGattCharacteristicNotificationTrigger2
  {
    [MethodImpl]
    public extern GattCharacteristicNotificationTrigger(
      GattCharacteristic characteristic,
      BluetoothEventTriggeringMode eventTriggeringMode);

    [MethodImpl]
    public extern GattCharacteristicNotificationTrigger(GattCharacteristic characteristic);

    public extern GattCharacteristic Characteristic { [MethodImpl] get; }

    public extern BluetoothEventTriggeringMode EventTriggeringMode { [MethodImpl] get; }
  }
}
