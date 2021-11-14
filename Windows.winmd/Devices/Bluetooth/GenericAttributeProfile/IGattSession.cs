// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattSession))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3527102787, 57422, 19492, 153, 156, 156, 37, 111, 152, 86, 177)]
  internal interface IGattSession
  {
    BluetoothDeviceId DeviceId { get; }

    bool CanMaintainConnection { get; }

    bool MaintainConnection { set; get; }

    ushort MaxPduSize { get; }

    GattSessionStatus SessionStatus { get; }

    event TypedEventHandler<GattSession, object> MaxPduSizeChanged;

    event TypedEventHandler<GattSession, GattSessionStatusChangedEventArgs> SessionStatusChanged;
  }
}
