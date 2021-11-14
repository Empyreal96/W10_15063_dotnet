// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IGattServiceProviderConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [ExclusiveTo(typeof (GattServiceProviderConnection))]
  [Guid(2141305273, 12051, 16565, 149, 130, 142, 183, 142, 152, 239, 19)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattServiceProviderConnection
  {
    string TriggerId { get; }

    GattLocalService Service { get; }

    void Start();
  }
}
