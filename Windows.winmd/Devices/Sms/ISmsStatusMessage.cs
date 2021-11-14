// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsStatusMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(3872555842, 46859, 18039, 147, 121, 201, 120, 63, 223, 248, 244)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmsStatusMessage))]
  internal interface ISmsStatusMessage : ISmsMessageBase
  {
    string To { get; }

    string From { get; }

    string Body { get; }

    int Status { get; }

    int MessageReferenceNumber { get; }

    DateTime ServiceCenterTimestamp { get; }

    DateTime DischargeTime { get; }
  }
}
