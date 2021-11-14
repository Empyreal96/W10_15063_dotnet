// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkStateChangeEventDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(520942387, 55206, 17629, 164, 233, 104, 124, 71, 107, 144, 61)]
  [ExclusiveTo(typeof (NetworkStateChangeEventDetails))]
  internal interface INetworkStateChangeEventDetails
  {
    bool HasNewInternetConnectionProfile { get; }

    bool HasNewConnectionCost { get; }

    bool HasNewNetworkConnectivityLevel { get; }

    bool HasNewDomainConnectivityLevel { get; }

    bool HasNewHostNameList { get; }

    bool HasNewWwanRegistrationState { get; }
  }
}
