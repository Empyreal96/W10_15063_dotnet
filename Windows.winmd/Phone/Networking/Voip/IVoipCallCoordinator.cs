// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.IVoipCallCoordinator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(224343417, 63197, 19984, 159, 37, 61, 140, 145, 55, 110, 232)]
  [ExclusiveTo(typeof (VoipCallCoordinator))]
  internal interface IVoipCallCoordinator
  {
    event TypedEventHandler<VoipCallCoordinator, MuteChangeEventArgs> MuteRequested;

    event TypedEventHandler<VoipCallCoordinator, MuteChangeEventArgs> UnmuteRequested;

    void RequestNewIncomingCall(
      string context,
      string contactName,
      string contactNumber,
      Uri contactImage,
      string serviceName,
      Uri brandingImage,
      string callDetails,
      Uri ringtone,
      VoipCallMedia media,
      TimeSpan ringTimeout,
      out VoipPhoneCall call);

    void RequestNewOutgoingCall(
      string context,
      string contactName,
      string serviceName,
      VoipCallMedia media,
      out VoipPhoneCall call);

    void NotifyMuted();

    void NotifyUnmuted();
  }
}
