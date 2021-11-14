// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsSendMessageResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmsSendMessageResult : ISmsSendMessageResult
  {
    public extern bool IsSuccessful { [MethodImpl] get; }

    public extern IVectorView<int> MessageReferenceNumbers { [MethodImpl] get; }

    public extern CellularClass CellularClass { [MethodImpl] get; }

    public extern SmsModemErrorCode ModemErrorCode { [MethodImpl] get; }

    public extern bool IsErrorTransient { [MethodImpl] get; }

    public extern int NetworkCauseCode { [MethodImpl] get; }

    public extern int TransportFailureCause { [MethodImpl] get; }
  }
}
