// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandNetworkRegistrationStateChangeTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandNetworkRegistrationStateChangeTriggerDetails : 
    IMobileBroadbandNetworkRegistrationStateChangeTriggerDetails
  {
    public extern IVectorView<MobileBroadbandNetworkRegistrationStateChange> NetworkRegistrationStateChanges { [MethodImpl] get; }
  }
}
