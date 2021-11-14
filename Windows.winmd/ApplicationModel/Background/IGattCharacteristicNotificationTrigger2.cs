// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGattCharacteristicNotificationTrigger2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (GattCharacteristicNotificationTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2468520644, 44558, 17138, 178, 140, 245, 19, 114, 230, 146, 69)]
  internal interface IGattCharacteristicNotificationTrigger2
  {
    BluetoothEventTriggeringMode EventTriggeringMode { get; }
  }
}
