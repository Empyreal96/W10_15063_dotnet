// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalDescriptorParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(1608441450, 62401, 19302, 140, 75, 227, 210, 41, 59, 64, 233)]
  [ExclusiveTo(typeof (GattLocalDescriptorParameters))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattLocalDescriptorParameters
  {
    IBuffer StaticValue { set; get; }

    GattProtectionLevel ReadProtectionLevel { set; get; }

    GattProtectionLevel WriteProtectionLevel { set; get; }
  }
}
