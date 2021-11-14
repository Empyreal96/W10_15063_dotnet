// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalCharacteristicResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattLocalCharacteristicResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2037767835, 368, 17303, 150, 102, 146, 248, 99, 241, 46, 230)]
  internal interface IGattLocalCharacteristicResult
  {
    GattLocalCharacteristic Characteristic { get; }

    BluetoothError Error { get; }
  }
}
