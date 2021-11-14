// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.IVoipCallCoordinatorWithUpgrade
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (VoipCallCoordinator))]
  [Guid(1634913468, 28113, 20366, 185, 56, 83, 147, 83, 12, 49, 202)]
  internal interface IVoipCallCoordinatorWithUpgrade
  {
    void RequestOutgoingUpgradeToVideoCall(
      Guid callUpgradeGuid,
      string context,
      string contactName,
      string serviceName,
      out VoipPhoneCall call);

    void RequestIncomingUpgradeToVideoCall(
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
  }
}
