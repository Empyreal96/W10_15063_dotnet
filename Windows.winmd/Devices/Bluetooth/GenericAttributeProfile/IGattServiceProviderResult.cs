// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceProviderResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(1984337624, 50494, 17036, 138, 72, 103, 175, 224, 44, 58, 230)]
  [ExclusiveTo(typeof (GattServiceProviderResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattServiceProviderResult
  {
    BluetoothError Error { get; }

    GattServiceProvider ServiceProvider { get; }
  }
}
