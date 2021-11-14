// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager
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
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (INetworkOperatorTetheringManagerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (INetworkOperatorTetheringManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (INetworkOperatorTetheringManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class NetworkOperatorTetheringManager : 
    INetworkOperatorTetheringManager,
    INetworkOperatorTetheringClientManager
  {
    public extern uint MaxClientCount { [MethodImpl] get; }

    public extern uint ClientCount { [MethodImpl] get; }

    public extern TetheringOperationalState TetheringOperationalState { [MethodImpl] get; }

    [MethodImpl]
    public extern NetworkOperatorTetheringAccessPointConfiguration GetCurrentAccessPointConfiguration();

    [MethodImpl]
    public extern IAsyncAction ConfigureAccessPointAsync(
      NetworkOperatorTetheringAccessPointConfiguration configuration);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<NetworkOperatorTetheringOperationResult> StartTetheringAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<NetworkOperatorTetheringOperationResult> StopTetheringAsync();

    [MethodImpl]
    public extern IVectorView<NetworkOperatorTetheringClient> GetTetheringClients();

    [Overload("CreateFromConnectionProfileWithTargetAdapter")]
    [MethodImpl]
    public static extern NetworkOperatorTetheringManager CreateFromConnectionProfile(
      ConnectionProfile profile,
      NetworkAdapter adapter);

    [MethodImpl]
    public static extern TetheringCapability GetTetheringCapabilityFromConnectionProfile(
      ConnectionProfile profile);

    [Overload("CreateFromConnectionProfile")]
    [MethodImpl]
    public static extern NetworkOperatorTetheringManager CreateFromConnectionProfile(
      ConnectionProfile profile);

    [MethodImpl]
    public static extern TetheringCapability GetTetheringCapability(
      string networkAccountId);

    [MethodImpl]
    public static extern NetworkOperatorTetheringManager CreateFromNetworkAccountId(
      string networkAccountId);
  }
}
