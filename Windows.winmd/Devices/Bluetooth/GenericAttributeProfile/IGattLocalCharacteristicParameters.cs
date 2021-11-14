// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalCharacteristicParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4210507188, 19711, 17607, 132, 69, 4, 14, 110, 173, 0, 99)]
  [ExclusiveTo(typeof (GattLocalCharacteristicParameters))]
  internal interface IGattLocalCharacteristicParameters
  {
    IBuffer StaticValue { set; get; }

    GattCharacteristicProperties CharacteristicProperties { set; get; }

    GattProtectionLevel ReadProtectionLevel { set; get; }

    GattProtectionLevel WriteProtectionLevel { set; get; }

    string UserDescription { set; get; }

    IVector<GattPresentationFormat> PresentationFormats { get; }
  }
}
