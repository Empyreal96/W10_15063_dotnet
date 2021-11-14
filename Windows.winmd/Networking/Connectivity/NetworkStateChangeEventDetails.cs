// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkStateChangeEventDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class NetworkStateChangeEventDetails : 
    INetworkStateChangeEventDetails,
    INetworkStateChangeEventDetails2
  {
    public extern bool HasNewInternetConnectionProfile { [MethodImpl] get; }

    public extern bool HasNewConnectionCost { [MethodImpl] get; }

    public extern bool HasNewNetworkConnectivityLevel { [MethodImpl] get; }

    public extern bool HasNewDomainConnectivityLevel { [MethodImpl] get; }

    public extern bool HasNewHostNameList { [MethodImpl] get; }

    public extern bool HasNewWwanRegistrationState { [MethodImpl] get; }

    public extern bool HasNewTetheringOperationalState { [MethodImpl] get; }

    public extern bool HasNewTetheringClientCount { [MethodImpl] get; }
  }
}
