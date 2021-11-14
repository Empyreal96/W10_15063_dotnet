// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.VoipPhoneCall
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VoipPhoneCall : IVoipPhoneCall, IVoipPhoneCallReady
  {
    public extern event TypedEventHandler<VoipPhoneCall, CallStateChangeEventArgs> EndRequested;

    public extern event TypedEventHandler<VoipPhoneCall, CallStateChangeEventArgs> HoldRequested;

    public extern event TypedEventHandler<VoipPhoneCall, CallStateChangeEventArgs> ResumeRequested;

    public extern event TypedEventHandler<VoipPhoneCall, CallAnswerEventArgs> AnswerRequested;

    public extern event TypedEventHandler<VoipPhoneCall, CallRejectEventArgs> RejectRequested;

    [MethodImpl]
    public extern void NotifyCallHeld();

    [MethodImpl]
    public extern void NotifyCallActive();

    [MethodImpl]
    public extern void NotifyCallEnded();

    public extern string ContactName { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime StartTime { [MethodImpl] get; [MethodImpl] set; }

    public extern VoipCallMedia CallMedia { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void NotifyCallReady();
  }
}
