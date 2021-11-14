// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsTextMessage2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmsTextMessage2))]
  [Guid(580966547, 17749, 18261, 181, 161, 231, 253, 132, 149, 95, 141)]
  internal interface ISmsTextMessage2 : ISmsMessageBase
  {
    DateTime Timestamp { get; }

    string To { get; set; }

    string From { get; }

    string Body { get; set; }

    SmsEncoding Encoding { get; set; }

    string CallbackNumber { get; set; }

    bool IsDeliveryNotificationEnabled { get; set; }

    int RetryAttemptCount { get; set; }

    int TeleserviceId { get; }

    int ProtocolId { get; }
  }
}
