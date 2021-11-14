// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsDevice2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ExclusiveTo(typeof (SmsDevice2))]
  [Guid(3179961363, 58658, 18123, 184, 213, 158, 173, 48, 251, 108, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsDevice2
  {
    string SmscAddress { get; set; }

    string DeviceId { get; }

    string ParentDeviceId { get; }

    string AccountPhoneNumber { get; }

    CellularClass CellularClass { get; }

    SmsDeviceStatus DeviceStatus { get; }

    SmsEncodedLength CalculateLength(ISmsMessageBase message);

    [RemoteAsync]
    IAsyncOperation<SmsSendMessageResult> SendMessageAndGetResultAsync(
      ISmsMessageBase message);

    event TypedEventHandler<SmsDevice2, object> DeviceStatusChanged;
  }
}
