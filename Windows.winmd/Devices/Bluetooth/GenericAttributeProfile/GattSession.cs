// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGattSessionStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class GattSession : IGattSession, IClosable
  {
    public extern BluetoothDeviceId DeviceId { [MethodImpl] get; }

    public extern bool CanMaintainConnection { [MethodImpl] get; }

    public extern bool MaintainConnection { [MethodImpl] set; [MethodImpl] get; }

    public extern ushort MaxPduSize { [MethodImpl] get; }

    public extern GattSessionStatus SessionStatus { [MethodImpl] get; }

    public extern event TypedEventHandler<GattSession, object> MaxPduSizeChanged;

    public extern event TypedEventHandler<GattSession, GattSessionStatusChangedEventArgs> SessionStatusChanged;

    [MethodImpl]
    public extern void Close();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GattSession> FromDeviceIdAsync(
      BluetoothDeviceId deviceId);
  }
}
