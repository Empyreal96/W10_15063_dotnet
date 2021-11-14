// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandNetwork
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandNetwork))]
  [Guid(3412300428, 777, 19638, 168, 193, 106, 90, 60, 142, 31, 246)]
  internal interface IMobileBroadbandNetwork
  {
    NetworkAdapter NetworkAdapter { get; }

    NetworkRegistrationState NetworkRegistrationState { get; }

    uint RegistrationNetworkError { get; }

    uint PacketAttachNetworkError { get; }

    uint ActivationNetworkError { get; }

    string AccessPointName { get; }

    DataClasses RegisteredDataClass { get; }

    string RegisteredProviderId { get; }

    string RegisteredProviderName { get; }

    void ShowConnectionUI();
  }
}
