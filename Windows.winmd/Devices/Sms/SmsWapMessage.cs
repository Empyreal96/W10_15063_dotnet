// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsWapMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Sms
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmsWapMessage : ISmsWapMessage, ISmsMessageBase
  {
    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern string To { [MethodImpl] get; }

    public extern string From { [MethodImpl] get; }

    public extern string ApplicationId { [MethodImpl] get; }

    public extern string ContentType { [MethodImpl] get; }

    public extern IBuffer BinaryBody { [MethodImpl] get; }

    public extern IMap<string, string> Headers { [MethodImpl] get; }

    public extern SmsMessageType MessageType { [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }

    public extern CellularClass CellularClass { [MethodImpl] get; }

    public extern SmsMessageClass MessageClass { [MethodImpl] get; }

    public extern string SimIccId { [MethodImpl] get; }
  }
}
