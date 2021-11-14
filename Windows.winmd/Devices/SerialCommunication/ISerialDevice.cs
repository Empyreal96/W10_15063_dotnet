// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.ISerialDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SerialCommunication
{
  [Guid(3783773382, 8720, 16719, 182, 90, 245, 85, 58, 3, 55, 42)]
  [ExclusiveTo(typeof (SerialDevice))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISerialDevice : IClosable
  {
    uint BaudRate { get; set; }

    bool BreakSignalState { get; set; }

    uint BytesReceived { get; }

    bool CarrierDetectState { get; }

    bool ClearToSendState { get; }

    ushort DataBits { get; set; }

    bool DataSetReadyState { get; }

    SerialHandshake Handshake { get; set; }

    bool IsDataTerminalReadyEnabled { get; set; }

    bool IsRequestToSendEnabled { get; set; }

    SerialParity Parity { get; set; }

    string PortName { get; }

    TimeSpan ReadTimeout { get; set; }

    SerialStopBitCount StopBits { get; set; }

    ushort UsbVendorId { get; }

    ushort UsbProductId { get; }

    TimeSpan WriteTimeout { get; set; }

    IInputStream InputStream { get; }

    IOutputStream OutputStream { get; }

    event TypedEventHandler<SerialDevice, ErrorReceivedEventArgs> ErrorReceived;

    event TypedEventHandler<SerialDevice, PinChangedEventArgs> PinChanged;
  }
}
