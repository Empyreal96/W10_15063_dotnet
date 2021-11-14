// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattSessionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattSession))]
  [Guid(778418524, 21407, 19895, 130, 168, 115, 189, 187, 247, 62, 191)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattSessionStatics
  {
    [RemoteAsync]
    IAsyncOperation<GattSession> FromDeviceIdAsync(
      BluetoothDeviceId deviceId);
  }
}
