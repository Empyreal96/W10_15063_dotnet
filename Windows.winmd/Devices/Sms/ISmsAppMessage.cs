// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsAppMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmsAppMessage))]
  [Guid(3904603284, 54176, 18954, 134, 215, 41, 16, 51, 168, 207, 84)]
  internal interface ISmsAppMessage : ISmsMessageBase
  {
    DateTime Timestamp { get; }

    string To { get; set; }

    string From { get; }

    string Body { get; set; }

    string CallbackNumber { get; set; }

    bool IsDeliveryNotificationEnabled { get; set; }

    int RetryAttemptCount { get; set; }

    SmsEncoding Encoding { get; set; }

    int PortNumber { get; set; }

    int TeleserviceId { get; set; }

    int ProtocolId { get; set; }

    IBuffer BinaryBody { get; set; }
  }
}
