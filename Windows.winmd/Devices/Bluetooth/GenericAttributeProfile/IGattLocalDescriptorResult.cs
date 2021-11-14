// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalDescriptorResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(928485822, 12831, 17254, 191, 193, 59, 198, 184, 44, 121, 248)]
  [ExclusiveTo(typeof (GattLocalDescriptorResult))]
  internal interface IGattLocalDescriptorResult
  {
    GattLocalDescriptor Descriptor { get; }

    BluetoothError Error { get; }
  }
}
