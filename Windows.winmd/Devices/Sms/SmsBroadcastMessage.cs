// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsBroadcastMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmsBroadcastMessage : ISmsBroadcastMessage, ISmsMessageBase
  {
    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern string To { [MethodImpl] get; }

    public extern string Body { [MethodImpl] get; }

    public extern int Channel { [MethodImpl] get; }

    public extern SmsGeographicalScope GeographicalScope { [MethodImpl] get; }

    public extern int MessageCode { [MethodImpl] get; }

    public extern int UpdateNumber { [MethodImpl] get; }

    public extern SmsBroadcastType BroadcastType { [MethodImpl] get; }

    public extern bool IsEmergencyAlert { [MethodImpl] get; }

    public extern bool IsUserPopupRequested { [MethodImpl] get; }

    public extern SmsMessageType MessageType { [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }

    public extern CellularClass CellularClass { [MethodImpl] get; }

    public extern SmsMessageClass MessageClass { [MethodImpl] get; }

    public extern string SimIccId { [MethodImpl] get; }
  }
}
