// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsMessageReceivedTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmsMessageReceivedTriggerDetails : ISmsMessageReceivedTriggerDetails
  {
    public extern SmsMessageType MessageType { [MethodImpl] get; }

    public extern SmsTextMessage2 TextMessage { [MethodImpl] get; }

    public extern SmsWapMessage WapMessage { [MethodImpl] get; }

    public extern SmsAppMessage AppMessage { [MethodImpl] get; }

    public extern SmsBroadcastMessage BroadcastMessage { [MethodImpl] get; }

    public extern SmsVoicemailMessage VoicemailMessage { [MethodImpl] get; }

    public extern SmsStatusMessage StatusMessage { [MethodImpl] get; }

    [MethodImpl]
    public extern void Drop();

    [MethodImpl]
    public extern void Accept();
  }
}
