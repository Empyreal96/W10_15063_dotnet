// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.VoipCallCoordinator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [Static(typeof (IVoipCallCoordinatorStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class VoipCallCoordinator : 
    IVoipCallCoordinator,
    IVoipCallCoordinatorWithUpgrade,
    IVoipOperationsManager,
    IVoipCallCoordinatorWithAppDeterminedUpgrade
  {
    public extern event TypedEventHandler<VoipCallCoordinator, MuteChangeEventArgs> MuteRequested;

    public extern event TypedEventHandler<VoipCallCoordinator, MuteChangeEventArgs> UnmuteRequested;

    [MethodImpl]
    public extern void RequestNewIncomingCall(
      string context,
      string contactName,
      string contactNumber,
      global::Windows.Foundation.Uri contactImage,
      string serviceName,
      global::Windows.Foundation.Uri brandingImage,
      string callDetails,
      global::Windows.Foundation.Uri ringtone,
      VoipCallMedia media,
      global::Windows.Foundation.TimeSpan ringTimeout,
      out VoipPhoneCall call);

    [MethodImpl]
    public extern void RequestNewOutgoingCall(
      string context,
      string contactName,
      string serviceName,
      VoipCallMedia media,
      out VoipPhoneCall call);

    [MethodImpl]
    public extern void NotifyMuted();

    [MethodImpl]
    public extern void NotifyUnmuted();

    [MethodImpl]
    public extern void RequestOutgoingUpgradeToVideoCall(
      Guid callUpgradeGuid,
      string context,
      string contactName,
      string serviceName,
      out VoipPhoneCall call);

    [MethodImpl]
    public extern void RequestIncomingUpgradeToVideoCall(
      string context,
      string contactName,
      string contactNumber,
      global::Windows.Foundation.Uri contactImage,
      string serviceName,
      global::Windows.Foundation.Uri brandingImage,
      string callDetails,
      global::Windows.Foundation.Uri ringtone,
      global::Windows.Foundation.TimeSpan ringTimeout,
      out VoipPhoneCall call);

    [MethodImpl]
    public extern IVoipOperation GetNextOperation();

    [MethodImpl]
    public extern void ConfirmNonSeamlessUpgrade(Guid callUpgradeGuid);

    [MethodImpl]
    public extern void CancelUpgrade(Guid callUpgradeGuid);

    [MethodImpl]
    public static extern VoipCallCoordinator GetDefault();
  }
}
