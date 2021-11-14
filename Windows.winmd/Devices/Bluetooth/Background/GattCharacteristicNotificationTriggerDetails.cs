// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.GattCharacteristicNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Background
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattCharacteristicNotificationTriggerDetails : 
    IGattCharacteristicNotificationTriggerDetails,
    IGattCharacteristicNotificationTriggerDetails2
  {
    public extern GattCharacteristic Characteristic { [MethodImpl] get; }

    public extern IBuffer Value { [MethodImpl] get; }

    public extern BluetoothError Error { [MethodImpl] get; }

    public extern BluetoothEventTriggeringMode EventTriggeringMode { [MethodImpl] get; }

    public extern IVectorView<GattValueChangedEventArgs> ValueChangedEvents { [MethodImpl] get; }
  }
}
