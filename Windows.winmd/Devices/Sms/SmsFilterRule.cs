// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsFilterRule
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ISmsFilterRuleFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SmsFilterRule : ISmsFilterRule
  {
    [MethodImpl]
    public extern SmsFilterRule(SmsMessageType messageType);

    public extern SmsMessageType MessageType { [MethodImpl] get; }

    public extern IVector<string> ImsiPrefixes { [MethodImpl] get; }

    public extern IVector<string> DeviceIds { [MethodImpl] get; }

    public extern IVector<string> SenderNumbers { [MethodImpl] get; }

    public extern IVector<string> TextMessagePrefixes { [MethodImpl] get; }

    public extern IVector<int> PortNumbers { [MethodImpl] get; }

    public extern CellularClass CellularClass { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<int> ProtocolIds { [MethodImpl] get; }

    public extern IVector<int> TeleserviceIds { [MethodImpl] get; }

    public extern IVector<string> WapApplicationIds { [MethodImpl] get; }

    public extern IVector<string> WapContentTypes { [MethodImpl] get; }

    public extern IVector<SmsBroadcastType> BroadcastTypes { [MethodImpl] get; }

    public extern IVector<int> BroadcastChannels { [MethodImpl] get; }
  }
}
