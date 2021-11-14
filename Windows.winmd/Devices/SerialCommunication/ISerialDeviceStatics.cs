// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.ISerialDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SerialCommunication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SerialDevice))]
  [Guid(93080176, 2102, 18835, 174, 26, 182, 26, 227, 190, 5, 107)]
  internal interface ISerialDeviceStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("GetDeviceSelectorFromPortName")]
    string GetDeviceSelector(string portName);

    string GetDeviceSelectorFromUsbVidPid(ushort vendorId, ushort productId);

    [RemoteAsync]
    IAsyncOperation<SerialDevice> FromIdAsync(string deviceId);
  }
}
