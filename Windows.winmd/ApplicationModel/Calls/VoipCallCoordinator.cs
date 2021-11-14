// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.VoipCallCoordinator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Static(typeof (IVoipCallCoordinatorStatics), 65536, "Windows.ApplicationModel.Calls.CallsVoipContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  public sealed class VoipCallCoordinator : IVoipCallCoordinator
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VoipPhoneCallResourceReservationStatus> ReserveCallResourcesAsync(
      string taskEntryPoint);

    public extern event TypedEventHandler<VoipCallCoordinator, MuteChangeEventArgs> MuteStateChanged;

    [MethodImpl]
    public extern VoipPhoneCall RequestNewIncomingCall(
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

    [MethodImpl]
    public extern VoipPhoneCall RequestNewOutgoingCall(
      string context,
      string contactName,
      string serviceName,
      VoipPhoneCallMedia media);

    [MethodImpl]
    public extern void NotifyMuted();

    [MethodImpl]
    public extern void NotifyUnmuted();

    [MethodImpl]
    public extern VoipPhoneCall RequestOutgoingUpgradeToVideoCall(
      Guid callUpgradeGuid,
      string context,
      string contactName,
      string serviceName);

    [MethodImpl]
    public extern VoipPhoneCall RequestIncomingUpgradeToVideoCall(
      string context,
      string contactName,
      string contactNumber,
      global::Windows.Foundation.Uri contactImage,
      string serviceName,
      global::Windows.Foundation.Uri brandingImage,
      string callDetails,
      global::Windows.Foundation.Uri ringtone,
      global::Windows.Foundation.TimeSpan ringTimeout);

    [MethodImpl]
    public extern void TerminateCellularCall(Guid callUpgradeGuid);

    [MethodImpl]
    public extern void CancelUpgrade(Guid callUpgradeGuid);

    [MethodImpl]
    public static extern VoipCallCoordinator GetDefault();
  }
}
