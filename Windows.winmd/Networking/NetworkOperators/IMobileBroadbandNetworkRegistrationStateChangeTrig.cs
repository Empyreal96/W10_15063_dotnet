// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandNetworkRegistrationStateChangeTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(2299747583, 10424, 18090, 177, 55, 28, 75, 15, 33, 237, 254)]
  [ExclusiveTo(typeof (MobileBroadbandNetworkRegistrationStateChangeTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandNetworkRegistrationStateChangeTriggerDetails
  {
    IVectorView<MobileBroadbandNetworkRegistrationStateChange> NetworkRegistrationStateChanges { get; }
  }
}
