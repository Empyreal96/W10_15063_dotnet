// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IVoipPhoneCall
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (VoipPhoneCall))]
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  [Guid(1827795354, 30612, 19034, 140, 104, 174, 135, 148, 122, 105, 144)]
  [WebHostHidden]
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

    VoipPhoneCallMedia CallMedia { get; set; }

    void NotifyCallReady();
  }
}
