// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.IVoipPhoneCall
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [ExclusiveTo(typeof (VoipPhoneCall))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(1902531774, 10472, 18782, 182, 87, 128, 83, 7, 75, 65, 80)]
  internal interface IVoipPhoneCall
  {
    event TypedEventHandler<VoipPhoneCall, CallStateChangeEventArgs> EndRequested;

    event TypedEventHandler<VoipPhoneCall, CallStateChangeEventArgs> HoldRequested;

    event TypedEventHandler<VoipPhoneCall, CallStateChangeEventArgs> ResumeRequested;

    event TypedEventHandler<VoipPhoneCall, CallAnswerEventArgs> AnswerRequested;

    event TypedEventHandler<VoipPhoneCall, CallRejectEventArgs> RejectRequested;

    void NotifyCallHeld();

    void NotifyCallActive();

    void NotifyCallEnded();

    string ContactName { get; set; }

    DateTime StartTime { get; set; }

    VoipCallMedia CallMedia { get; set; }
  }
}
