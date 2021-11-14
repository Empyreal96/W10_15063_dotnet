// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IVoipCallCoordinator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Guid(1326549967, 59631, 17460, 156, 95, 168, 216, 147, 250, 254, 121)]
  [ExclusiveTo(typeof (VoipCallCoordinator))]
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  [WebHostHidden]
  internal interface IVoipCallCoordinator
  {
    [RemoteAsync]
    IAsyncOperation<VoipPhoneCallResourceReservationStatus> ReserveCallResourcesAsync(
      string taskEntryPoint);

    event TypedEventHandler<VoipCallCoordinator, MuteChangeEventArgs> MuteStateChanged;

    VoipPhoneCall RequestNewIncomingCall(
      string context,
      string contactName,
      string contactNumber,
      global::Windows.Foundation.Uri contactImage,
      string serviceName,
      global::Windows.Foundation.Uri brandingImage,
      string callDetails,
      global::Windows.Foundation.Uri ringtone,
      VoipPhoneCallMedia media,
      global::Windows.Foundation.TimeSpan ringTimeout);

    VoipPhoneCall RequestNewOutgoingCall(
      string context,
      string contactName,
      string serviceName,
      VoipPhoneCallMedia media);

    void NotifyMuted();

    void NotifyUnmuted();

    VoipPhoneCall RequestOutgoingUpgradeToVideoCall(
      Guid callUpgradeGuid,
      string context,
      string contactName,
      string serviceName);

    VoipPhoneCall RequestIncomingUpgradeToVideoCall(
      string context,
      string contactName,
      string contactNumber,
      global::Windows.Foundation.Uri contactImage,
      string serviceName,
      global::Windows.Foundation.Uri brandingImage,
      string callDetails,
      global::Windows.Foundation.Uri ringtone,
      global::Windows.Foundation.TimeSpan ringTimeout);

    void TerminateCellularCall(Guid callUpgradeGuid);

    void CancelUpgrade(Guid callUpgradeGuid);
  }
}
