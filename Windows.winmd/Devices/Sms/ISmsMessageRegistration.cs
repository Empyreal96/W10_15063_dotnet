// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsMessageRegistration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(387993662, 62287, 17515, 131, 179, 15, 241, 153, 35, 180, 9)]
  [ExclusiveTo(typeof (SmsMessageRegistration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsMessageRegistration
  {
    string Id { get; }

    void Unregister();

    event TypedEventHandler<SmsMessageRegistration, SmsMessageReceivedTriggerDetails> MessageReceived;
  }
}
