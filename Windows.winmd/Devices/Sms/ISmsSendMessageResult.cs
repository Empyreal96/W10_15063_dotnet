// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsSendMessageResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(3675495154, 30921, 20459, 150, 34, 69, 35, 40, 8, 141, 98)]
  [ExclusiveTo(typeof (SmsSendMessageResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsSendMessageResult
  {
    bool IsSuccessful { get; }

    IVectorView<int> MessageReferenceNumbers { get; }

    CellularClass CellularClass { get; }

    SmsModemErrorCode ModemErrorCode { get; }

    bool IsErrorTransient { get; }

    int NetworkCauseCode { get; }

    int TransportFailureCause { get; }
  }
}
