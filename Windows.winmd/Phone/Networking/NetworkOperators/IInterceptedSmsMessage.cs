// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.NetworkOperators.IInterceptedSmsMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.NetworkOperators
{
  [Guid(1903416429, 65007, 18416, 130, 34, 34, 99, 22, 70, 50, 69)]
  [ExclusiveTo(typeof (InterceptedSmsMessage))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IInterceptedSmsMessage
  {
    string Body { get; }

    string SenderPhoneNumber { get; }

    string ProductId { get; }

    string SmsPrefix { get; }

    DateTime TimeStamp { get; }
  }
}
