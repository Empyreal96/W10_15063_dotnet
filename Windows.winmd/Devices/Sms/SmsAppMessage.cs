// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsAppMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmsAppMessage : ISmsAppMessage, ISmsMessageBase
  {
    [MethodImpl]
    public extern SmsAppMessage();

    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern string To { [MethodImpl] get; [MethodImpl] set; }

    public extern string From { [MethodImpl] get; }

    public extern string Body { [MethodImpl] get; [MethodImpl] set; }

    public extern string CallbackNumber { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDeliveryNotificationEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern int RetryAttemptCount { [MethodImpl] get; [MethodImpl] set; }

    public extern SmsEncoding Encoding { [MethodImpl] get; [MethodImpl] set; }

    public extern int PortNumber { [MethodImpl] get; [MethodImpl] set; }

    public extern int TeleserviceId { [MethodImpl] get; [MethodImpl] set; }

    public extern int ProtocolId { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer BinaryBody { [MethodImpl] get; [MethodImpl] set; }

    public extern SmsMessageType MessageType { [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }

    public extern CellularClass CellularClass { [MethodImpl] get; }

    public extern SmsMessageClass MessageClass { [MethodImpl] get; }

    public extern string SimIccId { [MethodImpl] get; }
  }
}
