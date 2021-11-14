// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsWapMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Sms
{
  [Guid(3448993603, 31317, 19771, 144, 33, 242, 46, 2, 45, 9, 197)]
  [ExclusiveTo(typeof (SmsWapMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsWapMessage : ISmsMessageBase
  {
    DateTime Timestamp { get; }

    string To { get; }

    string From { get; }

    string ApplicationId { get; }

    string ContentType { get; }

    IBuffer BinaryBody { get; }

    IMap<string, string> Headers { get; }
  }
}
