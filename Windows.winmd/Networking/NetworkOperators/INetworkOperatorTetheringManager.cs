// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (NetworkOperatorTetheringManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3562704288, 3718, 19864, 139, 164, 221, 112, 212, 183, 100, 211)]
  internal interface INetworkOperatorTetheringManager
  {
    uint MaxClientCount { get; }

    uint ClientCount { get; }

    TetheringOperationalState TetheringOperationalState { get; }

    NetworkOperatorTetheringAccessPointConfiguration GetCurrentAccessPointConfiguration();

    IAsyncAction ConfigureAccessPointAsync(
      NetworkOperatorTetheringAccessPointConfiguration configuration);

    [RemoteAsync]
    IAsyncOperation<NetworkOperatorTetheringOperationResult> StartTetheringAsync();

    [RemoteAsync]
    IAsyncOperation<NetworkOperatorTetheringOperationResult> StopTetheringAsync();
  }
}
