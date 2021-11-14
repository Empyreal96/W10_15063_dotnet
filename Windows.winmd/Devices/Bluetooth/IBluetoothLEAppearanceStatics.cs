// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEAppearanceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothLEAppearance))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2710814919, 17668, 20298, 155, 165, 205, 16, 84, 229, 224, 101)]
  internal interface IBluetoothLEAppearanceStatics
  {
    BluetoothLEAppearance FromRawValue(ushort rawValue);

    BluetoothLEAppearance FromParts(
      ushort appearanceCategory,
      ushort appearanceSubCategory);
  }
}
