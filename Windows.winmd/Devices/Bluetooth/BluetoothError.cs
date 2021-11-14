// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothError
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BluetoothError
  {
    Success,
    RadioNotAvailable,
    ResourceInUse,
    DeviceNotConnected,
    OtherError,
    DisabledByPolicy,
    NotSupported,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] DisabledByUser,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ConsentRequired,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] TransportNotSupported,
  }
}
