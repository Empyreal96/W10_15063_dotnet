// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.SerialDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SerialCommunication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISerialDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class SerialDevice : ISerialDevice, IClosable
  {
    public extern uint BaudRate { [MethodImpl] get; [MethodImpl] set; }

    public extern bool BreakSignalState { [MethodImpl] get; [MethodImpl] set; }

    public extern uint BytesReceived { [MethodImpl] get; }

    public extern bool CarrierDetectState { [MethodImpl] get; }

    public extern bool ClearToSendState { [MethodImpl] get; }

    public extern ushort DataBits { [MethodImpl] get; [MethodImpl] set; }

    public extern bool DataSetReadyState { [MethodImpl] get; }

    public extern SerialHandshake Handshake { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDataTerminalReadyEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsRequestToSendEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern SerialParity Parity { [MethodImpl] get; [MethodImpl] set; }

    public extern string PortName { [MethodImpl] get; }

    public extern TimeSpan ReadTimeout { [MethodImpl] get; [MethodImpl] set; }

    public extern SerialStopBitCount StopBits { [MethodImpl] get; [MethodImpl] set; }

    public extern ushort UsbVendorId { [MethodImpl] get; }

    public extern ushort UsbProductId { [MethodImpl] get; }

    public extern TimeSpan WriteTimeout { [MethodImpl] get; [MethodImpl] set; }

    public extern IInputStream InputStream { [MethodImpl] get; }

    public extern IOutputStream OutputStream { [MethodImpl] get; }

    public extern event TypedEventHandler<SerialDevice, ErrorReceivedEventArgs> ErrorReceived;

    public extern event TypedEventHandler<SerialDevice, PinChangedEventArgs> PinChanged;

    [MethodImpl]
    public extern void Close();

    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector();

    [Overload("GetDeviceSelectorFromPortName")]
    [MethodImpl]
    public static extern string GetDeviceSelector(string portName);

    [MethodImpl]
    public static extern string GetDeviceSelectorFromUsbVidPid(ushort vendorId, ushort productId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SerialDevice> FromIdAsync(
      string deviceId);
  }
}
