// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsVoicemailMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(656056486, 38321, 17663, 188, 184, 184, 253, 215, 224, 139, 195)]
  [ExclusiveTo(typeof (SmsVoicemailMessage))]
  internal interface ISmsVoicemailMessage : ISmsMessageBase
  {
    DateTime Timestamp { get; }

    string To { get; }

    string Body { get; }

    IReference<int> MessageCount { get; }
  }
}
