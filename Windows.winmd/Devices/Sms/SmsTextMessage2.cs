// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsTextMessage2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmsTextMessage2 : ISmsTextMessage2, ISmsMessageBase
  {
    [MethodImpl]
    public extern SmsTextMessage2();

    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern string To { [MethodImpl] get; [MethodImpl] set; }

    public extern string From { [MethodImpl] get; }

    public extern string Body { [MethodImpl] get; [MethodImpl] set; }

    public extern SmsEncoding Encoding { [MethodImpl] get; [MethodImpl] set; }

    public extern string CallbackNumber { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDeliveryNotificationEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern int RetryAttemptCount { [MethodImpl] get; [MethodImpl] set; }

    public extern int TeleserviceId { [MethodImpl] get; }

    public extern int ProtocolId { [MethodImpl] get; }

    public extern SmsMessageType MessageType { [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }

    public extern CellularClass CellularClass { [MethodImpl] get; }

    public extern SmsMessageClass MessageClass { [MethodImpl] get; }

    public extern string SimIccId { [MethodImpl] get; }
  }
}
