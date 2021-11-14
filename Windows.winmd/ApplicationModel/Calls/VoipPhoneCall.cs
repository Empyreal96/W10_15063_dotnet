// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.VoipPhoneCall
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  [WebHostHidden]
  public sealed class VoipPhoneCall : IVoipPhoneCall
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

    public extern VoipPhoneCallMedia CallMedia { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void NotifyCallReady();
  }
}
