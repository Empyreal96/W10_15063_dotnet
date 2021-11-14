// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsMessageReceivedTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmsMessageReceivedTriggerDetails))]
  [Guid(735038420, 9815, 16680, 173, 95, 227, 135, 113, 50, 189, 177)]
  internal interface ISmsMessageReceivedTriggerDetails
  {
    SmsMessageType MessageType { get; }

    SmsTextMessage2 TextMessage { get; }

    SmsWapMessage WapMessage { get; }

    SmsAppMessage AppMessage { get; }

    SmsBroadcastMessage BroadcastMessage { get; }

    SmsVoicemailMessage VoicemailMessage { get; }

    SmsStatusMessage StatusMessage { get; }

    void Drop();

    void Accept();
  }
}
