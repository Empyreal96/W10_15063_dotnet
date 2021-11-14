// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandNetwork
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class MobileBroadbandNetwork : IMobileBroadbandNetwork, IMobileBroadbandNetwork2
  {
    public extern NetworkAdapter NetworkAdapter { [MethodImpl] get; }

    public extern NetworkRegistrationState NetworkRegistrationState { [MethodImpl] get; }

    public extern uint RegistrationNetworkError { [MethodImpl] get; }

    public extern uint PacketAttachNetworkError { [MethodImpl] get; }

    public extern uint ActivationNetworkError { [MethodImpl] get; }

    public extern string AccessPointName { [MethodImpl] get; }

    public extern DataClasses RegisteredDataClass { [MethodImpl] get; }

    public extern string RegisteredProviderId { [MethodImpl] get; }

    public extern string RegisteredProviderName { [MethodImpl] get; }

    [MethodImpl]
    public extern void ShowConnectionUI();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetVoiceCallSupportAsync();

    public extern IVectorView<MobileBroadbandUiccApp> RegistrationUiccApps { [MethodImpl] get; }
  }
}
